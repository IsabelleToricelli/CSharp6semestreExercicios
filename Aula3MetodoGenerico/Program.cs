using Aula3MetodoGenerico;
using System;

namespace MyApp
{
    internal class Program
    {
       
          public static void TrocaValores<T>(ref T a, ref T b)
           {
            T temp = a;
            a = b;
            b = temp;
            }
        static void Main(string[] args)
        {
           

            int a = 1;
            int b = 2;

            Console.WriteLine(a);
            Console.WriteLine(b);

            //Ref significa que eu tenho uma referencia na variavel e posso alterar o valor dela, sem ref eu não poderia alterar o valor da variavel, apenas ler o valor dela, com ref eu posso ler e alterar o valor da variavel, sem ref eu não poderia alterar o valor da variavel, apenas ler o valor dela, com ref eu posso ler e alterar o valor da variavel, sem ref eu não poderia alterar o valor da variavel, apenas ler o valor dela, com ref eu posso ler e alterar o valor da variavel, sem ref eu não poderia alterar o valor da variavel, apenas ler o valor dela, com ref eu posso ler e alterar o valor da variavel, sem ref eu não poderia alterar o valor da variavel, apenas ler o valor dela, com ref eu posso ler e alterar o valor da variavel, sem ref eu não poderia alterar o valor da variavel, apenas ler o valor dela, com ref eu posso ler e alterar o valor da variavel, sem ref eu não poderia alterar o valor da variavel, apenas ler o valor dela, com ref eu posso ler e alterar o valor da variavel, sem ref eu não poderia alterar o valor da variavel, apenas ler o valor dela, com ref eu posso ler e alterar o valor da variavel, sem ref eu não poderia alterar o valor da variavel, apenas ler o valor dela, com ref eu posso ler e alterar o valor da variavel, sem ref eu não poderia alterar o valor da variavel, apenas ler o valor dela, com ref eu posso ler e alterar o valor da variavel, sem ref eu não poderia alterar o valor da variavel, apenas ler o valor dela, com ref eu posso ler e alterar o valor da variavel, sem ref eu não poderia alterar o valor da variavel, apenas ler o valor dela, 
            //Ref de a é o endereco da memoria e nao o valor de a, quando se passa o ref na troca de valores não esta trocando os valores mas fornecendo o endereco de um para o outro, a referencia das variaveis sao trocadas.

            TrocaValores(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);

            //A classe pede tipagem para ser instanciada, ou seja, eu preciso dizer qual tipo de dado eu quero usar para a classe.
           /*ClasFlex<int> clasFlex = new ClasFlex<int>();
            clasFlex.value = 1;
            clasFlex.Mostrar();
           */
           /*Classe que recebe 2 variaveis de dois tipos diferentes */
            ClasFlex<int, string> clasFlex = new ClasFlex<int, string>();
            clasFlex.value1 = 1;
            clasFlex.value2 = "Teste";
            clasFlex.Mostrar();

        }
        
    }
}