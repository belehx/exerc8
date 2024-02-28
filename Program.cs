using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            int maior = numeros[0];
            int menor = numeros[0];

           
            for (int i = 1; i < 5; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
                else if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            
            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine($"O menor número é: " + menor);

            Console.ReadKey();    
        }
    }
}
    

