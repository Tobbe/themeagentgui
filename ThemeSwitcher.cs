using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThemeAgentModel
{
	public class ThemeSwitcher
	{
		public void SwitchTheme()
		{
			ThemeAgentDLLWrapper.switchTheme();
		}
	}
}
