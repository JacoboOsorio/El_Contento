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
    public partial class MateriaGrupo : Form
    {
        public MateriaGrupo()
        {
            InitializeComponent();
        }

        private void mATERIASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mATERIASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aLUMNOS_EL_CONTENTODataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aLUMNOS_EL_CONTENTODataSet.ESTUDIANTES' Puede moverla o quitarla según sea necesario.
            this.eSTUDIANTESTableAdapter.Fill(this.aLUMNOS_EL_CONTENTODataSet.ESTUDIANTES);
            // TODO: esta línea de código carga datos en la tabla 'aLUMNOS_EL_CONTENTODataSet.GRUPOS' Puede moverla o quitarla según sea necesario.
            this.gRUPOSTableAdapter.Fill(this.aLUMNOS_EL_CONTENTODataSet.GRUPOS);
            // TODO: esta línea de código carga datos en la tabla 'aLUMNOS_EL_CONTENTODataSet.MATERIAS' Puede moverla o quitarla según sea necesario.
            this.mATERIASTableAdapter.Fill(this.aLUMNOS_EL_CONTENTODataSet.MATERIAS);

        }
    }
}
