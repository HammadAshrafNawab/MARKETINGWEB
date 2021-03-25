using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MARKETINGWEB
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                //CREATE CONNECTION
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DA0VNAQ\SQLEXPRESS;Initial Catalog=MARKETING;Integrated Security=True");
                //CONNECTION OPEN
                conn.Open();
                // STORED PROCEDURE KO CMD MAIN PASS KIA
                SqlCommand cmd = new SqlCommand("insert_employees", conn);
                //CMD KO BTAYA HAI K BHAE TU STORED PROCEDURE TYPE KA HAI
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add(new SqlParameter("@roll", Convert.ToInt32(txtrollno.Text.ToString())));
                //PARAMETERS DEFINE
                cmd.Parameters.Add(new SqlParameter("@name", txtname.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@email", txtemail.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@address", txtaddress.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@designation", txtdesignation.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@phone", txtphone.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@emp", txtemp.Text.ToString()));

                cmd.ExecuteNonQuery();
                Label1.Text = "DATA INSERTED";
                conn.Close();
            }
            catch (Exception ex)
            {
                Label1.Text = (ex.Message.ToString());
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DA0VNAQ\SQLEXPRESS;Initial Catalog=MARKETING;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("searchbyid_employees", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", Convert.ToInt32(txtid.Text.ToString())));
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds, "EMPLOYEES");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                txtname.Text = dr["NAME"].ToString();
                txtemail.Text = dr["EMAIL"].ToString();
                txtaddress.Text = dr["ADDRESS"].ToString();
                txtdesignation.Text = dr["DESIGNATION"].ToString();
                txtphone.Text = dr["PHONE_NO"].ToString();
                txtemp.Text = dr["EMPLOYEE_CODE"].ToString();
            }
            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //CREATE CONNECTION
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DA0VNAQ\SQLEXPRESS;Initial Catalog=MARKETING;Integrated Security=True");
                //CONNECTION OPEN
                conn.Open();
                // STORED PROCEDURE KO CMD MAIN PASS KIA
                SqlCommand cmd = new SqlCommand("update_employees", conn);
                //CMD KO BTAYA HAI K BHAE TU STORED PROCEDURE TYPE KA HAI
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add(new SqlParameter("@roll", Convert.ToInt32(txtrollno.Text.ToString())));
                //PARAMETERS DEFINE
                cmd.Parameters.Add(new SqlParameter("@id", Convert.ToInt32(txtid.Text.ToString())));
                cmd.Parameters.Add(new SqlParameter("@name", txtname.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@email", txtemail.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@address", txtaddress.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@designation", txtdesignation.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@phone", txtphone.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@emp", txtemp.Text.ToString()));

                cmd.ExecuteNonQuery();
                Label1.Text = "Data UPDATED";
                conn.Close();
            }
            catch (Exception ex)
            {
                Label1.Text = (ex.Message.ToString());
            }

        }
        private void LoadGridView()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DA0VNAQ\SQLEXPRESS;Initial Catalog=MARKETING;Integrated Security=True");
            conn.Open();
         

            SqlCommand cmd = new SqlCommand("search_all", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt != null)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {

        }
    } 
}