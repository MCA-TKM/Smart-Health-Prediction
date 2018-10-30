using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class breast_cancer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string fname=Session["id"].ToString()+"_testfile_bc.csv";
        StreamWriter sw = new StreamWriter("d:\\" + fname);
        sw.WriteLine("age,menopause,tumorsize,inv-nodes,node-caps,deg-malig,breast,breast-quad,irradiat");
        sw.WriteLine("'"+ age.Text +"','"+ meno.Text +"','"+ tumorsize.Text +"','"+inv.Text+"','"+nodec.Text+"','"+deg.Text+"','"+breast.Text+"','"+breastq.Text+"','"+irradiat.Text+"'");
        sw.Close();




    }
}