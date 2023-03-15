using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACTIVIDAD_5_PUNTO_3_C_SHARP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
  
        private void btnIdentificar_Click_1(object sender, EventArgs e)
        {
            // Arreglo unidimensional
            int[] numeros1D = { 2, 4, 6, 8, 10 };

            MessageBox.Show("Arreglo unidimensional\n\n" +
                            $"Cantidad de elementos: {numeros1D.Length}\n" +
                            $"Elemento más grande: {numeros1D.Max()}\n" +
                            $"Elemento más pequeño: {numeros1D.Min()}");

            // Arreglo bidimensional
            int[,] numeros2D = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            MessageBox.Show("Arreglo bidimensional\n\n" +
                            $"Cantidad de filas: {numeros2D.GetLength(0)}\n" +
                            $"Cantidad de columnas: {numeros2D.GetLength(1)}\n" +
                            $"Elemento en la fila 2, columna 1: {numeros2D[1, 0]}\n" +
                            $"Elemento en la fila 3, columna 2: {numeros2D[2, 1]}");

            // Arreglo tridimensional
            int[,,] numeros3D = { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

            MessageBox.Show("Arreglo tridimensional\n\n" +
                            $"Cantidad de páginas: {numeros3D.GetLength(0)}\n" +
                            $"Cantidad de filas: {numeros3D.GetLength(1)}\n" +
                            $"Cantidad de columnas: {numeros3D.GetLength(2)}\n" +
                            $"Elemento en la página 1, fila 1, columna 3: {numeros3D[0, 0, 2]}\n" +
                            $"Elemento en la página 2, fila 2, columna 2: {numeros3D[1, 1, 1]}");
        }
    }
}


