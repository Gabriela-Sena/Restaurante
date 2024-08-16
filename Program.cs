using System;
using System.Collections.Generic;

namespace Restaurante
{
    class Program
    {
        static List<Restaurante> restaurantes = new List<Restaurante>(); // Cria uma lista de restaurantes
        static List<Pedido> pedidos = new List<Pedido>(); // Cria uma lista de pedidos

        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== Sistema de Gerenciamento de Restaurantes ===");
                Console.WriteLine("1. Cadastrar Restaurante");
                Console.WriteLine("2. Adicionar Prato ao Cardápio");
                Console.WriteLine("3. Remover Prato do Cardápio");
                Console.WriteLine("4. Criar Pedido Delivery");
                Console.WriteLine("5. Criar Pedido Presencial");
                Console.WriteLine("6. Exibir Total de um Pedido");
                Console.WriteLine("7. Sair");
                Console.WriteLine("8. Listar Pedidos");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarRestaurante();
                        break;
                    case "2":
                        AdicionarPratoCardapio();
                        break;
                    case "3":
                        RemoverPratoCardapio();
                        break;
                    case "4":
                        CriarPedidoDelivery();
                        break;
                    case "5":
                        CriarPedidoPresencial();
                        break;
                    case "6":
                        ExibirTotalPedido();
                        break;
                    case "7":
                        continuar = false;
                        break;
                    case "8":
                        ListarPedidos();
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void CadastrarRestaurante()
        {
            Console.Clear();
            Console.WriteLine("=== Cadastrar Restaurante ===");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            Restaurante restaurante = new Restaurante(nome, endereco, telefone);
            restaurantes.Add(restaurante);

            Console.WriteLine("Restaurante cadastrado com sucesso! Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void AdicionarPratoCardapio()
        {
            Console.Clear();
            Console.WriteLine("=== Adicionar Prato ao Cardápio ===");
            Restaurante restaurante = SelecionarRestaurante();

            if (restaurante != null)
            {
                Console.Write("Nome do prato: ");
                string nomePrato = Console.ReadLine();

                Console.Write("Preço do prato: ");
                decimal preco = Convert.ToDecimal(Console.ReadLine());

                Console.Write("É vegetariano? (s/n): ");
                bool vegetariano = Console.ReadLine().ToLower() == "s";

                Prato prato = new Prato(nomePrato, preco, vegetariano);
                restaurante.AdicionarPrato(prato);

                Console.WriteLine("Prato adicionado com sucesso! Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        static void RemoverPratoCardapio()
        {
            Console.Clear();
            Console.WriteLine("=== Remover Prato do Cardápio ===");
            Restaurante restaurante = SelecionarRestaurante();

            if (restaurante != null)
            {
                Prato prato = SelecionarPrato(restaurante);

                if (prato != null)
                {
                    restaurante.RemoverPrato(prato);
                    Console.WriteLine("Prato removido com sucesso! Pressione qualquer tecla para continuar...");
                }
                else
                {
                    Console.WriteLine("Prato não encontrado! Pressione qualquer tecla para continuar...");
                }
                Console.ReadKey();
            }
        }

        static void CriarPedidoDelivery()
        {
            Console.Clear();
            Console.WriteLine("=== Criar Pedido Delivery ===");

            Console.Write("Número do Pedido: ");
            string numeroPedido = Console.ReadLine();

            Console.Write("Taxa de Entrega: ");
            decimal taxaEntrega = Convert.ToDecimal(Console.ReadLine());

            PedidoDelivery pedidoDelivery = new PedidoDelivery(numeroPedido, taxaEntrega);
            AdicionarPratosAoPedido(pedidoDelivery);

            pedidos.Add(pedidoDelivery);

            Console.WriteLine("Pedido Delivery criado com sucesso! Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void CriarPedidoPresencial()
        {
            Console.Clear();
            Console.WriteLine("=== Criar Pedido Presencial ===");

            Console.Write("Número do Pedido: ");
            string numeroPedido = Console.ReadLine();

            PedidoPresencial pedidoPresencial = new PedidoPresencial(numeroPedido);
            AdicionarPratosAoPedido(pedidoPresencial);

            pedidos.Add(pedidoPresencial);

            Console.WriteLine("Pedido Presencial criado com sucesso! Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void ExibirTotalPedido()
        {
            Console.Clear();
            Console.WriteLine("=== Exibir Total de um Pedido ===");

            Console.Write("Número do Pedido: ");
            string numeroPedido = Console.ReadLine();

            Pedido pedido = BuscarPedidoPorNumero(numeroPedido);

            if (pedido != null)
            {
                Console.WriteLine($"Total do Pedido: {pedido.CalcularTotal():C}");
                Console.WriteLine("Pratos do Pedido:");

                foreach (var prato in pedido.Pratos)
                {
                    Console.WriteLine($"{prato.Nome} - {prato.ObterPreco():C}");
                }
            }
            else
            {
                Console.WriteLine("Pedido não encontrado!");
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void ListarPedidos()
        {
            Console.Clear();
            Console.WriteLine("=== Listagem de Pedidos ===");

            if (pedidos.Count == 0)
            {
                Console.WriteLine("Não há pedidos cadastrados.");
            }
            else
            {
                foreach (var pedido in pedidos)
                {
                    Console.WriteLine($"Número do Pedido: {pedido.NumeroPedido}");
                    Console.WriteLine($"Tipo de Pedido: {(pedido is PedidoDelivery ? "Delivery" : "Presencial")}");
                    Console.WriteLine("Pratos:");

                    foreach (var prato in pedido.Pratos)
                    {
                        Console.WriteLine($"- {prato.Nome} ({prato.ObterPreco():C})");
                    }

                    Console.WriteLine($"Total: {pedido.CalcularTotal():C}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static Restaurante SelecionarRestaurante()
        {
            Console.WriteLine("Restaurantes disponíveis:");
            for (int i = 0; i < restaurantes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {restaurantes[i].Nome}");
            }

            Console.Write("Escolha o restaurante: ");
            int indice = Convert.ToInt32(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < restaurantes.Count)
            {
                return restaurantes[indice];
            }
            else
            {
                Console.WriteLine("Restaurante inválido! Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                return null;
            }
        }

        static Prato SelecionarPrato(Restaurante restaurante)
        {
            Console.WriteLine("Pratos disponíveis:");
            for (int i = 0; i < restaurante.Cardapio.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {restaurante.Cardapio[i].Nome}");
            }

            Console.Write("Escolha o prato: ");
            int indice = Convert.ToInt32(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < restaurante.Cardapio.Count)
            {
                return restaurante.Cardapio[indice];
            }
            else
            {
                return null;
            }
        }

        static void AdicionarPratosAoPedido(Pedido pedido)
        {
            bool adicionarMais = true;
            while (adicionarMais)
            {
                Restaurante restaurante = SelecionarRestaurante();

                if (restaurante != null)
                {
                    Prato prato = SelecionarPrato(restaurante);

                    if (prato != null)
                    {
                        pedido.AdicionarPrato(prato);
                        Console.WriteLine("Prato adicionado ao pedido!");
                    }
                    else
                    {
                        Console.WriteLine("Prato não encontrado!");
                    }
                }

                Console.Write("Deseja adicionar outro prato ao pedido? (s/n): ");
                adicionarMais = Console.ReadLine().ToLower() == "s";
            }
        }

        static Pedido BuscarPedidoPorNumero(string numeroPedido)
        {
            return pedidos.Find(p => p.NumeroPedido == numeroPedido);
        }
    }
}
