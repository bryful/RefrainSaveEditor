namespace RefrainSaveEditor
{
	partial class FriendshipEditDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.fl = new System.Windows.Forms.FlowLayoutPanel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnALL = new System.Windows.Forms.Button();
			this.numALL = new RefrainSaveEditor.NumBox();
			this.SuspendLayout();
			// 
			// fl
			// 
			this.fl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fl.Location = new System.Drawing.Point(12, 12);
			this.fl.Name = "fl";
			this.fl.Size = new System.Drawing.Size(787, 350);
			this.fl.TabIndex = 1;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(643, 368);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(724, 368);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnALL
			// 
			this.btnALL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnALL.Location = new System.Drawing.Point(518, 368);
			this.btnALL.Name = "btnALL";
			this.btnALL.Size = new System.Drawing.Size(75, 23);
			this.btnALL.TabIndex = 5;
			this.btnALL.Text = "ALL";
			this.btnALL.UseVisualStyleBackColor = true;
			this.btnALL.Click += new System.EventHandler(this.btnALL_Click);
			// 
			// numALL
			// 
			this.numALL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.numALL.Caption = "";
			this.numALL.Font = new System.Drawing.Font("MS UI Gothic", 14F);
			this.numALL.Location = new System.Drawing.Point(293, 368);
			this.numALL.Margin = new System.Windows.Forms.Padding(0);
			this.numALL.MaximumSize = new System.Drawing.Size(235, 27);
			this.numALL.MinimumSize = new System.Drawing.Size(235, 27);
			this.numALL.Name = "numALL";
			this.numALL.Size = new System.Drawing.Size(235, 27);
			this.numALL.TabIndex = 4;
			this.numALL.Text = "numBox1";
			this.numALL.Value = 0;
			// 
			// FriendshipEditDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(814, 408);
			this.Controls.Add(this.btnALL);
			this.Controls.Add(this.numALL);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.fl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "FriendshipEditDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FriendshipEditDialog";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel fl;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private NumBox numALL;
		private System.Windows.Forms.Button btnALL;
	}
}