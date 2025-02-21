List<int> numeros = new List<int> { 12, 25, 4, 7, 8 };

void SomandoNumerosLista(List<int> lista)
{
    int soma = 0;
    
    for(int i = 0; i < lista.Count; i++)
    {
        soma += lista[i];
    }
    Console.WriteLine(soma);
}

SomandoNumerosLista(numeros);