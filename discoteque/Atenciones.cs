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

        public int ida;
        public int idat;

        public Atenciones()
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
            Login l = new Login();
            l.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void agregarComandaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.comandaTableAdapter.InsertComanda(idat, ida);
            int com = (int)comandaTableAdapter.lastComanda();
            Formularios.CrearComanda comanda = new Formularios.CrearComanda();
            comanda.MdiParent=this;
            comanda.Show();


        }

        private void Atenciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.comanda' Puede moverla o quitarla según sea necesario.
            this.comandaTableAdapter.Fill(this.discotequeDataSet.comanda);

        }
    }
}
