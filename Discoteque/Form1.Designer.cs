namespace discoteque
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnBodega = new MetroFramework.Controls.MetroButton();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.discotequeDataSet = new discoteque.discotequeDataSet();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new discoteque.discotequeDataSetTableAdapters.productoTableAdapter();
            this.tipoproductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoproductoTableAdapter = new discoteque.discotequeDataSetTableAdapters.tipoproductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoproductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(607, 90);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(134, 38);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(637, 242);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnBodega
            // 
            this.btnBodega.Location = new System.Drawing.Point(646, 325);
            this.btnBodega.Name = "btnBodega";
            this.btnBodega.Size = new System.Drawing.Size(75, 23);
            this.btnBodega.TabIndex = 3;
            this.btnBodega.Text = "ListaBodega";
            this.btnBodega.UseSelectable = true;
            this.btnBodega.Click += new System.EventHandler(this.btnBodega_Click);
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "Prodcuto";
            reportDataSource1.Value = this.productoBindingSource;
            reportDataSource2.Name = "TiposP";
            reportDataSource2.Value = this.tipoproductoBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "discoteque.Reportes.reporteBodega.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(23, 90);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(488, 309);
            this.reportViewer2.TabIndex = 5;
            // 
            // discotequeDataSet
            // 
            this.discotequeDataSet.DataSetName = "discotequeDataSet";
            this.discotequeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.discotequeDataSet;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // tipoproductoBindingSource
            // 
            this.tipoproductoBindingSource.DataMember = "tipoproducto";
            this.tipoproductoBindingSource.DataSource = this.discotequeDataSet;
            // 
            // tipoproductoTableAdapter
            // 
            this.tipoproductoTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.btnBodega);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoproductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnBodega;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private discotequeDataSet discotequeDataSet;
        private System.Windows.Forms.BindingSource tipoproductoBindingSource;
        private discotequeDataSetTableAdapters.productoTableAdapter productoTableAdapter;
        private discotequeDataSetTableAdapters.tipoproductoTableAdapter tipoproductoTableAdapter;
    }
}

