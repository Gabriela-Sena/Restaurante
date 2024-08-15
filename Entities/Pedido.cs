using System;

namespace Restaurante;

public abstract class Pedido //Classe base para PedidoDelivery e PedidoPresencial
{
//Classe Pedido é uma classe abstrata que define um esqueleto comum para todos os tipos de pedidos, mas deixa a implementação do cálculo do total para as subclasses
//sso permite trabalhar com diferentes tipos de pedidos sem se preocupar com os detalhes específicos de cada tipo

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

    public abstract decimal CalcularTotal(); // Método abstrato

    //Classe Pedido define o método abstrato CalcularTotal, que é implementado de formas diferentes nas classes PedidoDelivery e PedidoPresencial
    // Dessa forma, voce ode tratar ambos os tipos de pedidos de forma genérica, mas o cálculo do total será específico para cada tipo de pedido
    
}

