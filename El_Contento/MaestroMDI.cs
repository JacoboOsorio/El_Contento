using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace El_Contento
{
    public partial class MaestroMDI : Form
    {
        SqlConnection objConector;
        SqlDataReader objTabla;
        SqlCommand objConsulta;

        int documento = 0;
        string rol = "", comando = "";
        public MaestroMDI()
        {
            InitializeComponent();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta objConsulta = new Consulta();
            objConsulta.MdiParent = this;
            objConsulta.Show();
        }

        private void actualizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizacion objActualizacion = new Actualizacion();
            objActualizacion.MdiParent = this;
            objActualizacion.Show();
        }

        private void novedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novedades objNovedades = new Novedades();
            objNovedades.MdiParent = this;
            objNovedades.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gruposYAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GruposAlumnos objGA = new GruposAlumnos();
            objGA.MdiParent = this;
            objGA.Show();
        }

        private void materiasYGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MateriaGrupo objMG = new MateriaGrupo();
            objMG.MdiParent = this;
            objMG.Show();
        }

        private void btDeshacer_Click(object sender, EventArgs e)
        {
            txDocumento.Text = "";
            cbRoles.Text = "";
            txDocumento.Focus();
        }

        private void gestionDeRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionRoles objGR = new GestionRoles();
            objGR.MdiParent = this;
            objGR.Show();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btVerficar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txDocumento.Text) || string.IsNullOrEmpty(cbRoles.Text))
            {
                MessageBox.Show("Error, debe llenar los campos requeridos.");
            }
            else
            {
                try
                {
                    objConector = DB.conectar("ALUMNOS_EL_CONTENTO");
                    documento = Int32.Parse(txDocumento.Text);
                    rol = cbRoles.Text;
                    comando = "SELECT * FROM ROLES WHERE DOCUMENTO = " + documento + "AND TIPOROL = '" + rol + "'";

                    try
                    {
                        objConsulta = new SqlCommand(comando, objConector);
                        objTabla = objConsulta.ExecuteReader();

                        if (objTabla.Read())
                        {
                            btVerficar.Enabled = false;
                            btDeshacer.Enabled = false;
                            txDocumento.Enabled = false;
                            cbRoles.Enabled = false;

                            MessageBox.Show("Bienvenido al programa " + objTabla[1].ToString());

                            switch (rol)
                            {
                                case "ESTUDIANTE":
                                    consultaToolStripMenuItem.Enabled = true;
                                break;

                                case "PROFESOR":
                                    consultaToolStripMenuItem.Enabled = true;
                                    actualizacionToolStripMenuItem.Enabled = true;
                                    maestrodetalleToolStripMenuItem.Enabled = true;
                                break;

                                case "ADMINISTRADOR":
                                    consultaToolStripMenuItem.Enabled = true;
                                    actualizacionToolStripMenuItem.Enabled = true;
                                    maestrodetalleToolStripMenuItem.Enabled = true;
                                    novedadesToolStripMenuItem.Enabled = true;
                                    gestionDeRolesToolStripMenuItem.Enabled = true;
                                break;
                            }

                            txDocumento.Text = "";
                            cbRoles.Text = "";
                            salirToolStripMenuItem.Visible = true;
                            gbLogIn.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Error, la persona no esta registrada para que acceda al programa.");
                            txDocumento.Text = "";
                            cbRoles.Text = "";
                            txDocumento.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    DB.cerrar(objConector);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
