using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class patienthome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "Welcome " + Session["uname"].ToString();
       // String p = Session["id"].ToString();

    }
       
   protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("breast_cancer.aspx");
        //String p = Session["id"].ToString();

    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("diabetis.aspx");
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("heart_disease.aspx");
    }
}