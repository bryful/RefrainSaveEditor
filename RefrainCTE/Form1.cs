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

namespace RefrainCTE
{
	public partial class Form1 : Form
	{
		private string m_FilePath = "";
		int[] offsetTable = new int[] { 0, 0x08, 0x0c, 0x50 };
		NumericUpDown[] nums = new NumericUpDown[4];
		public Form1()
		{
			InitializeComponent();
			nums[0] = numMana;
			nums[1] = numKARUMA;
			nums[2] = numRF;
			nums[3] = numCO;
			nums[0].Tag = 0;
			nums[1].Tag = 1;
			nums[2].Tag = 2;
			nums[3].Tag = 3;

			for (int i = 0; i < 4; i++) {
				nums[i].ValueChanged += Form1_ValueChanged;
				nums[i].Minimum = -0x99999999;
				nums[i].Maximum = 0x99999999;
				                  //0A43C3F0
			}
		}
		private bool refFlag = false;
		private void Form1_ValueChanged(object sender, EventArgs e)
		{
			if (refFlag == true) return;
			refFlag = true;
			int tag = (int)((NumericUpDown)sender).Tag;
			int v = (int)((NumericUpDown)sender).Value;
			switch (tag)
			{
				case 0:
					nums[1].Value = v - offsetTable[0] + offsetTable[1];
					nums[2].Value = v - offsetTable[0] + offsetTable[2];
					nums[3].Value = v - offsetTable[0] + offsetTable[3];
					break;
				case 1:
					nums[0].Value = v - offsetTable[1] + offsetTable[0];
					nums[2].Value = v - offsetTable[1] + offsetTable[2];
					nums[3].Value = v - offsetTable[1] + offsetTable[3];
					break;
				case 2:
					nums[0].Value = v - offsetTable[2] + offsetTable[0];
					nums[1].Value = v - offsetTable[2] + offsetTable[1];
					nums[3].Value = v - offsetTable[2] + offsetTable[3];
					break;
				case 3:
					nums[0].Value = v - offsetTable[3] + offsetTable[0];
					nums[1].Value = v - offsetTable[3] + offsetTable[1];
					nums[2].Value = v - offsetTable[3] + offsetTable[2];
					break;

			}



			refFlag = false;
		}
		private string ExportStr()
		{
			string ret = Properties.Resources.String1;

			int v = (int)nums[0].Value;
			ret = ret.Replace("$MANA", v.ToString("X8"));
			v = (int)nums[1].Value;
			ret = ret.Replace("$KARUMA", v.ToString("X8"));
			v = (int)nums[2].Value;
			ret = ret.Replace("$RF", v.ToString("X8"));
			v = (int)nums[3].Value;
			ret = ret.Replace("$CarryOver", v.ToString("X8"));
			return ret;

		}


		private void btnExport_Click(object sender, EventArgs e)
		{

			SaveFileDialog dlg = new SaveFileDialog();
			if(File.Exists(m_FilePath) == false)
			{
				dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
				dlg.FileName = "foo.CT";
			}
			else
			{
				dlg.InitialDirectory = Path.GetDirectoryName(m_FilePath);
				dlg.FileName = Path.GetFileName(m_FilePath);
			}
			dlg.DefaultExt = "CT";
			if (dlg.ShowDialog()==DialogResult.OK)
			{
				StreamWriter sw = new StreamWriter(dlg.FileName);
				try
				{
					sw.Write(ExportStr());
					m_FilePath = dlg.FileName;
				}
				finally
				{
					sw.Close();
				}
			}
		}
	}
}
