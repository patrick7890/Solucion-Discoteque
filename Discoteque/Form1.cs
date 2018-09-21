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
    public partial class Form1 :MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 5000;
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Login Form1 = new Login();
            Form1.Show();
            timer1.Enabled = false;
            
        }
    }
}
