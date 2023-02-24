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
    public partial class Numeros_Multiplos : Form
    {
        public Numeros_Multiplos()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            MostrarNumeros();
        }

        private void MostrarNumeros() 
        {
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        NumeroslistBox.Items.Add("Jeisson Zelaya");
                    }
                    else if (i % 3 == 0)
                    {
                        NumeroslistBox.Items.Add("Jeisson");
                    }
                    else if (i % 5 == 0)
                    {
                        NumeroslistBox.Items.Add("Zelaya");
                    }
                    else
                    {
                        NumeroslistBox.Items.Add(i);
                    }
                }
            }


        }


    }
}
