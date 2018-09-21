﻿using System;
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
    public partial class ListaComanda2 :MetroFramework.Forms.MetroForm
    {
        public ListaComanda2()
        {
            InitializeComponent();
        }

        private void ListaComanda2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.atencion' Puede moverla o quitarla según sea necesario.
            this.atencionTableAdapter.Fill(this.discotequeDataSet.atencion);
            this.reportViewer1.RefreshReport();
        }

        private void btnListarMesero_Click(object sender, EventArgs e)
        {
            this.atencionTableAdapter.FiltroMesero(this.discotequeDataSet.atencion,txtNombre.Text);
            this.reportViewer1.RefreshReport();

        }

        private void btnListarVip_Click(object sender, EventArgs e)
        {
            this.atencionTableAdapter.FiltroSala(this.discotequeDataSet.atencion, "VIP");
            this.reportViewer1.RefreshReport();
        }

        private void btnListarFecha_Click(object sender, EventArgs e)
        {
            this.atencionTableAdapter.FiltroFecha(this.discotequeDataSet.atencion, dateInicio.Text,dateTermino.Text);
            this.reportViewer1.RefreshReport();
        }

        private void btnMasVendido_Click(object sender, EventArgs e)
        {

        }

        private void btnMenosVendido_Click(object sender, EventArgs e)
        {

        }
    }
}
