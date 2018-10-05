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
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.atencion' Puede moverla o quitarla según sea necesario.
            this.atencionTableAdapter.Fill(this.discotequeDataSet.atencion);
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.discotequeDataSet.producto);
            this.reportViewer1.RefreshReport();

        }

        private void panel1_Load(object sender, EventArgs e)
        {

        }

        private void btnProductoDeBaja_Click(object sender, EventArgs e)
        {

            this.productoTableAdapter.Baja(this.discotequeDataSet.producto);

            this.reportViewer1.RefreshReport();
        }

        private void panel1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnListarProducto_Click(object sender, EventArgs e)
        {

            this.productoTableAdapter.Fill(this.discotequeDataSet.producto);

            this.reportViewer1.RefreshReport();


        }

        private void btnTotalMesero_Click(object sender, EventArgs e)
        {

            Formularios.PagarMesero M = new Formularios.PagarMesero();
            M.Show();



        }

        private void btnListarVIP_Click(object sender, EventArgs e)
        {

            Formularios.TotalSalaVip vip = new Formularios.TotalSalaVip();
            vip.Show();
            
            //this.atencionTableAdapter.FiltroSala(this.discotequeDataSet.atencion, "VIP");
            //this.reportViewer1.RefreshReport();
        }

        private void btnListarCritico_Click(object sender, EventArgs e)
        {
            this.productoTableAdapter.StockCritico(this.discotequeDataSet.producto);

            this.reportViewer1.RefreshReport();

        }
    }
}
