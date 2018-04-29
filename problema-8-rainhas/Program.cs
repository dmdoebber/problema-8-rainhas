using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace problema_8_rainhas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho do tabuleiro: ");
            int tam = Convert.ToInt32(Console.ReadLine());
            Busca b = new Busca(tam);

            /* (metodo utilizado em thread apenas por estética)*/
            Thread t = new Thread(b.run);
            t.Start();

            Console.ReadKey();
        }
    }
}
