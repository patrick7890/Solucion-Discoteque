﻿namespace discoteque.Formularios
{
    partial class CrearAtencion
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cboTipoSala = new MetroFramework.Controls.MetroComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.discotequeDataSet = new discoteque.discotequeDataSet();
            this.atencionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atencionTableAdapter = new discoteque.discotequeDataSetTableAdapters.atencionTableAdapter();
            this.tiposalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposalaTableAdapter = new discoteque.discotequeDataSetTableAdapters.tiposalaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposalaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(84, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(134, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Ingrese el tipo se sala";
            // 
            // cboTipoSala
            // 
            this.cboTipoSala.DataSource = this.tiposalaBindingSource;
            this.cboTipoSala.DisplayMember = "desctipoSala";
            this.cboTipoSala.FormattingEnabled = true;
            this.cboTipoSala.ItemHeight = 23;
            this.cboTipoSala.Location = new System.Drawing.Point(84, 115);
            this.cboTipoSala.Name = "cboTipoSala";
            this.cboTipoSala.Size = new System.Drawing.Size(174, 29);
            this.cboTipoSala.TabIndex = 1;
            this.cboTipoSala.UseSelectable = true;
            this.cboTipoSala.ValueMember = "idtipoSala";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(109, 198);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(138, 33);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // discotequeDataSet
            // 
            this.discotequeDataSet.DataSetName = "discotequeDataSet";
            this.discotequeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tiposalaBindingSource
            // 
            this.tiposalaBindingSource.DataMember = "tiposala";
            this.tiposalaBindingSource.DataSource = this.discotequeDataSet;
            // 
            // tiposalaTableAdapter
            // 
            this.tiposalaTableAdapter.ClearBeforeFill = true;
            // 
            // CrearAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 297);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.cboTipoSala);
            this.Controls.Add(this.metroLabel1);
            this.Name = "CrearAtencion";
            this.Text = "CrearAtencion";
            this.Load += new System.EventHandler(this.CrearAtencion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposalaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cboTipoSala;
        private System.Windows.Forms.Button btnCrear;
        private discotequeDataSet discotequeDataSet;
        private System.Windows.Forms.BindingSource atencionBindingSource;
        private discotequeDataSetTableAdapters.atencionTableAdapter atencionTableAdapter;
        private System.Windows.Forms.BindingSource tiposalaBindingSource;
        private discotequeDataSetTableAdapters.tiposalaTableAdapter tiposalaTableAdapter;
    }
}