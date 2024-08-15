using System;

namespace Restaurante;

public class PedidoPresencial : Pedido
{
    public PedidoPresencial(string numeroPedido) : base(numeroPedido)
    {
    }

    public override decimal CalcularTotal()
    {
        return Pratos.Sum(prato => prato.ObterPreco());
    }
}