using System;
using System.Windows.Forms;

namespace project
{
	public partial class Instructor : Form
	{
		public Instructor()
		{
			InitializeComponent();
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Question().ShowDialog();
			this.Show();
		}

		private void btnReport_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Report().ShowDialog();
			this.Show();
		}
	}
}
