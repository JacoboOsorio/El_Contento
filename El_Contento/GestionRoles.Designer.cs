namespace El_Contento
{
    partial class GestionRoles
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txDocumento = new System.Windows.Forms.TextBox();
            this.btIngresar = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btDeshacer = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.gbIngresar = new System.Windows.Forms.GroupBox();
            this.btSalirIngreso = new System.Windows.Forms.Button();
            this.btDeshacerIngreso = new System.Windows.Forms.Button();
            this.btIngresarIngreso = new System.Windows.Forms.Button();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txDocumentoIngreso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbConsultar = new System.Windows.Forms.GroupBox();
            this.txRol = new System.Windows.Forms.TextBox();
            this.btSalirConsulta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txNombreConsulta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbActualizarRol = new System.Windows.Forms.GroupBox();
            this.btSalirActualizar = new System.Windows.Forms.Button();
            this.btActualizarActualizar = new System.Windows.Forms.Button();
            this.cbNuevoRol = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txRolActual = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txNombreActualizar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btConsultar = new System.Windows.Forms.Button();
            this.gbIngresar.SuspendLayout();
            this.gbConsultar.SuspendLayout();
            this.gbActualizarRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa de gestion de roles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Documento de la persona:";
            // 
            // txDocumento
            // 
            this.txDocumento.Location = new System.Drawing.Point(288, 72);
            this.txDocumento.Name = "txDocumento";
            this.txDocumento.Size = new System.Drawing.Size(100, 20);
            this.txDocumento.TabIndex = 2;
            // 
            // btIngresar
            // 
            this.btIngresar.Location = new System.Drawing.Point(12, 112);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(75, 23);
            this.btIngresar.TabIndex = 3;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = true;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(198, 112);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(75, 23);
            this.btActualizar.TabIndex = 5;
            this.btActualizar.Text = "Actualizar rol";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(288, 112);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 6;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btDeshacer
            // 
            this.btDeshacer.Location = new System.Drawing.Point(378, 112);
            this.btDeshacer.Name = "btDeshacer";
            this.btDeshacer.Size = new System.Drawing.Size(75, 23);
            this.btDeshacer.TabIndex = 7;
            this.btDeshacer.Text = "Deshacer";
            this.btDeshacer.UseVisualStyleBackColor = true;
            this.btDeshacer.Click += new System.EventHandler(this.btDeshacer_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(469, 112);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 8;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // gbIngresar
            // 
            this.gbIngresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbIngresar.Controls.Add(this.btSalirIngreso);
            this.gbIngresar.Controls.Add(this.btDeshacerIngreso);
            this.gbIngresar.Controls.Add(this.btIngresarIngreso);
            this.gbIngresar.Controls.Add(this.cbRol);
            this.gbIngresar.Controls.Add(this.label5);
            this.gbIngresar.Controls.Add(this.txNombre);
            this.gbIngresar.Controls.Add(this.label4);
            this.gbIngresar.Controls.Add(this.txDocumentoIngreso);
            this.gbIngresar.Controls.Add(this.label3);
            this.gbIngresar.Location = new System.Drawing.Point(73, 170);
            this.gbIngresar.Name = "gbIngresar";
            this.gbIngresar.Size = new System.Drawing.Size(380, 178);
            this.gbIngresar.TabIndex = 9;
            this.gbIngresar.TabStop = false;
            this.gbIngresar.Text = "Ingreso de persona";
            this.gbIngresar.Visible = false;
            // 
            // btSalirIngreso
            // 
            this.btSalirIngreso.Location = new System.Drawing.Point(283, 122);
            this.btSalirIngreso.Name = "btSalirIngreso";
            this.btSalirIngreso.Size = new System.Drawing.Size(75, 23);
            this.btSalirIngreso.TabIndex = 8;
            this.btSalirIngreso.Text = "Salir";
            this.btSalirIngreso.UseVisualStyleBackColor = true;
            this.btSalirIngreso.Click += new System.EventHandler(this.btSalirIngreso_Click);
            // 
            // btDeshacerIngreso
            // 
            this.btDeshacerIngreso.Location = new System.Drawing.Point(283, 81);
            this.btDeshacerIngreso.Name = "btDeshacerIngreso";
            this.btDeshacerIngreso.Size = new System.Drawing.Size(75, 23);
            this.btDeshacerIngreso.TabIndex = 7;
            this.btDeshacerIngreso.Text = "Deshacer";
            this.btDeshacerIngreso.UseVisualStyleBackColor = true;
            this.btDeshacerIngreso.Click += new System.EventHandler(this.btDeshacerIngreso_Click);
            // 
            // btIngresarIngreso
            // 
            this.btIngresarIngreso.Location = new System.Drawing.Point(283, 41);
            this.btIngresarIngreso.Name = "btIngresarIngreso";
            this.btIngresarIngreso.Size = new System.Drawing.Size(75, 23);
            this.btIngresarIngreso.TabIndex = 6;
            this.btIngresarIngreso.Text = "Ingresar";
            this.btIngresarIngreso.UseVisualStyleBackColor = true;
            this.btIngresarIngreso.Click += new System.EventHandler(this.btIngresarIngreso_Click);
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "ESTUDIANTE",
            "PROFESOR",
            "ADMINISTRADOR"});
            this.cbRol.Location = new System.Drawing.Point(144, 124);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(116, 21);
            this.cbRol.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rol que tendra:";
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(160, 83);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(100, 20);
            this.txNombre.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre de la persona:";
            // 
            // txDocumentoIngreso
            // 
            this.txDocumentoIngreso.Enabled = false;
            this.txDocumentoIngreso.Location = new System.Drawing.Point(160, 43);
            this.txDocumentoIngreso.Name = "txDocumentoIngreso";
            this.txDocumentoIngreso.Size = new System.Drawing.Size(100, 20);
            this.txDocumentoIngreso.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Documento de la persona:";
            // 
            // gbConsultar
            // 
            this.gbConsultar.BackColor = System.Drawing.SystemColors.Info;
            this.gbConsultar.Controls.Add(this.txRol);
            this.gbConsultar.Controls.Add(this.btSalirConsulta);
            this.gbConsultar.Controls.Add(this.label7);
            this.gbConsultar.Controls.Add(this.txNombreConsulta);
            this.gbConsultar.Controls.Add(this.label8);
            this.gbConsultar.Location = new System.Drawing.Point(0, 19);
            this.gbConsultar.Name = "gbConsultar";
            this.gbConsultar.Size = new System.Drawing.Size(380, 129);
            this.gbConsultar.TabIndex = 10;
            this.gbConsultar.TabStop = false;
            this.gbConsultar.Text = "Consulta de persona";
            this.gbConsultar.Visible = false;
            // 
            // txRol
            // 
            this.txRol.Enabled = false;
            this.txRol.Location = new System.Drawing.Point(128, 82);
            this.txRol.Name = "txRol";
            this.txRol.Size = new System.Drawing.Size(138, 20);
            this.txRol.TabIndex = 12;
            // 
            // btSalirConsulta
            // 
            this.btSalirConsulta.Location = new System.Drawing.Point(283, 77);
            this.btSalirConsulta.Name = "btSalirConsulta";
            this.btSalirConsulta.Size = new System.Drawing.Size(75, 29);
            this.btSalirConsulta.TabIndex = 9;
            this.btSalirConsulta.Text = "Salir";
            this.btSalirConsulta.UseVisualStyleBackColor = true;
            this.btSalirConsulta.Click += new System.EventHandler(this.btSalirConsulta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Rol que tiene:";
            // 
            // txNombreConsulta
            // 
            this.txNombreConsulta.Enabled = false;
            this.txNombreConsulta.Location = new System.Drawing.Point(128, 38);
            this.txNombreConsulta.Name = "txNombreConsulta";
            this.txNombreConsulta.Size = new System.Drawing.Size(230, 20);
            this.txNombreConsulta.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nombre de la persona:";
            // 
            // gbActualizarRol
            // 
            this.gbActualizarRol.BackColor = System.Drawing.SystemColors.Highlight;
            this.gbActualizarRol.Controls.Add(this.btSalirActualizar);
            this.gbActualizarRol.Controls.Add(this.btActualizarActualizar);
            this.gbActualizarRol.Controls.Add(this.gbConsultar);
            this.gbActualizarRol.Controls.Add(this.cbNuevoRol);
            this.gbActualizarRol.Controls.Add(this.label11);
            this.gbActualizarRol.Controls.Add(this.txRolActual);
            this.gbActualizarRol.Controls.Add(this.label10);
            this.gbActualizarRol.Controls.Add(this.txNombreActualizar);
            this.gbActualizarRol.Controls.Add(this.label9);
            this.gbActualizarRol.Location = new System.Drawing.Point(73, 170);
            this.gbActualizarRol.Name = "gbActualizarRol";
            this.gbActualizarRol.Size = new System.Drawing.Size(380, 169);
            this.gbActualizarRol.TabIndex = 11;
            this.gbActualizarRol.TabStop = false;
            this.gbActualizarRol.Text = "Actualizacion de rol";
            this.gbActualizarRol.Visible = false;
            // 
            // btSalirActualizar
            // 
            this.btSalirActualizar.Location = new System.Drawing.Point(283, 112);
            this.btSalirActualizar.Name = "btSalirActualizar";
            this.btSalirActualizar.Size = new System.Drawing.Size(75, 23);
            this.btSalirActualizar.TabIndex = 20;
            this.btSalirActualizar.Text = "Salir";
            this.btSalirActualizar.UseVisualStyleBackColor = true;
            this.btSalirActualizar.Click += new System.EventHandler(this.btSalirActualizar_Click);
            // 
            // btActualizarActualizar
            // 
            this.btActualizarActualizar.Location = new System.Drawing.Point(283, 74);
            this.btActualizarActualizar.Name = "btActualizarActualizar";
            this.btActualizarActualizar.Size = new System.Drawing.Size(75, 23);
            this.btActualizarActualizar.TabIndex = 19;
            this.btActualizarActualizar.Text = "Actualizar";
            this.btActualizarActualizar.UseVisualStyleBackColor = true;
            this.btActualizarActualizar.Click += new System.EventHandler(this.btActualizarActualizar_Click);
            // 
            // cbNuevoRol
            // 
            this.cbNuevoRol.FormattingEnabled = true;
            this.cbNuevoRol.Items.AddRange(new object[] {
            "ESTUDIANTE",
            "PROFESOR",
            "ADMINISTRADOR"});
            this.cbNuevoRol.Location = new System.Drawing.Point(128, 114);
            this.cbNuevoRol.Name = "cbNuevoRol";
            this.cbNuevoRol.Size = new System.Drawing.Size(138, 21);
            this.cbNuevoRol.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Nuevo rol:";
            // 
            // txRolActual
            // 
            this.txRolActual.Enabled = false;
            this.txRolActual.Location = new System.Drawing.Point(128, 76);
            this.txRolActual.Name = "txRolActual";
            this.txRolActual.Size = new System.Drawing.Size(138, 20);
            this.txRolActual.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Rol actual:";
            // 
            // txNombreActualizar
            // 
            this.txNombreActualizar.Enabled = false;
            this.txNombreActualizar.Location = new System.Drawing.Point(128, 38);
            this.txNombreActualizar.Name = "txNombreActualizar";
            this.txNombreActualizar.Size = new System.Drawing.Size(230, 20);
            this.txNombreActualizar.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nombre de la persona:";
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(103, 112);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 23);
            this.btConsultar.TabIndex = 12;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // GestionRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 385);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.gbActualizarRol);
            this.Controls.Add(this.gbIngresar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btDeshacer);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btIngresar);
            this.Controls.Add(this.txDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GestionRoles";
            this.Text = "Gestion de roles";
            this.gbIngresar.ResumeLayout(false);
            this.gbIngresar.PerformLayout();
            this.gbConsultar.ResumeLayout(false);
            this.gbConsultar.PerformLayout();
            this.gbActualizarRol.ResumeLayout(false);
            this.gbActualizarRol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txDocumento;
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btDeshacer;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.GroupBox gbIngresar;
        private System.Windows.Forms.TextBox txDocumentoIngreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSalirIngreso;
        private System.Windows.Forms.Button btDeshacerIngreso;
        private System.Windows.Forms.Button btIngresarIngreso;
        private System.Windows.Forms.GroupBox gbConsultar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txNombreConsulta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btSalirConsulta;
        private System.Windows.Forms.GroupBox gbActualizarRol;
        private System.Windows.Forms.TextBox txNombreActualizar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txRolActual;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbNuevoRol;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btSalirActualizar;
        private System.Windows.Forms.Button btActualizarActualizar;
        private System.Windows.Forms.TextBox txRol;
        private System.Windows.Forms.Button btConsultar;
    }
}