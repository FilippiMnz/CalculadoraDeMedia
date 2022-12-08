using System;
namespace Media
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Insira a Primeira nota");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a segunda nota");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("insira a terceira nota");
            int nota3 = int.Parse(Console.ReadLine());

            int Media = (nota1 + nota2 + nota3) / 3;
            
            Console.WriteLine("A media do Aluno é {0}", Media);

            if (Media <= 7)
            {
                Console.WriteLine("Rodou parça, ta de recuperação");
            }
            else
            {
                Console.WriteLine( "Passou chefe");
            }
        
        }
    }
}
