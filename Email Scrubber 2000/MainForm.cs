using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

/*
 * Attempt to use a Producer/Consumer Pattern for high performance chunking
 * http://stackoverflow.com/questions/2161895/reading-large-text-files-with-streams-in-c-sharp?lq=1
 * 
 * 
 * Take all files as paths. 
 * Filters should be loaded ASAP, and got into code.
 * Read 1st Line for Categories
 * Headers
 * Process file by reading to the first ','.
 * Grab substring marked by @ symbol to comma.
 * If matches list, white whole line to somewhere.
 * Write to a temporary output file. //string fileName = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".aed";//(atomic email data file)
 * If doesn't match, write file to output window.
 * Show Processing
 * Use Line count to determine scrub time 
 * var lineCount = File.ReadLines(@"C:\file.txt").Count();
 * Once done, I should have some stuff.
 * 
 * Extensions:
 * Stream in line one of a file. 
 * 
 * 
 */

namespace Email_Scrubber_2000
{
    public partial class MainForm : Form
    {

        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        Stream myStream = null;
        List<String> whiteList = new List<String>();

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads a text file that contains email leads. Each lead is expected to be on a separate line
        /// and double comma deliminated. Ultimately we should be able to scrub data 
        /// </summary>
        /// <param name="sampleLine"></param>
        private void BtnLoadEmailList_Click(object sender, EventArgs e)
        {
            /*
            using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
            using (BufferedStream bs = new BufferedStream(fs);
            using (StreamReader sr = new StreamReader(bs));
            */
            LoadDataList();
            
        }//of BtnLoadEmailList_Click()

        //Grabs a local file for handling settings. All this will really house is the last path 
        private void LoadApplicationSettings()
        {



        }

        private void LoadDataList()
        {
            
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = ""; //Todo, grab last location from settings file if exists.
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 3;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Grabs Name without extension
                //String listPath = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                //String directoryPath = Path. //GetDirectoryName(openFileDialog1);

                //Grab name with extension
                String emailListName = openFileDialog1.SafeFileName;

                ListNameLabel.Text = emailListName;
                //If we got something potentially legit, start the worker.

            }

        }//of LoadDataList()


        private void BtnScrub_Click(object sender, EventArgs e)
        {
            bool keepLine = false;

            try
            {

                openFileDialog1.InitialDirectory = ""; //Todo, grab last location from settings file if exists.
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 3;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (StreamReader reader = new StreamReader(myStream))//myStream)
                        using (StreamWriter writer = new StreamWriter("scrubbed.txt", false))
                        {
                            //Email,F Name,L Name,Address,City,State,Zip,Phone Number,Source,IP,Date and Time,Gender,DOB
                            
                            String workingLine = "";

                            if (!reader.EndOfStream)
                                writer.WriteLine(reader.ReadLine()); //throw away the first line of the file. This is a hack, but I don't want this check in the loop.

                            while (!reader.EndOfStream)
                            {
                                workingLine = reader.ReadLine();

                                foreach (String domain in whiteList) //loops through all domains we have in the whitelist
                                {
                                    if (workingLine.IndexOf(domain) != -1)
                                        keepLine = true;
                                }

                                if (keepLine)
                                {
                                    writer.WriteLine(workingLine);
                                    keepLine = false;
                                } 
                                else
                                {
                                    int start = workingLine.IndexOf('@');
                                    int end = workingLine.IndexOf(",");

                                    String rejectedDomain = workingLine.Substring(start, end - start);
                                    //Find the domain and add it to the ScrubList


                                    if (ScrubListBox.FindString(rejectedDomain) == -1) ;
                                    {
                                        ScrubListBox.Items.Add(rejectedDomain);
                                        String count = Convert.ToString(ScrubListBox.Items.Count);
                                        DomainScrubCount.Text = count;
                                    } 

                                    //Add full line for review to RawListBox
                                    RawListBox.Items.Add(workingLine);
                                    RawListBoxCount.Text = Convert.ToString(RawListBox.Items.Count);
                                }

                            }//of while
                        }
                    }//if
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }//of BtnScrub_Click()

        private void BtnLoadWhiteList_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog2 = new OpenFileDialog();

            openFileDialog2.InitialDirectory = ""; //Todo, grab last location from settings file if exists.
            openFileDialog2.Filter = "Atomic Email Filter (*.aef)|*.aef|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog2.FilterIndex = 3;
            openFileDialog2.RestoreDirectory = true;

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                //Grabs Name without extension
                //String listPath = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                //String directoryPath = Path. //GetDirectoryName(openFileDialog1);

                //Grab name with extension
                String whiteListName = openFileDialog2.SafeFileName;

                WhiteListFileName.Text = whiteListName;
                //If we got something potentially legit, start the worker.
            }

            try
            {
                if ((myStream = openFileDialog2.OpenFile()) != null)
                {

                    using (StreamReader reader = new StreamReader(myStream))
                    {
                        String temp = "";
                        while (!reader.EndOfStream)
                        {
                            temp = reader.ReadLine();

                            whiteList.Add(temp);
                            WhiteListBox.Items.Add(temp);
                        }
                    }
                }

                WhiteListDomainCount.Text = Convert.ToString(WhiteListBox.Items.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }

        }//of BtnLoadWhiteList()



    }//of Class/Form

}//of Email_Scrubber_2000
