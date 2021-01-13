
namespace project
{
	partial class Correct
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Correct));
			this.btnCorrect = new System.Windows.Forms.Button();
			this.btnEndExam = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCorrect
			// 
			this.btnCorrect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnCorrect.Location = new System.Drawing.Point(142, 336);
			this.btnCorrect.Name = "btnCorrect";
			this.btnCorrect.Size = new System.Drawing.Size(190, 33);
			this.btnCorrect.TabIndex = 8;
			this.btnCorrect.Text = "Correct Exam";
			this.btnCorrect.UseVisualStyleBackColor = true;
			// 
			// btnEndExam
			// 
			this.btnEndExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEndExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnEndExam.Location = new System.Drawing.Point(342, 336);
			this.btnEndExam.Name = "btnEndExam";
			this.btnEndExam.Size = new System.Drawing.Size(190, 33);
			this.btnEndExam.TabIndex = 9;
			this.btnEndExam.Text = "End Exam";
			this.btnEndExam.UseVisualStyleBackColor = true;
			this.btnEndExam.Click += new System.EventHandler(this.btnEndExam_Click);
			// 
			// Correct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 381);
			this.Controls.Add(this.btnEndExam);
			this.Controls.Add(this.btnCorrect);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Correct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Correct Exam";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCorrect;
		private System.Windows.Forms.Button btnEndExam;
	}
}