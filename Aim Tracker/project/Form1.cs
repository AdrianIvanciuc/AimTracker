using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public static int GameMode;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameMode = 1;
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameMode = 2;
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = Form2.highscore;
        }
    }
}
