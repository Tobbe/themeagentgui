namespace ThemeAgent
{
	partial class DownloadThemesForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitCntnrDownload = new System.Windows.Forms.SplitContainer();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnQuitDl = new System.Windows.Forms.Button();
			this.splitCntnrBase = new System.Windows.Forms.SplitContainer();
			this.splitCntnrDownload.Panel1.SuspendLayout();
			this.splitCntnrDownload.Panel2.SuspendLayout();
			this.splitCntnrDownload.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.splitCntnrBase.Panel2.SuspendLayout();
			this.splitCntnrBase.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitCntnrDownload
			// 
			this.splitCntnrDownload.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitCntnrDownload.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitCntnrDownload.Location = new System.Drawing.Point(0, 0);
			this.splitCntnrDownload.Name = "splitCntnrDownload";
			this.splitCntnrDownload.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitCntnrDownload.Panel1
			// 
			this.splitCntnrDownload.Panel1.Controls.Add(this.webBrowser1);
			// 
			// splitCntnrDownload.Panel2
			// 
			this.splitCntnrDownload.Panel2.Controls.Add(this.flowLayoutPanel1);
			this.splitCntnrDownload.Size = new System.Drawing.Size(504, 312);
			this.splitCntnrDownload.SplitterDistance = 281;
			this.splitCntnrDownload.TabIndex = 8;
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(0, 0);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(504, 281);
			this.webBrowser1.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.btnQuitDl);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(504, 27);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// btnQuitDl
			// 
			this.btnQuitDl.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnQuitDl.Location = new System.Drawing.Point(426, 3);
			this.btnQuitDl.Name = "btnQuitDl";
			this.btnQuitDl.Size = new System.Drawing.Size(75, 23);
			this.btnQuitDl.TabIndex = 0;
			this.btnQuitDl.Text = "&Quit";
			this.btnQuitDl.UseVisualStyleBackColor = true;
			// 
			// splitCntnrBase
			// 
			this.splitCntnrBase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitCntnrBase.Location = new System.Drawing.Point(0, 0);
			this.splitCntnrBase.Name = "splitCntnrBase";
			this.splitCntnrBase.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitCntnrBase.Panel2
			// 
			this.splitCntnrBase.Panel2.Controls.Add(this.splitCntnrDownload);
			this.splitCntnrBase.Size = new System.Drawing.Size(504, 384);
			this.splitCntnrBase.SplitterDistance = 68;
			this.splitCntnrBase.TabIndex = 9;
			// 
			// DownloadThemesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 384);
			this.Controls.Add(this.splitCntnrBase);
			this.Name = "DownloadThemesForm";
			this.Text = "DownloadThemesForm";
			this.Load += new System.EventHandler(this.DownloadThemesForm_Load);
			this.splitCntnrDownload.Panel1.ResumeLayout(false);
			this.splitCntnrDownload.Panel2.ResumeLayout(false);
			this.splitCntnrDownload.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.splitCntnrBase.Panel2.ResumeLayout(false);
			this.splitCntnrBase.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitCntnrDownload;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button btnQuitDl;
		private System.Windows.Forms.SplitContainer splitCntnrBase;
	}
}