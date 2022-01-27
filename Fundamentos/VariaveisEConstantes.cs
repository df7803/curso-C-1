using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        internal static void Executar()
        {
            // area da circuferencia
            double raio = 4.5;
            const double PI = 3.14;
            double area = PI * raio * raio;
            //raio = 5.5;
            Console.WriteLine(area);
            Console.WriteLine("Area e " + area);
        }
    }
}
