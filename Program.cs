using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            //Limpando a tela de console
            Console.Clear();
            Console.WriteLine("#############################################");
            Console.WriteLine("#            Programa de Tabuada            #");
            Console.WriteLine("#############################################");
            Console.WriteLine();
            Console.WriteLine("Digite um número > ");
            numero = int.Parse(Console.ReadLine());

            for (int x=0 ; x<=10 ; x++){
                Console.WriteLine (numero + "X" + x + "=" + numero*x);
            }
            
        }
    }
}
