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
		public event EventHandler DataChanged;
        protected virtual void OnDataChanged(EventArgs e)
        {
            DataChanged?.Invoke(this, e);
		}
		public event EventHandler CharIndexChanged;
        protected virtual void OnCharIndexChanged(EventArgs e)
        {
            CharIndexChanged?.Invoke(this, e);
		}
		#endregion
		// *******************************************************************************************

		#region Controls

		private ListBox m_CharInfo = null;
		public ListBox CharInfo
		{
			get { return m_CharInfo; }
			set
			{
				m_CharInfo = value;
				if(m_CharInfo!=null)
				{
					m_CharInfo.Items.Clear();
					m_CharInfo.Items.AddRange(GetCharInfo());
				}
			}
		}


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

		private RefrainValue m_PlayerName = null;
		public RefrainValue PlayerName
		{
			get { return m_PlayerName; }
			set
			{
				m_PlayerName = value;
				if(m_PlayerName != null)
				{
					m_PlayerName.Caption = "Player Name";
					m_PlayerName.ValueType = ValueType.STRING;
					m_PlayerName.ValueTarget = ValueTarget.ABS_POS;
					m_PlayerName.SetRefrainSaveFile(this);
					m_PlayerName.StringLength = 0x36;
					m_PlayerName.Offset = 0x20;
				}
			}
		}
		private RefrainValue m_CoinValue = null;
		public RefrainValue CoinValue
		{
			get { return m_CoinValue; }
			set
			{
				m_CoinValue = value;
				if(m_CoinValue != null)
				{
					m_CoinValue.Caption = "銀貨";
					m_CoinValue.ValueType = ValueType.INT;
					m_CoinValue.ValueTarget = ValueTarget.ABS_POS;
					m_CoinValue.Offset = 0x56;
					m_CoinValue.SetRefrainSaveFile(this);
				}
			}
		}
		
		private RefrainValue m_ManaValue = null;
		public RefrainValue ManaValue
		{
			get { return m_ManaValue; }
			set
			{
				m_ManaValue = value;
				if(m_ManaValue != null)
				{
					m_ManaValue.Caption = "Mana";
					m_ManaValue.ValueType = ValueType.INT;
					m_ManaValue.ValueTarget = ValueTarget.ABS_POS;
					m_ManaValue.Offset = 0x5E;
					m_ManaValue.SetRefrainSaveFile(this);
				}
			}
		}
		private RefrainValue m_KarumaValue = null;
		public RefrainValue KarumaValue
		{
			get { return m_KarumaValue; }
			set
			{
				m_KarumaValue = value;
				if(m_KarumaValue != null)
				{
					m_KarumaValue.Caption = "カルマ";
					m_KarumaValue.ValueType = ValueType.INT;
					m_KarumaValue.ValueTarget = ValueTarget.ABS_POS;
					m_KarumaValue.MaxValue = 100;
					m_KarumaValue.Offset = 0x62;
					m_KarumaValue.SetRefrainSaveFile(this);
				}
			}
		}

		// Char 
		private RefrainValue m_CharName = null;
		public RefrainValue CharNmae
		{
			get { return m_CharName; }
			set
			{
				m_CharName = value;
				if(m_CharName != null)
				{
					m_CharName.Caption = "NAME";
					m_CharName.ValueType = ValueType.STRING;
					m_CharName.ValueTarget = ValueTarget.CHAR_INDEX;
					m_CharName.Offset = 0x05;
					m_CharName.StringLength = 0x42;
					m_CharName.SetRefrainSaveFile(this);
				}
			}
		}
		private RefrainValue m_CharShortName = null;
		public RefrainValue CharShortNmae
		{
			get { return m_CharShortName; }
			set
			{
				m_CharShortName = value;
				if(m_CharShortName != null)
				{
					m_CharShortName.Caption = "SHORT NAME";
					m_CharShortName.ValueType = ValueType.STRING;
					m_CharShortName.ValueTarget = ValueTarget.CHAR_INDEX;
					m_CharShortName.Offset = 0x47;
					m_CharShortName.StringLength = 0x1E;
					m_CharShortName.SetRefrainSaveFile(this);
				}
			}
		}
		private RefrainValue m_CharFlavorText = null;
		public RefrainValue CharFlavorText
		{
			get { return m_CharFlavorText; }
			set
			{
				m_CharFlavorText = value;
				if(m_CharFlavorText != null)
				{
					m_CharFlavorText.Caption = "Flavor Text";
					m_CharFlavorText.ValueType = ValueType.STRING;
					m_CharFlavorText.ValueTarget = ValueTarget.CHAR_INDEX;
					m_CharFlavorText.Offset = 0x65;
					m_CharFlavorText.StringLength = 0xF6;
					m_CharFlavorText.SetRefrainSaveFile(this);
				}
			}
		}
		//Causal number
		private RefrainValue m_CausalNum = null;
		public RefrainValue CausalNum
		{
			get { return m_CausalNum; }
			set
			{
				m_CausalNum = value;
				if(m_CausalNum != null)
				{
					m_CausalNum.Caption = "因果数";
					m_CausalNum.ValueType = ValueType.INT;
					m_CausalNum.ValueTarget = ValueTarget.CHAR_INDEX;
					m_CausalNum.Offset = 0x16C;
					m_CausalNum.MaxValue = 99;
					m_CausalNum.SetRefrainSaveFile(this);
				}
			}
		}


		private RefrainValue m_EXP = null;
		public RefrainValue EXP
		{
			get { return m_EXP; }
			set
			{
				m_EXP = value;
				if(m_EXP != null)
				{
					m_EXP.Caption = "EXP";
					m_EXP.ValueType = ValueType.INT;
					m_EXP.ValueTarget = ValueTarget.CHAR_INDEX;
					m_EXP.SetRefrainSaveFile(this);
					m_EXP.Offset = 0x1cc;
				}
			}
		}
		private RefrainValue m_TotalEXP = null;
		public RefrainValue TotalEXP
		{
			get { return m_TotalEXP; }
			set
			{
				m_TotalEXP = value;
				if(m_TotalEXP != null)
				{
					m_TotalEXP.ValueType = ValueType.INT;
					m_TotalEXP.ValueTarget = ValueTarget.CHAR_INDEX;
					m_TotalEXP.SetRefrainSaveFile(this);
					m_TotalEXP.Offset = 0x1D4;
				}
			}
		}
		
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
			this.DataChanged += RefrainSaveFile_DataChanged;
			this.CharIndexChanged += RefrainSaveFile_DataChanged;
		}
		private void RefrainSaveFile_DataChanged(object sender, EventArgs e)
		{
			if (m_PlayerName != null) { m_PlayerName.GetValue(); }
			if (m_CoinValue != null) { m_CoinValue.GetValue(); }
			if (m_ManaValue != null) { m_ManaValue.GetValue(); }
			if (m_KarumaValue != null) { m_KarumaValue.GetValue(); }

			if (m_CharName != null) { m_CharName.GetValue(); }
			if (m_CharShortName != null) { m_CharShortName.GetValue(); }
			if (m_CharFlavorText != null) { m_CharFlavorText.GetValue(); }
			if (m_CausalNum != null) { m_CausalNum.GetValue(); }
			if (m_EXP != null) { m_EXP.GetValue(); }
			if (m_TotalEXP != null) { m_TotalEXP.GetValue(); }

			if(m_CharInfo !=null)
			{
				m_CharInfo.SuspendLayout();
				m_CharInfo.Items.Clear();
				m_CharInfo.Items.AddRange(GetCharInfo());
				m_CharInfo.ResumeLayout();
			}
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
			if (m_FilePath!="") p =  Path.GetDirectoryName(m_FilePath);

			if (Directory.Exists(p) == false)
			{
				p = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
			}
			dlg.InitialDirectory = p;
			dlg.FileName = Path.GetFileName(m_FilePath);

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
	}
}
