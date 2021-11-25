using System;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Mostrar todos números negativos no array*/
            //Imprime na tela para inserir o array
           Console.Write("Tamanho do array: ");
            int tamanho = Convert.ToInt32(Console.ReadLine());
            
            //cria o array com tamanho de acordo com a variavel
            int[] arr = new int[tamanho];

            //pede para digitar os valores do array
            Console.WriteLine("Insira {0} elementos do array", tamanho);

            //faz a leitura do quanto falta para finalizar as entradas
            for (int i = 0; i < tamanho; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
                
            Console.Write("\nTodos valores negativos");
            for (int i = 0; i < tamanho; i++)
            {
                  //verifica os valores menores do que zero e imprime
                if (arr[i] <0)
                {
                    Console.Write(" {0}", arr[i]);
                }
            }
            Console.ReadLine();


        }
    }
}
