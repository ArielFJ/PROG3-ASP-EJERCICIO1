using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio1.HelperFunctions
{
    public class Helpers
    {
        public static int InvertirNumero(int n)
        {
            // Invierte el orden de los dígitos
            string nuevoN = "";
            if (n > 10)
            {
                nuevoN += n.ToString()[1];
                nuevoN += n.ToString()[0];
            }
            else
                nuevoN += n.ToString()[0] + "0";

            return Convert.ToInt32(nuevoN);
        }
    }
}
