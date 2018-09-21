namespace discoteque
{
    partial class ListarComanda
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnMenosVendido = new MetroFramework.Controls.MetroButton();
            this.btnMasVendido = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTermino = new MetroFramework.Controls.MetroDateTime();
            this.dateInicio = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnListarFecha = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnListarVip = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnListarMesero = new MetroFramework.Controls.MetroButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.metroLabel2);
            this.groupBox4.Controls.Add(this.metroLabel1);
            this.groupBox4.Controls.Add(this.btnMenosVendido);
            this.groupBox4.Controls.Add(this.btnMasVendido);
            this.groupBox4.Location = new System.Drawing.Point(633, 543);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(225, 124);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Producto Mas y Menos Vendidos";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 67);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Menos Vendido";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Mas Vendido";
            // 
            // btnMenosVendido
            // 
            this.btnMenosVendido.Location = new System.Drawing.Point(151, 67);
            this.btnMenosVendido.Name = "btnMenosVendido";
            this.btnMenosVendido.Size = new System.Drawing.Size(68, 31);
            this.btnMenosVendido.TabIndex = 1;
            this.btnMenosVendido.Text = "Listar";
            this.btnMenosVendido.UseSelectable = true;
            this.btnMenosVendido.Click += new System.EventHandler(this.btnMenosVendido_Click);
            // 
            // btnMasVendido
            // 
            this.btnMasVendido.Location = new System.Drawing.Point(151, 30);
            this.btnMasVendido.Name = "btnMasVendido";
            this.btnMasVendido.Size = new System.Drawing.Size(68, 31);
            this.btnMasVendido.TabIndex = 0;
            this.btnMasVendido.Text = "Listar";
            this.btnMasVendido.UseSelectable = true;
            this.btnMasVendido.Click += new System.EventHandler(this.btnMasVendido_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTermino);
            this.groupBox3.Controls.Add(this.dateInicio);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Controls.Add(this.btnListarFecha);
            this.groupBox3.Location = new System.Drawing.Point(633, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 182);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listar Por Fecha";
            // 
            // dateTermino
            // 
            this.dateTermino.Location = new System.Drawing.Point(142, 75);
            this.dateTermino.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTermino.Name = "dateTermino";
            this.dateTermino.Size = new System.Drawing.Size(200, 29);
            this.dateTermino.TabIndex = 4;
            // 
            // dateInicio
            // 
            this.dateInicio.Location = new System.Drawing.Point(142, 32);
            this.dateInicio.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(200, 29);
            this.dateInicio.TabIndex = 3;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(14, 85);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(113, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Fecha de Termino";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(14, 32);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Fecha de Inicio";
            // 
            // btnListarFecha
            // 
            this.btnListarFecha.Location = new System.Drawing.Point(95, 134);
            this.btnListarFecha.Name = "btnListarFecha";
            this.btnListarFecha.Size = new System.Drawing.Size(114, 31);
            this.btnListarFecha.TabIndex = 0;
            this.btnListarFecha.Text = "Listar";
            this.btnListarFecha.UseSelectable = true;
            this.btnListarFecha.Click += new System.EventHandler(this.btnListarFecha_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnListarVip);
            this.groupBox2.Location = new System.Drawing.Point(633, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 88);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de la sala VIP";
            // 
            // btnListarVip
            // 
            this.btnListarVip.Location = new System.Drawing.Point(121, 33);
            this.btnListarVip.Name = "btnListarVip";
            this.btnListarVip.Size = new System.Drawing.Size(114, 31);
            this.btnListarVip.TabIndex = 0;
            this.btnListarVip.Text = "Listar";
            this.btnListarVip.UseSelectable = true;
            this.btnListarVip.Click += new System.EventHandler(this.btnListarVip_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.btnListarMesero);
            this.groupBox1.Location = new System.Drawing.Point(633, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 106);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar Por Mesero";
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(14, 38);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(172, 23);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(14, 16);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(129, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "Nombre del Mesero";
            // 
            // btnListarMesero
            // 
            this.btnListarMesero.Location = new System.Drawing.Point(222, 56);
            this.btnListarMesero.Name = "btnListarMesero";
            this.btnListarMesero.Size = new System.Drawing.Size(114, 31);
            this.btnListarMesero.TabIndex = 0;
            this.btnListarMesero.Text = "Listar";
            this.btnListarMesero.UseSelectable = true;
            this.btnListarMesero.Click += new System.EventHandler(this.btnListarMesero_Click);
            // 
            // reportViewer1
            // 
            reportDataSource5.Name = "Prodcuto";
            reportDataSource5.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "discoteque.Reportes.reporteBodega.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(26, 84);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(589, 583);
            this.reportViewer1.TabIndex = 6;
            // 
            // ListarComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 751);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ListarComanda";
            this.Text = "ListarComanda";
            this.Load += new System.EventHandler(this.ListarComanda_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnMenosVendido;
        private MetroFramework.Controls.MetroButton btnMasVendido;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroDateTime dateTermino;
        private MetroFramework.Controls.MetroDateTime dateInicio;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnListarFecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnListarVip;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnListarMesero;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}