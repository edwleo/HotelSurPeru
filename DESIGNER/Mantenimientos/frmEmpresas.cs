using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BOL;

namespace DESIGNER.Mantenimientos
{
    public partial class frmEmpresas : Form
    {
        Empresa empresa = new Empresa();

        public frmEmpresas()
        {
            InitializeComponent();
        }

        private void frmEmpresas_Load(object sender, EventArgs e)
        {
            gridEmpresas.DataSource = empresa.listasActivos();
        }
    }
}
