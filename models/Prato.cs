namespace RestauranteC_POO
{
    public class Prato
    {
        public string Nome { get; set; }
        public decimal preco { get; private set; }//encapsulamento do preco, tornei o set privado
        public bool Vegetariano { get; set; }

        public Prato(string nome, decimal preco, bool vegetariano) //construtor de prato
        {
            Nome = nome;
            AtualizarPreco(preco);
            Vegetariano = vegetariano;
        }

        public void AtualizarPreco(decimal novoPreco) //metodo para atualizar o preço, que verifico com o if se eçle é positivo
        {
            if (novoPreco > 0)
            {
                preco = novoPreco;
            }
            else
            {
                throw new ArgumentException("O preço deve ser positivo.");
            }
        }

        public decimal ObterPreco() //metodo que retorna o preço
        {
            return preco;
        }
    }
}

