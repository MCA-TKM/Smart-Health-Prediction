using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using weka;
using weka.classifiers.evaluation;
using System.IO;


public partial class Dataprocessing : System.Web.UI.Page
{
    Connection db = new Connection();
    string sq = "";
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        try
        {
            string path = Server.MapPath(".") + "\\datasets\\" + dataset.Text + ".csv";
            string fname = path;
            File.Delete("d:\\train.arff");
            weka.core.converters.CSVLoader loader = new weka.core.converters.CSVLoader();
            loader.setSource(new java.io.File(fname));
            weka.core.Instances inst2 = loader.getDataSet();
            weka.core.converters.ArffSaver saver = new weka.core.converters.ArffSaver();
            saver.setInstances(inst2);
            saver.setFile(new java.io.File("d:\\train.arff"));
            saver.writeBatch();
            // Response.Write("<html><script>alert('File Converted..');</script></html>");
        }
        catch (Exception ex)
        {
            /// Response.Write("<html><script>alert('" + ex.Message.ToString() + "');</script></html>");
        }


        // weka.core.Instances data = new weka.core.Instances(new java.io.FileReader("d:\\train.arff"));
        // data.setClassIndex(data.numAttributes() - 1);
        // weka.classifiers.Classifier cls = new weka.classifiers.bayes.NaiveBayes();
        //// weka.classifiers.functions.supportVector.SMOset(); 
        // int runs = 1;
        // int folds = 10;
        // //string sq = "delete from nbresults";
        // //dbc.execfn(sq);
        // // perform cross-validation
        // for (int i = 0; i < runs; i++)
        // {
        //     // randomize data
        //     int seed = i + 1;
        //     java.util.Random rand = new java.util.Random(seed);
        //     weka.core.Instances randData = new weka.core.Instances(data);
        //     randData.randomize(rand);
        //     if (randData.classAttribute().isNominal())
        //         randData.stratify(folds);
        //     weka.classifiers.Evaluation eval = new weka.classifiers.Evaluation(randData);
        //     for (int n = 0; n < folds; n++)
        //     {
        //         weka.core.Instances train = randData.trainCV(folds, n);
        //         weka.core.Instances test = randData.testCV(folds, n);
        //         // build and evaluate classifier
        //         weka.classifiers.Classifier clsCopy = weka.classifiers.Classifier.makeCopy(cls);
        //         clsCopy.buildClassifier(train);

        //         eval.evaluateModel(clsCopy, test);
        //     }

        //     preci_value.Text = eval.precision(0).ToString();
        //     recall_value.Text = eval.recall(0).ToString();
        //     acc_value.Text = eval.fMeasure(0).ToString();

        //     string s = "NB";
        //     string str = "insert into evaluation values('" + instid.Text + "','" + courid.Text.ToString() + "','" + preci_value.Text.ToString() + "','" + recall_value.Text.ToString() + "','" + acc_value.Text.ToString() + "','"+ s+ "' )";
        //     dbc.execfn(str);
        //     MessageBox.Show("saved");

        //  }
        //  }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        sq = "select * from " + dataset.Text + "";
        db.dbSelect(sq);
        ds = db.fillfn(sq);
        GridView1.DataSource = ds.Tables["t1"];
        GridView1.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        weka.core.Instances data = new weka.core.Instances(new java.io.FileReader("d:\\train.arff"));
        data.setClassIndex(data.numAttributes() - 1);
        weka.classifiers.Classifier cls = new weka.classifiers.bayes.NaiveBayes();
        // weka.classifiers.functions.supportVector.SMOset(); 
        int runs = 1;
        int folds = 10;
        //string sq = "delete from nbresults";
        //dbc.execfn(sq);
        // perform cross-validation
        for (int i = 0; i < runs; i++)
        {
            // randomize data
            int seed = i + 1;
            java.util.Random rand = new java.util.Random(seed);
            weka.core.Instances randData = new weka.core.Instances(data);
            randData.randomize(rand);
            if (randData.classAttribute().isNominal())
                randData.stratify(folds);
           // weka.classifiers.trees.j48 jj;
            weka.classifiers.Evaluation eval = new weka.classifiers.Evaluation(randData);
            for (int n = 0; n < folds; n++)
            {
                weka.core.Instances train = randData.trainCV(folds, n);
                weka.core.Instances test = randData.testCV(folds, n);
                // build and evaluate classifier
                weka.classifiers.Classifier clsCopy = weka.classifiers.Classifier.makeCopy(cls);
                clsCopy.buildClassifier(train);

                eval.evaluateModel(clsCopy, test);
            }

           preci_value.Text = eval.precision(0).ToString();
          recall_value.Text = eval.recall(0).ToString();
           acc_value.Text = eval.fMeasure(0).ToString();

            string s = "NB";
        //    string str = "insert into evaluation values('" + instid.Text + "','" + courid.Text.ToString() + "','" + preci_value.Text.ToString() + "','" + recall_value.Text.ToString() + "','" + acc_value.Text.ToString() + "','" + s + "' )";
          //  db.execfn(str);
          //  MessageBox.Show("saved");
        }
    }

    
    

    
}