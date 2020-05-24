using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrainSaveEditor
{
	public partial class FriendshipEditDialog : Form
	{
		private int m_Count = 0;
		private string[] m_Names = new string[0];
		private int[] m_Nums = new int[0];
		private NumBox []  m_NumBoxs = new NumBox [60];

		private RefrainSaveFile m_sv = new RefrainSaveFile();


		public void Clear()
		{
			m_Names = new string[0];
			m_Nums = new int[0];
			m_Count = 0;
			ClearNumBoxs();
		}
		public void ClearNumBoxs()
		{
			for (int i=0; i < m_NumBoxs.Length;i++)
			{
				m_NumBoxs[i].Caption = "";
				m_NumBoxs[i].Value = 0;
				m_NumBoxs[i].Visible = false;
			}
		}
		public void SetRefrainSaveFile ( RefrainSaveFile sv)
		{
			m_sv = sv;
			if( m_sv!=null)
			{
				m_sv.CharIndexChanged += M_sv_CharIndexChanged;
				GetStatus();
			}

		}
		

		private void M_sv_CharIndexChanged(object sender, EventArgs e)
		{
			GetStatus();
		}
		private void SetNumBox()
		{
			for (int i = 0; i<m_NumBoxs.Length; i++)
			{
				m_NumBoxs[i] = new NumBox();
				m_NumBoxs[i].Tag = (object)i;
				fl.Controls.Add(m_NumBoxs[i]);

			}
		}
		private void GetStatus()
		{
			Clear();
			if (m_sv == null) return;
			int cnt = 0;
			m_Names = m_sv.CharNames();
			cnt = m_Names.Length;

			int[] fs = m_sv.GetCharFriendship();
			

			for ( int i=0; i<cnt;i++)
			{
				m_NumBoxs[i].Caption = m_Names[i];
				m_NumBoxs[i].Value = fs[i];
				m_NumBoxs[i].Visible = true;
			}
			m_Count = cnt;
		}
		public FriendshipEditDialog()
		{
			InitializeComponent();
			SetNumBox();
		}
		public int[] Friendships
		{
			get
			{
				int[] ret = new int[0];
				if (m_sv == null) return ret;
				if (m_Count <= 0) return ret;
				ret = new int[m_Count];
				for (int i=0; i<m_Count;i++)
				{
					ret[i] = m_NumBoxs[i].Value;
				}
				return ret;
			}
		}

		private void btnALL_Click(object sender, EventArgs e)
		{
			if (m_Count <= 0) return;

			for ( int i=0; i<m_Count;i++)
			{
				m_NumBoxs[i].Value = numALL.Value;
			}
		}
	}
}
