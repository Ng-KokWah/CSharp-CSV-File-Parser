using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVParserDGV
{
    public partial class Form1 : Form
    {
        //NOTE: All 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                file1.Text = file;

                if (passed == true && passed2 == true && passed3 == true)
                {
                    String[] csvfilecontents = FileHandling.ReadFromFileEachLine(file);

                    DataTable dtbl2 = new DataTable();

                    String[] header = csvfilecontents[Convert.ToInt16(textBox2.Text)].Split(',');

                    for (int j = 0; j < header.Length - 1; j++)
                    {
                        dtbl2.Columns.Add(header[j]);
                    }

                    for (int i = Convert.ToInt16(textBox1.Text); i < csvfilecontents.Length; i++)
                    {
                        String[] temp = csvfilecontents[i].Split(',');

                        //adds a empty row temporarily into the table to manipulate with in the codes below using the dr
                        DataRow dr = dtbl2.NewRow();

                        if (temp.Length > header.Length)
                        {
                            String[] splitByDoubleQuote = csvfilecontents[i].Split('\"');
                            List<String> concatOddAndEven = new List<string>();

                            for (int num = 0; num < splitByDoubleQuote.Length; num++)
                            {
                                if (num % 2 == 0)
                                {
                                    String removeEmptyCommas = "";
                                    if (splitByDoubleQuote[num].IndexOf(",") == 0)
                                    {
                                        removeEmptyCommas = splitByDoubleQuote[num].Substring(1);
                                        //Console.WriteLine("Starts with comma : " + removeEmptyCommas);
                                        if (splitByDoubleQuote[num].EndsWith(","))
                                        {
                                            removeEmptyCommas = splitByDoubleQuote[num].Substring(1, splitByDoubleQuote[num].Length - 2);
                                        }
                                    }
                                    else
                                    {
                                        removeEmptyCommas = splitByDoubleQuote[num].Substring(0, splitByDoubleQuote[num].Length - 1);
                                        //Console.WriteLine("ends with comma: " + removeEmptyCommas);
                                        if (splitByDoubleQuote[num].IndexOf(",") == 0)
                                        {
                                            removeEmptyCommas = splitByDoubleQuote[num].Substring(1, splitByDoubleQuote[num].Length - 2);
                                        }
                                    }

                                    String[] evenSplitted = removeEmptyCommas.Split(',');

                                    for (int t = 0; t < evenSplitted.Length; t++)
                                    {
                                        concatOddAndEven.Add(evenSplitted[t]);
                                        //Console.WriteLine("These are the proper splitted values: " + evenSplitted[t]);
                                    }
                                    //Console.WriteLine("These are odd numbers " + splitByDoubleQuote[num]);
                                }
                                else
                                {
                                    concatOddAndEven.Add(splitByDoubleQuote[num]);
                                    //Console.WriteLine("These are even numbers " + splitByDoubleQuote[num]);
                                }


                            }
                            for (int l = 0; l < header.Length - 1; l++)
                            {
                                dr[l] = concatOddAndEven[l];
                            }
                            //Console.WriteLine("this is longer than the columns avail " + i);
                        }
                        else
                        {
                            for (int l = 0; l < header.Length - 1; l++)
                            {
                                dr[l] = temp[l];
                            }
                        }

                        //attaches the datarow to the datatable before binding to the datagridview
                        dtbl2.Rows.Add(dr);
                    }

                    //binds the datatable to the datagridview
                    dataGridView1.DataSource = dtbl2;
                }
                else
                {
                    errLabel.Visible = true;
                    errLabel2.Visible = true;
                    errLabelHeader.Visible = true;


                    errLabel.Text = "Numbers only!";
                    errLabel2.Text = "Only CSV Files Allowed!";
                    errLabelHeader.Text = "Numbers Only!";
                }
            }
        }

        private static Boolean passed = false;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String pattern = "^[0-9]+$";
            Regex re = new Regex(pattern);
            if (re.IsMatch(textBox1.Text))
            {
                errLabel.Visible = false;
                passed = true;
            }
            else
            {
                errLabel.Text = "Only numbers are acceptable!";
                errLabel.Visible = true;
                passed = false;
            }
        }

        private static Boolean passed2 = false;
        private void file1_TextChanged(object sender, EventArgs e)
        {
            if (file1.Text.Substring((file1.Text.Length) - 3).ToLower().Equals("csv"))
            {
                errLabel2.Visible = false;
                passed2 = true;
            }
            else
            {
                errLabel2.Visible = true;
                errLabel2.Text = "Only CSV Files are allowed!";
                passed2 = false;
            }
        }

        private static Boolean passed3 = false;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            String pattern = "^[0-9]+$";
            Regex re = new Regex(pattern);
            if (re.IsMatch(textBox1.Text))
            {
                errLabelHeader.Visible = false;
                passed3 = true;
            }
            else
            {
                errLabelHeader.Text = "Only numbers are acceptable!";
                errLabelHeader.Visible = true;
                passed3 = false;
            }
        }
    }
}
