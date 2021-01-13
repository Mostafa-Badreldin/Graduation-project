using System;
using System.Windows.Forms;

namespace project
{
	public partial class Report : Form
	{
		public Report()
		{
			InitializeComponent();
		}

		private void Report_Load(object sender, EventArgs e)
		{

			this.reportViewer1.RefreshReport();
		}

		private void btnReport1_Click(object sender, EventArgs e)
		{
			reportViewer1.ServerReport.ReportPath = "/Project_reports/Report1";
			reportViewer1.ServerReport.Refresh();
			reportViewer1.RefreshReport();
		}

		private void btnReport2_Click(object sender, EventArgs e)
		{
			reportViewer1.ServerReport.ReportPath = "/Project_reports/Report2";
			reportViewer1.ServerReport.Refresh();
			reportViewer1.RefreshReport();
		}

		private void btnReport3_Click(object sender, EventArgs e)
		{
			reportViewer1.ServerReport.ReportPath = "/Project_reports/Report3";
			reportViewer1.ServerReport.Refresh();
			reportViewer1.RefreshReport();
		}

		private void btnReport4_Click(object sender, EventArgs e)
		{
			reportViewer1.ServerReport.ReportPath = "/Project_reports/Report4";
			reportViewer1.ServerReport.Refresh();
			reportViewer1.RefreshReport();
		}

		private void btnReport5_Click(object sender, EventArgs e)
		{
			reportViewer1.ServerReport.ReportPath = "/Project_reports/Report5";
			reportViewer1.ServerReport.Refresh();
			reportViewer1.RefreshReport();
		}

		private void btnReport6_Click(object sender, EventArgs e)
		{
			reportViewer1.ServerReport.ReportPath = "/Project_reports/Report6";
			reportViewer1.ServerReport.Refresh();
			reportViewer1.RefreshReport();
		}
	}
}
