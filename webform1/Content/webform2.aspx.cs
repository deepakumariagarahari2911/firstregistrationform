using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webform1.Content
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {

            ClearForm();
        }
        public void ClearForm()
        {
            txtname.Text = "";
            txtemail.Text = "";
            txtsalary.Text = "";
            txtmobile.Text = "";
            txtdob.Text = "";
        }

        protected void btnregister_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);
            //string query = "insert into EmpData(name,email,salary,mobile,dob) values('" + txtname.Text + "','" + txtemail.Text +
              //  "','" + txtsalary.Text + "','" + txtmobile.Text + "','" + txtdob.Text + "')";

            SqlCommand cmd = new SqlCommand("USP_Create_EmpData", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@salary", txtsalary.Text);
            cmd.Parameters.AddWithValue("@mobile", txtmobile.Text);
            cmd.Parameters.AddWithValue("@dob", txtdob.Text);

            if (connection.State == ConnectionState.Closed)
                connection.Open();

            SqlDataReader dr= cmd.ExecuteReader();
            dr.Read();
            int EmailExist = (int)dr["EmailExist"];
            int Created = (int)dr["Created"];
            if(EmailExist==1)
            {
                lbMassage.Text = "This Email is already exist Please try another Email!";
                lbMassage.ForeColor = System.Drawing.Color.Red;
            }

            else if(Created==1)
            {
                lbMassage.Text = "Employee Registered Successfully!";
                lbMassage.ForeColor = System.Drawing.Color.Gray;
                ClearForm();
            }
            else
            {
                lbMassage.Text = "Something Went Wrong!";
                lbMassage.ForeColor = System.Drawing.Color.Red;
            }
            connection.Close();






        }
    }
}