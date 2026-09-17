using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificadorExpresiones.Models
{
    internal class TelefonoCharValidador : Validador
    {

        public TelefonoCharValidador(string expresion) : base(expresion) { }

        public override string VerMensaje()
        {
            if (Validar())
            {
                return  "numero correcto"; 
            }

            return "numero incorrecto";
        }
        public override bool Validar()
        {

            string exp = Expresion;

            string[] partes = exp.Split('-');

            if (partes.Length != 2)
            {
                return false;
            }
            else if (partes[0].Length != 3 && partes[0].Length != 4)
            {
                return false;

            }
            else if(partes[1].Length != 7)
            {
                return false;
            }
            else
            {
                foreach (char p in partes[0])
                {
                    if (!char.IsDigit(p))
                    {
                        return false;
                    }
                }

                foreach (char p in partes[1])
                {
                    if (!char.IsDigit(p))
                    {
                        return false;
                    }
                }
            }

            return true;

        }
    }
}
