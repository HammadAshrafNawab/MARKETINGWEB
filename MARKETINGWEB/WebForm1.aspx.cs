using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MARKETINGWEB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DbCon db = new DbCon();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            string qry = "INSERT into PRODUCTS (NAME,DESCRIPTION,PRICE,COST,SALES_PRICE,TAX) values ('" + txtname.Text + "' , '" + txtdescription.Text + "','" + txtprice.Text + "','" + txtcost.Text + "','" + txtsales.Text + "','" + txttax.Text + "')";
            if (db.UDI(qry))
            {
                Label1.Text = "data inserted";
            }
            else
            {
                Label1.Text = " not data inserted";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string qry = "select * from PRODUCTS where ID='" + txtid.Text + "' ";
            DataTable dt = db.Search(qry);
            if (dt != null)
            {
                txtname.Text = dt.Rows[0]["NAME"].ToString();
                txtdescription.Text = dt.Rows[0]["DESCRIPTION"].ToString();
                txtprice.Text = dt.Rows[0]["PRICE"].ToString();
                txtcost.Text = dt.Rows[0]["COST"].ToString();
                txtsales.Text = dt.Rows[0]["SALES_PRICE"].ToString();
                txttax.Text = dt.Rows[0]["TAX"].ToString();
            }
        }
        private void LoadGridView()
        {
            string qry = "select * from  PRODUCTS";
            DataTable dt = db.Search(qry);
            if (dt != null)
            {
               GridView1.DataSource = dt;
               GridView1.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string qry = "update  PRODUCTS set NAME='" + txtname.Text + "', DESCRIPTION='" +txtdescription.Text +"', PRICE = '"+txtprice.Text + "', COST ='" + txtcost.Text + "', SALES_PRICE = '"+ txtsales.Text +"', TAX ='" + txttax.Text + "' where ID='"+txtid.Text+"' ";
            if (db.UDI(qry))
            {
                Label1.Text = "data updated";
            }
            else
            {
                Label1.Text = " not data updated";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }
    }
}