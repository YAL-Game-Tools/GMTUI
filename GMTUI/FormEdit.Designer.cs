namespace GMTUI {
	partial class FormEdit {
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
			this.components = new System.ComponentModel.Container();
			this.btPickPath = new System.Windows.Forms.Button();
			this.ofdExe = new System.Windows.Forms.OpenFileDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.tbPath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.btPickIcon = new System.Windows.Forms.Button();
			this.tbNotes = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbIcon = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.ofdIcon = new System.Windows.Forms.OpenFileDialog();
			this.tbArgs = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btEditConfig = new System.Windows.Forms.Button();
			this.ttip = new System.Windows.Forms.ToolTip(this.components);
			this.btResetIcon = new System.Windows.Forms.Button();
			this.cbWindowed = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// btPickPath
			// 
			this.btPickPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btPickPath.Location = new System.Drawing.Point(393, 12);
			this.btPickPath.Name = "btPickPath";
			this.btPickPath.Size = new System.Drawing.Size(35, 25);
			this.btPickPath.TabIndex = 1;
			this.btPickPath.Text = "...";
			this.btPickPath.UseVisualStyleBackColor = true;
			this.btPickPath.Click += new System.EventHandler(this.btPickPath_Click);
			// 
			// ofdExe
			// 
			this.ofdExe.FileName = "openFileDialog1";
			this.ofdExe.Filter = "Executable files|*.exe|All files|*.*";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Path";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbPath
			// 
			this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPath.Enabled = false;
			this.tbPath.Location = new System.Drawing.Point(96, 15);
			this.tbPath.Name = "tbPath";
			this.tbPath.Size = new System.Drawing.Size(291, 20);
			this.tbPath.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Name";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbName
			// 
			this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbName.Location = new System.Drawing.Point(96, 77);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(332, 20);
			this.tbName.TabIndex = 5;
			this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
			// 
			// btPickIcon
			// 
			this.btPickIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btPickIcon.Location = new System.Drawing.Point(393, 43);
			this.btPickIcon.Name = "btPickIcon";
			this.btPickIcon.Size = new System.Drawing.Size(35, 25);
			this.btPickIcon.TabIndex = 4;
			this.btPickIcon.Text = "...";
			this.btPickIcon.UseVisualStyleBackColor = true;
			this.btPickIcon.Click += new System.EventHandler(this.btPickIcon_Click);
			// 
			// tbNotes
			// 
			this.tbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbNotes.Location = new System.Drawing.Point(96, 110);
			this.tbNotes.Name = "tbNotes";
			this.tbNotes.Size = new System.Drawing.Size(332, 20);
			this.tbNotes.TabIndex = 6;
			this.tbNotes.TextChanged += new System.EventHandler(this.tbNotes_TextChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 25);
			this.label3.TabIndex = 8;
			this.label3.Text = "Notes";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbIcon
			// 
			this.tbIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbIcon.Enabled = false;
			this.tbIcon.Location = new System.Drawing.Point(96, 46);
			this.tbIcon.Name = "tbIcon";
			this.tbIcon.Size = new System.Drawing.Size(260, 20);
			this.tbIcon.TabIndex = 2;
			this.ttip.SetToolTip(this.tbIcon, "Optional: Allows to specify a custom icon file");
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 25);
			this.label4.TabIndex = 11;
			this.label4.Text = "Icon";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ofdIcon
			// 
			this.ofdIcon.FileName = "openFileDialog1";
			this.ofdIcon.Filter = "Icons|*.ico|All files|*.*";
			// 
			// tbArgs
			// 
			this.tbArgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbArgs.Location = new System.Drawing.Point(96, 139);
			this.tbArgs.Name = "tbArgs";
			this.tbArgs.Size = new System.Drawing.Size(332, 20);
			this.tbArgs.TabIndex = 7;
			this.ttip.SetToolTip(this.tbArgs, "Additional command-line arguments to pass to the executable.\r\nIf you are not sure" +
        " what this means, you probably don\'t need this option.");
			this.tbArgs.TextChanged += new System.EventHandler(this.tbArgs_TextChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 25);
			this.label5.TabIndex = 13;
			this.label5.Text = "CLI args";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btEditConfig
			// 
			this.btEditConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btEditConfig.Location = new System.Drawing.Point(308, 165);
			this.btEditConfig.Name = "btEditConfig";
			this.btEditConfig.Size = new System.Drawing.Size(120, 25);
			this.btEditConfig.TabIndex = 9;
			this.btEditConfig.Text = "Open GMT.ini";
			this.btEditConfig.UseVisualStyleBackColor = true;
			this.btEditConfig.Click += new System.EventHandler(this.btEditConfig_Click);
			// 
			// btResetIcon
			// 
			this.btResetIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btResetIcon.Location = new System.Drawing.Point(362, 43);
			this.btResetIcon.Name = "btResetIcon";
			this.btResetIcon.Size = new System.Drawing.Size(25, 25);
			this.btResetIcon.TabIndex = 3;
			this.btResetIcon.Text = "X";
			this.ttip.SetToolTip(this.btResetIcon, "Reverts to using the executable icon");
			this.btResetIcon.UseVisualStyleBackColor = true;
			this.btResetIcon.Click += new System.EventHandler(this.btResetIcon_Click);
			// 
			// cbWindowed
			// 
			this.cbWindowed.AutoSize = true;
			this.cbWindowed.Location = new System.Drawing.Point(96, 170);
			this.cbWindowed.Name = "cbWindowed";
			this.cbWindowed.Size = new System.Drawing.Size(133, 17);
			this.cbWindowed.TabIndex = 8;
			this.cbWindowed.Text = "Force windowed mode";
			this.cbWindowed.UseVisualStyleBackColor = true;
			this.cbWindowed.CheckedChanged += new System.EventHandler(this.cbWindowed_CheckedChanged);
			// 
			// FormEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 201);
			this.Controls.Add(this.btEditConfig);
			this.Controls.Add(this.btResetIcon);
			this.Controls.Add(this.cbWindowed);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbArgs);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbIcon);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbNotes);
			this.Controls.Add(this.btPickIcon);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbPath);
			this.Controls.Add(this.btPickPath);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(8000, 240);
			this.MinimumSize = new System.Drawing.Size(300, 240);
			this.Name = "FormEdit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Editing a bookmark";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEdit_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btPickPath;
		private System.Windows.Forms.OpenFileDialog ofdExe;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbPath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Button btPickIcon;
		private System.Windows.Forms.TextBox tbNotes;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbIcon;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.OpenFileDialog ofdIcon;
		private System.Windows.Forms.TextBox tbArgs;
		private System.Windows.Forms.ToolTip ttip;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btEditConfig;
		private System.Windows.Forms.CheckBox cbWindowed;
		private System.Windows.Forms.Button btResetIcon;
	}
}