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
        rainha r;
        int linha = 0;
        bool passouLimite = false;
        while(t.getLR.Count < tam)
        {
            if (passouLimite)
            {
                t.remRainha();
                linha--;
                passouLimite = t.alteraUltimo(tam);
            }
            r = t.procuraProx(linha, tam);
            if (r != null)
            {
                t.addRainha(r);
                linha++;
            }
            else
            {
                if (t.alteraUltimo(tam))
                    passouLimite = true;
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
