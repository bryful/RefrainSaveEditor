using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using BRY;
namespace RefrainSaveEditor
{
	public partial class RefrainSaveFile :Component
	{
		// *******************************************************************************************
		#region Event
		public bool NoEvent = false;

		public event EventHandler DataChanged;
        protected virtual void OnDataChanged(EventArgs e)
        {
			if (NoEvent == true) return;
            DataChanged?.Invoke(this, e);
		}
		public void Refresh()
		{
			OnDataChanged(new EventArgs());
		}
		public event EventHandler CharIndexChanged;
        protected virtual void OnCharIndexChanged(EventArgs e)
        {
            CharIndexChanged?.Invoke(this, e);
		}
		#endregion
		// *******************************************************************************************

		#region Controls

		private ListBox m_CharList = null;
		public ListBox CharList
		{
			get { return m_CharList; }
			set
			{
				m_CharList = value;
				if(m_CharList!=null)
				{
					if(m_Data.Length>0)
					{
						m_CharList.Items.Clear();
						m_CharList.Items.AddRange(CharNames());
					}
					m_CharList.SelectedIndexChanged += M_CharList_SelectedIndexChanged;
				}
			}
		}
		private void M_CharList_SelectedIndexChanged(object sender, EventArgs e)
		{
			CharIndex =  m_CharList.SelectedIndex;
		}


		public void ChkExp()
		{
			string[] names = CharNames();
			if (names.Length <= 0) return;
			for (int i=0; i<names.Length;i++)
			{
				int pos = GetCharAdr(i);
				byte[] v = GetData(pos + 0x1cc, 4);
				int exp = (int)v[0] + ((int)v[1] << 8) + ((int)v[2] << 16) + ((int)v[3] << 24);
				v = GetData(pos + 0x1D4, 4);
				int texp = (int)v[0] + ((int)v[1] << 8) + ((int)v[2] << 16) + ((int)v[3] << 24);
				if ((exp<0)||(texp<0))
				{
					v = new byte[4];
					v[0] = v[1] = v[2] = v[3] = 0;
					SetData(pos + 0x1cc, v);
					SetData(pos + 0x1D4, v);
				}
			}
			OnDataChanged(new EventArgs());
		}
		/*
		private SkillValue[] m_skills = new SkillValue[12];
		public void SetSkils(SkillValue [] ss)
		{
			if ((ss==null)||(ss.Length!=12))
			{
				for (int i = 0; i < 12; i++) m_skills[i] = null;
				return;
			}
			for (int i = 0; i < 12; i++)
			{
				m_skills[i] = ss[i];
				m_skills[i].Offset = 0x176 + i*4;
				m_skills[i].SetRefrainSaveFile(this);
			}
		}
		*/
		#endregion

		#region FilePath
		private string m_FilePath = "";
		public string FilePath
		{
			get { return m_FilePath; }
			set
			{
				if(LoadFile(value)==true)
				{
					m_FilePath = value;

				}
				else
				{
					InitData(0);
					m_FilePath = "";

				}
			}
		}
		#endregion

		// *******************************************************************************************
	
		// *******************************************************************************************
		public RefrainSaveFile()		
		{
			NoEvent = true;
			//SetSkils(null);
			this.DataChanged += RefrainSaveFile_DataChanged;
			this.CharIndexChanged += RefrainSaveFile_DataChanged;
			NoEvent = false;

		}
		private void RefrainSaveFile_DataChanged(object sender, EventArgs e)
		{
			if (NoEvent == true) return;
			/*
			for (int i=0; i<12;i++)
			{
				if (m_skills[i] != null) m_skills[i].GetValue();
			}
			*/
		}

		 // *******************************************************************************************
        public void InitData(int sz = 0)
        {
            Array.Resize(ref m_Data, sz);
			if (m_Data.Length > 0)
			{
				for (int i = 0; i < m_Data.Length; i++)
				{
					m_Data[i] = 0;
				}
			}
        }
		 // *******************************************************************************************
        public bool LoadFile(string p)
        {
            bool ret = false;
			if (File.Exists(p) == false) return ret;
            using (FileStream fs = new FileStream(p, FileMode.Open))
            {
                int sz1 = (int)fs.Length;
                InitData(sz1);
                int sz2 =  fs.Read(m_Data, 0, sz1);

                ret = (sz1 == sz2);
				if(ret == true)
				{
					m_FilePath = p;
					if (m_CharList != null)
					{
						m_CharList.Items.Clear();
						m_CharList.Items.AddRange(CharNames());
					}

					OnDataChanged(new EventArgs());
				}
            }
            return ret;
        }
		 // *******************************************************************************************
		public bool LoadFileDialog()
		{
            bool ret = false;
			OpenFileDialog dlg = new OpenFileDialog();
			string p = "";
			string pn = "";
			if (m_FilePath != "")
			{
				p = Path.GetDirectoryName(m_FilePath);
				pn = Path.GetFileName(m_FilePath);
			}
			else
			{
				p = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
				pn = "Refrain.CT";
			}

			if (Directory.Exists(p) == false)
			{
				p = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
			}
			dlg.InitialDirectory = p;
			dlg.FileName = pn;
			dlg.DefaultExt = "dat";
			dlg.Filter = "*.dat|*.dat|*.*|*.*";

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				ret = LoadFile(dlg.FileName);
			}
			return ret;

		}
		 // *******************************************************************************************
		public bool SaveFile(string p)
        {
            bool ret = false;
            if (m_Data.Length <= 0) return ret;

            FileStream fs = new FileStream(p, System.IO.FileMode.Create, FileAccess.Write);
            try
            {
                fs.Write(m_Data, 0, m_Data.Length);
                ret = true;
            }
            catch
            {
                ret = false;
            }
            finally
            {
                fs.Close();
            }
			if (ret == true)
			{
				m_FilePath = p;
			}

            return ret;
        }
		// *******************************************************************************************
		public bool SaveFileDialog()
		{
            bool ret = false;
			SaveFileDialog dlg = new SaveFileDialog();
			string p = "";
			string pn = "";
			if (m_FilePath != "")
			{
				p = Path.GetDirectoryName(m_FilePath);
				pn = Path.GetFileName(m_FilePath);
			}
			else
			{
				p = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
				pn = "Refrain.CT";
			}

			if (Directory.Exists(p) == false)
			{
				p = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
			}
			dlg.InitialDirectory = p;
			dlg.FileName = pn;
			dlg.DefaultExt = "dat";
			dlg.Filter = "*.dat|*.dat|*.*|*.*";

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				ret = SaveFile(dlg.FileName);
			}
			return ret;

		}
		public bool SaveFile()
		{
			bool ret = false;
			if (m_FilePath == "")
			{
				ret = SaveFileDialog();
			}
			else
			{
				if (File.Exists(m_FilePath) == true)
				{
					ret = SaveFile(m_FilePath);
				}
				else
				{
					ret = SaveFileDialog();
				}
			}
			return ret;
		}
	}
}
