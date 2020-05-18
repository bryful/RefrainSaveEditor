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
	public class BodyDamage :Control
	{
		private bool refFlag = false;
		private int m_Value = 0;
		public int Value { get { return m_Value; } }
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
			if (refFlag == true) return;
			if (m_sv != null)
			{
				GetValue();
				//OnValueChanged(new EventArgs());
			}
		}
		private int m_Offset = 0x310;
		public int Offset
		{
			get { return m_Offset; }
		}
		// *****************************************************
		public BodyDamage()
		{
			this.Size = new Size(60, 60);
			this.MinimumSize = this.Size;
			this.MaximumSize = this.Size;

		}
		// *****************************************************
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.DrawImage(Properties.Resources.BodyBase,0,0);

			int mv = m_Value;
			if ((mv & 0x01) == 0x01)
			{
				g.DrawImage(Properties.Resources.Body01,0,0);
			}
			if (((mv>>1) & 0x01) == 0x01)
			{
				g.DrawImage(Properties.Resources.Body02,0,0);
			}
			if (((mv>>2) & 0x01) == 0x01)
			{
				g.DrawImage(Properties.Resources.Body03,0,0);
			}
			if (((mv>>3) & 0x01) == 0x01)
			{
				g.DrawImage(Properties.Resources.Body04,0,0);
			}
			if (((mv>>4) & 0x01) == 0x01)
			{
				g.DrawImage(Properties.Resources.Body05,0,0);
			}

		}

		// *******************************************************************
		public void GetValue()
		{
			if ( (m_sv == null)||(m_sv.IsEnabled == false)||(m_sv.CharIndex<0))
			{
				m_Value = 0;
				this.Invalidate();
				return;
			}
			byte [] ret = new byte[0];
			ret = m_sv.GetCharData(m_Offset, 4);
			int idx = (int)((int)ret[0] + ((int)ret[1] << 8) + ((int)ret[2] << 16) + ((int)ret[3] << 24));
			refFlag = true;
			m_Value = idx;
			this.Invalidate();
			refFlag = false;
		}
	// *******************************************************************
		private void SetValue()
		{
			if ((m_sv == null)||(m_sv.IsEnabled==false)) return;
			byte[] ret = new byte[4];

			int it = m_Value;

			ret[0] = (byte)(it & 0xFF);
			ret[1] = (byte)((it>>8) & 0xFF);
			ret[2] = (byte)((it>>16) & 0xFF);
			ret[3] = (byte)((it>>24) & 0xFF);
			m_sv.SetCharData(m_Offset, ret);
		}		
		// *******************************************************************
		protected override void OnMouseDown(MouseEventArgs e)
		{
			int x = e.X;
			int y = e.Y;
			//base.OnMouseDown(e);
			// 23,19 35,30
			// 8,27  21,38 
			// 36,27  49,38
			// 22,30  35,43
			// 21,44  36,35
			int mv = m_Value;

			if (y<30)
			{
				mv ^= (0x1 << 0); 
			}else if (y < 40)
			{
				if(x<21)
				{
					mv ^= (0x1 << 1); 
				}else if (x < 35)
				{
					mv ^= (0x1 << 3);
				}
				else
				{
					mv ^= (0x1 << 2); 
				}
			}
			else
			{
				mv ^= (0x1 << 4); 
			}

			if(m_Value != mv)
			{
				m_Value = mv;
				SetValue();
				this.Invalidate();
			}
		}
	}
}
