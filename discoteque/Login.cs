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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioService.UsuarioWSClient login = new UsuarioService.UsuarioWSClient();
            try
            {

            

            int logeado = login.tipoUsuario(txtUsu.Text,txtPass.Text);

            int id = login.idUsuario(txtUsu.Text, txtPass.Text);

            if (logeado == 1 )
            {
                this.Hide();
                Atenciones Form1 = new Atenciones();
                Form1.ida = id;
                Form1.Show();

            }
            else if(logeado == 2){
                this.Hide();
                VistaAdmin Form2 = new VistaAdmin();
                Form2.Show();

            }else
            {
                MessageBox.Show("Usuario incorrecto");
            }

            }
            catch (Exception)
            {

                MessageBox.Show("Usuario incorrecto");
            }

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
