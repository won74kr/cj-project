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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.buttons[0] = CopySymbolButton1;
            Program.buttons[1] = CopySymbolButton2;
            Program.buttons[2] = CopySymbolButton3;
            Program.buttons[3] = CopySymbolButton4;
            Program.buttons[4] = CopySymbolButton5;
            Program.buttons[5] = CopySymbolButton6;
            Program.buttons[6] = CopySymbolButton7;
            Program.buttons[7] = CopySymbolButton8;
            Program.buttons[8] = CopySymbolButton9;
            Program.buttons[9] = CopySymbolButton10;
            Program.toolTip = toolTip1;

            Program.LoadResXFile();
            Program.ReflectButtonText("");
        }


        private void suchButtom_Click(object sender, EventArgs e)
        {
            Program.ReflectButtonText(textBox1.Text);
        }

        private void getoutbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CopySymbolButton1_Click(object sender, EventArgs e) => Program.SetKey(0);
        private void CopySymbolButton2_Click(object sender, EventArgs e) =>  Program.SetKey(1);
        private void CopySymbolButton3_Click(object sender, EventArgs e) => Program.SetKey(2);
        private void CopySymbolButton4_Click(object sender, EventArgs e) => Program.SetKey(3);
        private void CopySymbolButton5_Click(object sender, EventArgs e) => Program.SetKey(4);
        private void CopySymbolButton6_Click(object sender, EventArgs e) => Program.SetKey(5);
        private void CopySymbolButton7_Click(object sender, EventArgs e) => Program.SetKey(6);
        private void CopySymbolButton8_Click(object sender, EventArgs e) => Program.SetKey(7);
        private void CopySymbolButton9_Click(object sender, EventArgs e) => Program.SetKey(8);
        private void CopySymbolButton10_Click(object sender, EventArgs e) => Program.SetKey(9);
    }
}
