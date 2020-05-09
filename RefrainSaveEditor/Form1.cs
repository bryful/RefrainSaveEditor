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

using Codeplex.Data;
/// <summary>
/// 基本となるアプリのスケルトン
/// </summary>
namespace RefrainSaveEditor
{
	public partial class Form1 : Form
	{
		//-------------------------------------------------------------
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Form1()
		{
			InitializeComponent();
		}
		/// <summary>
		/// コントロールの初期化はこっちでやる
		/// </summary>
		protected override void InitLayout()
		{
			base.InitLayout();
		}
		//-------------------------------------------------------------
		/// <summary>
		/// フォーム作成時に呼ばれる
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{
			//設定ファイルの読み込み
			JsonPref pref = new JsonPref();
			if (pref.Load())
			{
				bool ok = false;
				Size sz = pref.GetSize("Size", out ok);
				if (ok) this.Size = sz;
				Point p = pref.GetPoint("Point", out ok);
				if (ok) this.Location = p;
				string fp = pref.GetString("FilePath", out ok);
				if (ok)
				{
					refrainSaveFile1.FilePath = fp;
					this.Text = refrainSaveFile1.FilePath;
				}
			}
		}
		//-------------------------------------------------------------
		/// <summary>
		/// フォームが閉じられた時
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			//設定ファイルの保存
			JsonPref pref = new JsonPref();
			pref.SetSize("Size", this.Size);
			pref.SetPoint("Point", this.Location);

			pref.SetString("FilePath", refrainSaveFile1.FilePath);
			pref.Save();

		}
		//-------------------------------------------------------------
		/// <summary>
		/// ドラッグ＆ドロップの準備
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.All;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}
		/// <summary>
		/// ドラッグ＆ドロップの本体
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			//ここでは単純にファイルをリストアップするだけ
			GetCommand(files);
		}
		//-------------------------------------------------------------
		/// <summary>
		/// ダミー関数
		/// </summary>
		/// <param name="cmd"></param>
		public void GetCommand(string[] cmd)
		{
			if (cmd.Length > 0)
			{
				foreach (string s in cmd)
				{
					//listBox1.Items.Add(s);
				}
			}
		}
		/// <summary>
		/// メニューの終了
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		//-------------------------------------------------------------
		private void quitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AppInfoDialog.ShowAppInfoDialog();
		}
		private void button1_Click(object sender, EventArgs e)
		{

			JsonPref j = new JsonPref();

			int[] aaa = new int[] { 78, 9, 12 };
			double[] bbb = new double[] { 0.7, 0.01, 0.12 };
			string[] ccc = new string[] { "eee", "sfskjbF", "13" };
			j.SetIntArray("aa", aaa);
			j.SetDoubleArray("bb", bbb);
			j.SetStringArray("cc", ccc);

			MessageBox.Show(j.ToJson());

		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if ( refrainSaveFile1.LoadFileDialog()==true)
			{
				this.Text = refrainSaveFile1.FilePath;
			}
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			lbResult.Items.Clear();
			if (refrainSaveFile1.IsEnabled == false) return;
			int v = 0;
			int[] ret = new int[0]; 
			if (int.TryParse(tbTargetInt.Text,out v))
			{
				ret = refrainSaveFile1.FindInt(v);
				if(ret.Length>0)
				{
					string [] rets = new string[ret.Length];
					for (int i=0; i<ret.Length;i++)
					{
						rets[i] = "0x"+ ret[i].ToString("X4");
					}
					lbResult.Items.AddRange(rets);

				}

				


			}
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			lbResult.Items.Clear();
			if (refrainSaveFile1.IsEnabled == false) return;
			byte v = 0;
			int[] ret = new int[0]; 
			if (byte.TryParse(tbTargetByte.Text,out v))
			{
				ret = refrainSaveFile1.FindByte(v);
				if(ret.Length>0)
				{
					string [] rets = new string[ret.Length];
					for (int i=0; i<ret.Length;i++)
					{
						rets[i] = "0x"+ ret[i].ToString("X4");
					}
					lbResult.Items.AddRange(rets);

				}

				


			}
		}

		private void btnFinfShort_Click(object sender, EventArgs e)
		{
			lbResult.Items.Clear();
			if (refrainSaveFile1.IsEnabled == false) return;
			short v = 0;
			int[] ret = new int[0]; 
			if (short.TryParse(tbTargetByte.Text,out v))
			{
				ret = refrainSaveFile1.FindShort(v);
				if(ret.Length>0)
				{
					string [] rets = new string[ret.Length];
					for (int i=0; i<ret.Length;i++)
					{
						rets[i] = "0x"+ ret[i].ToString("X4");
					}
					lbResult.Items.AddRange(rets);

				}

				


			}
		}
	}
}
