using System;
using System.IO;

namespace Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo");
            Thread.Sleep(1000);
            Menu();
            Console.ReadKey();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha a opção: ");
            Console.WriteLine("1 - Abrir Arquivo \n" + "2 - Criar novo arquivo \n"
                               + "0 - Sair");
            short escolha = short.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: Abrir(); break;
                case 2: Editar(); break;
                case 0: System.Environment.Exit(0);break;
                default: Console.WriteLine("Opção invalida, tente novamente");
                         Thread.Sleep(5000); Menu();break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo? ");
            string caminho = Console.ReadLine();

            using(var file = new StreamReader(caminho))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.ReadKey();
            Menu();

        }

        static void Editar()
        {
            string text = null;

            Console.Clear();
            Console.WriteLine("Digite seu texto: \n"+ "Digite ESC para sair. \n"+
                              "--------------------");
            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine; //quebrando a linha no final da leitura;
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape) ;

            //Console.WriteLine(text);
            Salvar(text);

        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine(" Qual o caminho para salvar: ");
            var caminho = Console.ReadLine();

            using( var file = new StreamWriter(caminho))
                //todo objeto é aberto e fechado sem termos que nos preocupar
            {
                file.Write (text);
            }

            Console.WriteLine("Arquivo salvo com sucesso");
            Thread.Sleep(4000);
            Menu();
        }
    }
}