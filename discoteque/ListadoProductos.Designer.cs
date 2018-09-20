namespace discoteque
{
    partial class ListadoProductos
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
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discotequeDataSet = new discoteque.discotequeDataSet();
            this.productoTableAdapter = new discoteque.discotequeDataSetTableAdapters.productoTableAdapter();
            this.discotequeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.discotequeDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.discotequeDataSetData = new discoteque.discotequeDataSetData();
            this.discotequeDataSetDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atencionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atencionTableAdapter = new discoteque.discotequeDataSetDataTableAdapters.atencionTableAdapter();
            this.tipoproductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoproductoTableAdapter = new discoteque.discotequeDataSetDataTableAdapters.tipoproductoTableAdapter();
            this.productoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter1 = new discoteque.discotequeDataSetDataTableAdapters.productoTableAdapter();
            this.idproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProductoidtipoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSetData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSetDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoproductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource4)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductoDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.enVentaDataGridViewTextBoxColumn,
            this.tipoProductoidtipoProductoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productoBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(23, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 252);
            this.dataGridView1.TabIndex = 0;
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
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // discotequeDataSetBindingSource
            // 
            this.discotequeDataSetBindingSource.DataSource = this.discotequeDataSet;
            this.discotequeDataSetBindingSource.Position = 0;
            // 
            // productoBindingSource1
            // 
            this.productoBindingSource1.DataMember = "producto";
            this.productoBindingSource1.DataSource = this.discotequeDataSetBindingSource;
            // 
            // discotequeDataSetBindingSource1
            // 
            this.discotequeDataSetBindingSource1.DataSource = this.discotequeDataSet;
            this.discotequeDataSetBindingSource1.Position = 0;
            // 
            // productoBindingSource2
            // 
            this.productoBindingSource2.DataMember = "producto";
            this.productoBindingSource2.DataSource = this.discotequeDataSet;
            // 
            // productoBindingSource3
            // 
            this.productoBindingSource3.DataMember = "producto";
            this.productoBindingSource3.DataSource = this.discotequeDataSetBindingSource;
            // 
            // discotequeDataSetData
            // 
            this.discotequeDataSetData.DataSetName = "discotequeDataSetData";
            this.discotequeDataSetData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // discotequeDataSetDataBindingSource
            // 
            this.discotequeDataSetDataBindingSource.DataSource = this.discotequeDataSetData;
            this.discotequeDataSetDataBindingSource.Position = 0;
            // 
            // atencionBindingSource
            // 
            this.atencionBindingSource.DataMember = "atencion";
            this.atencionBindingSource.DataSource = this.discotequeDataSetDataBindingSource;
            // 
            // atencionTableAdapter
            // 
            this.atencionTableAdapter.ClearBeforeFill = true;
            // 
            // tipoproductoBindingSource
            // 
            this.tipoproductoBindingSource.DataMember = "tipoproducto";
            this.tipoproductoBindingSource.DataSource = this.discotequeDataSetDataBindingSource;
            // 
            // tipoproductoTableAdapter
            // 
            this.tipoproductoTableAdapter.ClearBeforeFill = true;
            // 
            // productoBindingSource4
            // 
            this.productoBindingSource4.DataMember = "producto";
            this.productoBindingSource4.DataSource = this.discotequeDataSetData;
            // 
            // productoTableAdapter1
            // 
            this.productoTableAdapter1.ClearBeforeFill = true;
            // 
            // idproductoDataGridViewTextBoxColumn
            // 
            this.idproductoDataGridViewTextBoxColumn.DataPropertyName = "idproducto";
            this.idproductoDataGridViewTextBoxColumn.HeaderText = "idproducto";
            this.idproductoDataGridViewTextBoxColumn.Name = "idproductoDataGridViewTextBoxColumn";
            this.idproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            this.nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "nombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.HeaderText = "nombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // enVentaDataGridViewTextBoxColumn
            // 
            this.enVentaDataGridViewTextBoxColumn.DataPropertyName = "enVenta";
            this.enVentaDataGridViewTextBoxColumn.HeaderText = "enVenta";
            this.enVentaDataGridViewTextBoxColumn.Name = "enVentaDataGridViewTextBoxColumn";
            // 
            // tipoProductoidtipoProductoDataGridViewTextBoxColumn
            // 
            this.tipoProductoidtipoProductoDataGridViewTextBoxColumn.DataPropertyName = "tipoProducto_idtipoProducto";
            this.tipoProductoidtipoProductoDataGridViewTextBoxColumn.HeaderText = "tipoProducto_idtipoProducto";
            this.tipoProductoidtipoProductoDataGridViewTextBoxColumn.Name = "tipoProductoidtipoProductoDataGridViewTextBoxColumn";
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(111, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // ListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListadoProductos";
            this.Text = "ListadoProductos";
            this.Load += new System.EventHandler(this.ListadoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSetData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSetDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoproductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource4)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private discotequeDataSet discotequeDataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private discotequeDataSetTableAdapters.productoTableAdapter productoTableAdapter;
        private System.Windows.Forms.BindingSource productoBindingSource1;
        private System.Windows.Forms.BindingSource discotequeDataSetBindingSource;
        private System.Windows.Forms.BindingSource discotequeDataSetBindingSource1;
        private System.Windows.Forms.BindingSource productoBindingSource2;
        private System.Windows.Forms.BindingSource productoBindingSource3;
        private System.Windows.Forms.BindingSource discotequeDataSetDataBindingSource;
        private discotequeDataSetData discotequeDataSetData;
        private System.Windows.Forms.BindingSource atencionBindingSource;
        private discotequeDataSetDataTableAdapters.atencionTableAdapter atencionTableAdapter;
        private System.Windows.Forms.BindingSource tipoproductoBindingSource;
        private discotequeDataSetDataTableAdapters.tipoproductoTableAdapter tipoproductoTableAdapter;
        private System.Windows.Forms.BindingSource productoBindingSource4;
        private discotequeDataSetDataTableAdapters.productoTableAdapter productoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProductoidtipoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}