namespace GMTUI {
	partial class FormHelp {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
			this.tbHelp = new System.Windows.Forms.TextBox();
			this.lbThanks = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tbHelp
			// 
			this.tbHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbHelp.Location = new System.Drawing.Point(12, 12);
			this.tbHelp.Multiline = true;
			this.tbHelp.Name = "tbHelp";
			this.tbHelp.ReadOnly = true;
			this.tbHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbHelp.Size = new System.Drawing.Size(520, 244);
			this.tbHelp.TabIndex = 2;
			this.tbHelp.Text = resources.GetString("tbHelp.Text");
			// 
			// lbThanks
			// 
			this.lbThanks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbThanks.AutoSize = true;
			this.lbThanks.Location = new System.Drawing.Point(433, 259);
			this.lbThanks.Name = "lbThanks";
			this.lbThanks.Size = new System.Drawing.Size(99, 13);
			this.lbThanks.TabIndex = 0;
			this.lbThanks.Text = "Thanks for reading!";
			this.lbThanks.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// FormHelp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 281);
			this.Controls.Add(this.tbHelp);
			this.Controls.Add(this.lbThanks);
			this.Name = "FormHelp";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GMTogether UI how-to";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHelp_FormClosed);
			this.Load += new System.EventHandler(this.FormHelp_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbHelp;
		private System.Windows.Forms.Label lbThanks;
	}
}