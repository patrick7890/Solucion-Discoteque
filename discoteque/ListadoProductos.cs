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
    public partial class ListadoProductos : MetroFramework.Forms.MetroForm
    {
       
        public ListadoProductos()
        {
            InitializeComponent();
        }

        private void ListadoProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSetData.producto' Puede moverla o quitarla según sea necesario.
          //  this.productoTableAdapter1.Fill(this.discotequeDataSetData.producto);
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSetData.tipoproducto' Puede moverla o quitarla según sea necesario.
            this.tipoproductoTableAdapter.Fill(this.discotequeDataSetData.tipoproducto);
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSetData.atencion' Puede moverla o quitarla según sea necesario.
            this.atencionTableAdapter.Fill(this.discotequeDataSetData.atencion);
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.discotequeDataSet.producto);
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.discotequeDataSet.producto);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productoTableAdapter1.FillBy(this.discotequeDataSetData.producto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
