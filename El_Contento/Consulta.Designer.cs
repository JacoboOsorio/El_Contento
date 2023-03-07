namespace El_Contento
{
    partial class Consulta
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
            this.label3 = new System.Windows.Forms.Label();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txDocumento = new System.Windows.Forms.TextBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btDeshacer = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.gBoxDatosEstudiante = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btSalir2 = new System.Windows.Forms.Button();
            this.txNotaDefinitiva = new System.Windows.Forms.TextBox();
            this.txNota5 = new System.Windows.Forms.TextBox();
            this.txNota4 = new System.Windows.Forms.TextBox();
            this.txNota3 = new System.Windows.Forms.TextBox();
            this.txNota2 = new System.Windows.Forms.TextBox();
            this.txNota1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txGrupo = new System.Windows.Forms.TextBox();
            this.txFechaNacimiento = new System.Windows.Forms.TextBox();
            this.gBoxDatosEstudiante.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa de consulta de estudiantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del estudiante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Documento del estudiante:";
            // 
            // txNombre
            // 
            this.txNombre.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNombre.Location = new System.Drawing.Point(270, 84);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(200, 26);
            this.txNombre.TabIndex = 3;
            // 
            // txDocumento
            // 
            this.txDocumento.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDocumento.Location = new System.Drawing.Point(295, 129);
            this.txDocumento.Name = "txDocumento";
            this.txDocumento.Size = new System.Drawing.Size(100, 26);
            this.txDocumento.TabIndex = 4;
            // 
            // btConsultar
            // 
            this.btConsultar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.Location = new System.Drawing.Point(78, 178);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(90, 23);
            this.btConsultar.TabIndex = 5;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btDeshacer
            // 
            this.btDeshacer.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeshacer.Location = new System.Drawing.Point(202, 178);
            this.btDeshacer.Name = "btDeshacer";
            this.btDeshacer.Size = new System.Drawing.Size(107, 23);
            this.btDeshacer.TabIndex = 6;
            this.btDeshacer.Text = "Deshacer";
            this.btDeshacer.UseVisualStyleBackColor = true;
            this.btDeshacer.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(344, 178);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 7;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // gBoxDatosEstudiante
            // 
            this.gBoxDatosEstudiante.Controls.Add(this.label12);
            this.gBoxDatosEstudiante.Controls.Add(this.btSalir2);
            this.gBoxDatosEstudiante.Controls.Add(this.txNotaDefinitiva);
            this.gBoxDatosEstudiante.Controls.Add(this.txNota5);
            this.gBoxDatosEstudiante.Controls.Add(this.txNota4);
            this.gBoxDatosEstudiante.Controls.Add(this.txNota3);
            this.gBoxDatosEstudiante.Controls.Add(this.txNota2);
            this.gBoxDatosEstudiante.Controls.Add(this.txNota1);
            this.gBoxDatosEstudiante.Controls.Add(this.label11);
            this.gBoxDatosEstudiante.Controls.Add(this.label10);
            this.gBoxDatosEstudiante.Controls.Add(this.label9);
            this.gBoxDatosEstudiante.Controls.Add(this.label8);
            this.gBoxDatosEstudiante.Controls.Add(this.label7);
            this.gBoxDatosEstudiante.Controls.Add(this.label5);
            this.gBoxDatosEstudiante.Controls.Add(this.label4);
            this.gBoxDatosEstudiante.Controls.Add(this.label6);
            this.gBoxDatosEstudiante.Controls.Add(this.txGrupo);
            this.gBoxDatosEstudiante.Controls.Add(this.txFechaNacimiento);
            this.gBoxDatosEstudiante.Location = new System.Drawing.Point(92, 262);
            this.gBoxDatosEstudiante.Name = "gBoxDatosEstudiante";
            this.gBoxDatosEstudiante.Size = new System.Drawing.Size(365, 424);
            this.gBoxDatosEstudiante.TabIndex = 12;
            this.gBoxDatosEstudiante.TabStop = false;
            this.gBoxDatosEstudiante.Text = "Datos del Estudiante";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(268, 22);
            this.label12.TabIndex = 28;
            this.label12.Text = "Nota: \"SC\" significa \"Sin Calificar\"";
            // 
            // btSalir2
            // 
            this.btSalir2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir2.Location = new System.Drawing.Point(23, 218);
            this.btSalir2.Name = "btSalir2";
            this.btSalir2.Size = new System.Drawing.Size(106, 77);
            this.btSalir2.TabIndex = 13;
            this.btSalir2.Text = "Salir";
            this.btSalir2.UseVisualStyleBackColor = true;
            this.btSalir2.Click += new System.EventHandler(this.btSalir2_Click);
            // 
            // txNotaDefinitiva
            // 
            this.txNotaDefinitiva.Enabled = false;
            this.txNotaDefinitiva.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNotaDefinitiva.Location = new System.Drawing.Point(244, 380);
            this.txNotaDefinitiva.Name = "txNotaDefinitiva";
            this.txNotaDefinitiva.Size = new System.Drawing.Size(83, 26);
            this.txNotaDefinitiva.TabIndex = 27;
            // 
            // txNota5
            // 
            this.txNota5.Enabled = false;
            this.txNota5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNota5.Location = new System.Drawing.Point(244, 335);
            this.txNota5.Name = "txNota5";
            this.txNota5.Size = new System.Drawing.Size(83, 26);
            this.txNota5.TabIndex = 26;
            // 
            // txNota4
            // 
            this.txNota4.Enabled = false;
            this.txNota4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNota4.Location = new System.Drawing.Point(244, 288);
            this.txNota4.Name = "txNota4";
            this.txNota4.Size = new System.Drawing.Size(83, 26);
            this.txNota4.TabIndex = 25;
            // 
            // txNota3
            // 
            this.txNota3.Enabled = false;
            this.txNota3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNota3.Location = new System.Drawing.Point(244, 242);
            this.txNota3.Name = "txNota3";
            this.txNota3.Size = new System.Drawing.Size(83, 26);
            this.txNota3.TabIndex = 24;
            // 
            // txNota2
            // 
            this.txNota2.Enabled = false;
            this.txNota2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNota2.Location = new System.Drawing.Point(244, 197);
            this.txNota2.Name = "txNota2";
            this.txNota2.Size = new System.Drawing.Size(83, 26);
            this.txNota2.TabIndex = 23;
            // 
            // txNota1
            // 
            this.txNota1.Enabled = false;
            this.txNota1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNota1.Location = new System.Drawing.Point(244, 153);
            this.txNota1.Name = "txNota1";
            this.txNota1.Size = new System.Drawing.Size(83, 26);
            this.txNota1.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(126, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Nota Definitiva:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(179, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Nota 5:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(179, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Nota 4:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(179, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nota 3:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(179, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nota 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nota 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Grupo del estudiante:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fecha nacimiento del estudiante:";
            // 
            // txGrupo
            // 
            this.txGrupo.Enabled = false;
            this.txGrupo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txGrupo.Location = new System.Drawing.Point(245, 108);
            this.txGrupo.Name = "txGrupo";
            this.txGrupo.Size = new System.Drawing.Size(83, 26);
            this.txGrupo.TabIndex = 13;
            // 
            // txFechaNacimiento
            // 
            this.txFechaNacimiento.Enabled = false;
            this.txFechaNacimiento.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txFechaNacimiento.Location = new System.Drawing.Point(240, 69);
            this.txFechaNacimiento.Name = "txFechaNacimiento";
            this.txFechaNacimiento.Size = new System.Drawing.Size(88, 26);
            this.txFechaNacimiento.TabIndex = 12;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 716);
            this.Controls.Add(this.gBoxDatosEstudiante);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btDeshacer);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.txDocumento);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            this.gBoxDatosEstudiante.ResumeLayout(false);
            this.gBoxDatosEstudiante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txDocumento;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btDeshacer;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.GroupBox gBoxDatosEstudiante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txGrupo;
        private System.Windows.Forms.TextBox txFechaNacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txNotaDefinitiva;
        private System.Windows.Forms.TextBox txNota5;
        private System.Windows.Forms.TextBox txNota4;
        private System.Windows.Forms.TextBox txNota3;
        private System.Windows.Forms.TextBox txNota2;
        private System.Windows.Forms.TextBox txNota1;
        private System.Windows.Forms.Button btSalir2;
        private System.Windows.Forms.Label label12;
    }
}