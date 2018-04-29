using System;

public class Busca
{
    private Tabuleiro t;
    private int tam;

    /* 
     */

    public Busca(int tam)
	{
        this.tam = tam;
        t = new Tabuleiro();
	}

    /* (metodo utilizado em thread apenas por estética)
     * laço que se repete até possuir o numero desejado de rainhas
     * começa verificando se a ultima rainha foi movimentada (se não foi, quer dizer que a rainha não poderia ser movimentada)
     * depois se ela foi movimentada, começa a procurar novas posições disponiveis
     * se não inserir move a ultima rainha e volta no looping
     * 
     * 
     * por fim imprime o tabuleiro final
     */

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

            t.imprimeEstado(tam);
        }

        t.imprimeTabuleiro(tam);
    }
}
