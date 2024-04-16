using System.Configuration;
using System.Reflection;
using classes;

namespace classes
{

    public abstract class Forma
    {
        public virtual void Mostrar(){
            
        }
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();

        
    }

    public abstract class Quadrado : Forma{

        public double val {get;set;}

        public double setValor(double _val){

            return this.val = _val;
        }

        public double getValor(){

            return this.val;
        }
          public override double CalcularArea(){

            return Math.Pow(val, 2);
          }

        public override double CalcularPerimetro(){
            return 4 * val;
        }

         public override void Mostrar(){
        Console.WriteLine(val);
        Console.WriteLine(CalcularArea());
        Console.WriteLine(CalcularPerimetro());
    }

    }

    public abstract class Octagono : Forma{
        
        public double lado {get;set;}
    
         public double setLado(double _lado){

            return this.lado = _lado;
        }

        public double getLado(){

            return this.lado;
        }

        
          public override double CalcularArea(){

            return 2 * (1 + Math.Sqrt(2)) * Math.Pow(lado, 2);
          }

        public override double CalcularPerimetro(){
            return 8*lado;
        }

        public override void Mostrar(){
        Console.WriteLine(lado);
        Console.WriteLine(CalcularArea());
        Console.WriteLine(CalcularPerimetro());
    }
    }
 
    public abstract class Pentagono : Forma{
   public double lado {get;set;}  


    public double setLado(double _lado){

            return this.lado = _lado;
        }

        public double getLado(){

            return this.lado;
        }

    

        public override double CalcularArea(){

            return 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(lado, 2);
          }

        public override double CalcularPerimetro(){
            return 5*lado;
        }

        public override void Mostrar(){
        Console.WriteLine(lado);
        Console.WriteLine(CalcularArea());
        Console.WriteLine(CalcularPerimetro());
    }
   
    }

    public abstract class Retangulo : Forma{
        
            public double base1 {get;set;}
            public double altura {get;set;}

            public double setBase(double _base1){
                return this.base1 = _base1;
            }

            public double getBase1(){
                return this.base1;
            }

            public double setAltura(double _altura){
                return this.altura = _altura;
            }

            public double getAltura(){
                return this.altura;
            }

            public override double CalcularArea(){

            return base1*altura;
          }

        public override double CalcularPerimetro(){
            return base1 + base1 + altura + altura;
        }

        public override void Mostrar(){
        Console.WriteLine(base1);
        Console.WriteLine(altura);
        Console.WriteLine(CalcularArea());
        Console.WriteLine(CalcularPerimetro());
    }
    }}

    public abstract class Triangulo : Forma{

        
   public double base1 {get;set;}
   public double altura {get;set;}

   public double Lado1 { get; set; }
    public double Lado2 { get; set; }
    public double Lado3 { get; set; }

        public double setLado1(double _lado1){
        return this.Lado1 = _lado1;
    }

        public double getLado1(){

        return this.Lado1;

    }

        public double setLado2(double lado){

        return this.Lado2 = lado;

    }

        public double getLado2(){

        return this.Lado2;

    }

        public double setLado3(double lado){

        return this.Lado3 = lado;

    }

        public double getLado3(){

        return this.Lado3;

    }

        public double setBase(double _base){

            return this.base1 = _base;
        }

        public double getBase(){

            return this.base1;
        }

        public double setAltura(double _altura){

            return this.altura = _altura;
        }

        public double getAltura(){

            return this.altura;
        }

        public override double CalcularArea(){

            return 0.5 * base1 * altura;
          }

        public override double CalcularPerimetro(){
            return Lado1 + Lado2 + Lado3;
        }

        public override void Mostrar(){
        Console.WriteLine(base1);
        Console.WriteLine(altura);
        Console.WriteLine(CalcularArea());
        Console.WriteLine(CalcularPerimetro());
    }

    }

    public abstract class Circulo : Forma{

        public double raio {get;set;}

        public double setRaio(double _raio){

            return this.raio = _raio;
        }

        public double getRaio(){

            return this.raio;
        }

        public override double CalcularArea(){

            return  Math.PI * Math.Pow(raio, 2);
          }

        public override double CalcularPerimetro(){
            return 2 * Math.PI * raio;
        }

        public override void Mostrar(){
        Console.WriteLine(raio);
        Console.WriteLine(CalcularArea());
        Console.WriteLine(CalcularPerimetro());
    }
       

    }

    public abstract class Hexagono : Forma{

public double lado {get;set;}  


    public double setLado(double _lado){

            return this.lado = _lado;
        }

        public double getLado(){

            return this.lado;
        }

      public override double CalcularArea(){

            return  3 * Math.Sqrt(3) / 2 * Math.Pow(lado, 2);
          }

          public override double CalcularPerimetro(){
            return 6*lado;
        }

        public override void Mostrar(){
        Console.WriteLine(lado);
        Console.WriteLine(CalcularArea());
        Console.WriteLine(CalcularPerimetro());
    }

    }
