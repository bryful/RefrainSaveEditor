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
	public enum SKILLS
	{
		/*000*/NONE,//なし,
		/*001*/呪毒治癒術,
		/*002*/幻覚治癒術,
		/*003*/深淵治療術,
		/*004*/錯乱治療術,
		/*005*/驚愕治療術,
		/*006*/腐臭治療術,
		/*007*/全治癒術,
		/*008*/刀剣術師範,
		/*009*/蝕台術師範,
		/*010*/古塔槍術師範,
		/*011*/鈍槌術師範,
		/*012*/星嵐鎌術師範,
		/*013*/百花弓術師範,
		/*014*/呪鐘術師範,
		/*015*/戦術甲術師範,
		/*016*/腕自慢,
		/*017*/フィジカル自慢,
		/*018*/ドナム力自慢,
		/*019*/スピード自慢,
		/*020*/器用さ自慢,
		/*021*/美体自慢,
		/*022*/斬撃耐性強化術,
		/*023*/打撃耐性強化術,
		/*024*/貫撃耐性強化術,
		/*025*/焔撃耐性強化術,
		/*026*/泥撃耐性強化術,
		/*027*/霧撃耐性強化術,
		/*028*/呪毒耐性強化術,
		/*029*/幻覚耐性強化術,
		/*030*/深淵耐性強化術,
		/*031*/錯乱耐性強化術,
		/*032*/驚愕耐性強化術,
		/*033*/腐臭耐性強化術,
		/*034*/古塔乱,
		/*035*/不屈の精神,
		/*036*/星の心,
		/*037*/運命の星,
		/*038*/二刀一流,
		/*039*/影術,
		/*040*/闇討ち術,
		/*041*/呪い返し,
		/*042*/スキキライスキ,
		/*043*/癒演舞の鐘,
		/*044*/呪詛の鐘,
		/*045*/演者の維持,
		/*046*/ドナムマスター,
		/*047*/ぶちまわし,
		/*048*/ドナム効率化論,
		/*049*/月蝕,
		/*050*/篭城盾,
		/*051*/メガバッシュ,
		/*052*/亀甲の構え,
		/*053*/守るの心,
		/*054*/アヴォイダンス,
		/*055*/百花ノ狙撃手,
		/*056*/ステルス,
		/*057*/狙いすまし,
		/*058*/黒切断,
		/*059*/因果,
		/*060*/ぶん回しの剛腕,
		/*061*/誘惑の魔眼,
		/*062*/星嵐舞踏,
		/*063*/ウィッカーマン,
		/*064*/悪ノ華,
		/*065*/ドラキュリア,
		/*066*/速攻術,
		/*067*/精神統一,
		/*068*/見切り,
		/*069*/鉄壁,
		/*070*/足払い,
		/*071*/フンバリ,
		/*072*/雄心勃勃たる構え,
		/*073*/気功術,
		/*074*/鎧通し,
		/*075*/受け流し,
		/*076*/硬化術,
		/*077*/瞬速,
		/*078*/大鉄壁,
		/*079*/ゾーン,
		/*080*/卑見の見切り,
		/*081*/大火事場力,
		/*082*/力タメ,
		/*083*/百花の乱れ矢,
		/*084*/背徳の罪,
		/*085*/反撃の狼煙,
		/*086*/雲隠れ,
		/*087*/鉄壁の運勢,
		/*088*/見切りの運勢,
		/*089*/薄氷の見切り,
		/*090*/ドエムマスター,
		/*091*/ヘビースママッシャー,
		/*092*/反ドナム思想,
		/*093*/ボディタッチ,
		/*094*/奥義大鎧通し,
		/*095*/刃落とし,
		/*096*/やわらかボディ,
		/*097*/不明
	};



	public class SkillValue : Control
	{
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
		private int m_Index = 0;
		public int Index
		{
			get { return m_Index; }
			set
			{
				int v = value;
				if (v < 0) v = 0; else if (v > 11) v = 11;
				if (m_Index !=v)
				{
					m_Index = v;
					GetValue();
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

		private int m_Offset = 0x176;
		public int Offset
		{
			get { return m_Offset; }
		}

		private ComboBox m_Cmb = new ComboBox();
		string[] m_SkillNames = new string[]{
		/*000*/"なし",
		/*001*/"呪毒治癒術",
		/*002*/"幻覚治癒術",
		/*003*/"深淵治療術",
		/*004*/"錯乱治療術",
		/*005*/"驚愕治療術",
		/*006*/"腐臭治療術",
		/*007*/"全治癒術",
		/*008*/"刀剣術師範",
		/*009*/"蝕台術師範",
		/*010*/"古塔槍術師範",
		/*011*/"鈍槌術師範",
		/*012*/"星嵐鎌術師範",
		/*013*/"百花弓術師範",
		/*014*/"呪鐘術師範",
		/*015*/"戦術甲術師範",
		/*016*/"腕自慢",
		/*017*/"フィジカル自慢",
		/*018*/"ドナム力自慢",
		/*019*/"スピード自慢",
		/*020*/"器用さ自慢",
		/*021*/"美体自慢",
		/*022*/"斬撃耐性強化術",
		/*023*/"打撃耐性強化術",
		/*024*/"貫撃耐性強化術",
		/*025*/"焔撃耐性強化術",
		/*026*/"泥撃耐性強化術",
		/*027*/"霧撃耐性強化術",
		/*028*/"呪毒耐性強化術",
		/*029*/"幻覚耐性強化術",
		/*030*/"深淵耐性強化術",
		/*031*/"錯乱耐性強化術",
		/*032*/"驚愕耐性強化術",
		/*033*/"腐臭耐性強化術",
		/*034*/"古塔乱",
		/*035*/"不屈の精神",
		/*036*/"星の心",
		/*037*/"運命の星",
		/*038*/"二刀一流",
		/*039*/"影術",
		/*040*/"闇討ち術",
		/*041*/"呪い返し",
		/*042*/"スキキライスキ",
		/*043*/"癒演舞の鐘",
		/*044*/"呪詛の鐘",
		/*045*/"演者の維持",
		/*046*/"ドナムマスター",
		/*047*/"ぶちまわし",
		/*048*/"ドナム効率化論",
		/*049*/"月蝕",
		/*050*/"竜城盾",
		/*051*/"メガバッシュ",
		/*052*/"亀甲の構え",
		/*053*/"守るの心",
		/*054*/"アヴォイダンス",
		/*055*/"百花ノ狙撃者",
		/*056*/"ステルス",
		/*057*/"狙いすまし",
		/*058*/"黒切断",
		/*059*/"因果",
		/*060*/"ぶん回しの剛腕",
		/*061*/"誘惑の魔眼",
		/*062*/"星嵐舞踏",
		/*063*/"ウィッカーマン",
		/*064*/"悪ノ華",
		/*065*/"ドラキュリア",
		/*066*/"速攻術",
		/*067*/"精神統一",
		/*068*/"見切り",
		/*069*/"鉄壁",
		/*070*/"足払い",
		/*071*/"フンバリ",
		/*072*/"雄心勃起たる構え",
		/*073*/"気功術",
		/*074*/"鎧通し",
		/*075*/"受け流し",
		/*076*/"硬化術",
		/*077*/"瞬足",
		/*078*/"大鉄壁",
		/*079*/"ゾーン",
		/*080*/"卑見の見切り",
		/*081*/"大火事場力",
		/*082*/"力タメ",
		/*083*/"百花の乱れ矢",
		/*084*/"背徳の罪",
		/*085*/"反撃の狼煙",
		/*086*/"雲隠れ",
		/*087*/"鉄壁の運勢",
		/*088*/"見切りの運勢",
		/*089*/"薄氷の見切り",
		/*090*/"ドエムマスター",
		/*091*/"ヘビースママッシャー",
		/*092*/"反ドナム思想",
		/*093*/"ボディタッチ",
		/*094*/"奥義大鎧通し",
		/*095*/"刃落とし",
		/*096*/"やわらかボディ",
		/*097*/"不明"
		};

		public SkillValue()
		{
			this.Size = new Size(100, 20);
			this.Padding = new Padding(0);
			this.Margin = new Padding(0);
			this.MinimumSize = new Size(50, 20);
			this.MaximumSize = new Size(500, 20);

			m_Cmb.Size = this.Size;
			m_Cmb.DropDownStyle = ComboBoxStyle.DropDownList;
			m_Cmb.Padding = new Padding(0);
			m_Cmb.Margin = new Padding(0);
			m_Cmb.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
			m_Cmb.Items.Clear();
			m_Cmb.Items.AddRange(m_SkillNames);
			m_Cmb.SelectedIndex = 0;

			this.Controls.Add(m_Cmb);

			m_Cmb.SelectedIndexChanged += M_Cmb_SelectedIndexChanged;
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
				if (v < 0) v = 0;
				else if (v >= m_SkillNames.Length) v = m_SkillNames.Length - 1;

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
			ret = m_sv.GetCharData(m_Offset+ m_Index*4, 4);
			int idx = (int)((int)ret[0] + ((int)ret[1] << 8) + ((int)ret[2] << 16) + ((int)ret[3] << 24));
			refFlag = true;
			SelectedIndex = idx;
			refFlag = false;
		}
		// *******************************************************************
		private void SetValue()
		{
			if ((m_sv == null)||(m_sv.IsEnabled==false)) return;
			byte[] ret = new byte[4];

			int it = m_Cmb.SelectedIndex;
			if (it < 0) it = 0;

			ret[0] = (byte)(it & 0xFF);
			ret[1] = (byte)((it>>8) & 0xFF);
			ret[2] = (byte)((it>>16) & 0xFF);
			ret[3] = (byte)((it>>24) & 0xFF);
			m_sv.SetCharData(m_Offset+ m_Index*4, ret);
		}
	}
}
