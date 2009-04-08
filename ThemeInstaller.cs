using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThemeAgentModel
{
	class ThemeInstaller
	{
		public void InstallTheme(string pathToArchive)
		{
			ThemeAgentDLLWrapper.installTheme(pathToArchive);
		}
	}
}
