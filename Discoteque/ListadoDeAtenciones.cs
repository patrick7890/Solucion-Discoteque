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
    public partial class ListadoDeAtenciones : MetroFramework.Forms.MetroForm
    {
        DateTime fechaHoy = System.DateTime.Today;
        DateTime f = System.DateTime.Today.AddDays(1);
        public ListadoDeAtenciones()
        {
            InitializeComponent();
        }

        private void ListadoDeAtenciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.atencion' Puede moverla o quitarla según sea necesario.

           
            this.atencionTableAdapter.FiltroFecha(this.discotequeDataSet.atencion, fechaHoy.ToString(), f.ToString());




        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = dataGridView1.CurrentRow.Index;

                String idAtencion = dataGridView1.Rows[id].Cells[0].Value.ToString();
                int ida;
                int.TryParse(idAtencion, out ida);
           

                EliminadoDeComanda ec = new EliminadoDeComanda();
                ec.id=ida;
                ec.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione una Fila");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = dataGridView1.CurrentRow.Index;

                String idAtencion = dataGridView1.Rows[id].Cells[0].Value.ToString();
                int ida;
                int.TryParse(idAtencion, out ida);

                this.atencionTableAdapter.DeleteAtencion(ida);
                MessageBox.Show("Atencion Eliminada");
                this.atencionTableAdapter.FiltroFecha(this.discotequeDataSet.atencion, fechaHoy.ToString(), f.ToString());

            }
            catch (Exception)
            {

                MessageBox.Show("Error a Eliminar");
            }

        }
    }
}
