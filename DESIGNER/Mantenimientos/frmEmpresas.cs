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
            gridEmpresas.DataSource = empresa.listarActivos();
            gridEmpresas.Refresh();

            //Configuramos el datagridview
            gridEmpresas.Columns[0].Width = 50; //id
            gridEmpresas.Columns[1].Width = 220; //razonsocial
            gridEmpresas.Columns[2].Width = 100; //ruc
            gridEmpresas.Columns[3].Width = 350; //direccion
            gridEmpresas.Columns[4].Width = 100; //telefono
            gridEmpresas.Columns[5].Width = 200; //email
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Primero la validación
            if (txtRazonSocial.Text.Trim() == String.Empty || 
                txtRUC.Text.Trim().Length != 11 || 
                txtDireccion.Text.Trim() == String.Empty)
            {
                MessageBox.Show(
                    "Complete los 3 primeros campos por favor", 
                    "Hotel Ver. 1", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show(
                    "¿Registramos la empresa?",
                    "Hotel Ver. 1",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    empresa.registrar(txtRazonSocial.Text, txtRUC.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);
                    gridEmpresas.DataSource = empresa.listarActivos();
                    gridEmpresas.Refresh();

                    txtRazonSocial.Clear();
                    txtRUC.Clear();
                    txtDireccion.Clear();
                    txtTelefono.Clear();
                    txtEmail.Clear();
                }
            }
        }
    }
}
