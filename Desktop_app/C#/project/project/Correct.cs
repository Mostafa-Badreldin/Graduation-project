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
	public partial class Correct : Form
	{
		public Correct()
		{
			InitializeComponent();
		}

		private void btnEndExam_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
