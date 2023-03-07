using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;


namespace El_Contento
{
    public partial class Consulta : Form
    {
        SqlConnection objConector;
        SqlDataReader objTabla;
        string nombre = "", consultaSQL = "";
        int documento = 0;
        double nota = 0, porcentaje = 0.2;
        public Consulta()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txNombre.Text) || string.IsNullOrEmpty(txDocumento.Text))
            {
                MessageBox.Show("Error, debe ingresar todos los datos.");
            }
            else
            {
                nombre = txNombre.Text;
                documento = Int32.Parse(txDocumento.Text);
                btConsultar.Enabled = false;
                btDeshacer.Enabled = false;
                btSalir.Enabled = false;

                try
                {
                    objConector = DB.conectar("ALUMNOS_EL_CONTENTO");
                    //MessageBox.Show("Se realizó la convexíón");
                    consultaSQL = "SELECT * FROM ESTUDIANTES WHERE NOMBRE LIKE '" + nombre + "%' AND DOCUMENTO = " + documento;

                    try
                    {
                        objTabla = DB.consulta(consultaSQL, objConector);
                        if (objTabla.Read())
                        {
                            txFechaNacimiento.Text = objTabla[2].ToString();
                            txGrupo.Text = objTabla[3].ToString();

                            if (objTabla[4].ToString() == "")
                            {
                                txNota1.Text = "SC";
                            }
                            else
                            {
                                txNota1.Text = objTabla[4].ToString();
                                nota = nota + (Double.Parse(objTabla[4].ToString()) * porcentaje);
                            }

                            if (objTabla[5].ToString() == "")
                            {
                                txNota2.Text = "SC";
                            }
                            else
                            {
                                txNota2.Text = objTabla[5].ToString();
                                nota = nota + (Double.Parse(objTabla[5].ToString()) * porcentaje);
                            }

                            if (objTabla[6].ToString() == "")
                            {
                                txNota3.Text = "SC";
                            }
                            else
                            {
                                txNota3.Text = objTabla[6].ToString();
                                nota = nota + (Double.Parse(objTabla[6].ToString()) * porcentaje);
                            }

                            if (objTabla[7].ToString() == "")
                            {
                                txNota4.Text = "SC";
                            }
                            else
                            {
                                txNota4.Text = objTabla[7].ToString();
                                nota = nota + (Double.Parse(objTabla[7].ToString()) * porcentaje);
                            }

                            if (objTabla[8].ToString() == "")
                            {
                                txNota5.Text = "SC";
                            }
                            else
                            {
                                txNota5.Text = objTabla[8].ToString();
                                nota = nota + (Double.Parse(objTabla[8].ToString()) * porcentaje);
                            }

                            gBoxDatosEstudiante.Visible = true;
                            txNotaDefinitiva.Text = nota.ToString();
                        }
                        else
                        {
                            MessageBox.Show("El estudiante no esta registrado en la base de datos");
                            txNombre.Text = "";
                            txDocumento.Text = "";
                            txNombre.Focus();
                        }
                    }
                    catch (SqlException exx)
                    {
                        MessageBox.Show("Error de busqueda " + exx.Message);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error de conexión " + ex.Message);
                }
            }
        }

        private void btSalir2_Click(object sender, EventArgs e)
        {
            txFechaNacimiento.Text = "";
            txGrupo.Text = "";
            txNotaDefinitiva.Text = "";

            txNota1.Text = "";
            txNota2.Text = "";
            txNota3.Text = "";
            txNota4.Text = "";
            txNota5.Text = "";

            gBoxDatosEstudiante.Visible = false;

            btConsultar.Enabled = true;
            btDeshacer.Enabled = true;
            btSalir.Enabled = true;

            txNombre.Text = "";
            txDocumento.Text = "";
            txNombre.Focus();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            gBoxDatosEstudiante.Visible = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txNombre.Text) || string.IsNullOrEmpty(txDocumento.Text))
            {
                MessageBox.Show("Error, debe ingresar todos los datos.");
            }
            else
            {
                txNombre.Text = "";
                txDocumento.Text = "";
                txFechaNacimiento.Text = "";
                txGrupo.Text = "";
                gBoxDatosEstudiante.Visible = false;
                txNombre.Focus();
            }
        }
    }
}
