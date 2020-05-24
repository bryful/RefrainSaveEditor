using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrainSaveEditor
{
	public class NumBox :Control
	{
		private Label Label = new Label();
		private NumericUpDown Num = new NumericUpDown();
		private FlowLayoutPanel fl = new FlowLayoutPanel();

		public NumBox()
		{
			this.Size = new Size(235, 27);
			this.Padding = new Padding(0);
			this.Margin = new Padding(0);
			Font f = this.Font;
			f = new Font(f.FontFamily, 14);
			this.Font = f;

			fl.Size = new Size(235, 27);
			fl.Padding =  new Padding(0);
			fl.Margin =  new Padding(0);
			fl.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;

			this.Controls.Add(fl);

			this.MinimumSize = new Size(235, 27);
			this.MaximumSize = new Size(235, 27);

			Label.AutoSize = false;
			Label.Size = new Size(110, 20);
			Label.Font = this.Font;
			Label.TextAlign = ContentAlignment.MiddleRight;
			Label.Padding =  new Padding(0);
			Label.Margin =  new Padding(0);

			Num.Size = new Size(110, 20);
			Num.Minimum = -0x99999999;
			Num.Maximum = 0x99999999;
			Num.Font = this.Font;
			Num.TextAlign = HorizontalAlignment.Right;
			Num.Padding =  new Padding(0);
			Num.Margin =  new Padding(0);
			Num.Hexadecimal = true;

			fl.Controls.Add(Label);
			fl.Controls.Add(Num);


		}
		public int Value
		{
			get { return (int)Num.Value; }
			set { Num.Value = (decimal)value; }
		}
		public string Caption
		{
			get { return Label.Text; }
			set { Label.Text = value; }
		}
	}
}
