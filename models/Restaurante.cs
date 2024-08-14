using System.Collections.Generic;

namespace RestauranteC_POO
{
    public class Restaurante : Estabelecimento //Restaurante herda de estabelecimento
    {
        public List<Prato> Cardapio { get; private set; } = new List<Prato>();

        public void AdicionarPrato(Prato prato)
        {
            Cardapio.Add(prato);
        }

        public void RemoverPrato(Prato prato)
        {
            Cardapio.Remove(prato);
        }
    }
}

