// Lista de 8 exercícios - Laboratório prático 6 (VETORES)
using System;

/*
namespace exercicio_1
{
    class Ex1
    {
        public static void Main(string[]args)
        {
            int[] numbers = new int [20];

            for (int i = 0; i < numbers.Length; i++){
                Random rnd = new Random();
                numbers[i] = rnd.Next(1,100);
            }

            Console.WriteLine("Digite um valor (1 a 100):");
            int n = int.Parse(Console.ReadLine());

            string positions = "";

            for (int i = 0; i < numbers.Length; i++){
                if (n == numbers[i]){
                    positions += $"{i}, ";
                }
            }

            Console.Write($"O {n} está nas posições {positions} do array");
        }
    }
}

namespace exercicio_2
{
    class Ex2
    {
        public static void Main(string[]args)
        {
            int[] numbers = new int [5];

            for (int i = 0; i < numbers.Length; i++){
                Random rnd = new Random();
                numbers[i] = rnd.Next(1,100);
            }

            int smaller = numbers[0], smallerP = 0;

            for (int i = 0; i < numbers.Length; i++){
                if (numbers[i] < smaller){
                    smaller = numbers[i];
                    smallerP = i;
                }
            } 
            int p = numbers[smallerP];
            numbers[smallerP] = numbers[0];
            numbers[0] = p;
        }
    }
}

namespace exercicio_3
{
    class Ex3
    {
        public static void Main(string[]args)
        {
            int[] a = new int [10];
            for (int i = 0; i < 10; i++){
                Console.WriteLine($"Digite o {i+1}° valor do vetor A:");
                int n = int.Parse(Console.ReadLine());
                a[i] = n;
            }

            int[] b = new int [10];
            for (int i = 0; i < 10; i++){
                Console.WriteLine($"Digite o {i+1}° valor do vetor B:");
                int n = int.Parse(Console.ReadLine());
                b[i] = n;
            }

            int[] c = new int [10];

            for (int i = 0; i < 10; i++) c[i] = a[i] - b[i];
            for (int i = 0; i < c.Length; i++) Console.WriteLine($"{c[i]}, ");
        }
    }
}

namespace exercicio_4
{
    class Ex4
    {
        public static void Main(string[]args)
        {
            int[] a = new int [5];
            for (int i = 0; i < 5; i++){
                Console.WriteLine($"Digite o {i+1}° valor do vetor A:");
                int n = int.Parse(Console.ReadLine());
                a[i] = n;
            }

            int[] b = new int [5];
            for (int i = 0; i < 5; i++) b[i] = a[i] * 2;
        }
    }
}

namespace exercicio_5
{
    class Ex5
    {
        public static void Main(string[]args)
        {
            int[] a = new int [50];
            for (int i = 0; i < a.Length; i++) a[i] = (i + (3 * i) % (i + 1));

            for (int i = 0; i < a.Length; i++) Console.WriteLine($"{a[i]}, ");
        }
    }
}

namespace exercicio_6
{
    class Ex6
    {
        public static void Main(string[]args)
        {
            int[] a = new int [60];
            int i = 0, idade, soma = 0, media = 0;
            do {
                Console.WriteLine($"Digite a idade do {i+1}° aluno:");
                idade = int.Parse(Console.ReadLine());
                a[i] = idade;
                soma += idade;
            } while (i < 60 && idade != 0);

            media = soma / i;

            for (int j = 0; j < i; j++){
                Console.WriteLine($"idade do {j+1} é {a[j]}");
                if (a[j] > media) Console.WriteLine($"idade {a[j]} do {j+1} é acima da média");
            }
        }
    }
}

namespace exercicio_7
{
    class Ex7
    {
        public static void Main(string[]args)
        {
            int[] a = new int [100];

            int i = 1;

            while (i <= 100) {
                if (i % 7 != 0 || i % 10 != 7){
                    a[i-1] = i;
                    i++;
                }
            }
        }
    }
}

namespace exercicio_8
{
    class Ex8
    {
        public static void Main(string[]args)
        {
            int[] a = new int [10];
            for (int i = 0; i < a.Length; i++){
                Console.WriteLine($"Digite o {i+1}° valor do vetor A:");
                int n = int.Parse(Console.ReadLine());
                a[i] = n;
            }

            int[] b = new int [10];
            for (int i = 0; i < b.Length; i++){
                do {
                    Console.WriteLine($"Digite o {i+1}° valor do vetor B:");
                    int n = int.Parse(Console.ReadLine());
                    b[i] = n;
                } while (b[i] == a[i]);       
            }
            for (int i = 0; i < 10; i++){
                int dif = a[i] - b[i];
                Console.WriteLine($"A diferença entre os numeros da posição {i} é {dif}");
            }
        }
    }
}
*/

