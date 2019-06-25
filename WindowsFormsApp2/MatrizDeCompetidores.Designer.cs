namespace WindowsFormsApp2
{
    partial class MatrizDeCompetidores
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.butAdd = new System.Windows.Forms.Button();
            this.txtNomEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butDel = new System.Windows.Forms.Button();
            this.butValorar = new System.Windows.Forms.Button();
            this.buttGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(2, 1);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1383, 527);
            this.dgv.TabIndex = 1;
            // 
            // butAdd
            // 
            this.butAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.Location = new System.Drawing.Point(12, 549);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(99, 52);
            this.butAdd.TabIndex = 2;
            this.butAdd.Text = "Agregar";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // txtNomEmpresa
            // 
            this.txtNomEmpresa.Location = new System.Drawing.Point(117, 581);
            this.txtNomEmpresa.Name = "txtNomEmpresa";
            this.txtNomEmpresa.Size = new System.Drawing.Size(229, 20);
            this.txtNomEmpresa.TabIndex = 3;
            this.txtNomEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomEmpresa_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de la empresa";
            // 
            // butDel
            // 
            this.butDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDel.Location = new System.Drawing.Point(431, 549);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(99, 52);
            this.butDel.TabIndex = 5;
            this.butDel.Text = "Eliminar Fila";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // butValorar
            // 
            this.butValorar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butValorar.Location = new System.Drawing.Point(675, 549);
            this.butValorar.Name = "butValorar";
            this.butValorar.Size = new System.Drawing.Size(99, 52);
            this.butValorar.TabIndex = 6;
            this.butValorar.Text = "Evaluar";
            this.butValorar.UseVisualStyleBackColor = true;
            this.butValorar.Click += new System.EventHandler(this.butValorar_Click);
            // 
            // buttGuardar
            // 
            this.buttGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttGuardar.Location = new System.Drawing.Point(798, 549);
            this.buttGuardar.Name = "buttGuardar";
            this.buttGuardar.Size = new System.Drawing.Size(99, 52);
            this.buttGuardar.TabIndex = 7;
            this.buttGuardar.Text = "Guardar";
            this.buttGuardar.UseVisualStyleBackColor = true;
            this.buttGuardar.Click += new System.EventHandler(this.buttGuardar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(553, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Eliminar Columna";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MatrizDeCompetidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1387, 654);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttGuardar);
            this.Controls.Add(this.butValorar);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomEmpresa);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.dgv);
            this.Name = "MatrizDeCompetidores";
            this.Text = "MatrizDeCompetidores";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.TextBox txtNomEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button butValorar;
        private System.Windows.Forms.Button buttGuardar;
        private System.Windows.Forms.Button button1;
    }
}