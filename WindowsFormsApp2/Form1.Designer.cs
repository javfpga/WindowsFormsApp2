namespace WindowsFormsApp2
{
    partial class INICIO
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viabiliadComercialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.análisisDAFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrizDeCompetidoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrizDePosicionamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viabilidadEconómicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viabiliadComercialToolStripMenuItem,
            this.viabilidadEconómicaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1281, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viabiliadComercialToolStripMenuItem
            // 
            this.viabiliadComercialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.análisisDAFOToolStripMenuItem,
            this.matrizDeCompetidoresToolStripMenuItem,
            this.matrizDePosicionamientoToolStripMenuItem});
            this.viabiliadComercialToolStripMenuItem.Name = "viabiliadComercialToolStripMenuItem";
            this.viabiliadComercialToolStripMenuItem.Size = new System.Drawing.Size(165, 25);
            this.viabiliadComercialToolStripMenuItem.Text = "Viabilidad Comercial";
            // 
            // análisisDAFOToolStripMenuItem
            // 
            this.análisisDAFOToolStripMenuItem.Name = "análisisDAFOToolStripMenuItem";
            this.análisisDAFOToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.análisisDAFOToolStripMenuItem.Text = "Análisis DAFO";
            this.análisisDAFOToolStripMenuItem.Click += new System.EventHandler(this.análisisDAFOToolStripMenuItem_Click);
            // 
            // matrizDeCompetidoresToolStripMenuItem
            // 
            this.matrizDeCompetidoresToolStripMenuItem.Name = "matrizDeCompetidoresToolStripMenuItem";
            this.matrizDeCompetidoresToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.matrizDeCompetidoresToolStripMenuItem.Text = "Matriz de competidores";
            this.matrizDeCompetidoresToolStripMenuItem.Click += new System.EventHandler(this.matrizDeCompetidoresToolStripMenuItem_Click);
            // 
            // matrizDePosicionamientoToolStripMenuItem
            // 
            this.matrizDePosicionamientoToolStripMenuItem.Name = "matrizDePosicionamientoToolStripMenuItem";
            this.matrizDePosicionamientoToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.matrizDePosicionamientoToolStripMenuItem.Text = "Matriz de posicionamiento";
            this.matrizDePosicionamientoToolStripMenuItem.Click += new System.EventHandler(this.matrizDePosicionamientoToolStripMenuItem_Click);
            // 
            // viabilidadEconómicaToolStripMenuItem
            // 
            this.viabilidadEconómicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inversionToolStripMenuItem});
            this.viabilidadEconómicaToolStripMenuItem.Name = "viabilidadEconómicaToolStripMenuItem";
            this.viabilidadEconómicaToolStripMenuItem.Size = new System.Drawing.Size(170, 25);
            this.viabilidadEconómicaToolStripMenuItem.Text = "Viabilidad Económica";
            // 
            // inversionToolStripMenuItem
            // 
            this.inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            this.inversionToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.inversionToolStripMenuItem.Text = "Inversion";
            this.inversionToolStripMenuItem.Click += new System.EventHandler(this.inversionToolStripMenuItem_Click);
            // 
            // INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 552);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "INICIO";
            this.Text = "INICIO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viabiliadComercialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem análisisDAFOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrizDeCompetidoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrizDePosicionamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viabilidadEconómicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversionToolStripMenuItem;
    }
}

