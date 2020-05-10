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
			this.lbInfo = new System.Windows.Forms.ListBox();
			this.lbResult = new System.Windows.Forms.ListBox();
			this.tbTargetInt = new System.Windows.Forms.TextBox();
			this.btnFindInt = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tbTargetByte = new System.Windows.Forms.TextBox();
			this.tbTargetShort = new System.Windows.Forms.TextBox();
			this.btnFinfShort = new System.Windows.Forms.Button();
			this.cmbTarget = new System.Windows.Forms.ComboBox();
			this.BtnSetup = new System.Windows.Forms.Button();
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
			this.skillValue1 = new RefrainSaveEditor.SkillValue();
			this.rvDP = new RefrainSaveEditor.RefrainValue();
			this.rvHP = new RefrainSaveEditor.RefrainValue();
			this.rvFullLevel = new RefrainSaveEditor.RefrainValue();
			this.rvLevel = new RefrainSaveEditor.RefrainValue();
			this.rvAnima = new RefrainSaveEditor.RefrainValue();
			this.rvCN = new RefrainSaveEditor.RefrainValue();
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
			this.btnCheckExp = new System.Windows.Forms.Button();
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
			this.menuStrip1.Size = new System.Drawing.Size(992, 24);
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
			this.statusStrip1.Size = new System.Drawing.Size(992, 22);
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
			// lbInfo
			// 
			this.lbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbInfo.FormattingEnabled = true;
			this.lbInfo.ItemHeight = 12;
			this.lbInfo.Location = new System.Drawing.Point(790, 205);
			this.lbInfo.Name = "lbInfo";
			this.lbInfo.Size = new System.Drawing.Size(190, 232);
			this.lbInfo.TabIndex = 19;
			// 
			// lbResult
			// 
			this.lbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbResult.FormattingEnabled = true;
			this.lbResult.ItemHeight = 12;
			this.lbResult.Location = new System.Drawing.Point(790, 104);
			this.lbResult.Name = "lbResult";
			this.lbResult.Size = new System.Drawing.Size(171, 76);
			this.lbResult.TabIndex = 20;
			// 
			// tbTargetInt
			// 
			this.tbTargetInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTargetInt.Location = new System.Drawing.Point(790, 80);
			this.tbTargetInt.Name = "tbTargetInt";
			this.tbTargetInt.Size = new System.Drawing.Size(100, 19);
			this.tbTargetInt.TabIndex = 21;
			// 
			// btnFindInt
			// 
			this.btnFindInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFindInt.Location = new System.Drawing.Point(897, 80);
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
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(896, 35);
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
			this.tbTargetByte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTargetByte.Location = new System.Drawing.Point(790, 37);
			this.tbTargetByte.Name = "tbTargetByte";
			this.tbTargetByte.Size = new System.Drawing.Size(100, 19);
			this.tbTargetByte.TabIndex = 23;
			// 
			// tbTargetShort
			// 
			this.tbTargetShort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTargetShort.Location = new System.Drawing.Point(790, 60);
			this.tbTargetShort.Name = "tbTargetShort";
			this.tbTargetShort.Size = new System.Drawing.Size(100, 19);
			this.tbTargetShort.TabIndex = 25;
			// 
			// btnFinfShort
			// 
			this.btnFinfShort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFinfShort.Location = new System.Drawing.Point(897, 57);
			this.btnFinfShort.Name = "btnFinfShort";
			this.btnFinfShort.Size = new System.Drawing.Size(75, 23);
			this.btnFinfShort.TabIndex = 26;
			this.btnFinfShort.Text = "FindShort";
			this.btnFinfShort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnFinfShort.UseVisualStyleBackColor = true;
			this.btnFinfShort.Click += new System.EventHandler(this.btnFinfShort_Click);
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
			this.cmbTarget.Location = new System.Drawing.Point(563, 339);
			this.cmbTarget.Name = "cmbTarget";
			this.cmbTarget.Size = new System.Drawing.Size(135, 20);
			this.cmbTarget.TabIndex = 57;
			// 
			// BtnSetup
			// 
			this.BtnSetup.Location = new System.Drawing.Point(704, 339);
			this.BtnSetup.Name = "BtnSetup";
			this.BtnSetup.Size = new System.Drawing.Size(64, 23);
			this.BtnSetup.TabIndex = 58;
			this.BtnSetup.Text = "Setup";
			this.BtnSetup.UseVisualStyleBackColor = true;
			this.BtnSetup.Click += new System.EventHandler(this.button2_Click);
			// 
			// vS11
			// 
			this.vS11.Location = new System.Drawing.Point(592, 306);
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
			this.vS10.Location = new System.Drawing.Point(457, 306);
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
			this.vS9.Location = new System.Drawing.Point(592, 286);
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
			this.vS8.Location = new System.Drawing.Point(457, 286);
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
			this.vS7.Location = new System.Drawing.Point(592, 266);
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
			this.vS6.Location = new System.Drawing.Point(457, 266);
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
			this.vS5.Location = new System.Drawing.Point(592, 246);
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
			this.vS4.Location = new System.Drawing.Point(457, 246);
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
			this.vS3.Location = new System.Drawing.Point(592, 226);
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
			this.vS2.Location = new System.Drawing.Point(457, 226);
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
			this.vS1.Location = new System.Drawing.Point(592, 205);
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
			this.vS0.Location = new System.Drawing.Point(457, 205);
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
			// skillValue1
			// 
			this.skillValue1.Location = new System.Drawing.Point(372, 390);
			this.skillValue1.Margin = new System.Windows.Forms.Padding(0);
			this.skillValue1.MaximumSize = new System.Drawing.Size(500, 20);
			this.skillValue1.MinimumSize = new System.Drawing.Size(50, 20);
			this.skillValue1.Name = "skillValue1";
			this.skillValue1.Offset = 0;
			this.skillValue1.SelectedIndex = 0;
			this.skillValue1.Size = new System.Drawing.Size(173, 20);
			this.skillValue1.TabIndex = 44;
			this.skillValue1.Text = "skillValue1";
			// 
			// rvDP
			// 
			this.rvDP.ButtonWidth = 40;
			this.rvDP.Caption = "DP";
			this.rvDP.CaptionWidth = 80;
			this.rvDP.Location = new System.Drawing.Point(176, 326);
			this.rvDP.Margin = new System.Windows.Forms.Padding(0);
			this.rvDP.MaxValue = 9999999;
			this.rvDP.Name = "rvDP";
			this.rvDP.Offset = 780;
			this.rvDP.Size = new System.Drawing.Size(240, 20);
			this.rvDP.StringLength = 10;
			this.rvDP.TabIndex = 31;
			this.rvDP.Text = "refrainValue1";
			this.rvDP.ValueTarget = RefrainSaveEditor.ValueTarget.CHAR_INDEX;
			this.rvDP.ValueType = RefrainSaveEditor.ValueType.INT;
			this.rvDP.ValueWidth = 120;
			// 
			// rvHP
			// 
			this.rvHP.ButtonWidth = 40;
			this.rvHP.Caption = "HP";
			this.rvHP.CaptionWidth = 80;
			this.rvHP.Location = new System.Drawing.Point(176, 306);
			this.rvHP.Margin = new System.Windows.Forms.Padding(0);
			this.rvHP.MaxValue = 9999999;
			this.rvHP.Name = "rvHP";
			this.rvHP.Offset = 776;
			this.rvHP.Size = new System.Drawing.Size(240, 20);
			this.rvHP.StringLength = 10;
			this.rvHP.TabIndex = 30;
			this.rvHP.Text = "refrainValue1";
			this.rvHP.ValueTarget = RefrainSaveEditor.ValueTarget.CHAR_INDEX;
			this.rvHP.ValueType = RefrainSaveEditor.ValueType.INT;
			this.rvHP.ValueWidth = 120;
			// 
			// rvFullLevel
			// 
			this.rvFullLevel.ButtonWidth = 40;
			this.rvFullLevel.Caption = "総Level";
			this.rvFullLevel.CaptionWidth = 80;
			this.rvFullLevel.Location = new System.Drawing.Point(176, 286);
			this.rvFullLevel.Margin = new System.Windows.Forms.Padding(0);
			this.rvFullLevel.MaxValue = 9999999;
			this.rvFullLevel.Name = "rvFullLevel";
			this.rvFullLevel.Offset = 464;
			this.rvFullLevel.Size = new System.Drawing.Size(240, 20);
			this.rvFullLevel.StringLength = 10;
			this.rvFullLevel.TabIndex = 29;
			this.rvFullLevel.Text = "refrainValue1";
			this.rvFullLevel.ValueTarget = RefrainSaveEditor.ValueTarget.CHAR_INDEX;
			this.rvFullLevel.ValueType = RefrainSaveEditor.ValueType.INT;
			this.rvFullLevel.ValueWidth = 120;
			// 
			// rvLevel
			// 
			this.rvLevel.ButtonWidth = 40;
			this.rvLevel.Caption = "Level";
			this.rvLevel.CaptionWidth = 80;
			this.rvLevel.Location = new System.Drawing.Point(176, 266);
			this.rvLevel.Margin = new System.Windows.Forms.Padding(0);
			this.rvLevel.MaxValue = 9999999;
			this.rvLevel.Name = "rvLevel";
			this.rvLevel.Offset = 459;
			this.rvLevel.Size = new System.Drawing.Size(240, 20);
			this.rvLevel.StringLength = 10;
			this.rvLevel.TabIndex = 28;
			this.rvLevel.Text = "refrainValue1";
			this.rvLevel.ValueTarget = RefrainSaveEditor.ValueTarget.CHAR_INDEX;
			this.rvLevel.ValueType = RefrainSaveEditor.ValueType.BYTE;
			this.rvLevel.ValueWidth = 120;
			// 
			// rvAnima
			// 
			this.rvAnima.ButtonWidth = 40;
			this.rvAnima.Caption = "アニマクラリティ";
			this.rvAnima.CaptionWidth = 80;
			this.rvAnima.Location = new System.Drawing.Point(176, 246);
			this.rvAnima.Margin = new System.Windows.Forms.Padding(0);
			this.rvAnima.MaxValue = 9999999;
			this.rvAnima.Name = "rvAnima";
			this.rvAnima.Offset = 458;
			this.rvAnima.Size = new System.Drawing.Size(240, 20);
			this.rvAnima.StringLength = 10;
			this.rvAnima.TabIndex = 27;
			this.rvAnima.Text = "refrainValue1";
			this.rvAnima.ValueTarget = RefrainSaveEditor.ValueTarget.CHAR_INDEX;
			this.rvAnima.ValueType = RefrainSaveEditor.ValueType.BYTE;
			this.rvAnima.ValueWidth = 120;
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
			this.rvEXT.MaxValue = 2147483647;
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
			this.rvSName.Location = new System.Drawing.Point(425, 137);
			this.rvSName.Margin = new System.Windows.Forms.Padding(0);
			this.rvSName.MaxValue = 9999999;
			this.rvSName.Name = "rvSName";
			this.rvSName.Offset = 71;
			this.rvSName.Size = new System.Drawing.Size(225, 20);
			this.rvSName.StringLength = 30;
			this.rvSName.TabIndex = 15;
			this.rvSName.Text = "refrainValue1";
			this.rvSName.ValueTarget = RefrainSaveEditor.ValueTarget.CHAR_INDEX;
			this.rvSName.ValueType = RefrainSaveEditor.ValueType.STRING;
			this.rvSName.ValueWidth = 100;
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
			this.TotalExp.MaxValue = 2147483647;
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
			this.refrainSaveFile1.AnimaClarity = this.rvAnima;
			this.refrainSaveFile1.CausalNum = this.rvCN;
			this.refrainSaveFile1.CharDP = this.rvDP;
			this.refrainSaveFile1.CharFlavorText = this.rvFText;
			this.refrainSaveFile1.CharFullLevel = this.rvFullLevel;
			this.refrainSaveFile1.CharHP = this.rvHP;
			this.refrainSaveFile1.CharIndex = 0;
			this.refrainSaveFile1.CharInfo = this.lbInfo;
			this.refrainSaveFile1.CharLevel = this.rvLevel;
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
			// btnCheckExp
			// 
			this.btnCheckExp.Location = new System.Drawing.Point(485, 37);
			this.btnCheckExp.Name = "btnCheckExp";
			this.btnCheckExp.Size = new System.Drawing.Size(75, 23);
			this.btnCheckExp.TabIndex = 59;
			this.btnCheckExp.Text = "Check Exp";
			this.btnCheckExp.UseVisualStyleBackColor = true;
			this.btnCheckExp.Click += new System.EventHandler(this.btnCheckExp_Click);
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(992, 514);
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
			this.Controls.Add(this.skillValue1);
			this.Controls.Add(this.rvDP);
			this.Controls.Add(this.rvHP);
			this.Controls.Add(this.rvFullLevel);
			this.Controls.Add(this.rvLevel);
			this.Controls.Add(this.rvAnima);
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
		private RefrainValue rvAnima;
		private RefrainValue rvLevel;
		private RefrainValue rvFullLevel;
		private RefrainValue rvHP;
		private RefrainValue rvDP;
		private SkillValue skillValue1;
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
	}
}

