using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace problema_8_rainhas
{
    class Program
    {
        static void Main(string[] args)
        {
            testaColisao();
            Console.ReadKey();
        }

        private static int[] vet = new int[8];

        private static bool testaColisao()
        {
            for (int i = 0; i < 8; i++)
                vet[i] = 0;
            for(int i  = 0; i < 8; i++)
            {
                Console.Write(vet[i]);
            }

            return false;
        }
    }
}
