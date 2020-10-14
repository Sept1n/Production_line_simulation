using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LogIn : Form
    {
        string Użytkownik1 = "Kowalski";
        string Użytkownik2 = "Zalewski";
        string Użytkownik3 = "Nowak";
        string Hasło1 = "Kow123";
        string Hasło2 = "Zal123";
        string Hasło3 = "Now123";
        public LogIn()
        {
            InitializeComponent();
        }

        public void Logowanie_Click(object sender, EventArgs e)
        {
            główny_widok menu = new główny_widok();
            if (Użytkownik.Text == Użytkownik1 && Hasło.Text == Hasło1 || Użytkownik.Text == Użytkownik2 && Hasło.Text == Hasło2 ||
                Użytkownik.Text == Użytkownik3 && Hasło.Text == Hasło3)
            {
                menu.Show();
                Visible = false;
                
            }
            else
                MessageBox.Show("Zły login lub hasło!!!");

        }
    }
}
