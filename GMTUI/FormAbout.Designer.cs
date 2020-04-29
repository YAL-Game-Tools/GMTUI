namespace GMTUI {
	partial class FormAbout {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.llOnline = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// llOnline
			// 
			this.llOnline.AutoSize = true;
			this.llOnline.Location = new System.Drawing.Point(12, 9);
			this.llOnline.Name = "llOnline";
			this.llOnline.Size = new System.Drawing.Size(152, 13);
			this.llOnline.TabIndex = 0;
			this.llOnline.TabStop = true;
			this.llOnline.Text = "Read more about GMTogether";
			this.llOnline.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llOnline_LinkClicked);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(12, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(353, 87);
			this.label1.TabIndex = 1;
			this.label1.Text = "GMTUI by YellowAfterlife.\r\n\r\nSpecial thanks to nkrapivin for feedback and having " +
    "made a simpler launcher before this one existed.";
			// 
			// FormAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(377, 127);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.llOnline);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAbout";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			this.Load += new System.EventHandler(this.FormAbout_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel llOnline;
		private System.Windows.Forms.Label label1;
	}
}