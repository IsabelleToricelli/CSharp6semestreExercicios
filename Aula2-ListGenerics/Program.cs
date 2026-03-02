using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criacao de uma lista de produtos 
            List<string> list = new List<string>();
            //Criar 5 objetos 
            list.Add("Coca-Cola");
            list.Add("Pepsi");
            list.Add("Fanta");
            list.Add("Sprite");
            list.Add("Guaraná");

            //Mostrar os produtos da lista
            Console.WriteLine("Lista de Produtos");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //Remover um produto 
            list.Remove("Pepsi");

            //Mostrar a lista atualizada
            Console.WriteLine("Lista de Produtos atualizada");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}