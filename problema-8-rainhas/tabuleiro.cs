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
        listRainhas.Add(new rainha(0, 0));
        listRainhas.Add(new rainha(1, 3));
        listRainhas.Add(new rainha(1, 6));
        listRainhas.Add(new rainha(2, 5));
        listRainhas.Add(new rainha(3, 1));
        listRainhas.Add(new rainha(4, 7));
        listRainhas.Add(new rainha(5, 3));
        listRainhas.Add(new rainha(6, 1));
        listRainhas.Add(new rainha(7, 4));
        listRainhas.Add(new rainha(7, 7));
    }



    public List<rainha> getLR
    {
        get { return listRainhas; }
    }


    public bool testColisao(List<rainha> listaRainhas, rainha r)
    {
        foreach (rainha tr in listaRainhas)
        {
            int d1 = Math.Abs(tr.X - r.X);
            int d2 = Math.Abs(tr.Y - r.Y);
            if(d1 == d2)
                Console.Write("Colisao diagonal("+(tr.X+1) + (tr.Y+1) + ") e (" + (r.X+1) + (r.Y+1) + ")" + "\n");

        }
        return false;
    }
}
