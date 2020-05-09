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
		public readonly int SaveFileSize = 0xEC464;
		public readonly int CharStartAdr = 0x1020;
		public readonly int CharDataSize = 0x328;

		// *******************************************************************************************
		private byte[] m_Data = new byte[0];
		public bool IsEnabled
		{
			get { return m_Data.Length > 0; }
		}

		// *******************************************************************************************
		private int m_CharIndex = 0;
		public int CharIndex
		{
			get { return m_CharIndex; }

			set
			{
				if (m_CharIndex != value)
				{
					m_CharIndex = value;
					OnCharIndexChanged(new EventArgs());
				}
			}
		}

		// *******************************************************************************************
		public int GetCharAdr(int idx)
		{
			if (idx < 0) idx = 0;
			return CharStartAdr + CharDataSize * idx;
		}
		public int CharAdr 
		{
			get
			{
				if (m_Data.Length <= 0)
				{
					return -1;
				}
				else
				{
					return GetCharAdr(m_CharIndex);
				}
			}
		}


		// *******************************************************************************************
		public byte[] GetData(int adr,int sz)
		{
			byte[] ret = new byte[sz];

			for ( int i=0; i<sz;i++)
			{
				ret[i] = m_Data[adr + i];
			}
			return ret;
		}
		public void SetData(int adr,byte[] d)
		{
			int sz = d.Length;
			if (sz <= 0) return;
			for ( int i=0; i<sz;i++)
			{
				m_Data[adr + i] = d[i];
			}
		}
		public string GetString(int adr,int sz)
		{
			List<byte> r = new List<byte>();

			for ( int i=0; i<sz;i++)
			{
				if (m_Data[adr + i] == 0) break;
				r.Add(m_Data[adr + i]);
			}
			byte[] n = r.ToArray();
			if(n.Length<=0)
			{
				return "";
			}
			else
			{
				return Encoding.UTF8.GetString(n).Trim();
			}
		}
		public void SetString(int offset,string s, int sz)
		{
			byte[] data = System.Text.Encoding.UTF8.GetBytes(s);
			int dataSz = data.Length;
			if (dataSz > sz) dataSz = sz;

			for ( int i=0; i<dataSz;i++)
			{
				m_Data[offset + i] = data[i];
			}
			if (sz > dataSz)
			{
				for ( int i=dataSz; i<sz;i++)
				{
					m_Data[offset + i] = 0;
				}
			}
		}

		public int GetIntData(int adr)
		{
			int ret = 0;
			if (IsEnabled == false) return ret;
			ret += (int)m_Data[adr];
			ret += (int)m_Data[adr + 1] << 8;
			ret += (int)m_Data[adr + 2] << 16;
			ret += (int)m_Data[adr + 3] << 24;
			return ret;
		}

		public byte[] GetCharData(int offset,int sz)
		{
			if (m_CharIndex < 0) return new byte[0];
			if (sz <= 0) sz = 1;
			byte[] ret = new byte[sz];
			int pos = CharAdr + offset;

			for ( int i=0; i<sz;i++)
			{
				ret[i] = m_Data[pos + i];
			}
			return ret;
		}
		public void SetCharData(int offset,byte[] v)
		{
			if (m_CharIndex < 0) return;
			int pos = CharAdr + offset;
			if (v.Length>0)
			{
				for ( int i=0; i<v.Length;i++)
				{
					m_Data[pos + i] = v[i];
				}
			}
			OnDataChanged(new EventArgs());
		}
		public string GetCharString(int offset,int sz)
		{
			if (m_CharIndex < 0) return "";
			if (sz < 3) sz = 3;
			byte[] ret = new byte[sz];
			int pos = CharAdr + offset;

			List<byte> r = new List<byte>();

			for ( int i=0; i<sz;i++)
			{
				if (m_Data[pos + i] == 0) break;
				r.Add(m_Data[pos + i]);
			}
			byte[] n = r.ToArray();
			if(n.Length<=0)
			{
				return "";
			}
			else
			{
				return Encoding.UTF8.GetString(n).Trim();
			}
		}
		public void SetCharString(int offset,string s, int sz)
		{
			if (m_CharIndex < 0) return;
			if (sz < 3) sz = 3;
			byte[] data = System.Text.Encoding.UTF8.GetBytes(s);
			int dataSz = data.Length;
			if (dataSz > sz) dataSz = sz;
			int pos = CharAdr + offset;

			for ( int i=0; i<dataSz;i++)
			{
				m_Data[pos + i] = data[i];
			}
			if (sz > dataSz)
			{
				for ( int i=dataSz; i<sz;i++)
				{
					m_Data[pos + i] = 0;
				}
			}
		}

		// *******************************************************************************************
		public string CharName(int idx)
		{
			if (idx < 0)
			{
				return "";
			}
			List<byte> nn = new List<byte>();
			int adr = GetCharAdr(idx) + 5;
			for(int i=0;i<0x42;i++)
			{
				if (m_Data[adr + i] == 0)
				{
					break;
				}
				nn.Add( m_Data[adr + i]);
			}
			byte[] n = nn.ToArray();
			if(n.Length<=0)
			{
				return "";
			}
			else
			{
				return Encoding.UTF8.GetString(n).Trim();
			}

		}
		public string CharShortName(int idx)
		{
			if (idx < 0)
			{
				return "";
			}
			List<byte> nn = new List<byte>();
			int adr = GetCharAdr(idx) + 0x47;
			for(int i=0;i<0x1d;i++)
			{
				if (m_Data[adr + i] == 0)
				{
					break;
				}
				nn.Add( m_Data[adr + i]);
			}
			byte[] n = nn.ToArray();
			if(n.Length<=0)
			{
				return "";
			}
			else
			{
				return Encoding.UTF8.GetString(n).Trim();
			}

		}
		public string CharText(int idx)
		{
			string ret = "";
			if (idx < 0) return ret;

			List<byte> nn = new List<byte>();
			int adr = GetCharAdr(idx) + 0x65;
			for(int i=0;i<0xF5;i++)
			{
				if (m_Data[adr + i] == 0)
				{
					break;
				}
				nn.Add( m_Data[adr + i]);
			}
			byte[] n = nn.ToArray();
			if(n.Length>0)
			{
				ret = Encoding.UTF8.GetString(n).Trim();
			}

			return ret;
		}
		public string[] CharNames()
		{
			if (m_Data.Length<=0)
			{
				return new string[0];
			}

			List<string> ret = new List<string>();
			for(int i=0; i<60;i++)
			{
				string s = CharName(i);
				if (s != "")
				{
					ret.Add(s);
				}
			}
			return ret.ToArray();
		}
		// *******************************************************************************************
		/*
		public string PalyerName
		{
			get
			{
				string ret = "";
				if (IsEnabled == true)
				{
					ret = GetString(0x20, 0x36);
				}
				return ret;
			}
		}
		
		 // *******************************************************************************************
		 public int Mana
		{
			get { return GetIntData(0x5E); }
		}
		 // *******************************************************************************************
		 public int Coin
		{
			get { return GetIntData(0x56); }
		}
		 public int Karuma
		{
			get { return GetIntData(0x62); }
		}
		*/
		// *******************************************************************************************
		public int[] FindByte(byte v)
		{
			if ((m_Data.Length <= 0)) return new int[0];
			List<int> ret = new List<int>();
			int pos = CharAdr;
	

			for ( int i=0; i<CharDataSize;i++ )
			{
				byte b0 = m_Data[pos];
				if (b0 == v)
				{
					ret.Add(i);
				}
				pos++;
			}
			return ret.ToArray();

		}
		public int[] FindShort(short v)
		{
			if ((m_Data.Length <= 0)) return new int[0];
			List<int> ret = new List<int>();
			int pos = CharAdr;
			byte[] vv = new byte[2];
			vv[0] = (byte)(v & 0xFF);
			vv[1] = (byte)((v>>8) & 0xFF);


			for ( int i=0; i<CharDataSize;i++ )
			{
				byte b0 = m_Data[pos];
				byte b1 = m_Data[pos+1];
				if ((b0 == vv[0]) && (b1 == vv[1]))
				{
					ret.Add(i);
				}
				pos++;
			}
			return ret.ToArray();

		}
		public int[] FindInt(int v)
		{
			if ((m_Data.Length <= 0)) return new int[0];
			List<int> ret = new List<int>();
			int pos = CharAdr;
			byte[] vv = new byte[4];
			vv[0] = (byte)(v & 0xFF);
			vv[1] = (byte)((v>>8) & 0xFF);
			vv[2] = (byte)((v>>16) & 0xFF);
			vv[3] = (byte)((v>>24) & 0xFF);


			for ( int i=0; i<CharDataSize;i++ )
			{
				byte b0 = m_Data[pos];
				byte b1 = m_Data[pos+1];
				byte b2 = m_Data[pos+2];
				byte b3 = m_Data[pos+3];
				if ((b0 == vv[0]) && (b1 == vv[1])&& (b2 == vv[2])&& (b3 == vv[3]))
				{
					ret.Add(i);
				}
				pos++;
			}
			return ret.ToArray();

		}
	}
}
