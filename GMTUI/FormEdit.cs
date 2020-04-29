using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GMTUI {
	public partial class FormEdit : Form {
		public FormEdit() {
			InitializeComponent();
		}
		public GameListItem gameListItem;
		public void SetGameListItem(GameListItem item) {
			tbPath.Text = item.FullPath;
			tbIcon.Text = item.IconPath != null ? item.IconPath : "<default>";
			tbName.Text = item.Text;
			tbNotes.Text = item.Notes;
			tbArgs.Text = item.CLIArgs;
			cbWindowed.Checked = item.ForceWindowed;
			Icon = item.Icon;
			item.Editor = this;
			gameListItem = item;
		}

		private void btPickPath_Click(object sender, EventArgs e) {
			try {
				ofdExe.InitialDirectory = Path.GetDirectoryName(gameListItem.FullPath);
			} catch (Exception) { }
			if (ofdExe.ShowDialog() != DialogResult.OK) return;
			gameListItem.FullPath = ofdExe.FileName;
		}

		private void tbNotes_TextChanged(object sender, EventArgs e) {
			if (gameListItem != null) gameListItem.Notes = tbNotes.Text;
		}

		private void tbName_TextChanged(object sender, EventArgs e) {
			if (gameListItem != null) gameListItem.Text = tbName.Text;
		}

		private void FormEdit_FormClosed(object sender, FormClosedEventArgs e) {
			if (gameListItem.Editor == this) {
				gameListItem.Editor = null;
			}
		}

		private void btPickIcon_Click(object sender, EventArgs e) {
			try {
				var path = gameListItem.IconPath ?? gameListItem.FullPath;
				ofdIcon.InitialDirectory = Path.GetDirectoryName(path);
			} catch (Exception) { }
			if (ofdIcon.ShowDialog() != DialogResult.OK) return;
			gameListItem.IconPath = ofdIcon.FileName;
			tbIcon.Text = ofdIcon.FileName;
			Icon = gameListItem.Icon;
		}

		private void btResetIcon_Click(object sender, EventArgs e) {
			if (gameListItem.IconPath != null) {
				gameListItem.IconPath = null;
				tbIcon.Text = "<default>";
				Icon = gameListItem.Icon;
			}
		}

		private void tbArgs_TextChanged(object sender, EventArgs e) {
			if (gameListItem != null) {
				gameListItem.CLIArgs = tbArgs.Text;
			}
		}

		private void cbWindowed_CheckedChanged(object sender, EventArgs e) {
			if (gameListItem != null) {
				gameListItem.ForceWindowed = cbWindowed.Checked;
			}
		}

		private void btEditConfig_Click(object sender, EventArgs ea) {
			var dir = Path.GetDirectoryName(gameListItem.FullPath);
			if (!Directory.Exists(dir)) {
				MessageBox.Show(
					$"Game directory `{dir}` does not exist.",
					Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			var iniPath = dir + @"\GMT.ini";
			if (!File.Exists(iniPath)) {
				try {
					File.Copy(FormMain.ExeFolder + @"\GMT-Example.ini", iniPath);
				} catch (Exception e) {
					MessageBox.Show(
						"Failed to copy GMT-Example.ini."
						+ " Copying it manually might work."
						+ " Full error text:\r\n" + e,
						Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			Process.Start(iniPath);
		}
	}
}
