namespace GMTUI {
	partial class FormMain {
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
			this.lvApps = new System.Windows.Forms.ListView();
			this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ctxApps = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsiAddBookmark = new System.Windows.Forms.ToolStripMenuItem();
			this.tsiLaunch = new System.Windows.Forms.ToolStripMenuItem();
			this.tsiEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.tsiDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.ilAppsBig = new System.Windows.Forms.ImageList(this.components);
			this.ilApps = new System.Windows.Forms.ImageList(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsiView = new System.Windows.Forms.ToolStripMenuItem();
			this.tsiViewSmallIcons = new System.Windows.Forms.ToolStripMenuItem();
			this.tsiViewBigIcons = new System.Windows.Forms.ToolStripMenuItem();
			this.tsiViewDetails = new System.Windows.Forms.ToolStripMenuItem();
			this.tsiViewList = new System.Windows.Forms.ToolStripMenuItem();
			this.tsiViewTile = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsiOpenHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.tsiAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.heyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ctxApps.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvApps
			// 
			this.lvApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvApps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colNotes});
			this.lvApps.ContextMenuStrip = this.ctxApps;
			this.lvApps.HideSelection = false;
			this.lvApps.LabelEdit = true;
			this.lvApps.LargeImageList = this.ilAppsBig;
			this.lvApps.Location = new System.Drawing.Point(12, 27);
			this.lvApps.Name = "lvApps";
			this.lvApps.Size = new System.Drawing.Size(443, 331);
			this.lvApps.SmallImageList = this.ilApps;
			this.lvApps.TabIndex = 0;
			this.lvApps.UseCompatibleStateImageBehavior = false;
			this.lvApps.View = System.Windows.Forms.View.Tile;
			this.lvApps.DoubleClick += new System.EventHandler(this.lvApps_DoubleClick);
			this.lvApps.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvApps_MouseDown);
			this.lvApps.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvApps_MouseUp);
			// 
			// colName
			// 
			this.colName.Text = "Name";
			this.colName.Width = 200;
			// 
			// colNotes
			// 
			this.colNotes.Text = "Notes";
			this.colNotes.Width = 150;
			// 
			// ctxApps
			// 
			this.ctxApps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiAddBookmark,
            this.tsiLaunch,
            this.tsiEdit,
            this.tsiDelete});
			this.ctxApps.Name = "contextMenuStrip1";
			this.ctxApps.Size = new System.Drawing.Size(163, 92);
			this.ctxApps.Opening += new System.ComponentModel.CancelEventHandler(this.ctxApps_Opening);
			// 
			// tsiAddBookmark
			// 
			this.tsiAddBookmark.Name = "tsiAddBookmark";
			this.tsiAddBookmark.Size = new System.Drawing.Size(162, 22);
			this.tsiAddBookmark.Text = "Add bookmark...";
			this.tsiAddBookmark.Click += new System.EventHandler(this.tsiAddBookmark_Click);
			// 
			// tsiLaunch
			// 
			this.tsiLaunch.Name = "tsiLaunch";
			this.tsiLaunch.Size = new System.Drawing.Size(162, 22);
			this.tsiLaunch.Text = "Launch";
			this.tsiLaunch.Click += new System.EventHandler(this.tsiLaunch_Click);
			// 
			// tsiEdit
			// 
			this.tsiEdit.Name = "tsiEdit";
			this.tsiEdit.Size = new System.Drawing.Size(162, 22);
			this.tsiEdit.Text = "Edit...";
			this.tsiEdit.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
			// 
			// tsiDelete
			// 
			this.tsiDelete.Name = "tsiDelete";
			this.tsiDelete.Size = new System.Drawing.Size(162, 22);
			this.tsiDelete.Text = "Delete";
			this.tsiDelete.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// ilAppsBig
			// 
			this.ilAppsBig.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ilAppsBig.ImageSize = new System.Drawing.Size(32, 32);
			this.ilAppsBig.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// ilApps
			// 
			this.ilApps.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ilApps.ImageSize = new System.Drawing.Size(16, 16);
			this.ilApps.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(467, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2]
		{
			tsiView,
			helpToolStripMenuItem
		});

			// 
			// tsiView
			// 
			this.tsiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiViewSmallIcons,
            this.tsiViewBigIcons,
            this.tsiViewDetails,
            this.tsiViewList,
            this.tsiViewTile});
			this.tsiView.Name = "tsiView";
			this.tsiView.Size = new System.Drawing.Size(44, 20);
			this.tsiView.Text = "View";
			// 
			// tsiViewSmallIcons
			// 
			this.tsiViewSmallIcons.Name = "tsiViewSmallIcons";
			this.tsiViewSmallIcons.Size = new System.Drawing.Size(134, 22);
			this.tsiViewSmallIcons.Text = "Small icons";
			this.tsiViewSmallIcons.Click += new System.EventHandler(this.smallIconsToolStripMenuItem_Click);
			// 
			// tsiViewBigIcons
			// 
			this.tsiViewBigIcons.Name = "tsiViewBigIcons";
			this.tsiViewBigIcons.Size = new System.Drawing.Size(134, 22);
			this.tsiViewBigIcons.Text = "Big icons";
			this.tsiViewBigIcons.Click += new System.EventHandler(this.bigIconsToolStripMenuItem_Click);
			// 
			// tsiViewDetails
			// 
			this.tsiViewDetails.Checked = true;
			this.tsiViewDetails.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tsiViewDetails.Name = "tsiViewDetails";
			this.tsiViewDetails.Size = new System.Drawing.Size(134, 22);
			this.tsiViewDetails.Text = "Details";
			this.tsiViewDetails.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
			// 
			// tsiViewList
			// 
			this.tsiViewList.Name = "tsiViewList";
			this.tsiViewList.Size = new System.Drawing.Size(134, 22);
			this.tsiViewList.Text = "List";
			this.tsiViewList.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
			// 
			// tsiViewTile
			// 
			this.tsiViewTile.Name = "tsiViewTile";
			this.tsiViewTile.Size = new System.Drawing.Size(134, 22);
			this.tsiViewTile.Text = "Tile";
			this.tsiViewTile.Click += new System.EventHandler(this.tileToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiOpenHelp,
            this.tsiAbout});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// tsiOpenHelp
			// 
			this.tsiOpenHelp.Name = "tsiOpenHelp";
			this.tsiOpenHelp.Size = new System.Drawing.Size(184, 22);
			this.tsiOpenHelp.Text = "GMT documentation";
			this.tsiOpenHelp.Click += new System.EventHandler(this.tsiOpenHelp_Click);
			// 
			// tsiAbout
			// 
			this.tsiAbout.Name = "tsiAbout";
			this.tsiAbout.Size = new System.Drawing.Size(184, 22);
			this.tsiAbout.Text = "About";
			this.tsiAbout.Click += new System.EventHandler(this.tsiAbout_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "Hopefully GameMaker executables|*.exe";
			// 
			// heyToolStripMenuItem
			// 
			this.heyToolStripMenuItem.Name = "heyToolStripMenuItem";
			this.heyToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.heyToolStripMenuItem.Text = "Hey";
			// 
			// FormMain
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 370);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.lvApps);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GMTogether UI";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
			this.ctxApps.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lvApps;
		private System.Windows.Forms.ContextMenuStrip ctxApps;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ColumnHeader colName;
		private System.Windows.Forms.ColumnHeader colNotes;
		private System.Windows.Forms.ToolStripMenuItem tsiLaunch;
		private System.Windows.Forms.ToolStripMenuItem tsiEdit;
		private System.Windows.Forms.ToolStripMenuItem tsiDelete;
		private System.Windows.Forms.ToolStripMenuItem tsiView;
		private System.Windows.Forms.ToolStripMenuItem tsiViewSmallIcons;
		private System.Windows.Forms.ToolStripMenuItem tsiViewBigIcons;
		private System.Windows.Forms.ToolStripMenuItem tsiViewDetails;
		private System.Windows.Forms.ImageList ilApps;
		private System.Windows.Forms.ImageList ilAppsBig;
		private System.Windows.Forms.ToolStripMenuItem tsiViewList;
		private System.Windows.Forms.ToolStripMenuItem tsiViewTile;
		private System.Windows.Forms.ToolStripMenuItem tsiAddBookmark;
		private System.Windows.Forms.ToolStripMenuItem tsiOpenHelp;
		private System.Windows.Forms.ToolStripMenuItem tsiAbout;
		private System.Windows.Forms.ToolStripMenuItem heyToolStripMenuItem;
	}
}

