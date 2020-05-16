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
	public enum ValueType
	{
		SBYTE = 0,
		BYTE,
		SHORT,
		USHORT,
		INT,
		UINT,
		STRING
	};
	public enum ValueTarget
	{
		CHAR_INDEX,
		ABS_POS
	}
	public enum ParamValueType
	{
		None,
		PlayerName,
		Coins,
		Mana,
		Karma,

		Num,
		NAME,
		SHORTNAME,
		FLAVERTEXT,
		VISUAL,
		CAUSAL,
		ANIMA,
		LEVEL,
		EXP,
		FULL_LEVEL,
		TOTAL_EXP,
		MAX_HP,
		MAX_DP,
		STR,
		CON,
		DMP,
		AGI,
		DEX,
		ERS,
		LUC,
		HP,
		DP
	}

	public class ParamValue : Control
	{
		private bool m_IsModif = false;
		public bool IsModif { get { return m_IsModif; } }

		private string[] m_Captions = new string[]
		{
			"",
			"PLAYER_NAME",
			"銀貨",
			"MANA",
			"KARMA",
			"No.",
			"NAME",
			"ShortName",
			"フレーバーテキスト",
			"ビジュアル",
			"因果数",
			"アニマクラリティ",
			"Level",
			"Exp",
			"総Level",
			"TotalExp",
			"最大HP",
			"最大DP",
			"STR",
			"CON",
			"DMP",
			"AGI",
			"DEX",
			"ERS",
			"LUC",
			"HP",
			"DP"
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

		private void M_sv_DataChanged(object sender, EventArgs e)
		{
			if (m_sv != null) GetValue();
		}

		private ParamValueType m_ParamValueType = ParamValueType.None;
		public ParamValueType ParamValueType
		{
			get { return m_ParamValueType; }
			set
			{

				if ((m_ParamValueType != value)||(m_ParamValueType== ParamValueType.None)||(value== ParamValueType.None))
				{
					m_ParamValueType = value;
					switch(m_ParamValueType)
					{
						case ParamValueType.None:
							#region None
							Label1.Text = m_Captions[(int)ParamValueType.None];
							m_ValueType = ValueType.INT;
							m_ValueTarget = ValueTarget.ABS_POS;
							m_Offset = 0;
							TextBox1.Text = "";
							IsLocked = true;
							break;
							#endregion
						case ParamValueType.PlayerName:
							#region PlayerName
							Label1.Text = m_Captions[(int)ParamValueType.PlayerName];
							m_ValueType = ValueType.STRING;
							m_ValueTarget = ValueTarget.ABS_POS;
							m_StringLength = 0x36;
							m_Offset = 0x20;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.Coins:
							#region Coins
							Label1.Text = m_Captions[(int)ParamValueType.Coins];
							m_ValueType = ValueType.INT;
							m_ValueTarget = ValueTarget.ABS_POS;
							m_Offset = 0x56;
							m_MaxValue = 9999999;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.Mana:
							#region Mana
							Label1.Text = m_Captions[(int)ParamValueType.Mana];
							m_ValueType = ValueType.INT;
							m_ValueTarget = ValueTarget.ABS_POS;
							m_Offset = 0x5E;
							m_MaxValue = 9999999;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.Karma:
							#region Karma
							Label1.Text = m_Captions[(int)ParamValueType.Karma];
							m_ValueType = ValueType.INT;
							m_ValueTarget = ValueTarget.ABS_POS;
							m_Offset = 0x62;
							m_MaxValue = 100;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.Num:
							#region Num
							Label1.Text = m_Captions[(int)ParamValueType.Num];
							m_ValueType = ValueType.INT;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x01;
							m_MaxValue = 40;
							IsLocked = true;
							break;
							#endregion
						case ParamValueType.NAME:
							#region NAME
							Label1.Text = m_Captions[(int)ParamValueType.NAME];
							m_ValueType = ValueType.STRING;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x05;
							m_MaxValue = 999999;
							m_StringLength = 0x42;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.SHORTNAME:
							#region SHORTNAME
							Label1.Text = m_Captions[(int)ParamValueType.SHORTNAME];
							m_ValueType = ValueType.STRING;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x47;
							m_MaxValue = 999999;
							m_StringLength = 0x1E;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.FLAVERTEXT:
							#region FLAVERTEXT
							Label1.Text = m_Captions[(int)ParamValueType.FLAVERTEXT];
							m_ValueType = ValueType.STRING;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x65;
							m_MaxValue = 999999;
							m_StringLength = 0xF6;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.VISUAL:
							#region VISUAL
							Label1.Text = m_Captions[(int)ParamValueType.VISUAL];
							m_ValueType = ValueType.BYTE;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x15F;
							m_MaxValue = 999999;
							IsLocked = true;
							break;
							#endregion
						case ParamValueType.CAUSAL:
							#region CAUSAL
							Label1.Text = m_Captions[(int)ParamValueType.CAUSAL];
							m_ValueType = ValueType.INT;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x16C;
							m_MaxValue = 99;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.ANIMA:
							#region ANIMA
							Label1.Text = m_Captions[(int)ParamValueType.ANIMA];
							m_ValueType = ValueType.BYTE;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x01CA;
							m_MaxValue = 99;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.LEVEL:
							#region LEVEL
							Label1.Text = m_Captions[(int)ParamValueType.LEVEL];
							m_ValueType = ValueType.BYTE;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x01CB;
							m_MaxValue = 99;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.EXP:
							#region EXP
							Label1.Text = m_Captions[(int)ParamValueType.EXP];
							m_ValueType = ValueType.INT;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x1cc;
							m_MaxValue = 0x7FFFFFFF;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.FULL_LEVEL:
							#region FULL_LEVEL
							Label1.Text = m_Captions[(int)ParamValueType.FULL_LEVEL];
							m_ValueType = ValueType.INT;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x01D0;
							m_MaxValue = 0x7FFFFFFF;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.TOTAL_EXP:
							#region TOTAL_EXP
							Label1.Text = m_Captions[(int)ParamValueType.TOTAL_EXP];
							m_ValueType = ValueType.INT;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x1D4;
							m_MaxValue = 0x7FFFFFFF;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.MAX_HP:
							#region MAX_HP
							Label1.Text = m_Captions[(int)ParamValueType.MAX_HP];
							m_ValueType = ValueType.INT;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x1D8;
							m_MaxValue = 0x7FFFFFFF;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.MAX_DP:
							#region MAX_DP
							Label1.Text = m_Captions[(int)ParamValueType.MAX_DP];
							m_ValueType = ValueType.INT;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x1DC;
							m_MaxValue = 0x7FFFFFFF;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.STR:
							#region STR
							Label1.Text = m_Captions[(int)ParamValueType.STR];
							m_ValueType = ValueType.INT;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x1E0;
							m_MaxValue = 9999;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.CON:
							#region CON
							Label1.Text = m_Captions[(int)ParamValueType.CON];
							m_ValueType = ValueType.INT;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x1E4;
							m_MaxValue = 9999;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.DMP:
							#region DMP
							Label1.Text = m_Captions[(int)ParamValueType.DMP];
							m_ValueType = ValueType.INT;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x1E8;
							m_MaxValue = 9999;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.AGI:
							#region AGI
							Label1.Text = m_Captions[(int)ParamValueType.AGI];
							m_ValueType = ValueType.INT;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x1EC;
							m_MaxValue = 9999;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.DEX:
							#region DEX
							Label1.Text = m_Captions[(int)ParamValueType.DEX];
							m_ValueType = ValueType.INT;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x1F0;
							m_MaxValue = 9999;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.ERS:
							#region ERS
							Label1.Text = m_Captions[(int)ParamValueType.ERS];
							m_ValueType = ValueType.INT;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x1F4;
							m_MaxValue = 9999;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.LUC:
							#region LUC
							Label1.Text = m_Captions[(int)ParamValueType.LUC];
							m_ValueType = ValueType.INT;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x1F8;
							m_MaxValue = 9999;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.HP:
							#region HP
							Label1.Text = m_Captions[(int)ParamValueType.HP];
							m_ValueType = ValueType.INT;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x308;
							m_MaxValue = 0x7FFFFFFF;
							IsLocked = false;
							break;
							#endregion
						case ParamValueType.DP:
							#region DP
							Label1.Text = m_Captions[(int)ParamValueType.DP];
							m_ValueType = ValueType.INT;
							m_ValueTarget = ValueTarget.CHAR_INDEX;
							m_Offset = 0x30C;
							m_MaxValue = 0x7FFFFFFF;
							IsLocked = false;
							break;
							#endregion
					}
					if (m_sv != null) GetValue();
				}
			}
		}

		private ValueType m_ValueType = ValueType.UINT;
		public ValueType ValueType { get { return m_ValueType; } }
		private ValueTarget m_ValueTarget = ValueTarget.CHAR_INDEX;
		public ValueTarget ValueTarget { get { return m_ValueTarget; } }

		private int m_StringLength = 10;
		/// <summary>
		/// 文字列を扱うときの最大文字数
		/// </summary>
		public int StringLength { get { return m_StringLength; } }
		private int m_Offset = 0;
		public int Offset { get { return m_Offset; } }
		private int m_MaxValue = 9999999;
		public int MaxValue { get { return m_MaxValue; } }
		private bool m_IsLocked = false;
		public bool IsLocked
		{
			get { return m_IsLocked; }
			set
			{
				if(m_IsLocked != value)
				{
					m_IsLocked = value;
					Button1.Enabled = !value;
					TextBox1.ReadOnly = value;
				}
			}
		}

		private Label Label1 = new Label();
		private TextBox TextBox1 = new TextBox();
		private Button Button1 = new Button();

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
			get { return TextBox1.Width; }
			set { TextBox1.Width = value; }
		}
		public int ButtonWidth
		{
			get { return Button1.Width; }
			set { Button1.Width = value; }
		}
		// *******************************************************************
		// コンストラクタ
		// *******************************************************************
		public ParamValue()
		{
			this.Size = new Size(260, 20);
			this.Margin = new Padding(0);
			this.Padding = new Padding(0);

			fl.Size = this.Size;
			fl.Location = new Point(0, 0);
			fl.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
			fl.Margin = new Padding(0);
			fl.Padding = new Padding(0);

			this.Controls.Add(fl);


			Label1.AutoSize = false;
			Label1.Size = new Size(100, 20);
			Label1.Text = "Values";
			Label1.TextAlign = ContentAlignment.MiddleRight;
			Label1.Margin = new Padding(0);
			Label1.Padding = new Padding(0);


			TextBox1.Size = new Size(120, 20);
			//TextBox1.ReadOnly = true;
			TextBox1.TextAlign = HorizontalAlignment.Left;
			TextBox1.Margin = new Padding(0);
			TextBox1.Padding = new Padding(0);

			Button1.Size = new Size(40, 20);
			Button1.Text = "SET";
			Button1.Margin = new Padding(0);
			Button1.Padding = new Padding(0);


			Button1.Click += Button1_Click;
			fl.Controls.Add(Label1);
			fl.Controls.Add(TextBox1);
			fl.Controls.Add(Button1);

			ParamValueType = ParamValueType.None;

			TextBox1.TextChanged += TextBox1_TextChanged;

		}
		private bool refFlag = false;
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			if (refFlag == true) return;
			m_IsModif = true;
		}

		// *******************************************************************
		private void Button1_Click(object sender, EventArgs e)
		{
			SetValue();
		}
		// *******************************************************************
		public void GetValue()
		{
			string s = "";
			if ((m_sv == null)||(m_sv.IsEnabled == false))
			{
				refFlag = true;
				TextBox1.Text = s;
				refFlag = false;
				m_IsModif = false;
				return;
			}
			switch (m_ValueTarget)
			{
				case ValueTarget.CHAR_INDEX:
					GetCharValue();
					break;
				case ValueTarget.ABS_POS:
					GetAbsValue();
					break;
			}
			
		}
		// *******************************************************************
		public void GetCharValue()
		{
			string s = "";
			if ( (m_sv == null)||(m_sv.IsEnabled == false)||(m_ValueTarget != ValueTarget.CHAR_INDEX)||(m_sv.CharIndex<0))
			{
				refFlag = true;
				TextBox1.Text = s;
				refFlag = false;
				m_IsModif = false;
				return;
			}
			byte [] ret = new byte[0];
			switch(m_ValueType)
			{
				case ValueType.BYTE:
					ret = m_sv.GetCharData(m_Offset, 1);
					s = ((byte)ret[0]).ToString();
					break;
				case ValueType.SBYTE:
					ret = m_sv.GetCharData(m_Offset, 1);
					s = ((sbyte)ret[0]).ToString();
					break;
				case ValueType.SHORT:
					ret = m_sv.GetCharData(m_Offset, 2);
					s = ((short)(ret[0] + ((short)ret[1] << 8))).ToString();
					break;
				case ValueType.USHORT:
					ret = m_sv.GetCharData(m_Offset, 2);
					s = ((ushort)((ushort)ret[0] + ((ushort)ret[1] << 8))).ToString();
					break;
				case ValueType.INT:
					ret = m_sv.GetCharData(m_Offset, 4);
					s = ((int)((int)ret[0] + ((int)ret[1] << 8)+ ((int)ret[2] << 16)+ ((int)ret[3] << 24))).ToString();
					break;
				case ValueType.UINT:
					ret = m_sv.GetCharData(m_Offset, 4);
					s = ((uint)((uint)ret[0] + ((uint)ret[1] << 8)+ ((uint)ret[2] << 16)+ ((uint)ret[3] << 24))).ToString();
					break;
				case ValueType.STRING:
					s = m_sv.GetCharString(m_Offset, m_StringLength);
					break;
			}
			refFlag = true;
			TextBox1.Text = s;
			refFlag = false;
			m_IsModif = false;
		}
		// *******************************************************************
		public void GetAbsValue()
		{
			string s = "";
			if ( (m_sv == null)||(m_sv.IsEnabled == false)||(m_ValueTarget != ValueTarget.ABS_POS))
			{
				refFlag = true;
				TextBox1.Text = s;
				refFlag = false;
				m_IsModif = false;
				return;
			}
			byte [] ret = new byte[0];
			switch(m_ValueType)
			{
				case ValueType.BYTE:
					ret = m_sv.GetData(m_Offset, 1);
					s = ((byte)ret[0]).ToString();
					break;
				case ValueType.SBYTE:
					ret = m_sv.GetData(m_Offset, 1);
					s = ((sbyte)ret[0]).ToString();
					break;
				case ValueType.SHORT:
					ret = m_sv.GetData(m_Offset, 2);
					s = ((short)(ret[0] + ((short)ret[1] << 8))).ToString();
					break;
				case ValueType.USHORT:
					ret = m_sv.GetData(m_Offset, 2);
					s = ((ushort)((ushort)ret[0] + ((ushort)ret[1] << 8))).ToString();
					break;
				case ValueType.INT:
					ret = m_sv.GetData(m_Offset, 4);
					s = ((int)((int)ret[0] + ((int)ret[1] << 8)+ ((int)ret[2] << 16)+ ((int)ret[3] << 24))).ToString();
					break;
				case ValueType.UINT:
					ret = m_sv.GetData(m_Offset, 4);
					s = ((uint)((uint)ret[0] + ((uint)ret[1] << 8)+ ((uint)ret[2] << 16)+ ((uint)ret[3] << 24))).ToString();
					break;
				case ValueType.STRING:
					s = m_sv.GetString(m_Offset, m_StringLength);
					break;
			}
			refFlag = true;
			TextBox1.Text = s;
			refFlag = false;
			m_IsModif = false;
		}
		// *******************************************************************
		public void SetValue()
		{
			if ((m_sv == null)||(m_sv.IsEnabled==false)) return;

			if (m_IsLocked == true) return;
			switch(m_ValueTarget)
			{
				case ValueTarget.CHAR_INDEX:
					SetCharValue();
					break;
				case ValueTarget.ABS_POS:
					SetAbsValue();
					break;
			}
			m_IsModif = false;
		}
		// *******************************************************************
		private void SetCharValue()
		{
			if (m_IsLocked == true) return;
			if ((m_sv == null)||(m_sv.IsEnabled==false)) return;
			if (m_ValueTarget != ValueTarget.CHAR_INDEX) return;
			string s = TextBox1.Text.Trim();
			if (s == "") return;
			byte[] ret = new byte[1];
			switch (m_ValueType)
			{
				case ValueType.SBYTE:
					sbyte sb = 0;
					if (sbyte.TryParse(s,out sb))
					{
						ret[0] = (byte)sb;
						m_sv.SetCharData(m_Offset, ret);
					}
					break;
				case ValueType.BYTE:
					byte bt = 0;
					if (byte.TryParse(s,out bt))
					{
						ret[0] = bt;
						m_sv.SetCharData(m_Offset, ret);
					}
					break;
				case ValueType.SHORT:
					short sh = 0;
					if (short.TryParse(s,out sh))
					{
						ret = new byte[2];
						ret[0] = (byte)(sh & 0xFF);
						ret[1] = (byte)((sh>>8) & 0xFF);
						m_sv.SetCharData(m_Offset, ret);
					}
					break;
				case ValueType.USHORT:
					ushort ush = 0;
					if (ushort.TryParse(s,out ush))
					{
						ret = new byte[2];
						ret[0] = (byte)(ush & 0xFF);
						ret[1] = (byte)((ush>>8) & 0xFF);
						m_sv.SetCharData(m_Offset, ret);
					}
					break;
				case ValueType.INT:
					int it = 0;
					if (int.TryParse(s,out it))
					{
						if (it > m_MaxValue) it = m_MaxValue;
						ret = new byte[4];
						ret[0] = (byte)(it & 0xFF);
						ret[1] = (byte)((it>>8) & 0xFF);
						ret[2] = (byte)((it>>16) & 0xFF);
						ret[3] = (byte)((it>>24) & 0xFF);
						m_sv.SetCharData(m_Offset, ret);
					}
					break;
				case ValueType.UINT:
					uint ui = 0;
					if (uint.TryParse(s,out ui))
					{
						if (ui > m_MaxValue) ui = (uint)m_MaxValue;
						ret = new byte[4];
						ret[0] = (byte)(ui & 0xFF);
						ret[1] = (byte)((ui>>8) & 0xFF);
						ret[2] = (byte)((ui>>16) & 0xFF);
						ret[3] = (byte)((ui>>24) & 0xFF);
						m_sv.SetCharData(m_Offset, ret);
					}
					break;
				case ValueType.STRING:
					m_sv.SetCharString(m_Offset, s, m_StringLength);
					break;
			}
			m_IsModif = false;

		}
		// *******************************************************************
		private void SetAbsValue()
		{
			if (m_IsLocked == true) return;
			if ((m_sv == null)||(m_sv.IsEnabled==false)) return;
			if (m_ValueTarget != ValueTarget.ABS_POS) return;

			string s = TextBox1.Text.Trim();
			if (s == "") return;
			byte[] ret = new byte[1];
			switch (m_ValueType)
			{
				case ValueType.SBYTE:
					sbyte sb = 0;
					if (sbyte.TryParse(s,out sb))
					{
						ret[0] = (byte)sb;
						m_sv.SetData(m_Offset, ret);
					}
					break;
				case ValueType.BYTE:
					byte bt = 0;
					if (byte.TryParse(s,out bt))
					{
						ret[0] = bt;
						m_sv.SetData(m_Offset, ret);
					}
					break;
				case ValueType.SHORT:
					short sh = 0;
					if (short.TryParse(s,out sh))
					{
						ret = new byte[2];
						ret[0] = (byte)(sh & 0xFF);
						ret[1] = (byte)((sh>>8) & 0xFF);
						m_sv.SetData(m_Offset, ret);
					}
					break;
				case ValueType.USHORT:
					ushort ush = 0;
					if (ushort.TryParse(s,out ush))
					{
						ret = new byte[2];
						ret[0] = (byte)(ush & 0xFF);
						ret[1] = (byte)((ush>>8) & 0xFF);
						m_sv.SetData(m_Offset, ret);
					}
					break;
				case ValueType.INT:
					int it = 0;
					if (int.TryParse(s,out it))
					{
						if (it > m_MaxValue) it = m_MaxValue;
						ret = new byte[4];
						ret[0] = (byte)(it & 0xFF);
						ret[1] = (byte)((it>>8) & 0xFF);
						ret[2] = (byte)((it>>16) & 0xFF);
						ret[3] = (byte)((it>>24) & 0xFF);
						m_sv.SetData(m_Offset, ret);
					}
					break;
				case ValueType.UINT:
					uint ui = 0;
					if (uint.TryParse(s,out ui))
					{
						if (ui> m_MaxValue) ui = (uint)m_MaxValue;
						ret = new byte[4];
						ret[0] = (byte)(ui & 0xFF);
						ret[1] = (byte)((ui>>8) & 0xFF);
						ret[2] = (byte)((ui>>16) & 0xFF);
						ret[3] = (byte)((ui>>24) & 0xFF);
						m_sv.SetData(m_Offset, ret);
					}
					break;
				case ValueType.STRING:
					m_sv.SetString(m_Offset, s, m_StringLength);
					break;
			}
			m_IsModif = false;
	}
		// *******************************************************************
	}
	
}
