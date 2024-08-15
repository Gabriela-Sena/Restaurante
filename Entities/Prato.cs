using System;

namespace Restaurante;

public class Prato
{
    public string Nome { get; set; }
    private decimal preco; // Propriedade encapsulada
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
            preco = novoPreco; // Encapsulamento do campo preco
        }
        else
        {
            throw new ArgumentException("O preço deve ser positivo.");
        }
    }

    public decimal ObterPreco()
    {
        return preco; // Acesso controlado ao preço
    }

    //Propriedade preco é privada e só pode ser acessada por meio dos métodos AtualizarPreco e ObterPreco 
    //Isso garante que o valor do preço só possa ser alterado de forma controlada, garantindo que o preço sempre será positivo
}
