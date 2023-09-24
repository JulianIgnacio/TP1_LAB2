using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form3 : Form
    {
        public Form3(string descripcionProducto,double precioProducto,string fechaCompra,string tipoProducto,int cantidadProducto)
        {
            DatosFinales datos = new DatosFinales();

            InitializeComponent();

            ldescripcionP.Text = descripcionProducto.ToString();

            lprecioP.Text = ("$" + precioProducto).ToString();

            lfechaP.Text = fechaCompra.ToString();

            ltipoP.Text = tipoProducto.ToString();

            lcantidadP.Text = cantidadProducto.ToString();

            double precioTotal = datos.CalcularPrecioTotal(precioProducto, cantidadProducto);

            lprecioFinal.Text = ("$" + precioTotal).ToString();
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Visible = true;
            this.Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
