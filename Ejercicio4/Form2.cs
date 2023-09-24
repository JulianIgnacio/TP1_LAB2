using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tipoPropiedad = txtTipoP.Text;

            double precioPorDia = Convert.ToDouble(txtPrecioP.Text);

            int cantidadDeDias = Convert.ToInt16(txtCdias.Text);

            Form3 form3 = new Form3(tipoPropiedad,precioPorDia,cantidadDeDias);

            form3.Visible = true;

            this.Visible = false;
        }
    }
}
