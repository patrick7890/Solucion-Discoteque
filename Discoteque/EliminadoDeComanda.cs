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
    public partial class EliminadoDeComanda : MetroFramework.Forms.MetroForm
    {
        public int id;

        public EliminadoDeComanda()
        {

            InitializeComponent();
        }

        private void EliminadoDeComanda_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.comanda' Puede moverla o quitarla según sea necesario.
            this.comandaTableAdapter.GetComadaByAtencion(this.discotequeDataSet.comanda,id);



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idg = dataGridView1.CurrentRow.Index;

            String idAtencion = dataGridView1.Rows[idg].Cells[0].Value.ToString();
            int ida;
            int.TryParse(idAtencion, out ida);

            this.comandaTableAdapter.DeleteComanda(ida);







        }
    }
}
