using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MARKETINGWEB
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        DbCon db = new DbCon();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            string qry = "INSERT into SUPPLIERS (NAME,EMAIL,ADDRESS,CELL_NO,PHONE_NO,WEBSITE_ADDRESS) values ('" + txtname.Text + "' , '" + txtemail.Text + "','" + txtaddress.Text + "','" + txtcell.Text + "','" + txtphone.Text + "','" + txtweb.Text + "')";
            if (db.UDI(qry))
            {
                Label1.Text = "data inserted";
            }
            else
            {
                Label1.Text = " not data inserted";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        { 
          string qry = "update  SUPPLIERS set NAME='" + txtname.Text + "', EMAIL='" + txtemail.Text + "', ADDRESS = '" + txtaddress.Text + "', CELL_NO ='" + txtcell.Text + "',PHONE_NO = '" + txtphone.Text + "', WEBSITE_ADDRESS ='" + txtweb.Text + "' where ID='" + txtid.Text + "' ";
            if (db.UDI(qry))
            {
                Label1.Text = "data updated";
            }
            else
            {
                Label1.Text = " not data updated";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string qry = "select * from SUPPLIERS where ID='" + txtid.Text + "' ";
            DataTable dt = db.Search(qry);
            if (dt != null)
            {
                txtname.Text = dt.Rows[0]["NAME"].ToString();
                txtemail.Text = dt.Rows[0]["EMAIL"].ToString();
                txtaddress.Text = dt.Rows[0]["ADDRESS"].ToString();
                txtcell.Text = dt.Rows[0]["CELL_NO"].ToString();
                txtphone.Text = dt.Rows[0]["PHONE_NO"].ToString();
                txtweb.Text = dt.Rows[0]["WEBSITE_ADDRESS"].ToString();
            }
        }
        private void LoadGridView()
        {
            string qry = "select * from  SUPPLIERS";
            DataTable dt = db.Search(qry);
            if (dt != null)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }

        }
    }
    }
