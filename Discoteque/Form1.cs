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
    public partial class Form1 :MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.producto' Puede moverla o quitarla según sea necesario.
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Form1 = new Login();
            Form1.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            this.Hide();
            ListadoProductos Form1 = new ListadoProductos();
            Form1.Show();
        }

        private void btnBodega_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaBodega Form1 = new ListaBodega();
            Form1.Show();
        }
    }
}
