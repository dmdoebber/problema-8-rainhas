using System;
using System.Collections.Generic;

public class rainha
{
    private int x, y;

    public rainha(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    
    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }
}


public class Tabuleiro
{

    List<rainha> listRainhas;
    public Tabuleiro()
	{
        listRainhas = new List<rainha>();
        
        /*
        listRainhas.Add(new rainha(0, 3));
        listRainhas.Add(new rainha(1, 6));
        listRainhas.Add(new rainha(2, 2));
        listRainhas.Add(new rainha(3, 7));
        listRainhas.Add(new rainha(4, 1));
        listRainhas.Add(new rainha(5, 4));
        listRainhas.Add(new rainha(6, 0));
        listRainhas.Add(new rainha(7, 5));
        */
    }

    public List<rainha> getLR
    {
        get { return listRainhas; }
    }

    public void addRainha(rainha r)
    {
        listRainhas.Add(r);
    }

    public void remRainha()
    {
        listRainhas.RemoveAt(listRainhas.Count - 1);
    }

    public rainha getLastRainha()
    {
        return listRainhas[listRainhas.Count - 1];
    }


    public bool testColisao(int x, int y)
    {
        int d1, d2, id = 0;
        foreach (rainha tr in listRainhas)
        {
            d1 = Math.Abs(tr.X - x);
            d2 = Math.Abs(tr.Y - y);

            if (d1 == 0 || d2 == 0 || d1 == d2)
                return true;
        }
        return false;
    }

    public rainha procuraPosicaoDisponivel(int linha, int range)
    {
        for(int coluna = 0; coluna < range; coluna++)
        {
            if(!testColisao(linha, coluna))
            {
                return new rainha(linha, coluna);
            }
        }
        return null;
    }

    public rainha procuraProx(int linha, int  col, int avanca, int range)
    {
        for(int coluna = col+avanca; coluna < range; coluna++)
        {
            if (!testColisao(linha, coluna) && col+avanca != range)
            {
                return new rainha(linha, coluna);
            }
        }
        return null;
    }

    public void imprimeTabuleiro(int tam)
    {
        bool encontrou = false;
        for(int i = 0; i < tam; i++)
        {
            Console.Write("\n");
            for(int j = 0; j < tam; j++)
            {
                foreach(rainha r in listRainhas)
                {
                    if(r.X == i && r.Y == j)
                    {
                        Console.Write("X\t");
                        encontrou = true;
                    }
                }
                if (!encontrou)
                    Console.Write("-\t");
                else
                    encontrou = false;
            }
        }
    }
}
