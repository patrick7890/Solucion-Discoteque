namespace discoteque
{
    partial class ListaBodega
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListarCritico = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnListarVIP = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTotalMesero = new MetroFramework.Controls.MetroButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnProductoDeBaja = new MetroFramework.Controls.MetroButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnListarProducto = new MetroFramework.Controls.MetroButton();
            this.panel1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.discotequeDataSetData = new discoteque.discotequeDataSetData();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new discoteque.discotequeDataSetDataTableAdapters.productoTableAdapter();
            this.tipoproductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoproductoTableAdapter = new discoteque.discotequeDataSetDataTableAdapters.tipoproductoTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSetData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoproductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListarCritico);
            this.groupBox1.Location = new System.Drawing.Point(631, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar Stock Critico";
            // 
            // btnListarCritico
            // 
            this.btnListarCritico.Location = new System.Drawing.Point(41, 30);
            this.btnListarCritico.Name = "btnListarCritico";
            this.btnListarCritico.Size = new System.Drawing.Size(114, 31);
            this.btnListarCritico.TabIndex = 0;
            this.btnListarCritico.Text = "Listar";
            this.btnListarCritico.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnListarVIP);
            this.groupBox2.Location = new System.Drawing.Point(631, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 88);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consumo Sala VIP";
            // 
            // btnListarVIP
            // 
            this.btnListarVIP.Location = new System.Drawing.Point(41, 30);
            this.btnListarVIP.Name = "btnListarVIP";
            this.btnListarVIP.Size = new System.Drawing.Size(114, 31);
            this.btnListarVIP.TabIndex = 0;
            this.btnListarVIP.Text = "Listar";
            this.btnListarVIP.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTotalMesero);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(631, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 88);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total a pagar al Mesero";
            // 
            // btnTotalMesero
            // 
            this.btnTotalMesero.Location = new System.Drawing.Point(41, 30);
            this.btnTotalMesero.Name = "btnTotalMesero";
            this.btnTotalMesero.Size = new System.Drawing.Size(114, 31);
            this.btnTotalMesero.TabIndex = 0;
            this.btnTotalMesero.Text = "Listar";
            this.btnTotalMesero.UseSelectable = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnProductoDeBaja);
            this.groupBox4.Location = new System.Drawing.Point(631, 506);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 88);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Productos Dados de Baja";
            // 
            // btnProductoDeBaja
            // 
            this.btnProductoDeBaja.Location = new System.Drawing.Point(41, 30);
            this.btnProductoDeBaja.Name = "btnProductoDeBaja";
            this.btnProductoDeBaja.Size = new System.Drawing.Size(114, 31);
            this.btnProductoDeBaja.TabIndex = 0;
            this.btnProductoDeBaja.Text = "Listar";
            this.btnProductoDeBaja.UseSelectable = true;
            this.btnProductoDeBaja.Click += new System.EventHandler(this.btnProductoDeBaja_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnListarProducto);
            this.groupBox5.Location = new System.Drawing.Point(631, 397);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(180, 88);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Productos";
            // 
            // btnListarProducto
            // 
            this.btnListarProducto.Location = new System.Drawing.Point(41, 30);
            this.btnListarProducto.Name = "btnListarProducto";
            this.btnListarProducto.Size = new System.Drawing.Size(114, 31);
            this.btnListarProducto.TabIndex = 0;
            this.btnListarProducto.Text = "Listar";
            this.btnListarProducto.UseSelectable = true;
            // 
            // panel1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.productoBindingSource;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this.tipoproductoBindingSource;
            this.panel1.LocalReport.DataSources.Add(reportDataSource3);
            this.panel1.LocalReport.DataSources.Add(reportDataSource4);
            this.panel1.LocalReport.ReportEmbeddedResource = "discoteque.Reportes.ProductosDadosBaja.rdlc";
            this.panel1.Location = new System.Drawing.Point(13, 63);
            this.panel1.Name = "panel1";
            this.panel1.ServerReport.BearerToken = null;
            this.panel1.Size = new System.Drawing.Size(510, 558);
            this.panel1.TabIndex = 5;
            // 
            // discotequeDataSetData
            // 
            this.discotequeDataSetData.DataSetName = "discotequeDataSetData";
            this.discotequeDataSetData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.discotequeDataSetData;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // tipoproductoBindingSource
            // 
            this.tipoproductoBindingSource.DataMember = "tipoproducto";
            this.tipoproductoBindingSource.DataSource = this.discotequeDataSetData;
            // 
            // tipoproductoTableAdapter
            // 
            this.tipoproductoTableAdapter.ClearBeforeFill = true;
            // 
            // ListaBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 694);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListaBodega";
            this.Text = "ListaBodega";
            this.Load += new System.EventHandler(this.ListaBodega_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSetData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoproductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnListarCritico;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnListarVIP;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton btnTotalMesero;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroButton btnProductoDeBaja;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroButton btnListarProducto;
        private Microsoft.Reporting.WinForms.ReportViewer panel1;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private discotequeDataSetData discotequeDataSetData;
        private System.Windows.Forms.BindingSource tipoproductoBindingSource;
        private discotequeDataSetDataTableAdapters.productoTableAdapter productoTableAdapter;
        private discotequeDataSetDataTableAdapters.tipoproductoTableAdapter tipoproductoTableAdapter;
    }
}