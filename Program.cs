using System;
using System.Windows.Forms;
using ThemeAgentModel;

namespace ThemeAgentGUI
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			ThemeList tl = new ThemeList();
			ActiveTheme at = new ActiveTheme();
			ThemeSwitcher ts = new ThemeSwitcher();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new ThemeAgentForm(tl.List, at, ts));
		}
	}
}
