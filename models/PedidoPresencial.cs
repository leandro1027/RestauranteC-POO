namespace RestauranteC_POO;

public class PedidoPresencial : Pedido
{
      public override decimal CalcularTotal()
        {
            return Pratos.Sum(p => p.ObterPreco());
        }
    }

