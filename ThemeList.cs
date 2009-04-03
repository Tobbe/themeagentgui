using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System;

namespace ThemeAgentModel
{
	class ThemeList
	{
		private BindingList<ThemeNameIndex> themeList;

		public ThemeList()
		{
			themeList = new BindingList<ThemeNameIndex>();
			try
			{
				ThemeAgentDLLWrapper.setThemeListCallback(this.DLLCallback);
			}
			catch (DllNotFoundException e)
			{
				MessageBox.Show(e.ToString());
			}
		}

		public void DLLCallback(String name, int index)
		{
			themeList.Add(new ThemeNameIndex(name, index));
		}

		public void ForceUpdate()
		{
			try
			{
				ThemeAgentDLLWrapper.forceThemeListUpdate();
			}
			catch (DllNotFoundException e)
			{
				MessageBox.Show(e.ToString());
			}
		}

		public BindingList<ThemeNameIndex> List
		{
			get
			{
				return themeList;
			}
		}
	}
}
