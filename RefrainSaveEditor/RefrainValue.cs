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
	public class RefrainValue : Control
	{
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
		private ValueType m_ValueType = ValueType.UINT;
		public ValueType ValueType
		{
			get { return m_ValueType; }
			set
			{
				if (m_ValueType != value)
				{
					m_ValueType = value;
					GetValue();

				}
			}
		}
		private ValueTarget m_ValueTarget = ValueTarget.CHAR_INDEX;
		public ValueTarget ValueTarget
		{
			get { return m_ValueTarget; }
			set
			{
				if(m_ValueTarget != value)
				{
					m_ValueTarget = value;
					GetValue();
				}
			}
		}

		private int m_StringLength = 10;
		/// <summary>
		/// 文字列を扱うときの最大文字数
		/// </summary>
		public int StringLength
		{
			get { return m_StringLength; }
			set
			{
				if (m_StringLength != value)
				{
					m_StringLength = value;
					GetValue();
				}
			}
		}
		private int m_Offset = 0;
		public int Offset
		{
			get { return m_Offset; }
			set
			{
				if (m_Offset != value)
				{
					m_Offset = value;
					GetValue();
				}
			}
		}
		private int m_MaxValue = 9999999;
		public int MaxValue
		{
			get { return m_MaxValue; }
			set { m_MaxValue = value; }
		}

		private Label Label1 = new Label();
		private TextBox TextBox1 = new TextBox();
		private Button Button1 = new Button();

		private FlowLayoutPanel fl = new FlowLayoutPanel();

		public string Caption
		{
			get { return Label1.Text; }
			set { Label1.Text = value; }
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
		public RefrainValue()
		{
			this.Size = new Size(240, 20);
			this.Margin = new Padding(0);
			this.Padding = new Padding(0);

			fl.Size = this.Size;
			fl.Location = new Point(0, 0);
			fl.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
			fl.Margin = new Padding(0);
			fl.Padding = new Padding(0);

			this.Controls.Add(fl);


			Label1.AutoSize = false;
			Label1.Size = new Size(80, 20);
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
			if (m_sv == null)
			{
				TextBox1.Text = s;
				return;
			}
			if (m_sv.IsEnabled == false)
			{
				TextBox1.Text = s;
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
				TextBox1.Text = s;
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
			TextBox1.Text = s;
		}
		// *******************************************************************
		public void GetAbsValue()
		{
			string s = "";
			if ( (m_sv == null)||(m_sv.IsEnabled == false)||(m_ValueTarget != ValueTarget.ABS_POS))
			{
				TextBox1.Text = s;
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
			TextBox1.Text = s;
		}
		// *******************************************************************
		public void SetValue()
		{
			if ((m_sv == null)||(m_sv.IsEnabled==false)) return;

			switch(m_ValueTarget)
			{
				case ValueTarget.CHAR_INDEX:
					SetCharValue();
					break;
				case ValueTarget.ABS_POS:
					break;
			}

		}
		// *******************************************************************
		private void SetCharValue()
		{
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
		}
		// *******************************************************************
		private void SetAbsValue()
		{
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
		}
		// *******************************************************************
	}
	
}
