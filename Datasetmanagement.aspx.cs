using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;

public partial class Datasetmanagement : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    Connection cn = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string path = Server.MapPath(".") + "\\datasets\\";
        //Directory.CreateDirectory(path);
        string fname = FileUpload1.FileName;
        string ext = fname.Substring(fname.Length - 3, 3);
        if (ext == "csv")
        {
           // FileUpload1.SaveAs(path + "\\" + FileUpload1.FileName); 
            FileUpload1.SaveAs(path + FileUpload1.FileName);

        }



        string fname1 =path+ FileUpload1.FileName;
        StreamReader sr = new StreamReader(fname1);
        string line = "";
        DataTable dt = new DataTable();
        string sq = "";
        line = sr.ReadLine();
        string[] parts = line.Split(',');
        int ct = parts.Length;
        sq = "drop table " + selectdiease.Text;
        cn.dbInsert(sq);

        sq = "create table " + selectdiease.Text + "(";
        string ss = "";
        for (int i = 0; i < ct; i++)
        {
            dt.Columns.Add(parts[i], typeof(string));
            if (ss == "")
            {
                ss="["+parts[i] +"] nvarchar(50)";

            }
            else
            {
                ss=ss+",["+parts[i] +"] nvarchar(50)";

            }
        }

       sq = sq + ss + ")";
        cn.dbInsert(sq);


        sq = "delete from [" + selectdiease.Text + "]";
        cn.dbInsert(sq);
      
        while ((line = sr.ReadLine()) != null)
        {
sq = "insert into [" + selectdiease.Text + "] values(";
       
            parts = line.Split(',');
  ss = "";
            DataRow dr = dt.NewRow();
            for (int k = 0; k < parts.Length; k++)
            {
                dr[k] = parts[k];

                if (ss == "")
                {

                    ss = "'" + parts[k] + "'";

                }
                else
                {

                    ss = ss + ",'" + parts[k] + "'";

                }
            }

           sq = sq + ss + ")";

             cn.dbInsert (sq);
            dt.Rows.Add(dr);

            sq = "";
        }
 
        sr.Close();


        GridView1.DataSource = dt;
        GridView1.DataBind();



    }
}