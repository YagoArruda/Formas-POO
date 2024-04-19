using classes;
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
            Quadrado quad = new Quadrado();
            quad.setValor(double.Parse(ladoQuadrado.Text));
            Area.Text = "Area: " + quad.CalcularArea().ToString();
            Perimetro.Text = "Perimetro: " + quad.CalcularPerimetro().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Octagono octo = new Octagono();
            octo.setLado(double.Parse(ladoOctogono.Text));
            Area.Text = "Area: " + octo.CalcularArea().ToString();
            Perimetro.Text = "Perimetro: " + octo.CalcularPerimetro().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pentagono penta = new Pentagono();
            penta.setLado(double.Parse(ladoPentagono.Text));
            Area.Text = "Area: " + penta.CalcularArea().ToString();
            Perimetro.Text = "Perimetro: " + penta.CalcularPerimetro().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Retangulo retan = new Retangulo();
            retan.setBase(double.Parse(baseRetangulo.Text));
            retan.setAltura(double.Parse(alturaRetangulo.Text));
            Area.Text = "Area: " + retan.CalcularArea().ToString();
            Perimetro.Text = "Perimetro: " + retan.CalcularPerimetro().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Triangulo trian = new Triangulo();
            trian.setBase(double.Parse(baseTriangulo.Text));
            trian.setAltura(double.Parse(alturaTriangulo.Text));
            Area.Text = "Area: " + trian.CalcularArea().ToString();
            Perimetro.Text = "Perimetro: " + trian.CalcularPerimetro().ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Circulo circu = new Circulo();
            circu.setRaio(double.Parse(raioCirculo.Text));
            Area.Text = "Area: " + circu.CalcularArea().ToString();
            Perimetro.Text = "Perimetro: " + circu.CalcularPerimetro().ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hexagono hexag = new Hexagono();
            hexag.setLado(double.Parse(ladoHexagono.Text));
            Area.Text = "Area: " + hexag.CalcularArea().ToString();
            Perimetro.Text = "Perimetro: " + hexag.CalcularPerimetro().ToString();
        }
    }
}
