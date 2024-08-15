using System;

namespace Restaurante;

public class Restaurante : Estabelecimento
{

    //Classe Restaurante possui uma composição de objetos Prato em sua propriedade Cardapio
    //Cada restaurante contém uma lista de pratos
    public List<Prato> Cardapio { get; private set; }

    public Restaurante(string nome, string endereco, string telefone) : base(nome, endereco, telefone) // Chamando o construtor da classe base
    {
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

    //Classe Restaurante herda da classe Estabelecimento, aproveitando as propriedades Nome, Endereco, e Telefone
    //Isso elimina a duplicação de código e permite a reutilização de funcionalidades
}
