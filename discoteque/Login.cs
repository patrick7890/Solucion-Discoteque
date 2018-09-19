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

            Boolean logeado = login.Login(txtUsu.Text,txtPass.Text);

            

            if (logeado)
            {
                this.Hide();
                Form1 Form1 = new Form1();
                Form1.Show();

            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }

        }
    }
}
