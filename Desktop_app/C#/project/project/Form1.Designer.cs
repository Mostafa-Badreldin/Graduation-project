
namespace project
{
	partial class home
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
			this.lblExam = new System.Windows.Forms.Label();
			this.btnInstructor = new System.Windows.Forms.Button();
			this.btnStudent = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblExam
			// 
			this.lblExam.AutoSize = true;
			this.lblExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lblExam.Location = new System.Drawing.Point(72, 77);
			this.lblExam.Name = "lblExam";
			this.lblExam.Size = new System.Drawing.Size(403, 46);
			this.lblExam.TabIndex = 0;
			this.lblExam.Text = "Examination System";
			this.lblExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnInstructor
			// 
			this.btnInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInstructor.Location = new System.Drawing.Point(19, 289);
			this.btnInstructor.Name = "btnInstructor";
			this.btnInstructor.Size = new System.Drawing.Size(159, 46);
			this.btnInstructor.TabIndex = 1;
			this.btnInstructor.Text = "Instructor";
			this.btnInstructor.UseVisualStyleBackColor = true;
			this.btnInstructor.Click += new System.EventHandler(this.btnInstructor_Click);
			// 
			// btnStudent
			// 
			this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStudent.Location = new System.Drawing.Point(193, 289);
			this.btnStudent.Name = "btnStudent";
			this.btnStudent.Size = new System.Drawing.Size(159, 46);
			this.btnStudent.TabIndex = 2;
			this.btnStudent.Text = "Student";
			this.btnStudent.UseVisualStyleBackColor = true;
			this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
			// 
			// btnAbout
			// 
			this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAbout.Location = new System.Drawing.Point(367, 289);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(159, 46);
			this.btnAbout.TabIndex = 3;
			this.btnAbout.Text = "About";
			this.btnAbout.UseVisualStyleBackColor = true;
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(99, 183);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Username";
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.txtUserName.Location = new System.Drawing.Point(191, 180);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(159, 23);
			this.txtUserName.TabIndex = 5;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.txtPassword.Location = new System.Drawing.Point(191, 230);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(159, 23);
			this.txtPassword.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.Location = new System.Drawing.Point(99, 233);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "Password";
			// 
			// home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 381);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.btnStudent);
			this.Controls.Add(this.btnInstructor);
			this.Controls.Add(this.lblExam);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "home";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Home";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.home_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblExam;
		private System.Windows.Forms.Button btnInstructor;
		private System.Windows.Forms.Button btnStudent;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label2;
	}
}

