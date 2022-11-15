using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webform1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            LoadEmployee();

        }

        protected void LoadEmployee()
        {
            //string con = "Data Source=DESKTOP-H5TNQBM\\SQLEXPRESS;" +
              //  "Initial Catalog=employees;Integrated Security=True";
          
            string con = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);
            
            SqlCommand cmd = new SqlCommand("USP_Get_EmpData", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            if (connection.State == ConnectionState.Closed)
            connection.Open();
            GVemployees.DataSource = cmd.ExecuteReader();
            GVemployees.DataBind();
            connection.Close();
            




        }

        protected void btnclear_Click(object sender, EventArgs e)
        {

        }
    }
}