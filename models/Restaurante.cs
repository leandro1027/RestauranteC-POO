using System.Collections.Generic;

namespace RestauranteC_POO;


public class Restaurante : Estabelecimento
{
   
    private List<Estabelecimento> cardapio = new List<Estabelecimento>();

    public void AdiconarPrato(prato prato)
    {
        cardapio.Add(prato);
    }
}