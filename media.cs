using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            float w;
            float x;
            float y;
            float z;
            float r;

            Console.WriteLine("digita o valor de w");
            w=float.Parse(Console.ReadLine());
            Console.WriteLine("digita o valor de x");
            x=float.Parse(Console.ReadLine());
            Console.WriteLine("digita o valor de y");
            y=float.Parse(Console.ReadLine());
            Console.WriteLine("digita o valor de z");
            z=float.Parse(Console.ReadLine());
         
            r=(w+x+y+z)/4;
            if(r>=6)
            {
                Console.WriteLine($"Aluno Aprovado, com a média de {r}");
            } 
            else if (r<6)
            {
                Console.WriteLine($"Aluno Reprovado, com a média de {r}");
            }
        }
    }
}

