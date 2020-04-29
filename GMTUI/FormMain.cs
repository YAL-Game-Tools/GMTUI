using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace GMTUI {
	public partial class FormMain : Form {
		public static string IniPath;
		public static string ExeFolder;
		public static string LauncherPath;
		public FormMain() {
			InitializeComponent();
			Icon = Properties.Resources.GMT;
			typeof(Control).GetProperty("DoubleBuffered",
							 System.Reflection.BindingFlags.NonPublic |
							 System.Reflection.BindingFlags.Instance)
			   .SetValue(lvApps, true, null);
			//
			var AppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			var AppDir = AppData + @"\GMTogether";
			if (!Directory.Exists(AppDir)) {
				try {
					Directory.CreateDirectory(AppDir);
				} catch (Exception e) {
					MessageBox.Show("Failed to create an appdata directory!"
						+ " Very cursed."
						+ " This means that we won't be able to save your bookmarks."
						+ " See if you are missing user permissions somehow."
						+ " Full error:\r\n" + e,
						Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			IniPath = AppDir + @"\GMTUI.ini";
			//
			ExeFolder = Path.GetDirectoryName(Application.ExecutablePath);
			LauncherPath = ExeFolder + @"\GMT-Launcher.exe";
			if (!File.Exists(LauncherPath)) {
				MessageBox.Show(
					"Please extract GMT to GMTUI's directory before using the program.",
					Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			//
			var ini = new StrangeIni();
			if (ini.Load(IniPath)) {
				var top = ini.topSection;
				try {
					lvApps.View = (View)Enum.Parse(typeof(View), top["view"]);
					switch (lvApps.View) {
						case View.Details:
							SyncViewItems(tsiViewDetails);
							break;
						case View.LargeIcon:
							SyncViewItems(tsiViewBigIcons);
							break;
						case View.SmallIcon:
							SyncViewItems(tsiViewSmallIcons);
							break;
						case View.List:
							SyncViewItems(tsiViewList);
							break;
						case View.Tile:
							SyncViewItems(tsiViewTile);
							break;
					}
				} catch (Exception) { }
				if (int.TryParse(top["width"], out var w)) Width = w;
				if (int.TryParse(top["height"], out var h)) Height = h;
				foreach (var sct in ini.sections) {
					if (sct.name != "Bookmark") continue;
					var name = sct["name"] ?? "?";
					var path = sct["path"] ?? "";
					var item = new GameListItem(name, path);
					item.Notes = sct["text"] ?? "";
					item.IconPath = sct["icon"];
					item.CLIArgs = sct["args"] ?? "";
					item.ForceWindowed = sct["fwnd"] == "1";
					AddGLI(item);
				}
			}
		}

		public void FlushINI() {
			var ini = new StrangeIni();
			var top = ini.topSection;
			top["view"] = lvApps.View.ToString();
			top["width"] = "" + Width;
			top["height"] = "" + Height;
			//
			
			foreach (var pair in lvApps.GetSortedItems()) {
				var item = pair.Value;
				var sct = ini.AddSection("Bookmark");
				sct["path"] = item.FullPath;
				sct["name"] = item.Text;
				sct["text"] = item.Notes;
				sct["icon"] = item.IconPath;
				sct["args"] = item.CLIArgs;
				if (item.ForceWindowed) sct["fwnd"] = "1";
			}
			//
			var unsavedData = ini.Save(IniPath);
			if (unsavedData != null) {
				if (MessageBox.Show(
					"Failed to save bookmarks! Would you like INI text to be copied to your clipboard?",
					Text, MessageBoxButtons.YesNo, MessageBoxIcon.Error
				) == DialogResult.Yes) {
					Clipboard.SetText(unsavedData);
				}
			}
		}

		//
		public Dictionary<string, GameListItem> fullKeyMap = new Dictionary<string, GameListItem>();
		public void AddGLI(GameListItem item) {
			if (item.Icon == null) item.SyncIcon();
			if (fullKeyMap.ContainsKey(item.FullPath)) {
				var FullPre = item.FullPath + "@";
				var i = 1;
				while (fullKeyMap.ContainsKey(FullPre + i)) i++;
				item.FullKey = FullPre + i;
			} else {
				item.FullKey = item.FullPath;
			}
			lvApps.LargeImageList.Images.Add(item.FullKey, item.Icon);
			lvApps.SmallImageList.Images.Add(item.FullKey, item.Icon);
			item.ImageKey = item.FullKey;
			lvApps.Items.Add(item);
			fullKeyMap[item.FullKey] = item;
		}
		public void RemoveGLI(GameListItem item) {
			var fullKey = item.FullKey;
			lvApps.LargeImageList.Images.RemoveByKey(fullKey);
			lvApps.SmallImageList.Images.RemoveByKey(fullKey);
			if (item.Editor != null) item.Editor.Close();
			lvApps.Items.Remove(item);
			fullKeyMap.Remove(fullKey);
		}
		//

		private void addToolStripMenuItem_Click(object sender, EventArgs e) {
			
		}

		#region View
		private void SyncViewItems(ToolStripMenuItem current) {
			foreach (ToolStripMenuItem item in tsiView.DropDownItems) {
				item.Checked = item == current;
			}
		}
		private void bigIconsToolStripMenuItem_Click(object sender, EventArgs e) {
			lvApps.View = View.LargeIcon;
			SyncViewItems(tsiViewBigIcons);
		}

		private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e) {
			lvApps.View = View.SmallIcon;
			SyncViewItems(tsiViewSmallIcons);
		}

		private void detailsToolStripMenuItem_Click(object sender, EventArgs e) {
			lvApps.View = View.Details;
			SyncViewItems(tsiViewDetails);
		}

		private void listToolStripMenuItem_Click(object sender, EventArgs e) {
			lvApps.View = View.List;
			SyncViewItems(tsiViewList);
		}

		private void tileToolStripMenuItem_Click(object sender, EventArgs e) {
			lvApps.View = View.Tile;
			SyncViewItems(tsiViewTile);
		}
		#endregion

		private void editToolStripMenuItem_Click(object sender, EventArgs e) {
			foreach (ListViewItem lvItem in lvApps.SelectedItems) {
				if (!(lvItem is GameListItem)) continue;
				var item = lvItem as GameListItem;
				if (item.Editor != null) {
					item.Editor.Focus();
				} else {
					var fm = new FormEdit();
					fm.SetGameListItem(item);
					fm.Show(this);
				}
			}
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
			var prompt = "Are you sure you want to remove this bookmark? This cannot be undone.";
			if (MessageBox.Show(prompt, Text, MessageBoxButtons.YesNo) != DialogResult.Yes) return;
			foreach (ListViewItem lvItem in lvApps.SelectedItems) {
				if (lvItem is GameListItem) RemoveGLI(lvItem as GameListItem);
			}
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
			FlushINI();
		}

		private void ctxApps_Opening(object sender, CancelEventArgs e) {
			var isEmpty = lvApps.SelectedItems.Count == 0;
			foreach (ToolStripItem item in ctxApps.Items) {
				item.Visible = (item == tsiAddBookmark) == isEmpty;
			}
		}

		private void tsiAddBookmark_Click(object sender, EventArgs e) {
			if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
			var path = openFileDialog1.FileName;
			var name = Path.GetFileNameWithoutExtension(Path.GetFileName(path));
			var item = new GameListItem(name, path);
			AddGLI(item);
		}

		void LaunchSelected() {
			if (lvApps.SelectedItems.Count == 0) return;
			if (!(lvApps.SelectedItems[0] is GameListItem)) return;
			var item = lvApps.SelectedItems[0] as GameListItem;
			try {
				var args = $"\"{item.FullPath}\"";
				if (item.CLIArgs != "") args += " " + item.CLIArgs;
				if (item.ForceWindowed) args += " --windowed";
				Process.Start(LauncherPath, args);
			} catch (Exception e) {
				MessageBox.Show(
					"Failed to start:\r\n" + e
					, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void lvApps_DoubleClick(object sender, EventArgs e) {
			LaunchSelected();
		}

		private void tsiLaunch_Click(object sender, EventArgs e) {
			LaunchSelected();
		}

		private void tsiOpenHelp_Click(object sender, EventArgs e) {
			Process.Start(ExeFolder + @"\GMT-Readme.html");
		}

		private void tsiAbout_Click(object sender, EventArgs e) {
			(new FormAbout()).ShowDialog(this);
		}

		#region Reordering https://stackoverflow.com/a/19406069/5578773
		ListViewItem dragItem;
		Point dragItemOrigin;
		ListViewItemSnap dragSnap;
		private void lvApps_MouseDown(object sender, MouseEventArgs e) {
			dragItem = lvApps.GetItemAt(e.X, e.Y);
			if (dragItem == null) return;
			dragItemOrigin = new Point(e.X - dragItem.Position.X, e.Y - dragItem.Position.Y);
			lvApps.AutoArrange = false;
			lvApps.MouseMove += lvApps_MouseMove;
			dragSnap = ListViewItemSnap.Start(lvApps);
		}

		private void lvApps_MouseMove(object sender, MouseEventArgs e) {
			var nx = e.Location.X - dragItemOrigin.X;
			var ny = e.Location.Y - dragItemOrigin.Y;
			var np = new Point(nx, ny);
			//if (dragSnap != null) np = dragSnap.Snap(np);
			dragItem.Position = np;
		}

		private void lvApps_MouseUp(object sender, MouseEventArgs e) {
			if (dragItem == null) return;
			if (dragSnap != null) dragItem.Position = dragSnap.Snap(dragItem.Position);
			lvApps.AutoArrange = true;
			lvApps.MouseMove -= lvApps_MouseMove;
		}
		#endregion

		#region Dropping files (https://stackoverflow.com/a/89470/5578773)
		private void FormMain_DragEnter(object sender, DragEventArgs e) {
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
				e.Effect = DragDropEffects.Link;
			}
		}

		private void FormMain_DragDrop(object sender, DragEventArgs e) {
			var files = (string[])e.Data.GetData(DataFormats.FileDrop);
			foreach (var path in files) {
				if (Path.GetExtension(path).ToLower() != ".exe") continue;
				var name = Path.GetFileNameWithoutExtension(Path.GetFileName(path));
				var item = new GameListItem(name, path);
				AddGLI(item);
			}
		}
		#endregion
	}
}
