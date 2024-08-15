namespace RestauranteC_POO
{
    /*
    Menu simples que permite ao usuário:
    Cadastrar restaurantes e pratos.
    Adicionar e remover pratos do cardápio de um restaurante.
    Criar e processar pedidos (delivery e presencial).
    Exibir o total de um pedido, com detalhes sobre os pratos incluídos.
    */

    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<Restaurante> restaurantes = new List<Restaurante>(); // Lista que armazena todos os restaurantes cadastrados
            bool executando = true;

            while (executando)
            {
                Console.Clear();  // Limpa o console a cada iteração do loop
                Console.WriteLine("----- Menu -----");
                Console.WriteLine("1. Cadastrar Restaurante");
                Console.WriteLine("2. Cadastrar Prato");
                Console.WriteLine("3. Adicionar Prato ao Cardápio");
                Console.WriteLine("4. Remover Prato do Cardápio");
                Console.WriteLine("5. Criar Pedido Delivery");
                Console.WriteLine("6. Criar Pedido Presencial");
                Console.WriteLine("7. Exibir Total de um Pedido");
                Console.WriteLine("8. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarRestaurante(restaurantes);
                        break;
                    case "2":
                        CadastrarPrato(restaurantes);
                        break;
                    case "3":
                        AdicionarPratoCardapio(restaurantes);
                        break;
                    case "4":
                        RemoverPratoCardapio(restaurantes);
                        break;
                    case "5":
                        CriarPedidoDelivery(restaurantes);
                        break;
                    case "6":
                        CriarPedidoPresencial(restaurantes);
                        break;
                    case "7":
                        ExibirTotalPedido();
                        break;
                    case "8":
                        executando = false; // Sai do loop e encerra o programa
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                if (executando)
                {
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey(); // Aguarda o usuário pressionar uma tecla antes de continuar
                }
            }
        }

        static void CadastrarRestaurante(List<Restaurante> restaurantes)
        {
            Console.Write("Digite o nome do restaurante: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o endereço do restaurante: ");
            string endereco = Console.ReadLine();
            Console.Write("Digite o telefone do restaurante: ");
            string telefone = Console.ReadLine();

            // Cria um novo objeto Restaurante com os dados fornecidos
            Restaurante restaurante = new Restaurante { Nome = nome, Endereco = endereco, Telefone = telefone };
            restaurantes.Add(restaurante); // Adiciona o restaurante à lista de restaurantes

            Console.WriteLine("Restaurante cadastrado com sucesso!");
        }

        static void CadastrarPrato(List<Restaurante> restaurantes)
        {
          
            Restaurante restaurante = EscolherRestaurante(restaurantes);   // Permite ao usuário escolher um restaurante para cadastrar um prato
            if (restaurante == null) return; 

            Console.Write("Digite o nome do prato: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o preço do prato: ");
            decimal preco = decimal.Parse(Console.ReadLine());
            Console.Write("O prato é vegetariano? (s/n): ");
            bool vegetariano = Console.ReadLine().ToLower() == "s";

          
            Prato prato = new Prato(nome, preco, vegetariano);  // Cria um novo objeto Prato com os dados fornecidos
            restaurante.AdicionarPrato(prato); // Adiciona o prato ao cardápio do restaurante

            Console.WriteLine("Prato cadastrado com sucesso!");
        }

        static void AdicionarPratoCardapio(List<Restaurante> restaurantes)
        {
           
            Restaurante restaurante = EscolherRestaurante(restaurantes);  // Permite ao usuário escolher um restaurante para adicionar um prato ao cardápio
            if (restaurante == null) return; 

            
            Prato prato = EscolherPrato(restaurante); // Permite ao usuário escolher um prato para adicionar ao cardápio
            if (prato != null)
            {
                restaurante.AdicionarPrato(prato); // Adiciona o prato ao cardápio do restaurante
                Console.WriteLine("Prato adicionado ao cardápio!");
            }
        }

        static void RemoverPratoCardapio(List<Restaurante> restaurantes)
        {
           
            Restaurante restaurante = EscolherRestaurante(restaurantes);  // Permite ao usuário escolher um restaurante para remover um prato do cardápio
            if (restaurante == null) return;

            
            Prato prato = EscolherPrato(restaurante); // Permite ao usuário escolher um prato para remover do cardápio
            if (prato != null)
            {
                restaurante.RemoverPrato(prato); // Remove o prato do cardápio do restaurante
                Console.WriteLine("Prato removido do cardápio!");
            }
        }

        static void CriarPedidoDelivery(List<Restaurante> restaurantes)
        {
            
            PedidoDelivery pedido = new PedidoDelivery(); // Cria um novo pedido de delivery e chama o método de criação de pedido
            CriarPedido(restaurantes, pedido);
        }

        static void CriarPedidoPresencial(List<Restaurante> restaurantes)
        {
            
            PedidoPresencial pedido = new PedidoPresencial(); // Cria um novo pedido presencial e chama o método de criação de pedido
            CriarPedido(restaurantes, pedido);
        }

        static void CriarPedido(List<Restaurante> restaurantes, Pedido pedido)
        {
           
            Restaurante restaurante = EscolherRestaurante(restaurantes);  // Permite ao usuário escolher um restaurante e criar um pedido
            if (restaurante == null) return; 

            bool adicionandoPratos = true;

            while (adicionandoPratos)
            {
               
                Prato prato = EscolherPrato(restaurante);  // Permite ao usuário escolher um prato para adicionar ao pedido
                if (prato != null)
                {
                    pedido.Pratos.Add(prato); // Adiciona o prato à lista de pratos do pedido
                    Console.WriteLine("Prato adicionado ao pedido!");
                }

                Console.Write("Deseja adicionar mais pratos? (s/n): ");
                adicionandoPratos = Console.ReadLine().ToLower() == "s";
            }

            Console.WriteLine("Pedido criado com sucesso!");
            Console.WriteLine($"Total do pedido: {pedido.CalcularTotal():C}"); // Exibe o total do pedido formatado como moeda
        }

        static void ExibirTotalPedido() 
        {
            Console.Write("Digite o número do pedido: ");
            string numeroPedido = Console.ReadLine();

            
            Console.WriteLine("Não implementei ainda."); //Falta implementação
        }

        static Restaurante EscolherRestaurante(List<Restaurante> restaurantes)
        {
            if (restaurantes.Count == 0)
            {
                Console.WriteLine("Nenhum restaurante cadastrado.");
                return null;
            }

            Console.WriteLine("Escolha um restaurante:");
            for (int i = 0; i < restaurantes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {restaurantes[i].Nome}");
            }

            int escolha = int.Parse(Console.ReadLine());
            if (escolha < 1 || escolha > restaurantes.Count)
            {
                Console.WriteLine("Escolha inválida.");
                return null;
            }

            return restaurantes[escolha - 1]; // Retorna o restaurante escolhido
        }

        static Prato EscolherPrato(Restaurante restaurante)
        {
            if (restaurante.Cardapio.Count == 0)
            {
                Console.WriteLine("Nenhum prato disponível no cardápio.");
                return null;
            }

            Console.WriteLine("Escolha um prato:");
            for (int i = 0; i < restaurante.Cardapio.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {restaurante.Cardapio[i].Nome} - {restaurante.Cardapio[i].ObterPreco():C}");
            }

            int escolha = int.Parse(Console.ReadLine());
            if (escolha < 1 || escolha > restaurante.Cardapio.Count)
            {
                Console.WriteLine("Escolha inválida.");
                return null;
            }

            return restaurante.Cardapio[escolha - 1]; // Retorna o prato escolhido
        }
    }
}
