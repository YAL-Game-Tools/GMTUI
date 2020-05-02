using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GMTUI {
	public partial class FormHelp : Form {
		FormMain formMain;
		public FormHelp(FormMain main) {
			formMain = main;
			InitializeComponent();
			Icon = Properties.Resources.GMT;
		}

		private void FormHelp_Load(object sender, EventArgs e) {
			// Need something to dump focus onto? https://stackoverflow.com/a/1140277/5578773
			ActiveControl = lbThanks;
		}

		private void FormHelp_FormClosed(object sender, FormClosedEventArgs e) {
			if (formMain != null && formMain.formHelp == this) {
				formMain.formHelp = null;
			}
		}
	}
}
