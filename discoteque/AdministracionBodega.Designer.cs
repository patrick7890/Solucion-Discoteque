namespace discoteque
{
    partial class AdministracionBodega
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
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.btnCritico = new MetroFramework.Controls.MetroButton();
            this.btnConsumo = new MetroFramework.Controls.MetroButton();
            this.btnPagarMesero = new MetroFramework.Controls.MetroButton();
            this.btnListProducto = new MetroFramework.Controls.MetroButton();
            this.ListadoProducBaja = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroListView1
            // 
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(23, 106);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(526, 309);
            this.metroListView1.TabIndex = 0;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            // 
            // btnCritico
            // 
            this.btnCritico.Location = new System.Drawing.Point(575, 106);
            this.btnCritico.Name = "btnCritico";
            this.btnCritico.Size = new System.Drawing.Size(202, 40);
            this.btnCritico.TabIndex = 1;
            this.btnCritico.Text = "Stock Critico";
            this.btnCritico.UseSelectable = true;
            // 
            // btnConsumo
            // 
            this.btnConsumo.Location = new System.Drawing.Point(575, 152);
            this.btnConsumo.Name = "btnConsumo";
            this.btnConsumo.Size = new System.Drawing.Size(202, 40);
            this.btnConsumo.TabIndex = 2;
            this.btnConsumo.Text = "Listado de Consumo";
            this.btnConsumo.UseSelectable = true;
            // 
            // btnPagarMesero
            // 
            this.btnPagarMesero.Location = new System.Drawing.Point(575, 198);
            this.btnPagarMesero.Name = "btnPagarMesero";
            this.btnPagarMesero.Size = new System.Drawing.Size(202, 40);
            this.btnPagarMesero.TabIndex = 3;
            this.btnPagarMesero.Text = "Total a Pagar a Mesero";
            this.btnPagarMesero.UseSelectable = true;
            // 
            // btnListProducto
            // 
            this.btnListProducto.Location = new System.Drawing.Point(575, 244);
            this.btnListProducto.Name = "btnListProducto";
            this.btnListProducto.Size = new System.Drawing.Size(202, 40);
            this.btnListProducto.TabIndex = 4;
            this.btnListProducto.Text = "Listado de Producto";
            this.btnListProducto.UseSelectable = true;
            // 
            // ListadoProducBaja
            // 
            this.ListadoProducBaja.Location = new System.Drawing.Point(575, 290);
            this.ListadoProducBaja.Name = "ListadoProducBaja";
            this.ListadoProducBaja.Size = new System.Drawing.Size(202, 40);
            this.ListadoProducBaja.TabIndex = 5;
            this.ListadoProducBaja.Text = "Listado de Producto dados de Baja";
            this.ListadoProducBaja.UseSelectable = true;
            this.ListadoProducBaja.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // AdministracionBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListadoProducBaja);
            this.Controls.Add(this.btnListProducto);
            this.Controls.Add(this.btnPagarMesero);
            this.Controls.Add(this.btnConsumo);
            this.Controls.Add(this.btnCritico);
            this.Controls.Add(this.metroListView1);
            this.Name = "AdministracionBodega";
            this.Text = "AdministracionBodega";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView metroListView1;
        private MetroFramework.Controls.MetroButton btnCritico;
        private MetroFramework.Controls.MetroButton btnConsumo;
        private MetroFramework.Controls.MetroButton btnPagarMesero;
        private MetroFramework.Controls.MetroButton btnListProducto;
        private MetroFramework.Controls.MetroButton ListadoProducBaja;
    }
}