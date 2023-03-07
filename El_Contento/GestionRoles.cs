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
    public partial class GestionRoles : Form
    {
        SqlConnection objConector;
        SqlDataReader objTabla;
        SqlCommand objConsulta;
        string comando = "", nombre = "", rol = "";
        int documento = 0;

        public GestionRoles()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btDeshacer_Click(object sender, EventArgs e)
        {
            txDocumento.Text = "";
            txDocumento.Focus();
        }

        private void btEliminar_Click(object sender, EventArgs e)
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
                    documento = Int32.Parse(txDocumento.Text);
                    comando = "DELETE FROM ROLES WHERE DOCUMENTO = " + documento;

                    try
                    {
                        objConsulta = new SqlCommand(comando, objConector);
                        int n = objConsulta.ExecuteNonQuery();

                        if (n > 0)
                        {
                            MessageBox.Show("La persona se ha eliminado de la base de datos exitosamente!");
                        }
                        else
                        {
                            MessageBox.Show("Error, la persona no se encuentra registrada en la base de datos.");
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
                txDocumento.Focus();
            }
        }

        private void btIngresar_Click(object sender, EventArgs e)
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
                    documento = Int32.Parse(txDocumento.Text);
                    comando = "SELECT * FROM ROLES WHERE DOCUMENTO = " + documento;

                    try
                    {
                        objConsulta = new SqlCommand(comando, objConector);
                        objTabla = objConsulta.ExecuteReader();

                        if (objTabla.Read())
                        {
                            MessageBox.Show("Error, el usuario ya esta registrado en la tabla.");
                        }
                        else
                        {
                            txDocumentoIngreso.Text = documento.ToString();
                            gbIngresar.Visible = true;

                            btIngresar.Enabled = false;
                            btConsultar.Enabled = false;
                            btActualizar.Enabled = false;
                            btEliminar.Enabled = false;
                            btDeshacer.Enabled = false;
                            btSalir.Enabled = false;
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

                DB.cerrar(objConector);
                gbIngresar.Visible = true;
            }
        }

        private void btIngresarIngreso_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txNombre.Text) || string.IsNullOrEmpty(cbRol.Text))
            {
                MessageBox.Show("Error, debe llenar el campo requerido.");
            }
            else
            {
                try
                {
                    objConector = DB.conectar("ALUMNOS_EL_CONTENTO");
                    documento = Int32.Parse(txDocumentoIngreso.Text);
                    nombre = txNombre.Text;
                    rol = cbRol.Text;
                    comando = "INSERT INTO ROLES VALUES(" + documento + ", UPPER('" + nombre + "'), '" + rol + "')";

                    try
                    {
                        objConsulta = new SqlCommand(comando, objConector);
                        int n = objConsulta.ExecuteNonQuery();

                        if (n > 0)
                        {
                            MessageBox.Show("Los datos se registraron exitosamente!");
                            txDocumentoIngreso.Text = "";
                            txNombre.Text = "";
                            cbRol.Text = "";

                            btIngresar.Enabled = true;
                            btConsultar.Enabled = true;
                            btActualizar.Enabled = true;
                            btEliminar.Enabled = true;
                            btDeshacer.Enabled = true;
                            btSalir.Enabled = true;

                            gbIngresar.Visible = false;

                            txDocumento.Text = "";
                            txDocumento.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Error, no se pudieron ingresar los datos.");
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

                DB.cerrar(objConector);
                gbIngresar.Visible = false;
            }
        }

        private void btDeshacerIngreso_Click(object sender, EventArgs e)
        {
            txNombre.Text = "";
            cbRol.Text = "";
        }

        private void btSalirConsulta_Click(object sender, EventArgs e)
        {
            txNombreConsulta.Text = "";
            txRol.Text = "";
            gbConsultar.Visible = false;
            txDocumento.Text = "";
            txDocumento.Focus();

            btIngresar.Enabled = true;
            btConsultar.Enabled = true;
            btActualizar.Enabled = true;
            btEliminar.Enabled = true;
            btDeshacer.Enabled = true;
            btSalir.Enabled = true;
        }

        private void btActualizar_Click(object sender, EventArgs e)
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
                    documento = Int32.Parse(txDocumento.Text);
                    comando = "SELECT * FROM ROLES WHERE DOCUMENTO = " + documento;

                    try
                    {
                        objConsulta = new SqlCommand(comando, objConector);
                        objTabla = objConsulta.ExecuteReader();

                        if (objTabla.Read())
                        {
                            txNombreActualizar.Text = objTabla[1].ToString();
                            txRolActual.Text = objTabla[2].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Error, no se encontro a la persona en la base de datos.");
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
                gbActualizarRol.Visible = true;
            }
        }

        private void btActualizarActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbNuevoRol.Text))
            {
                MessageBox.Show("Error, debe llenar el campo requerido.");
            }
            else
            {
                try
                {
                    objConector = DB.conectar("ALUMNOS_EL_CONTENTO");
                    nombre = txNombreActualizar.Text;
                    documento = Int32.Parse(txDocumento.Text);
                    rol = cbNuevoRol.Text;
                    comando = "UPDATE ROLES SET TIPOROL = '" + rol + "' WHERE DOCUMENTO = " + documento;

                    try
                    {
                        objConsulta = new SqlCommand(comando, objConector);
                        int n = objConsulta.ExecuteNonQuery();

                        if (n > 0)
                        {
                            MessageBox.Show("El rol de " + nombre + " fue actualizado exitosamente!");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo realizar la actualizacion.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    DB.cerrar(objConector);
                    gbActualizarRol.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btSalirActualizar_Click(object sender, EventArgs e)
        {
            txNombreActualizar.Text = "";
            txRolActual.Text = "";
            cbNuevoRol.Text = "";
            gbActualizarRol.Visible = false;
        }

        private void btSalirIngreso_Click(object sender, EventArgs e)
        {
            txNombre.Text = "";
            cbRol.Text = "";
            txDocumentoIngreso.Text = "";
            gbIngresar.Visible = false;

            txDocumento.Text = "";
            txDocumento.Focus();

            btIngresar.Enabled = true;
            btConsultar.Enabled = true;
            btActualizar.Enabled = true;
            btEliminar.Enabled = true;
            btDeshacer.Enabled = true;
            btSalir.Enabled = true;
        }

        private void btConsultar_Click(object sender, EventArgs e)
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
                    documento = Int32.Parse(txDocumento.Text);
                    comando = "SELECT * FROM ROLES WHERE DOCUMENTO = " + documento;

                    try
                    {
                        objConsulta = new SqlCommand(comando, objConector);
                        objTabla = objConsulta.ExecuteReader();

                        if (objTabla.Read())
                        {
                            txNombreConsulta.Text = objTabla[1].ToString();
                            txRol.Text = objTabla[2].ToString();
                        }
                        else
                        {
                            MessageBox.Show("La persona no se encuentra registrada en la base de datos.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    DB.cerrar(objConector);
                    gbConsultar.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
