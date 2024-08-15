using System;

namespace Restaurante;

public class Estabelecimento //classe base para restaurante
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }

    public Estabelecimento(string nome, string endereco, string telefone)
    {
        Nome = nome;
        Endereco = endereco;
        Telefone = telefone;
    }
}


