

void ContadorCaracteres(string palavra)
{
    for(int i = 0; i < palavra.Length; i++)
    {

        if (palavra[i] == ' ') continue;
        int contador = 0;
        
        for(int j = 0; j < palavra.Length; j++)
        {
            if (palavra[i] == palavra[j])
            {
                contador++;
            }
        }

        Console.WriteLine($"O caractere '{palavra[i]}' aparece {contador} vezes");
        palavra = palavra.Replace(palavra[i], ' ');       
    }
}

Console.WriteLine($"Na palavra pateta: ");
ContadorCaracteres("pateta");

