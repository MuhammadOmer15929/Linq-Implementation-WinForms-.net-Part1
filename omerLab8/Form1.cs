using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace omerLab8
{
    public partial class Form1 : Form
    {

      public  string[] stdName = { "Kamran","Ali","Umar","Usama","Asim","Sammer","Ali","Azeem","Salman","Abdullah","FarooqeAzam","Umar","Ahad" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string combine = "";
            var name = from std in stdName select std;

            foreach(string q in name)
            {
                combine = combine + q + "";
            }
            textBox1.Text = combine;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string combine = "";

            var name = from std in stdName where std.StartsWith(textBox2.Text)
                       select std;

            foreach (string q in name)
            {
                combine = combine + q + "";
            }
            textBox3.Text = combine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string combine = "";

            var name = from std in stdName
                       where std.Length<=5
                       select std;

            foreach (string q in name)
            {
                combine = combine + q + "";
            }
            textBox4.Text = combine;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string combine = "";

            var name = from std in stdName
                       where std.Contains(textBox7.Text)
                       select std;

            foreach (string q in name)
            {
                combine = combine + q + "";
            }
            textBox5.Text = combine;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string combine = "";
            string a;
            string b;
            var name = from std in stdName
                 orderby std ascending
                       select std;

            foreach (string q in name)
            {
                combine = combine + q + "";
            }
            textBox6.Text = combine;
        }
    }
}
