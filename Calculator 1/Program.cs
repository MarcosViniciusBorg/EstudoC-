using System    ;

 namespace Calculator {

    class Program{
    
        static void Main (string[] args) {

            Menu();
            Calculo();
            
        }

        static void Menu()
        {
            Console.WriteLine("Bem vindo a calculadora: \n");

        }

        static void Calculo()
        {
            float res = 0;
            
            /*Console.Clear ();

            Console.WriteLine("Calculator");*/

            
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());  

            Console.WriteLine("Digite o sinal: ");
            string sinal = Console.ReadLine();
            
            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());  

            switch(sinal)
            {
                case "+": res = v1 + v2;
                          Console.WriteLine("O resultado é: "+ res); break;
                case "-": res = v1 - v2;
                          Console.WriteLine("O resultado é: "+ res); break;
                case "*": res = v1 * v2;
                          Console.WriteLine("O resultado é: "+ res); break;
                case "/": res = v1 / v2;
                          Console.WriteLine("O resultado é: "+ res); break;
                default: Console.WriteLine("Não temos essa operação");break;
            }
            Console.ReadKey();
        }

    }
 }