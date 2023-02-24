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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private async void Calcularbutton_Click(object sender, EventArgs e)
        {
            decimal precio = Convert.ToDecimal(PreciotextBox.Text);
            decimal cantidad = Convert.ToDecimal(CantidadtextBox.Text);
            
            decimal Total = await DescuentoAsync(precio, cantidad);

            DescuentotextBox.Text = Total.ToString();

        }

        private async Task<decimal> DescuentoAsync(decimal precio, decimal cantidad) 
        {
            decimal SubTotal = await Task.Run(() =>
            {
                return precio * cantidad;
            });

            decimal descuento = await Task.Run(() =>
            {
                return SubTotal * 0.15M;
            });

            decimal total = await Task.Run(() =>
            {
                return SubTotal - descuento;
            });
            return total;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            ProductotextBox.Clear();
            CantidadtextBox.Clear();
            PreciotextBox.Clear();
            DescuentotextBox.Clear();
        }
    }
}
