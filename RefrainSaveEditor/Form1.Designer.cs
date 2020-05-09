namespace RefrainSaveEditor
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.rvFText = new RefrainSaveEditor.RefrainValue();
			this.rvEXT = new RefrainSaveEditor.RefrainValue();
			this.rvSName = new RefrainSaveEditor.RefrainValue();
			this.rvCharName = new RefrainSaveEditor.RefrainValue();
			this.rvKaruma = new RefrainSaveEditor.RefrainValue();
			this.rvMana = new RefrainSaveEditor.RefrainValue();
			this.rvCoin = new RefrainSaveEditor.RefrainValue();
			this.rvPlayerName = new RefrainSaveEditor.RefrainValue();
			this.TotalExp = new RefrainSaveEditor.RefrainValue();
			this.refrainSaveFile1 = new RefrainSaveEditor.RefrainSaveFile();
			this.rvCN = new RefrainSaveEditor.RefrainValue();
			this.lbInfo = new System.Windows.Forms.ListBox();
			this.lbResult = new System.Windows.Forms.ListBox();
			this.tbTargetInt = new System.Windows.Forms.TextBox();
			this.btnFindInt = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tbTargetByte = new System.Windows.Forms.TextBox();
			this.tbTargetShort = new System.Windows.Forms.TextBox();
			this.btnFinfShort = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(821, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.quitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.saveAsToolStripMenuItem.Text = "SaveAs";
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.quitToolStripMenuItem.Text = "Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.aboutToolStripMenuItem.Text = "バージョン情報の表示";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 492);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(821, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 12;
			this.listBox2.Location = new System.Drawing.Point(23, 35);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(127, 448);
			this.listBox2.TabIndex = 4;
			// 
			// rvFText
			// 
			this.rvFText.ButtonWidth = 40;
			this.rvFText.Caption = "Flavor Text";
			this.rvFText.CaptionWidth = 80;
			this.rvFText.Location = new System.Drawing.Point(176, 157);
			this.rvFText.Margin = new System.Windows.Forms.Padding(0);
			this.rvFText.MaxValue = 9999999;
			this.rvFText.Name = "rvFText";
			this.rvFText.Offset = 101;
			this.rvFText.Size = new System.Drawing.Size(485, 24);
			this.rvFText.StringLength = 246;
			this.rvFText.TabIndex = 17;
			this.rvFText.Text = "refrainValue1";
			this.rvFText.ValueTarget = RefrainSaveEditor.ValueTarget.CHAR_INDEX;
			this.rvFText.ValueType = RefrainSaveEditor.ValueType.STRING;
			this.rvFText.ValueWidth = 350;
			// 
			// rvEXT
			// 
			this.rvEXT.ButtonWidth = 40;
			this.rvEXT.Caption = "EXP";
			this.rvEXT.CaptionWidth = 80;
			this.rvEXT.Location = new System.Drawing.Point(176, 205);
			this.rvEXT.Margin = new System.Windows.Forms.Padding(0);
			this.rvEXT.MaxValue = 9999999;
			this.rvEXT.Name = "rvEXT";
			this.rvEXT.Offset = 460;
			this.rvEXT.Size = new System.Drawing.Size(240, 20);
			this.rvEXT.StringLength = 10;
			this.rvEXT.TabIndex = 16;
			this.rvEXT.Text = "refrainValue1";
			this.rvEXT.ValueTarget = RefrainSaveEditor.ValueTarget.CHAR_INDEX;
			this.rvEXT.ValueType = RefrainSaveEditor.ValueType.INT;
			this.rvEXT.ValueWidth = 120;
			// 
			// rvSName
			// 
			this.rvSName.ButtonWidth = 40;
			this.rvSName.Caption = "SHORT NAME";
			this.rvSName.CaptionWidth = 80;
			this.rvSName.Location = new System.Drawing.Point(421, 137);
			this.rvSName.Margin = new System.Windows.Forms.Padding(0);
			this.rvSName.MaxValue = 9999999;
			this.rvSName.Name = "rvSName";
			this.rvSName.Offset = 71;
			this.rvSName.Size = new System.Drawing.Size(240, 20);
			this.rvSName.StringLength = 30;
			this.rvSName.TabIndex = 15;
			this.rvSName.Text = "refrainValue1";
			this.rvSName.ValueTarget = RefrainSaveEditor.ValueTarget.CHAR_INDEX;
			this.rvSName.ValueType = RefrainSaveEditor.ValueType.STRING;
			this.rvSName.ValueWidth = 120;
			// 
			// rvCharName
			// 
			this.rvCharName.ButtonWidth = 40;
			this.rvCharName.Caption = "NAME";
			this.rvCharName.CaptionWidth = 80;
			this.rvCharName.Location = new System.Drawing.Point(176, 137);
			this.rvCharName.Margin = new System.Windows.Forms.Padding(0);
			this.rvCharName.MaxValue = 9999999;
			this.rvCharName.Name = "rvCharName";
			this.rvCharName.Offset = 5;
			this.rvCharName.Size = new System.Drawing.Size(240, 20);
			this.rvCharName.StringLength = 66;
			this.rvCharName.TabIndex = 14;
			this.rvCharName.Text = "refrainValue1";
			this.rvCharName.ValueTarget = RefrainSaveEditor.ValueTarget.CHAR_INDEX;
			this.rvCharName.ValueType = RefrainSaveEditor.ValueType.STRING;
			this.rvCharName.ValueWidth = 120;
			// 
			// rvKaruma
			// 
			this.rvKaruma.ButtonWidth = 40;
			this.rvKaruma.Caption = "カルマ";
			this.rvKaruma.CaptionWidth = 80;
			this.rvKaruma.Location = new System.Drawing.Point(176, 95);
			this.rvKaruma.Margin = new System.Windows.Forms.Padding(0);
			this.rvKaruma.MaxValue = 100;
			this.rvKaruma.Name = "rvKaruma";
			this.rvKaruma.Offset = 98;
			this.rvKaruma.Size = new System.Drawing.Size(240, 20);
			this.rvKaruma.StringLength = 10;
			this.rvKaruma.TabIndex = 13;
			this.rvKaruma.ValueTarget = RefrainSaveEditor.ValueTarget.ABS_POS;
			this.rvKaruma.ValueType = RefrainSaveEditor.ValueType.INT;
			this.rvKaruma.ValueWidth = 120;
			// 
			// rvMana
			// 
			this.rvMana.ButtonWidth = 40;
			this.rvMana.Caption = "Mana";
			this.rvMana.CaptionWidth = 80;
			this.rvMana.Location = new System.Drawing.Point(176, 75);
			this.rvMana.Margin = new System.Windows.Forms.Padding(0);
			this.rvMana.MaxValue = 9999999;
			this.rvMana.Name = "rvMana";
			this.rvMana.Offset = 94;
			this.rvMana.Size = new System.Drawing.Size(240, 20);
			this.rvMana.StringLength = 10;
			this.rvMana.TabIndex = 12;
			this.rvMana.Text = "refrainValue1";
			this.rvMana.ValueTarget = RefrainSaveEditor.ValueTarget.ABS_POS;
			this.rvMana.ValueType = RefrainSaveEditor.ValueType.INT;
			this.rvMana.ValueWidth = 120;
			// 
			// rvCoin
			// 
			this.rvCoin.ButtonWidth = 40;
			this.rvCoin.Caption = "銀貨";
			this.rvCoin.CaptionWidth = 80;
			this.rvCoin.Location = new System.Drawing.Point(176, 55);
			this.rvCoin.Margin = new System.Windows.Forms.Padding(0);
			this.rvCoin.MaxValue = 9999999;
			this.rvCoin.Name = "rvCoin";
			this.rvCoin.Offset = 86;
			this.rvCoin.Size = new System.Drawing.Size(240, 20);
			this.rvCoin.StringLength = 10;
			this.rvCoin.TabIndex = 11;
			this.rvCoin.Text = "refrainValue1";
			this.rvCoin.ValueTarget = RefrainSaveEditor.ValueTarget.ABS_POS;
			this.rvCoin.ValueType = RefrainSaveEditor.ValueType.INT;
			this.rvCoin.ValueWidth = 120;
			// 
			// rvPlayerName
			// 
			this.rvPlayerName.ButtonWidth = 40;
			this.rvPlayerName.Caption = "Player Name";
			this.rvPlayerName.CaptionWidth = 80;
			this.rvPlayerName.Location = new System.Drawing.Point(176, 35);
			this.rvPlayerName.Margin = new System.Windows.Forms.Padding(0);
			this.rvPlayerName.MaxValue = 9999999;
			this.rvPlayerName.Name = "rvPlayerName";
			this.rvPlayerName.Offset = 32;
			this.rvPlayerName.Size = new System.Drawing.Size(265, 20);
			this.rvPlayerName.StringLength = 54;
			this.rvPlayerName.TabIndex = 10;
			this.rvPlayerName.Text = "refrainValue1";
			this.rvPlayerName.ValueTarget = RefrainSaveEditor.ValueTarget.ABS_POS;
			this.rvPlayerName.ValueType = RefrainSaveEditor.ValueType.STRING;
			this.rvPlayerName.ValueWidth = 120;
			// 
			// TotalExp
			// 
			this.TotalExp.ButtonWidth = 40;
			this.TotalExp.Caption = "TOTAL EXP";
			this.TotalExp.CaptionWidth = 80;
			this.TotalExp.Location = new System.Drawing.Point(176, 225);
			this.TotalExp.Margin = new System.Windows.Forms.Padding(0);
			this.TotalExp.MaxValue = 9999999;
			this.TotalExp.Name = "TotalExp";
			this.TotalExp.Offset = 468;
			this.TotalExp.Size = new System.Drawing.Size(257, 21);
			this.TotalExp.StringLength = 10;
			this.TotalExp.TabIndex = 7;
			this.TotalExp.Text = "refrainCharValue1";
			this.TotalExp.ValueTarget = RefrainSaveEditor.ValueTarget.CHAR_INDEX;
			this.TotalExp.ValueType = RefrainSaveEditor.ValueType.INT;
			this.TotalExp.ValueWidth = 120;
			// 
			// refrainSaveFile1
			// 
			this.refrainSaveFile1.CausalNum = this.rvCN;
			this.refrainSaveFile1.CharFlavorText = this.rvFText;
			this.refrainSaveFile1.CharIndex = 0;
			this.refrainSaveFile1.CharInfo = this.lbInfo;
			this.refrainSaveFile1.CharList = this.listBox2;
			this.refrainSaveFile1.CharNmae = this.rvCharName;
			this.refrainSaveFile1.CharShortNmae = this.rvSName;
			this.refrainSaveFile1.CoinValue = this.rvCoin;
			this.refrainSaveFile1.EXP = this.rvEXT;
			this.refrainSaveFile1.FilePath = "";
			this.refrainSaveFile1.KarumaValue = this.rvKaruma;
			this.refrainSaveFile1.ManaValue = this.rvMana;
			this.refrainSaveFile1.PlayerName = this.rvPlayerName;
			this.refrainSaveFile1.TotalEXP = this.TotalExp;
			// 
			// rvCN
			// 
			this.rvCN.ButtonWidth = 40;
			this.rvCN.Caption = "因果数";
			this.rvCN.CaptionWidth = 80;
			this.rvCN.Location = new System.Drawing.Point(176, 181);
			this.rvCN.Margin = new System.Windows.Forms.Padding(0);
			this.rvCN.MaxValue = 99;
			this.rvCN.Name = "rvCN";
			this.rvCN.Offset = 364;
			this.rvCN.Size = new System.Drawing.Size(240, 20);
			this.rvCN.StringLength = 10;
			this.rvCN.TabIndex = 18;
			this.rvCN.Text = "refrainValue1";
			this.rvCN.ValueTarget = RefrainSaveEditor.ValueTarget.CHAR_INDEX;
			this.rvCN.ValueType = RefrainSaveEditor.ValueType.INT;
			this.rvCN.ValueWidth = 120;
			// 
			// lbInfo
			// 
			this.lbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbInfo.FormattingEnabled = true;
			this.lbInfo.ItemHeight = 12;
			this.lbInfo.Location = new System.Drawing.Point(188, 249);
			this.lbInfo.Name = "lbInfo";
			this.lbInfo.Size = new System.Drawing.Size(396, 232);
			this.lbInfo.TabIndex = 19;
			// 
			// lbResult
			// 
			this.lbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbResult.FormattingEnabled = true;
			this.lbResult.ItemHeight = 12;
			this.lbResult.Location = new System.Drawing.Point(623, 249);
			this.lbResult.Name = "lbResult";
			this.lbResult.Size = new System.Drawing.Size(171, 232);
			this.lbResult.TabIndex = 20;
			// 
			// tbTargetInt
			// 
			this.tbTargetInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTargetInt.Location = new System.Drawing.Point(623, 225);
			this.tbTargetInt.Name = "tbTargetInt";
			this.tbTargetInt.Size = new System.Drawing.Size(100, 19);
			this.tbTargetInt.TabIndex = 21;
			// 
			// btnFindInt
			// 
			this.btnFindInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFindInt.Location = new System.Drawing.Point(730, 225);
			this.btnFindInt.Name = "btnFindInt";
			this.btnFindInt.Size = new System.Drawing.Size(75, 23);
			this.btnFindInt.TabIndex = 22;
			this.btnFindInt.Text = "FindInt";
			this.btnFindInt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnFindInt.UseVisualStyleBackColor = true;
			this.btnFindInt.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(729, 180);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 24;
			this.button1.Text = "FindByte";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// tbTargetByte
			// 
			this.tbTargetByte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTargetByte.Location = new System.Drawing.Point(623, 182);
			this.tbTargetByte.Name = "tbTargetByte";
			this.tbTargetByte.Size = new System.Drawing.Size(100, 19);
			this.tbTargetByte.TabIndex = 23;
			// 
			// tbTargetShort
			// 
			this.tbTargetShort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTargetShort.Location = new System.Drawing.Point(623, 205);
			this.tbTargetShort.Name = "tbTargetShort";
			this.tbTargetShort.Size = new System.Drawing.Size(100, 19);
			this.tbTargetShort.TabIndex = 25;
			// 
			// btnFinfShort
			// 
			this.btnFinfShort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFinfShort.Location = new System.Drawing.Point(730, 202);
			this.btnFinfShort.Name = "btnFinfShort";
			this.btnFinfShort.Size = new System.Drawing.Size(75, 23);
			this.btnFinfShort.TabIndex = 26;
			this.btnFinfShort.Text = "FindShort";
			this.btnFinfShort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnFinfShort.UseVisualStyleBackColor = true;
			this.btnFinfShort.Click += new System.EventHandler(this.btnFinfShort_Click);
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(821, 514);
			this.Controls.Add(this.btnFinfShort);
			this.Controls.Add(this.tbTargetShort);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tbTargetByte);
			this.Controls.Add(this.btnFindInt);
			this.Controls.Add(this.tbTargetInt);
			this.Controls.Add(this.lbResult);
			this.Controls.Add(this.lbInfo);
			this.Controls.Add(this.rvCN);
			this.Controls.Add(this.rvFText);
			this.Controls.Add(this.rvEXT);
			this.Controls.Add(this.rvSName);
			this.Controls.Add(this.rvCharName);
			this.Controls.Add(this.rvKaruma);
			this.Controls.Add(this.rvMana);
			this.Controls.Add(this.rvCoin);
			this.Controls.Add(this.rvPlayerName);
			this.Controls.Add(this.TotalExp);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private RefrainSaveFile refrainSaveFile1;
		private System.Windows.Forms.ListBox listBox2;
		private RefrainValue TotalExp;
		private RefrainValue rvPlayerName;
		private RefrainValue rvCoin;
		private RefrainValue rvKaruma;
		private RefrainValue rvMana;
		private RefrainValue rvCharName;
		private RefrainValue rvSName;
		private RefrainValue rvEXT;
		private RefrainValue rvFText;
		private RefrainValue rvCN;
		private System.Windows.Forms.ListBox lbInfo;
		private System.Windows.Forms.ListBox lbResult;
		private System.Windows.Forms.TextBox tbTargetInt;
		private System.Windows.Forms.Button btnFindInt;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tbTargetByte;
		private System.Windows.Forms.TextBox tbTargetShort;
		private System.Windows.Forms.Button btnFinfShort;
	}
}

