using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cj_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Program.buttons[0] = button1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void suchButtom_Click(object sender, EventArgs e)
        {
            Program.SearchStart(textBox1.Text);
        }

        private void getoutbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
