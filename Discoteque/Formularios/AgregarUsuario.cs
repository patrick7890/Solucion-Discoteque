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
    public partial class AgregarUsuario : MetroFramework.Forms.MetroForm
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.discotequeDataSet.usuario);
            // TODO: esta línea de código carga datos en la tabla 'discotequeDataSet.tipousuario' Puede moverla o quitarla según sea necesario.
            this.tipousuarioTableAdapter.Fill(this.discotequeDataSet.tipousuario);

        }

        private void btnAgregarUsu_Click(object sender, EventArgs e)
        {
            UsuarioService.UsuarioWSClient us = new UsuarioService.UsuarioWSClient();
            try
            {
                String nom = txtNombre.Text;
                String nomUsu = txtNombreUsuario.Text;
                String pass = txtPass.Text;
                String pass2 = txtPass2.Text;
                byte a = 1;
                int tipo =int.Parse( cboTipo.SelectedValue.ToString());

                if (pass==pass2)
                {
                    if (us.agregarUsario(nomUsu, pass, nom, tipo) && this.usuarioTableAdapter.Insert(nomUsu, pass, nom, a, tipo)!=0)
                    {
                        MessageBox.Show("Usuario Agregado");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Agregar");
                    }
       
                }
                else
                {
                    MessageBox.Show("La contraseña no coincide");
                }




                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
