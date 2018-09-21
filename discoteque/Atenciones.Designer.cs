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
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarComandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblN = new System.Windows.Forms.Label();
            this.discotequeDataSet = new discoteque.discotequeDataSet();
            this.comandaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comandaTableAdapter = new discoteque.discotequeDataSetTableAdapters.comandaTableAdapter();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // atencionToolStripMenuItem
            // 
            this.atencionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearAtencionToolStripMenuItem,
            this.eliminarToolStripMenuItem,
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
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // agregarComandaToolStripMenuItem
            // 
            this.agregarComandaToolStripMenuItem.Name = "agregarComandaToolStripMenuItem";
            this.agregarComandaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.agregarComandaToolStripMenuItem.Text = "Agregar Comanda";
            this.agregarComandaToolStripMenuItem.Click += new System.EventHandler(this.agregarComandaToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(153, 32);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(0, 13);
            this.lblN.TabIndex = 13;
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
            // Atenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 438);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Atenciones";
            this.Text = "Atenciones";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Atenciones_FormClosing);
            this.Load += new System.EventHandler(this.Atenciones_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atencionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearAtencionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.ToolStripMenuItem agregarComandaToolStripMenuItem;
        private discotequeDataSet discotequeDataSet;
        private System.Windows.Forms.BindingSource comandaBindingSource;
        private discotequeDataSetTableAdapters.comandaTableAdapter comandaTableAdapter;
    }
}