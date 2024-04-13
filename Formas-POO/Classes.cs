using System.Configuration;
using System.Reflection;

namespace classes
{

    public abstract class Forma
    {
        public virtual void Mostrar(){
            
        }
        protected abstract void CalcularArea();
        protected abstract void CalcularPerimetro();
    }

}

