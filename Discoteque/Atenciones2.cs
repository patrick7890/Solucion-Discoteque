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
            //Login l = new Login();
            //l.Show();
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
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.GetProductoByAtencio(this.discotequeDataSet.producto, idat);
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.atencion' Puede moverla o quitarla según sea necesario.
            //this.atencionTableAdapter.GetProductosByAtencion(this.discotequeDataSet.atencion, idat);
            lblA.Text = idat.ToString();
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.comanda' Puede moverla o quitarla según sea necesario.
            this.comandaTableAdapter.Fill(this.discotequeDataSet.comanda);
            timer1.Interval = 5000;

        }

        private void finalizarAtencionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            atencionTableAdapter.Updatefactura(0, idat);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            productoTableAdapter.GetProductoByAtencio(discotequeDataSet.producto, idat);

            lblTotal.Text= atencionTableAdapter.TotalAPagar(idat).ToString();
        }
    }
}
