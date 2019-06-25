namespace WindowsFormsApp2
{
    partial class AnalisisDAFO
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOportunidad = new System.Windows.Forms.TextBox();
            this.butOportEliminar = new System.Windows.Forms.Button();
            this.listBoxOportunidad = new System.Windows.Forms.ListBox();
            this.butOportunidad = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.butDebEliminar = new System.Windows.Forms.Button();
            this.textBoxDebilidad = new System.Windows.Forms.TextBox();
            this.listBoxDebilidad = new System.Windows.Forms.ListBox();
            this.butDeb = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAmenaza = new System.Windows.Forms.TextBox();
            this.butAmenazaEliminar = new System.Windows.Forms.Button();
            this.listBoxAmenaza = new System.Windows.Forms.ListBox();
            this.butAmenaza = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFortaleza = new System.Windows.Forms.TextBox();
            this.butFortEliminar = new System.Windows.Forms.Button();
            this.listBoxFortaleza = new System.Windows.Forms.ListBox();
            this.butFortaleza = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1251, 721);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxOportunidad);
            this.panel1.Controls.Add(this.butOportEliminar);
            this.panel1.Controls.Add(this.listBoxOportunidad);
            this.panel1.Controls.Add(this.butOportunidad);
            this.panel1.Location = new System.Drawing.Point(629, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 353);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(220, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "OPORTUNIDADES";
            // 
            // textBoxOportunidad
            // 
            this.textBoxOportunidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOportunidad.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOportunidad.Location = new System.Drawing.Point(238, 6);
            this.textBoxOportunidad.Name = "textBoxOportunidad";
            this.textBoxOportunidad.Size = new System.Drawing.Size(380, 39);
            this.textBoxOportunidad.TabIndex = 7;
            this.textBoxOportunidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBoxOportunidad_KeyPress);
            // 
            // butOportEliminar
            // 
            this.butOportEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOportEliminar.Location = new System.Drawing.Point(137, 0);
            this.butOportEliminar.Name = "butOportEliminar";
            this.butOportEliminar.Size = new System.Drawing.Size(100, 50);
            this.butOportEliminar.TabIndex = 6;
            this.butOportEliminar.Text = "ELIMINAR";
            this.butOportEliminar.UseVisualStyleBackColor = true;
            this.butOportEliminar.Click += new System.EventHandler(this.butOportEliminar_Click);
            // 
            // listBoxOportunidad
            // 
            this.listBoxOportunidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxOportunidad.BackColor = System.Drawing.Color.LightGreen;
            this.listBoxOportunidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.listBoxOportunidad.FormattingEnabled = true;
            this.listBoxOportunidad.ItemHeight = 24;
            this.listBoxOportunidad.Location = new System.Drawing.Point(0, 50);
            this.listBoxOportunidad.Name = "listBoxOportunidad";
            this.listBoxOportunidad.Size = new System.Drawing.Size(621, 292);
            this.listBoxOportunidad.TabIndex = 1;
            this.listBoxOportunidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBoxOportunidad_KeyPress);
            // 
            // butOportunidad
            // 
            this.butOportunidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOportunidad.Location = new System.Drawing.Point(0, 0);
            this.butOportunidad.Name = "butOportunidad";
            this.butOportunidad.Size = new System.Drawing.Size(137, 50);
            this.butOportunidad.TabIndex = 0;
            this.butOportunidad.Text = "AÑADIR OPORTUNIDAD";
            this.butOportunidad.UseVisualStyleBackColor = true;
            this.butOportunidad.Click += new System.EventHandler(this.butOportunidad_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.butDebEliminar);
            this.panel2.Controls.Add(this.textBoxDebilidad);
            this.panel2.Controls.Add(this.listBoxDebilidad);
            this.panel2.Controls.Add(this.butDeb);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 353);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(198, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "DEBILIDADES";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(510, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butDebEliminar
            // 
            this.butDebEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDebEliminar.Location = new System.Drawing.Point(101, 0);
            this.butDebEliminar.Name = "butDebEliminar";
            this.butDebEliminar.Size = new System.Drawing.Size(100, 50);
            this.butDebEliminar.TabIndex = 4;
            this.butDebEliminar.Text = "ELIMINAR";
            this.butDebEliminar.UseVisualStyleBackColor = true;
            this.butDebEliminar.Click += new System.EventHandler(this.butDebEliminar_Click);
            // 
            // textBoxDebilidad
            // 
            this.textBoxDebilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDebilidad.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDebilidad.Location = new System.Drawing.Point(203, 6);
            this.textBoxDebilidad.Name = "textBoxDebilidad";
            this.textBoxDebilidad.Size = new System.Drawing.Size(412, 39);
            this.textBoxDebilidad.TabIndex = 3;
            this.textBoxDebilidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDebilidad_KeyPress);
            // 
            // listBoxDebilidad
            // 
            this.listBoxDebilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDebilidad.BackColor = System.Drawing.Color.Khaki;
            this.listBoxDebilidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDebilidad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxDebilidad.FormattingEnabled = true;
            this.listBoxDebilidad.ItemHeight = 24;
            this.listBoxDebilidad.Location = new System.Drawing.Point(0, 50);
            this.listBoxDebilidad.Name = "listBoxDebilidad";
            this.listBoxDebilidad.Size = new System.Drawing.Size(621, 340);
            this.listBoxDebilidad.TabIndex = 1;
            // 
            // butDeb
            // 
            this.butDeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeb.Location = new System.Drawing.Point(0, 0);
            this.butDeb.Name = "butDeb";
            this.butDeb.Size = new System.Drawing.Size(101, 50);
            this.butDeb.TabIndex = 0;
            this.butDeb.Text = "AÑADIR DEBILIDAD";
            this.butDeb.UseVisualStyleBackColor = true;
            this.butDeb.Click += new System.EventHandler(this.butDeb_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBoxAmenaza);
            this.panel3.Controls.Add(this.butAmenazaEliminar);
            this.panel3.Controls.Add(this.listBoxAmenaza);
            this.panel3.Controls.Add(this.butAmenaza);
            this.panel3.Location = new System.Drawing.Point(629, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 353);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(233, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "AMENAZAS";
            // 
            // textBoxAmenaza
            // 
            this.textBoxAmenaza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAmenaza.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmenaza.Location = new System.Drawing.Point(201, 6);
            this.textBoxAmenaza.Name = "textBoxAmenaza";
            this.textBoxAmenaza.Size = new System.Drawing.Size(414, 39);
            this.textBoxAmenaza.TabIndex = 6;
            this.textBoxAmenaza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBoxAmenaza_KeyPress);
            // 
            // butAmenazaEliminar
            // 
            this.butAmenazaEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAmenazaEliminar.Location = new System.Drawing.Point(100, 0);
            this.butAmenazaEliminar.Name = "butAmenazaEliminar";
            this.butAmenazaEliminar.Size = new System.Drawing.Size(100, 50);
            this.butAmenazaEliminar.TabIndex = 5;
            this.butAmenazaEliminar.Text = "ELIMINAR";
            this.butAmenazaEliminar.UseVisualStyleBackColor = true;
            this.butAmenazaEliminar.Click += new System.EventHandler(this.butAmenazaEliminar_Click);
            // 
            // listBoxAmenaza
            // 
            this.listBoxAmenaza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAmenaza.BackColor = System.Drawing.Color.IndianRed;
            this.listBoxAmenaza.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.listBoxAmenaza.FormattingEnabled = true;
            this.listBoxAmenaza.ItemHeight = 24;
            this.listBoxAmenaza.Location = new System.Drawing.Point(0, 50);
            this.listBoxAmenaza.Name = "listBoxAmenaza";
            this.listBoxAmenaza.Size = new System.Drawing.Size(621, 364);
            this.listBoxAmenaza.TabIndex = 2;
            this.listBoxAmenaza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBoxAmenaza_KeyPress);
            // 
            // butAmenaza
            // 
            this.butAmenaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAmenaza.Location = new System.Drawing.Point(0, 0);
            this.butAmenaza.Name = "butAmenaza";
            this.butAmenaza.Size = new System.Drawing.Size(100, 50);
            this.butAmenaza.TabIndex = 1;
            this.butAmenaza.Text = "AÑADIR AMENAZA";
            this.butAmenaza.UseVisualStyleBackColor = true;
            this.butAmenaza.Click += new System.EventHandler(this.butAmenaza_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBoxFortaleza);
            this.panel4.Controls.Add(this.butFortEliminar);
            this.panel4.Controls.Add(this.listBoxFortaleza);
            this.panel4.Controls.Add(this.butFortaleza);
            this.panel4.Location = new System.Drawing.Point(4, 364);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(618, 353);
            this.panel4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(198, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "FORTALEZAS";
            // 
            // textBoxFortaleza
            // 
            this.textBoxFortaleza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFortaleza.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFortaleza.Location = new System.Drawing.Point(217, 6);
            this.textBoxFortaleza.Name = "textBoxFortaleza";
            this.textBoxFortaleza.Size = new System.Drawing.Size(398, 39);
            this.textBoxFortaleza.TabIndex = 6;
            this.textBoxFortaleza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFortaleza_KeyPress);
            // 
            // butFortEliminar
            // 
            this.butFortEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFortEliminar.Location = new System.Drawing.Point(115, 0);
            this.butFortEliminar.Name = "butFortEliminar";
            this.butFortEliminar.Size = new System.Drawing.Size(100, 50);
            this.butFortEliminar.TabIndex = 5;
            this.butFortEliminar.Text = "ELIMINAR";
            this.butFortEliminar.UseVisualStyleBackColor = true;
            this.butFortEliminar.Click += new System.EventHandler(this.butFortEliminar_Click);
            // 
            // listBoxFortaleza
            // 
            this.listBoxFortaleza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFortaleza.BackColor = System.Drawing.Color.CornflowerBlue;
            this.listBoxFortaleza.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.listBoxFortaleza.FormattingEnabled = true;
            this.listBoxFortaleza.ItemHeight = 24;
            this.listBoxFortaleza.Location = new System.Drawing.Point(0, 50);
            this.listBoxFortaleza.Name = "listBoxFortaleza";
            this.listBoxFortaleza.Size = new System.Drawing.Size(621, 292);
            this.listBoxFortaleza.TabIndex = 1;
            // 
            // butFortaleza
            // 
            this.butFortaleza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFortaleza.Location = new System.Drawing.Point(0, 0);
            this.butFortaleza.Name = "butFortaleza";
            this.butFortaleza.Size = new System.Drawing.Size(115, 50);
            this.butFortaleza.TabIndex = 0;
            this.butFortaleza.Text = "AÑADIR FORTALEZA";
            this.butFortaleza.UseVisualStyleBackColor = true;
            this.butFortaleza.Click += new System.EventHandler(this.butFortaleza_Click);
            // 
            // AnalisisDAFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1251, 721);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "AnalisisDAFO";
            this.Text = "Análisis DAFO";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butOportunidad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butDeb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button butAmenaza;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button butFortaleza;
        public System.Windows.Forms.ListBox listBoxDebilidad;
        public System.Windows.Forms.ListBox listBoxAmenaza;
        public System.Windows.Forms.ListBox listBoxOportunidad;
        public System.Windows.Forms.ListBox listBoxFortaleza;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxDebilidad;
        private System.Windows.Forms.Button butDebEliminar;
        private System.Windows.Forms.TextBox textBoxOportunidad;
        private System.Windows.Forms.Button butOportEliminar;
        private System.Windows.Forms.TextBox textBoxAmenaza;
        private System.Windows.Forms.Button butAmenazaEliminar;
        private System.Windows.Forms.TextBox textBoxFortaleza;
        private System.Windows.Forms.Button butFortEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}