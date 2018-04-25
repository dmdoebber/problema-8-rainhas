using System;
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
        foreach(rainha r in t.getLR)
        {
            t.testColisao(t.getLR, r);
        }
    }
}
