namespace RestauranteC_POO;

public class PedidoPresencial : Pedido
{
      public override decimal CalcularTotal() //implementação do método abstrato herdado de Pedido
        {
            return Pratos.Sum(p => p.ObterPreco());
        }
    }

