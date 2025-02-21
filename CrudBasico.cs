    List<string> listaDeCompras = new List<string>();
    int opcao;


    while (true)
    {
        Console.Clear();

        Console.WriteLine("O que você deseja fazer em sua lista de compras? \n" +
        "[1] - Adicionar Item\n" +
        "[2] - Deletar Item\n" +
        "[3] - Listar Itens\n" +
        "[4] - Atualizar dados\n" +
        "[5] - Sair");

        if (int.TryParse(Console.ReadLine(), out opcao))
        {
            switch (opcao)
            {
                case 1:
                    AdicionarLista();
                    break;

                case 2:
                    DeletarItem();
                    break;

                case 3:
                    ListarItens();
                    break;

                case 4:
                    AtualizarItem();
                    break;

                case 5:
                    Sair();
                    break;

                default:
                    Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;

            }
        }
    }

    void AdicionarLista()
    {
        Console.Clear();
        while (true)
        {

            string item;
            Console.WriteLine("Qual item você deseja adicionar a sua lista de compras? ");
            item = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(item))
            {
                listaDeCompras.Add(item);
                Console.WriteLine($"Item '{item}' adicionado com sucesso!");

                string escolha;

                Console.WriteLine("Deseja continuar adicionando itens? [S]im - [N]ão");
                escolha = Console.ReadLine().ToLower();

                if (escolha.StartsWith("s")) continue;
                if (escolha.StartsWith("n")) break;

            }
            else
            {
                Console.WriteLine("Espaços vazios não podem ser adicionados!");
            }

        }

        Console.WriteLine("Pressione qualquer tecla do teclado...");
        Console.ReadKey();
    }


    void DeletarItem()
    {
        Console.Clear();

        while (true)
        {
            string item;

            if (listaDeCompras.Count() > 0)
            {
                foreach (string i in listaDeCompras)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("Escreva o nome de qual dos itens da sua lista você deseja deletar\n\n");
                item = Console.ReadLine();

                if (listaDeCompras.Contains(item))
                {
                    listaDeCompras.Remove(item);
                    Console.WriteLine("Deseja continuar deletando itens? [S]im - [N]ão");
                    string escolha = Console.ReadLine().ToLower();

                    if (escolha.StartsWith("n")) break;
                    if (escolha.StartsWith("s")) continue;
            }
                else
                {
                    Console.WriteLine("Escolha um item válido");
                    Console.WriteLine("Deseja continuar deletando itens? [S]im - [N]ão");
                    string escolha = Console.ReadLine().ToLower();

                    if (escolha.StartsWith("n")) break;
                    if (escolha.StartsWith("s")) continue;
            }
            }      
            else
            {
                Console.WriteLine("Não há itens que possam ser deletados!");
                break;
            }
        }
        Console.WriteLine("Pressione qualquer tecla do teclado...");
        Console.ReadKey();
    }

    void ListarItens()
    {
        Console.Clear();

        if (listaDeCompras.Count > 0)
        {
            Console.WriteLine("Aqui estão os itens da sua lista: ");
            foreach(string item in listaDeCompras)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("Não há itens que possam ser listados!");
        }

        Console.WriteLine("Pressione qualquer tecla do teclado...");
        Console.ReadKey();
    }

void AtualizarItem()
{
    if (listaDeCompras.Count > 0)
    {
        int contador = 0;
        int indice;

        foreach (string item in listaDeCompras)
        {
            Console.WriteLine($"{contador} - {item}");
            contador++;
        }

        while (true)
        {
            string atualizacao;

            Console.WriteLine("Selecione o índice do item que deseja atualizar: ");
            bool isInt = int.TryParse(Console.ReadLine(), out indice);

            Console.WriteLine("Escreva a atualização que deseja fazer: ");
            atualizacao = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(atualizacao) && isInt == true && 0 <= indice && indice < listaDeCompras.Count)
                listaDeCompras[indice] = atualizacao;

            Console.WriteLine("Item atualizado com sucesso!");

            Console.WriteLine("Deseja atualizar outro item? [S]im - [N]ão");
            string escolha = Console.ReadLine().ToLower();

            if (escolha.StartsWith("n")) break;
            if (escolha.StartsWith("s")) continue;
        }

    }
    else
    {
        Console.WriteLine("Não há itens para ser atualizados!");
    }

    Console.WriteLine("Pressione qualquer tecla do teclado...");
    Console.ReadKey();

}

    void Sair()
    {
        if (opcao == 5)
        {
            Console.Clear();
            Console.WriteLine("Saindo do programa... Até mais!");
            Environment.Exit(0);
        }

    }