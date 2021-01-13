using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
	public partial class Exam : Form
	{
		Student s;

		public Exam():this(null)
		{
			//InitializeComponent();
		}

		public Exam(Student _s)
		{
			s = _s;
			InitializeComponent();
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Correct().ShowDialog();
		}

		private void Exam_Load(object sender, EventArgs e)
		{
			label1.Text = (string)s.exam.Rows[0][0];
			radioButton1.Text = (string)s.exam.Rows[0][1];
			radioButton2.Text = (string)s.exam.Rows[1][1];
			radioButton3.Text = (string)s.exam.Rows[2][1];
			radioButton4.Text = (string)s.exam.Rows[3][1];
			label2.Text = (string)s.exam.Rows[4][0];
			radioButton5.Text = (string)s.exam.Rows[4][1];
			radioButton6.Text = (string)s.exam.Rows[5][1];
			radioButton7.Text = (string)s.exam.Rows[6][1];
			radioButton8.Text = (string)s.exam.Rows[7][1];
			label3.Text = (string)s.exam.Rows[8][0];
			radioButton9.Text = (string)s.exam.Rows[8][1];
			radioButton10.Text = (string)s.exam.Rows[9][1];
			radioButton11.Text = (string)s.exam.Rows[10][1];
			radioButton12.Text = (string)s.exam.Rows[11][1];
			label4.Text = (string)s.exam.Rows[12][0];
			radioButton13.Text = (string)s.exam.Rows[12][1];
			radioButton14.Text = (string)s.exam.Rows[13][1];
			radioButton15.Text = (string)s.exam.Rows[14][1];
			radioButton16.Text = (string)s.exam.Rows[15][1];
			label5.Text = (string)s.exam.Rows[16][0];
			radioButton17.Text = (string)s.exam.Rows[16][1];
			radioButton18.Text = (string)s.exam.Rows[17][1];
			radioButton19.Text = (string)s.exam.Rows[18][1];
			radioButton20.Text = (string)s.exam.Rows[19][1];
			label6.Text = (string)s.exam.Rows[20][0];
			radioButton21.Text = (string)s.exam.Rows[20][1];
			radioButton22.Text = (string)s.exam.Rows[21][1];
			label7.Text = (string)s.exam.Rows[22][0];
			radioButton23.Text = (string)s.exam.Rows[22][1];
			radioButton24.Text = (string)s.exam.Rows[23][1];
			label8.Text = (string)s.exam.Rows[24][0];
			radioButton25.Text = (string)s.exam.Rows[24][1];
			radioButton26.Text = (string)s.exam.Rows[25][1];
			label9.Text = (string)s.exam.Rows[26][0];
			radioButton27.Text = (string)s.exam.Rows[26][1];
			radioButton28.Text = (string)s.exam.Rows[27][1];
			label10.Text = (string)s.exam.Rows[28][0];
			radioButton29.Text = (string)s.exam.Rows[28][1];
			radioButton30.Text = (string)s.exam.Rows[29][1];
		}
	}
}
