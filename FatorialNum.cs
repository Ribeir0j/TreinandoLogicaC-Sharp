using System.Numerics;
using System.Reflection;

int numero;
while (true)
{
    Console.WriteLine("Digite um número inteiro: ");

    bool intNumero = int.TryParse(Console.ReadLine(), out numero);

    if (intNumero)
    {
        break;
    }
    else
    {
        Console.WriteLine("Por favor, digite um número inteiro!");
    }
}

BigInteger CalcularFatorial(int numero)
{
    if (numero == 0)
    {
        return 1;
    }

    return numero * CalcularFatorial(numero - 1);
}

Console.WriteLine($"O fatorial de {numero} é {CalcularFatorial(numero)}");

    /*  
       ______________________________________________________________________________________

     *                          Entendendo a recursividade:
       ______________________________________________________________________________________
        
        * Valor de entrada == 5
        
     *  Calcularfatorial(5) -- > 5 * calcularfatorial(4)
     *  Calcularfatorial(4) -- > 4 * calcularfatorial(3)
     *  Calcularfatorial(3) -- > 3 * calcularfatorial(2)
     *  Calcularfatorial(2) -- > 2 * calcularfatorial(1)
     *  Calcularfatorial(1) --> 1 * calcularfatorial(0)
     *  calcularfatorial(0) --> retorna 1 e a função para de chamar a si mesma (condição de parada)  

     *  Agora a pilha vai ser resolvida de baixo para cima pois: 
     
     *  calcularfatorial(5) que é a chamada inicial da função, aguarda calcularfatorial(4) ser resolvida
     *  calcularfatorial(4), aguarda calcularfatorial(3)
     *  calcularfatorial(3), aguarda calcularfatorial(2)
     *  calcularfatorial(2), aguarda calcularfatorial(1)
     *  calcularfatorial(1), aguarda calcularfatorial(0) 
      
     *  Assim quando calcularfatorial(0) retorna 1, calcularfatorial(1) pode ser resolvida, e assim por diante
     
     * 1 * CalcularFatorial(0) = 1 * 1
     * 2 * CalcularFatorial(1) = 2 * 1 
     * 3 * CalcularFatorial(2) = 3 * 2 * 1
     * 4 * CalcularFatorial(3) = 4 * 3 * 2 * 1
     * 5 * CalcularFatorial(5) = 5 * 4 * 3 * 2 * 1
     */



