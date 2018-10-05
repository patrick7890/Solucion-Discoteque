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
    public partial class PagarMesero : MetroFramework.Forms.MetroForm
    {
        public PagarMesero()
        {
            InitializeComponent();
            

        }

        private void PagarMesero_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.atencion' Puede moverla o quitarla según sea necesario.
            this.atencionTableAdapter.Fill(this.discotequeDataSet.atencion);
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.discotequeDataSet.usuario);

        }

        private void cboMesero_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Mesero = (cboMesero.Text);
            DateTime fini = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month,1);
            DateTime ffin = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, 31);

            

            this.atencionTableAdapter.FiltroUusarioFecha(this.discotequeDataSet.atencion,fini.ToString(),ffin.ToString(),Mesero);


        }
    }
}
