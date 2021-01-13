using project.DBLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace project
{
	public partial class home : Form
	{
		public home()
		{
			InitializeComponent();
		}

		private void home_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(MessageBox.Show("Are you sure to close the application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				e.Cancel = true;
			}
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This application is developed by:\n" +
				"\n    1- Mostafa Ibrahim" +
				"\n    2- Habiba Khaled" +
				"\n    3- Nouran Sherif" +
				"\n    4- Amira Fayez\n" +
				"\nCopyright© 2021", "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnInstructor_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable dt = DBL.ExecuteQuery(string.Format("select * from instructor where ins_name = '{0}' and ins_id = {1}", Convert.ToString(txtUserName.Text.Trim()), txtPassword.Text.Trim()));
				if (dt.Rows.Count == 1)
				{
					this.Hide();
					new Instructor().ShowDialog();
					txtUserName.Clear();
					txtPassword.Clear();
					this.Show();
				}
				else
				{
					MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtUserName.Clear();
					txtPassword.Clear();
				}
			}
			catch (Exception)
			{

				MessageBox.Show("Please, enter your password as numbers only", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtUserName.Clear();
				txtPassword.Clear();
			}
		}

		private void btnStudent_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable dt = DBL.ExecuteQuery(string.Format("select * from student where std_fname = '{0}' and std_id = {1}", Convert.ToString(txtUserName.Text.Trim()), txtPassword.Text.Trim()));
				if (dt.Rows.Count == 1)
				{
					this.Hide();
					new Student().ShowDialog();
					txtUserName.Clear();
					txtPassword.Clear();
					this.Show();
				}
				else
				{
					MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtUserName.Clear();
					txtPassword.Clear();
				}
			}
			catch (Exception)
			{

				MessageBox.Show("Please, enter your password as numbers only", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtUserName.Clear();
				txtPassword.Clear();
			}
		}
	}
}
