using System;
namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {

            Start();         
            Console.ReadKey();
        }

        static int Menu()
            {
                Console.WriteLine("Cronometro");
                Console.WriteLine("Quantos segundos deseja contar: \n"+ 
                                  "Caso deseje sair, basta digitar sair: ");
                int tempo = int.Parse(Console.ReadLine());
                return tempo;
            }

        static void Start()
        { 

            int time = Menu();
            int inicio = 0;

            while (inicio <= time)
            {
                Console.Clear();
                Console.WriteLine(inicio);
                Thread.Sleep(1000);
                inicio +=1;
            }

            Final();
            
        }    

        static void Final()
        {
            Console.WriteLine("Agora, decida:");
            Console.WriteLine("1 - Encerrar ");
            Console.WriteLine("2 - Continuar ");
            int finalizar = int.Parse(Console.ReadLine());

            if (finalizar == 2)
            {
                Start();
            } else if (finalizar != 1 && finalizar != 2)
            {
                Console.Clear();
                Final();
            }
            else
            {
                Console.WriteLine("Até mais");
            }
        }
                
    }
}