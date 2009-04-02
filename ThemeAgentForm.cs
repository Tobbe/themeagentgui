using System;
using System.Windows.Forms;

namespace ThemeAgentGUI
{
	public partial class ThemeAgentForm : Form
	{
		public ThemeAgentForm()
		{
			InitializeComponent();
		}

		private void btnQuitManage_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void ThemeAgentForm_Load(object sender, EventArgs e)
		{
			this.Height = 430;
			this.ActiveControl = btnQuitManage;
		}

		private void ThemeAgentForm_Layout(object sender, LayoutEventArgs e)
		{
			SuspendLayout();
			ResumeLayout();
		}
	}
}
