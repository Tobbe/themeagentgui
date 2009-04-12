namespace ThemeAgentGUI
{
	partial class InstallProgressForm
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
			this.pbProgress = new System.Windows.Forms.ProgressBar();
			this.lblProgress = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pbProgress
			// 
			this.pbProgress.Location = new System.Drawing.Point(12, 56);
			this.pbProgress.Name = "pbProgress";
			this.pbProgress.Size = new System.Drawing.Size(268, 23);
			this.pbProgress.TabIndex = 0;
			// 
			// lblProgress
			// 
			this.lblProgress.Location = new System.Drawing.Point(12, 9);
			this.lblProgress.Name = "lblProgress";
			this.lblProgress.Size = new System.Drawing.Size(268, 33);
			this.lblProgress.TabIndex = 1;
			this.lblProgress.Text = "Theme installation is starting";
			// 
			// InstallProgressForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 94);
			this.ControlBox = false;
			this.Controls.Add(this.lblProgress);
			this.Controls.Add(this.pbProgress);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(300, 121);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(300, 121);
			this.Name = "InstallProgressForm";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Theme Installation Progress";
			this.TopMost = true;
			this.Shown += new System.EventHandler(this.InstallProgressForm_Shown);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ProgressBar pbProgress;
		private System.Windows.Forms.Label lblProgress;
	}
}