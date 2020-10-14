using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class główny_widok : Form
    {
        float a;
        public główny_widok()
        {
            InitializeComponent();
        }
        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            Close();
            login.Show();
        }

        private void blaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jestem.Stop();
            jestem.Start();
        }

        private void parametryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jestem.Stop();
            jestem.Start();
        }

        private void cPUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPU fcpu = new CPU();
            fcpu.Show();
            jestem.Stop();
            jestem.Start();
        }

        private void rAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RAM ram = new RAM();
            ram.Show();
            jestem.Stop();
            jestem.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) // temperatura
        {

            Random zmienna = new Random();
            a = zmienna.Next(40, 80);
            circularProgressBar2.Value = (int)a;
            circularProgressBar2.Text = string.Format("{0:0}°C", a);
            if (a > 70)
            {
                timer13.Enabled = true;
                timer14.Enabled = true;
                timer1.Enabled = false;
            }
            else
            {

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random zmienna = new Random();
            a = zmienna.Next(40, 60);
            circularProgressBar2.Value = (int)a;
            circularProgressBar2.Text = string.Format("{0:0}°C", a);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer13.Enabled = false;
            timer14.Enabled = false;
            label4.Text = ("");
            jestem.Stop();
            jestem.Start();
        }
        private void timer13_Tick(object sender, EventArgs e)
        {
            label4.Text = ("Przegrzewa się!");
            Thread.Sleep(500);
        }
        private void timer14_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            label4.Text = ("");
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random zmienna = new Random();
            int x = zmienna.Next(1, 20);
            if (x > 18)
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
                timer3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer4.Enabled = true;
            timer7.Enabled = true;
            jestem.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer4.Enabled = false;
            timer5.Enabled = true;
            timer6.Enabled = true;
            timer15.Enabled = false;
            timer16.Enabled = false;
            label5.Text = ("");
            jestem.Stop();
            jestem.Start();
        }

        private void timer4_Tick(object sender, EventArgs e) // Ciśnienie
        {
            Random zmienna = new Random();
            int b = zmienna.Next(30, 50);
            circularProgressBar1.Value = (int)b;
            circularProgressBar1.Text = string.Format("{0:00.00}GPa", b);
            if (b > 45)
            {
                timer15.Enabled = true;
                timer16.Enabled = true;
                timer4.Enabled = false;
            }
            else
            {

            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            Random zmienna = new Random();
            int b = zmienna.Next(10, 40);
            circularProgressBar1.Value = (int)b;
            circularProgressBar1.Text = string.Format("{0:0.00}GPa", b);
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            Random zmienna = new Random();
            int x = zmienna.Next(1, 20);
            if (x > 18)
            {
                timer4.Enabled = true;
                timer5.Enabled = false;
                timer6.Enabled = false;
            }
        }
        private void timer15_Tick(object sender, EventArgs e)
        {
            label5.Text = ("Za duże ciśnienie!");
            Thread.Sleep(500);
        }
        private void timer16_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            label5.Text = ("");
        }

        private void timer7_Tick(object sender, EventArgs e) //nacisk
        {
            Random zmienna = new Random();
            int b = zmienna.Next(10, 50);
            circularProgressBar3.Value = (int)b;
            circularProgressBar3.Text = string.Format("{0:00.00}kg/m^2", b);
            if (b < 15)
            {
                timer17.Enabled = true;
                timer18.Enabled = true;
                timer7.Enabled = false;
            }
            if (b > 45)
            {
                timer7.Enabled = false;
                timer19.Enabled = true;
                timer20.Enabled = true;
            }
            else
            {

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            timer8.Enabled = true;
            timer10.Enabled = true;
            timer17.Enabled = false;
            timer18.Enabled = false;
            label6.Text = ("");
            jestem.Stop();
            jestem.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        { 
            timer9.Enabled = true;
            timer10.Enabled = true;
            timer19.Enabled = false;
            timer20.Enabled = false;
            label7.Text = ("");
            jestem.Stop();
            jestem.Start();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            Random zmienna = new Random();
            int b = zmienna.Next(15, 50);
            circularProgressBar3.Value = (int)b;
            circularProgressBar3.Text = string.Format("{0:0.00}kg/m^2", b);
            if (b > 45)
            {
                timer7.Enabled = false;
                timer8.Enabled = false;
                timer19.Enabled = true;
                timer20.Enabled = true;
            }
            else
            {

            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            Random zmienna = new Random();
            int b = zmienna.Next(10, 45);
            circularProgressBar3.Value = (int)b;
            circularProgressBar3.Text = string.Format("{0:0.00}kg/m^2", b);
            if (b < 15)
            {
                timer7.Enabled = false;
                timer9.Enabled = false;
                timer17.Enabled = true;
                timer18.Enabled = true;
            }
            else
            {

            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            Random zmienna = new Random();
            int x = zmienna.Next(1, 20);
            if (x > 18)
            {
                timer7.Enabled = true;
                timer8.Enabled = false;
                timer10.Enabled = false;
            }
        }

        private void timer11_Tick(object sender, EventArgs e) 
        {
            Random zmienna = new Random();
            int x = zmienna.Next(1, 20);
            if (x > 18)
            {
                timer7.Enabled = true;
                timer9.Enabled = false;
                timer11.Enabled = false;
            }
        }
        private void timer17_Tick(object sender, EventArgs e)
        {
            label6.Text = ("Za mały nacisk!");
            Thread.Sleep(500);
        }

        private void timer18_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            label6.Text = ("");
        }

        private void timer19_Tick(object sender, EventArgs e)
        {
            label7.Text = ("Za duży nacisk!");
            Thread.Sleep(500);
        }

        private void timer20_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            label7.Text = ("");
        }

        private void timer12_Tick(object sender, EventArgs e) //awaria
        {
            Random zmienna = new Random();
            int x = zmienna.Next(1, 50);
            if (x >= 48)
            {
                MessageBox.Show("Awaria systemu - wezwij pomoc");
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                timer6.Enabled = false;
                timer7.Enabled = false;
                timer8.Enabled = false;
                timer9.Enabled = false;
                timer10.Enabled = false;
                timer11.Enabled = false;
                timer12.Enabled = false;
                timer13.Enabled = false;
                timer14.Enabled = false;
                timer15.Enabled = false;
                timer16.Enabled = false;
                timer17.Enabled = false;
                timer18.Enabled = false;
                timer19.Enabled = false;
                timer20.Enabled = false;

            }
            else
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer4.Enabled = true;
            timer7.Enabled = true;
            jestem.Stop();
            jestem.Start();
            label4.Text = ("");
            label5.Text = ("");
            label6.Text = ("");
            label7.Text = ("");
        }

        private void jestem_Tick(object sender, EventArgs e) //aktywność 

        {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                timer6.Enabled = false;
                timer7.Enabled = false;
                timer8.Enabled = false;
                timer9.Enabled = false;
                timer10.Enabled = false;
                timer11.Enabled = false;
                timer12.Enabled = false;
                timer13.Enabled = false;
                timer14.Enabled = false;
                timer15.Enabled = false;
                timer16.Enabled = false;
                timer17.Enabled = false;
                timer18.Enabled = false;
                timer19.Enabled = false;
                timer20.Enabled = false;
                timer21.Enabled = true;
           if ( MessageBox.Show("Żyjesz?","Siema", MessageBoxButtons.YesNo)==DialogResult.No)
            {
                
                Application.Exit();
            }
           else
            {
                timer1.Enabled = true;
                timer4.Enabled = true;
                timer7.Enabled = true;
                timer21.Enabled = false;
                label4.Text = ("");
                label5.Text = ("");
                label6.Text = ("");
                label7.Text = ("");
            }
        }

        private void timer21_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
