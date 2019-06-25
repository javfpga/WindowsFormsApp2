/*
 * Archivo: Form2.cs
 * Descripión: Ventana para el estudio económico de un proyecto
 * Autor: Javier Salvador García
 * Fecha: 20/10/2018
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
using GridExtension;
using Microsoft.VisualBasic;
using System.Numerics;


namespace WindowsFormsApp2
{
    public partial class AnalisisInversion : Form
    {
        public AnalisisInversion()
        {
            InitializeComponent();
        }
        
       /*
        * Función: void calculo()
        * Param: 
        * Return: none
        * Descripción: Funcion que permite realizar el calculo del total acumulado 
        *              para el importe, el valor residual y la depreciacion total de cada periodo
        * Autor: Javier Salvador Garcia
        */
        public void calculo()
       {
            double total_importe = 0;
            double total_residual = 0;
            double total_depreciacion1 = 0;
            double total_depreciacion2 = 0;
            double total_depreciacion3 = 0;
            double total_depreciacion4 = 0;
            double total_depreciacion5 = 0;
            double total_depreciacion6 = 0;
            double total_depreciacion7 = 0;
            double total_depreciacion8 = 0;
            double total_depreciacion9 = 0;
            double total_depreciacion10 = 0;
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total_importe += Convert.ToDouble(row.Cells["colImporte"].Value);
                total_residual += Convert.ToDouble(row.Cells["colValorResidual"].Value);
                /*Totales depreciacion por periodo*/
                total_depreciacion1 += Convert.ToDouble(row.Cells["ColDepreciacion1"].Value);
                total_depreciacion2 += Convert.ToDouble(row.Cells["ColDepreciacion2"].Value);
                total_depreciacion3 += Convert.ToDouble(row.Cells["ColDepreciacion3"].Value);
                total_depreciacion4 += Convert.ToDouble(row.Cells["ColDepreciacion4"].Value);
                total_depreciacion5 += Convert.ToDouble(row.Cells["ColDepreciacion5"].Value);
                total_depreciacion6 += Convert.ToDouble(row.Cells["ColDepreciacion6"].Value);
                total_depreciacion7 += Convert.ToDouble(row.Cells["ColDepreciacion7"].Value);
                total_depreciacion8 += Convert.ToDouble(row.Cells["ColDepreciacion8"].Value);
                total_depreciacion9 += Convert.ToDouble(row.Cells["ColDepreciacion9"].Value);
                total_depreciacion10 += Convert.ToDouble(row.Cells["ColDepreciacion10"].Value);
            }

            textBoxImporte.Text = Convert.ToString(total_importe);
            textBoxResidual.Text = Convert.ToString(total_residual);
            textDeprec1.Text = Convert.ToString(total_depreciacion1);
            textDeprec2.Text = Convert.ToString(total_depreciacion2);
            textDeprec3.Text = Convert.ToString(total_depreciacion3);
            textDeprec4.Text = Convert.ToString(total_depreciacion4);
            textDeprec5.Text = Convert.ToString(total_depreciacion5);
            textDeprec6.Text = Convert.ToString(total_depreciacion6);
            textDeprec7.Text = Convert.ToString(total_depreciacion7);
            textDeprec8.Text = Convert.ToString(total_depreciacion8);
            textDeprec9.Text = Convert.ToString(total_depreciacion9);
            textDeprec10.Text = Convert.ToString(total_depreciacion10);
        }

        /*
        * Función: void calculo_cobros()
        * Param: 
        * Return: none
        * Descripción: Funcion que permite realizar el calculo del total acumulado 
        *              para los cobros
        * Autor: Javier Salvador Garcia
        */
        public void calculo_cobros ()
        {
            double total_cobros1 = 0;
            double total_cobros2 = 0;
            double total_cobros3 = 0;
            double total_cobros4 = 0;
            double total_cobros5 = 0;
            double total_cobros6 = 0;
            double total_cobros7 = 0;
            double total_cobros8 = 0;
            double total_cobros9 = 0;
            double total_cobros10 = 0;

            foreach (DataGridViewRow row in dgvCobros.Rows)
            {
                /*calculo totales cobros por periodo*/
                total_cobros1 += Convert.ToDouble(row.Cells["colCobros1"].Value);
                total_cobros2 += Convert.ToDouble(row.Cells["colCobros2"].Value);
                total_cobros3 += Convert.ToDouble(row.Cells["colCobros3"].Value);
                total_cobros4 += Convert.ToDouble(row.Cells["colCobros4"].Value);
                total_cobros5 += Convert.ToDouble(row.Cells["colCobros5"].Value);
                total_cobros6 += Convert.ToDouble(row.Cells["colCobros6"].Value);
                total_cobros7 += Convert.ToDouble(row.Cells["colCobros7"].Value);
                total_cobros8 += Convert.ToDouble(row.Cells["colCobros8"].Value);
                total_cobros9 += Convert.ToDouble(row.Cells["colCobros9"].Value);
                total_cobros10 += Convert.ToDouble(row.Cells["colCobros10"].Value);
            }

            /*Total cobros por periodo*/
            textCobros1.Text = Convert.ToString(total_cobros1);
            textCobros2.Text = Convert.ToString(total_cobros2);
            textCobros3.Text = Convert.ToString(total_cobros3);
            textCobros4.Text = Convert.ToString(total_cobros4);
            textCobros5.Text = Convert.ToString(total_cobros5);
            textCobros6.Text = Convert.ToString(total_cobros6);
            textCobros7.Text = Convert.ToString(total_cobros7);
            textCobros8.Text = Convert.ToString(total_cobros8);
            textCobros9.Text = Convert.ToString(total_cobros9);
            textCobros10.Text = Convert.ToString(total_cobros10);
        }

        /*
        * Función: void calculo_pagos()
        * Param: 
        * Return: none
        * Descripción: Funcion que permite realizar el calculo del total acumulado 
        *              para los pagos
        * Autor: Javier Salvador Garcia
        */
        public void calculo_pagos()
        {
            double total_pagos1 = 0;
            double total_pagos2 = 0;
            double total_pagos3 = 0;
            double total_pagos4 = 0;
            double total_pagos5 = 0;
            double total_pagos6 = 0;
            double total_pagos7 = 0;
            double total_pagos8 = 0;
            double total_pagos9 = 0;
            double total_pagos10 = 0;

            foreach (DataGridViewRow row in dgvPagos.Rows)
            {
                /*calculo totales pagos por periodo*/
                total_pagos1 += Convert.ToDouble(row.Cells["colPagos1"].Value);
                total_pagos2 += Convert.ToDouble(row.Cells["colPagos2"].Value);
                total_pagos3 += Convert.ToDouble(row.Cells["colPagos3"].Value);
                total_pagos4 += Convert.ToDouble(row.Cells["colPagos4"].Value);
                total_pagos5 += Convert.ToDouble(row.Cells["colPagos5"].Value);
                total_pagos6 += Convert.ToDouble(row.Cells["colPagos6"].Value);
                total_pagos7 += Convert.ToDouble(row.Cells["colPagos7"].Value);
                total_pagos8 += Convert.ToDouble(row.Cells["colPagos8"].Value);
                total_pagos9 += Convert.ToDouble(row.Cells["colPagos9"].Value);
                total_pagos10 += Convert.ToDouble(row.Cells["colPagos10"].Value);
            }

            /*Total pagos por periodo*/
            textBoxPagos1.Text = Convert.ToString(total_pagos1);
            textBoxPagos2.Text = Convert.ToString(total_pagos2);
            textBoxPagos3.Text = Convert.ToString(total_pagos3);
            textBoxPagos4.Text = Convert.ToString(total_pagos4);
            textBoxPagos5.Text = Convert.ToString(total_pagos5);
            textBoxPagos6.Text = Convert.ToString(total_pagos6);
            textBoxPagos7.Text = Convert.ToString(total_pagos7);
            textBoxPagos8.Text = Convert.ToString(total_pagos8);
            textBoxPagos9.Text = Convert.ToString(total_pagos9);
            textBoxPagos10.Text = Convert.ToString(total_pagos10);
        }

        decimal valorDepreciacion = 0;
        decimal importe = 0;
        decimal valorResidual = 0;
        decimal vidaUtil = 0;
        /*
         * Función: void calculoDepreciacion()
         * Param: 
         * Return: none
         * Descripción: Funcion para realizar el cálculo de la deprecicación
         *              para todos los periodos y para cada concepto
         * Autor: Javier Salvador Garcia
         */
        public void calculoDepreciacion()
        {
            for (int i = 5; i < dataGridView1.ColumnCount; i++)   //bucle para recorrer todas la columnas que van a almacenar
            {
                for(int j = 0; j < dataGridView1.RowCount; j++) //bucle para recorrer las filas
                {
                   try
                    {
                        importe = decimal.Parse(dataGridView1.Rows[j].Cells["colImporte"].Value.ToString());
                        valorResidual = decimal.Parse(dataGridView1.Rows[j].Cells["colValorResidual"].Value.ToString());
                        vidaUtil = decimal.Parse(dataGridView1.Rows[j].Cells["colVidaUtil"].Value.ToString());
                        valorDepreciacion = (importe - valorResidual) / vidaUtil;
                        
                    }
                    catch (Exception)
                    {
                        valorDepreciacion = 0;
                    }
                    dataGridView1.Rows[j].Cells[i].Value = valorDepreciacion;   //Escribimos en la celda
                }
            }
        }

        /*
         * Función: void calculoFlujosCaja(string periodo)
         * Param: string periodo
         * Return: none
         * Descripción: Funcion para realizar el cálculo de los flujos de caja
         *              para todos los periodos
         * Autor: Javier Salvador Garcia
         */
        public void calculoFlujosCaja(string periodo)
        {
            decimal flujo_caja_periodo1 = 0;
            decimal flujo_caja_periodo2 = 0;
            decimal flujo_caja_periodo3 = 0;
            decimal flujo_caja_periodo4 = 0;
            decimal flujo_caja_periodo5 = 0;
            decimal flujo_caja_periodo6 = 0;
            decimal flujo_caja_periodo7 = 0;
            decimal flujo_caja_periodo8 = 0;
            decimal flujo_caja_periodo9 = 0;
            decimal flujo_caja_periodo10 = 0;
            try
            {
                flujo_caja_periodo1 = ((decimal.Parse(textCobros1.Text) - decimal.Parse(textBoxPagos1.Text)) * (1 - decimal.Parse(textBoxTasaImpositiva.Text)))
                                   + (decimal.Parse(textDeprec1.Text) * decimal.Parse(textBoxTasaImpositiva.Text));
                flujo_caja_periodo2 = ((decimal.Parse(textCobros2.Text) - decimal.Parse(textBoxPagos2.Text)) * (1 - decimal.Parse(textBoxTasaImpositiva.Text)))
                                       + (decimal.Parse(textDeprec2.Text) * decimal.Parse(textBoxTasaImpositiva.Text));
                flujo_caja_periodo3 = ((decimal.Parse(textCobros3.Text) - decimal.Parse(textBoxPagos3.Text)) * (1 - decimal.Parse(textBoxTasaImpositiva.Text)))
                                       + (decimal.Parse(textDeprec3.Text) * decimal.Parse(textBoxTasaImpositiva.Text));
                flujo_caja_periodo4 = ((decimal.Parse(textCobros4.Text) - decimal.Parse(textBoxPagos4.Text)) * (1 - decimal.Parse(textBoxTasaImpositiva.Text)))
                                       + (decimal.Parse(textDeprec4.Text) * decimal.Parse(textBoxTasaImpositiva.Text));
                flujo_caja_periodo5 = ((decimal.Parse(textCobros5.Text) - decimal.Parse(textBoxPagos5.Text)) * (1 - decimal.Parse(textBoxTasaImpositiva.Text)))
                                       + (decimal.Parse(textDeprec5.Text) * decimal.Parse(textBoxTasaImpositiva.Text));
                flujo_caja_periodo6 = ((decimal.Parse(textCobros6.Text) - decimal.Parse(textBoxPagos6.Text)) * (1 - decimal.Parse(textBoxTasaImpositiva.Text)))
                                       + (decimal.Parse(textDeprec6.Text) * decimal.Parse(textBoxTasaImpositiva.Text));
                flujo_caja_periodo7 = ((decimal.Parse(textCobros7.Text) - decimal.Parse(textBoxPagos7.Text)) * (1 - decimal.Parse(textBoxTasaImpositiva.Text)))
                                       + (decimal.Parse(textDeprec7.Text) * decimal.Parse(textBoxTasaImpositiva.Text));
                flujo_caja_periodo8 = ((decimal.Parse(textCobros8.Text) - decimal.Parse(textBoxPagos8.Text)) * (1 - decimal.Parse(textBoxTasaImpositiva.Text)))
                                       + (decimal.Parse(textDeprec8.Text) * decimal.Parse(textBoxTasaImpositiva.Text));
                flujo_caja_periodo9 = ((decimal.Parse(textCobros9.Text) - decimal.Parse(textBoxPagos9.Text)) * (1 - decimal.Parse(textBoxTasaImpositiva.Text)))
                                       + (decimal.Parse(textDeprec9.Text) * decimal.Parse(textBoxTasaImpositiva.Text));
                flujo_caja_periodo10 = ((decimal.Parse(textCobros10.Text) - decimal.Parse(textBoxPagos10.Text)) * (1 - decimal.Parse(textBoxTasaImpositiva.Text)))
                                       + (decimal.Parse(textDeprec10.Text) * decimal.Parse(textBoxTasaImpositiva.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("No se han calculado los cobros y pagos");
            }

            dgvFlujosCaja.Rows[0].Cells[0].Value = flujo_caja_periodo1;   //Escribimos en la celda
            dgvFlujosCaja.Rows[0].Cells[1].Value = flujo_caja_periodo2;   //Escribimos en la celda
            dgvFlujosCaja.Rows[0].Cells[2].Value = flujo_caja_periodo3;   //Escribimos en la celda
            dgvFlujosCaja.Rows[0].Cells[3].Value = flujo_caja_periodo4;   //Escribimos en la celda
            dgvFlujosCaja.Rows[0].Cells[4].Value = flujo_caja_periodo5;   //Escribimos en la celda
            dgvFlujosCaja.Rows[0].Cells[5].Value = flujo_caja_periodo6;   //Escribimos en la celda
            dgvFlujosCaja.Rows[0].Cells[6].Value = flujo_caja_periodo7;   //Escribimos en la celda
            dgvFlujosCaja.Rows[0].Cells[7].Value = flujo_caja_periodo8;   //Escribimos en la celda
            dgvFlujosCaja.Rows[0].Cells[8].Value = flujo_caja_periodo9;   //Escribimos en la celda
            dgvFlujosCaja.Rows[0].Cells[9].Value = flujo_caja_periodo10;   //Escribimos en la celda

        }

        /*
         * Función: void numPeriodos(string numeroPeriodos)
         * Param: (string numeroPeriodo
         * Return: none
         * Descripción: Funcion para pintar el número de columnas necesarias en las
         *              tablas en función del nº de periodos
         * Autor: Javier Salvador Garcia
         */
        public void numPeriodos(string numeroPeriodos)
        {
         
         if (numeroPeriodos != "")
         {
                switch (int.Parse(numeroPeriodos))
                {
                    case 1:
                        /*Tabla depreciacion*/
                        dataGridView1.Columns["ColDepreciacion1"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion3"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion4"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion2"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion5"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion6"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion7"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion8"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion9"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion10"].Visible = false;
                        textDeprec1.Visible = true;
                        textDeprec2.Visible = false;
                        textDeprec3.Visible = false;
                        textDeprec4.Visible = false;
                        textDeprec5.Visible = false;
                        textDeprec6.Visible = false;
                        textDeprec7.Visible = false;
                        textDeprec8.Visible = false;
                        textDeprec9.Visible = false;
                        textDeprec10.Visible = false;
                        label3.Visible = true;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;
                        /*Tabla Cobros*/
                        dgvCobros.Columns["colCobros1"].Visible = true;
                        dgvCobros.Columns["colCobros2"].Visible = false;
                        dgvCobros.Columns["colCobros3"].Visible = false;
                        dgvCobros.Columns["colCobros4"].Visible = false;
                        dgvCobros.Columns["colCobros5"].Visible = false;
                        dgvCobros.Columns["colCobros6"].Visible = false;
                        dgvCobros.Columns["colCobros7"].Visible = false;
                        dgvCobros.Columns["colCobros8"].Visible = false;
                        dgvCobros.Columns["colCobros9"].Visible = false;
                        dgvCobros.Columns["colCobros10"].Visible = false;
                        textCobros1.Visible = true;
                        textCobros2.Visible = false;
                        textCobros3.Visible = false;
                        textCobros4.Visible = false;
                        textCobros5.Visible = false;
                        textCobros6.Visible = false;
                        textCobros7.Visible = false;
                        textCobros8.Visible = false;
                        textCobros9.Visible = false;
                        textCobros10.Visible = false;
                        labelCobros1.Visible = true;
                        labelCobros2.Visible = false;
                        labelCobros3.Visible = false;
                        labelCobros4.Visible = false;
                        labelCobros5.Visible = false;
                        labelCobros6.Visible = false;
                        labelCobros7.Visible = false;
                        labelCobros8.Visible = false;
                        labelCobros9.Visible = false;
                        labelCobros10.Visible = false;
                        /*Tabla Pagos*/
                        dgvPagos.Columns["colPagos1"].Visible = true;
                        dgvPagos.Columns["colPagos2"].Visible = false;
                        dgvPagos.Columns["colPagos3"].Visible = false;
                        dgvPagos.Columns["colPagos4"].Visible = false;
                        dgvPagos.Columns["colPagos5"].Visible = false;
                        dgvPagos.Columns["colPagos6"].Visible = false;
                        dgvPagos.Columns["colPagos7"].Visible = false;
                        dgvPagos.Columns["colPagos8"].Visible = false;
                        dgvPagos.Columns["colPagos9"].Visible = false;
                        dgvPagos.Columns["colPagos10"].Visible = false;
                        textBoxPagos1.Visible = true;
                        textBoxPagos2.Visible = false;
                        textBoxPagos3.Visible = false;
                        textBoxPagos4.Visible = false;
                        textBoxPagos5.Visible = false;
                        textBoxPagos6.Visible = false;
                        textBoxPagos7.Visible = false;
                        textBoxPagos8.Visible = false;
                        textBoxPagos9.Visible = false;
                        textBoxPagos10.Visible = false;
                        labelPagos1.Visible = true;
                        labelPagos2.Visible = false;
                        labelPagos3.Visible = false;
                        labelPagos4.Visible = false;
                        labelPagos5.Visible = false;
                        labelPagos6.Visible = false;
                        labelPagos7.Visible = false;
                        labelPagos8.Visible = false;
                        labelPagos9.Visible = false;
                        labelPagos10.Visible = false;
                        /*Flujos de Caja*/
                        dgvFlujosCaja.Columns["FLC1"].Visible = true;
                        dgvFlujosCaja.Columns["FLC2"].Visible = false;
                        dgvFlujosCaja.Columns["FLC3"].Visible = false;
                        dgvFlujosCaja.Columns["FLC4"].Visible = false;
                        dgvFlujosCaja.Columns["FLC5"].Visible = false;
                        dgvFlujosCaja.Columns["FLC6"].Visible = false;
                        dgvFlujosCaja.Columns["FLC7"].Visible = false;
                        dgvFlujosCaja.Columns["FLC8"].Visible = false;
                        dgvFlujosCaja.Columns["FLC9"].Visible = false;
                        dgvFlujosCaja.Columns["FLC10"].Visible = false;
                        break;

                    case 2:
                        dataGridView1.Columns["ColDepreciacion1"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion2"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion3"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion4"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion5"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion6"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion7"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion8"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion9"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion10"].Visible = false;
                        textDeprec1.Visible = true;
                        textDeprec2.Visible = true;
                        textDeprec3.Visible = false;
                        textDeprec4.Visible = false;
                        textDeprec5.Visible = false;
                        textDeprec6.Visible = false;
                        textDeprec7.Visible = false;
                        textDeprec8.Visible = false;
                        textDeprec9.Visible = false;
                        textDeprec10.Visible = false;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;
                        /*Tabla Cobros*/
                        dgvCobros.Columns["colCobros1"].Visible = true;
                        dgvCobros.Columns["colCobros2"].Visible = true;
                        dgvCobros.Columns["colCobros3"].Visible = false;
                        dgvCobros.Columns["colCobros4"].Visible = false;
                        dgvCobros.Columns["colCobros5"].Visible = false;
                        dgvCobros.Columns["colCobros6"].Visible = false;
                        dgvCobros.Columns["colCobros7"].Visible = false;
                        dgvCobros.Columns["colCobros8"].Visible = false;
                        dgvCobros.Columns["colCobros9"].Visible = false;
                        dgvCobros.Columns["colCobros10"].Visible = false;
                        textCobros1.Visible = true;
                        textCobros2.Visible = true;
                        textCobros3.Visible = false;
                        textCobros4.Visible = false;
                        textCobros5.Visible = false;
                        textCobros6.Visible = false;
                        textCobros7.Visible = false;
                        textCobros8.Visible = false;
                        textCobros9.Visible = false;
                        textCobros10.Visible = false;
                        labelCobros1.Visible = true;
                        labelCobros2.Visible = true;
                        labelCobros3.Visible = false;
                        labelCobros4.Visible = false;
                        labelCobros5.Visible = false;
                        labelCobros6.Visible = false;
                        labelCobros7.Visible = false;
                        labelCobros8.Visible = false;
                        labelCobros9.Visible = false;
                        labelCobros10.Visible = false;
                        /*Tabla Pagos*/
                        dgvPagos.Columns["colPagos1"].Visible = true;
                        dgvPagos.Columns["colPagos2"].Visible = true;
                        dgvPagos.Columns["colPagos3"].Visible = false;
                        dgvPagos.Columns["colPagos4"].Visible = false;
                        dgvPagos.Columns["colPagos5"].Visible = false;
                        dgvPagos.Columns["colPagos6"].Visible = false;
                        dgvPagos.Columns["colPagos7"].Visible = false;
                        dgvPagos.Columns["colPagos8"].Visible = false;
                        dgvPagos.Columns["colPagos9"].Visible = false;
                        dgvPagos.Columns["colPagos10"].Visible = false;
                        textBoxPagos1.Visible = true;
                        textBoxPagos2.Visible = true;
                        textBoxPagos3.Visible = false;
                        textBoxPagos4.Visible = false;
                        textBoxPagos5.Visible = false;
                        textBoxPagos6.Visible = false;
                        textBoxPagos7.Visible = false;
                        textBoxPagos8.Visible = false;
                        textBoxPagos9.Visible = false;
                        textBoxPagos10.Visible = false;
                        labelPagos1.Visible = true;
                        labelPagos2.Visible = true;
                        labelPagos3.Visible = false;
                        labelPagos4.Visible = false;
                        labelPagos5.Visible = false;
                        labelPagos6.Visible = false;
                        labelPagos7.Visible = false;
                        labelPagos8.Visible = false;
                        labelPagos9.Visible = false;
                        labelPagos10.Visible = false;
                        /*Flujos de Caja*/
                        dgvFlujosCaja.Columns["FLC1"].Visible = true;
                        dgvFlujosCaja.Columns["FLC2"].Visible = true;
                        dgvFlujosCaja.Columns["FLC3"].Visible = false;
                        dgvFlujosCaja.Columns["FLC4"].Visible = false;
                        dgvFlujosCaja.Columns["FLC5"].Visible = false;
                        dgvFlujosCaja.Columns["FLC6"].Visible = false;
                        dgvFlujosCaja.Columns["FLC7"].Visible = false;
                        dgvFlujosCaja.Columns["FLC8"].Visible = false;
                        dgvFlujosCaja.Columns["FLC9"].Visible = false;
                        dgvFlujosCaja.Columns["FLC10"].Visible = false;
                        break;

                    case 3:
                        dataGridView1.Columns["ColDepreciacion1"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion2"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion3"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion4"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion5"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion6"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion7"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion8"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion9"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion10"].Visible = false;
                        textDeprec1.Visible = true;
                        textDeprec2.Visible = true;
                        textDeprec3.Visible = true;
                        textDeprec4.Visible = false;
                        textDeprec5.Visible = false;
                        textDeprec6.Visible = false;
                        textDeprec7.Visible = false;
                        textDeprec8.Visible = false;
                        textDeprec9.Visible = false;
                        textDeprec10.Visible = false;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = false;
                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;
                        /*Tabla Cobros*/
                        dgvCobros.Columns["colCobros1"].Visible = true;
                        dgvCobros.Columns["colCobros2"].Visible = true;
                        dgvCobros.Columns["colCobros3"].Visible = true;
                        dgvCobros.Columns["colCobros4"].Visible = false;
                        dgvCobros.Columns["colCobros5"].Visible = false;
                        dgvCobros.Columns["colCobros6"].Visible = false;
                        dgvCobros.Columns["colCobros7"].Visible = false;
                        dgvCobros.Columns["colCobros8"].Visible = false;
                        dgvCobros.Columns["colCobros9"].Visible = false;
                        dgvCobros.Columns["colCobros10"].Visible = false;
                        textCobros1.Visible = true;
                        textCobros2.Visible = true;
                        textCobros3.Visible = true;
                        textCobros4.Visible = false;
                        textCobros5.Visible = false;
                        textCobros6.Visible = false;
                        textCobros7.Visible = false;
                        textCobros8.Visible = false;
                        textCobros9.Visible = false;
                        textCobros10.Visible = false;
                        labelCobros1.Visible = true;
                        labelCobros2.Visible = true;
                        labelCobros3.Visible = true;
                        labelCobros4.Visible = false;
                        labelCobros5.Visible = false;
                        labelCobros6.Visible = false;
                        labelCobros7.Visible = false;
                        labelCobros8.Visible = false;
                        labelCobros9.Visible = false;
                        labelCobros10.Visible = false;
                        /*Tabla Pagos*/
                        dgvPagos.Columns["colPagos1"].Visible = true;
                        dgvPagos.Columns["colPagos2"].Visible = true;
                        dgvPagos.Columns["colPagos3"].Visible = true;
                        dgvPagos.Columns["colPagos4"].Visible = false;
                        dgvPagos.Columns["colPagos5"].Visible = false;
                        dgvPagos.Columns["colPagos6"].Visible = false;
                        dgvPagos.Columns["colPagos7"].Visible = false;
                        dgvPagos.Columns["colPagos8"].Visible = false;
                        dgvPagos.Columns["colPagos9"].Visible = false;
                        dgvPagos.Columns["colPagos10"].Visible = false;
                        textBoxPagos1.Visible = true;
                        textBoxPagos2.Visible = true;
                        textBoxPagos3.Visible = true;
                        textBoxPagos4.Visible = false;
                        textBoxPagos5.Visible = false;
                        textBoxPagos6.Visible = false;
                        textBoxPagos7.Visible = false;
                        textBoxPagos8.Visible = false;
                        textBoxPagos9.Visible = false;
                        textBoxPagos10.Visible = false;
                        labelPagos1.Visible = true;
                        labelPagos2.Visible = true;
                        labelPagos3.Visible = true;
                        labelPagos4.Visible = false;
                        labelPagos5.Visible = false;
                        labelPagos6.Visible = false;
                        labelPagos7.Visible = false;
                        labelPagos8.Visible = false;
                        labelPagos9.Visible = false;
                        labelPagos10.Visible = false;
                        /*Flujos de Caja*/
                        dgvFlujosCaja.Columns["FLC1"].Visible = true;
                        dgvFlujosCaja.Columns["FLC2"].Visible = true;
                        dgvFlujosCaja.Columns["FLC3"].Visible = true;
                        dgvFlujosCaja.Columns["FLC4"].Visible = false;
                        dgvFlujosCaja.Columns["FLC5"].Visible = false;
                        dgvFlujosCaja.Columns["FLC6"].Visible = false;
                        dgvFlujosCaja.Columns["FLC7"].Visible = false;
                        dgvFlujosCaja.Columns["FLC8"].Visible = false;
                        dgvFlujosCaja.Columns["FLC9"].Visible = false;
                        dgvFlujosCaja.Columns["FLC10"].Visible = false;
                        break;

                    case 4:
                        dataGridView1.Columns["ColDepreciacion1"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion2"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion3"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion4"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion5"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion6"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion7"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion8"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion9"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion10"].Visible = false;
                        textDeprec1.Visible = true;
                        textDeprec2.Visible = true;
                        textDeprec3.Visible = true;
                        textDeprec4.Visible = true;
                        textDeprec5.Visible = false;
                        textDeprec6.Visible = false;
                        textDeprec7.Visible = false;
                        textDeprec8.Visible = false;
                        textDeprec9.Visible = false;
                        textDeprec10.Visible = false;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;
                        /*Tabla Cobros*/
                        dgvCobros.Columns["colCobros1"].Visible = true;
                        dgvCobros.Columns["colCobros2"].Visible = true;
                        dgvCobros.Columns["colCobros3"].Visible = true;
                        dgvCobros.Columns["colCobros4"].Visible = true;
                        dgvCobros.Columns["colCobros5"].Visible = false;
                        dgvCobros.Columns["colCobros6"].Visible = false;
                        dgvCobros.Columns["colCobros7"].Visible = false;
                        dgvCobros.Columns["colCobros8"].Visible = false;
                        dgvCobros.Columns["colCobros9"].Visible = false;
                        dgvCobros.Columns["colCobros10"].Visible = false;
                        textCobros1.Visible = true;
                        textCobros2.Visible = true;
                        textCobros3.Visible = true;
                        textCobros4.Visible = true;
                        textCobros5.Visible = false;
                        textCobros6.Visible = false;
                        textCobros7.Visible = false;
                        textCobros8.Visible = false;
                        textCobros9.Visible = false;
                        textCobros10.Visible = false;
                        labelCobros1.Visible = true;
                        labelCobros2.Visible = true;
                        labelCobros3.Visible = true;
                        labelCobros4.Visible = true;
                        labelCobros5.Visible = false;
                        labelCobros6.Visible = false;
                        labelCobros7.Visible = false;
                        labelCobros8.Visible = false;
                        labelCobros9.Visible = false;
                        labelCobros10.Visible = false;
                        /*Tabla Pagos*/
                        dgvPagos.Columns["colPagos1"].Visible = true;
                        dgvPagos.Columns["colPagos2"].Visible = true;
                        dgvPagos.Columns["colPagos3"].Visible = true;
                        dgvPagos.Columns["colPagos4"].Visible = true;
                        dgvPagos.Columns["colPagos5"].Visible = false;
                        dgvPagos.Columns["colPagos6"].Visible = false;
                        dgvPagos.Columns["colPagos7"].Visible = false;
                        dgvPagos.Columns["colPagos8"].Visible = false;
                        dgvPagos.Columns["colPagos9"].Visible = false;
                        dgvPagos.Columns["colPagos10"].Visible = false;
                        textBoxPagos1.Visible = true;
                        textBoxPagos2.Visible = true;
                        textBoxPagos3.Visible = true;
                        textBoxPagos4.Visible = true;
                        textBoxPagos5.Visible = false;
                        textBoxPagos6.Visible = false;
                        textBoxPagos7.Visible = false;
                        textBoxPagos8.Visible = false;
                        textBoxPagos9.Visible = false;
                        textBoxPagos10.Visible = false;
                        labelPagos1.Visible = true;
                        labelPagos2.Visible = true;
                        labelPagos3.Visible = true;
                        labelPagos4.Visible = true;
                        labelPagos5.Visible = false;
                        labelPagos6.Visible = false;
                        labelPagos7.Visible = false;
                        labelPagos8.Visible = false;
                        labelPagos9.Visible = false;
                        labelPagos10.Visible = false;
                        /*Flujos de Caja*/
                        dgvFlujosCaja.Columns["FLC1"].Visible = true;
                        dgvFlujosCaja.Columns["FLC2"].Visible = true;
                        dgvFlujosCaja.Columns["FLC3"].Visible = true;
                        dgvFlujosCaja.Columns["FLC4"].Visible = true;
                        dgvFlujosCaja.Columns["FLC5"].Visible = false;
                        dgvFlujosCaja.Columns["FLC6"].Visible = false;
                        dgvFlujosCaja.Columns["FLC7"].Visible = false;
                        dgvFlujosCaja.Columns["FLC8"].Visible = false;
                        dgvFlujosCaja.Columns["FLC9"].Visible = false;
                        dgvFlujosCaja.Columns["FLC10"].Visible = false;
                        break;

                    case 5:
                        dataGridView1.Columns["ColDepreciacion1"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion2"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion3"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion4"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion5"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion6"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion7"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion8"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion9"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion10"].Visible = false;
                        textDeprec1.Visible = true;
                        textDeprec2.Visible = true;
                        textDeprec3.Visible = true;
                        textDeprec4.Visible = true;
                        textDeprec5.Visible = true;
                        textDeprec6.Visible = false;
                        textDeprec7.Visible = false;
                        textDeprec8.Visible = false;
                        textDeprec9.Visible = false;
                        textDeprec10.Visible = false;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        label8.Visible = false;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;
                        /*Tabla Cobros*/
                        dgvCobros.Columns["colCobros1"].Visible = true;
                        dgvCobros.Columns["colCobros2"].Visible = true;
                        dgvCobros.Columns["colCobros3"].Visible = true;
                        dgvCobros.Columns["colCobros4"].Visible = true;
                        dgvCobros.Columns["colCobros5"].Visible = true;
                        dgvCobros.Columns["colCobros6"].Visible = false;
                        dgvCobros.Columns["colCobros7"].Visible = false;
                        dgvCobros.Columns["colCobros8"].Visible = false;
                        dgvCobros.Columns["colCobros9"].Visible = false;
                        dgvCobros.Columns["colCobros10"].Visible = false;
                        textCobros1.Visible = true;
                        textCobros2.Visible = true;
                        textCobros3.Visible = true;
                        textCobros4.Visible = true;
                        textCobros5.Visible = true;
                        textCobros6.Visible = false;
                        textCobros7.Visible = false;
                        textCobros8.Visible = false;
                        textCobros9.Visible = false;
                        textCobros10.Visible = false;
                        labelCobros1.Visible = true;
                        labelCobros2.Visible = true;
                        labelCobros3.Visible = true;
                        labelCobros4.Visible = true;
                        labelCobros5.Visible = true;
                        labelCobros6.Visible = false;
                        labelCobros7.Visible = false;
                        labelCobros8.Visible = false;
                        labelCobros9.Visible = false;
                        labelCobros10.Visible = false;
                        /*Tabla Pagos*/
                        dgvPagos.Columns["colPagos1"].Visible = true;
                        dgvPagos.Columns["colPagos2"].Visible = true;
                        dgvPagos.Columns["colPagos3"].Visible = true;
                        dgvPagos.Columns["colPagos4"].Visible = true;
                        dgvPagos.Columns["colPagos5"].Visible = true;
                        dgvPagos.Columns["colPagos6"].Visible = false;
                        dgvPagos.Columns["colPagos7"].Visible = false;
                        dgvPagos.Columns["colPagos8"].Visible = false;
                        dgvPagos.Columns["colPagos9"].Visible = false;
                        dgvPagos.Columns["colPagos10"].Visible = false;
                        textBoxPagos1.Visible = true;
                        textBoxPagos2.Visible = true;
                        textBoxPagos3.Visible = true;
                        textBoxPagos4.Visible = true;
                        textBoxPagos5.Visible = true;
                        textBoxPagos6.Visible = false;
                        textBoxPagos7.Visible = false;
                        textBoxPagos8.Visible = false;
                        textBoxPagos9.Visible = false;
                        textBoxPagos10.Visible = false;
                        labelPagos1.Visible = true;
                        labelPagos2.Visible = true;
                        labelPagos3.Visible = true;
                        labelPagos4.Visible = true;
                        labelPagos5.Visible = true;
                        labelPagos6.Visible = false;
                        labelPagos7.Visible = false;
                        labelPagos8.Visible = false;
                        labelPagos9.Visible = false;
                        labelPagos10.Visible = false;
                        /*Flujos de Caja*/
                        dgvFlujosCaja.Columns["FLC1"].Visible = true;
                        dgvFlujosCaja.Columns["FLC2"].Visible = true;
                        dgvFlujosCaja.Columns["FLC3"].Visible = true;
                        dgvFlujosCaja.Columns["FLC4"].Visible = true;
                        dgvFlujosCaja.Columns["FLC5"].Visible = true;
                        dgvFlujosCaja.Columns["FLC6"].Visible = false;
                        dgvFlujosCaja.Columns["FLC7"].Visible = false;
                        dgvFlujosCaja.Columns["FLC8"].Visible = false;
                        dgvFlujosCaja.Columns["FLC9"].Visible = false;
                        dgvFlujosCaja.Columns["FLC10"].Visible = false;
                        break;

                    case 6:
                        dataGridView1.Columns["ColDepreciacion1"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion2"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion3"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion4"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion5"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion6"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion7"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion8"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion9"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion10"].Visible = false;
                        textDeprec1.Visible = true;
                        textDeprec2.Visible = true;
                        textDeprec3.Visible = true;
                        textDeprec4.Visible = true;
                        textDeprec5.Visible = true;
                        textDeprec6.Visible = true;
                        textDeprec7.Visible = false;
                        textDeprec8.Visible = false;
                        textDeprec9.Visible = false;
                        textDeprec10.Visible = false;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        label8.Visible = true;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;
                        /*Tabla Cobros*/
                        dgvCobros.Columns["colCobros1"].Visible = true;
                        dgvCobros.Columns["colCobros2"].Visible = true;
                        dgvCobros.Columns["colCobros3"].Visible = true;
                        dgvCobros.Columns["colCobros4"].Visible = true;
                        dgvCobros.Columns["colCobros5"].Visible = true;
                        dgvCobros.Columns["colCobros6"].Visible = true;
                        dgvCobros.Columns["colCobros7"].Visible = false;
                        dgvCobros.Columns["colCobros8"].Visible = false;
                        dgvCobros.Columns["colCobros9"].Visible = false;
                        dgvCobros.Columns["colCobros10"].Visible = false;
                        textCobros1.Visible = true;
                        textCobros2.Visible = true;
                        textCobros3.Visible = true;
                        textCobros4.Visible = true;
                        textCobros5.Visible = true;
                        textCobros6.Visible = true;
                        textCobros7.Visible = false;
                        textCobros8.Visible = false;
                        textCobros9.Visible = false;
                        textCobros10.Visible = false;
                        labelCobros1.Visible = true;
                        labelCobros2.Visible = true;
                        labelCobros3.Visible = true;
                        labelCobros4.Visible = true;
                        labelCobros5.Visible = true;
                        labelCobros6.Visible = true;
                        labelCobros7.Visible = false;
                        labelCobros8.Visible = false;
                        labelCobros9.Visible = false;
                        labelCobros10.Visible = false;
                        /*Tabla Pagos*/
                        dgvPagos.Columns["colPagos1"].Visible = true;
                        dgvPagos.Columns["colPagos2"].Visible = true;
                        dgvPagos.Columns["colPagos3"].Visible = true;
                        dgvPagos.Columns["colPagos4"].Visible = true;
                        dgvPagos.Columns["colPagos5"].Visible = true;
                        dgvPagos.Columns["colPagos6"].Visible = true;
                        dgvPagos.Columns["colPagos7"].Visible = false;
                        dgvPagos.Columns["colPagos8"].Visible = false;
                        dgvPagos.Columns["colPagos9"].Visible = false;
                        dgvPagos.Columns["colPagos10"].Visible = false;
                        textBoxPagos1.Visible = true;
                        textBoxPagos2.Visible = true;
                        textBoxPagos3.Visible = true;
                        textBoxPagos4.Visible = true;
                        textBoxPagos5.Visible = true;
                        textBoxPagos6.Visible = true;
                        textBoxPagos7.Visible = false;
                        textBoxPagos8.Visible = false;
                        textBoxPagos9.Visible = false;
                        textBoxPagos10.Visible = false;
                        labelPagos1.Visible = true;
                        labelPagos2.Visible = true;
                        labelPagos3.Visible = true;
                        labelPagos4.Visible = true;
                        labelPagos5.Visible = true;
                        labelPagos6.Visible = true;
                        labelPagos7.Visible = false;
                        labelPagos8.Visible = false;
                        labelPagos9.Visible = false;
                        labelPagos10.Visible = false;
                        /*Flujos de Caja*/
                        dgvFlujosCaja.Columns["FLC1"].Visible = true;
                        dgvFlujosCaja.Columns["FLC2"].Visible = true;
                        dgvFlujosCaja.Columns["FLC3"].Visible = true;
                        dgvFlujosCaja.Columns["FLC4"].Visible = true;
                        dgvFlujosCaja.Columns["FLC5"].Visible = true;
                        dgvFlujosCaja.Columns["FLC6"].Visible = true;
                        dgvFlujosCaja.Columns["FLC7"].Visible = false;
                        dgvFlujosCaja.Columns["FLC8"].Visible = false;
                        dgvFlujosCaja.Columns["FLC9"].Visible = false;
                        dgvFlujosCaja.Columns["FLC10"].Visible = false;
                        break;

                    case 7:
                        dataGridView1.Columns["ColDepreciacion1"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion2"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion3"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion4"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion5"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion6"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion7"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion8"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion9"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion10"].Visible = false;
                        textDeprec1.Visible = true;
                        textDeprec2.Visible = true;
                        textDeprec3.Visible = true;
                        textDeprec4.Visible = true;
                        textDeprec5.Visible = true;
                        textDeprec6.Visible = true;
                        textDeprec7.Visible = true;
                        textDeprec8.Visible = false;
                        textDeprec9.Visible = false;
                        textDeprec10.Visible = false;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        label8.Visible = true;
                        label9.Visible = true;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;
                        /*Tabla Cobros*/
                        dgvCobros.Columns["colCobros1"].Visible = true;
                        dgvCobros.Columns["colCobros2"].Visible = true;
                        dgvCobros.Columns["colCobros3"].Visible = true;
                        dgvCobros.Columns["colCobros4"].Visible = true;
                        dgvCobros.Columns["colCobros5"].Visible = true;
                        dgvCobros.Columns["colCobros6"].Visible = true;
                        dgvCobros.Columns["colCobros7"].Visible = true;
                        dgvCobros.Columns["colCobros8"].Visible = false;
                        dgvCobros.Columns["colCobros9"].Visible = false;
                        dgvCobros.Columns["colCobros10"].Visible = false;
                        textCobros1.Visible = true;
                        textCobros2.Visible = true;
                        textCobros3.Visible = true;
                        textCobros4.Visible = true;
                        textCobros5.Visible = true;
                        textCobros6.Visible = true;
                        textCobros7.Visible = true;
                        textCobros8.Visible = false;
                        textCobros9.Visible = false;
                        textCobros10.Visible = false;
                        labelCobros1.Visible = true;
                        labelCobros2.Visible = true;
                        labelCobros3.Visible = true;
                        labelCobros4.Visible = true;
                        labelCobros5.Visible = true;
                        labelCobros6.Visible = true;
                        labelCobros7.Visible = true;
                        labelCobros8.Visible = false;
                        labelCobros9.Visible = false;
                        labelCobros10.Visible = false;
                        /*Tabla Pagos*/
                        dgvPagos.Columns["colPagos1"].Visible = true;
                        dgvPagos.Columns["colPagos2"].Visible = true;
                        dgvPagos.Columns["colPagos3"].Visible = true;
                        dgvPagos.Columns["colPagos4"].Visible = true;
                        dgvPagos.Columns["colPagos5"].Visible = true;
                        dgvPagos.Columns["colPagos6"].Visible = true;
                        dgvPagos.Columns["colPagos7"].Visible = true;
                        dgvPagos.Columns["colPagos8"].Visible = false;
                        dgvPagos.Columns["colPagos9"].Visible = false;
                        dgvPagos.Columns["colPagos10"].Visible = false;
                        textBoxPagos1.Visible = true;
                        textBoxPagos2.Visible = true;
                        textBoxPagos3.Visible = true;
                        textBoxPagos4.Visible = true;
                        textBoxPagos5.Visible = true;
                        textBoxPagos6.Visible = true;
                        textBoxPagos7.Visible = true;
                        textBoxPagos8.Visible = false;
                        textBoxPagos9.Visible = false;
                        textBoxPagos10.Visible = false;
                        labelPagos1.Visible = true;
                        labelPagos2.Visible = true;
                        labelPagos3.Visible = true;
                        labelPagos4.Visible = true;
                        labelPagos5.Visible = true;
                        labelPagos6.Visible = true;
                        labelPagos7.Visible = true;
                        labelPagos8.Visible = false;
                        labelPagos9.Visible = false;
                        labelPagos10.Visible = false;
                        /*Flujos de Caja*/
                        dgvFlujosCaja.Columns["FLC1"].Visible = true;
                        dgvFlujosCaja.Columns["FLC2"].Visible = true;
                        dgvFlujosCaja.Columns["FLC3"].Visible = true;
                        dgvFlujosCaja.Columns["FLC4"].Visible = true;
                        dgvFlujosCaja.Columns["FLC5"].Visible = true;
                        dgvFlujosCaja.Columns["FLC6"].Visible = true;
                        dgvFlujosCaja.Columns["FLC7"].Visible = true;
                        dgvFlujosCaja.Columns["FLC8"].Visible = false;
                        dgvFlujosCaja.Columns["FLC9"].Visible = false;
                        dgvFlujosCaja.Columns["FLC10"].Visible = false;
                        break;

                    case 8:
                        dataGridView1.Columns["ColDepreciacion1"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion2"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion3"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion4"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion5"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion6"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion7"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion8"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion9"].Visible = false;
                        dataGridView1.Columns["ColDepreciacion10"].Visible = false;
                        textDeprec1.Visible = true;
                        textDeprec2.Visible = true;
                        textDeprec3.Visible = true;
                        textDeprec4.Visible = true;
                        textDeprec5.Visible = true;
                        textDeprec6.Visible = true;
                        textDeprec7.Visible = true;
                        textDeprec8.Visible = true;
                        textDeprec9.Visible = false;
                        textDeprec10.Visible = false;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        label8.Visible = true;
                        label9.Visible = true;
                        label10.Visible = true;
                        label11.Visible = false;
                        label12.Visible = false;
                        /*Tabla Cobros*/
                        dgvCobros.Columns["colCobros1"].Visible = true;
                        dgvCobros.Columns["colCobros2"].Visible = true;
                        dgvCobros.Columns["colCobros3"].Visible = true;
                        dgvCobros.Columns["colCobros4"].Visible = true;
                        dgvCobros.Columns["colCobros5"].Visible = true;
                        dgvCobros.Columns["colCobros6"].Visible = true;
                        dgvCobros.Columns["colCobros7"].Visible = true;
                        dgvCobros.Columns["colCobros8"].Visible = true;
                        dgvCobros.Columns["colCobros9"].Visible = false;
                        dgvCobros.Columns["colCobros10"].Visible = false;
                        textCobros1.Visible = true;
                        textCobros2.Visible = true;
                        textCobros3.Visible = true;
                        textCobros4.Visible = true;
                        textCobros5.Visible = true;
                        textCobros6.Visible = true;
                        textCobros7.Visible = true;
                        textCobros8.Visible = true;
                        textCobros9.Visible = false;
                        textCobros10.Visible = false;
                        labelCobros1.Visible = true;
                        labelCobros2.Visible = true;
                        labelCobros3.Visible = true;
                        labelCobros4.Visible = true;
                        labelCobros5.Visible = true;
                        labelCobros6.Visible = true;
                        labelCobros7.Visible = true;
                        labelCobros8.Visible = true;
                        labelCobros9.Visible = false;
                        labelCobros10.Visible = false;
                        /*Tabla Pagos*/
                        dgvPagos.Columns["colPagos1"].Visible = true;
                        dgvPagos.Columns["colPagos2"].Visible = true;
                        dgvPagos.Columns["colPagos3"].Visible = true;
                        dgvPagos.Columns["colPagos4"].Visible = true;
                        dgvPagos.Columns["colPagos5"].Visible = true;
                        dgvPagos.Columns["colPagos6"].Visible = true;
                        dgvPagos.Columns["colPagos7"].Visible = true;
                        dgvPagos.Columns["colPagos8"].Visible = true;
                        dgvPagos.Columns["colPagos9"].Visible = false;
                        dgvPagos.Columns["colPagos10"].Visible = false;
                        textBoxPagos1.Visible = true;
                        textBoxPagos2.Visible = true;
                        textBoxPagos3.Visible = true;
                        textBoxPagos4.Visible = true;
                        textBoxPagos5.Visible = true;
                        textBoxPagos6.Visible = true;
                        textBoxPagos7.Visible = true;
                        textBoxPagos8.Visible = true;
                        textBoxPagos9.Visible = false;
                        textBoxPagos10.Visible = false;
                        labelPagos1.Visible = true;
                        labelPagos2.Visible = true;
                        labelPagos3.Visible = true;
                        labelPagos4.Visible = true;
                        labelPagos5.Visible = true;
                        labelPagos6.Visible = true;
                        labelPagos7.Visible = true;
                        labelPagos8.Visible = true;
                        labelPagos9.Visible = false;
                        labelPagos10.Visible = false;
                        /*Flujos de Caja*/
                        dgvFlujosCaja.Columns["FLC1"].Visible = true;
                        dgvFlujosCaja.Columns["FLC2"].Visible = true;
                        dgvFlujosCaja.Columns["FLC3"].Visible = true;
                        dgvFlujosCaja.Columns["FLC4"].Visible = true;
                        dgvFlujosCaja.Columns["FLC5"].Visible = true;
                        dgvFlujosCaja.Columns["FLC6"].Visible = true;
                        dgvFlujosCaja.Columns["FLC7"].Visible = true;
                        dgvFlujosCaja.Columns["FLC8"].Visible = true;
                        dgvFlujosCaja.Columns["FLC9"].Visible = false;
                        dgvFlujosCaja.Columns["FLC10"].Visible = false;
                        break;

                    case 9:
                        dataGridView1.Columns["ColDepreciacion1"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion2"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion3"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion4"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion5"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion6"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion7"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion8"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion9"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion10"].Visible = false;
                        textDeprec1.Visible = true;
                        textDeprec2.Visible = true;
                        textDeprec3.Visible = true;
                        textDeprec4.Visible = true;
                        textDeprec5.Visible = true;
                        textDeprec6.Visible = true;
                        textDeprec7.Visible = true;
                        textDeprec8.Visible = true;
                        textDeprec9.Visible = true;
                        textDeprec10.Visible = false;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        label8.Visible = true;
                        label9.Visible = true;
                        label10.Visible = true;
                        label11.Visible = true;
                        label12.Visible = false;
                        /*Tabla Cobros*/
                        dgvCobros.Columns["colCobros1"].Visible = true;
                        dgvCobros.Columns["colCobros2"].Visible = true;
                        dgvCobros.Columns["colCobros3"].Visible = true;
                        dgvCobros.Columns["colCobros4"].Visible = true;
                        dgvCobros.Columns["colCobros5"].Visible = true;
                        dgvCobros.Columns["colCobros6"].Visible = true;
                        dgvCobros.Columns["colCobros7"].Visible = true;
                        dgvCobros.Columns["colCobros8"].Visible = true;
                        dgvCobros.Columns["colCobros9"].Visible = true;
                        dgvCobros.Columns["colCobros10"].Visible = false;
                        textCobros1.Visible = true;
                        textCobros2.Visible = true;
                        textCobros3.Visible = true;
                        textCobros4.Visible = true;
                        textCobros5.Visible = true;
                        textCobros6.Visible = true;
                        textCobros7.Visible = true;
                        textCobros8.Visible = true;
                        textCobros9.Visible = true;
                        textCobros10.Visible = false;
                        labelCobros1.Visible = true;
                        labelCobros2.Visible = true;
                        labelCobros3.Visible = true;
                        labelCobros4.Visible = true;
                        labelCobros5.Visible = true;
                        labelCobros6.Visible = true;
                        labelCobros7.Visible = true;
                        labelCobros8.Visible = true;
                        labelCobros9.Visible = true;
                        labelCobros10.Visible = false;
                        /*Tabla Pagos*/
                        dgvPagos.Columns["colPagos1"].Visible = true;
                        dgvPagos.Columns["colPagos2"].Visible = true;
                        dgvPagos.Columns["colPagos3"].Visible = true;
                        dgvPagos.Columns["colPagos4"].Visible = true;
                        dgvPagos.Columns["colPagos5"].Visible = true;
                        dgvPagos.Columns["colPagos6"].Visible = true;
                        dgvPagos.Columns["colPagos7"].Visible = true;
                        dgvPagos.Columns["colPagos8"].Visible = true;
                        dgvPagos.Columns["colPagos9"].Visible = true;
                        dgvPagos.Columns["colPagos10"].Visible = false;
                        textBoxPagos1.Visible = true;
                        textBoxPagos2.Visible = true;
                        textBoxPagos3.Visible = true;
                        textBoxPagos4.Visible = true;
                        textBoxPagos5.Visible = true;
                        textBoxPagos6.Visible = true;
                        textBoxPagos7.Visible = true;
                        textBoxPagos8.Visible = true;
                        textBoxPagos9.Visible = true;
                        textBoxPagos10.Visible = false;
                        labelPagos1.Visible = true;
                        labelPagos2.Visible = true;
                        labelPagos3.Visible = true;
                        labelPagos4.Visible = true;
                        labelPagos5.Visible = true;
                        labelPagos6.Visible = true;
                        labelPagos7.Visible = true;
                        labelPagos8.Visible = true;
                        labelPagos9.Visible = true;
                        labelPagos10.Visible = false;
                        /*Flujos de Caja*/
                        dgvFlujosCaja.Columns["FLC1"].Visible = true;
                        dgvFlujosCaja.Columns["FLC2"].Visible = true;
                        dgvFlujosCaja.Columns["FLC3"].Visible = true;
                        dgvFlujosCaja.Columns["FLC4"].Visible = true;
                        dgvFlujosCaja.Columns["FLC5"].Visible = true;
                        dgvFlujosCaja.Columns["FLC6"].Visible = true;
                        dgvFlujosCaja.Columns["FLC7"].Visible = true;
                        dgvFlujosCaja.Columns["FLC8"].Visible = true;
                        dgvFlujosCaja.Columns["FLC9"].Visible = true;
                        dgvFlujosCaja.Columns["FLC10"].Visible = false;
                        break;

                    case 10:
                        dataGridView1.Columns["ColDepreciacion1"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion2"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion3"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion4"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion5"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion6"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion7"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion8"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion9"].Visible = true;
                        dataGridView1.Columns["ColDepreciacion10"].Visible = true;
                        textDeprec1.Visible = true;
                        textDeprec2.Visible = true;
                        textDeprec3.Visible = true;
                        textDeprec4.Visible = true;
                        textDeprec5.Visible = true;
                        textDeprec6.Visible = true;
                        textDeprec7.Visible = true;
                        textDeprec8.Visible = true;
                        textDeprec9.Visible = true;
                        textDeprec10.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        label8.Visible = true;
                        label9.Visible = true;
                        label10.Visible = true;
                        label11.Visible = true;
                        label12.Visible = true;
                        /*Tabla Cobros*/
                        dgvCobros.Columns["colCobros1"].Visible = true;
                        dgvCobros.Columns["colCobros2"].Visible = true;
                        dgvCobros.Columns["colCobros3"].Visible = true;
                        dgvCobros.Columns["colCobros4"].Visible = true;
                        dgvCobros.Columns["colCobros5"].Visible = true;
                        dgvCobros.Columns["colCobros6"].Visible = true;
                        dgvCobros.Columns["colCobros7"].Visible = true;
                        dgvCobros.Columns["colCobros8"].Visible = true;
                        dgvCobros.Columns["colCobros9"].Visible = true;
                        dgvCobros.Columns["colCobros10"].Visible = true;
                        textCobros1.Visible = true;
                        textCobros2.Visible = true;
                        textCobros3.Visible = true;
                        textCobros4.Visible = true;
                        textCobros5.Visible = true;
                        textCobros6.Visible = true;
                        textCobros7.Visible = true;
                        textCobros8.Visible = true;
                        textCobros9.Visible = true;
                        textCobros10.Visible = true;
                        labelCobros1.Visible = true;
                        labelCobros2.Visible = true;
                        labelCobros3.Visible = true;
                        labelCobros4.Visible = true;
                        labelCobros5.Visible = true;
                        labelCobros6.Visible = true;
                        labelCobros7.Visible = true;
                        labelCobros8.Visible = true;
                        labelCobros9.Visible = true;
                        labelCobros10.Visible = true;
                        /*Tabla Pagos*/
                        dgvPagos.Columns["colPagos1"].Visible = true;
                        dgvPagos.Columns["colPagos2"].Visible = true;
                        dgvPagos.Columns["colPagos3"].Visible = true;
                        dgvPagos.Columns["colPagos4"].Visible = true;
                        dgvPagos.Columns["colPagos5"].Visible = true;
                        dgvPagos.Columns["colPagos6"].Visible = true;
                        dgvPagos.Columns["colPagos7"].Visible = true;
                        dgvPagos.Columns["colPagos8"].Visible = true;
                        dgvPagos.Columns["colPagos9"].Visible = true;
                        dgvPagos.Columns["colPagos10"].Visible = true;
                        textBoxPagos1.Visible = true;
                        textBoxPagos2.Visible = true;
                        textBoxPagos3.Visible = true;
                        textBoxPagos4.Visible = true;
                        textBoxPagos5.Visible = true;
                        textBoxPagos6.Visible = true;
                        textBoxPagos7.Visible = true;
                        textBoxPagos8.Visible = true;
                        textBoxPagos9.Visible = true;
                        textBoxPagos10.Visible = true;
                        labelPagos1.Visible = true;
                        labelPagos2.Visible = true;
                        labelPagos3.Visible = true;
                        labelPagos4.Visible = true;
                        labelPagos5.Visible = true;
                        labelPagos6.Visible = true;
                        labelPagos7.Visible = true;
                        labelPagos8.Visible = true;
                        labelPagos9.Visible = true;
                        labelPagos10.Visible = true;
                        /*Flujos de Caja*/
                        dgvFlujosCaja.Columns["FLC1"].Visible = true;
                        dgvFlujosCaja.Columns["FLC2"].Visible = true;
                        dgvFlujosCaja.Columns["FLC3"].Visible = true;
                        dgvFlujosCaja.Columns["FLC4"].Visible = true;
                        dgvFlujosCaja.Columns["FLC5"].Visible = true;
                        dgvFlujosCaja.Columns["FLC6"].Visible = true;
                        dgvFlujosCaja.Columns["FLC7"].Visible = true;
                        dgvFlujosCaja.Columns["FLC8"].Visible = true;
                        dgvFlujosCaja.Columns["FLC9"].Visible = true;
                        dgvFlujosCaja.Columns["FLC10"].Visible =true;
                        break;
                    default:
                        MessageBox.Show("El numero máximo de periodos maximo es 10 y el minimo 1");
                        break;

                }
         }
         else
         {
                MessageBox.Show("Introduzca el número de periodos");
         }
            
            
        }

        /*
         * Función: void  dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
         * Param:
         * Return: none
         * Descripción: Funcion para calcular la depreciación y el total cuando se termina de escribir
         *              en las celdas de la tabla
         * Autor: Javier Salvador Garcia
         */
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            calculoDepreciacion();
            calculo();
           
        }

        /*
         * Función: void numPeriodos_KeyPress(object sender, KeyPressEventArgs e)
         * Param:
         * Return: none
         * Descripción: Funcion para permitir solo la entrada de caracteres numéricos
         * Autor: Javier Salvador Garcia
         */
        private void numPeriodos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point 
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        /*
         * Función: void butNumPeriodos_Click(object sender, EventArgs e)
         * Param:
         * Return: none
         * Descripción: Funcion para llamar a la función numPeriodos cuando se pincha el boton
         * Autor: Javier Salvador Garcia
         */
        private void butNumPeriodos_Click(object sender, EventArgs e)
        {
            numPeriodos(TextNumPeriodos.Text);
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        /*
         * Función: void dgvCobros_CellEndEdit(object sender, EventArgs e)
         * Param:
         * Return: none
         * Descripción: Funcion para calcular el total de pagos segun se termina de editar la celda
         * Autor: Javier Salvador Garcia
         */
        private void dgvCobros_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            calculo_cobros();
        }

        /*
         * Función: void dgvPagos_CellEndEdit(object sender, EventArgs e)
         * Param:
         * Return: none
         * Descripción: Funcion para calcular el total de pagos segun se termina de editar la celda
         * Autor: Javier Salvador Garcia
         */
        private void dgvPagos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            calculo_pagos();
        }

        /*
         * Función: void dgvPagos_CellEndEdit(object sender, EventArgs e)
         * Param:
         * Return: none
         * Descripción: Funcion para calcular los flujos de caja
         * Autor: Javier Salvador Garcia
         */
        private void CalFlujosCaja_Click(object sender, EventArgs e)
        {
            if(textBoxTasaImpositiva.Text =="")
            {
                MessageBox.Show("No ha indicado la tasa impositiva que desea utilizar");
            }
            else
            {
                calculoFlujosCaja(TextNumPeriodos.Text);
            }

        }

        /*
         * Función: void textBoxTasaImpositiva_KeyPress(object sender, EventArgs e)
         * Param:
         * Return: none
         * Descripción: Funcion para permitir solo la entrada de datos numéricos
         * Autor: Javier Salvador Garcia
         */
        private void textBoxTasaImpositiva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&  (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point 
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        /*
         * Función: void butCalVAN_Click(object sender, EventArgs e)
         * Param:
         * Return: none
         * Descripción: Funcion para realizar los cálculos del VAN, TIR e IR
         * Autor: Javier Salvador Garcia
         */
        private void butCalVAN_Click(object sender, EventArgs e)
        {
            //proteccion para el indice y para valor nulo en los datos que se utilizan
            double VAN;
            double TIR;
            double IR;
            double guess = 0.1;
            double[] flujos = new double[11];

            /*Bucle para rellenar el array con todos los valores de los flujos de caja*/
            try
            {
                for (int i = 0; i < int.Parse(TextNumPeriodos.Text); i++)   //bucle para recorrer todas la columnas que van a almacenar
                {
                    for (int j = 0; j < dgvFlujosCaja.RowCount; j++)        //bucle para recorrer las filas
                    {
                       flujos[i + 1] = double.Parse(dgvFlujosCaja.Rows[j].Cells[i].Value.ToString());
                    }
                }
            
                flujos[0] = -1 * double.Parse(textBoxImporte.Text);
                double ratio = 1.14;
                VAN = Financial.NPV(ratio, ref flujos);
                IR = (VAN + (-1 * flujos[0]))/(-1 * flujos[0]);
                TIR = Financial.IRR(ref flujos, guess) * 100;
                textBoxResultadoTIR.Text = TIR.ToString("N2") + "%";
                textBoxResultadoVAN.Text = VAN.ToString("N2") + "€";
                textBoxResultadoIR.Text = IR.ToString("N2");
            }
            catch (Exception)
            {
                
                if (TextNumPeriodos.Text == "")
                {
                    MessageBox.Show("No ha introducido el numero de periodos");
                }
                else
                {
                    MessageBox.Show("Los flujos de caja no estan calculados");
                }
            }
            

            

        }

        /*
         * Función: void buttGuardar_Click(object sender, EventArgs e)
         * Param:
         * Return: none
         * Descripción: Funcion para guardar toda la información de la ventana en formato imagen
         * Autor: Javier Salvador Garcia
         */
        private void buttGuardar_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Title = "Guardar Imagen En....";
            SaveFileDialog1.DefaultExt = "jpeg";
            SaveFileDialog1.Filter = "JPEG|*.jpeg|BITMAP|*.bmp|PNG|*.png|All Files|*.*";
            SaveFileDialog1.FilterIndex = 1;
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, panel1.DisplayRectangle);

            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (SaveFileDialog1.FileName == "")
                {
                    return;
                }
                //Obtengo la extension del archivo
                string strExt;
                strExt = System.IO.Path.GetExtension(SaveFileDialog1.FileName);

                if (strExt == ".jpeg")
                {
                    bmp.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                if (strExt == ".bmp")
                {
                    bmp.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                }
                if (strExt == ".png")
                {
                    bmp.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
                MessageBox.Show("Imagen Guardada Correctamente!\n* Ubicacion : " + SaveFileDialog1.FileName + "");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
