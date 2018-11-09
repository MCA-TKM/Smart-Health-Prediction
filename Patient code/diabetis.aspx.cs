using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using weka.classifiers.evaluation;
public partial class diabetis : System.Web.UI.Page
{


    string sq = "";
    Connection db = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       // Session["id"] = "9";

        string fname = Session["id"].ToString() + "_testfile_bc.csv";
        StreamWriter sw = new StreamWriter("d:\\" + fname);
        sw.WriteLine("No.pregnent,plasma glucose,Bp,Triceps skin fold thickness,Serum insulin  in 2hr,Body mass index,Diabetes pedigree function,Age,class ");
        sw.WriteLine("'" + nop.Text + "','" + plasmag.Text + "','" + bp.Text + "','" + tsf.Text + "','" + si.Text + "','" + bmass.Text + "','" + dpf.Text + "','" + age.Text + "','T'");
        sw.WriteLine("'" + nop.Text + "','" + plasmag.Text + "','" + bp.Text + "','" + tsf.Text + "','" + si.Text + "','" + bmass.Text + "','" + dpf.Text + "','" + age.Text + "','F'");
        sw.Close();
        try
        {
            string path = "d:\\" + fname;
            string fname1 = path;
            File.Delete("d:\\test.arff");
            weka.core.converters.CSVLoader loader = new weka.core.converters.CSVLoader();
            loader.setSource(new java.io.File(fname1));
            weka.core.Instances inst2 = loader.getDataSet();
            weka.core.converters.ArffSaver saver = new weka.core.converters.ArffSaver();
            saver.setInstances(inst2);
            saver.setFile(new java.io.File("d:\\test.arff"));

            saver.writeBatch();

            // Response.Write("<html><script>alert('File Converted..');</script></html>");
        }
        catch (Exception ex)
        {
            /// Response.Write("<html><script>alert('" + ex.Message.ToString() + "');</script></html>");
        }

        //predicting the results


        sq = "delete  from nbresults";
        db.dbInsert(sq);
        weka.core.Instances data = new weka.core.Instances(new java.io.FileReader("d:\\train.arff"));
        data.setClassIndex(data.numAttributes() - 1);



        weka.core.Instances testdata = new weka.core.Instances(new java.io.FileReader("d:\\test.arff"));
        testdata.setClassIndex(testdata.numAttributes() - 1);

        string str= selectmethod.Text ;
        if (str.ToString() == "Method1")
        {
        weka.classifiers.Classifier cls=null ;
       
        
            cls = new weka.classifiers.bayes.NaiveBayes();

            int runs = 1;
            int folds = 10;
            for (int i = 0; i < runs; i++)
            {
                // randomize data
                int seed = i + 1;
                java.util.Random rand = new java.util.Random(seed);
                weka.core.Instances randData = new weka.core.Instances(data);
                weka.core.Instances randDatatest = new weka.core.Instances(testdata);

                randData.randomize(rand);
                if (randData.classAttribute().isNominal())
                    randData.stratify(folds);
                // weka.classifiers.trees.j48 jj
                double label = 0;
                weka.classifiers.Evaluation eval = new weka.classifiers.Evaluation(randData);
                for (int n = 0; n < folds; n++)
                {

                    weka.core.Instances train = randData.trainCV(folds, n);
                    weka.core.Instances test = new weka.core.Instances(testdata);  //randDatatest.testCV(2, n);
                    // build and evaluate classifier
                    weka.classifiers.Classifier clsCopy = weka.classifiers.Classifier.makeCopy(cls);
                    clsCopy.buildClassifier(train);

                    eval.evaluateModel(clsCopy, test);

                    label = clsCopy.classifyInstance(test.instance(0));
                    test.instance(0).setClassValue(label);
                    string pp = test.instance(0).value(8).ToString(); ;
                    for (int k = 0; k < test.numInstances(); k++)
                    {
                        double pred = clsCopy.classifyInstance(test.instance(0));
                        test.instance(i).setClassValue(pred);
                        if (pred == 1)
                        {
                            //    Response.Write("<html><script>alert('got one s');</script></html>");


                        }
                    }

                    //   string s=  test.classAttribute().value((int) pred);
                }



                int p = 0;
                int loopvt = 0;
                foreach (object o in eval.predictions().toArray())
                {
                    Random rnd = new Random();
                    NominalPrediction prediction = o as NominalPrediction;
                    int nominal = rnd.Next(0, 1);
                    if (prediction != null)
                    {
                        double act = prediction.actual();
                        double pred = prediction.predicted();
                        double[] distribution = prediction.distribution();

                        p = (int)pred;

                        string s = "";
                        if (p == 1)
                        {
                            s = "Y";

                        }
                        else
                        {
                            s = "N";

                        }


                        sq = "insert into nbresults values(" + loopvt + ",'" + s + "')";
                        db.dbInsert(sq);
                        loopvt++;
                    }
                }


                sq = "select count(class) from nbresults where class='Y'";
                int yc = db.sclarfn(sq);

                sq = "select count(class) from nbresults where class='N'";
                int nc = db.sclarfn(sq);
                if (yc < nc)
                {
                    Panel1.BackColor = System.Drawing.Color.Red;
                    Response.Write("<html><script>alert('Sorry.... you have traces of Diabetis');</script></html>");

                }
                else
                {
                    Panel1.BackColor = System.Drawing.Color.Green;
                    Response.Write("<html><script>alert('No Diabetis found...');</script></html>");

                }


                //   weka.core.Instance cind = test.instance(i);
                //   double pred = ml.classifyInstance(cind);


                //   preci_value.Text = eval.precision(0).ToString();
                // recall_value.Text = eval.recall(0).ToString();
                // acc_value.Text = eval.fMeasure(0).ToString();




            }

        }
        if (str.ToString() == "Method2")
        {

            weka.classifiers.trees.J48 j48 = new weka.classifiers.trees.J48();
            j48.setUnpruned(true);        // using an unpruned J48
            j48.buildClassifier(data);


            weka.core.Instances train = data.trainCV(10, 1);
            weka.core.Instances test = new weka.core.Instances(testdata);  //randDatatest.testCV(2, n);
                    
            
           weka.classifiers.Evaluation eval = new weka.classifiers.Evaluation(data);
            weka.classifiers.Classifier clsCopy = weka.classifiers.Classifier.makeCopy(j48);
            clsCopy.buildClassifier( train );
            java.util.Random r = new java.util.Random(1);

            eval.crossValidateModel(j48, data,2, r);
           

            
            //sample test

            
     

            //test end 
            eval.evaluateModel(clsCopy, testdata  );

                int p = 0;
                int loopvt = 0;
                foreach (object o in eval.predictions().toArray())
                {
                    Random rnd = new Random();
                    NominalPrediction prediction = o as NominalPrediction;
                    int nominal = rnd.Next(0, 1);
                    if (prediction != null)
                    {
                        double act = prediction.actual();
                        double pred = prediction.predicted();
                        double[] distribution = prediction.distribution();

                        p = (int)pred;

                        string s = "";
                        if (p == 1)
                        {
                            s = "Y";

                        }
                        else
                        {
                            s = "N";

                        }


                        sq = "insert into nbresults values(" + loopvt + ",'" + s + "')";
                        db.dbInsert(sq);
                        loopvt++;
                    }
                
                }

                sq = "select count(class) from nbresults where class='Y'";
                int yc = db.sclarfn(sq);

                sq = "select count(class) from nbresults where class='N'";
                int nc = db.sclarfn(sq);
                if (yc > nc)
                {
                    Panel1.BackColor = System.Drawing.Color.Red;
                    Response.Write("<html><script>alert('Sorry.... you have traces of Diabetis');</script></html>");

                }
                else
                {
                    Panel1.BackColor = System.Drawing.Color.Green;
                    Response.Write("<html><script>alert('Mo Diabetis found...');</script></html>");

                }

            
        }
            
        
        
        
       
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("patientHome.aspx");
    }
}