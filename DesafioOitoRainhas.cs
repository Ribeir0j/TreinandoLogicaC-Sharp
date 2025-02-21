using System.ComponentModel;
using System.Security.Cryptography;

int[,] matriz = new int[8, 8];
Random random = new Random();


bool VerificarDiagonais(int[,] matriz)
{
    for (int i = 0; i < 8; i++) //"cria" uma linha
    {
        for (int j = 0; j < 8; j++) //percorre todas as suas colunas
        {
            if (matriz[i, j] == 1) //se achar o 1 (rainha) em alguma posição continua, se não volta e procura em outra linha
            {
                for (int i2 = i + 1; i2 < 8; i2++) //se achou o 1, ele vai pular pra linha de baixo i2  
                {
                   for (int j2 = 0; j2 < 8; j2++) //e vai percorrer todas as colunas dessa linha
                   {
                      if (matriz[i2, j2] == 1) //se achar uma posição que tenha 1
                      {
                           if (i + j == i2 + j2 || i - j == i2 - j2) //vai calcular se ta na diagonal
                           {
                               return true;
                           }
                      }
                   }
                }
            }
        }
    }
    return false; //não há rainhas em diagonais
}

bool VerificarColunas(int[,] matriz)
{
    for (int j = 0; j < 8; j++) //vai na coluna de indice 0 
    {
        int rainhas = 0;
        for (int i = 0; i < 8; i++) //percorre as linhas
        {
            if (matriz[i, j] == 1) //Se achar uma posição que tenha 1, soma a rainha no contador de rainhas
            {   
                rainhas++;
            }
        }
        if (rainhas > 1) //se o contador tem mais de uma quer dizer que tem mais de uma rainha naquela coluna
        {
           return true; //tem mais de uma rainha
        }
    }

    return false; //não tem mais de uma rainha em cada coluna
}

void LimparMatriz(int[,] matriz)
{
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
             matriz[i, j] = 0; //cria uma matriz só com zeros
        }
    }
}

void ColocarRainhas(int[,] matriz)
{
    bool posicaoCorreta = false; //inicializa a variavel posicao correta

    while (!posicaoCorreta) //enquanto ela for falsa
    {
        LimparMatriz(matriz); //limpa a matriz antes de começar

        for (int i = 0; i < 8; i++) //começa a partir da linha 0
        {
            int posicaoRainha = random.Next(0, 8); //escolhe um número aleatorio entre 0 e 7
            matriz[i, posicaoRainha] = 1; //coloca o número 1 nessa posição [indice i, indice aleatorio]
        }

        if (!VerificarColunas(matriz) && !VerificarDiagonais(matriz)) //Pega o retorno das verificações
        {
            posicaoCorreta = true; //posicao esta correta, sai do looping. Se estiver incorreta, limpa a matriz e começa de novo!
        }
    }

    ExibirMatriz(matriz); //exibe a matriz
}

void ExibirMatriz(int[,] matriz)
{   
    for (int i = 0; i < 8; i++) 
    {
        for (int j = 0; j < 8; j++)
        {
            Console.Write(matriz[i, j] + " "); //passa por todos os indices de linhas e colunas e coloca cada valor na sua posição. Onde n estiver 1 em c# vai ser automaticamente preenchido por 0
        }
        Console.WriteLine();
    }
}

ColocarRainhas(matriz); 