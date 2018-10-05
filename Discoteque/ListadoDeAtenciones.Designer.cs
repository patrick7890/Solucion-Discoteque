namespace discoteque
{
    partial class ListadoDeAtenciones
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
            this.idatencionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalatencionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioidusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoSalaidtipoSalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desctipoSalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atencionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discotequeDataSet = new discoteque.discotequeDataSet();
            this.atencionTableAdapter = new discoteque.discotequeDataSetTableAdapters.atencionTableAdapter();
            this.btnIngresar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idatencionDataGridViewTextBoxColumn,
            this.totalatencionDataGridViewTextBoxColumn,
            this.faturadaDataGridViewTextBoxColumn,
            this.propinaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.usuarioidusuarioDataGridViewTextBoxColumn,
            this.tipoSalaidtipoSalaDataGridViewTextBoxColumn,
            this.nombreusuarioDataGridViewTextBoxColumn,
            this.desctipoSalaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.atencionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(947, 371);
            this.dataGridView1.TabIndex = 1;
            // 
            // idatencionDataGridViewTextBoxColumn
            // 
            this.idatencionDataGridViewTextBoxColumn.DataPropertyName = "idatencion";
            this.idatencionDataGridViewTextBoxColumn.HeaderText = "idatencion";
            this.idatencionDataGridViewTextBoxColumn.Name = "idatencionDataGridViewTextBoxColumn";
            this.idatencionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalatencionDataGridViewTextBoxColumn
            // 
            this.totalatencionDataGridViewTextBoxColumn.DataPropertyName = "totalatencion";
            this.totalatencionDataGridViewTextBoxColumn.HeaderText = "totalatencion";
            this.totalatencionDataGridViewTextBoxColumn.Name = "totalatencionDataGridViewTextBoxColumn";
            // 
            // faturadaDataGridViewTextBoxColumn
            // 
            this.faturadaDataGridViewTextBoxColumn.DataPropertyName = "faturada";
            this.faturadaDataGridViewTextBoxColumn.HeaderText = "faturada";
            this.faturadaDataGridViewTextBoxColumn.Name = "faturadaDataGridViewTextBoxColumn";
            // 
            // propinaDataGridViewTextBoxColumn
            // 
            this.propinaDataGridViewTextBoxColumn.DataPropertyName = "propina";
            this.propinaDataGridViewTextBoxColumn.HeaderText = "propina";
            this.propinaDataGridViewTextBoxColumn.Name = "propinaDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // usuarioidusuarioDataGridViewTextBoxColumn
            // 
            this.usuarioidusuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario_idusuario";
            this.usuarioidusuarioDataGridViewTextBoxColumn.HeaderText = "usuario_idusuario";
            this.usuarioidusuarioDataGridViewTextBoxColumn.Name = "usuarioidusuarioDataGridViewTextBoxColumn";
            // 
            // tipoSalaidtipoSalaDataGridViewTextBoxColumn
            // 
            this.tipoSalaidtipoSalaDataGridViewTextBoxColumn.DataPropertyName = "tipoSala_idtipoSala";
            this.tipoSalaidtipoSalaDataGridViewTextBoxColumn.HeaderText = "tipoSala_idtipoSala";
            this.tipoSalaidtipoSalaDataGridViewTextBoxColumn.Name = "tipoSalaidtipoSalaDataGridViewTextBoxColumn";
            // 
            // nombreusuarioDataGridViewTextBoxColumn
            // 
            this.nombreusuarioDataGridViewTextBoxColumn.DataPropertyName = "nombreusuario";
            this.nombreusuarioDataGridViewTextBoxColumn.HeaderText = "nombreusuario";
            this.nombreusuarioDataGridViewTextBoxColumn.Name = "nombreusuarioDataGridViewTextBoxColumn";
            // 
            // desctipoSalaDataGridViewTextBoxColumn
            // 
            this.desctipoSalaDataGridViewTextBoxColumn.DataPropertyName = "desctipoSala";
            this.desctipoSalaDataGridViewTextBoxColumn.HeaderText = "desctipoSala";
            this.desctipoSalaDataGridViewTextBoxColumn.Name = "desctipoSalaDataGridViewTextBoxColumn";
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
            // atencionTableAdapter
            // 
            this.atencionTableAdapter.ClearBeforeFill = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(1014, 104);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseSelectable = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1014, 168);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ListadoDeAtenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 480);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListadoDeAtenciones";
            this.Text = "ListadoDeAtenciones";
            this.Load += new System.EventHandler(this.ListadoDeAtenciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private discotequeDataSet discotequeDataSet;
        private System.Windows.Forms.BindingSource atencionBindingSource;
        private discotequeDataSetTableAdapters.atencionTableAdapter atencionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idatencionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalatencionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioidusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoSalaidtipoSalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desctipoSalaDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btnIngresar;
        private MetroFramework.Controls.MetroButton btnEliminar;
    }
}