using System;

namespace Restaurante;

public class PedidoPresencial : Pedido
{
    public PedidoPresencial(string numeroPedido) : base(numeroPedido)
    {
        //nao tem nada pois teria os mesmos dados de um pedido (classe base)
    }

    public override decimal CalcularTotal()
    {
        return Pratos.Sum(prato => prato.ObterPreco());
    }
}