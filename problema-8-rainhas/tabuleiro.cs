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
        listRainhas.Add(new rainha(0, 3));
        listRainhas.Add(new rainha(1, 6));
        listRainhas.Add(new rainha(2, 2));
        listRainhas.Add(new rainha(3, 7));
        listRainhas.Add(new rainha(4, 1));
        listRainhas.Add(new rainha(5, 4));
        listRainhas.Add(new rainha(6, 0));
        listRainhas.Add(new rainha(7, 5));
    }

    public List<rainha> getLR
    {
        get { return listRainhas; }
    }


    public bool testColisao(rainha r, int indice)
    {
        foreach (rainha tr in listRainhas)
        {
            
            if(Math.Abs(tr.X - r.X) == 0 || Math.Abs(tr.Y - r.Y) == 0)
            {
                Console.Write("Colisao = (" + (tr.X + 1) + (tr.Y + 1) + ") e (" + (r.X + 1) + (r.Y + 1) + ")" + "\n");
                return true;
            }
                
        }
        return false;
    }
}
