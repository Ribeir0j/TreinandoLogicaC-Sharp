using System.Reflection.Metadata.Ecma335;

string palavra = "";

while (true)
{
    Console.WriteLine("Digite uma palavra e verifique se ela é um palíndromo: ");
    palavra = Console.ReadLine();
    
    if(palavra.Contains(" ")) 
    {
        Console.WriteLine("Digite somente uma palavra");
        continue;
    }
    else
    {
        break;
    }
}


void VerificaPalindromo(string palavra)
{
    string palavraInvertida = "";

    for(int i = palavra.Length - 1; i >= 0; i--)
    {
        palavraInvertida += string.Concat(palavra[i]);

    }
        if(palavraInvertida == palavra)
        {
            Console.WriteLine($"A palavra '{palavra}' é um palíndromo.");
        }
        else
        {
            Console.WriteLine($"A palavra '{palavra}' não é um palíndromo.");
        }
}

VerificaPalindromo(palavra);