using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class tipo
    {
        List<string> diferentesveh = new List<string>() { "Automovil", "Motocicleta", "Dron" };

        public Boolean BuscarTipo(string valor)
        {


            Boolean result = diferentesveh.Contains(valor);


            return result;


        }

        public void listasve()
        {

            foreach (var i in diferentesveh)
            {
                Console.WriteLine(i);
            }


        }
    }
}
