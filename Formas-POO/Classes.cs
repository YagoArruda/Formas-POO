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
        
         public double val {get;set;}

        public double setValor(double _val){

            return this.val = _val;
        }

        public double getValor(){

            return this.val;
        }
          public override double CalcularArea(double _val){

            return 8*_val;
          }

        public override double CalcularPerimetro(double _val){
            return 8*_val;
        }
    }

}

