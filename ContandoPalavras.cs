string frase = " Olá, mundo! Este é um teste: com pontuação, espaços extras e... números como 123 ou 45.6!";

string frase2 = "";


for (int i = 0; i < frase.Length; i++)
{ 
    if (char.IsLetter(frase[i]) || frase[i] == ' ')
    {
        frase2 += frase[i].ToString().ToLower();
    }
    else
    {
        continue;
    }
}

string[] palavras = frase2.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

Dictionary<string, int> contagemPalavras = new Dictionary<string, int>();

foreach (string palavra in palavras)
{
    if (contagemPalavras.ContainsKey(palavra))
    {
        contagemPalavras[palavra]++;
    }                   //chave  //valor
    else
    {
        contagemPalavras[palavra] = 1;
    }                    //chave    //valor
}

foreach(var item in contagemPalavras)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}

