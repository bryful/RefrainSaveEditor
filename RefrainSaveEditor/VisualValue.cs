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

namespace RefrainSaveEditor
{
	public enum VISUALS
	{
			NONE,
			アステルナイト男1,
			アステルナイト男2,
			アステルナイト男3,
			アステルナイト男4,
			アステルナイト女1,
			アステルナイト女2,
			アステルナイト女3,
			アステルナイト女4,
			シノブシ男1,
			シノブシ男2,
			シノブシ男3,
			シノブシ男4,
			シノブシ女1,
			シノブシ女2,
			シノブシ女3,
			シノブシ女4,
			シアトリカルスター男1,
			シアトリカルスター男2,
			シアトリカルスター男3,
			シアトリカルスター男4,
			シアトリカルスター女1,
			シアトリカルスター女2,
			シアトリカルスター女3,
			シアトリカルスター女4,
			マージナルメイズ男1,
			マージナルメイズ男2,
			マージナルメイズ男3,
			マージナルメイズ男4,
			マージナルメイズ女1,
			マージナルメイズ女2,
			マージナルメイズ女3,
			マージナルメイズ女4,
			ピアフォートレス男1,
			ピアフォートレス男2,
			ピアフォートレス男3,
			ピアフォートレス男4,
			ピアフォートレス女1,
			ピアフォートレス女2,
			ピアフォートレス女3,
			ピアフォートレス女4,
			マッドラプター男1,
			マッドラプター男2,
			マッドラプター男3,
			マッドラプター男4,
			マッドラプター女1,
			マッドラプター女2,
			マッドラプター女3,
			マッドラプター女4,
			ゴシックコッペリア1,
			ゴシックコッペリア2,
			ゴシックコッペリア3,
			ゴシックコッペリア4,
			デモンリーパー1,
			デモンリーパー2,
			デモンリーパー3,
			デモンリーパー4
	}
	public class VisualValue : Control
	{
		private readonly string[] VItms = new string[]
		{
			"なし",
			"アステルナイト男1",
			"アステルナイト男2",
			"アステルナイト男3",
			"アステルナイト男4",
			"アステルナイト女1",
			"アステルナイト女2",
			"アステルナイト女3",
			"アステルナイト女4",
			"シノブシ男1",
			"シノブシ男2",
			"シノブシ男3",
			"シノブシ男4",
			"シノブシ女1",
			"シノブシ女2",
			"シノブシ女3",
			"シノブシ女4",
			"シアトリカルスター男1",
			"シアトリカルスター男2",
			"シアトリカルスター男3",
			"シアトリカルスター男4",
			"シアトリカルスター女1",
			"シアトリカルスター女2",
			"シアトリカルスター女3",
			"シアトリカルスター女4",
			"マージナルメイズ男1",
			"マージナルメイズ男2",
			"マージナルメイズ男3",
			"マージナルメイズ男4",
			"マージナルメイズ女1",
			"マージナルメイズ女2",
			"マージナルメイズ女3",
			"マージナルメイズ女4",
			"ピアフォートレス男1",
			"ピアフォートレス男2",
			"ピアフォートレス男3",
			"ピアフォートレス男4",
			"ピアフォートレス女1",
			"ピアフォートレス女2",
			"ピアフォートレス女3",
			"ピアフォートレス女4",
			"マッドラプター男1",
			"マッドラプター男2",
			"マッドラプター男3",
			"マッドラプター男4",
			"マッドラプター女1",
			"マッドラプター女2",
			"マッドラプター女3",
			"マッドラプター女4",
			"ゴシックコッペリア1",
			"ゴシックコッペリア2",
			"ゴシックコッペリア3",
			"ゴシックコッペリア4",
			"デモンリーパー1",
			"デモンリーパー2",
			"デモンリーパー3",
			"デモンリーパー4"
		};

		#region Event
		public event EventHandler ValueChanged;
        protected virtual void OnValueChanged(EventArgs e)
        {
            ValueChanged?.Invoke(this, e);
		}
		#endregion

		private RefrainSaveFile m_sv = null;
		public RefrainSaveFile RefrainSaveFile
		{
			get { return m_sv; }
			set
			{
				m_sv = value;
				if (m_sv!=null)
				{
					m_sv.DataChanged += M_sv_DataChanged;
					m_sv.CharIndexChanged += M_sv_DataChanged;
				}
			}
		}

		private bool refFlag = false;
		private void M_sv_DataChanged(object sender, EventArgs e)
		{
			if (refFlag == true) return;
			if (m_sv != null)
			{
				GetValue();
				//OnValueChanged(new EventArgs());
			}
		}


		private int m_Offset = 0x15F;
		public int Offset { get { return m_Offset; } }
		private bool m_IsLocked = false;
		public bool IsLocked
		{
			get { return m_IsLocked; }
			set
			{
				if(m_IsLocked != value)
				{
					m_IsLocked = value;
					ComboBox.Enabled = !value;
				}
			}
		}




		private Label Label1 = new Label();
		private ComboBox ComboBox = new ComboBox();

		private FlowLayoutPanel fl = new FlowLayoutPanel();

		public string Caption
		{
			get { return Label1.Text; }
		}
		public int CaptionWidth
		{
			get { return Label1.Width; }
			set { Label1.Width = value; }
		}
		public int ValueWidth
		{
			get { return ComboBox.Width; }
			set { ComboBox.Width = value; }
		}
		// *******************************************************************
		// コンストラクタ
		// *******************************************************************
		public VisualValue()
		{
			this.Size = new Size(260, 27);
			this.Margin = new Padding(0);
			this.Padding = new Padding(0);

			fl.Size = this.Size;
			fl.Location = new Point(0, 0);
			fl.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
			fl.Margin = new Padding(0);
			fl.Padding = new Padding(0);

			this.Controls.Add(fl);


			Label1.AutoSize = false;
			Label1.Size = new Size(100, 27);
			Label1.Text = "ビジュアル";
			Label1.TextAlign = ContentAlignment.MiddleRight;
			Label1.Margin = new Padding(0);
			Label1.Padding = new Padding(0);



			ComboBox.Size = new Size(120, 27);
			ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			//TextBox1.ReadOnly = true;
			ComboBox.Margin = new Padding(0);
			ComboBox.Padding = new Padding(0);
			ComboBox.Items.AddRange(VItms);
			ComboBox.SelectedIndex = 0;
			ComboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

			fl.Controls.Add(Label1);
			fl.Controls.Add(ComboBox);
		}
		public int SelectedIndex
		{
			get { return ComboBox.SelectedIndex; }
			set
			{
				int v = value;
				if (v >= VItms.Length) v = VItms.Length - 1;

				if (ComboBox.SelectedIndex != v)
				{
					ComboBox.SelectedIndex = v;
				}

			}
		}
		// *******************************************************************
		private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (m_sv == null) return;
			if (refFlag == true) return;
			SetValue();
			OnValueChanged(new EventArgs());

		}

		// *******************************************************************
		public void GetValue()
		{
			int v = 0;
			if ( (m_sv == null)||(m_sv.IsEnabled == false)||(m_sv.CharIndex<0))
			{
				refFlag = true;
				SelectedIndex = v;
				refFlag = false;
				return;
			}
			byte [] ret = new byte[0];
			ret = m_sv.GetCharData(m_Offset, 1);
			v = (int)ret[0];
			if( SelectedIndex != v)
			{
				refFlag = true;
				SelectedIndex = v;
				refFlag = false;
			}
		}

		// *******************************************************************
		public void SetValue()
		{
			if (m_IsLocked == true) return;
			if ((m_sv == null)||(m_sv.IsEnabled==false)) return;
			int v = ComboBox.SelectedIndex;
			if (v < 0) v = 0;
			byte[] ret = new byte[1];
			ret[0] = (byte)v;
			m_sv.SetCharData(m_Offset, ret);
		}

		// *******************************************************************
	}
	
}
