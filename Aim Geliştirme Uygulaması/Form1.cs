using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aim_Geliştirme_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        int sure = 60;
        int skor = 0;
        int can = 3;


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
            Random rnd = new Random();

            skor++;

            lblSkor.Text = skor.ToString();

            int nokta_x;
            nokta_x = rnd.Next(0, 700);
            pictureBox1.Location = new Point(nokta_x, pictureBox1.Location.Y);

            int nokta_y;
            nokta_y = rnd.Next(70, 400);
            pictureBox1.Location = new Point(pictureBox1.Location.X, nokta_y);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();

            if (sure == 0)
            {
                timer1.Stop();
                MessageBox.Show("Süre Doldu!\nSkorunuz: " + skor.ToString(), "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Restart();
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            lblSure.Text = "60";
            timer1.Start();
            pictureBox1.Visible = true;
            lblKalanHak.Text = "3";
            panel1.Enabled = true;
            this.Controls.Remove(button1);
            button1.Visible = false;
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            can--;
            lblKalanHak.Text = can.ToString();
            if (can == 0)
            {
                timer1.Stop();
                MessageBox.Show("Kaybettiniz!\nSkorunuz: " + skor.ToString(), "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Restart();
            }
        }
    }
}
