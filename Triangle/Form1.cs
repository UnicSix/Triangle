using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string inputFile = "TriangleHeight.txt";
            System.IO.StreamReader inputData = new System.IO.StreamReader(inputFile);
            int hei = int.Parse(inputData.ReadLine());
            InitializeComponent();
            for(int i = 1; i<=hei; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    richTextBox1.AppendText(j.ToString());
                }
                richTextBox1.AppendText("\n");
            }
            richTextBox1.Font = new Font("Times New Roman", 15, FontStyle.Regular);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
