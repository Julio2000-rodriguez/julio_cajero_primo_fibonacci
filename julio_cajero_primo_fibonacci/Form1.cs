using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace julio_cajero_primo_fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRestirar_Click(object sender, EventArgs e)
        {
            {
                double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
                double cantidad = double.Parse(txtCantidad.Text);
                sbyte n = 0;
                String respuesta = "Respuesta: ";
                foreach (double denominacion in denominaciones)
                {
                    while (denominacion <= cantidad)
                    {
                        n++;
                        cantidad -= denominacion;
                    }
                    if (n > 0)
                    {
                        respuesta += n + (denominacion > 1 ? "billetes " : "monedas ") + denominacion + "\n";
                    }
                    n = 0;
                }
                lblRespuesta.Text = respuesta;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.50, 0.10, 0.05, 0.01 };
            double cantidad = double.Parse(txtpagar.Text);
            double pago = double.Parse(txtpago.Text);
            sbyte n = 0;
            double resta = pago - cantidad;
            string resp = "cambio \n";
            foreach (double denominacion in denominaciones)
            {
                while (denominacion <= Math.Round(resta, 2))
                {
                    n++;

                    resta -= denominacion;
                }
                if (n > 0)
                {
                    resp += n + (denominacion > 1 ? "Billete" : "Monedas") + denominacion + "\n";
                }
                n = 0;
            }
            lblCambio.Text = resp;
        }

        private void btnrespuesta_Click(object sender, EventArgs e)
        {
            int x, a, b = 0;
            x = Convert.ToInt32(txtnumero.Text);

            for (a = 1; a <= x; a++)
            {

                if (x % a == 0)
                    b++;
            }

            if (b > 1)

            {
                lblprimo.Text = "El numero es primo.";
            }
            else
            {
                lblprimo.Text = "El numero no es primo.";
            }
        }

        private void btnmio_Click(object sender, EventArgs e)
        {
            int x, a, b = 0;
            x = Convert.ToInt32(txtnumero.Text);

            for (a = 1; a <= x; a++)
            {

                if (x % a == 0)
                    b++;
            }

            if (b > 1)

            {
                lblprimo.Text = "El numero es primo.";
            }
            else
            {
                lblprimo.Text = "El numero no es primo.";
            }
        }
    }
}
