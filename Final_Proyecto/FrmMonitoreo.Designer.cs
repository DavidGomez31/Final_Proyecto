namespace Final_Proyecto
{
    partial class FrmMonitoreo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.pbQuimicos = new System.Windows.Forms.ProgressBar();
            this.pbMetales = new System.Windows.Forms.ProgressBar();
            this.pbTurbidez = new System.Windows.Forms.ProgressBar();
            this.pbPH = new System.Windows.Forms.ProgressBar();
            this.txtQuimicos = new System.Windows.Forms.TextBox();
            this.txtMetales = new System.Windows.Forms.TextBox();
            this.txtTurbidez = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.btnIrReporte = new System.Windows.Forms.Button();
            this.timerSimulacion = new System.Windows.Forms.Timer(this.components);
            this.chartMonitoreo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvValores = new System.Windows.Forms.DataGridView();
            this.btnDetenerSimulacion = new System.Windows.Forms.Button();
            this.lblAlerta = new System.Windows.Forms.Label();
            this.gbParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonitoreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(20, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(158, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Monitoreo del Rio Suarez";
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.pbQuimicos);
            this.gbParametros.Controls.Add(this.pbMetales);
            this.gbParametros.Controls.Add(this.pbTurbidez);
            this.gbParametros.Controls.Add(this.pbPH);
            this.gbParametros.Controls.Add(this.txtQuimicos);
            this.gbParametros.Controls.Add(this.txtMetales);
            this.gbParametros.Controls.Add(this.txtTurbidez);
            this.gbParametros.Controls.Add(this.label4);
            this.gbParametros.Controls.Add(this.label3);
            this.gbParametros.Controls.Add(this.label2);
            this.gbParametros.Controls.Add(this.txtPH);
            this.gbParametros.Controls.Add(this.label1);
            this.gbParametros.Location = new System.Drawing.Point(34, 133);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(478, 213);
            this.gbParametros.TabIndex = 1;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parametros";
            // 
            // pbQuimicos
            // 
            this.pbQuimicos.Location = new System.Drawing.Point(294, 146);
            this.pbQuimicos.Maximum = 75;
            this.pbQuimicos.Name = "pbQuimicos";
            this.pbQuimicos.Size = new System.Drawing.Size(145, 24);
            this.pbQuimicos.TabIndex = 9;
            // 
            // pbMetales
            // 
            this.pbMetales.Location = new System.Drawing.Point(294, 109);
            this.pbMetales.Maximum = 50;
            this.pbMetales.Name = "pbMetales";
            this.pbMetales.Size = new System.Drawing.Size(145, 24);
            this.pbMetales.TabIndex = 8;
            // 
            // pbTurbidez
            // 
            this.pbTurbidez.Location = new System.Drawing.Point(294, 71);
            this.pbTurbidez.Name = "pbTurbidez";
            this.pbTurbidez.Size = new System.Drawing.Size(145, 24);
            this.pbTurbidez.TabIndex = 7;
            // 
            // pbPH
            // 
            this.pbPH.Location = new System.Drawing.Point(294, 31);
            this.pbPH.Maximum = 14;
            this.pbPH.Name = "pbPH";
            this.pbPH.Size = new System.Drawing.Size(145, 24);
            this.pbPH.TabIndex = 6;
            // 
            // txtQuimicos
            // 
            this.txtQuimicos.Location = new System.Drawing.Point(181, 146);
            this.txtQuimicos.Name = "txtQuimicos";
            this.txtQuimicos.Size = new System.Drawing.Size(75, 22);
            this.txtQuimicos.TabIndex = 2;
            this.txtQuimicos.TextChanged += new System.EventHandler(this.txtQuimicos_TextChanged);
            // 
            // txtMetales
            // 
            this.txtMetales.Location = new System.Drawing.Point(181, 109);
            this.txtMetales.Name = "txtMetales";
            this.txtMetales.Size = new System.Drawing.Size(75, 22);
            this.txtMetales.TabIndex = 2;
            this.txtMetales.TextChanged += new System.EventHandler(this.txtMetales_TextChanged);
            // 
            // txtTurbidez
            // 
            this.txtTurbidez.Location = new System.Drawing.Point(181, 73);
            this.txtTurbidez.Name = "txtTurbidez";
            this.txtTurbidez.Size = new System.Drawing.Size(75, 22);
            this.txtTurbidez.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Residuos Quimicos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Metales Pesados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Turbidez";
            // 
            // txtPH
            // 
            this.txtPH.Location = new System.Drawing.Point(181, 33);
            this.txtPH.Name = "txtPH";
            this.txtPH.Size = new System.Drawing.Size(75, 22);
            this.txtPH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "pH";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(60, 390);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(180, 33);
            this.btnSimular.TabIndex = 2;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // btnIrReporte
            // 
            this.btnIrReporte.Location = new System.Drawing.Point(561, 403);
            this.btnIrReporte.Name = "btnIrReporte";
            this.btnIrReporte.Size = new System.Drawing.Size(196, 35);
            this.btnIrReporte.TabIndex = 3;
            this.btnIrReporte.Text = "Reporte";
            this.btnIrReporte.UseVisualStyleBackColor = true;
            this.btnIrReporte.Click += new System.EventHandler(this.btnIrReporte_Click);
            // 
            // timerSimulacion
            // 
            this.timerSimulacion.Interval = 2000;
            this.timerSimulacion.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chartMonitoreo
            // 
            chartArea4.Name = "ChartArea1";
            this.chartMonitoreo.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartMonitoreo.Legends.Add(legend4);
            this.chartMonitoreo.Location = new System.Drawing.Point(534, 45);
            this.chartMonitoreo.Name = "chartMonitoreo";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "pH";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Turbidez";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "Metales";
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "Quimicos";
            this.chartMonitoreo.Series.Add(series13);
            this.chartMonitoreo.Series.Add(series14);
            this.chartMonitoreo.Series.Add(series15);
            this.chartMonitoreo.Series.Add(series16);
            this.chartMonitoreo.Size = new System.Drawing.Size(242, 143);
            this.chartMonitoreo.TabIndex = 5;
            this.chartMonitoreo.Text = "chart1";
            this.chartMonitoreo.Click += new System.EventHandler(this.chart1_Click);
            // 
            // dgvValores
            // 
            this.dgvValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValores.Location = new System.Drawing.Point(539, 204);
            this.dgvValores.Name = "dgvValores";
            this.dgvValores.RowHeadersWidth = 51;
            this.dgvValores.RowTemplate.Height = 24;
            this.dgvValores.Size = new System.Drawing.Size(236, 178);
            this.dgvValores.TabIndex = 6;
            this.dgvValores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvValores_CellContentClick);
            // 
            // btnDetenerSimulacion
            // 
            this.btnDetenerSimulacion.Location = new System.Drawing.Point(267, 390);
            this.btnDetenerSimulacion.Name = "btnDetenerSimulacion";
            this.btnDetenerSimulacion.Size = new System.Drawing.Size(169, 33);
            this.btnDetenerSimulacion.TabIndex = 7;
            this.btnDetenerSimulacion.Text = "Detener Simulacion";
            this.btnDetenerSimulacion.UseVisualStyleBackColor = true;
            this.btnDetenerSimulacion.Click += new System.EventHandler(this.btnDetenerSimulacion_Click);
            // 
            // lblAlerta
            // 
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.Location = new System.Drawing.Point(72, 61);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(42, 16);
            this.lblAlerta.TabIndex = 8;
            this.lblAlerta.Text = "Alerta";
            // 
            // FrmMonitoreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAlerta);
            this.Controls.Add(this.btnDetenerSimulacion);
            this.Controls.Add(this.dgvValores);
            this.Controls.Add(this.chartMonitoreo);
            this.Controls.Add(this.btnIrReporte);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.gbParametros);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmMonitoreo";
            this.Text = "f";
            this.Load += new System.EventHandler(this.FrmMonitoreo_Load);
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonitoreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuimicos;
        private System.Windows.Forms.TextBox txtMetales;
        private System.Windows.Forms.TextBox txtTurbidez;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Button btnIrReporte;
        private System.Windows.Forms.Timer timerSimulacion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonitoreo;
        private System.Windows.Forms.DataGridView dgvValores;
        private System.Windows.Forms.Button btnDetenerSimulacion;
        private System.Windows.Forms.ProgressBar pbQuimicos;
        private System.Windows.Forms.ProgressBar pbMetales;
        private System.Windows.Forms.ProgressBar pbTurbidez;
        private System.Windows.Forms.ProgressBar pbPH;
        private System.Windows.Forms.Label lblAlerta;
    }
}