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
        int d1, d2;
        foreach (rainha tr in listRainhas)
        {
            d1 = Math.Abs(tr.X - x);
            d2 = Math.Abs(tr.Y - y);

            if (d1 == 0 || d2 == 0 || d1 == d2)
                return true;
        }
        return false;
    }

    public bool procuraPos(int range)
    {
        int linha = 0;

        if(listRainhas.Count != 0)
            linha = getLastRainha().X + 1;

        for(int coluna = 0; coluna < range; coluna++)
            if(!testColisao(linha, coluna))
            {
                addRainha(new rainha(linha, coluna));
                return true;
            }

        return false;
    }

    public bool moveUltimo(int range)
    {
        rainha r = getLastRainha();
        remRainha();
        for(int coluna = r.Y + 1; coluna < range; coluna++)
            if(!testColisao(r.X, coluna))
            {
                r.Y = coluna;
                addRainha(r);
                return true;
            }

        return false;
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
