using System.Reflection.Metadata.Ecma335;

int[] arrayNumeros = { 1, 2, 3, 4, 5, 6, 7, 8 };
int valor;
while (true)
{
    Console.WriteLine("Qual valor você deseja encontrar dentro do array?: ");
    bool valorIsInt = int.TryParse(Console.ReadLine(), out valor);

    if (!valorIsInt) Console.WriteLine("Digite um valor válido!\n");

    else break;
}

bool BuscaBinaria(int[] array, int valorBuscado)
{
    int inicio = 0;
    int fim = array.Length - 1;

    while(inicio <= fim)
    {
        int meio = (inicio + fim) / 2;

        if (valorBuscado == array[meio]) return true;

        if (valorBuscado < array[meio])
        {
            fim = meio - 1;
        }
        else
        {
            inicio = meio + 1;
        }
    }
    return false;
}

bool encontrado = BuscaBinaria(arrayNumeros, valor);

if (encontrado) Console.WriteLine($"O valor {valor} foi encontrado no array");

else Console.WriteLine($"O valor {valor} não foi encontrado no array");

