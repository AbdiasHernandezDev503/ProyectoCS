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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartamentos frmDepartamentos = new FrmDepartamentos();
            frmDepartamentos.StartPosition = FormStartPosition.CenterScreen;
            frmDepartamentos.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sintomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSintomas frmSintomas = new FrmSintomas();
            frmSintomas.StartPosition = FormStartPosition.CenterScreen;
            frmSintomas.ShowDialog();   
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
