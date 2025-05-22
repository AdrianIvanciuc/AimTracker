using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class Form2 : Form
    {
        Random rnd = new Random();
        int CurrentLabel, multiplier, multiplier2, CurrentSize=100, pause=1;
        long difficulty, score;
        public static string highscore;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.GameMode == 1) { multiplier = 8; multiplier2 = 8; difficulty = 16; }
            if (Form1.GameMode == 2) { multiplier = 16; multiplier2 = 16; difficulty = 32; }
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CurrentLabel++;
            if (CurrentLabel == 6) CurrentLabel = 1;
            if (CurrentLabel == 1)
            {
                if (label1.Visible == true) this.Close(); 
                label1.Visible = true;
                int x = rnd.Next(15, 625);
                int y = rnd.Next(15, 600);
                this.label1.Location = new Point(x, y);
            }
            if (CurrentLabel == 2)
            {
                if (label2.Visible == true) this.Close();
                label2.Visible = true;
                int x = rnd.Next(15, 625);
                int y = rnd.Next(15, 600);
                this.label2.Location = new Point(x, y);
            }
            if (CurrentLabel == 3)
            {
                if (label3.Visible == true) this.Close();
                label3.Visible = true;
                int x = rnd.Next(15, 625);
                int y = rnd.Next(15, 600);
                this.label3.Location = new Point(x, y);
            }
            if (CurrentLabel == 4)
            {
                if (label4.Visible == true) this.Close();
                label4.Visible = true;
                int x = rnd.Next(15, 625);
                int y = rnd.Next(15, 600);
                this.label4.Location = new Point(x, y);
            }
            if (CurrentLabel == 5)
            {
                if (label5.Visible == true) this.Close();
                label5.Visible = true;
                int x = rnd.Next(15, 625);
                int y = rnd.Next(15, 600);
                this.label5.Location = new Point(x, y);
            }
            if (score >= difficulty)
            {
                timer1.Interval -= 80;
                difficulty = difficulty * 2;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            score+=multiplier;
            multiplier+=multiplier2;
            highscore = score.ToString();
            Scoreboard.Text = score.ToString();
            label1.Visible = false;
            if (Form1.GameMode == 2) 
            {
                if (CurrentSize > 50) CurrentSize--;
                this.label1.Size = new Size(CurrentSize, CurrentSize); 
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            score += multiplier;
            multiplier+=multiplier2;
            highscore = score.ToString();
            Scoreboard.Text = score.ToString();
            label2.Visible = false;
            if (Form1.GameMode == 2)
            {
                if (CurrentSize > 50) CurrentSize--;
                this.label2.Size = new Size(CurrentSize, CurrentSize);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            score += multiplier;
            multiplier+=multiplier2;
            highscore = score.ToString();
            Scoreboard.Text = score.ToString();
            label3.Visible = false;
            if (Form1.GameMode == 2)
            {
                if (CurrentSize > 50) CurrentSize--;
                this.label3.Size = new Size(CurrentSize, CurrentSize);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            score += multiplier;
            multiplier+=multiplier2;
            highscore = score.ToString();
            Scoreboard.Text = score.ToString();
            label4.Visible = false;
            if (Form1.GameMode == 2)
            {
                if (CurrentSize > 50) CurrentSize--;
                this.label4.Size = new Size(CurrentSize, CurrentSize);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            score += multiplier;
            multiplier+=multiplier2;
            highscore = score.ToString();
            Scoreboard.Text = score.ToString();
            label5.Visible = false;
            if (Form1.GameMode == 2)
            {
                if (CurrentSize > 50) CurrentSize--;
                this.label5.Size = new Size(CurrentSize, CurrentSize);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pause % 2 == 1) 
            { 
                timer1.Stop();
                label1.Click -= label1_Click;
                label2.Click -= label2_Click;
                label3.Click -= label3_Click;
                label4.Click -= label4_Click;
                label5.Click -= label5_Click;
                label6.Visible = true;
            }
            if (pause % 2 == 0) 
            { 
                label1.Click += label1_Click;
                label2.Click += label2_Click;
                label3.Click += label3_Click;
                label4.Click += label4_Click;
                label5.Click += label5_Click;
                label6.Visible = false;
                timer1.Start();
            }
            pause++;
        }
    }
}