/*
 * Archivo: Form1
 * Descripión: Aplicación estudio viabilidad económica y comercial (Ventana principal)
 * Autor: Javier Salvador García
 * Fecha: 10/10/2018
 * Versión: 1.0
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }
        /*
         * Función: void análisisDAFOToolStripMenuItem_Click(object sender, EventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para el botón Análisis DAFO del desplegable, 
         *              que permite abrir la ventana para generar el análisis
         * Autor: Javier Salvador Garcia
         */
        private void análisisDAFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalisisDAFO aDAFO = new AnalisisDAFO();    //Creamos una instancia de la ventana de Analisis DAFO
            aDAFO.Show();                               //Abrimos la ventana de Analisis DAFO
        }

        /*
         * Función: void matrizDePosicionamientoToolStripMenuItem_Click(object sender, EventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para el botón Matriz de Posicionamient del desplegable,
         *              que permite abrir la ventana para generar el análisis
         * Autor: Javier Salvador Garcia
         */
        private void matrizDePosicionamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatrizDePosicionamiento mdp = new MatrizDePosicionamiento();
            mdp.Show();
        }

        /*
         * Función: void matrizDeCompetidoresToolStripMenuItem_Click(object sender, EventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para el botón Matriz de Competidores del desplegable,
         *              que permite abrir la ventana para generar el análisis
         * Autor: Javier Salvador Garcia
         */
        private void matrizDeCompetidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatrizDeCompetidores mdc = new MatrizDeCompetidores();
            mdc.Show();
        }

        /*
         * Función: void inversionToolStripMenuItem_Click(object sender, EventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para el botón Inversión del desplegable,
         *              que permite abrir la ventana para generar el análisis
         * Autor: Javier Salvador Garcia
         */
        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalisisInversion fm2 = new AnalisisInversion();
            fm2.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
