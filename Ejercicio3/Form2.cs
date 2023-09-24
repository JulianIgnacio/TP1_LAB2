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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string descripcionDeProducto = txtDescripcionProducto.Text;
            double precioProducto = Convert.ToDouble(txtPrecio.Text);
            string fechaDeCompra = txtFechaC.Text;
            string tipoDeProducto = txtTipoProducto.Text;
            int cantidadDeProducto = Convert.ToInt16(txtCantidadProducto.Text);
            Form3 form3 = new Form3(descripcionDeProducto,precioProducto,fechaDeCompra,tipoDeProducto,cantidadDeProducto);
            form3.Visible = true;
            this.Visible = false;

        }
    }
}
