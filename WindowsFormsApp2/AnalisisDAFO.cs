/*
 * Archivo: AnalsisDafo.cs
 * Descripión: Ventana para generar un Análsis DAFO
 *             para un proyecto
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
    public partial class AnalisisDAFO : Form
    {
        public AnalisisDAFO()
        {
            InitializeComponent();
        }


        /*
         * Función: void butDeb_Click(object sender, EventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para agregar una nueva entrada al 
         *              text box de la zona de la debilidad
         * Autor: Javier Salvador Garcia
         */

        private void butDeb_Click(object sender, EventArgs e)
        {
            if (textBoxDebilidad.Text == "")
            {
                MessageBox.Show("No ha introducido ninguna debilidad");
            }
            else
            {
                listBoxDebilidad.Items.Add(">>" + textBoxDebilidad.Text);
                textBoxDebilidad.Clear();
            }

        }


        /*
         * Función: void butAmenaza_Click(object sender, EventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para agregar una nueva entrada al 
         *              text box de la zona de la amenaza
         * Autor: Javier Salvador Garcia
         */
        private void butAmenaza_Click(object sender, EventArgs e)
        {
            if (textBoxAmenaza.Text == "")
            {
                MessageBox.Show("No ha introducido ninguna amenaza");
            }
            else
            {
                listBoxAmenaza.Items.Add(">>" + textBoxAmenaza.Text);
                textBoxAmenaza.Clear();
            }
        }

        /*
         * Función: void butFortaleza_Click(object sender, EventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para agregar una nueva entrada al 
         *              text box de la zona de la fortaleza
         * Autor: Javier Salvador Garcia
         */
        private void butFortaleza_Click(object sender, EventArgs e)
        {
            if (textBoxFortaleza.Text == "")
            {
                MessageBox.Show("No ha introducido ninguna fortaleza");
            }
            else
            {
                listBoxFortaleza.Items.Add(">>" + textBoxFortaleza.Text);
                textBoxFortaleza.Clear();
            }
        }

        /*
         * Función: void butOportunidad_Click(object sender, EventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para agregar una nueva entrada al 
         *              text box de la zona de la oportunidad
         * Autor: Javier Salvador Garcia
         */
        private void butOportunidad_Click(object sender, EventArgs e)
        {
            if (textBoxOportunidad.Text == "")
            {
                MessageBox.Show("No ha introducido ninguna oportunidad");
            }
            else
            {
                listBoxOportunidad.Items.Add(">>" + textBoxOportunidad.Text);
                textBoxOportunidad.Clear();
            }
        }

        /*
         * Función: void butDebEliminar_Click(object sender, EventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para eliminar una entrada en el 
         *              text box de la debilidad
         * Autor: Javier Salvador Garcia
         */
        private void butDebEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxDebilidad.Items.Count == 0)
            {
                MessageBox.Show("No hay ninguna debilidad para eliminar");
            }
            else if (listBoxDebilidad.SelectedIndex == -1)
            {
                MessageBox.Show("No ha seleccionado que debilidad quiere elimiar");
            }
            else
            {
                listBoxDebilidad.Items.RemoveAt(listBoxDebilidad.SelectedIndex);
            }

        }

        /*
         * Función: void butAmenazaEliminar_Click(object sender, EventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para eliminar una entrada en el 
         *              text box de la amenaza
         * Autor: Javier Salvador Garcia
         */
        private void butAmenazaEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxAmenaza.Items.Count == 0)
            {
                MessageBox.Show("No hay ninguna amenaza para eliminar");
            }
            else if (listBoxAmenaza.SelectedIndex == -1)
            {
                MessageBox.Show("No ha seleccionado que amenaza quiere elimiar");
            }
            else
            {
                listBoxAmenaza.Items.RemoveAt(listBoxAmenaza.SelectedIndex);
            }
        }

        /*
         * Función: void butFortEliminar_Click(object sender, EventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para eliminar una entrada en el 
         *              text box de la fortaleza
         * Autor: Javier Salvador Garcia
         */
        private void butFortEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxFortaleza.Items.Count == 0)
            {
                MessageBox.Show("No hay ninguna fortaleza para eliminar");
            }
            else if (listBoxFortaleza.SelectedIndex == -1)
            {
                MessageBox.Show("No ha seleccionado que fortaleza quiere elimiar");
            }
            else
            {
                listBoxFortaleza.Items.RemoveAt(listBoxFortaleza.SelectedIndex);
            }
        }

        /*
         * Función: void butOporEliminar_Click(object sender, EventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para eliminar una entrada en el 
         *              text box de la oportunidad
         * Autor: Javier Salvador Garcia
         */
        private void butOportEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxOportunidad.Items.Count == 0)
            {
                MessageBox.Show("No hay ninguna oportunidad para eliminar");
            }
            else if (listBoxOportunidad.SelectedIndex == -1)
            {
                MessageBox.Show("No ha seleccionado que oportunidad quiere elimiar");
            }
            else
            {
                listBoxOportunidad.Items.RemoveAt(listBoxOportunidad.SelectedIndex);
            }
        }

        /*
         * Función: void button1_Click(object sender, EventArgs e)
         * Param: 
         * Return: none
         * Descripción: Función para guardar en formato imagen
         *              el contenido de la ventana
         * Autor: Javier Salvador Garcia
         */
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Title = "Guardar Imagen En....";
            SaveFileDialog1.DefaultExt = "jpeg";
            SaveFileDialog1.Filter = "JPEG|*.jpeg|BITMAP|*.bmp|PNG|*.png|All Files|*.*";
            SaveFileDialog1.FilterIndex = 1;
            Bitmap bmp = new Bitmap(tableLayoutPanel1.Width, tableLayoutPanel1.Height);
            tableLayoutPanel1.DrawToBitmap(bmp, tableLayoutPanel1.DisplayRectangle);

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
        * Función: void textBoxDebilidad_KeyPress(object sender, EventArgs e)
        * Param: 
        * Return: none
        * Descripción: Función para poder tener validar el texto escrito
        *              con la telca ENTER en el área de la debilidad
        * Autor: Javier Salvador Garcia
        */
        private void textBoxDebilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (textBoxDebilidad.Text == "")
                {
                    MessageBox.Show("No ha introducido ninguna debilidad");
                }
                else
                {
                    listBoxDebilidad.Items.Add(">>" + textBoxDebilidad.Text);
                    textBoxDebilidad.Clear();
                }
            }
        }

        /*
        * Función: void listBoxAmenaza_KeyPress(object sender, EventArgs e)
        * Param: 
        * Return: none
        * Descripción: Función para poder tener validar el texto escrito
        *              con la telca ENTER en el área de la amenaza
        * Autor: Javier Salvador Garcia
        */
        private void listBoxAmenaza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (textBoxAmenaza.Text == "")
                {
                    MessageBox.Show("No ha introducido ninguna amenaza");
                }
                else
                {
                    listBoxAmenaza.Items.Add(">>" + textBoxAmenaza.Text);
                    textBoxAmenaza.Clear();
                }
            }
        }

        /*
        * Función: void textBoxFortaleza_KeyPress(object sender, EventArgs e)
        * Param: 
        * Return: none
        * Descripción: Función para poder tener validar el texto escrito
        *              con la telca ENTER en el área de la fortaleza
        * Autor: Javier Salvador Garcia
        */
        private void textBoxFortaleza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (textBoxFortaleza.Text == "")
                {
                    MessageBox.Show("No ha introducido ninguna fortaleza");
                }
                else
                {
                    listBoxFortaleza.Items.Add(">>" + textBoxFortaleza.Text);
                    textBoxFortaleza.Clear();
                }
            }
        }

        /*
        * Función: void listBoxOportunidad_KeyPress(object sender, EventArgs e)
        * Param: 
        * Return: none
        * Descripción: Función para poder tener validar el texto escrito
        *              con la telca ENTER en el área de la oportunidad
        * Autor: Javier Salvador Garcia
        */
        private void listBoxOportunidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (textBoxOportunidad.Text == "")
                {
                    MessageBox.Show("No ha introducido ninguna oportunidad");
                }
                else
                {
                    listBoxOportunidad.Items.Add(">>" + textBoxOportunidad.Text);
                    textBoxOportunidad.Clear();
                }
            }
        }
    }
}
