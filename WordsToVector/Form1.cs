using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.Design;

namespace WordsToVector
{
    public partial class Form1 : Form
    {
        string sr;
        string processedFile;
        private object _vocabulary;
        Dictionary<string, int> wordFrequencyDictionary;
        List<TrainItem> trainingDataSet;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoudTrainSet_Click(object sender, EventArgs e)
        {
            loadData();

         }
        public enum TokenSource
        {

         }

        private void btnwords2vector_Click(object sender, EventArgs e)

        {
            string st = richTextBox1.Text;
            string[] tokin = st.Split(' ');

            foreach (string textbox in tokin)
            {
                richTextBox1.Text = "";
                richTextBox1.Text += textbox + "\n";
            }
        }

        public  void OpenFile()
        {
            openFileDialog1.Title = "Choose file";
            openFileDialog1.ShowDialog();

        }
        public void loadData()
        {
            OpenFile();
            //StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
            //sr = streamReader.ReadToEnd();
            string textInBox = System.IO.File.ReadAllText(openFileDialog1.FileName);
            processedFile = Regex.Replace(sr, "[^a-zA-Z ]", "");
            richTextBox1.Text = processedFile;
          

        }
       
        public void button1_Click(object sender, EventArgs e)
        {
            multiLine();
        }
        public void multiLine()
        {
            string st = richTextBox1.Text;
            string[] tokin = st.Split(' ');

            foreach (string textbox in tokin)
            {
                richTextBox1.Text = "";
                richTextBox1.Text += textbox + "\n";
            }
        }
    }

   

    
}