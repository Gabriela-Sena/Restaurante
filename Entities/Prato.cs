using System;

namespace Restaurante;

public class Prato
{
    public string Nome { get; set; }
    private decimal preco;
    public bool Vegetariano { get; set; }

    public Prato(string nome, decimal preco, bool vegetariano)
    {
        Nome = nome;
        AtualizarPreco(preco);
        Vegetariano = vegetariano;
    }

    public void AtualizarPreco(decimal novoPreco)
    {
        if (novoPreco > 0)
        {
            preco = novoPreco;
        }
        else
        {
            throw new ArgumentException("O preço deve ser positivo.");
        }
    }

    public decimal ObterPreco()
    {
        return preco;
    }
}
