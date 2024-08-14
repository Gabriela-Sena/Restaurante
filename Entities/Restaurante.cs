using System;

namespace Restaurante;
{
    public class Restaurante:Estabelecimento
    {
        public Restaurante(string nome, string endereco, string telefone) : base(nome, endereco, telefone)
	{
		Nome = nome;
        Endereco = endereco;
        Telefone = telefone;
	}
    }
}