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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.discotequeDataSet = new discoteque.discotequeDataSet();
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.productoTableAdapter = new discoteque.discotequeDataSetTableAdapters.productoTableAdapter();
            this.atencionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atencionTableAdapter = new discoteque.discotequeDataSetTableAdapters.atencionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atencionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "producto";
            this.bindingSource1.DataSource = this.discotequeDataSet;
            // 
            // discotequeDataSet
            // 
            this.discotequeDataSet.DataSetName = "discotequeDataSet";
            this.discotequeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnListarCritico.Click += new System.EventHandler(this.btnListarCritico_Click);
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
            this.btnListarVIP.Click += new System.EventHandler(this.btnListarVIP_Click);
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
            this.btnTotalMesero.Click += new System.EventHandler(this.btnTotalMesero_Click);
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
            this.btnListarProducto.Click += new System.EventHandler(this.btnListarProducto_Click);
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "Prodcuto";
            reportDataSource3.Value = this.bindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "discoteque.Reportes.reporteBodega.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(512, 531);
            this.reportViewer1.TabIndex = 4;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // atencionBindingSource
            // 
            this.atencionBindingSource.DataMember = "atencion";
            this.atencionBindingSource.DataSource = this.discotequeDataSet;
            // 
            // atencionTableAdapter
            // 
            this.atencionTableAdapter.ClearBeforeFill = true;
            // 
            // ListaBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 694);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListaBodega";
            this.Text = "ListaBodega";
            this.Load += new System.EventHandler(this.ListaBodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.atencionBindingSource)).EndInit();
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
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private discotequeDataSet discotequeDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private discotequeDataSetTableAdapters.productoTableAdapter productoTableAdapter;
        private System.Windows.Forms.BindingSource atencionBindingSource;
        private discotequeDataSetTableAdapters.atencionTableAdapter atencionTableAdapter;
    }
}