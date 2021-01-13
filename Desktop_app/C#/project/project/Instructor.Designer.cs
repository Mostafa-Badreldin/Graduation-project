
namespace project
{
	partial class Instructor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructor));
			this.btnInsert = new System.Windows.Forms.Button();
			this.btnReport = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnInsert
			// 
			this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInsert.Location = new System.Drawing.Point(192, 112);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(148, 45);
			this.btnInsert.TabIndex = 0;
			this.btnInsert.Text = "Insert Question";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// btnReport
			// 
			this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReport.Location = new System.Drawing.Point(192, 229);
			this.btnReport.Name = "btnReport";
			this.btnReport.Size = new System.Drawing.Size(148, 45);
			this.btnReport.TabIndex = 1;
			this.btnReport.Text = "View Reports";
			this.btnReport.UseVisualStyleBackColor = true;
			this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
			// 
			// Instructor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 381);
			this.Controls.Add(this.btnReport);
			this.Controls.Add(this.btnInsert);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Instructor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Instructor";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.Button btnReport;
	}
}