using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrainSaveEditor
{
	public class ParamBox : Control
	{
		private Label Label1 = new Label();
		private TextBox TextBox1 = new TextBox();
		private FlowLayoutPanel fp = new FlowLayoutPanel();
		public ParamBox()
		{
			this.Size = new Size(120, 20);
			this.Margin = new Padding(0);
			this.Padding = new Padding(0);


			fp.Size = this.Size;
			fp.Location = new Point(0, 0);
			fp.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
			fp.FlowDirection = FlowDirection.LeftToRight;
			fp.Margin = new Padding(0);
			fp.Padding = new Padding(0);

			this.Controls.Add(fp);

			Label1.AutoSize = false;
			Label1.Size = new Size(60, 20);
			Label1.TextAlign = ContentAlignment.MiddleRight;
			Label1.Margin = new Padding(0);
			Label1.Padding = new Padding(0);

			TextBox1.Size = new Size(60, 20);
			TextBox1.TextAlign = HorizontalAlignment.Right;
			TextBox1.Margin = new Padding(0);

			fp.Controls.Add(Label1);
			fp.Controls.Add(TextBox1);
		}
		public string Caption
		{
			get { return Label1.Text; }
			set { Label1.Text = value; }
		}
		public string StrValue
		{
			get { return TextBox1.Text; }
			set { TextBox1.Text = value; }
		}
		public int Value
		{
			get
			{
				int ret = 0;
				if (int.TryParse(TextBox1.Text.Trim(),out ret))
				{
					return ret;
				}
				else
				{
					return 0;
				}
			}
			set
			{
				TextBox1.Text = value.ToString();
			}
		}
		public void SizeChk()
		{
			int w = Label1.Width + TextBox1.Width;
			if( fp.Width!= w)
			{
				Size sz = new Size(w, this.Height);
				this.Size = sz;
				fp.Size = sz;
			}

		}
		public int CaptionWidth
		{
			get { return Label1.Width; }
			set
			{
				if (Label1.Width != value)
				{
					Label1.Width = value;
				}
			}
		}
		public int ValueWidth
		{
			get { return TextBox1.Width; }
			set
			{
				if (TextBox1.Width != value)
				{
					TextBox1.Width = value;
				}
			}
		}
	}
}
