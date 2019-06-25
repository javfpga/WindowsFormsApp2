/*
 * Archivo: MatrizDePosicionamiento.cs
 * Descripión: Ventana para generar ungráfico para la comparación
 *             de dos parámetros entre distintas empresas
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
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp2
{
    public partial class MatrizDePosicionamiento : Form
    {

        List<Empresas> _listaEmpresas = new List<Empresas>();
        public MatrizDePosicionamiento()
        {
            InitializeComponent();
            chart1.ChartAreas[0].AxisX.Maximum = 10;
            chart1.ChartAreas[0].AxisY.Maximum = 10;
            chart1.ChartAreas[0].AxisX.Minimum = -10;
            chart1.ChartAreas[0].AxisY.Minimum = -10;
            chart1.ChartAreas[0].AxisX.Crossing = 0;
            chart1.ChartAreas[0].AxisY.Crossing = 0;
            chart1.ChartAreas[0].AxisY.LabelStyle.Enabled = true;
            chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = true;

        }
        private void MatrizDePosicionamiento_Load(object sender, EventArgs e)
        {

        }

        /*
         * Función: void txtValorY_KeyPress(object sender, KeyPressEventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para que en el text box solo se puedan escribir números y el
         *              signo -
         * Autor: Javier Salvador Garcia
         */
        private void txtValorY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
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
         * Función: void txtValorX_KeyPress(object sender, KeyPressEventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para que en el text box solo se puedan escribir números y el
         *              signo -
         * Autor: Javier Salvador Garcia
         */
        private void txtValorX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
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
         * Función: void butAgregar_Click(object sender, EventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para agregar una nueva entrada a la tabla
         * Autor: Javier Salvador Garcia
         */
        private void butAgregar_Click(object sender, EventArgs e)
        {
            //Creamos un objeto para validar los datos a ingresar
            if ((txtNombre.Text != "") && (txtValorX.Text != "") && (txtValorY.Text != ""))
            {
                Empresas nuevaEmpresa = new Empresas()
                {
                    Nombre = txtNombre.Text,
                    ValorX = Int32.Parse(txtValorX.Text),
                    ValorY = Int32.Parse(txtValorY.Text)
                };


                //Llamada a la función para agregar la nueva linea
                if (!agregarEmpresa(nuevaEmpresa))
                {
                    MessageBox.Show("La empresa: " + nuevaEmpresa.Nombre + " ya esta agregado en la lista");
                }
            }
            else
            {
                MessageBox.Show("Ha dejado algún campo vacio, no se puede completar la operación");
            }
            //Llamamos a la función para dejar limpios los textbox y poder escribir de nuevo
            limpiarTXT();
        }

        /*
        * Función: void limpiarTXT()
        * Param: 
        * Return: none
        * Descripción: Función para limpiar los text box
        * Autor: Javier Salvador Garcia
        */
        void limpiarTXT()
        {
            txtNombre.Clear();
            txtValorX.Clear();
            txtValorY.Clear();
        }

       /*
        * Función: bool agregarEmpresa(Empresas empresa)
        * Param: Empresas empresa
        * Return: none
        * Descripción: Función para agregar una nueva entrada en la lista si no existe previamente
        * Autor: Javier Salvador Garcia
        */
        public bool agregarEmpresa(Empresas empresa)
        {
            bool existe = _listaEmpresas.Any(x => x.Nombre.Equals(empresa.Nombre));
            if (!existe)
            {
                //sino existe lo agregamos
                _listaEmpresas.Add(empresa);
                //limpiamos el datagrid
                dataGridView1.DataSource = null;
                //mostramos los datos
                dataGridView1.DataSource = _listaEmpresas;

                //enviamos que se agrego
                return true;
            }
            //caso contrario enviamos que no se agrego
            return false;
        }

        /*
        * Función: bool eliminarEmpresa(Empresas empresaEliminar)
        * Param: Empresas empresaEliminar
        * Return: none
        * Descripción: Función para eliminar una fila de la tabla
        * Autor: Javier Salvador Garcia
        */
        public bool eliminarEmpresa(Empresas empresaEliminar)
        {
            bool encontrado = _listaEmpresas.Any(x => x.Nombre.Equals(empresaEliminar.Nombre));
            if (encontrado)
            {
                _listaEmpresas.RemoveAll(x => x.Nombre.Equals(empresaEliminar.Nombre));
                //  _listaEmpresas.Remove(empresaEliminar);
                //limpiamos el datagrid
                dataGridView1.DataSource = null;
                //mostramos los datos
                dataGridView1.DataSource = _listaEmpresas;

                //enviamos que se agrego
                return true;
            }
            return false;
        }

        /*
        * Función: agregarSerie(string nomSerie, string valorX, string valorY)
        * Param: string nomSerie, string valorX, string valorY
        * Return: none
        * Descripción: Función para agregar una nueva serie a la gráfica y configurarla
        * Autor: Javier Salvador Garcia
        */
        void agregarSerie(string nomSerie, string valorX, string valorY)
        {

            Series serie = new Series();
            serie.Name = nomSerie;
            serie.ChartType = SeriesChartType.Bubble;
            serie.Points.AddXY(Convert.ToDouble(valorX), Convert.ToDouble(valorY));
            serie.XValueType = ChartValueType.Double;
            serie.YValueType = ChartValueType.Double;
            serie.IsXValueIndexed = false;
            chart1.Series.Add(serie);


        }

        int primera_vez = 0;
        /*
        * Función: butGraficar_Click(object sender, EventArgs e)
        * Param: 
        * Return: none
        * Descripción: Función para pintar los datos de la tabla en la gráfica
        * Autor: Javier Salvador Garcia
        */
        private void butGraficar_Click(object sender, EventArgs e)
        {

            chart1.Series.Clear();
            string nom_serie;
            string valX, valY;

            if (primera_vez == 0)
            {
                if ((nomEjeXTxT.Text != "") && (nomEjeYTxT.Text != ""))
                {
                    chart1.ChartAreas[0].AxisX.Title = nomEjeXTxT.Text;
                    chart1.ChartAreas[0].AxisY.Title = nomEjeYTxT.Text;
                    
                    //Bucle For para recorrer toda la tabla 
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        chart1.DataSource = dataGridView1;
                        chart1.DataBind();
                        nom_serie = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        valX = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        valY = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        agregarSerie(nom_serie, valX, valY);

                    }
                    primera_vez = 1;
                }
                else
                {
                    MessageBox.Show("Debe rellenar los campos de los nombres de los ejes");
                }
                nomEjeXTxT.Clear();
                nomEjeYTxT.Clear();
                //Form2 fm2 = new Form2();
                //fm2.ShowDialog();
            }
            else
            {
                //Bucle For para recorrer toda la tabla 
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    chart1.DataSource = dataGridView1;
                    chart1.DataBind();
                    nom_serie = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    valX = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    valY = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    agregarSerie(nom_serie, valX, valY);

                }
                if ((nomEjeXTxT.Text != "") && (nomEjeYTxT.Text != ""))
                {
                    chart1.ChartAreas[0].AxisX.Title = nomEjeXTxT.Text;
                    chart1.ChartAreas[0].AxisY.Title = nomEjeYTxT.Text;
                }
                nomEjeXTxT.Clear();
                nomEjeYTxT.Clear();
            }
            
        }

        
        /*
        * Función: butGuardar_Click(object sender, EventArgs e)
        * Param: 
        * Return: none
        * Descripción: Función para guardar en gráfico en formato imagen
        * Autor: Javier Salvador Garcia
        */
        private void butGuardar_Click(object sender, EventArgs e)
        {
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Title = "Guardar Imagen En....";
            SaveFileDialog1.DefaultExt = "jpeg";
            SaveFileDialog1.Filter = "JPEG|*.jpeg|BITMAP|*.bmp|PNG|*.png|All Files|*.*";
            SaveFileDialog1.FilterIndex = 1;
            Bitmap bmp = new Bitmap(chart1.Width, chart1.Height);
            chart1.DrawToBitmap(bmp, chart1.DisplayRectangle);

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

        /*
        * Función: butEliminar_Click(object sender, EventArgs e)
        * Param: 
        * Return: none
        * Descripción: Función para llamar a la función eliminarEmpresa cuando se pincha el botón
        * Autor: Javier Salvador Garcia
        */
        private void butEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("No hay nada para eliminar");
            }
            else
            {
                Empresas nuevaEmpresa = new Empresas()
                {
                    Nombre = dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                    ValorX = Int32.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()),
                    ValorY = Int32.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString())
                };
                eliminarEmpresa(nuevaEmpresa);

            }
        }

        private void txtValorX_TextChanged(object sender, EventArgs e)
        {
            
        }
    }        
}
