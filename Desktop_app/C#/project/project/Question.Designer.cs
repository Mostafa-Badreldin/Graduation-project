
namespace project
{
	partial class Question
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question));
			this.gbQuestion = new System.Windows.Forms.GroupBox();
			this.btnInsertQuestion = new System.Windows.Forms.Button();
			this.ddlCourse = new System.Windows.Forms.ComboBox();
			this.lblCourse = new System.Windows.Forms.Label();
			this.ddlQType = new System.Windows.Forms.ComboBox();
			this.lblQType = new System.Windows.Forms.Label();
			this.txtQuestionGrade = new System.Windows.Forms.TextBox();
			this.lblQuestionGrade = new System.Windows.Forms.Label();
			this.txtModelAnswer = new System.Windows.Forms.TextBox();
			this.lblModelAnswer = new System.Windows.Forms.Label();
			this.txtQuestion = new System.Windows.Forms.TextBox();
			this.lblQuestion = new System.Windows.Forms.Label();
			this.gbQuestionChoices = new System.Windows.Forms.GroupBox();
			this.btnInsertChoice = new System.Windows.Forms.Button();
			this.ddlChoiceID = new System.Windows.Forms.ComboBox();
			this.lblChoiceID = new System.Windows.Forms.Label();
			this.txtChoice = new System.Windows.Forms.TextBox();
			this.gbQuestion.SuspendLayout();
			this.gbQuestionChoices.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbQuestion
			// 
			this.gbQuestion.Controls.Add(this.btnInsertQuestion);
			this.gbQuestion.Controls.Add(this.ddlCourse);
			this.gbQuestion.Controls.Add(this.lblCourse);
			this.gbQuestion.Controls.Add(this.ddlQType);
			this.gbQuestion.Controls.Add(this.lblQType);
			this.gbQuestion.Controls.Add(this.txtQuestionGrade);
			this.gbQuestion.Controls.Add(this.lblQuestionGrade);
			this.gbQuestion.Controls.Add(this.txtModelAnswer);
			this.gbQuestion.Controls.Add(this.lblModelAnswer);
			this.gbQuestion.Controls.Add(this.txtQuestion);
			this.gbQuestion.Controls.Add(this.lblQuestion);
			this.gbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.gbQuestion.Location = new System.Drawing.Point(7, 8);
			this.gbQuestion.Name = "gbQuestion";
			this.gbQuestion.Size = new System.Drawing.Size(531, 203);
			this.gbQuestion.TabIndex = 0;
			this.gbQuestion.TabStop = false;
			this.gbQuestion.Text = "Question";
			// 
			// btnInsertQuestion
			// 
			this.btnInsertQuestion.Location = new System.Drawing.Point(389, 153);
			this.btnInsertQuestion.Name = "btnInsertQuestion";
			this.btnInsertQuestion.Size = new System.Drawing.Size(121, 37);
			this.btnInsertQuestion.TabIndex = 10;
			this.btnInsertQuestion.Text = "Insert Question";
			this.btnInsertQuestion.UseVisualStyleBackColor = true;
			this.btnInsertQuestion.Click += new System.EventHandler(this.btnInsertQuestion_Click);
			// 
			// ddlCourse
			// 
			this.ddlCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlCourse.FormattingEnabled = true;
			this.ddlCourse.Location = new System.Drawing.Point(140, 163);
			this.ddlCourse.Name = "ddlCourse";
			this.ddlCourse.Size = new System.Drawing.Size(121, 24);
			this.ddlCourse.TabIndex = 9;
			// 
			// lblCourse
			// 
			this.lblCourse.AutoSize = true;
			this.lblCourse.Location = new System.Drawing.Point(22, 166);
			this.lblCourse.Name = "lblCourse";
			this.lblCourse.Size = new System.Drawing.Size(53, 17);
			this.lblCourse.TabIndex = 8;
			this.lblCourse.Text = "Course";
			// 
			// ddlQType
			// 
			this.ddlQType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlQType.FormattingEnabled = true;
			this.ddlQType.Items.AddRange(new object[] {
            "MCQ",
            "T/F"});
			this.ddlQType.Location = new System.Drawing.Point(389, 114);
			this.ddlQType.Name = "ddlQType";
			this.ddlQType.Size = new System.Drawing.Size(121, 24);
			this.ddlQType.TabIndex = 7;
			this.ddlQType.SelectedIndexChanged += new System.EventHandler(this.ddlQType_SelectedIndexChanged);
			// 
			// lblQType
			// 
			this.lblQType.AutoSize = true;
			this.lblQType.Location = new System.Drawing.Point(277, 117);
			this.lblQType.Name = "lblQType";
			this.lblQType.Size = new System.Drawing.Size(101, 17);
			this.lblQType.TabIndex = 6;
			this.lblQType.Text = "Question Type";
			// 
			// txtQuestionGrade
			// 
			this.txtQuestionGrade.Location = new System.Drawing.Point(140, 114);
			this.txtQuestionGrade.Name = "txtQuestionGrade";
			this.txtQuestionGrade.Size = new System.Drawing.Size(100, 23);
			this.txtQuestionGrade.TabIndex = 5;
			this.txtQuestionGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuestionGrade_KeyPress);
			// 
			// lblQuestionGrade
			// 
			this.lblQuestionGrade.AutoSize = true;
			this.lblQuestionGrade.Location = new System.Drawing.Point(22, 117);
			this.lblQuestionGrade.Name = "lblQuestionGrade";
			this.lblQuestionGrade.Size = new System.Drawing.Size(106, 17);
			this.lblQuestionGrade.TabIndex = 4;
			this.lblQuestionGrade.Text = "Question grade";
			// 
			// txtModelAnswer
			// 
			this.txtModelAnswer.Location = new System.Drawing.Point(140, 73);
			this.txtModelAnswer.Name = "txtModelAnswer";
			this.txtModelAnswer.Size = new System.Drawing.Size(370, 23);
			this.txtModelAnswer.TabIndex = 3;
			// 
			// lblModelAnswer
			// 
			this.lblModelAnswer.AutoSize = true;
			this.lblModelAnswer.Location = new System.Drawing.Point(22, 76);
			this.lblModelAnswer.Name = "lblModelAnswer";
			this.lblModelAnswer.Size = new System.Drawing.Size(95, 17);
			this.lblModelAnswer.TabIndex = 2;
			this.lblModelAnswer.Text = "Model answer";
			// 
			// txtQuestion
			// 
			this.txtQuestion.Location = new System.Drawing.Point(140, 32);
			this.txtQuestion.Name = "txtQuestion";
			this.txtQuestion.Size = new System.Drawing.Size(370, 23);
			this.txtQuestion.TabIndex = 1;
			// 
			// lblQuestion
			// 
			this.lblQuestion.AutoSize = true;
			this.lblQuestion.Location = new System.Drawing.Point(22, 35);
			this.lblQuestion.Name = "lblQuestion";
			this.lblQuestion.Size = new System.Drawing.Size(65, 17);
			this.lblQuestion.TabIndex = 0;
			this.lblQuestion.Text = "Question";
			// 
			// gbQuestionChoices
			// 
			this.gbQuestionChoices.Controls.Add(this.btnInsertChoice);
			this.gbQuestionChoices.Controls.Add(this.ddlChoiceID);
			this.gbQuestionChoices.Controls.Add(this.lblChoiceID);
			this.gbQuestionChoices.Controls.Add(this.txtChoice);
			this.gbQuestionChoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.gbQuestionChoices.Location = new System.Drawing.Point(7, 222);
			this.gbQuestionChoices.Name = "gbQuestionChoices";
			this.gbQuestionChoices.Size = new System.Drawing.Size(531, 144);
			this.gbQuestionChoices.TabIndex = 1;
			this.gbQuestionChoices.TabStop = false;
			this.gbQuestionChoices.Text = "Question Choices";
			// 
			// btnInsertChoice
			// 
			this.btnInsertChoice.Location = new System.Drawing.Point(389, 84);
			this.btnInsertChoice.Name = "btnInsertChoice";
			this.btnInsertChoice.Size = new System.Drawing.Size(121, 37);
			this.btnInsertChoice.TabIndex = 3;
			this.btnInsertChoice.Text = "Insert Choice";
			this.btnInsertChoice.UseVisualStyleBackColor = true;
			this.btnInsertChoice.Click += new System.EventHandler(this.btnInsertChoice_Click);
			// 
			// ddlChoiceID
			// 
			this.ddlChoiceID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlChoiceID.FormattingEnabled = true;
			this.ddlChoiceID.Location = new System.Drawing.Point(389, 33);
			this.ddlChoiceID.Name = "ddlChoiceID";
			this.ddlChoiceID.Size = new System.Drawing.Size(121, 24);
			this.ddlChoiceID.TabIndex = 2;
			// 
			// lblChoiceID
			// 
			this.lblChoiceID.AutoSize = true;
			this.lblChoiceID.Location = new System.Drawing.Point(296, 36);
			this.lblChoiceID.Name = "lblChoiceID";
			this.lblChoiceID.Size = new System.Drawing.Size(68, 17);
			this.lblChoiceID.TabIndex = 1;
			this.lblChoiceID.Text = "Choice ID";
			// 
			// txtChoice
			// 
			this.txtChoice.Location = new System.Drawing.Point(25, 33);
			this.txtChoice.Name = "txtChoice";
			this.txtChoice.Size = new System.Drawing.Size(229, 23);
			this.txtChoice.TabIndex = 0;
			// 
			// Question
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 381);
			this.Controls.Add(this.gbQuestionChoices);
			this.Controls.Add(this.gbQuestion);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Question";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Question";
			this.Load += new System.EventHandler(this.Question_Load);
			this.gbQuestion.ResumeLayout(false);
			this.gbQuestion.PerformLayout();
			this.gbQuestionChoices.ResumeLayout(false);
			this.gbQuestionChoices.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbQuestion;
		private System.Windows.Forms.TextBox txtQuestion;
		private System.Windows.Forms.Label lblQuestion;
		private System.Windows.Forms.TextBox txtModelAnswer;
		private System.Windows.Forms.Label lblModelAnswer;
		private System.Windows.Forms.ComboBox ddlQType;
		private System.Windows.Forms.Label lblQType;
		private System.Windows.Forms.TextBox txtQuestionGrade;
		private System.Windows.Forms.Label lblQuestionGrade;
		private System.Windows.Forms.ComboBox ddlCourse;
		private System.Windows.Forms.Label lblCourse;
		private System.Windows.Forms.Button btnInsertQuestion;
		private System.Windows.Forms.GroupBox gbQuestionChoices;
		private System.Windows.Forms.TextBox txtChoice;
		private System.Windows.Forms.ComboBox ddlChoiceID;
		private System.Windows.Forms.Label lblChoiceID;
		private System.Windows.Forms.Button btnInsertChoice;
	}
}