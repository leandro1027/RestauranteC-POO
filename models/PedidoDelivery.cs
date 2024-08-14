namespace RestauranteC_POO;

public class PedidoDelivery : Pedido
{
       private const decimal taxaEntrega = 10.00m; // taxa de entrega fixa

        public override decimal CalcularTotal() //implementação do método abstrato herdado de Pedido
        {
            return Pratos.Sum(p => p.ObterPreco()) + taxaEntrega;
        }
    }

