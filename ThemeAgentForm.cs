using System;
using System.Windows.Forms;
using System.ComponentModel;
using ThemeAgentModel;

namespace ThemeAgentGUI
{
	public partial class ThemeAgentForm : Form
	{
		BindingList<ThemeNameIndex> data = null;

		public ThemeAgentForm(BindingList<ThemeNameIndex> data)
		{
			this.data = data;
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
			this.listThemes.DataSource = data;
			this.listThemes.DisplayMember = "Name";
			this.listThemes.ValueMember = "Index";
		}

		private void ThemeAgentForm_Layout(object sender, LayoutEventArgs e)
		{
			SuspendLayout();
			ResumeLayout();
		}
	}
}
