using System.Runtime.InteropServices;
using System;

namespace ThemeAgentModel
{
	class ThemeAgentDLLWrapper
	{
		public delegate void ThemeListCallback(String name, int index);

		[DllImport("themeagent.dll")]
		public static extern void setThemeListCallback(ThemeListCallback tlc);

		[DllImport("themeagent.dll")]
		public static extern void forceThemeListUpdate();
	}
}
