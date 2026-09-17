using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificadorExpresiones.Models
{
    abstract class Validador
    {
        private string expresion;

        public string Expresion { get { return expresion; } }

        public Validador(string expresion)
        {
            this.expresion = expresion;
        }

        public virtual string VerMensaje()
        {
            return this.expresion;
        }

        public abstract bool Validar();

    }
}
