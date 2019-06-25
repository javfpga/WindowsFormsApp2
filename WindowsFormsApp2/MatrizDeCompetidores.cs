/*
 * Archivo: MatrizDeCompetidores.cs
 * Descripión: Ventana para generar una tabla para la comparación
 *              de distintos factores críticos entre distintas empresas
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
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp2
{
    public partial class MatrizDeCompetidores : Form
    {
        public MatrizDeCompetidores()
        {
            InitializeComponent();
            DataGridViewTextBoxColumn ColumnaFactores = new DataGridViewTextBoxColumn();
            ColumnaFactores.HeaderText = "Factores Críticos";
            ColumnaFactores.Name = "Factores Críticos";
            dgv.Columns.Add(ColumnaFactores);
            NumericGridColumn ColumnaValores = new NumericGridColumn();
            ColumnaValores.HeaderText = "Valor";
            ColumnaValores.Name = "Valor";
            dgv.Columns.Add(ColumnaValores);


        }

        int color = 0;  // Variable para generar el color alternativo de las columnas
        
        /*
         * Función: agregarColumna (string nomEmpresa)
         * Param: nomEmpresa
         * Return: none
         * Descripción: Función para agregar las columnas de las empresas en la tabla
         * Autor: Javier Salvador Garcia
         */
        void agregarColumna (string nomEmpresa)
        {
            NumericGridColumn Columna1 = new NumericGridColumn();   //Creación de la columna
            Columna1.HeaderText = "Calficiación Empresa: " + nomEmpresa;            //Nombre de la cabecera de la columna
            Columna1.Name = "Calficiación Empresa: " + nomEmpresa;
            // Columna1.DefaultCellStyle.Format = "d";
            dgv.Columns.Add(Columna1);                                              //Agregamos la columna al datagridview
            //dgv.Columns["Calficiación Empresa: " + nomEmpresa].DefaultCellStyle.Format = "N2";
            NumericGridColumn Columna2 = new NumericGridColumn();
            Columna2.HeaderText = "Ponderación Empresa: " + nomEmpresa;
            Columna2.Name = "Ponderación Empresa: " + nomEmpresa;
            Columna2.ReadOnly = true;   //para que no sea editable
           // Columna2.DefaultCellStyle.Format = "d";
            dgv.Columns.Add(Columna2);
            if (color == 0)
            {
                Columna1.DefaultCellStyle.BackColor = Color.LightGray;                //Color de la celda
                Columna1.DefaultCellStyle.SelectionBackColor = Color.LightSlateGray;    //Color de la celda cuando esta seleccionada
                Columna2.DefaultCellStyle.BackColor = Color.LightGray;
                Columna2.DefaultCellStyle.SelectionBackColor = Color.LightSlateGray;
                color = color + 1;
            }
            else
            {
                Columna1.DefaultCellStyle.BackColor = Color.WhiteSmoke;  //LightGray DimGray
                Columna1.DefaultCellStyle.SelectionBackColor = Color.LightSlateGray;
                Columna2.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                Columna2.DefaultCellStyle.SelectionBackColor = Color.LightSlateGray;

                color = 0;
            }
        }

        /*
         * Función: void butAdd_Click(object sender, EventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para llamar a la función agregarEmpresa cuando se pincha el botón
         * Autor: Javier Salvador Garcia
         */
        private void butAdd_Click(object sender, EventArgs e)
        {
            //Control de cadena vacia
            if (txtNomEmpresa.Text != "")
            {
                agregarColumna(txtNomEmpresa.Text); //Llamada a la función para agregar las columnas de las empresas
            }
            else
            {
                MessageBox.Show("No ha introducido ningún nombre de empresa");  //Mensaje de aviso
            }
            txtNomEmpresa.Clear();  // Limpiamos el buffer del TextBox donde se escribe el nombre de la empresa
        }


        decimal calificacion = 0;
        decimal valor = 0;
        decimal ponderacion = 0;
        decimal pesoValor = 0;
        /*
         * Función: void butValorar_Click(object sender, EventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para calcular la ponderación de las empresas cuando se pincha el botón
         * Autor: Javier Salvador Garcia
         */
        private void butValorar_Click(object sender, EventArgs e)   //la variable i marca la posicion de la columna en la que nos encontramos
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                pesoValor += Convert.ToDecimal(row.Cells[1].Value);
            }
            if(pesoValor == 1)
            {
                for (int i = 3; i < dgv.ColumnCount; i = i + 2)   //bucle para recorrer todas la columnas que van a almacenar la ponderacion
                {
                    for (int j = 0; j < dgv.RowCount - 1; j++)     //bucle para recorrer todas las filas de una columna
                    {
                        int columna_actual = i - 1;
                        try
                        {
                            valor = decimal.Parse(dgv.Rows[j].Cells[1].Value.ToString());   //recorremos todas las filas de la columna valor
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Debe completar el campo valor fila:" + j);
                            valor = 0;
                        }
                        try
                        {
                            calificacion = decimal.Parse(dgv.Rows[j].Cells[i - 1].Value.ToString());  //recorremos todas las filas de la columna calificacion
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Debe completar la fila: " + j + " de la columna: " + columna_actual);
                            calificacion = 0;
                        }
                        if (!(valor == 0) && !(calificacion == 0))
                        {
                            ponderacion = valor * calificacion;         //Realizamos la operacion 
                            dgv.Rows[j].Cells[i].Value = ponderacion;   //Escribimos en la celda 
                        }

                    }

                }
                pesoValor = 0;
            }
            else
            {
                MessageBox.Show("La suma del valor tota es distinta de 1"+ "\n" +"Su valor actual es: "+ pesoValor + " y deberia ser 1");
                pesoValor = 0;
            }
            
        }


        /*
         * Función: void butDel_Click(object sender, EventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para eliminar filas de la tabla
         * Autor: Javier Salvador Garcia
         */
        private void butDel_Click(object sender, EventArgs e)
        {
            try
            {
                dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
            }
            catch(Exception)
            {
                MessageBox.Show("No hay nada para eliminar");
            }
        }

        /*
         * Función: void button1_Click(object sender, EventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para eliminar columnas de la tabla
         * Autor: Javier Salvador Garcia
         */
        private void button1_Click(object sender, EventArgs e)
        {
            
          
            if ((dgv.ColumnCount >2) && (dgv.CurrentCell.ColumnIndex != 0) && (dgv.CurrentCell.ColumnIndex != 1)) //Control para evitar borrar los factores críticos y el valor de ese factor
            {
                int index = dgv.CurrentCell.ColumnIndex;
                int indexSup = index + 1;
                int indexInf = index - 1;
                if (dgv.CurrentCell.ColumnIndex % 2 == 0 )
                {
                    dgv.Columns.RemoveAt(indexSup);
                    dgv.Columns.RemoveAt(index);
                }
                else
                {
                    
                    dgv.Columns.RemoveAt(index);
                    dgv.Columns.RemoveAt(indexInf);
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna columna para eliminar");
            }
           
        }

        /*
         * Función: void buttGuardar_Click(object sender, EventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para guardar la tabla en un excel, que llama a la función
         *              ImportarExcel cuando se pincha el botón
         * Autor: Javier Salvador Garcia
         */
        private void buttGuardar_Click(object sender, EventArgs e)
        {

            ImportarExcel(dgv);
            
        }

        /*
         * Función: void txtNomEmpresa_KeyPress(object sender, EventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para poder introducir los nombres con la tecla ENTER
         * Autor: Javier Salvador Garcia
         */
        private void txtNomEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                // Control de cadena vacia
                if (txtNomEmpresa.Text != "")
                {
                    agregarColumna(txtNomEmpresa.Text); //Llamada a la función para agregar las columnas de las empresas
                }
                else
                {
                    MessageBox.Show("No ha introducido ningún nombre de empresa");  //Mensaje de aviso
                }
                txtNomEmpresa.Clear();  // Limpiamos el buffer del TextBox donde se escribe el nombre de la empresa
            }
        }

        /*
         * Función: void ImportarExcel (DataGridView tabla)
         * Param: DataGridView tabla
         * Return: none
         * Descripción: Función para abrir un excel y exportar los datos de la tabla al mismo
         * Autor: Javier Salvador Garcia
         */
        public void ImportarExcel (DataGridView tabla)
        {
            try
            {

                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = "ArchivoExportado";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    int IndiceColumna = 0;

                    foreach (DataGridViewColumn col in tabla.Columns) // Columnas
                    {

                        IndiceColumna++;

                        aplicacion.Cells[1, IndiceColumna] = col.Name;

                    }

                    int IndeceFila = 0;

                    foreach (DataGridViewRow row in tabla.Rows) // Filas
                    {

                        IndeceFila++;

                        IndiceColumna = 0;

                        foreach (DataGridViewColumn col in tabla.Columns)
                        {

                            IndiceColumna++;

                            aplicacion.Cells[IndeceFila +1, IndiceColumna] = row.Cells[col.Name].Value;

                        }

                    }
                    libros_trabajo.SaveAs(fichero.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString());
            }
        }

        
    }
}
