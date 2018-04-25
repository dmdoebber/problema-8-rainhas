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
            Busca b = new Busca();
            Thread t = new Thread(b.run);
            t.Start();

            Console.ReadKey();
        }
    }
}
