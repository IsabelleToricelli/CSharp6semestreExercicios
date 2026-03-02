using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3MetodoGenerico
{
    /* Classe que recebe 1 variavel de qualquer tipo 
   internal class ClasFlex <T>
   {

       public T value { get; set; }

       public void Mostrar()
       {
           Console.WriteLine(value.ToString());//ToString para não mostrar o endereco da classe e sim o valor 

       }
       */
    /*Classe que recebe 2 variaveis de dois tipos diferentes */
    
    internal class ClasFlex<T1, T2> //Similar a um dicionario
    {
        public T1 value1 { get; set; }
        public T2 value2 { get; set; }
        public void Mostrar()
        {
            Console.WriteLine(value1.ToString());
            Console.WriteLine(value2.ToString());
        }
    }

}
