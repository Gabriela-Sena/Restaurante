using System;

namespace Restaurante;

public class PedidoDelivery : Pedido //herda de Pedido  
{
    public decimal TaxaEntrega { get; set; }

    public PedidoDelivery(string numeroPedido, decimal taxaEntrega) : base(numeroPedido)
    {
        TaxaEntrega = taxaEntrega; // tem atributo a mais no pedido
    }

    public override decimal CalcularTotal()
    {
        decimal total = Pratos.Sum(prato => prato.ObterPreco());
        return total + TaxaEntrega;
    }
}