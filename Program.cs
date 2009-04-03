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

			tl.ForceUpdate();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new ThemeAgentForm(tl.List));
		}
	}
}
