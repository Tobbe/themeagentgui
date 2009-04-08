using System;
using System.Windows.Forms;
using System.ComponentModel;
using ThemeAgentModel;
using System.Drawing;

namespace ThemeAgentGUI
{
	public partial class ThemeAgentForm : Form
	{
		private BindingList<ThemeNameIndex> data;
		private ActiveTheme at;
		private ThemeSwitcher ts;

		public ThemeAgentForm(BindingList<ThemeNameIndex> data, ActiveTheme at, ThemeSwitcher ts)
		{
			this.data = data;
			this.at = at;
			this.ts = ts;
			InitializeComponent();
		}

		private void btnQuitManage_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void ThemeAgentForm_Load(object sender, EventArgs e)
		{
			this.ActiveControl = btnQuitManage;
			this.listThemes.DataSource = data;
			this.listThemes.DisplayMember = "Name";
			this.listThemes.ValueMember = "Index";

			Binding b = new Binding("Text", at, "Name", true);
			b.Format += new ConvertEventHandler(NameLabelFormat);
			this.lblName.DataBindings.Add(b);

			Binding b2 = new Binding("Text", at, "Author", true);
			b2.Format += new ConvertEventHandler(AuthorLabelFormat);
			this.lblAuthor.DataBindings.Add(b2);

			Binding b3 = new Binding("Image", at, "Preview", true);
			b3.Format += new ConvertEventHandler(PreviewPictureFormat);
			this.picPreview.DataBindings.Add(b3);
		}

		private void NameLabelFormat(object sender, ConvertEventArgs cevent)
		{
			// The application can only convert to string type. 
			if (cevent.DesiredType != typeof(string))
			{
				return;
			}

			if (at.Version != "")
			{
				cevent.Value = cevent.Value + " v" + at.Version;
			}
		}

		private void AuthorLabelFormat(object sender, ConvertEventArgs cevent)
		{
			// The application can only convert to string type. 
			if (cevent.DesiredType != typeof(string))
			{
				return;
			}

			if (cevent.Value.ToString() != "")
			{
				cevent.Value = "Author: " + cevent.Value;
			}
			else
			{
				cevent.Value = "Author: Unknown";
			}
		}

		private void PreviewPictureFormat(object sender, ConvertEventArgs cevent)
		{
			//MessageBox.Show(">" + cevent.Value.ToString() + "<");
			Bitmap img;
			if (System.IO.File.Exists(cevent.Value.ToString()))
			{
				try
				{
					img = Bitmap.FromFile(cevent.Value.ToString()) as Bitmap;
				}
				catch (Exception)
				{
					img = new Bitmap(160, 100);
				}
			}
			else
			{
				img = new Bitmap(160, 100);
			}

			cevent.Value = img;
		}

		private void ThemeAgentForm_Layout(object sender, LayoutEventArgs e)
		{
			SuspendLayout();
			ResumeLayout();
		}

		private void listThemes_SelectedIndexChanged(object sender, EventArgs e)
		{
			at.Index = ((ThemeNameIndex)listThemes.SelectedItem).Index;
		}

		private void btnSet_Click(object sender, EventArgs e)
		{
			ts.SwitchTheme();
		}

		private void btnInstall_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "LiteStep Theme Archive (*.lsz)|*.lsz|Archive file (*.zip)|*.zip|All files (*.*)|*.*";
			dialog.Title = "Select a LiteStep Theme Archive";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ThemeAgentDLLWrapper.installTheme(dialog.FileName);
			}
		}
	}
}
