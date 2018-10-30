using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class diabetis : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string fname = Session["id"].ToString() + "_testfile_bc.csv";
        StreamWriter sw = new StreamWriter("d:\\" + fname);
        sw.WriteLine("No.pregnent,plasma glucose,Bp,Triceps skin fold thickness,Serum insulin  in 2hr,Body mass index,Diabetes pedigree function,Age");
        sw.WriteLine("'" +nop.Text + "','" + plasmag.Text + "','" + bp.Text + "','" + tsf.Text + "','" + si.Text + "','" + bmass.Text + "','" + dpf.Text + "','" + age.Text + "'");
        sw.Close();

    }
}