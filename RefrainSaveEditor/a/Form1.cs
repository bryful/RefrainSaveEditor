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
		SkillValue[] m_skills = new SkillValue[12];
		//-------------------------------------------------------------
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Form1()
		{
			InitializeComponent();

			m_skills[0] = vS0;
			m_skills[1] = vS1;
			m_skills[2] = vS2;
			m_skills[3] = vS3;
			m_skills[4] = vS4;
			m_skills[5] = vS5;
			m_skills[6] = vS6;
			m_skills[7] = vS7;
			m_skills[8] = vS8;
			m_skills[9] = vS9;
			m_skills[10] = vS10;
			m_skills[11] = vS11;

			refrainSaveFile1.SetSkils(m_skills);

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

		

		

		
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			refrainSaveFile1.SaveFile();
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			refrainSaveFile1.SaveFileDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int sel = cmbTarget.SelectedIndex;
			if (sel < 0) return;
			int[] pat = new int[12];
			switch (sel)
			{
				case 0://あす
					pat[0] = (int)SKILLS.古塔乱;
					pat[1] = (int)SKILLS.古塔槍術師範;
					pat[2] = (int)SKILLS.不屈の精神;
					pat[3] = (int)SKILLS.腕自慢;
					pat[4] = (int)SKILLS.ドナムマスター;
					pat[5] = (int)SKILLS.スピード自慢;
					pat[6] = (int)SKILLS.速攻術;
					pat[7] = (int)SKILLS.黒切断;
					pat[8] = (int)SKILLS.全治癒術;
					pat[9] = (int)SKILLS.誘惑の魔眼;
					pat[10] = (int)SKILLS.気功術;
					pat[11] = (int)SKILLS.硬化術;
					break;
				case 1://しのぶし
					pat[0] = (int)SKILLS.二刀一流;
					pat[1] = (int)SKILLS.刀剣術師範;
					pat[2] = (int)SKILLS.器用さ自慢;
					pat[3] = (int)SKILLS.不屈の精神;
					pat[4] = (int)SKILLS.ドナムマスター;
					pat[5] = (int)SKILLS.スピード自慢;
					pat[6] = (int)SKILLS.速攻術;
					pat[7] = (int)SKILLS.黒切断;
					pat[8] = (int)SKILLS.全治癒術;
					pat[9] = (int)SKILLS.誘惑の魔眼;
					pat[10] = (int)SKILLS.気功術;
					pat[11] = (int)SKILLS.硬化術;
					break;
				case 2://シアトリカルスター
					pat[0] = (int)SKILLS.癒演舞の鐘;
					pat[1] = (int)SKILLS.呪詛の鐘;
					pat[2] = (int)SKILLS.呪鐘術師範;
					pat[3] = (int)SKILLS.不屈の精神;
					pat[4] = (int)SKILLS.ドナムマスター;
					pat[5] = (int)SKILLS.スピード自慢;
					pat[6] = (int)SKILLS.速攻術;
					pat[7] = (int)SKILLS.黒切断;
					pat[8] = (int)SKILLS.全治癒術;
					pat[9] = (int)SKILLS.誘惑の魔眼;
					pat[10] = (int)SKILLS.気功術;
					pat[11] = (int)SKILLS.硬化術;
					break;
				case 3://マージナルメイズ
					pat[0] = (int)SKILLS.ドナムマスター;
					pat[1] = (int)SKILLS.ドナム効率化論;
					pat[2] = (int)SKILLS.ドナム力自慢;
					pat[3] = (int)SKILLS.月蝕;
					pat[4] = (int)SKILLS.蝕台術師範;
					pat[5] = (int)SKILLS.不屈の精神;
					pat[6] = (int)SKILLS.スピード自慢;
					pat[7] = (int)SKILLS.速攻術;
					pat[8] = (int)SKILLS.黒切断;
					pat[9] = (int)SKILLS.全治癒術;
					pat[10] = (int)SKILLS.誘惑の魔眼;
					pat[11] = (int)SKILLS.硬化術;
					break;
				case 4://ピアフォートレス
					pat[0] = (int)SKILLS.篭城盾;
					pat[1] = (int)SKILLS.守るの心;
					pat[2] = (int)SKILLS.亀甲の構え;
					pat[3] = (int)SKILLS.戦術甲術師範;
					pat[4] = (int)SKILLS.鉄壁;
					pat[5] = (int)SKILLS.ドナムマスター;
					pat[6] = (int)SKILLS.不屈の精神;
					pat[7] = (int)SKILLS.スピード自慢;
					pat[8] = (int)SKILLS.速攻術;
					pat[9] = (int)SKILLS.全治癒術;
					pat[10] = (int)SKILLS.硬化術;
					pat[11] = (int)SKILLS.受け流し;
					break;
				case 5://マッドラプター
					pat[0] = (int)SKILLS.百花ノ狙撃手;
					pat[1] = (int)SKILLS.百花弓術師範;
					pat[2] = (int)SKILLS.スピード自慢;
					pat[3] = (int)SKILLS.速攻術;
					pat[4] = (int)SKILLS.百花の乱れ矢;
					pat[5] = (int)SKILLS.不屈の精神;
					pat[6] = (int)SKILLS.ドナムマスター;
					pat[7] = (int)SKILLS.黒切断;
					pat[8] = (int)SKILLS.全治癒術;
					pat[9] = (int)SKILLS.誘惑の魔眼;
					pat[10] = (int)SKILLS.気功術;
					pat[11] = (int)SKILLS.硬化術;
					break;
				case 6://ゴシックコッペリア
					pat[0] = (int)SKILLS.黒切断;
					pat[1] = (int)SKILLS.全治癒術;
					pat[2] = (int)SKILLS.誘惑の魔眼;
					pat[3] = (int)SKILLS.気功術;
					pat[4] = (int)SKILLS.鈍槌術師範;
					pat[5] = (int)SKILLS.硬化術;
					pat[6] = (int)SKILLS.ドナムマスター;
					pat[7] = (int)SKILLS.不屈の精神;
					pat[8] = (int)SKILLS.瞬速;
					pat[9] = (int)SKILLS.スピード自慢;
					pat[10] = (int)SKILLS.速攻術;
					pat[11] = (int)SKILLS.腕自慢;
					break;
				case 7://デモンリーパー
					pat[0] = (int)SKILLS.星嵐舞踏;
					pat[1] = (int)SKILLS.受け流し;
					pat[2] = (int)SKILLS.雄心勃勃たる構え;
					pat[3] = (int)SKILLS.星嵐鎌術師範;
					pat[4] = (int)SKILLS.瞬速;
					pat[5] = (int)SKILLS.ドナムマスター;
					pat[6] = (int)SKILLS.不屈の精神;
					pat[7] = (int)SKILLS.全治癒術;
					pat[8] = (int)SKILLS.誘惑の魔眼;
					pat[9] = (int)SKILLS.気功術;
					pat[10] = (int)SKILLS.スピード自慢;
					pat[11] = (int)SKILLS.速攻術;
					break;
				default:
					break;
			}

			for (int i=0;i<12;i++)
			{
				m_skills[i].SelectedIndex = pat[i];
			}
		}

		private void btnCheckExp_Click(object sender, EventArgs e)
		{
			refrainSaveFile1.ChkExp();
		}
	}
}
