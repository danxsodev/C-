using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA___Csharp
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("###############");
            Console.WriteLine("Escolha o tamanho do vetor");

            Console.WriteLine("Digite o tamanho do vetor");
            int x = int.Parse(Console.ReadLine());
            int numa = 0;
            int numb = 0;
            int y = 1;
            Console.WriteLine();
            int[] vetorprojeta = new int[x];
            int[] vetorprojetb = new int[x];
            int[] vetorprojetsoma = new int[x];
            int[] vetorprojetsub = new int[x];
            int[] vetorprojetdiv = new int[x];
            int[] vetorprojetmult = new int[x];
            int[] vetorprojetexp = new int[x];
            for (int i=0; i<x; i++)
            {
                Console.WriteLine($"Digite o Vetor A {y}");
                numa = int.Parse(Console.ReadLine());
                vetorprojeta[i] = numa;
                Console.WriteLine($"Digite o Vetor B {y}");
                y++;
                numb = int.Parse(Console.ReadLine());
                vetorprojetb[i] = numb;
                vetorprojetsoma[i] = vetorprojeta[i] + vetorprojetb[i];
                vetorprojetsub[i] = vetorprojeta[i] - vetorprojetb[i];
                vetorprojetdiv[i] = vetorprojeta[i] / vetorprojetb[i];
                vetorprojetmult[i] = vetorprojeta[i] * vetorprojetb[i];
                vetorprojetexp[i] = (int) Math.Pow(vetorprojeta[i] , vetorprojetb[i]);
            }
            Console.WriteLine("Vetor Soma");
            foreach(int item in vetorprojetsoma)
            {
                Console.WriteLine($"{item} \n");
            }
            Console.WriteLine("Vetor Sub");
            foreach (int item in vetorprojetsub)
            {
                Console.WriteLine($"{item} \n");
            }
            Console.WriteLine("Vetor Divisão");
            foreach (int item in vetorprojetdiv)
            {
                Console.WriteLine($"{item} \n");
            }
            Console.WriteLine("Vetor Multiplicação");
            foreach (int item in vetorprojetmult)
            {
                Console.WriteLine($"{item} \n");
            }
            Console.WriteLine("fim");
            Console.ReadKey();
        }
    }
}
