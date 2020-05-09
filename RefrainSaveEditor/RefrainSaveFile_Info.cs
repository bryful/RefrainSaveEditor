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

namespace RefrainSaveEditor
{
	public partial class RefrainSaveFile :Component
	{
		private int DataToInt(int adr)
		{
			int ret = 0;
			ret = (int)m_Data[adr];
			ret += (int)m_Data[adr + 1] << 8;
			ret += (int)m_Data[adr + 2] << 16;
			ret += (int)m_Data[adr + 3] << 24;
			return ret;
		}
		private string InfoStr(int adr, int idx)
		{
			string ret = "";
			byte c = m_Data[adr];
			ret += idx.ToString("X4");
			ret += " [" + c.ToString("X2") + "] ";
			int vv = DataToInt(adr);
			if(vv>=0) ret += "Int:(" +vv.ToString()+")";

			if ((c & 0xE0) == 0xE0)
			{
				byte[] ss = new byte[3];
				ss[0] = m_Data[adr + 0];
				ss[1] = m_Data[adr + 1];
				ss[2] = m_Data[adr + 2];
				ret += "/* " + Encoding.UTF8.GetString(ss).Trim() + " */";
			}


			return ret;
		}

		public string[] GetCharInfo()
		{
			if (m_Data.Length <= 0) return new string[0];

			int pos = CharAdr;
			if (pos < 0) return new string[0];
			string[] ret = new string[CharDataSize];
			for (int i=0; i<CharDataSize; i++)
			{
				ret[i] = InfoStr(pos, i);
				pos++;
			}
			return ret;
		}

	}
}
