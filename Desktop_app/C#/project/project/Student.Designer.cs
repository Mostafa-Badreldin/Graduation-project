
namespace project
{
	partial class Student
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
			this.btnGenExam = new System.Windows.Forms.Button();
			this.ddlT_FNum = new System.Windows.Forms.ComboBox();
			this.lblT_FNum = new System.Windows.Forms.Label();
			this.ddlMCQNum = new System.Windows.Forms.ComboBox();
			this.lblMCQNum = new System.Windows.Forms.Label();
			this.lblCourseName = new System.Windows.Forms.Label();
			this.ddlCourseName = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnGenExam
			// 
			this.btnGenExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnGenExam.Location = new System.Drawing.Point(189, 257);
			this.btnGenExam.Name = "btnGenExam";
			this.btnGenExam.Size = new System.Drawing.Size(190, 33);
			this.btnGenExam.TabIndex = 0;
			this.btnGenExam.Text = "Generate Exam";
			this.btnGenExam.UseVisualStyleBackColor = true;
			this.btnGenExam.Click += new System.EventHandler(this.btnGenExam_Click);
			// 
			// ddlT_FNum
			// 
			this.ddlT_FNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlT_FNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.ddlT_FNum.FormattingEnabled = true;
			this.ddlT_FNum.Items.AddRange(new object[] {
            "5"});
			this.ddlT_FNum.Location = new System.Drawing.Point(189, 86);
			this.ddlT_FNum.Name = "ddlT_FNum";
			this.ddlT_FNum.Size = new System.Drawing.Size(190, 24);
			this.ddlT_FNum.TabIndex = 1;
			// 
			// lblT_FNum
			// 
			this.lblT_FNum.AutoSize = true;
			this.lblT_FNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblT_FNum.Location = new System.Drawing.Point(118, 89);
			this.lblT_FNum.Name = "lblT_FNum";
			this.lblT_FNum.Size = new System.Drawing.Size(29, 17);
			this.lblT_FNum.TabIndex = 2;
			this.lblT_FNum.Text = "T/F";
			// 
			// ddlMCQNum
			// 
			this.ddlMCQNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlMCQNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.ddlMCQNum.FormattingEnabled = true;
			this.ddlMCQNum.Items.AddRange(new object[] {
            "5"});
			this.ddlMCQNum.Location = new System.Drawing.Point(189, 143);
			this.ddlMCQNum.Name = "ddlMCQNum";
			this.ddlMCQNum.Size = new System.Drawing.Size(190, 24);
			this.ddlMCQNum.TabIndex = 3;
			// 
			// lblMCQNum
			// 
			this.lblMCQNum.AutoSize = true;
			this.lblMCQNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblMCQNum.Location = new System.Drawing.Point(118, 146);
			this.lblMCQNum.Name = "lblMCQNum";
			this.lblMCQNum.Size = new System.Drawing.Size(39, 17);
			this.lblMCQNum.TabIndex = 4;
			this.lblMCQNum.Text = "MCQ";
			// 
			// lblCourseName
			// 
			this.lblCourseName.AutoSize = true;
			this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblCourseName.Location = new System.Drawing.Point(118, 203);
			this.lblCourseName.Name = "lblCourseName";
			this.lblCourseName.Size = new System.Drawing.Size(53, 17);
			this.lblCourseName.TabIndex = 5;
			this.lblCourseName.Text = "Course";
			// 
			// ddlCourseName
			// 
			this.ddlCourseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.ddlCourseName.FormattingEnabled = true;
			this.ddlCourseName.Items.AddRange(new object[] {
            "sql",
            "oracle",
            "java",
            "c#",
            "python",
            "statistics course"});
			this.ddlCourseName.Location = new System.Drawing.Point(189, 200);
			this.ddlCourseName.Name = "ddlCourseName";
			this.ddlCourseName.Size = new System.Drawing.Size(190, 24);
			this.ddlCourseName.TabIndex = 6;
			// 
			// Student
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 381);
			this.Controls.Add(this.btnGenExam);
			this.Controls.Add(this.ddlCourseName);
			this.Controls.Add(this.lblCourseName);
			this.Controls.Add(this.lblT_FNum);
			this.Controls.Add(this.ddlMCQNum);
			this.Controls.Add(this.lblMCQNum);
			this.Controls.Add(this.ddlT_FNum);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Student";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Student";
			this.Load += new System.EventHandler(this.Student_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGenExam;
		private System.Windows.Forms.ComboBox ddlT_FNum;
		private System.Windows.Forms.Label lblT_FNum;
		private System.Windows.Forms.ComboBox ddlMCQNum;
		private System.Windows.Forms.Label lblMCQNum;
		private System.Windows.Forms.ComboBox ddlCourseName;
		private System.Windows.Forms.Label lblCourseName;
	}
}