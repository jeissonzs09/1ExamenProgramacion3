using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeissonZelaya
{
    public partial class Intereses : Form
    {
        public Intereses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               CalculoInteres();
        }

        private void CalculoInteres() 
        {
            double TasaInteres = 0.0015;
            double Capital = 2000000;

            InteresesMensuales.Items.Clear();

            for (int mes = 1; mes <= 12; mes++)
            {
                double interes = Capital * TasaInteres;
                Capital += (int)interes;
                InteresesMensuales.Items.Add("Mes " + mes +": " + interes.ToString("C2"));
            }
        
        }
    }
}
