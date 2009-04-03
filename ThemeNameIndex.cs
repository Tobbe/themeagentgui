using System;

namespace ThemeAgentModel
{
	public class ThemeNameIndex
	{
		private String name;
		private int index;

		public ThemeNameIndex(String name, int index)
		{
			this.name = name;
			this.index = index;
		}

		public string Name
		{
			get
			{
				return name;
			}
		}

		public int Index
		{
			get
			{
				return index;
			}
		}
	}
}
