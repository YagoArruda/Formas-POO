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

        private void button1_Click(object sender, EventArgs e)
        {
            Quadrado quad = new Quadrado(double.Parse(ladoQuadrado.Text), imagemForma, Area, Perimetro);
            quad.Mostrar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Octagono octo = new Octagono(double.Parse(ladoOctogono.Text), imagemForma, Area, Perimetro);
            octo.Mostrar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pentagono penta = new Pentagono(double.Parse(ladoPentagono.Text), imagemForma, Area, Perimetro);
            penta.Mostrar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Retangulo retan = new Retangulo(double.Parse(baseRetangulo.Text), double.Parse(alturaRetangulo.Text), imagemForma, Area, Perimetro);
            retan.Mostrar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Triangulo trian = new Triangulo(double.Parse(baseTriangulo.Text), double.Parse(alturaTriangulo.Text), imagemForma, Area, Perimetro);
            trian.Mostrar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Circulo circu = new Circulo(double.Parse(raioCirculo.Text), imagemForma, Area, Perimetro);
            circu.Mostrar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hexagono hexag = new Hexagono(double.Parse(ladoHexagono.Text), imagemForma, Area, Perimetro);
            hexag.Mostrar();
        }

    }
}
