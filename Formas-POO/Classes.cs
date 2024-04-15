using System.Configuration;
using System.Reflection;

namespace classes
{

    public abstract class Forma
    {
        public virtual void Mostrar(){
            
        }
        public abstract double CalcularArea(double valor);
        public abstract double CalcularPerimetro(double valor);

        public abstract double CalcularArea1(double valor, double valor1);
        public abstract double CalcularPerimetro1(double valor, double valor1);
    }

    public abstract class Quadrado : Forma{

        public double val {get;set;}

        public double setValor(double _val){

            return this.val = _val;
        }

        public double getValor(){

            return this.val;
        }
          public override double CalcularArea(double _val){

            return 4*_val;
          }

        public override double CalcularPerimetro(double _val){
            return 4*_val;
        }
    }

    public abstract class Octagono : Forma{
        
        public double lado {get;set;}
        public double apotema {get;set;}
         public double val {get;set;}

        public double setValor(double _val){

            return this.val = _val;
        }

        public double getValor(){

            return this.val;
        }

         public double setLado(double _lado){

            return this.lado = _lado;
        }

        public double getLado(){

            return this.lado;
        }

         public double setApotema(double _apotema){

            return this.apotema = _apotema;
        }

        public double getApotema(){

            return this.apotema;
        }
          public override double CalcularArea1(double lado, double apotema){

            return 4*lado*apotema;
          }

        public override double CalcularPerimetro(double _val){
            return 8*_val;
        }
    }
 
    public abstract class Pentagono : Forma{
   public double val {get;set;}  
   public double perimetro {get;set;}
   public double apotema {get;set;}

    public double setValor(double _val){

            return this.val = _val;
        }

        public double getValor(){

            return this.val;
        }

    public double setPerimetro(double _perimetro){

            return this.perimetro = _perimetro;
        }

        public double getPerimetro(){

            return this.perimetro;
        }

         public double setApotema(double _apotema){

            return this.apotema = _apotema;
        }

        public double getApotema(){

            return this.apotema;
        }

        public override double CalcularArea1(double perimetro,double apotema){

            return perimetro*apotema/2;
          }

        public override double CalcularPerimetro(double _val){
            return 5*_val;
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

            public override double CalcularArea1(double base1,double altura){

            return base1*altura;
          }

        public override double CalcularPerimetro1(double base1,double altura){
            return base1 + base1 + altura + altura;
        }
    }}


