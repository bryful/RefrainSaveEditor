﻿namespace RefrainCTE
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.numMana = new System.Windows.Forms.NumericUpDown();
			this.numKARUMA = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.numRF = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.numCO = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.btnExport = new System.Windows.Forms.Button();
			this.btnExport2 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.numCharHP = new RefrainCTE.NumBox();
			((System.ComponentModel.ISupportInitialize)(this.numMana)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numKARUMA)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numRF)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numCO)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(99, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "MANA";
			// 
			// numMana
			// 
			this.numMana.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.numMana.Hexadecimal = true;
			this.numMana.Location = new System.Drawing.Point(164, 61);
			this.numMana.Name = "numMana";
			this.numMana.Size = new System.Drawing.Size(120, 26);
			this.numMana.TabIndex = 1;
			// 
			// numKARUMA
			// 
			this.numKARUMA.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.numKARUMA.Hexadecimal = true;
			this.numKARUMA.Location = new System.Drawing.Point(164, 93);
			this.numKARUMA.Name = "numKARUMA";
			this.numKARUMA.Size = new System.Drawing.Size(120, 26);
			this.numKARUMA.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(99, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "カルマ";
			// 
			// numRF
			// 
			this.numRF.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.numRF.Hexadecimal = true;
			this.numRF.Location = new System.Drawing.Point(164, 125);
			this.numRF.Name = "numRF";
			this.numRF.Size = new System.Drawing.Size(120, 26);
			this.numRF.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(51, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 19);
			this.label3.TabIndex = 4;
			this.label3.Text = "リーンフォース";
			// 
			// numCO
			// 
			this.numCO.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.numCO.Hexadecimal = true;
			this.numCO.Location = new System.Drawing.Point(164, 157);
			this.numCO.Name = "numCO";
			this.numCO.Size = new System.Drawing.Size(120, 26);
			this.numCO.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(51, 159);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 19);
			this.label4.TabIndex = 6;
			this.label4.Text = "CarryOver";
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(209, 203);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(75, 23);
			this.btnExport.TabIndex = 8;
			this.btnExport.Text = "Export";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// btnExport2
			// 
			this.btnExport2.Location = new System.Drawing.Point(209, 327);
			this.btnExport2.Name = "btnExport2";
			this.btnExport2.Size = new System.Drawing.Size(75, 23);
			this.btnExport2.TabIndex = 10;
			this.btnExport2.Text = "Export";
			this.btnExport2.UseVisualStyleBackColor = true;
			this.btnExport2.Click += new System.EventHandler(this.btnExport2_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label5.Location = new System.Drawing.Point(24, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 19);
			this.label5.TabIndex = 11;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Control;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox1.Location = new System.Drawing.Point(12, 12);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(297, 43);
			this.textBox1.TabIndex = 12;
			this.textBox1.Text = "リーンフォースあたりをサーチして入力してください。";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.Control;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox2.Location = new System.Drawing.Point(12, 232);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(297, 43);
			this.textBox2.TabIndex = 13;
			this.textBox2.Text = "キャラのHPをサーチしてCTをエクスポートします";
			// 
			// numCharHP
			// 
			this.numCharHP.Caption = "キャラのHP";
			this.numCharHP.Font = new System.Drawing.Font("MS UI Gothic", 14F);
			this.numCharHP.Location = new System.Drawing.Point(49, 285);
			this.numCharHP.Margin = new System.Windows.Forms.Padding(0);
			this.numCharHP.MaximumSize = new System.Drawing.Size(235, 27);
			this.numCharHP.MinimumSize = new System.Drawing.Size(235, 27);
			this.numCharHP.Name = "numCharHP";
			this.numCharHP.Size = new System.Drawing.Size(235, 27);
			this.numCharHP.TabIndex = 9;
			this.numCharHP.Text = "numBox1";
			this.numCharHP.Value = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(326, 362);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnExport2);
			this.Controls.Add(this.numCharHP);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.numCO);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.numRF);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numKARUMA);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numMana);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "RefrainCTE";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.numMana)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numKARUMA)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numRF)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numCO)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numMana;
		private System.Windows.Forms.NumericUpDown numKARUMA;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numRF;
		protected System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numCO;
		protected System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnExport;
		private NumBox numCharHP;
		private System.Windows.Forms.Button btnExport2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
	}
}

