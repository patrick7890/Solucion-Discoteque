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
    public partial class TotalSalaVip : MetroFramework.Forms.MetroForm
    {
        public TotalSalaVip()
        {
            InitializeComponent();
        }

        private void TotalSalaVip_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.atencion' Puede moverla o quitarla según sea necesario.

            DateTime fini = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, 1);
            DateTime ffin = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, 31);

            this.atencionTableAdapter.Vip(this.discotequeDataSet.atencion, fini.ToString(),ffin.ToString());
            int? consumo=this.atencionTableAdapter.ConsumoVipMensual(fini.ToString(),ffin.ToString());


            label1.Text = "Total: " + consumo;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
