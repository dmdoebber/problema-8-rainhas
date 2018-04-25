using System;
using System.Collections.Generic;
using System.Threading;



public class Busca
{
    Tabuleiro t;

    public Busca()
	{
        t = new Tabuleiro(8);
	}

    public void run()
    {
        int i = 0;
        foreach(rainha r in t.getLR)
        {
            t.testColisao(r, i++);
        }
    }
}
