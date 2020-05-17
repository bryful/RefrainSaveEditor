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
using Codeplex.Data;
using BRY;

namespace RefrainCTE
{
	public partial class Form1 : Form
	{
		private string m_FilePath = "";
		int[] offsetTable = new int[] { 0, 0x08, 0x0c, 0x50 };

		int[] CharOffsetTable = new int[]
		{
			+0x000,//0
			+0x004,//1
			+0x008,//2
			-0x1B4,//3
			-0x1B0,//4
			-0x1AC,//5
			-0x1A8,//6
			-0x1A4,//7
			-0x1A0,//8
			-0x19C,//性格(表) byte 9
			-0x19B,//裏の性格 byte 10
			-0x198,//ボイスタイプ 11
			-0x140,//アニマクラリティ 12
			-0x13F,//レベル 13
			-0x13C,//EXP
			-0x138,//総レベル
			-0x134,//TOTAL EXP
			-0x130,//最大HP
			-0x12C,//最大DP
			-0x128,//STR
			-0x124,//CON
			-0x120,//DMP
			-0x11C,//AGL
			-0x118,//DEX
			-0x114,//ERS
			-0x110,//LUC
			-0x10C,//利き手
			-0x0F0,//相手への友好度1人目
			-0x0EC,//相手への友好度2人目
			-0x0E8,//相手への友好度3人目
			-0x0E4,//相手への友好度4人目
		};
		string[] CharOffsetName = new string[]
		{
			"HP",
			"DP",
			"状態異常＆欠損回復",
			"性別",
			"ビジュアル",
			"ファセット",
			"スタンス",
			"成長タイプ",
			"因果数",
			"性格(表)",
			"裏の性格",
			"ボイスタイプ",
			"アニマクラリティ",
			"レベル",
			"EXP",
			"総レベル",
			"TOTAL EXP",
			"最大HP",
			"最大DP",
			"STR",
			"CON",
			"DMP",
			"AGL",
			"DEX",
			"ERS",
			"LUC",
			"利き手",
			"相手への友好度1人目",
			"相手への友好度2人目",
			"相手への友好度3人目",
			"相手への友好度4人目"
		};

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
		private string ExportCharStr()
		{
			string ret = Properties.Resources.String2;

			int HPAdr = numCharHP.Value;

			int cnt = CharOffsetTable.Length;

			string data = "";

			for ( int i=0; i<cnt;i++)
			{
				string s = Properties.Resources.String3;
				s = s.Replace("$INFO", CharOffsetName[i]);
				int a = HPAdr + CharOffsetTable[i];
				s = s.Replace("$ADR",  a.ToString("X8"));
				if ((i == 4) || (i == 9) || (i == 10)|| (i == 12)|| (i == 13))
				{
					s = s.Replace("$LENGTH", "1");
				}
				else
				{
					s = s.Replace("$LENGTH", "4");
				}
				data += s;

			}
			ret = ret.Replace("$DATA", data);
			return ret;

		}
		private void btnExport2_Click(object sender, EventArgs e)
		{

			SaveFileDialog dlg = new SaveFileDialog();
			if(File.Exists(m_FilePath) == false)
			{
				dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
				dlg.FileName = "foo2.CT";
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
					sw.Write(ExportCharStr());
					m_FilePath = dlg.FileName;
				}
				finally
				{
					sw.Close();
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//設定ファイルの読み込み
			JsonPref pref = new JsonPref();
			if (pref.Load())
			{
				bool ok = false;
				Point p = pref.GetPoint("Point", out ok);
				if (ok) this.Location = p;
			}
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
						//設定ファイルの保存
			JsonPref pref = new JsonPref();
			pref.SetPoint("Point", this.Location);
			pref.Save();
		}
	}
}
