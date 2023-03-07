using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Contento
{
    public partial class GruposAlumnos : Form
    {
        public GruposAlumnos()
        {
            InitializeComponent();
        }

        private void eSTUDIANTESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eSTUDIANTESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aLUMNOS_EL_CONTENTODataSet);

        }

        private void MaestroDetalle_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aLUMNOS_EL_CONTENTODataSet1.GRUPOS' Puede moverla o quitarla según sea necesario.
            this.gRUPOSTableAdapter1.Fill(this.aLUMNOS_EL_CONTENTODataSet1.GRUPOS);
            // TODO: esta línea de código carga datos en la tabla 'aLUMNOS_EL_CONTENTODataSet1.MATERIAS' Puede moverla o quitarla según sea necesario.
            this.mATERIASTableAdapter1.Fill(this.aLUMNOS_EL_CONTENTODataSet1.MATERIAS);
            // TODO: esta línea de código carga datos en la tabla 'aLUMNOS_EL_CONTENTODataSet1.ESTUDIANTES' Puede moverla o quitarla según sea necesario.
            this.eSTUDIANTESTableAdapter1.Fill(this.aLUMNOS_EL_CONTENTODataSet1.ESTUDIANTES);
            // TODO: esta línea de código carga datos en la tabla 'aLUMNOS_EL_CONTENTODataSet.MATERIAS' Puede moverla o quitarla según sea necesario.
            this.mATERIASTableAdapter.Fill(this.aLUMNOS_EL_CONTENTODataSet.MATERIAS);
            // TODO: esta línea de código carga datos en la tabla 'aLUMNOS_EL_CONTENTODataSet.GRUPOS' Puede moverla o quitarla según sea necesario.
            this.gRUPOSTableAdapter.Fill(this.aLUMNOS_EL_CONTENTODataSet.GRUPOS);
            // TODO: esta línea de código carga datos en la tabla 'aLUMNOS_EL_CONTENTODataSet.ESTUDIANTES' Puede moverla o quitarla según sea necesario.
            this.eSTUDIANTESTableAdapter.Fill(this.aLUMNOS_EL_CONTENTODataSet.ESTUDIANTES);

        }
    }
}
