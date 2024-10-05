using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Razeni
{
    public partial class Form1 : Form
    {
        private Prevodovka p = new Prevodovka(800);

        public Form1()
        {
            InitializeComponent();
        }

        //metoda na aktualizaci stavu rychlosti a otacek
        public void Budiky()
        {
            otackoMer.Text = p.OtackyMotoru.ToString();
            tachometr.Text = p.Rychlost.ToString();

            otackoMetrBar.Value = p.OtackyMotoru;
            rychloMetrBar.Value = p.Rychlost;
        }

        private void stupenJedna_MouseClick(object sender, MouseEventArgs e)
        {
            if (spojka.Checked)
            {
                Console.WriteLine("jednicka");
                p.AktualniPrevod = 0;
                p.MatematikaStavu(akcelerator.Value, 6000, 400);
            }
            Budiky();
        }

        private void akcelerator_ValueChanged(object sender, EventArgs e)
        {
            p.MatematikaStavu(akcelerator.Value, 6000, 400);
            Budiky();
        }

        private void stupenDva_MouseClick(object sender, MouseEventArgs e)
        {
            if (spojka.Checked)
            {
                Console.WriteLine("dvojka");
                p.AktualniPrevod = 1;
                p.MatematikaStavu(akcelerator.Value, 6000, 400);
            }
            Budiky();
        }
    }
}
