using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_classificação_de_triangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           double lado double lado1, lado2, lado3;
            if (!double.TryParse(txtLado1.Text, out lado1) ||
                !double.TryParse(txtLado2.Text, out lado2) ||
                !double.TryParse(txtLado3.Text, out lado3))
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos para os lados do triângulo.");
                return;
            }

            // Verifica se os lados formam um triângulo
            if (VerificarTriangulo(lado1, lado2, lado3))
            {
                // Classifica o triângulo
                string classificacao = ClassificarTriangulo(lado1, lado2, lado3);
                MessageBox.Show($"O triângulo é {classificacao}.");
            }
            else
            {
                MessageBox.Show("Os lados fornecidos não formam um triângulo válido.");
            }
        }

        // verifica se os lados vão formar um triângulo
        private bool VerificarTriangulo(double lado1, 2, double lado3)
        {
            // a soma de dois lados deve ser maior q o terceiro
            return (lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1);
        }

        // Aqui vai classificar o triângulo 
        private string ClassificarTriangulo(double lado1, double lado2, double lado3)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                return "equilátero";
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                return "isósceles";
            }
            else
            {
                return "escaleno";
            }
        }
    }
}
