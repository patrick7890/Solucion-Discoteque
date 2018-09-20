namespace discoteque
{
    partial class Atenciones
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCrearAtencion = new MetroFramework.Controls.MetroButton();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = null;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = null;
            this.panel1.LocalReport.DataSources.Add(reportDataSource1);
            this.panel1.LocalReport.DataSources.Add(reportDataSource2);
            this.panel1.LocalReport.ReportEmbeddedResource = "discoteque.Reportes.ProductosDadosBaja.rdlc";
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.ServerReport.BearerToken = null;
            this.panel1.Size = new System.Drawing.Size(634, 332);
            this.panel1.TabIndex = 6;
            // 
            // btnCrearAtencion
            // 
            this.btnCrearAtencion.Location = new System.Drawing.Point(689, 77);
            this.btnCrearAtencion.Name = "btnCrearAtencion";
            this.btnCrearAtencion.Size = new System.Drawing.Size(109, 23);
            this.btnCrearAtencion.TabIndex = 7;
            this.btnCrearAtencion.Text = "Crear Atencion";
            this.btnCrearAtencion.UseSelectable = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(689, 349);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseSelectable = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(689, 129);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseSelectable = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(689, 179);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            // 
            // Atenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 438);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrearAtencion);
            this.Controls.Add(this.panel1);
            this.Name = "Atenciones";
            this.Text = "Atenciones";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer panel1;
        private MetroFramework.Controls.MetroButton btnCrearAtencion;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroButton btnModificar;
        private MetroFramework.Controls.MetroButton btnEliminar;
    }
}