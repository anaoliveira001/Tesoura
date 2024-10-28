using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesoura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tesoura tesoura = new Tesoura("Rosa");

            tesoura.Cortar("plastico");
            tesoura.Cortar("metal");
            tesoura.Cortar("ferro");

            
            Console.ReadKey();
        }
    }
}
