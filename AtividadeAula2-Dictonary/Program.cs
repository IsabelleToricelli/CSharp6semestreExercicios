using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criar um dicionario para armazenar telefone
            Dictionary<String, int> listaTelefonica = new Dictionary<String, int>();
            //Adicionar 3 telefones 
            listaTelefonica.Add("Mario", 1193377980);
            listaTelefonica.Add("Isabelle", 1197860000);
            listaTelefonica.Add("Carina", 1198081120);

            //Buscar um telefone pelo nome
            Console.WriteLine("Digite o nome para buscar o telefone: ");
            String nome = Console.ReadLine();

            //Usar trygetvalue para verificar se o nome existe no dicionário e obter o telefone correspondente
            if (listaTelefonica.TryGetValue(nome, out int telefone))
            {
                Console.WriteLine($"O telefone de {nome} é: {telefone}");
            }
            else
            {
                Console.WriteLine($"O nome {nome} não foi encontrado na lista telefônica.");
            }
        }
    }
}