using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace FileSplitter
{
  
    public partial class Form1 : Form
    {
        private string sourceFileExt { get; set; }
        public string sourceFileName { get; set; }
        private int splitFileSize { get; set; }
        public string splitDelimiter { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chkFileSize.Checked == false)
            {
                MessageBox.Show("Please set split file size", "Error");
                return;
            }
            else
            {
                if (!splitfile("C:\\WorkArea\\TestData\\", "C:\\WorkArea\\TestData\\Create_SetUpForlossCostLookUp.sql"))
                {
                    MessageBox.Show("Split Fail", "Error");
                }
                else
                {
                    MessageBox.Show("Done", "Done");
                }
            }

            
           
        }

        private bool splitfile(string detinationDirectory, string sourceFile)
        {
            bool success = false;
            string baseName = detinationDirectory + "\\" +sourceFileName +"_"+ DateTime.Now.ToString("HHmmss") + "_";

            StreamWriter writer = null;
            try
            {
                using (StreamReader inputfile = new System.IO.StreamReader(sourceFile))
                {
                    int count = 0;
                    string line;
                    int fileCount = 0;
                    bool endNow = false;
                    bool lastGo = false;
                    decimal fileSizeMB = 0;
                    string splitFileName = "";
                    while ((line = inputfile.ReadLine()) != null)
                    {


                        if (chkDelimeter.Checked && chkFileSize.Checked) {
                            if (fileSizeMB > splitFileSize && line.ToUpper() == splitDelimiter)
                            {
                                lastGo = true;
                            }
                        }
                        else if (chkDelimeter.Checked==false && chkFileSize.Checked)
                        {
                            if (fileSizeMB > splitFileSize)
                            {
                                lastGo = true;
                            }
                        }


                        if (writer == null || endNow )
                        {
                            if (writer != null)
                            {
                                writer.Close();
                                writer = null;
                                lastGo = false;
                                endNow = false;
                            }
                            splitFileName = baseName + count.ToString() + sourceFileExt;
                            writer = new System.IO.StreamWriter(splitFileName, true);

                            count = 0;
                            fileCount++;
                        }

                        writer.WriteLine(line);

                        if (splitFileName != "")
                        {
                            FileInfo fi = new FileInfo(splitFileName);

                            if (fi.Exists)
                            {
                                // Get file size  
                                decimal size = fi.Length;
                                fileSizeMB = Math.Round((size / 1024)/1000);
                            }
                        }

                        if (lastGo)
                        {
                            endNow = true;
                        }

                        ++count;

                    }
                    success = true;
                }
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
            return success;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xml",
                Filter = "All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSourcePath.Text = openFileDialog1.FileName;
                sourceFileExt = Path.GetExtension(openFileDialog1.FileName);
                sourceFileName = Path.GetFileName(openFileDialog1.FileName).Replace(sourceFileExt, "");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //string[] files = Directory.GetFiles(fbd.SelectedPath);

                    //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                    txtDestination.Text = fbd.SelectedPath;
                }
            }
        }

        private void txtFileSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFileSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chkFileSize_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFileSize.Checked)
            {
                int n;
                bool isNumeric = int.TryParse(txtFileSize.Text, out n);
                if (isNumeric)
                {
                    txtFileSize.Enabled = false;
                    splitFileSize = n;
                }
                else {
                    MessageBox.Show("Please input a number", "Error");
                    txtFileSize.Text = "";
                    chkFileSize.Checked = false;
                }
            }
            else
            {
                txtFileSize.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            splitFileSize = int.Parse( txtFileSize.Text);
            splitDelimiter = txtDelimiter.Text;
        }

        private void chkDelimeter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelimeter.Checked)
            {
                txtDelimiter.Enabled = false;
            }
            else
            {
                txtDelimiter.Enabled = true;
            }
        }
    }
}
