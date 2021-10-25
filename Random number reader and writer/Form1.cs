using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool comeOrGo = false;
            do
            {
                int n = 0, i = 0;
                Random rnd = new Random();
                string nText = textBox1.Text;
                List<int> arlist = new List<int>();
                if(nText != "")
                    n = Convert.ToInt32(nText);
                
                
                for (i = 0; i < n; i++)
                {
                    int num = rnd.Next(100);
                    arlist.Add(num);
                }//end for
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "numb files only plz|*.numb";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = sfd.FileName;
                    StreamWriter bw = new StreamWriter(File.Create(path));
                    foreach (int j in arlist)
                    {
                        bw.Write(j);
                        bw.Write("\n");
                        

                    }//foreach

                    bw.Dispose();
                    comeOrGo = true;
                }//end if
            } while (comeOrGo == false);

            
        }//end button1

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "numb files only plz|*.numb";
            int number = 0,counter = 0,sum = 0;
            List<int> readList = new List<int>();
            String line = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //ofd.ShowDialog();
                StreamReader sr = new StreamReader(ofd.FileName);
                while (line != null)
                {
                    line = sr.ReadLine();
                    number = Convert.ToInt32(line);
                    if(number !=0)
                    {
                        readList.Add(number);
                        counter++;
                        sum = sum + number;
                    }
                    
                }//end while
                listBox1.DataSource = readList;
                label5.Text = counter.ToString();
                label6.Text = sum.ToString();
            }//end if
            



        }//end button 2

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
