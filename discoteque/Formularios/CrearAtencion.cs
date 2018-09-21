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
    public partial class CrearAtencion : MetroFramework.Forms.MetroForm
    {

        public int idUsu;

        public CrearAtencion()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            int id = idUsu;
            int tipo = cboTipoSala.SelectedIndex +1;
            DateTime fecha = DateTime.Now;

            this.atencionTableAdapter.InsertAtencion(fecha.ToString(),id,tipo);
            this.Hide();
            Atenciones Form1 = new Atenciones();
            Form1.idat = id;
            Form1.Show();

        }

        private void CrearAtencion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.tiposala' Puede moverla o quitarla según sea necesario.
            this.tiposalaTableAdapter.Fill(this.discotequeDataSet.tiposala);
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.atencion' Puede moverla o quitarla según sea necesario.
            this.atencionTableAdapter.Fill(this.discotequeDataSet.atencion);

        }
    }
}
