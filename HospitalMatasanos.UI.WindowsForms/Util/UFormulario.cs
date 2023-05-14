using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMatasanos.UI.WindowsForms.Util
{
    public class UFormulario
    {
        public static int ObtenerIdGrid(DataGridView dataGridView)
        {
            try
            {
                int Id = 0;
                Id = int.Parse(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value.ToString());
                return Id;
            }
            catch (Exception)
            {

                return 0;
            }
        }
    }
}
