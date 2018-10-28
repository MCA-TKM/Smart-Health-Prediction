using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for Connection
/// </summary>

public class Connection
{
    SqlConnection cn;
    SqlCommand cmd;
    SqlDataReader rd;
    DataSet ds = new DataSet();
    public Connection()
    {
        //
        // TODO: Add constructor logic here
        //
        cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\user\Documents\Healthprediction.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;MultipleActiveResultsets=True");
        cn.Open();
    }
    public int dbInsert(String query)
    {


        try
        {
            cmd = new SqlCommand(query, cn);
            int t = cmd.ExecuteNonQuery();
            return t;
        }
        catch (Exception ex)
        {
            return (0);
        }
    }
    public SqlDataReader dbSelect(String query)
    {
        cmd = new SqlCommand(query, cn);
        rd = cmd.ExecuteReader();
        return rd;

    }
    public DataSet fillfn(string sq)
    {
        SqlDataAdapter ad = new SqlDataAdapter(sq,cn);
        ad.Fill(ds, "t1");
        return (ds);

    }
    public int sclarfn(string sq)
    {

        cmd = new SqlCommand(sq, cn);

        int p = 0;
        try
        {
            p = Convert.ToInt16(cmd.ExecuteScalar());
        }
        catch (Exception ex)
        {
            p = 0;

        }

        return (p);
    }


   // public double  sclarfn(string sq)
   // {

       // cmd = new SqlCommand(sq, cn);

       // double p = 0;
        //try
       // {
           // p = Convert.ToDouble (cmd.ExecuteScalar());
        //}
        //catch (Exception ex)
       // {
           // p = 0;

       // }

        //return (p);
    //}
}