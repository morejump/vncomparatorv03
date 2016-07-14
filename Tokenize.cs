using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DevExpress.XtraWaitForm;

namespace vnComparatorV03
{
    public partial class Tokenize : Form
    {
        private  string relativePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        private string processedString01, processedString02;
        private DocumentCollection docCollection;
        private ProcessStartInfo processInfo;   // ProcessStartInfo
        private Process process;    // process
        private string Commamd;
        private XmlDocument xmlDocument;
        private XmlNodeList nodeList;
        private int countNode;
        public Tokenize()
        {
            
            InitializeComponent();
            docCollection = new DocumentCollection() { DocumentList = new List<string>() };// initializing DocumentCollection to get two setences
        }
        private void btnCompare_Click(object sender, EventArgs e)
        {
            // get value of sentences----> here
            if (!string.IsNullOrEmpty(txtFirst.Text) && !string.IsNullOrEmpty(txtSencond.Text))
            {
                if (docCollection.DocumentList.Count!=0)
                {
                    docCollection.DocumentList.Clear();
                }
                progressPanel01.Visible = true;
                //progressPanel.Visible = true;
                // writing two setences to two responring file
                System.IO.File.WriteAllText(relativePath+"\\vn.hus.nlp.tagger-4.2.0-bin\\inputFirstSentence.txt", txtFirst.Text);
                System.IO.File.WriteAllText(relativePath+ "\\vn.hus.nlp.tagger-4.2.0-bin\\inputSecondSentence.txt", txtSencond.Text);
                xmlDocument = new XmlDocument();
                // processing two sentences
                // the first sentence
                Commamd = "vnTagger.bat -i inputFirstSentence.txt -o outputFirstSentence.txt -u";    // command
                processInfo = new ProcessStartInfo("cmd.exe", "/c " + Commamd);     // initialize 
                processInfo.WorkingDirectory = relativePath + "\\vn.hus.nlp.tagger-4.2.0-bin";
                processInfo.UseShellExecute = false;
                processInfo.CreateNoWindow = true;
                process = Process.Start(processInfo);
                process.WaitForExit();
                //----
                xmlDocument.Load(relativePath + "\\vn.hus.nlp.tagger-4.2.0-bin\\outputFirstSentence.txt");
                nodeList = xmlDocument.GetElementsByTagName("w");
                countNode = nodeList.Count;
                for (int i = 0; i < countNode; i++)
                {
                    if (!InvalidChacracterHandler.isInvalidChar(nodeList[i].InnerText) && !StopWordsHandler.IsStotpWord(nodeList[i].InnerText))
                    {
                        processedString01 += nodeList[i].InnerText + " ";
                    }
                    else
                    {
                        continue;
                    }
                }
                txtFirst.Text = processedString01;
                // the second sentence
                Commamd = "vnTagger.bat -i inputSecondSentence.txt -o outputSecondSentence.txt -u";    // command
                processInfo = new ProcessStartInfo("cmd.exe", "/c " + Commamd);     // initialize 
                processInfo.WorkingDirectory = relativePath + "\\vn.hus.nlp.tagger-4.2.0-bin";
                processInfo.UseShellExecute = false;
                processInfo.CreateNoWindow = true;
                process = Process.Start(processInfo);
                process.WaitForExit();
                //-----
                xmlDocument.Load(relativePath + "\\vn.hus.nlp.tagger-4.2.0-bin\\outputSecondSentence.txt");
                nodeList = xmlDocument.GetElementsByTagName("w");
                countNode = nodeList.Count;
                for (int i = 0; i < countNode; i++)
                {
                    if (!InvalidChacracterHandler.isInvalidChar(nodeList[i].InnerText) && !StopWordsHandler.IsStotpWord(nodeList[i].InnerText))
                    {
                        processedString02 += nodeList[i].InnerText + " ";
                    }
                    else
                    {
                        continue;
                    }
                }
                txtSencond.Text = processedString02;
                docCollection.DocumentList.Add(processedString01);
                docCollection.DocumentList.Add(processedString02);
                //---------
                Console.WriteLine("so chuoi thu duoc la: {0}", docCollection.DocumentList.Count);
                List<DocumentVector> vSpace = VectorSpaceModel.ProcessDocumentCollection(docCollection);
                float similarity = SimilarityMatrics.FindCosineSimilarity(vSpace[0].VectorSpace, vSpace[1].VectorSpace);
                lblSimilarity.Text = similarity.ToString();
                progressPanel01.Visible = false;
                // these the flowing states just used to display console
                Console.WriteLine("vecto thu nhat");
                foreach (var a in vSpace[0].VectorSpace)
                {
                    Console.Write("{0}  ", a);
                }
                Console.WriteLine("\nvecto thu hai");
                foreach (var a in vSpace[1].VectorSpace)
                {
                    Console.Write("{0}   ", a);
                }
                Console.WriteLine("\ncac cau vua nhap vao la");
                foreach (var doc in docCollection.DocumentList)
                {
                    Console.WriteLine(doc);
                }
                //   progressPanel.Visible = false;

            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ các câu nhé!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            docCollection.DocumentList.Clear();
            txtFirst.Text = "";
            txtSencond.Text = "";
            processedString01 = "";
            processedString02 = "";
        }

       
        private void Tokenize_Load(object sender, EventArgs e)
        {
           progressPanel01.Visible = false;
        }

        

        
        

        

        

        

        

        
    }
}
