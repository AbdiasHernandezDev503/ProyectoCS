using HospitalMatasanos.EntidadesDeNegocio;
using HospitalMatasanos.LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalMatasanos.UI.WindowsForms.Util;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace HospitalMatasanos.UI.WindowsForms
{
    public partial class FrmDepartamentos : Form
    {
        public FrmDepartamentos()
        {
            InitializeComponent();
        }
        private void MostraDepartamentos()
        {
            dgvDepartamento.DataSource = DepartamentoBL.ObtenerTodos();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FrmDepartamento frmDepartamentos = new FrmDepartamento();
            frmDepartamentos.StartPosition = FormStartPosition.CenterScreen;
            frmDepartamentos.ShowDialog();
            MostraDepartamentos();
        }
        private void FrmDepartamentos_Load(object sender, EventArgs e)
        {
            MostraDepartamentos();
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Departamento departamento = new Departamento
            {
                nombre = txtNombre.Text,
            };

            dgvDepartamento.DataSource = DepartamentoBL.Buscar(departamento);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            byte Id = (Byte)UFormulario.ObtenerIdGrid(dgvDepartamento);
            if (Id > 0)
            {
                FrmDepartamento frmDepartamento = new FrmDepartamento();
                frmDepartamento.StartPosition = FormStartPosition.CenterScreen;
                frmDepartamento.Id = Id;
                frmDepartamento.ShowDialog();
                MostraDepartamentos();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro para modificar");
            }
        }

        private void btnElimar_Click(object sender, EventArgs e)
        {
            byte Id = (Byte)UFormulario.ObtenerIdGrid(dgvDepartamento);
            if (Id > 0)
            {
                if (MessageBox.Show("Desea Elimnar", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (DepartamentoBL.Eliminar(new Departamento { Id = Id }) > 0)
                    {
                        MessageBox.Show("Registro Eliminado");
                        MostraDepartamentos();
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
