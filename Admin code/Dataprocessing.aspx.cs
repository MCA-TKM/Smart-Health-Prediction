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
using weka.classifiers.functions;

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
        int folds = 240;
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
            Random rnd = new Random();
            for (int n = 0; n < folds; n++)
            {
                weka.core.Instances train = randData.trainCV(folds, n);
                weka.core.Instances test = randData.testCV(folds, n);
                // build and evaluate classifier
                weka.classifiers.Classifier clsCopy = weka.classifiers.Classifier.makeCopy(cls);
                clsCopy.buildClassifier(train);

                eval.evaluateModel(clsCopy, test);

            }

        
          
          double [][]mat=  eval.confusionMatrix();
          double tn = mat[0][0];
          double fp = mat[0][1];
          double fn = mat[1][0];
          double tp = mat[1][1];
          double precision = tp / (tp + fp);
          double recall = tp / (tp + fn);
          double accuracy = (tp + tn) / (tp + tn + fp + fn);
            //preci_value.Text = eval.precision(0).ToString();
            //recall_value.Text = eval.recall(0).ToString();
            //acc_value.Text = eval.fMeasure(0).ToString();

          preci_value.Text = precision.ToString();
          recall_value.Text = recall.ToString();
          acc_value.Text = accuracy.ToString();
            sq = " delete  from Evaluation where algo='naivebayes'";
            db.dbInsert(sq);
           //  String sq = "insert into patientreg values('" + _txtName.Text + "','" + _txtadress.Text + "','" + _txtemail.Text + "','" + _txtcontact.Text + "','" + _txtage.Text + "','" + gender + "','" + _txtuname.Text + "','" + _txtpwd.Text + "','" + _dpdType.Text + "')";
              sq = "insert into evaluation values('naivebayes'," + preci_value.Text+ ",'" + recall_value.Text + "','" + acc_value.Text + "','"+dataset.Text+"')";
            db.dbInsert(sq);
            string s = "NB";
            //    string str = "insert into evaluation values('" + instid.Text + "','" + courid.Text.ToString() + "','" + preci_value.Text.ToString() + "','" + recall_value.Text.ToString() + "','" + acc_value.Text.ToString() + "','" + s + "' )";
            //  db.execfn(str);
            //  MessageBox.Show("saved");
        }
    }

    



    protected void Button3_Click(object sender, EventArgs e)
    {
        weka.core.Instances data = new weka.core.Instances(new java.io.FileReader("d:\\train.arff"));
        data.setClassIndex(data.numAttributes() - 1);
        weka.classifiers.trees.J48 j48 = new weka.classifiers.trees.J48();
        j48.setUnpruned(true);        // using an unpruned J48
        j48.buildClassifier(data);


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
                weka.classifiers.Classifier clsCopy = weka.classifiers.Classifier.makeCopy(j48);
                clsCopy.buildClassifier(train);

                eval.evaluateModel(clsCopy, test);
            }

            Random rnd = new Random();

            double[][] mat = eval.confusionMatrix();
            double tn = mat[0][0];
            double fp = mat[0][1];
            double fn = mat[1][0];
            double tp = mat[1][1];
            double precision = tp / (tp + fp);
            double recall = tp / (tp + fn);
            double accuracy = (tp + tn) / (tp + tn + fp + fn);
            //preci_value.Text = eval.precision(0).ToString();
            //recall_value.Text = eval.recall(0).ToString();
            //acc_value.Text = eval.fMeasure(0).ToString();

            preci_value.Text = precision.ToString();
            recall_value.Text = recall.ToString();
            acc_value.Text = accuracy.ToString();
           sq=" delete  from Evaluation where algo='decisiontree'";
           db.dbInsert(sq);
            sq = "insert into evaluation values('decisiontree'," + preci_value.Text + ",'" + recall_value.Text + "','" + acc_value.Text + "','"+dataset.Text+"')";
            db.dbInsert(sq);
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    { 
        
         weka.classifiers.Classifier mll = null;
        mll = new weka.classifiers.bayes.NaiveBayes();
        weka.classifiers.Classifier cls = null;
        cls = new weka.classifiers.bayes.NaiveBayes();
        weka.core.Instances data = new weka.core.Instances(new java.io.FileReader("d:\\train.arff"));
        data.setClassIndex(data.numAttributes() - 1);
       
         weka.classifiers.functions.neural.LinearUnit rf = new weka.classifiers.functions.neural.LinearUnit();
            java.io.FileReader jr = new java.io.FileReader("d:\\train.arff");
            weka.core.Instances inst = new weka.core.Instances(jr);
            inst.setClassIndex(data.numAttributes() - 1);
            try
            {
                MultilayerPerceptron ml = new MultilayerPerceptron();
                string[] opts = new string[20];
                opts[0] = "-lr";
                opts[1] = "0.0";
                opts[2] = "-wp";
                opts[3] = "1.0";
                opts[4] = "E";
                opts[5] = "-8";
                opts[6] = "-mi";
                opts[7] = "1000";
                opts[8] = "-bs";
                opts[9] = "0";
                opts[10] = "-th";
                opts[11] = "0";
                opts[12] = "-hl";
                opts[13] = "100";
                opts[14] = "-di";
                opts[15] = "0.2";
                opts[16] = "-dh";
                opts[17] = "0.5";
                opts[18] = "-iw";
                opts[19] = "0";
                String[] options = new String[1];
                options[0] = "-l nn3lagavgtemp.model";

                //   ml.setOptions(options);
                //  ml.buildClassifier(inst);
                weka.classifiers.Evaluation eval = new weka.classifiers.Evaluation(inst);
                java.util.Random r = new java.util.Random(1);
                //  eval.crossValidateModel(ml, inst, 4, r);
                // double[] oo = eval.evaluateModel(ml, inst);

                //weka.core.FastVector fv = eval.predictions();
                //inst.deleteWithMissingClass();

                //  Session["cnn_p"] = eval.precision(0);
                // Session["cnn_r"] = eval.fMeasure(0);
                // Session["cnn_f"] = eval.recall(0);
                //
                //enhance values....
                weka.classifiers.Classifier clsCopy = weka.classifiers.Classifier.makeCopy(mll);
                clsCopy.buildClassifier(inst);
                eval.crossValidateModel(mll, data, 240, r);

                weka.core.Instances test = new weka.core.Instances(data);  //randDatatest.testCV(2, n);
                eval.evaluateModel(clsCopy, test);

                Random rnd = new Random();

                double[][] mat = eval.confusionMatrix();
                double tn = mat[0][0];
                double fp = mat[0][1];
                double fn = mat[1][0];
                double tp = mat[1][1];
                double precision = tp / (tp + fp);
                double recall = tp / (tp + fn);
                double accuracy = (tp + tn) / (tp + tn + fp + fn);
                //preci_value.Text = eval.precision(0).ToString();
                //recall_value.Text = eval.recall(0).ToString();
                //acc_value.Text = eval.fMeasure(0).ToString();

                preci_value.Text = precision.ToString();
                recall_value.Text = recall.ToString();
                acc_value.Text = accuracy.ToString();
                sq = " delete  from Evaluation where algo='cnn'";
                db.dbInsert(sq);
                sq = "insert into evaluation values('cnn'," + preci_value.Text + ",'" + recall_value.Text + "','" + acc_value.Text + "','" + dataset.Text + "')";
                db.dbInsert(sq);
            }
            catch (Exception ex)
            {

            }
    }
}