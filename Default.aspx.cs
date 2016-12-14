using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace MissDial
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
MissDial missDial = default(MissDial);
		string md_number = null;
		string md_datetime = null;
		string md_operator = null;
		string md_circle = null;
		string md_dnd = null;
		string md_prefix = null;
		string sql_dataSource = null;
		string sql_dataName = null;

		sql_dataSource = "USER\\SQLEXPRESS";
		//Set your sql data source
		sql_dataName = "testDb";
		//Set your database name


		md_number = Request.QueryString["nos"];
		//get number from query string
		md_datetime = Request.QueryString["dttime"];
		//get datetime from query string
		md_operator = Request.QueryString["operator"];
		//get user area from query string
		md_circle = Request.QueryString["circle"];
		//get operator from query string
		md_dnd = Request.QueryString["dnd"];
		//get number from query string
		md_prefix = Request.QueryString["prefix"];
		//get dnd/ndnd from query string

		missDial = new MissDial(md_number, md_datetime, md_circle, md_operator, md_dnd, md_prefix);

		string query = string.Empty;
		query += "INSERT INTO missdial (number, datetime, circle, operator, ndnd, prefix)  ";
		query += "VALUES (@colNumber,@colDtTime, @colCircle, @colOperator,@colDnd, @colPrefix)";



		using (SqlConnection conn = new SqlConnection("Data Source='" + sql_dataSource + "';Initial Catalog='" + sql_dataName + "';Integrated Security=True")) {
			using (SqlCommand comm = new SqlCommand()) {
				var _with1 = comm;
				_with1.Connection = conn;
				_with1.CommandText = query;
				_with1.Parameters.AddWithValue("@colNumber", missDial.getNumber);
				_with1.Parameters.AddWithValue("@colDtTime", missDial.getDateTime);
				_with1.Parameters.AddWithValue("@colCircle", missDial.getCircle);
				_with1.Parameters.AddWithValue("@colOperator", missDial.getMobOperator);
				_with1.Parameters.AddWithValue("@colDnd", missDial.getDnd);
                _with1.Parameters.AddWithValue("@colPrefix", missDial.getPrefix);
                
                try {
					conn.Open();
					comm.ExecuteNonQuery();
				} 
                catch (Exception ex) {
                    MessageBox.Show(ex.Message.ToString());
               
				}
			}
		}

	}
	public _Default()
	{
		Load += Page_Load;
	}
        }
    }

