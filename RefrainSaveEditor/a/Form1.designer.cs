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
			this.cmbTarget = new System.Windows.Forms.ComboBox();
			this.BtnSetup = new System.Windows.Forms.Button();
			this.btnCheckExp = new System.Windows.Forms.Button();
			this.refrainSaveFile1 = new RefrainSaveEditor.RefrainSaveFile();
			this.vS11 = new RefrainSaveEditor.SkillValue();
			this.vS10 = new RefrainSaveEditor.SkillValue();
			this.vS9 = new RefrainSaveEditor.SkillValue();
			this.vS8 = new RefrainSaveEditor.SkillValue();
			this.vS7 = new RefrainSaveEditor.SkillValue();
			this.vS6 = new RefrainSaveEditor.SkillValue();
			this.vS5 = new RefrainSaveEditor.SkillValue();
			this.vS4 = new RefrainSaveEditor.SkillValue();
			this.vS3 = new RefrainSaveEditor.SkillValue();
			this.vS2 = new RefrainSaveEditor.SkillValue();
			this.vS1 = new RefrainSaveEditor.SkillValue();
			this.vS0 = new RefrainSaveEditor.SkillValue();
			this.pvPlayerName = new RefrainSaveEditor.ParamValue();
			this.paramValue1 = new RefrainSaveEditor.ParamValue();
			this.paramValue2 = new RefrainSaveEditor.ParamValue();
			this.paramValue3 = new RefrainSaveEditor.ParamValue();
			this.paramValue4 = new RefrainSaveEditor.ParamValue();
			this.paramValue5 = new RefrainSaveEditor.ParamValue();
			this.paramValue6 = new RefrainSaveEditor.ParamValue();
			this.paramValue7 = new RefrainSaveEditor.ParamValue();
			this.paramValue8 = new RefrainSaveEditor.ParamValue();
			this.paramValue9 = new RefrainSaveEditor.ParamValue();
			this.paramValue10 = new RefrainSaveEditor.ParamValue();
			this.paramValue11 = new RefrainSaveEditor.ParamValue();
			this.paramValue12 = new RefrainSaveEditor.ParamValue();
			this.paramValue13 = new RefrainSaveEditor.ParamValue();
			this.paramValue14 = new RefrainSaveEditor.ParamValue();
			this.paramValue15 = new RefrainSaveEditor.ParamValue();
			this.paramValue16 = new RefrainSaveEditor.ParamValue();
			this.paramValue17 = new RefrainSaveEditor.ParamValue();
			this.paramValue18 = new RefrainSaveEditor.ParamValue();
			this.paramValue19 = new RefrainSaveEditor.ParamValue();
			this.paramValue20 = new RefrainSaveEditor.ParamValue();
			this.paramValue21 = new RefrainSaveEditor.ParamValue();
			this.paramValue22 = new RefrainSaveEditor.ParamValue();
			this.paramValue23 = new RefrainSaveEditor.ParamValue();
			this.paramValue24 = new RefrainSaveEditor.ParamValue();
			this.paramValue25 = new RefrainSaveEditor.ParamValue();
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
			this.menuStrip1.Size = new System.Drawing.Size(794, 24);
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
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.saveAsToolStripMenuItem.Text = "SaveAs";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
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
			this.statusStrip1.Size = new System.Drawing.Size(794, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// listBox2
			// 
			this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 12;
			this.listBox2.Location = new System.Drawing.Point(23, 35);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(127, 448);
			this.listBox2.TabIndex = 4;
			// 
			// cmbTarget
			// 
			this.cmbTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTarget.FormattingEnabled = true;
			this.cmbTarget.Items.AddRange(new object[] {
            "アステルナイト",
            "シノブシ",
            "シアトリカルスター",
            "マージナルメイズ",
            "ピアフォートレス",
            "マッドラプター",
            "ゴシックコッペリア",
            "デモンリーパー"});
			this.cmbTarget.Location = new System.Drawing.Point(167, 463);
			this.cmbTarget.Name = "cmbTarget";
			this.cmbTarget.Size = new System.Drawing.Size(135, 20);
			this.cmbTarget.TabIndex = 57;
			// 
			// BtnSetup
			// 
			this.BtnSetup.Location = new System.Drawing.Point(340, 460);
			this.BtnSetup.Name = "BtnSetup";
			this.BtnSetup.Size = new System.Drawing.Size(64, 23);
			this.BtnSetup.TabIndex = 58;
			this.BtnSetup.Text = "Setup";
			this.BtnSetup.UseVisualStyleBackColor = true;
			this.BtnSetup.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnCheckExp
			// 
			this.btnCheckExp.Location = new System.Drawing.Point(532, 38);
			this.btnCheckExp.Name = "btnCheckExp";
			this.btnCheckExp.Size = new System.Drawing.Size(75, 23);
			this.btnCheckExp.TabIndex = 59;
			this.btnCheckExp.Text = "Check Exp";
			this.btnCheckExp.UseVisualStyleBackColor = true;
			this.btnCheckExp.Click += new System.EventHandler(this.btnCheckExp_Click);
			// 
			// refrainSaveFile1
			// 
			this.refrainSaveFile1.CharIndex = 0;
			this.refrainSaveFile1.CharList = this.listBox2;
			this.refrainSaveFile1.FilePath = "";
			// 
			// vS11
			// 
			this.vS11.Location = new System.Drawing.Point(302, 426);
			this.vS11.Margin = new System.Windows.Forms.Padding(0);
			this.vS11.MaximumSize = new System.Drawing.Size(500, 20);
			this.vS11.MinimumSize = new System.Drawing.Size(50, 20);
			this.vS11.Name = "vS11";
			this.vS11.Offset = 0;
			this.vS11.SelectedIndex = 0;
			this.vS11.Size = new System.Drawing.Size(120, 20);
			this.vS11.TabIndex = 56;
			this.vS11.Text = "skillValue2";
			// 
			// vS10
			// 
			this.vS10.Location = new System.Drawing.Point(167, 426);
			this.vS10.Margin = new System.Windows.Forms.Padding(0);
			this.vS10.MaximumSize = new System.Drawing.Size(500, 20);
			this.vS10.MinimumSize = new System.Drawing.Size(50, 20);
			this.vS10.Name = "vS10";
			this.vS10.Offset = 0;
			this.vS10.SelectedIndex = 0;
			this.vS10.Size = new System.Drawing.Size(120, 20);
			this.vS10.TabIndex = 55;
			this.vS10.Text = "skillValue2";
			// 
			// vS9
			// 
			this.vS9.Location = new System.Drawing.Point(302, 406);
			this.vS9.Margin = new System.Windows.Forms.Padding(0);
			this.vS9.MaximumSize = new System.Drawing.Size(500, 20);
			this.vS9.MinimumSize = new System.Drawing.Size(50, 20);
			this.vS9.Name = "vS9";
			this.vS9.Offset = 0;
			this.vS9.SelectedIndex = 0;
			this.vS9.Size = new System.Drawing.Size(120, 20);
			this.vS9.TabIndex = 54;
			this.vS9.Text = "skillValue2";
			// 
			// vS8
			// 
			this.vS8.Location = new System.Drawing.Point(167, 406);
			this.vS8.Margin = new System.Windows.Forms.Padding(0);
			this.vS8.MaximumSize = new System.Drawing.Size(500, 20);
			this.vS8.MinimumSize = new System.Drawing.Size(50, 20);
			this.vS8.Name = "vS8";
			this.vS8.Offset = 0;
			this.vS8.SelectedIndex = 0;
			this.vS8.Size = new System.Drawing.Size(120, 20);
			this.vS8.TabIndex = 53;
			this.vS8.Text = "skillValue2";
			// 
			// vS7
			// 
			this.vS7.Location = new System.Drawing.Point(302, 386);
			this.vS7.Margin = new System.Windows.Forms.Padding(0);
			this.vS7.MaximumSize = new System.Drawing.Size(500, 20);
			this.vS7.MinimumSize = new System.Drawing.Size(50, 20);
			this.vS7.Name = "vS7";
			this.vS7.Offset = 0;
			this.vS7.SelectedIndex = 0;
			this.vS7.Size = new System.Drawing.Size(120, 20);
			this.vS7.TabIndex = 52;
			this.vS7.Text = "skillValue2";
			// 
			// vS6
			// 
			this.vS6.Location = new System.Drawing.Point(167, 386);
			this.vS6.Margin = new System.Windows.Forms.Padding(0);
			this.vS6.MaximumSize = new System.Drawing.Size(500, 20);
			this.vS6.MinimumSize = new System.Drawing.Size(50, 20);
			this.vS6.Name = "vS6";
			this.vS6.Offset = 0;
			this.vS6.SelectedIndex = 0;
			this.vS6.Size = new System.Drawing.Size(120, 20);
			this.vS6.TabIndex = 51;
			this.vS6.Text = "skillValue2";
			// 
			// vS5
			// 
			this.vS5.Location = new System.Drawing.Point(302, 366);
			this.vS5.Margin = new System.Windows.Forms.Padding(0);
			this.vS5.MaximumSize = new System.Drawing.Size(500, 20);
			this.vS5.MinimumSize = new System.Drawing.Size(50, 20);
			this.vS5.Name = "vS5";
			this.vS5.Offset = 0;
			this.vS5.SelectedIndex = 0;
			this.vS5.Size = new System.Drawing.Size(120, 20);
			this.vS5.TabIndex = 50;
			this.vS5.Text = "skillValue2";
			// 
			// vS4
			// 
			this.vS4.Location = new System.Drawing.Point(167, 366);
			this.vS4.Margin = new System.Windows.Forms.Padding(0);
			this.vS4.MaximumSize = new System.Drawing.Size(500, 20);
			this.vS4.MinimumSize = new System.Drawing.Size(50, 20);
			this.vS4.Name = "vS4";
			this.vS4.Offset = 0;
			this.vS4.SelectedIndex = 0;
			this.vS4.Size = new System.Drawing.Size(120, 20);
			this.vS4.TabIndex = 49;
			this.vS4.Text = "skillValue2";
			// 
			// vS3
			// 
			this.vS3.Location = new System.Drawing.Point(302, 346);
			this.vS3.Margin = new System.Windows.Forms.Padding(0);
			this.vS3.MaximumSize = new System.Drawing.Size(500, 20);
			this.vS3.MinimumSize = new System.Drawing.Size(50, 20);
			this.vS3.Name = "vS3";
			this.vS3.Offset = 0;
			this.vS3.SelectedIndex = 0;
			this.vS3.Size = new System.Drawing.Size(120, 20);
			this.vS3.TabIndex = 48;
			this.vS3.Text = "skillValue2";
			// 
			// vS2
			// 
			this.vS2.Location = new System.Drawing.Point(167, 346);
			this.vS2.Margin = new System.Windows.Forms.Padding(0);
			this.vS2.MaximumSize = new System.Drawing.Size(500, 20);
			this.vS2.MinimumSize = new System.Drawing.Size(50, 20);
			this.vS2.Name = "vS2";
			this.vS2.Offset = 0;
			this.vS2.SelectedIndex = 0;
			this.vS2.Size = new System.Drawing.Size(120, 20);
			this.vS2.TabIndex = 47;
			this.vS2.Text = "skillValue2";
			// 
			// vS1
			// 
			this.vS1.Location = new System.Drawing.Point(302, 325);
			this.vS1.Margin = new System.Windows.Forms.Padding(0);
			this.vS1.MaximumSize = new System.Drawing.Size(500, 20);
			this.vS1.MinimumSize = new System.Drawing.Size(50, 20);
			this.vS1.Name = "vS1";
			this.vS1.Offset = 0;
			this.vS1.SelectedIndex = 0;
			this.vS1.Size = new System.Drawing.Size(120, 20);
			this.vS1.TabIndex = 46;
			this.vS1.Text = "skillValue2";
			// 
			// vS0
			// 
			this.vS0.Location = new System.Drawing.Point(167, 325);
			this.vS0.Margin = new System.Windows.Forms.Padding(0);
			this.vS0.MaximumSize = new System.Drawing.Size(500, 20);
			this.vS0.MinimumSize = new System.Drawing.Size(50, 20);
			this.vS0.Name = "vS0";
			this.vS0.Offset = 0;
			this.vS0.SelectedIndex = 0;
			this.vS0.Size = new System.Drawing.Size(120, 20);
			this.vS0.TabIndex = 45;
			this.vS0.Text = "skillValue2";
			// 
			// pvPlayerName
			// 
			this.pvPlayerName.ButtonWidth = 40;
			this.pvPlayerName.CaptionWidth = 100;
			this.pvPlayerName.IsLocked = false;
			this.pvPlayerName.Location = new System.Drawing.Point(175, 38);
			this.pvPlayerName.Margin = new System.Windows.Forms.Padding(0);
			this.pvPlayerName.Name = "pvPlayerName";
			this.pvPlayerName.ParamValueType = RefrainSaveEditor.ParamValueType.PlayerName;
			this.pvPlayerName.RefrainSaveFile = this.refrainSaveFile1;
			this.pvPlayerName.Size = new System.Drawing.Size(260, 20);
			this.pvPlayerName.TabIndex = 60;
			this.pvPlayerName.Text = "paramValue1";
			this.pvPlayerName.ValueWidth = 120;
			// 
			// paramValue1
			// 
			this.paramValue1.ButtonWidth = 40;
			this.paramValue1.CaptionWidth = 100;
			this.paramValue1.IsLocked = false;
			this.paramValue1.Location = new System.Drawing.Point(175, 58);
			this.paramValue1.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue1.Name = "paramValue1";
			this.paramValue1.ParamValueType = RefrainSaveEditor.ParamValueType.Coins;
			this.paramValue1.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue1.Size = new System.Drawing.Size(260, 20);
			this.paramValue1.TabIndex = 61;
			this.paramValue1.Text = "paramValue1";
			this.paramValue1.ValueWidth = 120;
			// 
			// paramValue2
			// 
			this.paramValue2.ButtonWidth = 40;
			this.paramValue2.CaptionWidth = 100;
			this.paramValue2.IsLocked = false;
			this.paramValue2.Location = new System.Drawing.Point(175, 78);
			this.paramValue2.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue2.Name = "paramValue2";
			this.paramValue2.ParamValueType = RefrainSaveEditor.ParamValueType.Mana;
			this.paramValue2.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue2.Size = new System.Drawing.Size(260, 20);
			this.paramValue2.TabIndex = 62;
			this.paramValue2.Text = "paramValue2";
			this.paramValue2.ValueWidth = 120;
			// 
			// paramValue3
			// 
			this.paramValue3.ButtonWidth = 40;
			this.paramValue3.CaptionWidth = 100;
			this.paramValue3.IsLocked = false;
			this.paramValue3.Location = new System.Drawing.Point(175, 98);
			this.paramValue3.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue3.Name = "paramValue3";
			this.paramValue3.ParamValueType = RefrainSaveEditor.ParamValueType.Karma;
			this.paramValue3.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue3.Size = new System.Drawing.Size(260, 20);
			this.paramValue3.TabIndex = 63;
			this.paramValue3.Text = "paramValue3";
			this.paramValue3.ValueWidth = 120;
			// 
			// paramValue4
			// 
			this.paramValue4.ButtonWidth = 40;
			this.paramValue4.CaptionWidth = 100;
			this.paramValue4.IsLocked = true;
			this.paramValue4.Location = new System.Drawing.Point(175, 140);
			this.paramValue4.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue4.Name = "paramValue4";
			this.paramValue4.ParamValueType = RefrainSaveEditor.ParamValueType.Num;
			this.paramValue4.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue4.Size = new System.Drawing.Size(260, 20);
			this.paramValue4.TabIndex = 64;
			this.paramValue4.Text = "paramValue4";
			this.paramValue4.ValueWidth = 120;
			// 
			// paramValue5
			// 
			this.paramValue5.ButtonWidth = 40;
			this.paramValue5.CaptionWidth = 100;
			this.paramValue5.IsLocked = false;
			this.paramValue5.Location = new System.Drawing.Point(175, 160);
			this.paramValue5.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue5.Name = "paramValue5";
			this.paramValue5.ParamValueType = RefrainSaveEditor.ParamValueType.NAME;
			this.paramValue5.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue5.Size = new System.Drawing.Size(260, 20);
			this.paramValue5.TabIndex = 65;
			this.paramValue5.Text = "paramValue5";
			this.paramValue5.ValueWidth = 120;
			// 
			// paramValue6
			// 
			this.paramValue6.ButtonWidth = 40;
			this.paramValue6.CaptionWidth = 70;
			this.paramValue6.IsLocked = false;
			this.paramValue6.Location = new System.Drawing.Point(442, 160);
			this.paramValue6.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue6.Name = "paramValue6";
			this.paramValue6.ParamValueType = RefrainSaveEditor.ParamValueType.SHORTNAME;
			this.paramValue6.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue6.Size = new System.Drawing.Size(234, 20);
			this.paramValue6.TabIndex = 66;
			this.paramValue6.Text = "paramValue6";
			this.paramValue6.ValueWidth = 120;
			// 
			// paramValue7
			// 
			this.paramValue7.ButtonWidth = 40;
			this.paramValue7.CaptionWidth = 100;
			this.paramValue7.IsLocked = false;
			this.paramValue7.Location = new System.Drawing.Point(175, 180);
			this.paramValue7.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue7.Name = "paramValue7";
			this.paramValue7.ParamValueType = RefrainSaveEditor.ParamValueType.FLAVERTEXT;
			this.paramValue7.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue7.Size = new System.Drawing.Size(501, 20);
			this.paramValue7.TabIndex = 67;
			this.paramValue7.Text = "paramValue7";
			this.paramValue7.ValueWidth = 360;
			// 
			// paramValue8
			// 
			this.paramValue8.ButtonWidth = 40;
			this.paramValue8.CaptionWidth = 100;
			this.paramValue8.IsLocked = true;
			this.paramValue8.Location = new System.Drawing.Point(175, 216);
			this.paramValue8.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue8.Name = "paramValue8";
			this.paramValue8.ParamValueType = RefrainSaveEditor.ParamValueType.VISUAL;
			this.paramValue8.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue8.Size = new System.Drawing.Size(260, 20);
			this.paramValue8.TabIndex = 68;
			this.paramValue8.Text = "paramValue8";
			this.paramValue8.ValueWidth = 120;
			// 
			// paramValue9
			// 
			this.paramValue9.ButtonWidth = 40;
			this.paramValue9.CaptionWidth = 50;
			this.paramValue9.IsLocked = false;
			this.paramValue9.Location = new System.Drawing.Point(442, 216);
			this.paramValue9.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue9.Name = "paramValue9";
			this.paramValue9.ParamValueType = RefrainSaveEditor.ParamValueType.CAUSAL;
			this.paramValue9.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue9.Size = new System.Drawing.Size(221, 20);
			this.paramValue9.TabIndex = 69;
			this.paramValue9.Text = "paramValue9";
			this.paramValue9.ValueWidth = 120;
			// 
			// paramValue10
			// 
			this.paramValue10.ButtonWidth = 40;
			this.paramValue10.CaptionWidth = 100;
			this.paramValue10.IsLocked = false;
			this.paramValue10.Location = new System.Drawing.Point(175, 236);
			this.paramValue10.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue10.Name = "paramValue10";
			this.paramValue10.ParamValueType = RefrainSaveEditor.ParamValueType.ANIMA;
			this.paramValue10.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue10.Size = new System.Drawing.Size(260, 20);
			this.paramValue10.TabIndex = 70;
			this.paramValue10.Text = "paramValue10";
			this.paramValue10.ValueWidth = 120;
			// 
			// paramValue11
			// 
			this.paramValue11.ButtonWidth = 40;
			this.paramValue11.CaptionWidth = 100;
			this.paramValue11.IsLocked = false;
			this.paramValue11.Location = new System.Drawing.Point(175, 256);
			this.paramValue11.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue11.Name = "paramValue11";
			this.paramValue11.ParamValueType = RefrainSaveEditor.ParamValueType.LEVEL;
			this.paramValue11.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue11.Size = new System.Drawing.Size(260, 20);
			this.paramValue11.TabIndex = 71;
			this.paramValue11.Text = "paramValue11";
			this.paramValue11.ValueWidth = 120;
			// 
			// paramValue12
			// 
			this.paramValue12.ButtonWidth = 40;
			this.paramValue12.CaptionWidth = 100;
			this.paramValue12.IsLocked = false;
			this.paramValue12.Location = new System.Drawing.Point(175, 276);
			this.paramValue12.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue12.Name = "paramValue12";
			this.paramValue12.ParamValueType = RefrainSaveEditor.ParamValueType.EXP;
			this.paramValue12.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue12.Size = new System.Drawing.Size(260, 20);
			this.paramValue12.TabIndex = 72;
			this.paramValue12.Text = "paramValue12";
			this.paramValue12.ValueWidth = 120;
			// 
			// paramValue13
			// 
			this.paramValue13.ButtonWidth = 40;
			this.paramValue13.CaptionWidth = 50;
			this.paramValue13.IsLocked = false;
			this.paramValue13.Location = new System.Drawing.Point(442, 256);
			this.paramValue13.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue13.Name = "paramValue13";
			this.paramValue13.ParamValueType = RefrainSaveEditor.ParamValueType.FULL_LEVEL;
			this.paramValue13.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue13.Size = new System.Drawing.Size(221, 20);
			this.paramValue13.TabIndex = 73;
			this.paramValue13.Text = "paramValue13";
			this.paramValue13.ValueWidth = 120;
			// 
			// paramValue14
			// 
			this.paramValue14.ButtonWidth = 40;
			this.paramValue14.CaptionWidth = 100;
			this.paramValue14.IsLocked = false;
			this.paramValue14.Location = new System.Drawing.Point(175, 296);
			this.paramValue14.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue14.Name = "paramValue14";
			this.paramValue14.ParamValueType = RefrainSaveEditor.ParamValueType.TOTAL_EXP;
			this.paramValue14.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue14.Size = new System.Drawing.Size(260, 20);
			this.paramValue14.TabIndex = 74;
			this.paramValue14.Text = "paramValue14";
			this.paramValue14.ValueWidth = 120;
			// 
			// paramValue15
			// 
			this.paramValue15.ButtonWidth = 40;
			this.paramValue15.CaptionWidth = 50;
			this.paramValue15.IsLocked = false;
			this.paramValue15.Location = new System.Drawing.Point(442, 276);
			this.paramValue15.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue15.Name = "paramValue15";
			this.paramValue15.ParamValueType = RefrainSaveEditor.ParamValueType.MAX_HP;
			this.paramValue15.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue15.Size = new System.Drawing.Size(260, 20);
			this.paramValue15.TabIndex = 75;
			this.paramValue15.Text = "paramValue15";
			this.paramValue15.ValueWidth = 120;
			// 
			// paramValue16
			// 
			this.paramValue16.ButtonWidth = 40;
			this.paramValue16.CaptionWidth = 50;
			this.paramValue16.IsLocked = false;
			this.paramValue16.Location = new System.Drawing.Point(442, 296);
			this.paramValue16.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue16.Name = "paramValue16";
			this.paramValue16.ParamValueType = RefrainSaveEditor.ParamValueType.MAX_DP;
			this.paramValue16.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue16.Size = new System.Drawing.Size(260, 20);
			this.paramValue16.TabIndex = 76;
			this.paramValue16.Text = "paramValue16";
			this.paramValue16.ValueWidth = 120;
			// 
			// paramValue17
			// 
			this.paramValue17.ButtonWidth = 40;
			this.paramValue17.CaptionWidth = 40;
			this.paramValue17.IsLocked = false;
			this.paramValue17.Location = new System.Drawing.Point(452, 325);
			this.paramValue17.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue17.Name = "paramValue17";
			this.paramValue17.ParamValueType = RefrainSaveEditor.ParamValueType.STR;
			this.paramValue17.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue17.Size = new System.Drawing.Size(146, 20);
			this.paramValue17.TabIndex = 77;
			this.paramValue17.Text = "paramValue17";
			this.paramValue17.ValueWidth = 60;
			// 
			// paramValue18
			// 
			this.paramValue18.ButtonWidth = 40;
			this.paramValue18.CaptionWidth = 40;
			this.paramValue18.IsLocked = false;
			this.paramValue18.Location = new System.Drawing.Point(452, 346);
			this.paramValue18.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue18.Name = "paramValue18";
			this.paramValue18.ParamValueType = RefrainSaveEditor.ParamValueType.CON;
			this.paramValue18.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue18.Size = new System.Drawing.Size(146, 20);
			this.paramValue18.TabIndex = 78;
			this.paramValue18.Text = "paramValue18";
			this.paramValue18.ValueWidth = 60;
			// 
			// paramValue19
			// 
			this.paramValue19.ButtonWidth = 40;
			this.paramValue19.CaptionWidth = 40;
			this.paramValue19.IsLocked = false;
			this.paramValue19.Location = new System.Drawing.Point(452, 366);
			this.paramValue19.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue19.Name = "paramValue19";
			this.paramValue19.ParamValueType = RefrainSaveEditor.ParamValueType.DMP;
			this.paramValue19.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue19.Size = new System.Drawing.Size(146, 20);
			this.paramValue19.TabIndex = 79;
			this.paramValue19.Text = "paramValue19";
			this.paramValue19.ValueWidth = 60;
			// 
			// paramValue20
			// 
			this.paramValue20.ButtonWidth = 40;
			this.paramValue20.CaptionWidth = 40;
			this.paramValue20.IsLocked = false;
			this.paramValue20.Location = new System.Drawing.Point(598, 325);
			this.paramValue20.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue20.Name = "paramValue20";
			this.paramValue20.ParamValueType = RefrainSaveEditor.ParamValueType.AGI;
			this.paramValue20.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue20.Size = new System.Drawing.Size(146, 20);
			this.paramValue20.TabIndex = 80;
			this.paramValue20.Text = "paramValue20";
			this.paramValue20.ValueWidth = 60;
			// 
			// paramValue21
			// 
			this.paramValue21.ButtonWidth = 40;
			this.paramValue21.CaptionWidth = 40;
			this.paramValue21.IsLocked = false;
			this.paramValue21.Location = new System.Drawing.Point(598, 346);
			this.paramValue21.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue21.Name = "paramValue21";
			this.paramValue21.ParamValueType = RefrainSaveEditor.ParamValueType.DEX;
			this.paramValue21.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue21.Size = new System.Drawing.Size(146, 20);
			this.paramValue21.TabIndex = 81;
			this.paramValue21.Text = "paramValue21";
			this.paramValue21.ValueWidth = 60;
			// 
			// paramValue22
			// 
			this.paramValue22.ButtonWidth = 40;
			this.paramValue22.CaptionWidth = 40;
			this.paramValue22.IsLocked = false;
			this.paramValue22.Location = new System.Drawing.Point(598, 366);
			this.paramValue22.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue22.Name = "paramValue22";
			this.paramValue22.ParamValueType = RefrainSaveEditor.ParamValueType.ERS;
			this.paramValue22.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue22.Size = new System.Drawing.Size(146, 20);
			this.paramValue22.TabIndex = 82;
			this.paramValue22.Text = "paramValue22";
			this.paramValue22.ValueWidth = 60;
			// 
			// paramValue23
			// 
			this.paramValue23.ButtonWidth = 40;
			this.paramValue23.CaptionWidth = 40;
			this.paramValue23.IsLocked = false;
			this.paramValue23.Location = new System.Drawing.Point(598, 386);
			this.paramValue23.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue23.Name = "paramValue23";
			this.paramValue23.ParamValueType = RefrainSaveEditor.ParamValueType.LUC;
			this.paramValue23.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue23.Size = new System.Drawing.Size(146, 20);
			this.paramValue23.TabIndex = 83;
			this.paramValue23.Text = "paramValue23";
			this.paramValue23.ValueWidth = 60;
			// 
			// paramValue24
			// 
			this.paramValue24.ButtonWidth = 40;
			this.paramValue24.CaptionWidth = 40;
			this.paramValue24.IsLocked = false;
			this.paramValue24.Location = new System.Drawing.Point(472, 140);
			this.paramValue24.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue24.Name = "paramValue24";
			this.paramValue24.ParamValueType = RefrainSaveEditor.ParamValueType.HP;
			this.paramValue24.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue24.Size = new System.Drawing.Size(146, 20);
			this.paramValue24.TabIndex = 84;
			this.paramValue24.Text = "paramValue24";
			this.paramValue24.ValueWidth = 60;
			// 
			// paramValue25
			// 
			this.paramValue25.ButtonWidth = 40;
			this.paramValue25.CaptionWidth = 40;
			this.paramValue25.IsLocked = false;
			this.paramValue25.Location = new System.Drawing.Point(607, 140);
			this.paramValue25.Margin = new System.Windows.Forms.Padding(0);
			this.paramValue25.Name = "paramValue25";
			this.paramValue25.ParamValueType = RefrainSaveEditor.ParamValueType.DP;
			this.paramValue25.RefrainSaveFile = this.refrainSaveFile1;
			this.paramValue25.Size = new System.Drawing.Size(146, 20);
			this.paramValue25.TabIndex = 85;
			this.paramValue25.Text = "paramValue25";
			this.paramValue25.ValueWidth = 60;
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(794, 514);
			this.Controls.Add(this.paramValue25);
			this.Controls.Add(this.paramValue24);
			this.Controls.Add(this.paramValue23);
			this.Controls.Add(this.paramValue22);
			this.Controls.Add(this.paramValue21);
			this.Controls.Add(this.paramValue20);
			this.Controls.Add(this.paramValue19);
			this.Controls.Add(this.paramValue18);
			this.Controls.Add(this.paramValue17);
			this.Controls.Add(this.paramValue16);
			this.Controls.Add(this.paramValue15);
			this.Controls.Add(this.paramValue14);
			this.Controls.Add(this.paramValue13);
			this.Controls.Add(this.paramValue12);
			this.Controls.Add(this.paramValue11);
			this.Controls.Add(this.paramValue10);
			this.Controls.Add(this.paramValue9);
			this.Controls.Add(this.paramValue8);
			this.Controls.Add(this.paramValue7);
			this.Controls.Add(this.paramValue6);
			this.Controls.Add(this.paramValue5);
			this.Controls.Add(this.paramValue4);
			this.Controls.Add(this.paramValue3);
			this.Controls.Add(this.paramValue2);
			this.Controls.Add(this.paramValue1);
			this.Controls.Add(this.pvPlayerName);
			this.Controls.Add(this.btnCheckExp);
			this.Controls.Add(this.BtnSetup);
			this.Controls.Add(this.cmbTarget);
			this.Controls.Add(this.vS11);
			this.Controls.Add(this.vS10);
			this.Controls.Add(this.vS9);
			this.Controls.Add(this.vS8);
			this.Controls.Add(this.vS7);
			this.Controls.Add(this.vS6);
			this.Controls.Add(this.vS5);
			this.Controls.Add(this.vS4);
			this.Controls.Add(this.vS3);
			this.Controls.Add(this.vS2);
			this.Controls.Add(this.vS1);
			this.Controls.Add(this.vS0);
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
		private SkillValue vS0;
		private SkillValue vS1;
		private SkillValue vS2;
		private SkillValue vS3;
		private SkillValue vS4;
		private SkillValue vS5;
		private SkillValue vS6;
		private SkillValue vS7;
		private SkillValue vS8;
		private SkillValue vS9;
		private SkillValue vS10;
		private SkillValue vS11;
		private System.Windows.Forms.ComboBox cmbTarget;
		private System.Windows.Forms.Button BtnSetup;
		private System.Windows.Forms.Button btnCheckExp;
		private ParamValue pvPlayerName;
		private ParamValue paramValue1;
		private ParamValue paramValue2;
		private ParamValue paramValue3;
		private ParamValue paramValue4;
		private ParamValue paramValue5;
		private ParamValue paramValue6;
		private ParamValue paramValue7;
		private ParamValue paramValue8;
		private ParamValue paramValue9;
		private ParamValue paramValue10;
		private ParamValue paramValue11;
		private ParamValue paramValue12;
		private ParamValue paramValue13;
		private ParamValue paramValue14;
		private ParamValue paramValue15;
		private ParamValue paramValue16;
		private ParamValue paramValue17;
		private ParamValue paramValue18;
		private ParamValue paramValue19;
		private ParamValue paramValue20;
		private ParamValue paramValue21;
		private ParamValue paramValue22;
		private ParamValue paramValue23;
		private ParamValue paramValue24;
		private ParamValue paramValue25;
	}
}

