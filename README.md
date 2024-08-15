# RestauranteCSharpPOO
Sistema de gerenciamento de uma rede de restaurantes com cadastro, gerenciador de cardápio de cada restaurante e processamento de pedidos de clientes em C# usando POO

# Conceitos de Programação Orientada a Objetos (POO)

# 1. Herança
Definição:
Herança é um mecanismo da POO que permite que uma classe herde atributos e métodos de outra classe. Isso promove a reutilização de código e a organização hierárquica das classes.

Aplicação no Projeto:
No projeto "RestauranteC_POO", a classe Restaurante herda da classe Estabelecimento. A classe Restaurante herda atributos como Nome, Endereco, e Telefone da classe Estabelecimento, permitindo que um restaurante seja representado como um tipo específico de estabelecimento.

# 2. Classe Abstrata
Definição:
Uma classe abstrata é uma classe que não pode ser instanciada diretamente e pode conter métodos abstratos (sem implementação) que devem ser implementados por classes derivadas.

Aplicação no Projeto:
A classe Pedido é abstrata e define o método CalcularTotal(), que é implementado nas classes derivadas PedidoDelivery e PedidoPresencial. Isso garante que qualquer tipo de pedido tenha um método para calcular o total, mas permite que cada tipo de pedido tenha sua própria forma de calcular esse total.

# 3. Encapsulamento
Definição:
Encapsulamento é o conceito de esconder os detalhes internos de uma classe e expor apenas o que é necessário. Isso é geralmente feito usando modificadores de acesso como private, protected, e public.

Aplicação no Projeto:
No projeto, a classe Prato encapsula o atributo preco, tornando seu setter privado e fornecendo um método AtualizarPreco() para validar e atualizar o preço. Isso protege a integridade dos dados, garantindo que o preço de um prato só possa ser alterado de maneira controlada.

# 4. Polimorfismo
Definição:
Polimorfismo permite que uma classe ou método tenha várias formas diferentes de comportamento. Em POO, isso é frequentemente alcançado através da herança e da implementação de interfaces.

Aplicação no Projeto:
O polimorfismo é utilizado no projeto com as classes PedidoDelivery e PedidoPresencial, ambas derivadas da classe abstrata Pedido. Cada classe implementa o método CalcularTotal() de forma diferente, adaptando o cálculo do total do pedido de acordo com o tipo de pedido (delivery ou presencial).

# 5. Métodos Estáticos
Definição:
Métodos estáticos pertencem à classe em si e não a uma instância específica da classe. Eles podem ser chamados sem a necessidade de criar um objeto da classe.

Aplicação no Projeto:
Embora o projeto "RestauranteC_POO" não utilize métodos estáticos, eles poderiam ser aplicados, por exemplo, para validar informações gerais, como o formato do telefone de um restaurante, que não dependem de uma instância específica.

# 6. Coleções Genéricas
Definição:
Coleções genéricas, como List<T>, permitem armazenar objetos de um tipo específico, proporcionando segurança de tipo e métodos úteis para manipulação de dados.

Aplicação no Projeto:
O projeto usa coleções genéricas, como List<Prato> para gerenciar o cardápio de um restaurante e List<Pedido> para armazenar pedidos. Isso facilita a manipulação de grupos de objetos, como adicionar ou remover pratos do cardápio e manter um registro dos pedidos feitos.
