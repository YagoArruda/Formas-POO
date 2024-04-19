using System.Configuration;
using System.Reflection;
using classes;
using Formas_POO;
using System.IO;

//18/04/2024: Conferir as formulas usadas nas areas

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
        public double lado;

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
            
        }

    }

    public class Octagono : Forma
    {

        public double lado;

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
            Console.WriteLine(lado);
            Console.WriteLine(CalcularArea());
            Console.WriteLine(CalcularPerimetro());
        }
    }

    public class Pentagono : Forma
    {
        public double lado;

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
            Console.WriteLine(lado);
            Console.WriteLine(CalcularArea());
            Console.WriteLine(CalcularPerimetro());
        }

    }

    public class Retangulo : Forma
    {
        public double base1;
        public double altura;

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
            Console.WriteLine(base1);
            Console.WriteLine(altura);
            Console.WriteLine(CalcularArea());
            Console.WriteLine(CalcularPerimetro());
        }
    }

    public class Triangulo : Forma
    {

        public double baset;
        public double altura;

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
            Console.WriteLine(baset);
            Console.WriteLine(altura);
            Console.WriteLine(CalcularArea());
            Console.WriteLine(CalcularPerimetro());
        }

    }

    public class Circulo : Forma
    {

        public double raio;

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
            return Math.PI * Math.Pow(raio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * raio;
        }

        public override void Mostrar()
        {
            Console.WriteLine(raio);
            Console.WriteLine(CalcularArea());
            Console.WriteLine(CalcularPerimetro());
        }


    }

    public class Hexagono : Forma
    {

        public double lado;


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
            Console.WriteLine(lado);
            Console.WriteLine(CalcularArea());
            Console.WriteLine(CalcularPerimetro());
        }

    }

}