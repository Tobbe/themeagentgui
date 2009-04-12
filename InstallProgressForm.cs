using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThemeAgentModel;

namespace ThemeAgentGUI
{
	public partial class InstallProgressForm : Form
	{
		bool canClose = false;

		public InstallProgressForm(ref ThemeInstaller ti)
		{
			InitializeComponent();
			ti.PropertyChanged += new PropertyChangedEventHandler(ThemeInstaller_PropertyChanged);
		}

		public void ResetProgress()
		{
			UpdateProgress(0);
			UpdateLabel("");
			canClose = false;
		}

		private void UpdateProgress(int progress)
		{
			if (pbProgress.InvokeRequired)
			{
				Invoke(new MethodInvoker(delegate {
					UpdateProgress(progress);
				}));
			}
			else
			{
				if (!pbProgress.IsDisposed && pbProgress.IsHandleCreated)
				{
					pbProgress.Value = progress;
				}
			}
		}

		private void UpdateLabel(String text)
		{
			if (lblProgress.InvokeRequired)
			{
				Invoke(new MethodInvoker(delegate {
					UpdateLabel(text);
				}));
			}
			else
			{
				if (!lblProgress.IsDisposed && lblProgress.IsHandleCreated)
				{
					lblProgress.Text = text;
				}
			}
		}

		private void HandleInstallationDone()
		{
			// canClose needs to be set here for the _Shown event to work
			// as it should
			canClose = true;

			if (this.InvokeRequired)
			{
				Invoke(new MethodInvoker(HandleInstallationDone));
			}
			else
			{
				if (!this.IsDisposed && this.IsHandleCreated)
				{
					this.Hide();
				}
			}
		}

		private void ThemeInstaller_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			switch (e.PropertyName)
			{
				case "Progress":
				{
					UpdateProgress(((ThemeInstaller)sender).Progress);

					break;
				}
				case "CurrentFile":
				{
					UpdateLabel("Extracting " + ((ThemeInstaller)sender).CurrentFile);

					break;
				}
				case "InstallationDone":
				{
					HandleInstallationDone();
					break;
				}
			}
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing && !canClose)
			{
				e.Cancel = true;
			}
		}

		private void InstallProgressForm_Shown(object sender, EventArgs e)
		{
			if (canClose)
			{
				HandleInstallationDone();
			}
		}
	}
}
