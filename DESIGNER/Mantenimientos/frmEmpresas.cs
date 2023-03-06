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
using DESIGNER.Herramientas;
using ENTITIES;

namespace DESIGNER.Mantenimientos
{
    public partial class frmEmpresas : Form
    {
        Empresa empresa = new Empresa();
        EEmpresa entidadEmpresa = new EEmpresa();

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
                Dialogo.Informar("Complete los 3 primeros campos por favor");
            }
            else
            {
                if (Dialogo.Preguntar("¿Registramos la empresa?") == DialogResult.Yes)
                {
                    //Enviar los valores de las cajas de texto a la entidad
                    entidadEmpresa.razonSocial = txtRazonSocial.Text.Trim();
                    entidadEmpresa.ruc = txtRUC.Text.Trim();
                    entidadEmpresa.direccion = txtDireccion.Text.Trim();
                    entidadEmpresa.telefono = txtTelefono.Text.Trim();
                    entidadEmpresa.email = txtEmail.Text.Trim();
                    
                    //La entidad es enviada al método como parámetro
                    if (empresa.registrar(entidadEmpresa) > 0)
                    {
                        //Comportamientos postinserción de datos
                        gridEmpresas.DataSource = empresa.listarActivos();
                        gridEmpresas.Refresh();

                        txtRazonSocial.Clear();
                        txtRUC.Clear();
                        txtDireccion.Clear();
                        txtTelefono.Clear();
                        txtEmail.Clear();
                    }
                    else
                    {
                        Dialogo.Error("Error, no se pudo guardar el registro");
                    }
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
