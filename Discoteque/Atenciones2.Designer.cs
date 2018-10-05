namespace discoteque
{
    partial class Atenciones2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atencionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearAtencionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarComandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarAtencionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblN = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discotequeDataSet = new discoteque.discotequeDataSet();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.comandaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comandaTableAdapter = new discoteque.discotequeDataSetTableAdapters.comandaTableAdapter();
            this.atencionTableAdapter = new discoteque.discotequeDataSetTableAdapters.atencionTableAdapter();
            this.productoTableAdapter = new discoteque.discotequeDataSetTableAdapters.productoTableAdapter();
            this.atencionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPropina = new System.Windows.Forms.Label();
            this.lbltp = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atencionToolStripMenuItem,
            this.finalizarAtencionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // atencionToolStripMenuItem
            // 
            this.atencionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearAtencionToolStripMenuItem,
            this.agregarComandaToolStripMenuItem});
            this.atencionToolStripMenuItem.Name = "atencionToolStripMenuItem";
            this.atencionToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.atencionToolStripMenuItem.Text = "Atencion";
            // 
            // crearAtencionToolStripMenuItem
            // 
            this.crearAtencionToolStripMenuItem.Name = "crearAtencionToolStripMenuItem";
            this.crearAtencionToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.crearAtencionToolStripMenuItem.Text = "Crear Atencion";
            this.crearAtencionToolStripMenuItem.Click += new System.EventHandler(this.crearAtencionToolStripMenuItem_Click);
            // 
            // agregarComandaToolStripMenuItem
            // 
            this.agregarComandaToolStripMenuItem.Name = "agregarComandaToolStripMenuItem";
            this.agregarComandaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.agregarComandaToolStripMenuItem.Text = "Agregar Comanda";
            this.agregarComandaToolStripMenuItem.Click += new System.EventHandler(this.agregarComandaToolStripMenuItem_Click);
            // 
            // finalizarAtencionToolStripMenuItem
            // 
            this.finalizarAtencionToolStripMenuItem.Name = "finalizarAtencionToolStripMenuItem";
            this.finalizarAtencionToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.finalizarAtencionToolStripMenuItem.Text = "Finalizar Atencion";
            this.finalizarAtencionToolStripMenuItem.Click += new System.EventHandler(this.finalizarAtencionToolStripMenuItem_Click);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(153, 32);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(0, 13);
            this.lblN.TabIndex = 13;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(147, 32);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 15;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(160, 31);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 13);
            this.lblA.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreProductoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(245, 294);
            this.dataGridView1.TabIndex = 17;
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            this.nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "nombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            this.nombreProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.discotequeDataSet;
            // 
            // discotequeDataSet
            // 
            this.discotequeDataSet.DataSetName = "discotequeDataSet";
            this.discotequeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTotal.Location = new System.Drawing.Point(435, 131);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 0);
            this.lblTotal.TabIndex = 19;
            // 
            // comandaBindingSource
            // 
            this.comandaBindingSource.DataMember = "comanda";
            this.comandaBindingSource.DataSource = this.discotequeDataSet;
            // 
            // comandaTableAdapter
            // 
            this.comandaTableAdapter.ClearBeforeFill = true;
            // 
            // atencionTableAdapter
            // 
            this.atencionTableAdapter.ClearBeforeFill = true;
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
            // lblPropina
            // 
            this.lblPropina.AutoSize = true;
            this.lblPropina.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropina.Location = new System.Drawing.Point(458, 179);
            this.lblPropina.Name = "lblPropina";
            this.lblPropina.Size = new System.Drawing.Size(26, 29);
            this.lblPropina.TabIndex = 20;
            this.lblPropina.Text = "0";
            // 
            // lbltp
            // 
            this.lbltp.AutoSize = true;
            this.lbltp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltp.Location = new System.Drawing.Point(352, 218);
            this.lbltp.Name = "lbltp";
            this.lbltp.Size = new System.Drawing.Size(197, 29);
            this.lbltp.TabIndex = 21;
            this.lbltp.Text = "Total+Propina : 0";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumo.Location = new System.Drawing.Point(352, 150);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(141, 29);
            this.lblConsumo.TabIndex = 22;
            this.lblConsumo.Text = "Consumo :0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Propina :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Atenciones2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.lbltp);
            this.Controls.Add(this.lblPropina);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Atenciones2";
            this.Text = "Atencion n°";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Atenciones_FormClosing);
            this.Load += new System.EventHandler(this.Atenciones_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atencionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearAtencionToolStripMenuItem;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.ToolStripMenuItem agregarComandaToolStripMenuItem;
        private discotequeDataSet discotequeDataSet;
        private System.Windows.Forms.BindingSource comandaBindingSource;
        private discotequeDataSetTableAdapters.comandaTableAdapter comandaTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem finalizarAtencionToolStripMenuItem;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblA;
        private discotequeDataSetTableAdapters.atencionTableAdapter atencionTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private discotequeDataSetTableAdapters.productoTableAdapter productoTableAdapter;
        private System.Windows.Forms.BindingSource atencionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblPropina;
        private System.Windows.Forms.Label lbltp;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.Label label1;
    }
}