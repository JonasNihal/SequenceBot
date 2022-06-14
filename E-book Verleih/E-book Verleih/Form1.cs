using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_book_Verleih
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
            panelKaufen.Hide();
            panelMeineBuecher.Hide();
            panelVerkaufen.Hide();
        }
        //Menü Button:
        private void btn_kaufen_Click(object sender, EventArgs e)
        {
            panelKaufen.Show();
        }

        private void btn_anzeigen_Click(object sender, EventArgs e)
        {
            panelMeineBuecher.Show();
        }

        private void btn_verkaufen_Click(object sender, EventArgs e)
        {
            panelVerkaufen.Show();
        }

        private void btn_Schliesen_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_zurueck_Click_1(object sender, EventArgs e)
        {
            panelKaufen.Hide();
        }

        private void btn_zurueck1_Click_1(object sender, EventArgs e)
        {
            panelMeineBuecher.Hide();
        }
        private void btn_zurueck2_Click(object sender, EventArgs e)
        {
            panelVerkaufen.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Kaufen1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Kaufen2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Kaufen3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Kaufen4_Click(object sender, EventArgs e)
        {

        }

    }
}
