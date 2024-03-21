using System.Globalization;


internal class Program
{
    private static void Main(string[] args)
    {
        int x, y, soma, troca;
        
        Console.WriteLine("Digite dois números: ");
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        //condição para trocar a ordem dos valores de x e y.
        if(x > y)
        {
            troca = x;
            x = y;
            y = troca;
        }

        //CONDIÇÃO PARA REALIZAR A SOMA DOS ÍMPARES ENTRE X E Y.

        soma = 0;
        for(int i = x + 1; i < y; i++)
        {
            if(i % 2 != 0)
            {
                soma = soma + i;
            }
        }

        Console.Write("SOMA DOS ÍMPARES = " + soma);
    }
}