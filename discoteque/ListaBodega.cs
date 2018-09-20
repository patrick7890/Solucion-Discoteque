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
    public partial class ListaBodega : MetroFramework.Forms.MetroForm
    {
        public ListaBodega()
        {
            InitializeComponent();
        }

        private void ListaBodega_Load(object sender, EventArgs e)
        {
           

        }

        private void panel1_Load(object sender, EventArgs e)
        {

        }

        private void btnProductoDeBaja_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSetData.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.ListaDaoDeBaja(this.discotequeDataSetData.producto);
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSetData.tipoproducto' Puede moverla o quitarla según sea necesario.
            this.tipoproductoTableAdapter.Fill(this.discotequeDataSetData.tipoproducto);
            this.panel1.RefreshReport();
        }
    }
}
