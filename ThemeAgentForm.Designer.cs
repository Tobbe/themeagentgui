namespace ThemeAgentGUI
{
	partial class ThemeAgentForm
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
			this.lblManage = new System.Windows.Forms.Label();
			this.splitManage = new System.Windows.Forms.SplitContainer();
			this.splitMain = new System.Windows.Forms.SplitContainer();
			this.splitList = new System.Windows.Forms.SplitContainer();
			this.listThemes = new System.Windows.Forms.ListView();
			this.splitTheme = new System.Windows.Forms.SplitContainer();
			this.picPreview = new System.Windows.Forms.PictureBox();
			this.lblAuthor = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.flowTheme = new System.Windows.Forms.FlowLayoutPanel();
			this.btnUninstall = new System.Windows.Forms.Button();
			this.btnSet = new System.Windows.Forms.Button();
			this.splitBottomButtons = new System.Windows.Forms.SplitContainer();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnInstall = new System.Windows.Forms.Button();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnQuitManage = new System.Windows.Forms.Button();
			this.splitManage.Panel1.SuspendLayout();
			this.splitManage.Panel2.SuspendLayout();
			this.splitManage.SuspendLayout();
			this.splitMain.Panel1.SuspendLayout();
			this.splitMain.Panel2.SuspendLayout();
			this.splitMain.SuspendLayout();
			this.splitList.Panel1.SuspendLayout();
			this.splitList.Panel2.SuspendLayout();
			this.splitList.SuspendLayout();
			this.splitTheme.Panel1.SuspendLayout();
			this.splitTheme.Panel2.SuspendLayout();
			this.splitTheme.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
			this.flowTheme.SuspendLayout();
			this.splitBottomButtons.Panel1.SuspendLayout();
			this.splitBottomButtons.Panel2.SuspendLayout();
			this.splitBottomButtons.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblManage
			// 
			this.lblManage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblManage.Location = new System.Drawing.Point(0, 0);
			this.lblManage.Margin = new System.Windows.Forms.Padding(3);
			this.lblManage.MinimumSize = new System.Drawing.Size(0, 56);
			this.lblManage.Name = "lblManage";
			this.lblManage.Size = new System.Drawing.Size(566, 56);
			this.lblManage.TabIndex = 9;
			this.lblManage.Text = "Manage your LiteStep themes";
			this.lblManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// splitManage
			// 
			this.splitManage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitManage.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitManage.IsSplitterFixed = true;
			this.splitManage.Location = new System.Drawing.Point(0, 0);
			this.splitManage.Name = "splitManage";
			this.splitManage.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitManage.Panel1
			// 
			this.splitManage.Panel1.BackColor = System.Drawing.SystemColors.Control;
			this.splitManage.Panel1.Controls.Add(this.lblManage);
			this.splitManage.Panel1MinSize = 56;
			// 
			// splitManage.Panel2
			// 
			this.splitManage.Panel2.BackColor = System.Drawing.SystemColors.Control;
			this.splitManage.Panel2.Controls.Add(this.splitMain);
			this.splitManage.Size = new System.Drawing.Size(566, 403);
			this.splitManage.SplitterDistance = 56;
			this.splitManage.TabIndex = 10;
			// 
			// splitMain
			// 
			this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitMain.Location = new System.Drawing.Point(0, 0);
			this.splitMain.Name = "splitMain";
			this.splitMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitMain.Panel1
			// 
			this.splitMain.Panel1.Controls.Add(this.splitList);
			// 
			// splitMain.Panel2
			// 
			this.splitMain.Panel2.Controls.Add(this.splitBottomButtons);
			this.splitMain.Size = new System.Drawing.Size(566, 343);
			this.splitMain.SplitterDistance = 314;
			this.splitMain.TabIndex = 0;
			// 
			// splitList
			// 
			this.splitList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitList.Location = new System.Drawing.Point(0, 0);
			this.splitList.Name = "splitList";
			// 
			// splitList.Panel1
			// 
			this.splitList.Panel1.Controls.Add(this.listThemes);
			// 
			// splitList.Panel2
			// 
			this.splitList.Panel2.Controls.Add(this.splitTheme);
			this.splitList.Size = new System.Drawing.Size(566, 314);
			this.splitList.SplitterDistance = 188;
			this.splitList.TabIndex = 0;
			// 
			// listThemes
			// 
			this.listThemes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listThemes.Location = new System.Drawing.Point(0, 0);
			this.listThemes.Name = "listThemes";
			this.listThemes.Size = new System.Drawing.Size(188, 314);
			this.listThemes.TabIndex = 0;
			this.listThemes.UseCompatibleStateImageBehavior = false;
			// 
			// splitTheme
			// 
			this.splitTheme.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitTheme.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitTheme.IsSplitterFixed = true;
			this.splitTheme.Location = new System.Drawing.Point(0, 0);
			this.splitTheme.Name = "splitTheme";
			this.splitTheme.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitTheme.Panel1
			// 
			this.splitTheme.Panel1.Controls.Add(this.picPreview);
			this.splitTheme.Panel1.Controls.Add(this.lblAuthor);
			this.splitTheme.Panel1.Controls.Add(this.lblName);
			// 
			// splitTheme.Panel2
			// 
			this.splitTheme.Panel2.Controls.Add(this.flowTheme);
			this.splitTheme.Size = new System.Drawing.Size(374, 314);
			this.splitTheme.SplitterDistance = 283;
			this.splitTheme.TabIndex = 0;
			// 
			// picPreview
			// 
			this.picPreview.BackColor = System.Drawing.SystemColors.Control;
			this.picPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picPreview.Location = new System.Drawing.Point(0, 37);
			this.picPreview.Name = "picPreview";
			this.picPreview.Size = new System.Drawing.Size(374, 246);
			this.picPreview.TabIndex = 2;
			this.picPreview.TabStop = false;
			// 
			// lblAuthor
			// 
			this.lblAuthor.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblAuthor.Location = new System.Drawing.Point(0, 21);
			this.lblAuthor.Name = "lblAuthor";
			this.lblAuthor.Size = new System.Drawing.Size(374, 16);
			this.lblAuthor.TabIndex = 1;
			this.lblAuthor.Text = "Author: Theme Author";
			// 
			// lblName
			// 
			this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(0, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(374, 21);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "ThemeName v0.1";
			// 
			// flowTheme
			// 
			this.flowTheme.Controls.Add(this.btnUninstall);
			this.flowTheme.Controls.Add(this.btnSet);
			this.flowTheme.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowTheme.Location = new System.Drawing.Point(0, 0);
			this.flowTheme.Name = "flowTheme";
			this.flowTheme.Size = new System.Drawing.Size(374, 27);
			this.flowTheme.TabIndex = 0;
			// 
			// btnUninstall
			// 
			this.btnUninstall.Location = new System.Drawing.Point(3, 3);
			this.btnUninstall.Name = "btnUninstall";
			this.btnUninstall.Size = new System.Drawing.Size(75, 23);
			this.btnUninstall.TabIndex = 0;
			this.btnUninstall.Text = "Uninstall";
			this.btnUninstall.UseVisualStyleBackColor = true;
			// 
			// btnSet
			// 
			this.btnSet.AutoSize = true;
			this.btnSet.Location = new System.Drawing.Point(84, 3);
			this.btnSet.Name = "btnSet";
			this.btnSet.Size = new System.Drawing.Size(79, 23);
			this.btnSet.TabIndex = 1;
			this.btnSet.Text = "Set as theme";
			this.btnSet.UseVisualStyleBackColor = true;
			// 
			// splitBottomButtons
			// 
			this.splitBottomButtons.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitBottomButtons.IsSplitterFixed = true;
			this.splitBottomButtons.Location = new System.Drawing.Point(0, 0);
			this.splitBottomButtons.Name = "splitBottomButtons";
			// 
			// splitBottomButtons.Panel1
			// 
			this.splitBottomButtons.Panel1.Controls.Add(this.flowLayoutPanel1);
			// 
			// splitBottomButtons.Panel2
			// 
			this.splitBottomButtons.Panel2.Controls.Add(this.flowLayoutPanel2);
			this.splitBottomButtons.Size = new System.Drawing.Size(566, 25);
			this.splitBottomButtons.SplitterDistance = 288;
			this.splitBottomButtons.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.btnInstall);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(288, 25);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// btnInstall
			// 
			this.btnInstall.AutoSize = true;
			this.btnInstall.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnInstall.Location = new System.Drawing.Point(2, 0);
			this.btnInstall.Margin = new System.Windows.Forms.Padding(2, 0, 3, 3);
			this.btnInstall.Name = "btnInstall";
			this.btnInstall.Size = new System.Drawing.Size(99, 23);
			this.btnInstall.TabIndex = 0;
			this.btnInstall.Text = "Install new theme";
			this.btnInstall.UseVisualStyleBackColor = false;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.btnQuitManage);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(274, 25);
			this.flowLayoutPanel2.TabIndex = 0;
			// 
			// btnQuitManage
			// 
			this.btnQuitManage.Location = new System.Drawing.Point(197, 0);
			this.btnQuitManage.Margin = new System.Windows.Forms.Padding(3, 0, 2, 3);
			this.btnQuitManage.Name = "btnQuitManage";
			this.btnQuitManage.Size = new System.Drawing.Size(75, 23);
			this.btnQuitManage.TabIndex = 0;
			this.btnQuitManage.Text = "&Quit";
			this.btnQuitManage.UseVisualStyleBackColor = true;
			this.btnQuitManage.Click += new System.EventHandler(this.btnQuitManage_Click);
			// 
			// ThemeAgentForm
			// 
			this.AcceptButton = this.btnSet;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 403);
			this.Controls.Add(this.splitManage);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(574, 430);
			this.Name = "ThemeAgentForm";
			this.Text = "ThemeAgent";
			this.Load += new System.EventHandler(this.ThemeAgentForm_Load);
			this.Layout += new System.Windows.Forms.LayoutEventHandler(this.ThemeAgentForm_Layout);
			this.splitManage.Panel1.ResumeLayout(false);
			this.splitManage.Panel2.ResumeLayout(false);
			this.splitManage.ResumeLayout(false);
			this.splitMain.Panel1.ResumeLayout(false);
			this.splitMain.Panel2.ResumeLayout(false);
			this.splitMain.ResumeLayout(false);
			this.splitList.Panel1.ResumeLayout(false);
			this.splitList.Panel2.ResumeLayout(false);
			this.splitList.ResumeLayout(false);
			this.splitTheme.Panel1.ResumeLayout(false);
			this.splitTheme.Panel2.ResumeLayout(false);
			this.splitTheme.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
			this.flowTheme.ResumeLayout(false);
			this.flowTheme.PerformLayout();
			this.splitBottomButtons.Panel1.ResumeLayout(false);
			this.splitBottomButtons.Panel2.ResumeLayout(false);
			this.splitBottomButtons.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblManage;
		private System.Windows.Forms.SplitContainer splitManage;
		private System.Windows.Forms.SplitContainer splitMain;
		private System.Windows.Forms.SplitContainer splitBottomButtons;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button btnInstall;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Button btnQuitManage;
		private System.Windows.Forms.SplitContainer splitList;
		private System.Windows.Forms.ListView listThemes;
		private System.Windows.Forms.SplitContainer splitTheme;
		private System.Windows.Forms.FlowLayoutPanel flowTheme;
		private System.Windows.Forms.Button btnUninstall;
		private System.Windows.Forms.Button btnSet;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.PictureBox picPreview;
		private System.Windows.Forms.Label lblAuthor;

	}
}
