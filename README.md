# RestauranteCSharpPOO
Sistema de gerenciamento de uma rede de restaurantes com cadastro, gerenciador de cardápio de cada restaurante e processamento de pedidos de clientes em C# usando POO

# Principais Funcionalidades

# 1. Cadastro de Restaurantes:
Permite criar e gerenciar informações de diferentes restaurantes, como nome, endereço e telefone.
# 2. Gerenciamento de Cardápio:
Adicione ou remova pratos de um restaurante, especificando o nome do prato, preço e se é vegetariano ou não.
# 3. Criação e Processamento de Pedidos:
Crie pedidos do tipo delivery ou presencial. Para pedidos delivery, uma taxa de entrega fixa é adicionada ao total.
# 4. Cálculo e Exibição do Total do Pedido:
Visualize os detalhes de um pedido, incluindo os pratos escolhidos e o valor total a ser pago.

# Conceitos de Programação Orientada a Objetos (POO):

# 1. Herança
No projeto, a classe Restaurante herda da classe Estabelecimento. A classe Restaurante herda atributos como Nome, Endereco, e Telefone da classe Estabelecimento, permitindo que um restaurante seja representado como um tipo específico de estabelecimento.

# 2. Classe Abstrata
A classe Pedido é abstrata e define o método CalcularTotal(), que é implementado nas classes derivadas PedidoDelivery e PedidoPresencial. Isso garante que qualquer tipo de pedido tenha um método para calcular o total, mas permite que cada tipo de pedido tenha sua própria forma de calcular esse total.

# 3. Encapsulamento
No projeto, a classe Prato encapsula o atributo preco, tornando seu setter privado e fornecendo um método AtualizarPreco() para validar e atualizar o preço. Isso protege a integridade dos dados, garantindo que o preço de um prato só possa ser alterado de maneira controlada.

# 4. Polimorfismo
O polimorfismo é utilizado no projeto com as classes PedidoDelivery e PedidoPresencial, ambas derivadas da classe abstrata Pedido. Cada classe implementa o método CalcularTotal() de forma diferente, adaptando o cálculo do total do pedido de acordo com o tipo de pedido (delivery ou presencial).

# 5. Coleções Genéricas
O projeto usa coleções genéricas, como List<Prato> para gerenciar o cardápio de um restaurante e List<Pedido> para armazenar pedidos. Isso facilita a manipulação de grupos de objetos, como adicionar ou remover pratos do cardápio e manter um registro dos pedidos feitos.

# Execusão do sistema:
1. Certifique-se de ter o .NET instalado em seu ambiente.
2. Compile o código-fonte utilizando um ambiente de desenvolvimento como o Visual Studio, ou diretamente pelo terminal com o comando:
dotnet build
3.Após a compilação, execute o programa com:
dotnet run
