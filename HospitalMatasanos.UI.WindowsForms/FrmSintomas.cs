using HospitalMatasanos.EntidadesDeNegocio;
using HospitalMatasanos.LogicaDeNegocio;
using HospitalMatasanos.UI.WindowsForms.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMatasanos.UI.WindowsForms
{
    public partial class FrmSintomas : Form
    {
        public FrmSintomas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmSintoma frmSintoma = new FrmSintoma();
            frmSintoma.StartPosition = FormStartPosition.CenterScreen;
            frmSintoma.ShowDialog();
            MostrarSintomas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            byte Id = (Byte)UFormulario.ObtenerIdGrid(dgvSintomas);
            if (Id > 0)
            {
                FrmSintoma frmSintoma = new FrmSintoma();
                frmSintoma.StartPosition = FormStartPosition.CenterScreen;
                frmSintoma._IdSintoma = Id;
                frmSintoma.ShowDialog();
                MostrarSintomas();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro para modificar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            byte Id = (Byte)UFormulario.ObtenerIdGrid(dgvSintomas);
            if (Id > 0)
            {
                if (MessageBox.Show("Desea Elimnar", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (SintomaBL.Eliminar(new Sintoma { IdSintoma = Id }) > 0)
                    {
                        MessageBox.Show("Registro Eliminado");
                        MostrarSintomas();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        private void FrmSintomas_Load(object sender, EventArgs e)
        {
            MostrarSintomas();
        }

        private void MostrarSintomas()
        {
            dgvSintomas.DataSource = SintomaBL.ObtenerTodos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Sintoma sintoma = new Sintoma
            {
                CondicionMedica = txtCondicionMedica.Text,
            };

            dgvSintomas.DataSource = SintomaBL.Buscar(sintoma);
        }
    }
}
