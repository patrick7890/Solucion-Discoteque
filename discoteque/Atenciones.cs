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
    public partial class Atenciones : MetroFramework.Forms.MetroForm
    {
        public Atenciones()
        {
            InitializeComponent();
        }

        private void btnCrearAtencion_Click(object sender, EventArgs e)
        {

            this.Hide();
            Formularios.CrearAtencion Form1 = new Formularios.CrearAtencion();
            Form1.Show();


        }
    }
}
