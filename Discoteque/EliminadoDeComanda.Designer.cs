namespace discoteque
{
    partial class EliminadoDeComanda
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
            this.discotequeDataSet = new discoteque.discotequeDataSet();
            this.comandaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comandaTableAdapter = new discoteque.discotequeDataSetTableAdapters.comandaTableAdapter();
            this.idcomandaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcomandaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atencionidatencionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atencionusuarioidusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcomandaDataGridViewTextBoxColumn,
            this.totalcomandaDataGridViewTextBoxColumn,
            this.atencionidatencionDataGridViewTextBoxColumn,
            this.atencionusuarioidusuarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.comandaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 289);
            this.dataGridView1.TabIndex = 0;
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
            // idcomandaDataGridViewTextBoxColumn
            // 
            this.idcomandaDataGridViewTextBoxColumn.DataPropertyName = "idcomanda";
            this.idcomandaDataGridViewTextBoxColumn.HeaderText = "idcomanda";
            this.idcomandaDataGridViewTextBoxColumn.Name = "idcomandaDataGridViewTextBoxColumn";
            this.idcomandaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalcomandaDataGridViewTextBoxColumn
            // 
            this.totalcomandaDataGridViewTextBoxColumn.DataPropertyName = "totalcomanda";
            this.totalcomandaDataGridViewTextBoxColumn.HeaderText = "totalcomanda";
            this.totalcomandaDataGridViewTextBoxColumn.Name = "totalcomandaDataGridViewTextBoxColumn";
            // 
            // atencionidatencionDataGridViewTextBoxColumn
            // 
            this.atencionidatencionDataGridViewTextBoxColumn.DataPropertyName = "atencion_idatencion";
            this.atencionidatencionDataGridViewTextBoxColumn.HeaderText = "atencion_idatencion";
            this.atencionidatencionDataGridViewTextBoxColumn.Name = "atencionidatencionDataGridViewTextBoxColumn";
            // 
            // atencionusuarioidusuarioDataGridViewTextBoxColumn
            // 
            this.atencionusuarioidusuarioDataGridViewTextBoxColumn.DataPropertyName = "atencion_usuario_idusuario";
            this.atencionusuarioidusuarioDataGridViewTextBoxColumn.HeaderText = "atencion_usuario_idusuario";
            this.atencionusuarioidusuarioDataGridViewTextBoxColumn.Name = "atencionusuarioidusuarioDataGridViewTextBoxColumn";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(560, 104);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 33);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // EliminadoDeComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EliminadoDeComanda";
            this.Text = "EliminadoDeComanda";
            this.Load += new System.EventHandler(this.EliminadoDeComanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private discotequeDataSet discotequeDataSet;
        private System.Windows.Forms.BindingSource comandaBindingSource;
        private discotequeDataSetTableAdapters.comandaTableAdapter comandaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomandaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcomandaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atencionidatencionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atencionusuarioidusuarioDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btnEliminar;
    }
}