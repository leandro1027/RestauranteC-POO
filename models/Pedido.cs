using System.Collections.Generic;

namespace RestauranteC_POO
{
    public abstract class Pedido
    {
        public string NumeroPedido { get; set; }
        public List<Prato> Pratos { get; set; } = new List<Prato>();

        public abstract decimal CalcularTotal(); // Método abstrato implementado nas classes Pedidodelivery e PedidoPresencial
    }
}
