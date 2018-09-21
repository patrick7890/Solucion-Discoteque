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

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoProductos form2=null;
            ListadoProductos form = new ListadoProductos();
            if (form2!=null)
            {
                this.Close();
            }
            form2 = form;
            form2.MdiParent = this;
            form2.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();

        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaBodega form = new ListaBodega();
            form.MdiParent = this;
            form.Show();
        }

        private void VistaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void VistaAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Login l = new Login();
            l.Show();
        }
    }
}
