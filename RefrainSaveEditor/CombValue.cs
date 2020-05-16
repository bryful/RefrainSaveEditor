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
	public enum TARGET_SIZE
	{
		INT = 4,
		SHORT = 2,
		BYTE = 1
	}

	public enum COMB_TYPE
	{
		NONE = 0,
		GENDER,
		FACET,
		STANCE,
		TYPE,
		HAND,
		PERSONAL,
		PERSONAL_URA,

	}

	public class CombValue : Control
	{
		readonly string[] ItemGender = new string[]
		{
			"男性",
			"女性",
			"性別不明"
		};
		readonly string[] ItemFacet = new string[]
		{
			"アステルナイト",
			"シノブシ",
			"シアトリカルスター",
			"マージナルメイズ",
			"ピアフォートレス",
			"マッドラプター",
			"ゴシックコッペリア",
			"デモンリーパー"
		};//stance
		readonly string[] ItemStance = new string[]
		{
			"スタンダード",
			"サニーサイド",
			"ムーンサイド"
		};//stance
		readonly string[] ItemType = new string[]
		{
			"ナチュラル",
			"フラット",
			"シャープ",
			"ダブルフラット",
			"ダブルシャープ"
		};//personality

		readonly string[] ItemHand = new string[]
		{
			"右手",
			"左手"
		};

		readonly string[] ItemPersonal = new string[]
		{
			"勇敢",
			"熱血漢",
			"純真無垢",
			"天真爛漫",
			"聡明",
			"ニヒル",
			"猪突猛進",
			"完全主義",
			"潔癖症",
			"へそまがり",
			"頑固",
			"気まぐれ",
			"陽気",
			"ほがらか",
			"情熱化",
			"楽天家",
			"高慢",
			"勝ち気",
			"わがまま",
			"きまじめ",
			"几帳面",
			"情け深い",
			"心配性",
			"しっかり者",
			"寂しがり",
			"根暗",
			"冷静",
			"自己中心",
			"悪戯好き",
			"助平",
			"強運ピエロ",
			"凡人"
		};//personality

		private COMB_TYPE m_CombType = COMB_TYPE.NONE;
		public COMB_TYPE CombType
		{
			get { return m_CombType; }
			set
			{
				m_CombType = value;
				m_Cmb.Items.Clear();
				m_Offset = 0;
				switch (m_CombType)
				{
					case COMB_TYPE.GENDER:
						m_Offset = 0x015B;
						Label.Text = "性別";
						m_TargetSize = TARGET_SIZE.INT;
						m_Cmb.Items.AddRange(ItemGender);
						break;
					case COMB_TYPE.FACET:
						Label.Text = "ファセット";
						m_Offset = 0x0160;
						m_TargetSize = TARGET_SIZE.INT;
						m_Cmb.Items.AddRange(ItemFacet);
						break;
					case COMB_TYPE.STANCE:
						Label.Text = "スタンス";
						m_Offset = 0x0164;
						m_TargetSize = TARGET_SIZE.INT;
						m_Cmb.Items.AddRange(ItemStance);
						break;
					case COMB_TYPE.TYPE:
						Label.Text = "成長タイプ";
						m_Offset = 0x0168;
						m_TargetSize = TARGET_SIZE.INT;
						m_Cmb.Items.AddRange(ItemType);
						break;
					case COMB_TYPE.HAND:
						Label.Text = "利き腕";
						m_Offset = 0x01FC;
						m_TargetSize = TARGET_SIZE.INT;
						m_Cmb.Items.AddRange(ItemHand);
						break;
					case COMB_TYPE.PERSONAL:
						Label.Text = "性格";
						m_Offset = 0x0170;
						m_TargetSize = TARGET_SIZE.BYTE;
						m_Cmb.Items.AddRange(ItemPersonal);
						break;
					case COMB_TYPE.PERSONAL_URA:
						Label.Text = "裏性格";
						m_Offset = 0x0171;
						m_TargetSize = TARGET_SIZE.BYTE;
						m_Cmb.Items.AddRange(ItemPersonal);
						break;
				}
			}
		}

		#region Event
		public event EventHandler ValueChanged;
		protected virtual void OnValueChanged(EventArgs e)
		{
			ValueChanged?.Invoke(this, e);
		}
		#endregion
		private RefrainSaveFile m_sv = null;
		public void SetRefrainSaveFile(RefrainSaveFile v)
		{
			m_sv = v;
		}
		public RefrainSaveFile RefrainSaveFile
		{
			get { return m_sv; }
			set
			{
				m_sv = value;
				if (m_sv != null)
				{
					m_sv.DataChanged += M_sv_DataChanged;
					m_sv.CharIndexChanged += M_sv_DataChanged;
				}
			}
		}

		private void M_sv_DataChanged(object sender, EventArgs e)
		{
			if (m_sv != null) GetValue();
		}

		private int m_Offset = 0;
		public int Offset
		{
			get { return m_Offset; }
		}

		private TARGET_SIZE m_TargetSize = TARGET_SIZE.INT;
		public TARGET_SIZE TargetSize
		{
			get { return m_TargetSize; }
		}

		private bool m_IsWrite = true;
		public bool IsWrite
		{
			get { return m_IsWrite; }
			set { m_IsWrite = value; }
		}
		public int CaptionWidth
		{
			get { return Label.Width; }
			set { Label.Width = value; }
		}

		private ComboBox m_Cmb = new ComboBox();

		private Label Label = new Label();
		private FlowLayoutPanel fl = new FlowLayoutPanel();

		public CombValue()
		{
			this.Size = new Size(200, 22);
			this.Padding = new Padding(0);
			this.Margin = new Padding(0);
			this.MinimumSize = new Size(50, 22);
			this.MaximumSize = new Size(500, 22);

			fl.Size = new Size(200, 22);
			fl.Padding = new Padding(0);
			fl.Margin = new Padding(0);
			this.Controls.Add(fl);

			Label.AutoSize = false;
			Label.Size = new Size(80, 22);
			Label.Padding = new Padding(0);
			Label.Margin = new Padding(0);
			Label.TextAlign = ContentAlignment.MiddleRight;
	

			m_Cmb.Size = new Size(120, 22);
			m_Cmb.DropDownStyle = ComboBoxStyle.DropDownList;
			m_Cmb.Padding = new Padding(0);
			m_Cmb.Margin = new Padding(0);
			m_Cmb.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
			m_Cmb.Items.Clear();

			fl.Controls.Add(Label);
			fl.Controls.Add(m_Cmb);

			m_Cmb.SelectedIndexChanged += M_Cmb_SelectedIndexChanged;
		}
		public string Caption
		{
			get { return Label.Text; }
		}
		// ******************************
		private bool refFlag = false;
		private void M_Cmb_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (refFlag == true) return;
			SetValue();
			OnValueChanged(new EventArgs());

		}
		public int SelectedIndex
		{
			get { return m_Cmb.SelectedIndex; }
			set
			{
				int v = value;
				if (v >= m_Cmb.Items.Count) v = m_Cmb.Items.Count -1;

				if (m_Cmb.SelectedIndex != v)
				{
					m_Cmb.SelectedIndex = v;
				}

			}
		}
		// *******************************************************************
		public void GetValue()
		{
			if ( (m_sv == null)||(m_sv.IsEnabled == false)||(m_sv.CharIndex<0))
			{
				refFlag = true;
				SelectedIndex = 0;
				refFlag = false;
				return;
			}
			byte [] ret = new byte[0];
			int idx = 0;
			switch (m_TargetSize)
			{
				case TARGET_SIZE.INT:
					ret = m_sv.GetCharData(m_Offset, 4);
					idx = (int)((int)ret[0] + ((int)ret[1] << 8) + ((int)ret[2] << 16) + ((int)ret[3] << 24));
					break;
				case TARGET_SIZE.SHORT:
					ret = m_sv.GetCharData(m_Offset, 2);
					idx = (int)((int)ret[0] + ((int)ret[1] << 8));
					break;
				case TARGET_SIZE.BYTE:
					ret = m_sv.GetCharData(m_Offset, 1);
					idx = (int)ret[0];
					break;

			}
			refFlag = true;
			SelectedIndex = idx;
			refFlag = false;
		}
		// *******************************************************************
		private void SetValue()
		{
			if (m_IsWrite == false) return;
			if ((m_sv == null)||(m_sv.IsEnabled==false)) return;
			byte[] ret = new byte[0];

			int it = m_Cmb.SelectedIndex;
			if (it < 0) it = 0;

			switch (m_TargetSize)
			{
				case TARGET_SIZE.INT:
					ret = new byte[4];
					ret[0] = (byte)(it & 0xFF);
					ret[1] = (byte)((it>>8) & 0xFF);
					ret[2] = (byte)((it>>16) & 0xFF);
					ret[3] = (byte)((it>>24) & 0xFF);
					break;
				case TARGET_SIZE.SHORT:
					ret = new byte[2];
					ret[0] = (byte)(it & 0xFF);
					ret[1] = (byte)((it>>8) & 0xFF);
					break;
				case TARGET_SIZE.BYTE:
					ret = new byte[1];
					ret[0] = (byte)(it & 0xFF);
					break;
			}

			m_sv.SetCharData(m_Offset, ret);
		}
	}
}
