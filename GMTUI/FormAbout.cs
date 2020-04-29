using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GMTUI {
	public partial class FormAbout : Form {
		public FormAbout() {
			InitializeComponent();
			Icon = Properties.Resources.GMT;
		}

		private void llOnline_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start("https://yal.cc/r/19/gmt/");
		}

		private void FormAbout_Load(object sender, EventArgs e) {

		}
	}
}
