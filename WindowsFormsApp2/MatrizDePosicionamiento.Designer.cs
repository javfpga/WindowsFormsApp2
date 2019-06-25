namespace WindowsFormsApp2
{
    partial class MatrizDePosicionamiento
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomEjeYTxT = new System.Windows.Forms.TextBox();
            this.nomEjeXTxT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.txtValorY = new System.Windows.Forms.TextBox();
            this.txtValorX = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.butAgregar = new System.Windows.Forms.Button();
            this.butGraficar = new System.Windows.Forms.Button();
            this.butEliminar = new System.Windows.Forms.Button();
            this.butGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LineWidth = 3;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Title = "Eje X";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LineWidth = 3;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineWidth = 2;
            chartArea1.AxisY.MajorTickMark.LineWidth = 2;
            chartArea1.AxisY.MajorTickMark.Size = 4F;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisY.Title = "Eje Y";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.Title = "Empresas";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(559, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(794, 687);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(393, 349);
            this.dataGridView1.TabIndex = 3;
            // 
            // nomEjeYTxT
            // 
            this.nomEjeYTxT.Location = new System.Drawing.Point(386, 586);
            this.nomEjeYTxT.Name = "nomEjeYTxT";
            this.nomEjeYTxT.Size = new System.Drawing.Size(100, 20);
            this.nomEjeYTxT.TabIndex = 25;
            // 
            // nomEjeXTxT
            // 
            this.nomEjeXTxT.Location = new System.Drawing.Point(386, 552);
            this.nomEjeXTxT.Name = "nomEjeXTxT";
            this.nomEjeXTxT.Size = new System.Drawing.Size(100, 20);
            this.nomEjeXTxT.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 581);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nombre Eje Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre Eje X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Valor Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Valor X";
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpresa.Location = new System.Drawing.Point(294, 437);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(86, 24);
            this.labelEmpresa.TabIndex = 19;
            this.labelEmpresa.Text = "Empresa";
            // 
            // txtValorY
            // 
            this.txtValorY.Location = new System.Drawing.Point(386, 494);
            this.txtValorY.MaxLength = 3;
            this.txtValorY.Name = "txtValorY";
            this.txtValorY.Size = new System.Drawing.Size(100, 20);
            this.txtValorY.TabIndex = 18;
            this.txtValorY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorY_KeyPress);
            // 
            // txtValorX
            // 
            this.txtValorX.Location = new System.Drawing.Point(386, 468);
            this.txtValorX.MaxLength = 3;
            this.txtValorX.Name = "txtValorX";
            this.txtValorX.Size = new System.Drawing.Size(100, 20);
            this.txtValorX.TabIndex = 17;
            this.txtValorX.TextChanged += new System.EventHandler(this.txtValorX_TextChanged);
            this.txtValorX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorX_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(386, 442);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // butAgregar
            // 
            this.butAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAgregar.Location = new System.Drawing.Point(58, 442);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(91, 34);
            this.butAgregar.TabIndex = 26;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // butGraficar
            // 
            this.butGraficar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGraficar.Location = new System.Drawing.Point(58, 482);
            this.butGraficar.Name = "butGraficar";
            this.butGraficar.Size = new System.Drawing.Size(91, 32);
            this.butGraficar.TabIndex = 27;
            this.butGraficar.Text = "Graficar";
            this.butGraficar.UseVisualStyleBackColor = true;
            this.butGraficar.Click += new System.EventHandler(this.butGraficar_Click);
            // 
            // butEliminar
            // 
            this.butEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEliminar.Location = new System.Drawing.Point(58, 520);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(91, 32);
            this.butEliminar.TabIndex = 28;
            this.butEliminar.Text = "Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.butEliminar_Click);
            // 
            // butGuardar
            // 
            this.butGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGuardar.Location = new System.Drawing.Point(58, 558);
            this.butGuardar.Name = "butGuardar";
            this.butGuardar.Size = new System.Drawing.Size(91, 32);
            this.butGuardar.TabIndex = 29;
            this.butGuardar.Text = "Guardar";
            this.butGuardar.UseVisualStyleBackColor = true;
            this.butGuardar.Click += new System.EventHandler(this.butGuardar_Click);
            // 
            // MatrizDePosicionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 711);
            this.Controls.Add(this.butGuardar);
            this.Controls.Add(this.butEliminar);
            this.Controls.Add(this.butGraficar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.nomEjeYTxT);
            this.Controls.Add(this.nomEjeXTxT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEmpresa);
            this.Controls.Add(this.txtValorY);
            this.Controls.Add(this.txtValorX);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Name = "MatrizDePosicionamiento";
            this.Text = "Matriz de Posicionamiento";
            this.Load += new System.EventHandler(this.MatrizDePosicionamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nomEjeYTxT;
        private System.Windows.Forms.TextBox nomEjeXTxT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.TextBox txtValorY;
        private System.Windows.Forms.TextBox txtValorX;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button butAgregar;
        private System.Windows.Forms.Button butGraficar;
        private System.Windows.Forms.Button butEliminar;
        private System.Windows.Forms.Button butGuardar;
    }
}