using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HospitalMatasanos.EntidadesDeNegocio;
using HospitalMatasanos.LogicaDeNegocio;
using HospitalMatasanos.UI.WindowsForms.Util;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace HospitalMatasanos.UI.WindowsForms
{
    public partial class FrmEspecialidad : Form
    {
        Especialidad especialidad = new Especialidad();
        public int Id = 0;
        public FrmEspecialidad()
        {
            InitializeComponent();
        }

        private void dgvEspecialidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MostraEspecialidades();
        }
        private void MostraEspecialidades()
        {
            dgvEspecialidad.DataSource = EspecialidadBL.ObtenerTodos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Especialidad especialidad = new Especialidad
            {
                Nombre = txtNombre.Text,
            };

            dgvEspecialidad.DataSource = EspecialidadBL.Buscar(especialidad);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEspecialidades frmEspecialidad = new FrmEspecialidades();
            frmEspecialidad.StartPosition = FormStartPosition.CenterScreen;
            frmEspecialidad.ShowDialog();
            MostraEspecialidades();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int Id = (int)UFormulario.ObtenerIdGrid(dgvEspecialidad);
            if (Id > 0)
            {
                FrmEspecialidades frmEspecialidad = new FrmEspecialidades();
                frmEspecialidad.StartPosition = FormStartPosition.CenterScreen;
                frmEspecialidad.Id = Id;
                frmEspecialidad.ShowDialog();
                MostraEspecialidades();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro para modificar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int Id = (int)UFormulario.ObtenerIdGrid(dgvEspecialidad);
            if (Id > 0)
            {
                if (MessageBox.Show("Desea Elimnar", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (EspecialidadBL.Eliminar(new Especialidad { Id = Id }) > 0)
                    {
                        MessageBox.Show("Registro Eliminado");
                        MostraEspecialidades();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }
    }
    
}
