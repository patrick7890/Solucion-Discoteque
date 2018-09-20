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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.atencionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discotequeDataSet = new discoteque.discotequeDataSet();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnBodega = new MetroFramework.Controls.MetroButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.atencionTableAdapter = new discoteque.discotequeDataSetTableAdapters.atencionTableAdapter();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.atencionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // atencionBindingSource
            // 
            this.atencionBindingSource.DataMember = "atencion";
            this.atencionBindingSource.DataSource = this.discotequeDataSet;
            // 
            // discotequeDataSet
            // 
            this.discotequeDataSet.DataSetName = "discotequeDataSet";
            this.discotequeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.metroButton1.Location = new System.Drawing.Point(623, 215);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnBodega
            // 
            this.btnBodega.Location = new System.Drawing.Point(623, 270);
            this.btnBodega.Name = "btnBodega";
            this.btnBodega.Size = new System.Drawing.Size(75, 23);
            this.btnBodega.TabIndex = 3;
            this.btnBodega.Text = "ListaBodega";
            this.btnBodega.UseSelectable = true;
            this.btnBodega.Click += new System.EventHandler(this.btnBodega_Click);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "Atencion";
            reportDataSource2.Value = this.atencionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "discoteque.Reportes.atenciones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(37, 81);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(474, 320);
            this.reportViewer1.TabIndex = 4;
            // 
            // atencionTableAdapter
            // 
            this.atencionTableAdapter.ClearBeforeFill = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(623, 330);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "ListaComanda";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(547, 176);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 6;
            this.metroLink1.Text = "metroLink1";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnBodega);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atencionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnBodega;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource atencionBindingSource;
        private discotequeDataSet discotequeDataSet;
        private discotequeDataSetTableAdapters.atencionTableAdapter atencionTableAdapter;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}

