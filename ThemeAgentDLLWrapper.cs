using System.Runtime.InteropServices;
using System;
using System.Text;

namespace ThemeAgentModel
{
	class ThemeAgentDLLWrapper
	{
		public delegate void ThemeListCallback(String name, int index);
		public delegate void ActiveThemeCallback(int index);

		[DllImport("themeagent.dll")]
		public static extern void setThemeListCallback(ThemeListCallback tlc);

		[DllImport("themeagent.dll")]
		public static extern void forceThemeListUpdate();

		[DllImport("themeagent.dll")]
		public static extern void setActiveTheme(int index);

		[DllImport("themeagent.dll")]
		public static extern void setActiveThemeCallback(ActiveThemeCallback atc);

		[DllImport("themeagent.dll")]
		public static extern void getActiveThemeDetails(StringBuilder name,
			StringBuilder author, StringBuilder version, StringBuilder preview);

		[DllImport("themeagent.dll")]
		public static extern void switchTheme();

		[DllImport("themeagent.dll")]
		public static extern void installTheme(String pathToArchive);
	}
}
