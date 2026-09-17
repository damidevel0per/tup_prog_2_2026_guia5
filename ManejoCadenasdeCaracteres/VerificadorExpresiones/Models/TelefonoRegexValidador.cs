using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VerificadorExpresiones.Models
{
    internal class TelefonoRegexValidador : TelefonoCharValidador
    {
        public TelefonoRegexValidador(string expresion) : base(expresion)
        {

        }

        public override bool Validar()
        {
            string exp = Expresion;

            Regex regex = new Regex(@"^\d{3,4}-\d{7}$");

            if(regex.Match(exp).Success)
            {
                return true;
            }
            else { return false; } 

        }
    }
}
