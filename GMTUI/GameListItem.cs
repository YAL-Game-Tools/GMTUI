using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GMTUI {
	public class GameListItem : ListViewItem {
		public string FullKey;
		public string FullPath;
		private string __IconPath = null;
		public string IconPath {
			get { return __IconPath; }
			set {
				if (__IconPath == value) return;
				__IconPath = value;
				if (ListView != null) {
					SyncIcon();
					ImageKey = null;
					ListView.LargeImageList.ReplaceByKey(FullKey, Icon);
					ListView.SmallImageList.ReplaceByKey(FullKey, Icon);
					ImageKey = FullKey;
				}
			}
		}
		//
		public Icon Icon;
		public void SyncIcon() {
			var path = IconPath != null ? IconPath : FullPath;
			try {
				Icon = Icon.ExtractAssociatedIcon(path);
			} catch (Exception) {
				Icon = SystemIcons.Error;
			}
		}
		//
		public string Notes {
			get { return SubItems[1].Text; }
			set {
				SubItems[1].Text = value;
				ToolTipText = value;
			}
		}
		//
		public FormEdit Editor;
		public string CLIArgs = "";
		public bool ForceWindowed = false;
		//
		public GameListItem(string name, string path) : base(name) {
			FullPath = path;
			SubItems.Add(new ListViewSubItem(this, ""));
		}
	}
}
