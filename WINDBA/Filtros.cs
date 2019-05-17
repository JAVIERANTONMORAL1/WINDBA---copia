using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINDBA
{
    public partial class Filtros : Form
    {
        public Filtros()
        {
            InitializeComponent();
        }

        private void BFiltroSueldo_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            EmpresaTableAdapters.EmpleadosTableAdapter taEmpleados =
                new EmpresaTableAdapters.EmpleadosTableAdapter();

            bool fSueldo = int.TryParse(tDatoFiltro.Text, out int valor);

            if(fSueldo)
            {
                tabla = taEmpleados.SueldosMayoresQue(valor);
            }

            dgwFiltros.DataSource = tabla;
        }
    }
}
