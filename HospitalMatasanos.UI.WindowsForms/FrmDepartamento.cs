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
namespace HospitalMatasanos.UI.WindowsForms
{
    public partial class FrmDepartamento : Form
    {
        Departamento departamento = new Departamento();
        public int Id = 0;

        public byte IdDepartamento { get; private set; }

        public FrmDepartamento()
        {
            InitializeComponent();
        }
        private bool ValidarDatosFormulario()
        {
            bool validar = false;
            if (txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nombre Departamento, es obligatorio");
                validar = true;
            }
            return validar;
        }
        private void Guardar()
        {
            try
            {
                if (!ValidarDatosFormulario())
                {
                    departamento.nombre = txtNombre.Text;
                    if (Id <= 0)
                    {
                        if (DepartamentoBL.Guardar(departamento) > 0)
                        {
                            MessageBox.Show("Registro exitoso");
                            this.Close();
                        }
                    }
                    else
                    {
                        if (DepartamentoBL.Modificar(departamento) > 0)
                        {
                            MessageBox.Show("Registro exitoso");
                            this.Close();
                        }
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un al intentar guardar");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void FrmDepartamento_Load(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                CargarDatos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
       private void CargarDatos()
       {

       }

    }
}
