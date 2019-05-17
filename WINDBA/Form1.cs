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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void empleadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.empresa);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empresa.Empleados' table. You can move, or remove it, as needed.
            this.empleadosTableAdapter.Fill(this.empresa.Empleados);

        }

        private void BFiltros_Click(object sender, EventArgs e)
        {
            Filtros vFiltros = new Filtros();

            vFiltros.Show();
        }
    }
}
