# Restaurante
# Aluna: Gabriela Sena da Silva

# Rodar projeto: 'dotnet run'
# Este projeto tem como objetivo gerenciar uma rede de restaurantes. O sistema deve permitir cadastrar restaurantes, gerenciar o cardápio de cada restaurante e processar pedidos de clientes.

### Estrutura do Projeto

1. *Classes e Herança:*

   - **Classe Estabelecimento:**
     - Propriedades:
       - Nome (string)
       - Endereco (string)
       - Telefone (string)

   - **Classe Restaurante (herda de Estabelecimento):**
     - Propriedades:
       - Cardapio (lista de objetos da classe Prato)
     - Métodos:
       - AdicionarPrato(Prato prato): Adiciona um prato ao cardápio
       - RemoverPrato(Prato prato): Remove um prato do cardápio

   - **Classe Prato:**
     - Propriedades:
       - Nome (string)
       - Preco (decimal) - Encapsulado
       - Vegetariano (bool)
     - Métodos:
       - AtualizarPreco(decimal novoPreco): Atualiza o preço do prato, garantindo que o valor seja sempre positivo
       - ObterPreco(): Retorna o preço atual do prato

2. *Encapsulamento:*
   - Na classe Prato, o acesso ao preço será controlado por métodos públicos. Isso garante que o preço seja manipulado de maneira segura

3. *Polimorfismo:*

   - **Classe abstrata Pedido:**
     - Propriedades:
       - NumeroPedido (string)
       - Pratos (lista de objetos da classe Prato)
     - Métodos:
       - CalcularTotal(): Método abstrato que deve ser implementado nas classes derivadas

   - **Classe PedidoDelivery (herda de Pedido):**
     - Propriedades adicionais:
       - TaxaEntrega (decimal)
     - Métodos:
       - Implementação de CalcularTotal(), considerando o valor dos pratos mais a taxa de entrega

   - **Classe PedidoPresencial (herda de Pedido):**
     - Métodos:
       - Implementação de CalcularTotal(), considerando apenas o valor dos pratos

4. *Interação com o Usuário:*

   - Um menu simples será implementado no programa principal para permitir que o usuário:
     - Cadastre restaurantes e pratos
     - Adicione e remova pratos do cardápio de um restaurante
     - Crie e processe pedidos (delivery e presencial)
     - Exiba o total de um pedido, incluindo detalhes sobre os pratos

### Explicação das Funcionalidades do Menu

1. *Cadastrar Restaurante*: Permite que o usuário cadastre um novo restaurante
2. *Adicionar Prato ao Cardápio*: Permite que o usuário adicione pratos ao cardápio de um restaurante específico
3. *Remover Prato do Cardápio*: Permite que o usuário remova pratos do cardápio de um restaurante específico
4. *Criar Pedido Delivery*: Permite criar um pedido de delivery, incluindo a seleção de pratos e cálculo do total
5. *Criar Pedido Presencial*: Permite criar um pedido presencial, incluindo a seleção de pratos e cálculo do total
6. *Exibir Total de um Pedido*: Permite que o usuário veja o total de um pedido, junto com os detalhes dos pratos
7. *Sair*: Sai do sistema.


