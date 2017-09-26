using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace planet
{
    public partial class Form1 : Form
    {
        SoundPlayer sp = new SoundPlayer(@"C:\Users\Guzeri\Desktop\пготлд\планеты\12.WAV");

        double ang = 360;
        double ang1 = 360;
        double ang2 = 360;
        double ang3 = 360;
        double ang4 = 360;
        double ang5 = 360;
        double ang6 = 360;
        double ang7 = 360;

        int r = 160;
        int r11 = 180;
        int r22 = 240;
        int r33 = 300;
        int r44 = 370;
        int r55 = 420;
        int r66 = 470;
        int r77 = 510;

        int r1 = 49;
        int r2 = 75;
        int r3 = 125;
        int r4 = 160;
        int r5 = 200;
        int r6 = 240;
        int r7 = 270;
        int r8 = 320;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sp.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(Convert.ToInt32(r * Math.Cos(ang) + 555), Convert.ToInt32(r1 * Math.Sin(ang) + 325));
            ang -= 0.11;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(Convert.ToInt32(r11 * Math.Cos(ang1) + 555), Convert.ToInt32(r2 * Math.Sin(ang1) + 325));
            ang1 -= 0.07;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox4.Location = new Point(Convert.ToInt32(r22 * Math.Cos(ang2) + 550), Convert.ToInt32(r3 * Math.Sin(ang2) + 325));
            ang2 -= 0.05;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox5.Location = new Point(Convert.ToInt32(r33 * Math.Cos(ang3) + 550), Convert.ToInt32(r4 * Math.Sin(ang3) + 325));
            ang3 -= 0.03;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox6.Location = new Point(Convert.ToInt32(r44 * Math.Cos(ang4) + 550), Convert.ToInt32(r5 * Math.Sin(ang4) + 325));
            ang4 -= 0.02;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox7.Location = new Point(Convert.ToInt32(r55 * Math.Cos(ang5) + 550), Convert.ToInt32(r6 * Math.Sin(ang5) + 325));
            ang5 -= 0.015;
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox8.Location = new Point(Convert.ToInt32(r66 * Math.Cos(ang6) + 570), Convert.ToInt32(r7 * Math.Sin(ang6) + 335));
            ang6 -= 0.013;
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox9.Location = new Point(Convert.ToInt32(r77 * Math.Cos(ang7) + 570), Convert.ToInt32(r8 * Math.Sin(ang7) + 335));
            ang7 -= 0.011;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
            timer2.Interval = trackBar1.Value;
            timer3.Interval = trackBar1.Value;
            timer4.Interval = trackBar1.Value;
            timer5.Interval = trackBar1.Value;
            timer6.Interval = trackBar1.Value;
            timer7.Interval = trackBar1.Value;
            timer8.Interval = trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
            timer6.Start();
            timer7.Start();
            timer8.Start();
            sp.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            timer6.Stop();
            timer7.Stop();
            timer8.Stop();
            sp.Stop();
        }
    }
}
