using System;

namespace Restaurante;

public class PedidoDelivery : Pedido
{
    public decimal TaxaEntrega { get; set; }

    public PedidoDelivery(string numeroPedido, decimal taxaEntrega) : base(numeroPedido)
    {
        TaxaEntrega = taxaEntrega;
    }

    public override decimal CalcularTotal()
    {
        decimal total = Pratos.Sum(prato => prato.ObterPreco());
        return total + TaxaEntrega;
    }
}