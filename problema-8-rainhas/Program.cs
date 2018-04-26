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
            int tam = Convert.ToInt32(Console.ReadLine());
            Busca b = new Busca(tam);
            
            Thread t = new Thread(b.run);
            t.Start();

            Console.ReadKey();
        }
    }
}
