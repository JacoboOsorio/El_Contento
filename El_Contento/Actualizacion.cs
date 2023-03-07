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
    public partial class Actualizacion : Form
    {
        SqlConnection objConector;
        SqlDataReader objTabla;
        SqlCommand objConsulta;
        string nombre = "", comando = "", grupo = "", fechaNacimiento = "";
        int documento = 0, nota = 0, notaNumero = 0;

        public Actualizacion()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txDocumento.Text))
            {
                MessageBox.Show("Error, debe llenar el campo requerido.");
            }
            else
            {
                btIngresar.Enabled = false;
                btCambiar.Enabled = false;
                btEliminar.Enabled = false;
                documento = Int32.Parse(txDocumento.Text);

                try
                {
                    objConector = DB.conectar("ALUMNOS_EL_CONTENTO");

                    try
                    {
                        comando = "SELECT DOCUMENTO FROM ESTUDIANTES  WHERE DOCUMENTO = " + documento;
                        objConsulta = new SqlCommand(comando, objConector);
                        objTabla = objConsulta.ExecuteReader();

                        if (objTabla.Read())
                        {
                            MessageBox.Show("El estudiante se encuentra en la base de datos.");
                        }
                        else
                        {
                            gbIngresar.Visible = true;
                            txDocumento.Enabled = false;
                        }
                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show("Error, el(la) estudiante no se encuentra en la base de datos. " + exx);
                    }
                    DB.cerrar(objConector);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void btCambiar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txDocumento.Text))
            {
                MessageBox.Show("Error, debe llenar el campo requerido.");
            }
            else
            {
                btIngresar.Enabled = false;
                btEliminar.Enabled = false;
                btCambiar.Enabled = false;

                try
                {
                    objConector = DB.conectar("ALUMNOS_EL_CONTENTO");
                    documento = Int32.Parse(txDocumento.Text);

                    try
                    {
                        comando = "SELECT * FROM ESTUDIANTES WHERE DOCUMENTO = " + documento;
                        objConsulta = new SqlCommand(comando, objConector);
                        objTabla = objConsulta.ExecuteReader();

                        if (objTabla.Read())
                        {
                            txNombreC.Text = objTabla[1].ToString();
                            MessageBox.Show("El estudiante se encuentra en la base de datos.");
                            gbCambiar.Visible = true;
                        }

                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show("Error, el(la) estudiante no se encuentra en la base de datos. " + exx);
                    }
                    DB.cerrar(objConector);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar la conexion con la base de datos. " + ex);
                }
            }
        }

        private void btSalirC_Click(object sender, EventArgs e)
        {
            ckbNota.Checked = false;
            ckbGrupo.Checked = false;
            ckbTodos.Checked = false;
            txNombreC.Text = "";
            txNuevaNota.Text = "";
            txNuevoGrupo.Text = "";
            gbCambiar.Visible = false;
            btCambiar.Enabled = true;
            btEliminar.Enabled = true;
            btIngresar.Enabled = true;
        }

        private void btBorrarC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txDocumento.Text))
            {
                MessageBox.Show("Error, debe llenar el campo requerido.");
            }
            else
            {
                txNuevaNota.Enabled = true;
                txNuevoGrupo.Enabled = true;
                ckbNota.Checked = false;
                ckbGrupo.Checked = false;
                ckbTodos.Checked = false;
                txNuevaNota.Text = "";
                txNuevoGrupo.Text = "";
            }
        }

        private void btCambiarC_Click(object sender, EventArgs e)
        {
            documento = Int32.Parse(txDocumento.Text);
            int n = 0;
            string grupoActual = "";

            if (string.IsNullOrEmpty(txNuevaNota.Text) || string.IsNullOrEmpty(txNuevoGrupo.Text))
            {
                MessageBox.Show("No se cambio ningun dato, por lo menos se debe cambiar uno.");
            }
            else
            {
                try
                {
                    objConector = DB.conectar("ALUMNOS_EL_CONTENTO");

                        if (ckbNota.Checked)
                        {
                            try
                            {
                                notaNumero = Int32.Parse(cbNota.Text);
                                nota = Int32.Parse(txNuevaNota.Text);
                                comando = "UPDATE ESTUDIANTES SET NOTA" + notaNumero + " = " + nota + " WHERE DOCUMENTO = " + documento;
                                objConsulta = new SqlCommand(comando, objConector);
                                n = objConsulta.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }

                        if (ckbGrupo.Checked)
                        {
                            try
                            {
                                grupo = txNuevoGrupo.Text;
                                comando = "SELECT CODGRUPO FROM ESTUDIANTES WHERE DOCUMENTO = '" + documento + "'";

                                objTabla = DB.consulta(comando, objConector);

                                if (objTabla.Read())
                                {
                                    grupoActual = objTabla[0].ToString();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            DB.cerrar(objConector);

                            try
                            {
                                objConector = DB.conectar("ALUMNOS_EL_CONTENTO");
                                comando = "UPDATE GRUPOS SET NROESTUDIANTES = NROESTUDIANTES - 1 WHERE CODIGO = '" + grupoActual + "'";
                                

                                try
                                {
                                    objConsulta = new SqlCommand(comando, objConector);
                                    n = objConsulta.ExecuteNonQuery();

                                    if (n > 0)
                                    {
                                        MessageBox.Show("Los comandos se ejecutaron correctamente.");
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

                            try
                            {
                                objConector = DB.conectar("ALUMNOS_EL_CONTENTO");
                                comando = "UPDATE GRUPOS SET NROESTUDIANTES = NROESTUDIANTES + 1 WHERE CODIGO = '" + grupo + "'";

                                try
                                {
                                    objConsulta = new SqlCommand(comando, objConector);
                                    n = objConsulta.ExecuteNonQuery();

                                    if (n > 0)
                                    {
                                        MessageBox.Show("Los comandos se ejecutaron correctamente.");
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

                            try
                            {
                                objConector = DB.conectar("ALUMNOS_EL_CONTENTO");
                                comando = "UPDATE ESTUDIANTES SET CODGRUPO = UPPER('" + grupo + "') WHERE DOCUMENTO = " + documento;

                                try
                                {
                                    objConsulta = new SqlCommand(comando, objConector);
                                    n = objConsulta.ExecuteNonQuery();
                                    
                                    if(n > 0)
                                    {
                                        MessageBox.Show("Los comandos se ejecutaron correctamente.");
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

                        if (ckbTodos.Checked)
                        {
                            notaNumero = Int32.Parse(cbNota.Text);
                            nota = Int32.Parse(txNuevaNota.Text);
                            comando = "UPDATE ESTUDIANTES SET NOTA" + notaNumero + " = " + nota + " AND CODGRUPO = UPPER('" + grupo + "') WHERE DOCUMENTO = " + documento;
                            objConsulta = new SqlCommand(comando, objConector);
                            n = objConsulta.ExecuteNonQuery();
                        }

                        if (n > 0)
                        {
                            MessageBox.Show("Los cambios se han realizado con exito!");
                        }
                        else
                        {
                            MessageBox.Show("Error al momento de realizar los cambios a los datos del estudiante.");
                        }
                    DB.cerrar(objConector);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                gbCambiar.Visible = false;
                txNombreC.Text = "";
                ckbNota.Checked = false;
                ckbGrupo.Checked = false;
                ckbTodos.Checked = false;
                txNuevaNota.Text = "";
                txNuevoGrupo.Text = "";
                txDocumento.Text = "";
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txDocumento.Text))
            {
                MessageBox.Show("Error, debe llenar el campo requerido.");
            }
            else
            {
                documento = Int32.Parse(txDocumento.Text);

                try
                {
                    objConector = DB.conectar("ALUMNOS_EL_CONTENTO");

                    try
                    {
                        comando = "DELETE FROM ESTUDIANTES WHERE DOCUMENTO = " + documento + "";
                        objConsulta = new SqlCommand(comando, objConector);
                        int n = objConsulta.ExecuteNonQuery();

                        if (n > 0)
                        {
                            MessageBox.Show("El estudiante se borro exitosamente de la base de datos!");
                        }
                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show("El estudiante no existe en la base de datos." + exx);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                DB.cerrar(objConector);
                txDocumento.Text = "";
            }

            
        }
        private void ckbEdad_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNota.Checked)
            {
                cbNota.Enabled = true;
                txNuevaNota.Enabled = true;
            }
            else
            {
                cbNota.Enabled = false;
                txNuevaNota.Enabled = false;
            }
        }

        private void ckbGrado_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbGrupo.Checked)
            {
                txNuevoGrupo.Enabled = true;
            }
            else
            {
                txNuevoGrupo.Enabled = false;
            }
        }

        private void ckbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTodos.Checked)
            {
                txNuevoGrupo.Enabled = true;
                txNuevaNota.Enabled = true;
                cbNota.Enabled = true;

                ckbNota.Enabled = false;
                ckbGrupo.Enabled = false;
            }
            else
            {
                txNuevoGrupo.Enabled = false;
                txNuevaNota.Enabled = false;
                cbNota.Enabled = false;

                ckbNota.Enabled = true;
                ckbGrupo.Enabled = true;
            }
        }
        private void btIngresarI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txDocumento.Text))
            {
                MessageBox.Show("Error, debe llenar el campo requerido.");
            }
            else
            {
                try
                {
                    objConector = DB.conectar("ALUMNOS_EL_CONTENTO");

                    try
                    {
                        if (string.IsNullOrEmpty(txNombre2.Text) || string.IsNullOrEmpty(txFechaNacimiento.Text) || string.IsNullOrEmpty(txGrupo.Text))
                        {
                            MessageBox.Show("Por favor llene todos los campos.");
                        }
                        else
                        {
                            nombre = txNombre2.Text;
                            documento = Int32.Parse(txDocumento.Text);
                            fechaNacimiento = txFechaNacimiento.Text;
                            grupo = txGrupo.Text;
                            comando = "SELECT CODIGO FROM GRUPOS WHERE CODIGO = '" + grupo + "'";

                            //Primero, comprobar si el grupo existe, si no existe, no se
                            //ingresa el usuario a la base de datos.

                            try
                            {
                                objConsulta = new SqlCommand(comando, objConector);

                                if (objConsulta.ExecuteReader().Read())
                                {
                                    //El grupo al que desea ingresar si existe.
                                    comando = "INSERT INTO ESTUDIANTES(DOCUMENTO, NOMBRE, FECHANACIMIENTO,CODGRUPO) VALUES (" + documento + ", UPPER('" + nombre + "'), '" + fechaNacimiento + "', UPPER('" + grupo + "'))";
                                }
                                else
                                {
                                    //El grupo no existe.
                                    MessageBox.Show("El grupo al que desea ingresar no existe.");
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

                try
                {
                    objConector = DB.conectar("ALUMNOS_EL_CONTENTO");

                    try
                    {
                        objConsulta = new SqlCommand(comando, objConector);
                        int n = objConsulta.ExecuteNonQuery();

                        if (n > 0)
                        {
                            MessageBox.Show("Los datos se ingresaron exitosamente!");
                        }
                        else
                        {
                            MessageBox.Show("Error al realizar el comando a la base de datos.");
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
                txDocumento.Text = "";
                txNombre2.Text = "";
                txFechaNacimiento.Text = "";
                txGrupo.Text = "";
                gbIngresar.Visible = false;

                txDocumento.Enabled = true;
                btCambiar.Enabled = true;
                btEliminar.Enabled = true;
                btIngresar.Enabled = true;
            }
        }

        private void btBorrarI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txDocumento.Text))
            {
                MessageBox.Show("Error, debe llenar el campo requerido.");
            }
            else
            {
                txNombre2.Text = "";
                txFechaNacimiento.Text = "";
                txGrupo.Text = "";
                txNombre2.Focus();
            }
        }

        private void btSalirI_Click(object sender, EventArgs e)
        {
            txDocumento.Enabled = true;
            txDocumento.Text = "";
            txNombre2.Text = "";
            txFechaNacimiento.Text = "";
            txGrupo.Text = "";
            gbIngresar.Visible = false;
            txDocumento.Focus();
            btCambiar.Enabled = true;
            btEliminar.Enabled = true;
            btIngresar.Enabled = true;
        }
    }
}