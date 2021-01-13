using System.Data;
using System.Data.SqlClient;

namespace project.DBLayer
{
	static class DBL
	{
		static string conStr;

		static DBL()
		{
			conStr = "Data Source=.;Initial Catalog=examination_system;Integrated Security=True";
		}

		#region Select Statement using disconnected model
		public static DataTable ExecuteQuery (string selectCommand)
		{
			SqlDataAdapter adpt = new SqlDataAdapter(selectCommand, conStr);
			DataTable result = new DataTable();
			adpt.Fill(result);
			return result;
		}
		#endregion

		#region Insert, Update & Delete statement using connected model
		public static int ExecuteNonQuery (string dmlCommand)
		{
			SqlConnection con = new SqlConnection(conStr);
			SqlCommand cmd = new SqlCommand(dmlCommand, con);
			con.Open();
			int result = cmd.ExecuteNonQuery();
			con.Close();
			return result;
		}
		#endregion

		#region Scalar query
		public static object ExecuteScalar(string selectCommand)
		{
			object result = null;
			DataTable dt = ExecuteQuery(selectCommand);
			if (dt.Rows.Count > 0)
			{
				result = dt.Rows[0][0];
			}
			return result;
		}
		#endregion
	}
}
