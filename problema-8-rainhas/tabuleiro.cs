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
    public Tabuleiro(int tam)
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
        listRainhas.Add(new rainha(0, 0));
        listRainhas.Add(new rainha(5, 5));

    }

    public List<rainha> getLR
    {
        get { return listRainhas; }
    }


    public bool testColisao(rainha r, int indice)
    {
        int d1, d2, id = 0;
        foreach (rainha tr in listRainhas)
        {
            d1 = Math.Abs(tr.X - r.X);
            d2 = Math.Abs(tr.Y - r.Y);

            if (indice != id++)
                if (d1 == 0 || d2 == 0 || d1 == d2)
                    return true;
        }
        return false;
    }
}
