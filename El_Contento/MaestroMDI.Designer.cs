namespace El_Contento
{
    partial class MaestroMDI
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maestrodetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposYAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasYGruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbLogIn = new System.Windows.Forms.GroupBox();
            this.btDeshacer = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btVerficar = new System.Windows.Forms.Button();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.txDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gestionDeRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.gbLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.actualizacionToolStripMenuItem,
            this.novedadesToolStripMenuItem,
            this.maestrodetalleToolStripMenuItem,
            this.gestionDeRolesToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Enabled = false;
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // actualizacionToolStripMenuItem
            // 
            this.actualizacionToolStripMenuItem.Enabled = false;
            this.actualizacionToolStripMenuItem.Name = "actualizacionToolStripMenuItem";
            this.actualizacionToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.actualizacionToolStripMenuItem.Text = "Actualizacion";
            this.actualizacionToolStripMenuItem.Click += new System.EventHandler(this.actualizacionToolStripMenuItem_Click);
            // 
            // novedadesToolStripMenuItem
            // 
            this.novedadesToolStripMenuItem.Enabled = false;
            this.novedadesToolStripMenuItem.Name = "novedadesToolStripMenuItem";
            this.novedadesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.novedadesToolStripMenuItem.Text = "Novedades";
            this.novedadesToolStripMenuItem.Click += new System.EventHandler(this.novedadesToolStripMenuItem_Click);
            // 
            // maestrodetalleToolStripMenuItem
            // 
            this.maestrodetalleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gruposYAlumnosToolStripMenuItem,
            this.materiasYGruposToolStripMenuItem});
            this.maestrodetalleToolStripMenuItem.Enabled = false;
            this.maestrodetalleToolStripMenuItem.Name = "maestrodetalleToolStripMenuItem";
            this.maestrodetalleToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.maestrodetalleToolStripMenuItem.Text = "Maestro-detalle";
            // 
            // gruposYAlumnosToolStripMenuItem
            // 
            this.gruposYAlumnosToolStripMenuItem.Name = "gruposYAlumnosToolStripMenuItem";
            this.gruposYAlumnosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.gruposYAlumnosToolStripMenuItem.Text = "Grupos y alumnos";
            this.gruposYAlumnosToolStripMenuItem.Click += new System.EventHandler(this.gruposYAlumnosToolStripMenuItem_Click);
            // 
            // materiasYGruposToolStripMenuItem
            // 
            this.materiasYGruposToolStripMenuItem.Name = "materiasYGruposToolStripMenuItem";
            this.materiasYGruposToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.materiasYGruposToolStripMenuItem.Text = "Materias y grupos";
            this.materiasYGruposToolStripMenuItem.Click += new System.EventHandler(this.materiasYGruposToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Visible = false;
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // gbLogIn
            // 
            this.gbLogIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbLogIn.Controls.Add(this.btDeshacer);
            this.gbLogIn.Controls.Add(this.btSalir);
            this.gbLogIn.Controls.Add(this.btVerficar);
            this.gbLogIn.Controls.Add(this.cbRoles);
            this.gbLogIn.Controls.Add(this.txDocumento);
            this.gbLogIn.Controls.Add(this.label2);
            this.gbLogIn.Controls.Add(this.label1);
            this.gbLogIn.Location = new System.Drawing.Point(59, 102);
            this.gbLogIn.Name = "gbLogIn";
            this.gbLogIn.Size = new System.Drawing.Size(519, 138);
            this.gbLogIn.TabIndex = 4;
            this.gbLogIn.TabStop = false;
            this.gbLogIn.Text = "Log in";
            // 
            // btDeshacer
            // 
            this.btDeshacer.Location = new System.Drawing.Point(423, 68);
            this.btDeshacer.Name = "btDeshacer";
            this.btDeshacer.Size = new System.Drawing.Size(75, 23);
            this.btDeshacer.TabIndex = 9;
            this.btDeshacer.Text = "Deshacer";
            this.btDeshacer.UseVisualStyleBackColor = true;
            this.btDeshacer.Click += new System.EventHandler(this.btDeshacer_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(423, 97);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 7;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btVerficar
            // 
            this.btVerficar.Location = new System.Drawing.Point(423, 39);
            this.btVerficar.Name = "btVerficar";
            this.btVerficar.Size = new System.Drawing.Size(75, 23);
            this.btVerficar.TabIndex = 6;
            this.btVerficar.Text = "Ingresar";
            this.btVerficar.UseVisualStyleBackColor = true;
            this.btVerficar.Click += new System.EventHandler(this.btVerficar_Click);
            // 
            // cbRoles
            // 
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Items.AddRange(new object[] {
            "ESTUDIANTE",
            "PROFESOR",
            "ADMINISTRADOR"});
            this.cbRoles.Location = new System.Drawing.Point(272, 41);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(121, 21);
            this.cbRoles.TabIndex = 3;
            // 
            // txDocumento
            // 
            this.txDocumento.Location = new System.Drawing.Point(131, 42);
            this.txDocumento.Name = "txDocumento";
            this.txDocumento.Size = new System.Drawing.Size(76, 20);
            this.txDocumento.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rol:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su documento:";
            // 
            // gestionDeRolesToolStripMenuItem
            // 
            this.gestionDeRolesToolStripMenuItem.Enabled = false;
            this.gestionDeRolesToolStripMenuItem.Name = "gestionDeRolesToolStripMenuItem";
            this.gestionDeRolesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionDeRolesToolStripMenuItem.Text = "Gestion de roles";
            this.gestionDeRolesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeRolesToolStripMenuItem_Click);
            // 
            // MaestroMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 335);
            this.Controls.Add(this.gbLogIn);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MaestroMDI";
            this.Text = "Maestro MDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbLogIn.ResumeLayout(false);
            this.gbLogIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novedadesToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbLogIn;
        private System.Windows.Forms.TextBox txDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btVerficar;
        private System.Windows.Forms.Button btDeshacer;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maestrodetalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposYAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasYGruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeRolesToolStripMenuItem;
    }
}