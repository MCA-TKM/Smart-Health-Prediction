using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.UI.DataVisualization.Charting;
using System.Data;
public partial class Evaluation : System.Web.UI.Page
{
    string sq = "";
    DataSet ds = new DataSet();
    Connection dbc = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        sq = "select * from evaluation";
        ds = new DataSet();
        ds = dbc.fillfn(sq);

        chart.DataSource = ds.Tables["t1"];
        chart.DataBind();


        chart.Series["Precision"].ChartType = SeriesChartType.Column;
        chart.Series["Precision"].XValueMember = "algo";
        chart.Series["Precision"].YValueMembers = "precision";

        chart.Series["Recall"].ChartType = SeriesChartType.Column;
        chart.Series["Recall"].XValueMember = "algo";
        chart.Series["Recall"].YValueMembers = "recall";

       
        //  chart.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;

        chart.ChartAreas["ChartArea1"].AxisX.Title = "Measure Type";
        chart.ChartAreas["ChartArea1"].AxisY.Title = "Value";


    }
}