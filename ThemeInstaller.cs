using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;

namespace ThemeAgentModel
{
	public class ThemeInstaller : INotifyPropertyChanged
	{
		private ThemeAgentDLLWrapper.ThemeInstallerCallback tic;
		int progress;
		String currentFile;
		bool installationDone;

		public event PropertyChangedEventHandler PropertyChanged;

		public ThemeInstaller()
		{
			tic = this.DLLCallback;
			try
			{
				ThemeAgentDLLWrapper.setThemeInstallerCallback(tic);
			}
			catch (DllNotFoundException e)
			{
				MessageBox.Show(e.ToString());
			}
		}

		public void DLLCallback(int progress, String currentFile, bool installationDone)
		{
			if (Progress != progress)
			{
				this.progress = progress;
				NotifyPropertyChanged("Progress");
			}

			if (CurrentFile != currentFile)
			{
				this.currentFile = currentFile;
				NotifyPropertyChanged("CurrentFile");
			}

			if (InstallationDone != installationDone)
			{
				this.installationDone = installationDone;
				NotifyPropertyChanged("InstallationDone");
			}
		}

		public void InstallTheme(String pathToArchive)
		{
			progress = 0;
			installationDone = false;

			ThreadStart starter = delegate { ThemeAgentDLLWrapper.installTheme(pathToArchive); };
			new Thread(starter).Start();
		}

		private void NotifyPropertyChanged(String field)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(field));
			}
		}

		public int Progress
		{
			get { return progress; }
		}

		public String CurrentFile
		{
			get { return currentFile; }
		}

		public bool InstallationDone
		{
			get { return installationDone; }
		}
	}
}
