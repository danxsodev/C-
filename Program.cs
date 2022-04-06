using System;

namespace imc
{
    class Program
    {
        static void Main(string[] args)
        {
            float x;
            float y;
            double r;

            Console.WriteLine("digita o valor a altura");
            x=float.Parse(Console.ReadLine());
            Console.WriteLine("digita o valor o peso");
            y=float.Parse(Console.ReadLine());
            r=y/(Math.Pow(x,2));

            if(r>=18.5&&r<25)
            {
                Console.WriteLine($"IMC Normal de = {r}");
            } 
            else if (r>=25&&r<30)
            {
                Console.WriteLine($"IMC Sobrepeso de = {r}");   
            }
            else if (r>=30&&r<40)
            {
                Console.WriteLine($"IMC Obesidade de = {r}"); 
            }
            else if (r>=40)
            {
                Console.WriteLine($"IMC Obesidade Mórbida de = {r}"); 
            }
        }
    }
}
