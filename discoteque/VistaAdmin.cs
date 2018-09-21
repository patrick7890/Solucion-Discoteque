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
    public partial class VistaAdmin : MetroFramework.Forms.MetroForm
    {
        public VistaAdmin()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Formularios.AgregarProducto form = new Formularios.AgregarProducto();
            form.MdiParent = this;
            form.Show();
        }
    }
}
