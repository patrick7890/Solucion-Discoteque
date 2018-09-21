using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discoteque.Formularios
{
    public partial class AgregarProducto : MetroFramework.Forms.MetroForm
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.producto' Puede moverla o quitarla según sea necesario.

            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.tipoproducto' Puede moverla o quitarla según sea necesario.
            this.tipoproductoTableAdapter.Fill(this.discotequeDataSet.tipoproducto);

        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            try
            {



                String nombre = txtNombre.Text;
                int precio = int.Parse(txtPrecio.Text);
                int stock = int.Parse(txtStock.Text);
                int tipo = cboTipoProducto.SelectedIndex + 1;

                if (this.productoTableAdapter.InsertProducto(nombre, precio, stock, tipo) == 1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Producto Agregado");

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Producto NO Agregado");
                }
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Producto NO Agregado","ERRO" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }
    }
}
