using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GMTUI_Detach {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			try {
				var dir = Path.GetDirectoryName(Application.ExecutablePath);
				Process.Start(dir + @"\GMTUI.exe");
			} catch (Exception e) {
				MessageBox.Show(
					"Failed to start up GMTUI."
					+ " You can try doing so yourself by opening it from directory."
					+ " Full error message: " + e,
					"GMTUI-Detach", MessageBoxButtons.OK, MessageBoxIcon.Error
				);
			}
			Application.Exit();
		}
	}
}
