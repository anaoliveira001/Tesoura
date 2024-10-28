using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesoura
{
    internal class Tesoura
    {
        string cor;
        int totalUso;

        // método não usa-se void
        public Tesoura(string cor)
        {
            this.cor = cor;
            this.totalUso = 100;

        }
        public void Cortar(string material)
        {
            material = material.ToLower();

            if (this.totalUso <= 0)
            {
                Console.WriteLine("A tesoura quebrou");
                return;
            }

            if (material == "papel")
                this.totalUso--;
            else if (material == "metal")
                this.totalUso -= 20;
            else if (material == "plastico")
                this.totalUso -= 70;
            else
                Console.WriteLine("Não pode cortar este Material com esta tesoura, use outro tipo");

            this.UsosRestantes();
        }

        public void UsosRestantes()
        {
            Console.WriteLine($"A tesoura tem o total de: {this.totalUso} usos");
        }
    }
}
