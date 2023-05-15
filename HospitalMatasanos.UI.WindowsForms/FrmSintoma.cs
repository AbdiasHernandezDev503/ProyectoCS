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

namespace HospitalMatasanos.UI.WindowsForms
{
    public partial class FrmSintoma : Form
    {
        Sintoma sintoma = new Sintoma();
        public int _IdSintoma = 0;
        public FrmSintoma()
        {
            InitializeComponent();
        }

        private void FrmSintoma_Load(object sender, EventArgs e)
        {
            if (_IdSintoma > 0)
            {
                CargarDatos();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarDatosFormulario()
        {
            bool validar = false;
            if (txtCondicionMedica.Text.Trim().Equals(""))
            {
                MessageBox.Show("Sintoma es obligatorio");
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
                    sintoma.CondicionMedica = txtCondicionMedica.Text;
                    if (_IdSintoma <= 0)
                    {
                        if (SintomaBL.Guardar(sintoma) > 0)
                        {
                            MessageBox.Show("Registro exitoso");
                            this.Close();
                        }
                    }
                    else
                    {
                        if (SintomaBL.Modificar(sintoma) > 0)
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

        private void CargarDatos()
        {
            sintoma = SintomaBL.BuscarPorId(_IdSintoma);
            if (sintoma.IdSintoma > 0)
            {
                txtCondicionMedica.Text = sintoma.CondicionMedica;
            }
            else
            {
                MessageBox.Show("Ocurrio un problema al cargar datos");
                this.Close();
            }
        }
    }
}
