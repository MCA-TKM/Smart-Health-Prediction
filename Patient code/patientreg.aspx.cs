using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class patientreg : System.Web.UI.Page
{  SqlDataReader rd;
    Connection db=new Connection();
     string[] s;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string gender = "";
        if (RadioButton1.Checked == true)
        {
            gender = "M";

        }
        else
        {

            gender = "F";
        }

        String sel = "select * from patientreg where username='" + _txtuname.Text + "'";
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
            String sq = "insert into patientreg values('" + _txtName.Text + "','" + _txtadress.Text + "','" + _txtemail.Text + "','" + _txtcontact.Text + "','" + _txtage.Text + "','" + gender + "','" + _txtuname.Text + "','" + _txtpwd.Text + "','" + _dpdType.Text + "')";
            //cmd = new SqlCommand(sq, cm);
            //cmd.ExecuteNonQuery();
            db.dbInsert(sq);

            sq = "select max(patientid) from patientreg";
            int regid = db.sclarfn(sq);

            String sd = "insert into login values('" + _txtuname.Text + "','" + _txtpwd.Text + "','" + _dpdType.Text + "'," + regid + ")";
            db.dbInsert(sd);
          

        }

    }
    protected void _dpdType_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
