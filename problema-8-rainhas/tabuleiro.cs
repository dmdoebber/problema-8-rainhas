using System;
using System.Collections.Generic;

public class Tabuleiro
{
    private List<rainha> listRainhas;

    public Tabuleiro()
	{
        listRainhas = new List<rainha>();
    }

    /* retorna o tabuleiro
    */

    public List<rainha> getLR
    {
        get { return listRainhas; }
    }

    /* adiciona uma rainha no tabuleiro
    */

    private void addRainha(rainha r)
    {
        listRainhas.Add(r);
    }

    /* remove a ultima linha inserida no tabuleiro
    */

    private void remRainha()
    {
        listRainhas.RemoveAt(listRainhas.Count - 1);
    }

    /* o metodo retorna a ultima rainha iserida
    */

    private rainha getLastRainha()
    {
        return listRainhas[listRainhas.Count - 1];
    }

    /* Verifica a colisão entre os pontos pegando os valores absolutos da subtração dos pontos
     * d1 = 0 (exite colisao em x)
     * d2 = 0 (existe colisao em Y)
     * d1 = d2 (existe colisao diagonal entre os pontos)
     */

    private bool testColisao(int x, int y)
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

    /* procura uma posição disponivel no tabuleiro na linha seguinte
     * se não houver posição disponivel na prox linha 
     * retorna falso
     */

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

    /* move pra frente a ultima rainha inserida no tabuleiro
     * se ela não puder ser alterada é removida do tabuleiro
     */

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

    /* imprime o estado atual das rainhas
     * onde a posição é a linha e o valor é a coluna 
     */

    public void imprimeEstado(int range)
    {
        Console.Write("\n<");
        for(int i  = 0; i < range; i++)
        {
            if (i < listRainhas.Count)
                Console.Write(listRainhas[i].Y + " ");
            else
                Console.Write("0 ");
        }
        Console.Write(">");
    }

    /* imprime o tabuleiro final
     */

    public void imprimeTabuleiro(int tam)
    {
        Console.Write("\n╔");
        for (int i = 0; i < 3 * tam; i++)
            Console.Write("═");
        Console.Write("╗");
        for (int i = 0; i < tam; i++)
        {
            Console.Write("\n║");
            for (int j = 0; j < tam; j++)
            {
                if (listRainhas[i].Y == j)
                    Console.Write("X  ");
                else
                    Console.Write(".  ");
            }
            Console.Write("║");
        }
        Console.Write("\n╚");
        for (int i = 0; i < 3 * tam; i++)
            Console.Write("═");
        Console.Write("╝");
    }
}
