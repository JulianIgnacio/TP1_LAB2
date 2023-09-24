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
    public partial class Form3 : Form
    {
        Alquiler alquiler = new Alquiler();

        public Form3(string tipoP,double precioDia,int cantDias)
        {
            InitializeComponent();

            lprop.Text = tipoP.ToString();

            lprecio.Text = ("$" + precioDia).ToString();

            ldiasAlq.Text = cantDias.ToString();

            double totalAlquiler = alquiler.CalcularTotal(cantDias,precioDia);

            lprecioT.Text = ("$" + totalAlquiler).ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Visible = true;
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
