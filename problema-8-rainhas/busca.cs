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
        int linha = 0;
        rainha r;
        while(t.getLR.Count < tam)
        {

        }

        for (int i = 0; i < 7; i++, linha++) { 
            r = t.procuraPosicaoDisponivel(linha, tam);
            if (r != null)
                t.addRainha(r);
        }

        t.imprimeTabuleiro(tam);
    }
}
