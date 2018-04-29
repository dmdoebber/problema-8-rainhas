using System;
using System.Collections.Generic;



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
        bool inseriu = true;
        bool moveuUltimo = true;
        
        while(t.getLR.Count < tam)
        {
            if (!moveuUltimo)
                moveuUltimo = t.moveUltimo(tam);
            if(moveuUltimo)
                inseriu = t.procuraPos(tam);
            if (!inseriu)
                moveuUltimo = t.moveUltimo(tam);
        }

        t.imprimeTabuleiro(tam);

        foreach (rainha ra in t.getLR)
        {
            Console.Write("\nx = " + ra.X + "y =" + ra.Y);
        }
    }
}
