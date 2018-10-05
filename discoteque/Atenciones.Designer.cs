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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atencionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearAtencionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblN = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.atencionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discotequeDataSet = new discoteque.discotequeDataSet();
            this.comandaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comandaTableAdapter = new discoteque.discotequeDataSetTableAdapters.comandaTableAdapter();
            this.atencionTableAdapter = new discoteque.discotequeDataSetTableAdapters.atencionTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.idatencionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desctipoSalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalatencionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atencionToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(749, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // atencionToolStripMenuItem
            // 
            this.atencionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearAtencionToolStripMenuItem});
            this.atencionToolStripMenuItem.Name = "atencionToolStripMenuItem";
            this.atencionToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.atencionToolStripMenuItem.Text = "Atencion";
            // 
            // crearAtencionToolStripMenuItem
            // 
            this.crearAtencionToolStripMenuItem.Name = "crearAtencionToolStripMenuItem";
            this.crearAtencionToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.crearAtencionToolStripMenuItem.Text = "Crear Atencion";
            this.crearAtencionToolStripMenuItem.Click += new System.EventHandler(this.crearAtencionToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
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
            this.lblid.Location = new System.Drawing.Point(156, 32);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idatencionDataGridViewTextBoxColumn,
            this.nombreusuarioDataGridViewTextBoxColumn,
            this.desctipoSalaDataGridViewTextBoxColumn,
            this.totalatencionDataGridViewTextBoxColumn,
            this.propinaDataGridViewTextBoxColumn,
            this.faturadaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.atencionBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 334);
            this.dataGridView1.TabIndex = 16;
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // idatencionDataGridViewTextBoxColumn
            // 
            this.idatencionDataGridViewTextBoxColumn.DataPropertyName = "idatencion";
            this.idatencionDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idatencionDataGridViewTextBoxColumn.Name = "idatencionDataGridViewTextBoxColumn";
            this.idatencionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreusuarioDataGridViewTextBoxColumn
            // 
            this.nombreusuarioDataGridViewTextBoxColumn.DataPropertyName = "nombreusuario";
            this.nombreusuarioDataGridViewTextBoxColumn.HeaderText = "Mesero";
            this.nombreusuarioDataGridViewTextBoxColumn.Name = "nombreusuarioDataGridViewTextBoxColumn";
            // 
            // desctipoSalaDataGridViewTextBoxColumn
            // 
            this.desctipoSalaDataGridViewTextBoxColumn.DataPropertyName = "desctipoSala";
            this.desctipoSalaDataGridViewTextBoxColumn.HeaderText = "Sala";
            this.desctipoSalaDataGridViewTextBoxColumn.Name = "desctipoSalaDataGridViewTextBoxColumn";
            // 
            // totalatencionDataGridViewTextBoxColumn
            // 
            this.totalatencionDataGridViewTextBoxColumn.DataPropertyName = "totalatencion";
            this.totalatencionDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalatencionDataGridViewTextBoxColumn.Name = "totalatencionDataGridViewTextBoxColumn";
            // 
            // propinaDataGridViewTextBoxColumn
            // 
            this.propinaDataGridViewTextBoxColumn.DataPropertyName = "propina";
            this.propinaDataGridViewTextBoxColumn.HeaderText = "Propina";
            this.propinaDataGridViewTextBoxColumn.Name = "propinaDataGridViewTextBoxColumn";
            // 
            // faturadaDataGridViewTextBoxColumn
            // 
            this.faturadaDataGridViewTextBoxColumn.DataPropertyName = "faturada";
            this.faturadaDataGridViewTextBoxColumn.HeaderText = "Faturada";
            this.faturadaDataGridViewTextBoxColumn.Name = "faturadaDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // Atenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 438);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Atenciones";
            this.Text = "Atenciones";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Atenciones_FormClosing);
            this.Load += new System.EventHandler(this.Atenciones_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atencionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearAtencionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.Label lblN;
        private discotequeDataSet discotequeDataSet;
        private System.Windows.Forms.BindingSource comandaBindingSource;
        private discotequeDataSetTableAdapters.comandaTableAdapter comandaTableAdapter;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource atencionBindingSource;
        private discotequeDataSetTableAdapters.atencionTableAdapter atencionTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idatencionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desctipoSalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalatencionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
    }
}