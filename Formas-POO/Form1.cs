using classes;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Formas_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool validarvalorquadrado()
        {
             if (ladoQuadrado.Text == "")
                {
                    MessageBox.Show("Coloque um valor válido!");
                
                  return false;
                }

             return true;

        }

        private bool validarvaloroctogono()
        {
            if (ladoOctogono.Text == "")
            {
                MessageBox.Show("Coloque um valor válido!");

                return false;
            }

            return true;

        }

        private bool validarvalorpentagono()
        {
            if (ladoPentagono.Text == "")
            {
                MessageBox.Show("Coloque um valor válido!");

                return false;
            }

            return true;

        }

        private bool validarvalorretangulo()
        {
            if (baseRetangulo.Text == "" || alturaRetangulo.Text =="")
            {
                MessageBox.Show("Coloque um valor válido!");

                return false;
            }

            return true;

        }

        private bool validarvalortriangulo()
        {
            if (baseTriangulo.Text == "" || alturaTriangulo.Text == "")
            {
                MessageBox.Show("Coloque um valor válido!");

                return false;
            }

            return true;

        }

        private bool validarvalorcirculo()
        {
            if (raioCirculo.Text == "")
            {
                MessageBox.Show("Coloque um valor válido!");

                return false;
            }

            return true;

        }

        private bool validarvalorhexagono()
        {
            if (ladoHexagono.Text == "")
            {
                MessageBox.Show("Coloque um valor válido!");

                return false;
            }

            return true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (validarvalorquadrado()) { 
                Quadrado quad = new Quadrado(double.Parse(ladoQuadrado.Text), imagemForma, Area, Perimetro);

            
                quad.Mostrar();
            }
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (validarvaloroctogono())
            {
                Octagono octo = new Octagono(double.Parse(ladoOctogono.Text), imagemForma, Area, Perimetro);
                octo.Mostrar();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (validarvalorpentagono())
            {
                Pentagono penta = new Pentagono(double.Parse(ladoPentagono.Text), imagemForma, Area, Perimetro);
                penta.Mostrar();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (validarvalorretangulo())
            {
                Retangulo retan = new Retangulo(double.Parse(baseRetangulo.Text), double.Parse(alturaRetangulo.Text), imagemForma, Area, Perimetro);
                retan.Mostrar();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (validarvalortriangulo())
            {
                Triangulo trian = new Triangulo(double.Parse(baseTriangulo.Text), double.Parse(alturaTriangulo.Text), imagemForma, Area, Perimetro);
                trian.Mostrar();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (validarvalorcirculo())
            {
                Circulo circu = new Circulo(double.Parse(raioCirculo.Text), imagemForma, Area, Perimetro);
                circu.Mostrar();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (validarvalorhexagono())
            {
                Hexagono hexag = new Hexagono(double.Parse(ladoHexagono.Text), imagemForma, Area, Perimetro);
                hexag.Mostrar();
            }
        }

    }
}
