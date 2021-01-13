
namespace project
{
	partial class Report
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
			this.btnReport1 = new System.Windows.Forms.Button();
			this.btnReport2 = new System.Windows.Forms.Button();
			this.btnReport3 = new System.Windows.Forms.Button();
			this.btnReport4 = new System.Windows.Forms.Button();
			this.btnReport5 = new System.Windows.Forms.Button();
			this.btnReport6 = new System.Windows.Forms.Button();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// btnReport1
			// 
			this.btnReport1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReport1.Location = new System.Drawing.Point(12, 7);
			this.btnReport1.Name = "btnReport1";
			this.btnReport1.Size = new System.Drawing.Size(88, 28);
			this.btnReport1.TabIndex = 0;
			this.btnReport1.Text = "Report 1";
			this.btnReport1.UseVisualStyleBackColor = true;
			this.btnReport1.Click += new System.EventHandler(this.btnReport1_Click);
			// 
			// btnReport2
			// 
			this.btnReport2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnReport2.Location = new System.Drawing.Point(117, 7);
			this.btnReport2.Name = "btnReport2";
			this.btnReport2.Size = new System.Drawing.Size(88, 28);
			this.btnReport2.TabIndex = 1;
			this.btnReport2.Text = "Report 2";
			this.btnReport2.UseVisualStyleBackColor = true;
			this.btnReport2.Click += new System.EventHandler(this.btnReport2_Click);
			// 
			// btnReport3
			// 
			this.btnReport3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnReport3.Location = new System.Drawing.Point(222, 7);
			this.btnReport3.Name = "btnReport3";
			this.btnReport3.Size = new System.Drawing.Size(88, 28);
			this.btnReport3.TabIndex = 2;
			this.btnReport3.Text = "Report 3";
			this.btnReport3.UseVisualStyleBackColor = true;
			this.btnReport3.Click += new System.EventHandler(this.btnReport3_Click);
			// 
			// btnReport4
			// 
			this.btnReport4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnReport4.Location = new System.Drawing.Point(327, 7);
			this.btnReport4.Name = "btnReport4";
			this.btnReport4.Size = new System.Drawing.Size(88, 28);
			this.btnReport4.TabIndex = 3;
			this.btnReport4.Text = "Report 4";
			this.btnReport4.UseVisualStyleBackColor = true;
			this.btnReport4.Click += new System.EventHandler(this.btnReport4_Click);
			// 
			// btnReport5
			// 
			this.btnReport5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnReport5.Location = new System.Drawing.Point(432, 7);
			this.btnReport5.Name = "btnReport5";
			this.btnReport5.Size = new System.Drawing.Size(88, 28);
			this.btnReport5.TabIndex = 4;
			this.btnReport5.Text = "Report 5";
			this.btnReport5.UseVisualStyleBackColor = true;
			this.btnReport5.Click += new System.EventHandler(this.btnReport5_Click);
			// 
			// btnReport6
			// 
			this.btnReport6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnReport6.Location = new System.Drawing.Point(537, 7);
			this.btnReport6.Name = "btnReport6";
			this.btnReport6.Size = new System.Drawing.Size(88, 28);
			this.btnReport6.TabIndex = 5;
			this.btnReport6.Text = "Report 6";
			this.btnReport6.UseVisualStyleBackColor = true;
			this.btnReport6.Click += new System.EventHandler(this.btnReport6_Click);
			// 
			// reportViewer1
			// 
			this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.reportViewer1.Location = new System.Drawing.Point(0, 41);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(639, 382);
			this.reportViewer1.TabIndex = 6;
			// 
			// Report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(639, 423);
			this.Controls.Add(this.reportViewer1);
			this.Controls.Add(this.btnReport6);
			this.Controls.Add(this.btnReport5);
			this.Controls.Add(this.btnReport4);
			this.Controls.Add(this.btnReport3);
			this.Controls.Add(this.btnReport2);
			this.Controls.Add(this.btnReport1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Report";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Report";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Report_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnReport1;
		private System.Windows.Forms.Button btnReport2;
		private System.Windows.Forms.Button btnReport3;
		private System.Windows.Forms.Button btnReport4;
		private System.Windows.Forms.Button btnReport5;
		private System.Windows.Forms.Button btnReport6;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
	}
}