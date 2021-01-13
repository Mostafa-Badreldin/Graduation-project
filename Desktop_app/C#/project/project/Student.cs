using project.DBLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace project
{
	public partial class Student : Form
	{
		public DataTable exam { get; set; }

		public Student()
		{
			InitializeComponent();
		}

		private void Student_Load(object sender, EventArgs e)
		{
			FillCourses();
		}

		private void FillCourses()
		{
			DataTable dt = DBL.ExecuteQuery("exec SelectCoursesQ");
			ddlCourseName.DisplayMember = "crs_name";
			ddlCourseName.ValueMember = "crs_id";
			ddlCourseName.DataSource = dt;
		}

		private void btnGenExam_Click(object sender, EventArgs e)
		{
			GenerateExam();
			int ExamID = ExamId();
			exam = Examshow(ExamID);
			this.Hide();
			new Exam(this).ShowDialog();
			this.Show();
		}

		private void GenerateExam()
		{
			DataRowView drv = (DataRowView)ddlCourseName.SelectedItem;
			DataTable dt = DBL.ExecuteQuery(string.Format("exec ExamGeneration_sp '{0}', {1}, {2}", drv["crs_name"].ToString(), Convert.ToInt32(ddlMCQNum.SelectedItem), Convert.ToInt32(ddlT_FNum.SelectedItem)));
		}

		private int ExamId()
		{
			int ExamId = (int)DBL.ExecuteScalar("select max(exam_id) from Exam");
			return ExamId;
		}

		private DataTable Examshow(int ExamId)
		{
			DataTable dt = DBL.ExecuteQuery(string.Format("exec Examshow_sp {0}", ExamId));
			return dt;
		}
	}
}
