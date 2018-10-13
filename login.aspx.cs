using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class login : System.Web.UI.Page
{
    Connection dbc = new Connection();
    string sq = "";
    SqlDataReader rd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void _imgAdmin_Click(object sender, ImageClickEventArgs e)
    {
        Session["utype"] = "admin";
        Label1.Text = "Welcome Admin !!!";

    }
    protected void _btnLogin_Click(object sender, EventArgs e)
    {
        if (Session["utype"].ToString() == "admin")
        {

            sq = "select * from login where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'and utype='admin'" ;
            rd = dbc.dbSelect(sq);
            if (rd.HasRows == true)
            {
                rd.Close();
                Response.Redirect("AdminHome.aspx");


            }
            else
            {
                Response.Write("<html><script>alert('invalid username or password');</script></html>");

                rd.Close();


            }

        }
            if (Session["utype"].ToString() == "patient")
            {

                sq = "select * from login where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "' and utype='patient'";
                rd = dbc.dbSelect(sq);
                if (rd.HasRows == true)
                {

                    rd.Read(); ;
                    string patid = rd["id"].ToString();
                    Session["uname"] = TextBox1.Text;
                    Session["id"] = patid;
                    rd.Close();
                    Response.Redirect("patienthome.aspx");


                }
                else
                {
                    Response.Write("<html><script>alert('invalid username or password');</script></html>");
                   
                    //message

                    rd.Close();


                }

            }


            
            if (Session["utype"].ToString() == "hospital")
            {

                sq = "select * from login where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "' and utype='hospital' and id in ( select hspid from hospitalreg where status='Y')";
                rd = dbc.dbSelect(sq);
                if (rd.HasRows == true)
                {


                    rd.Close();
            Response.Redirect("hospitalhome.aspx");


                }
                else
                {
                    Response.Write("<html><script>alert('invalid username or password');</script></html>");

                    rd.Close();


                }




            




        }
    }
    protected void img_patient_click(object sender, ImageClickEventArgs e)
    {
        Session["utype"] = "patient";
        Label1.Text = "Welcome user!!!";

    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Session["utype"] = "hospital";
        Label1.Text = "Welcome user!!!";

    }
    
}
