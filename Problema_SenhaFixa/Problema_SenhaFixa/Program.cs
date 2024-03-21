using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int senha;

            Console.Write("Digite a Senha: ");
            senha = int.Parse(Console.ReadLine());

            //laço para verificar se a senha informada é diferente de 2002.
            // Feito com if, caso o usuário digite corretamente, ficará no primeiro laço if.
            //Caso não digite corretamente, pulará para o else dentro do while.

            if(senha == 2002)
            {
                Console.Write("Acesso Permitido");
            }
            else
            {
                while(senha != 2002)
                {
                    Console.Write("SENHA INCORRETA. Tente novamente: ");
                    senha = int.Parse(Console.ReadLine());

                    if(senha == 2002)
                    {
                        Console.Write("Acesso Permitido!!");
                    }
                }
            }
            
        }
    }
}