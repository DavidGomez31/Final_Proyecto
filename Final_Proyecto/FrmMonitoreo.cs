using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Proyecto
{
    public partial class FrmMonitoreo : Form
    {
        Random rnd = new Random();
        public FrmMonitoreo()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            timerSimulacion.Start();
        }

        private void btnIrReporte_Click(object sender, EventArgs e)
        {
            FrmReporte frm = new FrmReporte();
            frm.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmMonitoreo monitoreo = new FrmMonitoreo();
            monitoreo.Show();
            this.Hide();
        }

        private void FrmMonitoreo_Load(object sender, EventArgs e)
        {
            // Opcionalmente inicializar campos
            txtPH.Text = "";
            txtTurbidez.Text = "";
            txtMetales.Text = "";
            txtQuimicos.Text = "";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            double ph = Math.Round(rnd.NextDouble() * 14, 2);
            double turbidez = Math.Round(rnd.NextDouble() * 100, 2);
            double metales = Math.Round(rnd.NextDouble() * 50, 2);
            double quimicos = Math.Round(rnd.NextDouble() * 75, 2);

            // Actualiza Chart
            chartMonitoreo.Series["pH"].Points.AddY(ph);
            chartMonitoreo.Series["Turbidez"].Points.AddY(turbidez);
            chartMonitoreo.Series["Metales"].Points.AddY(metales);
            chartMonitoreo.Series["Quimicos"].Points.AddY(quimicos);

            // Actualiza los TextBox con los valores actuales
            txtPH.Text = ph.ToString();
            txtTurbidez.Text = turbidez.ToString();
            txtMetales.Text = metales.ToString();
            txtQuimicos.Text = quimicos.ToString();

            // Actualiza ProgressBar
            pbPH.Value = (int)Math.Min(ph, pbPH.Maximum);
            pbTurbidez.Value = (int)Math.Min(turbidez, pbTurbidez.Maximum);
            pbMetales.Value = (int)Math.Min(metales, pbMetales.Maximum);
            pbQuimicos.Value = (int)Math.Min(quimicos, pbQuimicos.Maximum);

            // Guarda el dato
            DatosGlobales.ListaDatos.Add(new SensorData
            {
                FechaHora = DateTime.Now,
                PH = ph,
                Turbidez = turbidez,
                Metales = metales,
                Quimicos = quimicos
            });

            // Mostrar en el DataGridView
            dgvValores.DataSource = null;
            dgvValores.DataSource = DatosGlobales.ListaDatos;

            // Verificar alertas
            StringBuilder alerta = new StringBuilder();

            if (ph < 6.5 || ph > 8.5)
                alerta.AppendLine("⚠ Nivel de pH fuera del rango saludable.");

            if (turbidez > 50)
                alerta.AppendLine("⚠ Alta turbidez detectada.");

            if (metales > 30)
                alerta.AppendLine("⚠ Niveles peligrosos de metales.");

            if (quimicos > 50)
                alerta.AppendLine("⚠ Contaminación química excesiva.");

            // Mostrar alerta
            lblAlerta.Text = alerta.ToString();
            lblAlerta.ForeColor = alerta.Length > 0 ? Color.Red : Color.Black;

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void txtMetales_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuimicos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDetenerSimulacion_Click(object sender, EventArgs e)
        {
            timerSimulacion.Stop();
        }

        private void dgvValores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
