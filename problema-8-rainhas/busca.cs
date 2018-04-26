using System;
using System.Collections.Generic;
using System.Threading;



public class Busca
{
    private Tabuleiro t;
    private int tam;

    public Busca(int tam)
	{
        this.tam = tam;
        t = new Tabuleiro();
	}

    public void run()
    {
        int linha = 0, avanca = 0, coluna = 0;
        rainha r;
        while(t.getLR.Count < tam)
        {
            r = t.procuraProx(linha, coluna, avanca, tam);
            if (r != null)
            {
                t.addRainha(r);
                linha++;
            }
            else
            {
                r = t.getLastRainha();
                t.remRainha();
                linha--;
                avanca = 1;
                r = t.procuraProx(linha, r.Y, avanca, tam);
                if(r != null)
                {
                    t.addRainha(r);
                    linha++;
                    avanca = 0;
                }
                else
                {
                    t.remRainha();
                    linha--;
                    avanca = 1;
                }
                
            }
            Console.Clear();
            t.imprimeTabuleiro(tam);
        }
        foreach (rainha ra in t.getLR)
        {
            Console.Write("\nx = " + ra.X + "y =" + ra.Y);
        }
    }
}
