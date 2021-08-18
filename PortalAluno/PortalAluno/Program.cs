using System;
using System.Collections.Generic;
namespace PortalAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> A = new SortedSet<int>();
            SortedSet<int> B = new SortedSet<int>();
            SortedSet<int> C = new SortedSet<int>();
            SortedSet<int> D = new SortedSet<int>();



            Console.Write("How many students for course A? ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; a > i; i++)
            {
                int n = i + 1;
                Console.Write("Numero do aluno: #" + n + "? ");
                int numeroaluno = int.Parse(Console.ReadLine());
                A.Add(numeroaluno);
            }

            Console.Write("How many students for course B? ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; b > i; i++)
            {
                int n = i + 1;
                Console.Write("Numero do aluno: #" + n + "? ");
                int numeroaluno = int.Parse(Console.ReadLine());
                B.Add(numeroaluno);
            }


            Console.Write("How many students for course C? ");
            int c = int.Parse(Console.ReadLine());
            for (int i = 0; c > i; i++)
            {
                int n = i + 1;
                Console.Write("Numero do aluno: #" + n + "? ");
                int numeroaluno = int.Parse(Console.ReadLine());
                C.Add(numeroaluno);
            }

            D.UnionWith(A);
            D.UnionWith(B);
            D.UnionWith(C);

            int students = 0;
            foreach (int var in D)
            {
                students++;
            }
            Console.WriteLine();
            Console.Write("Total students: ");
            Console.WriteLine(students);
        }
    }
}
