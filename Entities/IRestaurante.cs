using System;

namespace Restaurante;

public interface IRestaurante
{
    void AdicionarPrato(Prato prato);
    void RemoverPrato(Prato prato);
    List<Prato> ListarCardapio();
    decimal CalcularTotalCardapio();
}