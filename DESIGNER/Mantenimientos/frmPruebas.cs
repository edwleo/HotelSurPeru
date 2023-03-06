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
    public partial class frmPruebas : Form
    {
        Empresa empresa = new Empresa();

        DataTable dt = new DataTable(); //Contener los registros obtenidos desde la BD
        DataView dv = new DataView();   //Objeto que permite filtros asincrónicos

        string campoFiltro = "razonsocial";

        public frmPruebas()
        {
            InitializeComponent();
        }

        private void cargaDatos()
        {
            dt = empresa.listarActivos();
            gridEmpresas.DataSource = dt;
            gridEmpresas.Refresh();
            dv = dt.DefaultView;    //Asociación/conexión 

            //Paso 1 (agregar columna boton icono)
            //Instancia de un botón de columna
            DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
            //Nombre botón de cada fila del grid
            btnCol.Name = "Editar";
            gridEmpresas.Columns.Add(btnCol);
        }

        private void frmPruebas_Load(object sender, EventArgs e)
        {
            cargaDatos();

            //Configuramos el datagridview
            gridEmpresas.Columns[0].Width = 50; //id
            gridEmpresas.Columns[1].Width = 200; //razonsocial
            gridEmpresas.Columns[2].Width = 100; //ruc
            gridEmpresas.Columns[3].Width = 320; //direccion
            gridEmpresas.Columns[4].Width = 100; //telefono
            gridEmpresas.Columns[5].Width = 200; //email
        }

        private void txtValorBuscado_TextChanged(object sender, EventArgs e)
        {
            if (txtValorBuscado.Text.Trim() != String.Empty)
            {
                dv.RowFilter = campoFiltro + " LIKE '%" + txtValorBuscado.Text.Trim() + "%'";
            }
            else
            {
                gridEmpresas.ClearSelection();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargaDatos();
        }

        private void optRazonSocial_CheckedChanged(object sender, EventArgs e)
        {
            campoFiltro = "razonsocial";
        }

        private void optRUC_CheckedChanged(object sender, EventArgs e)
        {
            campoFiltro = "ruc";
        }

        private void gridEmpresas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && gridEmpresas.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                //Render (pintar) icono dentro del botón
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);  //Utiliza todo el espacio disponible

                //Construir icono
                DataGridViewButtonCell celButton = gridEmpresas.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
                //Imagen (archivo ICO)
                Icon icono = new Icon(Environment.CurrentDirectory + @"\edit.ico");
                //Pintar el icono
                e.Graphics.DrawIcon(icono, e.CellBounds.Left + 7, e.CellBounds.Top + 7);

                //Enviamos al grid
                gridEmpresas.Rows[e.RowIndex].Height = icono.Height + 15;
                gridEmpresas.Columns[e.ColumnIndex].Width = icono.Width + 15;

                //Activamos el control de eventos sobre el nuevo boton
                e.Handled = true;
            }
        }

        private void gridEmpresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Identificar sobre qué columna/boton se pulsó click
            if (gridEmpresas.Columns[e.ColumnIndex].Name == "Editar")
            {
                int idempresa = Convert.ToInt32(gridEmpresas.CurrentRow.Cells[0].Value);
                MessageBox.Show("El ID seleccionado es: " + idempresa.ToString());
            }
        }
    }
}
