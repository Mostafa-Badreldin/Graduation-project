using project.DBLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace project
{
	public partial class Question : Form
	{
		public Question()
		{
			InitializeComponent();
		}

		private void Question_Load(object sender, EventArgs e)
		{
			FillCourses();
		}

		private void FillCourses()
		{
			DataTable dt = DBL.ExecuteQuery("exec SelectCourses");
			ddlCourse.DisplayMember = "crs_name";
			ddlCourse.ValueMember = "crs_id";
			ddlCourse.DataSource = dt;
		}

		private void txtQuestionGrade_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
			{
				e.Handled = true;
				MessageBox.Show("Please, enter only numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnInsertQuestion_Click(object sender, EventArgs e)
		{
			DataRowView drv = (DataRowView)ddlCourse.SelectedItem;
			int x = DBL.ExecuteNonQuery(string.Format("exec questions_insert_sp '{0}', '{1}', '{2}', {3}, '{4}'", txtQuestion.Text.Trim(), txtModelAnswer.Text.Trim(), (string)ddlQType.SelectedItem, Convert.ToInt32(txtQuestionGrade.Text.Trim()), drv["crs_name"].ToString()));
			if (x > 0)
			{
				MessageBox.Show("Your question is inserted successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtQuestion.Clear();
				txtModelAnswer.Clear();
				txtQuestionGrade.Clear();
			}
			else
			{
				MessageBox.Show("Your question is not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnInsertChoice_Click(object sender, EventArgs e)
		{
			int x = DBL.ExecuteNonQuery(string.Format("question_choices_insert_v2_sp '{0}', {1}", txtChoice.Text.Trim(), Convert.ToInt32(ddlChoiceID.SelectedItem)));
			if (x > 0)
			{
				MessageBox.Show("Your choice is inserted successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtChoice.Clear();
			}
			else
			{
				MessageBox.Show("Your choice is not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ddlQType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((string)ddlQType.SelectedItem == "T/F")
			{
				ddlChoiceID.Items.Clear();
				ddlChoiceID.Items.Add(1);
				ddlChoiceID.Items.Add(2);
			}
			else
			{
				ddlChoiceID.Items.Clear();
				ddlChoiceID.Items.Add(1);
				ddlChoiceID.Items.Add(2);
				ddlChoiceID.Items.Add(3);
				ddlChoiceID.Items.Add(4);
			}
		}
	}
}
