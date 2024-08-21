using System;

namespace Restaurante;

public class Restaurante : IRestaurante //A classe Restaurante agora é obrigada a implementar todos os métodos definidos na interface IRestaurante
//Isso torna a interface focada exclusivamente em operações de restaurantes
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
    public List<Prato> Cardapio { get; set; }

    public Restaurante(string nome, string endereco, string telefone)
    {
        Nome = nome;
        Endereco = endereco;
        Telefone = telefone;
        Cardapio = new List<Prato>();
    }

    public void AdicionarPrato(Prato prato)
    {
        Cardapio.Add(prato);
    }

    public void RemoverPrato(Prato prato)
    {
        Cardapio.Remove(prato);
    }

    public List<Prato> ListarCardapio()
    {
        return Cardapio;
    }

    public decimal CalcularTotalCardapio()
    {
        return Cardapio.Sum(prato => prato.ObterPreco());
    }
}
