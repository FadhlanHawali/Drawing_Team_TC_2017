using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Team_TC_Label
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string temp;
            string[] name = new string[10];
            name[0] = "Absent";
            name[1] = "Amikom112";
            name[2] = "Furqon Team";
            name[3] = "Invose Alfa";
            name[4] = "Tahu Telor Team";
            name[5] = "The Three Newbie";
            name[6] = "Titan Tech";
            name[7] = "Black Jack";
            name[8] = "Dear Raisa";
            name[9] = "Slice Pro";


            this.label1.Text = name[0];
            this.label2.Text = name[1];
            this.label3.Text = name[2];
            this.label4.Text = name[3];
            this.label5.Text = name[4];
            this.label6.Text = name[5];
            this.label7.Text = name[6];
            this.label8.Text = name[7];
            this.label9.Text = name[8];
            this.label10.Text = name[9];
           
            Random rand = new Random();
            for (int i = 0; i < name.Length - 1; i++)
            {
                int j = rand.Next(i, name.Length);
                temp = name[i];
                name[i] = name[j];
                name[j] = temp;
            }
            this.label1.Text = name[0];
            this.label2.Text = name[1];
            this.label3.Text = name[2];
            this.label4.Text = name[3];
            this.label5.Text = name[4];
            this.label6.Text = name[5];
            this.label7.Text = name[6];
            this.label8.Text = name[7];
            this.label9.Text = name[8];
            this.label10.Text = name[9];
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
