using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificadorExpresiones.Models
{
    internal class PatentesViejasCharValidador : Validador
    {
        public PatentesViejasCharValidador(string expresion) : base(expresion)
        {

        }

        public override string VerMensaje()
        {
            if (Validar())
            {
                return "patente correcta";
            }

            return "patente incorrecta";
        }

        public override bool Validar()
        {
            string patente = Expresion;

            string[] partesPatente = patente.Split(' ');

            if (partesPatente.Length != 2)
            {
                return false;
            }
            else if (partesPatente[0].Length != 3 || partesPatente[1].Length != 3)
            {
                return false;
            }
            else {

                foreach (char p in partesPatente[0])
                {
                    if (!char.IsLetter(p))
                    {
                        return false;
                    }
                }

                foreach (char p in partesPatente[1])
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
