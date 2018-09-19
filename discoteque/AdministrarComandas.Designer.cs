namespace discoteque
{
    partial class AdministrarComandas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.btnListaDelMesero = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboTipoSala = new MetroFramework.Controls.MetroComboBox();
            this.btnListaTipoSala = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dtInicio = new MetroFramework.Controls.MetroDateTime();
            this.dtTermino = new MetroFramework.Controls.MetroDateTime();
            this.btnListadoFecha = new MetroFramework.Controls.MetroButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnMasVendido = new MetroFramework.Controls.MetroButton();
            this.btnMenosVendodos = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroListView1
            // 
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(24, 107);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(414, 479);
            this.metroListView1.TabIndex = 0;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListaDelMesero);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(479, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado del Mesero";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(129, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nombre del Mesero";
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(156, 15);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(117, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnListaDelMesero
            // 
            this.btnListaDelMesero.Location = new System.Drawing.Point(156, 57);
            this.btnListaDelMesero.Name = "btnListaDelMesero";
            this.btnListaDelMesero.Size = new System.Drawing.Size(110, 23);
            this.btnListaDelMesero.TabIndex = 2;
            this.btnListaDelMesero.Text = "Listar";
            this.btnListaDelMesero.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnListaTipoSala);
            this.groupBox2.Controls.Add(this.cboTipoSala);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Location = new System.Drawing.Point(479, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 103);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado Por Sala";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Tipo de Sala";
            // 
            // cboTipoSala
            // 
            this.cboTipoSala.FormattingEnabled = true;
            this.cboTipoSala.ItemHeight = 23;
            this.cboTipoSala.Location = new System.Drawing.Point(138, 19);
            this.cboTipoSala.Name = "cboTipoSala";
            this.cboTipoSala.Size = new System.Drawing.Size(121, 29);
            this.cboTipoSala.TabIndex = 1;
            this.cboTipoSala.UseSelectable = true;
            // 
            // btnListaTipoSala
            // 
            this.btnListaTipoSala.Location = new System.Drawing.Point(138, 67);
            this.btnListaTipoSala.Name = "btnListaTipoSala";
            this.btnListaTipoSala.Size = new System.Drawing.Size(121, 23);
            this.btnListaTipoSala.TabIndex = 2;
            this.btnListaTipoSala.Text = "Listar";
            this.btnListaTipoSala.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnListadoFecha);
            this.groupBox3.Controls.Add(this.dtTermino);
            this.groupBox3.Controls.Add(this.dtInicio);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Location = new System.Drawing.Point(479, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 162);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado Por Fecha";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(26, 38);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(123, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Ingrese Fecha Inicio";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(7, 81);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(142, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Ingrese Fecha Termino";
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(173, 28);
            this.dtInicio.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(161, 29);
            this.dtInicio.TabIndex = 2;
            // 
            // dtTermino
            // 
            this.dtTermino.Location = new System.Drawing.Point(173, 71);
            this.dtTermino.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTermino.Name = "dtTermino";
            this.dtTermino.Size = new System.Drawing.Size(161, 29);
            this.dtTermino.TabIndex = 3;
            // 
            // btnListadoFecha
            // 
            this.btnListadoFecha.Location = new System.Drawing.Point(173, 119);
            this.btnListadoFecha.Name = "btnListadoFecha";
            this.btnListadoFecha.Size = new System.Drawing.Size(161, 27);
            this.btnListadoFecha.TabIndex = 4;
            this.btnListadoFecha.Text = "Listar";
            this.btnListadoFecha.UseSelectable = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnMenosVendodos);
            this.groupBox4.Controls.Add(this.btnMasVendido);
            this.groupBox4.Controls.Add(this.metroLabel6);
            this.groupBox4.Controls.Add(this.metroLabel5);
            this.groupBox4.Location = new System.Drawing.Point(479, 476);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 158);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Producto Mas y Meno Vendido";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(7, 39);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(144, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Producto Mas Vendido";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(7, 97);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(159, 19);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "Producto Menos Vendido";
            // 
            // btnMasVendido
            // 
            this.btnMasVendido.Location = new System.Drawing.Point(199, 35);
            this.btnMasVendido.Name = "btnMasVendido";
            this.btnMasVendido.Size = new System.Drawing.Size(114, 23);
            this.btnMasVendido.TabIndex = 2;
            this.btnMasVendido.Text = "Listar";
            this.btnMasVendido.UseSelectable = true;
            // 
            // btnMenosVendodos
            // 
            this.btnMenosVendodos.Location = new System.Drawing.Point(199, 93);
            this.btnMenosVendodos.Name = "btnMenosVendodos";
            this.btnMenosVendodos.Size = new System.Drawing.Size(114, 23);
            this.btnMenosVendodos.TabIndex = 3;
            this.btnMenosVendodos.Text = "Listar";
            this.btnMenosVendodos.UseSelectable = true;
            // 
            // AdministrarComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 657);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroListView1);
            this.Name = "AdministrarComandas";
            this.Text = "AdministrarComandas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnListaDelMesero;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnListaTipoSala;
        private MetroFramework.Controls.MetroComboBox cboTipoSala;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton btnListadoFecha;
        private MetroFramework.Controls.MetroDateTime dtTermino;
        private MetroFramework.Controls.MetroDateTime dtInicio;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroButton btnMenosVendodos;
        private MetroFramework.Controls.MetroButton btnMasVendido;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}