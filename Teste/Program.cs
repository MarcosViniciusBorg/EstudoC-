using System;

namespace Teste {
    
    class Program {
        static void Main (string[]args){

            // byte test = 3;
            // sbyte menegativo = -5;
            // int numero = 10;
            // numero = 20;
            // short tes = 1;
            // ushort test = -1; // erro
            // double salario = 1.2333;
            // float salarionovo = 2.12f;
            // decimal salrio = 2.123m;
            //char letra = 's';
            //string palavra ="testando";
            // int idade = null; // errado
            // int? idade2 = null; // certo
            // int inteiro = 100;
            // float  real = 25.5f;
            // double testando = inteiro - real;
            // real = inteiro;
            // inteiro = real; // erro
            
            // int inteiro = 100;
            // Console.WriteLine(inteiro);

            // if ( 25 == 32) // COMPAREI SE É IGUAL
            // {
            //     Console.WriteLine ( "TESTE 1 Correto");
            // } else {
            //     Console.WriteLine ("TESTE 1 Não igual");
            // }

            // if ( 25 != 32)  // COMPAREI SE NÃO É IGUAL
            // {
            //     Console.WriteLine ( "TESTE 2 Correto");
            // } else {
            //     Console.WriteLine ("TESTE 2 Não igual");
            // }
            
            // if ( idade == maior_idade) // COMPAREI SE É IGUAL
            // {
            //     Console.WriteLine ( "TESTE 1 Correto");
            // } else {
            //     Console.WriteLine ("TESTE 1 Não igual");
            // }

            // if ( idade != maior_idade)  // COMPAREI SE NÃO É IGUAL
            // {
            //     Console.WriteLine ( "TESTE 2 Correto");
            // } else {
            //     Console.WriteLine ("TESTE 2 Não igual");
            // }

            // if ( idade >= maior_idade) // COMPAREI SE É maior
            // {
            //     Console.WriteLine ( "Maior");
            // } else {
            //     Console.WriteLine ("menor");
            // }

            // if ( idade >= maior_idade && idade <= idoso) // COMPARação com and 
            // {
            //     Console.WriteLine ( "Adulto");
            // } else {
            //     Console.WriteLine ("não classificado");
            // }
            // int idoso = 65;
            // int idade = 08;
            // int maior_idade = 18;
            
            // if ( idade >= maior_idade ) // COMPARação com else if
            // {
            //     Console.WriteLine ( "Adulto");
            // } else if (idade <= idoso){
            //     Console.WriteLine ("Usei o else if");
            // }else {
            //     Console.WriteLine ("não classificado");
            // }

            // string number = "33";
            // //double res = number % 2;
            // switch (int.Parse(number) % 2) {
            //     case 0: Console.WriteLine(" É PAR");break;
            //     case > 0:  Console.WriteLine(" É impar");break;
            //     default : Console.WriteLine ("Não calculado"); break;
            // }

            // LAÇOS de repetição

            for (var i = 0; i < 4; i++){
                Console.WriteLine (i);
            }

            int varia = 5;
            
            while ( varia <= 7) {
                 Console.WriteLine("while " + varia);
                varia++;
            }
            
            do {
                    Console.WriteLine ("do while " + varia);
                    //varia = varia - 1;
                    //varia -=1;
                    varia --;
            }
            while( varia > 0);    
            
        }
    }
}