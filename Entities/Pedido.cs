using System;

namespace Restaurante;

public abstract class Pedido
{
    public string NumeroPedido { get; set; }
    public List<Prato> Pratos { get; private set; }

    public Pedido(string numeroPedido)
    {
        NumeroPedido = numeroPedido;
        Pratos = new List<Prato>();
    }

    public void AdicionarPrato(Prato prato)
    {
        Pratos.Add(prato);
    }

    public abstract decimal CalcularTotal();

}