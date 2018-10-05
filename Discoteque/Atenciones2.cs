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
    public partial class Atenciones2 : MetroFramework.Forms.MetroForm
    {

        public int ida;
        public int idat;


        public Atenciones2()
        {
            InitializeComponent();

        }

        private void btnCrearAtencion_Click(object sender, EventArgs e)
        {




            this.Hide();
            Formularios.CrearAtencion Form1 = new Formularios.CrearAtencion();

            Form1.idUsu = ida;

            Form1.Show();


        }

        private void crearAtencionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Formularios.CrearAtencion Form1 = new Formularios.CrearAtencion();

            Form1.idUsu = ida;

            Form1.Show();



        }

        private void Atenciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            int total = int.Parse(atencionTableAdapter.TotalAPagar(idat).ToString());
            int p =(int) Math.Round(total*0.1);
            atencionTableAdapter.Updatefactura(p,idat);
            MessageBox.Show("Atencion Finalizada Total a pagar" + lbltp.Text);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void agregarComandaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.comandaTableAdapter.InsertComanda(idat, ida);
            int com = (int)comandaTableAdapter.lastComanda();
            Formularios.CrearComanda comanda = new Formularios.CrearComanda();
            comanda.idcomanda = com;
            comanda.Show();


        }

        private void Atenciones_Load(object sender, EventArgs e)
        {
            lblA.Text = idat.ToString();
            timer1.Interval = 5000;

        }

        private void finalizarAtencionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                productoTableAdapter.GetProductoByAtencio(discotequeDataSet.producto, idat);
            }
            catch (Exception)
            {

                productoTableAdapter.GetProductoByAtencio(discotequeDataSet.producto, idat);
            }
            int total = int.Parse(atencionTableAdapter.TotalAPagar(idat).ToString());

            int propina = (int) Math.Round(total * 0.1);
            lblConsumo.Text="Consumo :"+ total.ToString();
            lblPropina.Text =propina.ToString();
            lbltp.Text = "Total+Propina : " + (total+propina).ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
