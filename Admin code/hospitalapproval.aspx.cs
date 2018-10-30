using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class hospitalapproval : System.Web.UI.Page
{
    Connection db = new Connection();
    string sq = "";
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {

        loaddata();
    }

    void loaddata()
    {

sq = "select * from hospitalreg where status='N'";
        ds = db.fillfn(sq);
        GridView1.DataSource = ds.Tables["t1"];
        GridView1.DataBind();

    }
    protected void _btnAprove_Click(object sender, EventArgs e)
    {
      Button bt=(Button)  sender;
     TableCell tc=(TableCell) bt.Parent;
     GridViewRow gr = (GridViewRow)tc.Parent;

     string hid = gr.Cells[1].Text;
     sq = "update hospitalreg set status='Y' where hspid=" + hid;
     db.dbInsert(sq);
     GridView1.DataBind();
     loaddata();
    }

  
    /*protected void _btnReject_Click(object sender, EventArgs e)
    {
        Button bt = (Button)sender;
        TableCell tc = (TableCell)bt.Parent;
        GridViewRow gr = (GridViewRow)tc.Parent;

        string hid = gr.Cells[1].Text;
        sq = "delete from hospitalreg where hspid=" + hid;
        db.dbInsert(sq);
        GridView1.DataBind();
        loaddata();
    }*/
    protected void _btnReject_Click1(object sender, EventArgs e)
    {
        Button bt = (Button)sender;
        TableCell tc = (TableCell)bt.Parent;
        GridViewRow gr = (GridViewRow)tc.Parent;

        string hid = gr.Cells[1].Text;
        sq = "delete from hospitalreg where hspid=" + hid;
        db.dbInsert(sq);
        GridView1.DataBind();
        loaddata();
    }
    
}