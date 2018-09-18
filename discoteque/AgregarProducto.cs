using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discoteque
{
    public partial class AgregarProducto : MetroFramework.Forms.MetroForm
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            ProductoSevice.ProductoWSClient servicio = new ProductoSevice.ProductoWSClient();

            String nombre = txtNombre.Text;
            int precio = int.Parse(txtPrecio.Text);
            int stock = int.Parse(txtStock.Text);
            int tipo = cboTipoProducto.SelectedIndex;


            Boolean agregado= servicio.IngresarProducto(nombre, precio, stock, tipo);

            if (agregado)
            {
                MessageBox.Show("Preoducto Ingresado Corectamente");

            }
            else{
                MessageBox.Show("No se Pudo Ingresar");
            }


        }
    }
}
