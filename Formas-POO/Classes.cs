using System.Configuration;
using System.Reflection;
using classes;
using Formas_POO;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace classes
{

    public abstract class Forma
    {

        public virtual void Mostrar()
        {

        }

        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();

    }

    public class Quadrado : Forma 
    {
        private double lado = 0;
        PictureBox localImagem;
        Label area;
        Label perimetro;

        public Quadrado(double _lado, PictureBox _localImagem, Label _area, Label _perimetro)
        {
            setValor(_lado);
            setLocalImagem(_localImagem);
            setLabelArea(_area);
            setLabelPerimetro(_perimetro);
        }

        public void setLocalImagem(PictureBox _localImagem)
        {
            this.localImagem = _localImagem;
        }

        public void setLabelArea(Label _area)
        {
            this.area = _area;
        }

        public void setLabelPerimetro(Label _perimetro)
        {
            this.perimetro = _perimetro;
        }

        public void setValor(double _lado)
        {
            this.lado = _lado;
        }

        public double getValor()
        {
            return this.lado;
        }
        public override double CalcularArea()
        {
            return Math.Pow(lado, 2);
        }

        public override double CalcularPerimetro()
        {
            return 4 * lado;
        }

        public override void Mostrar()
        {
            this.localImagem.Image = Image.FromFile("Imagens/quadrado.png");
            this.area.Text = "Area: " + CalcularArea().ToString();
            this.perimetro.Text = "Perimetro: " + CalcularPerimetro().ToString();
        }

    }

    public class Octagono : Forma
    {

        private double lado = 0;
        PictureBox localImagem;
        Label area;
        Label perimetro;

        public Octagono(double _lado, PictureBox _localImagem, Label _area, Label _perimetro)
        {
            setLado(_lado);
            setLocalImagem(_localImagem);
            setLabelArea(_area);
            setLabelPerimetro(_perimetro);
        }

        public void setLocalImagem(PictureBox _localImagem)
        {
            this.localImagem = _localImagem;
        }

        public void setLabelArea(Label _area)
        {
            this.area = _area;
        }

        public void setLabelPerimetro(Label _perimetro)
        {
            this.perimetro = _perimetro;
        }


        public void setLado(double _lado)
        {
            this.lado = _lado;
        }

        public double getLado()
        {
            return this.lado;
        }

        public override double CalcularArea()//verificar formula
        {
            return 2 * (1 + Math.Sqrt(2)) * Math.Pow(lado, 2);
        }

        public override double CalcularPerimetro()
        {
            return 8 * lado;
        }

        public override void Mostrar()
        {
            this.localImagem.Image = Image.FromFile("Imagens/octagono.png");
            this.area.Text = "Area: " + CalcularArea().ToString();
            this.perimetro.Text = "Perimetro: " + CalcularPerimetro().ToString();
        }
    }

    public class Pentagono : Forma
    {
        private double lado = 0;
        PictureBox localImagem;
        Label area;
        Label perimetro;

        public Pentagono(double _lado, PictureBox _localImagem, Label _area, Label _perimetro)
        {
            setLado(_lado);
            setLocalImagem(_localImagem);
            setLabelArea(_area);
            setLabelPerimetro(_perimetro);
        }

        public void setLocalImagem(PictureBox _localImagem)
        {
            this.localImagem = _localImagem;
        }

        public void setLabelArea(Label _area)
        {
            this.area = _area;
        }

        public void setLabelPerimetro(Label _perimetro)
        {
            this.perimetro = _perimetro;
        }


        public void setLado(double _lado)
        {
            this.lado = _lado;
        }

        public double getLado()
        {
            return this.lado;
        }

        public override double CalcularArea()
        {

            return 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(lado, 2);
        }

        public override double CalcularPerimetro()
        {
            return 5 * lado;
        }

        public override void Mostrar()
        {
            this.localImagem.Image = Image.FromFile("Imagens/pentagono.png");
            this.area.Text = "Area: " + CalcularArea().ToString();
            this.perimetro.Text = "Perimetro: " + CalcularPerimetro().ToString();
        }

    }

    public class Retangulo : Forma
    {
        private double base1 = 0;
        private double altura = 0;
        PictureBox localImagem;
        Label area;
        Label perimetro;

        public Retangulo(double _base, double _altura, PictureBox _localImagem, Label _area, Label _perimetro)
        {
            setBase(_base);
            setAltura(_altura);
            setLocalImagem(_localImagem);
            setLabelArea(_area);
            setLabelPerimetro(_perimetro);
        }

        public void setLocalImagem(PictureBox _localImagem)
        {
            this.localImagem = _localImagem;
        }

        public void setLabelArea(Label _area)
        {
            this.area = _area;
        }

        public void setLabelPerimetro(Label _perimetro)
        {
            this.perimetro = _perimetro;
        }


        public void setBase(double _base1)
        {
            this.base1 = _base1;
        }

        public double getBase1()
        {
            return this.base1;
        }

        public void setAltura(double _altura)
        {
            this.altura = _altura;
        }

        public double getAltura()
        {
            return this.altura;
        }

        public override double CalcularArea()
        {

            return base1 * altura;
        }

        public override double CalcularPerimetro()
        {
            return base1 + base1 + altura + altura;
        }

        public override void Mostrar()
        {
            this.localImagem.Image = Image.FromFile("Imagens/retangulo.png");
            this.area.Text = "Area: " + CalcularArea().ToString();
            this.perimetro.Text = "Perimetro: " + CalcularPerimetro().ToString();
        }
    }

    public class Triangulo : Forma
    {

        private double baset = 0;
        private double altura = 0;
        PictureBox localImagem;
        Label area;
        Label perimetro;

        public Triangulo(double _baset, double _altura, PictureBox _localImagem, Label _area, Label _perimetro)
        {
            setBase(_baset);
            setAltura(_altura);
            setLocalImagem(_localImagem);
            setLabelArea(_area);
            setLabelPerimetro(_perimetro);
        }

        public void setLocalImagem(PictureBox _localImagem)
        {
            this.localImagem = _localImagem;
        }

        public void setLabelArea(Label _area)
        {
            this.area = _area;
        }

        public void setLabelPerimetro(Label _perimetro)
        {
            this.perimetro = _perimetro;
        }

        public void setBase(double _base)
        {

            this.baset = _base;
        }

        public double getBase()
        {

            return this.baset;
        }

        public void setAltura(double _altura)
        {

            this.altura = _altura;
        }

        public double getAltura()
        {

            return this.altura;
        }

        public override double CalcularArea()
        {

            return 0.5 * baset * altura;
        }

        public override double CalcularPerimetro()
        {
            return baset * 3;
        }

        public override void Mostrar()
        {
            this.localImagem.Image = Image.FromFile("Imagens/triangulo.jpg");
            this.area.Text = "Area: " + CalcularArea().ToString();
            this.perimetro.Text = "Perimetro: " + CalcularPerimetro().ToString();
        }

    }

    public class Circulo : Forma
    {

        private double raio = 0;
        PictureBox localImagem;
        Label area;
        Label perimetro;

        public Circulo(double _raio, PictureBox _localImagem, Label _area, Label _perimetro)
        {
            setRaio(_raio);
            setLocalImagem(_localImagem);
            setLabelArea(_area);
            setLabelPerimetro(_perimetro);
        }

        public void setLocalImagem(PictureBox _localImagem)
        {
            this.localImagem = _localImagem;
        }

        public void setLabelArea(Label _area)
        {
            this.area = _area;
        }

        public void setLabelPerimetro(Label _perimetro)
        {
            this.perimetro = _perimetro;
        }

        public void setRaio(double _raio)
        {
            this.raio = _raio;
        }

        public double getRaio()
        {
            return this.raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * raio * raio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * raio;
        }

        public override void Mostrar()
        {
            this.localImagem.Image = Image.FromFile("Imagens/circulo.png");
            this.area.Text = "Area: " + CalcularArea().ToString();
            this.perimetro.Text = "Perimetro: " + CalcularPerimetro().ToString();
        }

    }

    public class Hexagono : Forma
    {

        private double lado = 0;
        PictureBox localImagem;
        Label area;
        Label perimetro;

        public Hexagono(double _lado, PictureBox _localImagem, Label _area, Label _perimetro)
        {
            setLado(_lado);
            setLocalImagem(_localImagem);
            setLabelArea(_area);
            setLabelPerimetro(_perimetro);
        }

        public void setLocalImagem(PictureBox _localImagem)
        {
            this.localImagem = _localImagem;
        }

        public void setLabelArea(Label _area)
        {
            this.area = _area;
        }

        public void setLabelPerimetro(Label _perimetro)
        {
            this.perimetro = _perimetro;
        }


        public void setLado(double _lado)
        {
            this.lado = _lado;
        }

        public double getLado()
        {
            return this.lado;
        }

        public override double CalcularArea()
        {
            return 3 * Math.Sqrt(3) / 2 * Math.Pow(lado, 2);
        }

        public override double CalcularPerimetro()
        {
            return 6 * lado;
        }

        public override void Mostrar()
        {
            this.localImagem.Image = Image.FromFile("Imagens/hexagono.png");
            this.area.Text = "Area: " + CalcularArea().ToString();
            this.perimetro.Text = "Perimetro: " + CalcularPerimetro().ToString();
        }

    }

}