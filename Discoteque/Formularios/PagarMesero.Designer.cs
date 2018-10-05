namespace discoteque.Formularios
{
    partial class PagarMesero
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.atencionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discotequeDataSet = new discoteque.discotequeDataSet();
            this.cboMesero = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new discoteque.discotequeDataSetTableAdapters.usuarioTableAdapter();
            this.atencionTableAdapter = new discoteque.discotequeDataSetTableAdapters.atencionTableAdapter();
            this.nombreusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalatencionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desctipoSalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreusuarioDataGridViewTextBoxColumn,
            this.totalatencionDataGridViewTextBoxColumn,
            this.propinaDataGridViewTextBoxColumn,
            this.desctipoSalaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.atencionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 309);
            this.dataGridView1.TabIndex = 0;
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
            // cboMesero
            // 
            this.cboMesero.DataSource = this.usuarioBindingSource;
            this.cboMesero.DisplayMember = "nombreusuario";
            this.cboMesero.FormattingEnabled = true;
            this.cboMesero.Location = new System.Drawing.Point(582, 114);
            this.cboMesero.Name = "cboMesero";
            this.cboMesero.Size = new System.Drawing.Size(121, 21);
            this.cboMesero.TabIndex = 1;
            this.cboMesero.ValueMember = "idusuario";
            this.cboMesero.SelectedIndexChanged += new System.EventHandler(this.cboMesero_SelectedIndexChanged);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.discotequeDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // atencionTableAdapter
            // 
            this.atencionTableAdapter.ClearBeforeFill = true;
            // 
            // nombreusuarioDataGridViewTextBoxColumn
            // 
            this.nombreusuarioDataGridViewTextBoxColumn.DataPropertyName = "nombreusuario";
            this.nombreusuarioDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreusuarioDataGridViewTextBoxColumn.Name = "nombreusuarioDataGridViewTextBoxColumn";
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
            // desctipoSalaDataGridViewTextBoxColumn
            // 
            this.desctipoSalaDataGridViewTextBoxColumn.DataPropertyName = "desctipoSala";
            this.desctipoSalaDataGridViewTextBoxColumn.HeaderText = "Sala";
            this.desctipoSalaDataGridViewTextBoxColumn.Name = "desctipoSalaDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // PagarMesero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboMesero);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PagarMesero";
            this.Text = "PagarMesero";
            this.Load += new System.EventHandler(this.PagarMesero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboMesero;
        private discotequeDataSet discotequeDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private discotequeDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.BindingSource atencionBindingSource;
        private discotequeDataSetTableAdapters.atencionTableAdapter atencionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalatencionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desctipoSalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
    }
}