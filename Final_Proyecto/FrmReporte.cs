using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Final_Proyecto
{
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = DatosGlobales.ListaDatos;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            var excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            var workbook = excel.Workbooks.Add();
            var worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

            for (int i = 0; i < dgvDatos.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dgvDatos.Columns[i].HeaderText;
            }

            for (int i = 0; i < dgvDatos.Rows.Count; i++)
            {
                for (int j = 0; j < dgvDatos.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvDatos.Rows[i].Cells[j].Value;
                }
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmMonitoreo monitoreo = new FrmMonitoreo();
            monitoreo.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
