namespace RestauranteC_POO;

public class PedidoDelivery : Pedido
{
       private const decimal taxaEntrega = 10.00m;

        public override decimal CalcularTotal()
        {
            return Pratos.Sum(p => p.ObterPreco()) + taxaEntrega;
        }
    }

