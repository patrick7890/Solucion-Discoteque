namespace discoteque.Formularios
{
    partial class AgregarUsuario
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.txtNombreUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.txtPass2 = new MetroFramework.Controls.MetroTextBox();
            this.cboTipo = new MetroFramework.Controls.MetroComboBox();
            this.tipousuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discotequeDataSet = new discoteque.discotequeDataSet();
            this.tipousuarioTableAdapter = new discoteque.discotequeDataSetTableAdapters.tipousuarioTableAdapter();
            this.btnAgregarUsu = new MetroFramework.Controls.MetroButton();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new discoteque.discotequeDataSetTableAdapters.usuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tipousuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(60, 113);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nombre";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(60, 201);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Contraseña";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(60, 155);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(126, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Nombre de Usuario";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(60, 248);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(116, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Repita Contraseña";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(60, 301);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(102, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Tipo de Usuario";
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(249, 113);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(146, 23);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombreUsuario
            // 
            // 
            // 
            // 
            this.txtNombreUsuario.CustomButton.Image = null;
            this.txtNombreUsuario.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txtNombreUsuario.CustomButton.Name = "";
            this.txtNombreUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreUsuario.CustomButton.TabIndex = 1;
            this.txtNombreUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreUsuario.CustomButton.UseSelectable = true;
            this.txtNombreUsuario.CustomButton.Visible = false;
            this.txtNombreUsuario.Lines = new string[0];
            this.txtNombreUsuario.Location = new System.Drawing.Point(249, 155);
            this.txtNombreUsuario.MaxLength = 32767;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.PasswordChar = '\0';
            this.txtNombreUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreUsuario.SelectedText = "";
            this.txtNombreUsuario.SelectionLength = 0;
            this.txtNombreUsuario.SelectionStart = 0;
            this.txtNombreUsuario.ShortcutsEnabled = true;
            this.txtNombreUsuario.Size = new System.Drawing.Size(146, 23);
            this.txtNombreUsuario.TabIndex = 6;
            this.txtNombreUsuario.UseSelectable = true;
            this.txtNombreUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(249, 201);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(146, 23);
            this.txtPass.TabIndex = 7;
            this.txtPass.UseSelectable = true;
            this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPass2
            // 
            // 
            // 
            // 
            this.txtPass2.CustomButton.Image = null;
            this.txtPass2.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txtPass2.CustomButton.Name = "";
            this.txtPass2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPass2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass2.CustomButton.TabIndex = 1;
            this.txtPass2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass2.CustomButton.UseSelectable = true;
            this.txtPass2.CustomButton.Visible = false;
            this.txtPass2.Lines = new string[0];
            this.txtPass2.Location = new System.Drawing.Point(249, 248);
            this.txtPass2.MaxLength = 32767;
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '*';
            this.txtPass2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass2.SelectedText = "";
            this.txtPass2.SelectionLength = 0;
            this.txtPass2.SelectionStart = 0;
            this.txtPass2.ShortcutsEnabled = true;
            this.txtPass2.Size = new System.Drawing.Size(146, 23);
            this.txtPass2.TabIndex = 8;
            this.txtPass2.UseSelectable = true;
            this.txtPass2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboTipo
            // 
            this.cboTipo.DataSource = this.tipousuarioBindingSource;
            this.cboTipo.DisplayMember = "descripciontipoU";
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.ItemHeight = 23;
            this.cboTipo.Location = new System.Drawing.Point(249, 298);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(146, 29);
            this.cboTipo.TabIndex = 9;
            this.cboTipo.UseSelectable = true;
            this.cboTipo.ValueMember = "idtipoUsuario";
            // 
            // tipousuarioBindingSource
            // 
            this.tipousuarioBindingSource.DataMember = "tipousuario";
            this.tipousuarioBindingSource.DataSource = this.discotequeDataSet;
            // 
            // discotequeDataSet
            // 
            this.discotequeDataSet.DataSetName = "discotequeDataSet";
            this.discotequeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipousuarioTableAdapter
            // 
            this.tipousuarioTableAdapter.ClearBeforeFill = true;
            // 
            // btnAgregarUsu
            // 
            this.btnAgregarUsu.Location = new System.Drawing.Point(147, 378);
            this.btnAgregarUsu.Name = "btnAgregarUsu";
            this.btnAgregarUsu.Size = new System.Drawing.Size(131, 34);
            this.btnAgregarUsu.TabIndex = 10;
            this.btnAgregarUsu.Text = "Agregar";
            this.btnAgregarUsu.UseSelectable = true;
            this.btnAgregarUsu.Click += new System.EventHandler(this.btnAgregarUsu_Click);
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
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 496);
            this.Controls.Add(this.btnAgregarUsu);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AgregarUsuario";
            this.Text = "AgregarUsuario";
            this.Load += new System.EventHandler(this.AgregarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipousuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discotequeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroTextBox txtNombreUsuario;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroTextBox txtPass2;
        private MetroFramework.Controls.MetroComboBox cboTipo;
        private discotequeDataSet discotequeDataSet;
        private System.Windows.Forms.BindingSource tipousuarioBindingSource;
        private discotequeDataSetTableAdapters.tipousuarioTableAdapter tipousuarioTableAdapter;
        private MetroFramework.Controls.MetroButton btnAgregarUsu;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private discotequeDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
    }
}