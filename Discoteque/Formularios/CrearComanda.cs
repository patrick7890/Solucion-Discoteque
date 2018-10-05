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
    public partial class CrearComanda : MetroFramework.Forms.MetroForm
    {

        public int idcomanda;
        public CrearComanda()
        {
            InitializeComponent();
        }

        private void CrearComanda_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.comanda_producto' Puede moverla o quitarla según sea necesario.
            this.comanda_productoTableAdapter.Fill(this.discotequeDataSet.comanda_producto);
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.tipoproducto' Puede moverla o quitarla según sea necesario.
            this.tipoproductoTableAdapter.Fill(this.discotequeDataSet.tipoproducto);
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.ProductosEnVenta(this.discotequeDataSet.producto);

        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void cboTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

            int idTipo = cboTipoProducto.SelectedIndex +1;

            
            this.productoTableAdapter.enVenta(this.discotequeDataSet.producto,idTipo);
            

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int agregado = 0;
            int cont = 0;
            int cant = int.Parse(txtCantidad.Text);
            int id = int.Parse(txtID.Text);
            try
            {
                if (this.productoTableAdapter.GetStock(id)>cant)
                {
                    for (int i = 0; i < cant; i++)
                    {
                        agregado = this.comanda_productoTableAdapter.InsertComanda_Producto(id, idcomanda);

                        if (agregado != 0)
                        {
                            cont++;
                        }

                    }
                    MessageBox.Show(cont + " Productos Agregados");
                } 
                
                
                else
                {
               
                    MessageBox.Show(cant - cont + " No hay stock Suficiente");
                }
            }
            catch (Exception)
            {

                MessageBox.Show( "El Producto no Existe");
            }


            limpiar();

        }


        public void limpiar()
        {
            txtCantidad.Text = "";
            txtID.Text = "";
            int idTipo = cboTipoProducto.SelectedIndex + 1;
            this.productoTableAdapter.enVenta(this.discotequeDataSet.producto, idTipo);
            dataGridView1.Refresh();

        }
    }
}
