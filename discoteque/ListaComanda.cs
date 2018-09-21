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
    public partial class txtNombreMesero : MetroFramework.Forms.MetroForm
    {
        public txtNombreMesero()
        {
            InitializeComponent();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreMesero_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.atencion' Puede moverla o quitarla según sea necesario.
            this.atencionTableAdapter.Fill(this.discotequeDataSet.atencion);

            this.reportViewer1.RefreshReport();

        }

        private void btnListarMesero_Click(object sender, EventArgs e)
        {

            this.atencionTableAdapter.TablaFiltroMesero(txtNombre.Text);

            this.reportViewer1.RefreshReport();
        }

        private void btnMasVendido_Click(object sender, EventArgs e)
        {



            MessageBox.Show("Usuario incorrecto");

        }
    }
}
