
List<int> listaNum = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int numero;
int indice;
int opcao;

while (true)
{
    Console.WriteLine("Temos uma lista de números inteiros, o que você deseja saber? \n\n" +
        "[Opção 1] --> Qual número está no índice 'i'? \n\n" +
        "[Opção 2] --> Ou deseja saber se um número x está ou não na lista\n\n" +
        "[Opção 3] --> Sair");

    bool opcaoExiste = int.TryParse(Console.ReadLine(), out opcao);

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Digite o índice desejado: ");
            bool isValidIndice = int.TryParse(Console.ReadLine(), out indice);
            VerificaIndice(listaNum, indice);
            break;

        case 2:
            Console.WriteLine("Digite o número desejado: ");
            bool isIntNum = int.TryParse(Console.ReadLine(), out numero);
            NumeroNaLista(numero, listaNum);
            break;

        case 3:
            return;

        default:
            Console.WriteLine("Selecione uma opção que seja válida!");
            continue;
    }  
}

void NumeroNaLista(int num, List<int> lista)
{
    for(int i = 0; i < lista.Count; i++)
    {
        if (lista[i] == num)
        {
            Console.WriteLine($"O número {num} está na lista no índice {i}");
        }
    }
}

void VerificaIndice(List<int> lista, int indice)
{
    if(indice >= lista.Count || indice < 0)
    {
        Console.WriteLine("Índice fora dos limites");
        return;
    }

    Console.WriteLine($"O índice {indice} da lista é {lista[indice]}");
}