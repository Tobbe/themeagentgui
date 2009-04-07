using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace ThemeAgentModel
{
	public class ActiveTheme : INotifyPropertyChanged
	{
		private String name;
		private String version;
		private String author;
		private String preview;
		private int index;

		private ThemeAgentDLLWrapper.ActiveThemeCallback atc;

		public event PropertyChangedEventHandler PropertyChanged;

		public ActiveTheme()
		{
			atc = this.DLLCallback;
			try
			{
				ThemeAgentDLLWrapper.setActiveThemeCallback(atc);
			}
			catch (DllNotFoundException e)
			{
				MessageBox.Show(e.ToString());
			}
		}

		public void DLLCallback(int index)
		{
			const int MAX_PATH = 260;
			this.index = index;
			StringBuilder n = new StringBuilder(MAX_PATH);
			StringBuilder a = new StringBuilder(MAX_PATH);
			StringBuilder v = new StringBuilder(MAX_PATH);
			StringBuilder p = new StringBuilder(MAX_PATH);
			ThemeAgentDLLWrapper.getActiveThemeDetails(n, a, v, p);
			name = n.ToString();
			version = v.ToString();
			author = a.ToString();
			preview = p.ToString();
			NotifyPropertyChanged("Name");
			NotifyPropertyChanged("Version");
			NotifyPropertyChanged("Author");
			NotifyPropertyChanged("Preview");
		}

		private void NotifyPropertyChanged(String field)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(field));
			}
		}

		public int Index
		{
			get
			{
				return index;
			}
			set
			{
				ThemeAgentDLLWrapper.setActiveTheme(value);
			}
		}

		public String Name
		{
			get
			{
				return name;
			}
		}

		public String Version
		{
			get
			{
				return version;
			}
		}

		public String Author
		{
			get
			{
				return author;
			}
		}

		public String Preview
		{
			get
			{
				return preview;
			}
		}
	}
}
