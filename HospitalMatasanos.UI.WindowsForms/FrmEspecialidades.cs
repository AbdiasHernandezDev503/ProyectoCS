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
using HospitalMatasanos.EntidadesDeNegocio;
using HospitalMatasanos.LogicaDeNegocio;
using HospitalMatasanos.UI.WindowsForms.Util;

namespace HospitalMatasanos.UI.WindowsForms
{
    public partial class FrmEspecialidades : Form
    {
        Especialidad especialidad = new Especialidad();
        public int Id = 0; 
        public FrmEspecialidades()
        {
            InitializeComponent();
        }

        private void FrmEspecialidades_Load(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                CargarDatos();
            }
        }
        private void CargarDatos()
        {
            especialidad = EspecialidadBL.BuscarPorId(Id);
            if (especialidad.Id > 0)
            {
                txtNombre.Text = especialidad.Nombre;
            }
            else
            {
                MessageBox.Show("Ocurrio un problema al cargar datos");
                this.Close();
            }
        }
        private bool ValidarDatosFormulario()
        {
            bool validar = false;
            if (txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nombre Especialidad, es obligatorio");
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
                    especialidad.Nombre = txtNombre.Text;
                    if (Id <= 0)
                    {
                        if (EspecialidadBL.Guardar(especialidad) > 0)
                        {
                            MessageBox.Show("Registro exitoso");
                            this.Close();
                        }
                    }
                    else
                    {
                        if (EspecialidadBL.Modificar(especialidad) > 0)
                        {
                            MessageBox.Show("Registro exitoso");
                            this.Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
               MessageBox.Show("Ocurrio el siguinte error al guardar" + ex);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
