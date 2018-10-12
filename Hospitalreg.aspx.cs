using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Hospitalreg : System.Web.UI.Page
{
    SqlDataReader rd;
    Connection db = new Connection();
    string[] s;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        String sel = "select * from hospitalreg where username='" + _txtuname.Text + "'";
        //cmd = new SqlCommand(sq, cm);
        rd = db.dbSelect(sel);
        if (rd.HasRows == true)
        {
            rd.Close();
            Response.Write("<html><script>alert('duplication');</script></html>");


        }
        else
        {
            rd.Close();
            String sq = "insert into hospitalreg values('" + _txtName.Text + "','" + _txtadress.Text + "','" + _txtemail.Text + "','" + _txtcontact.Text + "','" + _dpdType.Text + "','" + _txtuname.Text + "','" + _txtpwd.Text + "','N')";
            //cmd = new SqlCommand(sq, cm);
            //cmd.ExecuteNonQuery();
            db.dbInsert(sq);


            sq = "select max(hspid) from hospitalreg";
            int hspid = db.sclarfn(sq);

            String sd = "insert into login values('" + _txtuname.Text + "','" + _txtpwd.Text + "','" + _dpdType.Text + "',"+hspid +")";
            db.dbInsert(sd);

        }
    }

}
