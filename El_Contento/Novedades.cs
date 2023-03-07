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

namespace El_Contento
{
    public partial class Novedades : Form
    {
        SqlConnection objConector;
        SqlDataReader objTabla;
        SqlCommand objConsulta;
        string comando = "", nroNota = "";
        int documento = 0;
        double porcentaje = 0.2, nota = 0;
        public Novedades()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txDocumento.Text = "";
            txDocumento.Focus();
        }

        private void btIngresarNota_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbNroNota.Text) || string.IsNullOrEmpty(txNota.Text))
            {
                MessageBox.Show("Error, por favor llene el campo solicitado.");
            }
            else
            {
                nroNota = cbNroNota.Text;
                nota = Double.Parse(txNota.Text);
                documento = Int32.Parse(txDocumento.Text);

                try
                {
                    objConector = DB.conectar("ALUMNOS_EL_CONTENTO");
                    comando = "SELECT " + nroNota + " FROM ESTUDIANTES WHERE DOCUMENTO = " + documento;

                    try
                    {
                        objConsulta = new SqlCommand(comando, objConector);
                        objTabla = objConsulta.ExecuteReader();
                        objTabla.Read();

                        if (objTabla[0].ToString() != "")
                        {
                            MessageBox.Show("Este espacio de nota ya ha sido calificado, Por favor escriba otro.");
                        }
                        else
                        {
                            DB.cerrar(objConector);

                            try
                            {
                                objConector = DB.conectar("ALUMNOS_EL_CONTENTO");
                                comando = "UPDATE ESTUDIANTES SET " + nroNota + " = " + nota + " WHERE DOCUMENTO = " + documento;

                                try
                                {
                                    objConsulta = new SqlCommand(comando, objConector);
                                    int n = objConsulta.ExecuteNonQuery();

                                    if (n > 0)
                                    {
                                        MessageBox.Show("La nota se ha registrado correctamente!");
                                        cbNroNota.Text = "";
                                        txNota.Text = "";
                                        gbIngresar.Visible = false;
                                        btCalcular.Enabled = true;
                                        btIngresar.Enabled = true;
                                        btCancelar.Enabled = true;
                                        txNombre1.Text = "";
                                        txDocumento.Text = "";
                                        txNombre1.Focus();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
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

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txDocumento.Text))
            {
                MessageBox.Show("Error, por favor llene el campo solicitado.");
            }
            else
            {
                documento = Int32.Parse(txDocumento.Text);
                int contNotas = 0, notasFaltantes = 0;

                try
                {
                    objConector = DB.conectar("ALUMNOS_EL_CONTENTO");
                    comando = "SELECT * FROM ESTUDIANTES WHERE DOCUMENTO = " + documento;

                    try
                    {
                        objConsulta = new SqlCommand(comando, objConector);
                        objTabla = objConsulta.ExecuteReader();

                        if (objTabla.Read())
                        {
                            if (objTabla[4].ToString() == "")
                            {
                                notasFaltantes = notasFaltantes + 1;
                            }
                            else
                            {
                                contNotas = contNotas + 1;
                                nota = nota + (Double.Parse(objTabla[4].ToString()) * porcentaje);
                            }

                            if (objTabla[5].ToString() == "")
                            {
                                notasFaltantes = notasFaltantes + 1;
                            }
                            else
                            {
                                contNotas = contNotas + 1;
                                nota = nota + (Double.Parse(objTabla[5].ToString()) * porcentaje);
                            }

                            if (objTabla[6].ToString() == "")
                            {
                                notasFaltantes = notasFaltantes + 1;
                            }
                            else
                            {
                                contNotas = contNotas + 1;
                                nota = nota + (Double.Parse(objTabla[6].ToString()) * porcentaje);
                            }

                            if (objTabla[7].ToString() == "")
                            {
                                notasFaltantes = notasFaltantes + 1;
                            }
                            else
                            {
                                contNotas = contNotas + 1;
                                nota = nota + (Double.Parse(objTabla[7].ToString()) * porcentaje);
                            }

                            if (objTabla[8].ToString() == "")
                            {
                                notasFaltantes = notasFaltantes + 1;
                            }
                            else
                            {
                                contNotas = contNotas + 1;
                                nota = nota + (Double.Parse(objTabla[8].ToString()) * porcentaje);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No existe");
                        }

                        txNroNotas.Text = contNotas.ToString();
                        txNotasFaltantes.Text = notasFaltantes.ToString();
                        txDefinitiva.Text = nota.ToString();
                        txNombre1.Text = objTabla[1].ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                gbDefinitiva.Visible = true;
            }
        }

        private void btSalirNotaDef_Click(object sender, EventArgs e)
        {
            txNroNotas.Text = "";
            txNotasFaltantes.Text = "";
            txDefinitiva.Text = "";
            gbDefinitiva.Visible = false;
            txNombre1.Text = "";
            txDocumento.Text = "";
            txNombre1.Focus();
        }

        private void btSalirIngresar_Click(object sender, EventArgs e)
        {
            txNombre1.Text = "";
            txNombre1.Focus();
            txDocumento.Text = "";
            btCalcular.Enabled = true;
            btCancelar.Enabled = true;
            btIngresar.Enabled = true;
            gbIngresar.Visible = false;
        }

        private void btDeshacer_Click(object sender, EventArgs e)
        {
            cbNroNota.Text = "";
            txNota.Text = "";
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txDocumento.Text))
            {
                MessageBox.Show("Error, por favor llene el campo solicitado.");
            }
            else
            {
                try
                {
                    objConector = DB.conectar("ALUMNOS_EL_CONTENTO");
                    documento = Int32.Parse(txDocumento.Text);
                    comando = "SELECT * FROM ESTUDIANTES WHERE DOCUMENTO = " + documento;

                    try
                    {
                        objConsulta = new SqlCommand(comando, objConector);
                        objTabla = objConsulta.ExecuteReader();

                        if (objTabla.Read())
                        {
                            if (objTabla[4].ToString() == "" || objTabla[5].ToString() == "" || objTabla[6].ToString() == "" || objTabla[7].ToString() == "" || objTabla[8].ToString() == "")
                            {
                                btIngresar.Enabled = false;
                                btCalcular.Enabled = false;
                                btCancelar.Enabled = false;
                                gbIngresar.Visible = true;
                                txNombre.Text = objTabla[1].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Al estudiante " + objTabla[1].ToString() + " ya se le ingresaron todas sus notas.");
                            }
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
