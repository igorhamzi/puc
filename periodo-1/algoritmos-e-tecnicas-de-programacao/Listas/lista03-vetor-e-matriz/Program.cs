
// 3° lista de exercícios(64) - Vetores e Matrizes

using System;

/*
namespace exercicio_01
{
    class Ex01
    {
        public static void Main(string[]args)
        {
            int[] a = {1,0,5,-2,-5,7};
            int soma = a[0] + a[1] + a[5];
            Console.WriteLine(soma);
            a[4] = 100;
            for (int i = 0; i < 6; i++) Console.WriteLine(a[i]);
        }
    }
}

namespace exercicio_02
{
    class Ex02
    {
        public static void Main(string[]args)
        {
            int[] array = new int [6];

            for (int i = 0; i < 6; i++){
                Console.WriteLine($"Digite o {i+1}° valor do array:");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 6; i++) Console.Write($"{array[i]}, ");
        }
    }
}

namespace exercicio_03
{
    class Ex03
    {
        public static void Main(string[]args)
        {
            int[] a1 = new int [10];
            double[] a2 = new double [10];

            for (int i = 0; i < 10; i++){
                Console.WriteLine($"Digite o {i+1}° valor do array:");
                a1[i] = int.Parse(Console.ReadLine());
                a2[i] = Math.Sqrt(a1[i]);
            }
            for (int i = 0; i < 10; i++){
                if(i == 0) {
                    Console.Write($"Array 1: [");
                    Console.Write($"{a1[i]}, ");
                } else if (i != 9){
                    Console.Write($"{a1[i]}, ");
                } else {
                    Console.Write($"{a1[i]}]");
                }
            }
            Console.Write("\n");
            for (int i = 0; i < 10; i++){
                if(i == 0) {
                    Console.Write($"Array 2: [");
                    Console.Write($"{a2[i]}, ");
                } else if (i != 9){
                    Console.Write($"{a2[i]}, ");
                } else {
                    Console.Write($"{a2[i]}]");
                }
            }
        }
    }
}

namespace exercicio_04
{
    class Ex04
    {
        public static void Main(string[]args)
        {
            int[] a = new int [8];

            for (int i = 0; i < a.Length; i++){
                Console.WriteLine($"Digite o {i+1}° valor do array:");
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Digite o valor da posição X:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o valor da posição Y:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"A soma dos valores é: {a[x-1]} + {a[y-1]} = {a[x-1] + a[y-1]}");
        }
    }
}

namespace exercicio_05
{
    class Ex05
    {
        public static void Main(string[]args)
        {
            int[] array = new int [10];
            int count = 0;

            for (int i = 0; i < array.Length; i++){
                Console.WriteLine($"Digite o {i+1}° valor do array:");
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] % 2 == 0) count++;
            }
        }
    }
}

namespace exercicio_06
{
    class Ex06
    {
        public static void Main(string[]args)
        {
            int[] array = new int [10];
            int bigger = 0, smaller = 0;

            for (int i = 0; i < array.Length; i++){
                Console.WriteLine($"Digite o {i+1}° valor do array:");
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] > bigger) bigger = array[i];
                if (smaller == 0) smaller = array[i];
                else if (array[i] < smaller) smaller = array[i];
            }

            Console.WriteLine($"O maior valor é: {bigger}, e o menor valor é {smaller}");
        }
    }
}

namespace exercicio_07
{
    class Ex07
    {
        public static void Main(string[]args)
        {
            int[] array = new int [10];
            int bigger = 0, p = 0;

            for (int i = 0; i < array.Length; i++){
                Console.WriteLine($"Digite o {i+1}° valor do array:");
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] > bigger){
                    bigger = array[i];
                    p = i + 1;
                }
                Console.Write($"{array[i]}, ");
            }

            for (int i = 0; i < array.Length; i++){
                Console.Write($"{array[i]}, ");
                Console.WriteLine($"O maior número é: {bigger} e sua posição é: {p}");
            }
        }
    }
}

namespace exercicio_08
{
    class Ex08
    {
        public static void Main(string[]args)
        {
            int[] array = new int [6];

            for (int i = 0; i < array.Length; i++){
                Console.WriteLine($"Digite o {i+1}° valor do array:");
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = array.Length - 1; i >= 0; i--){
                Console.Write($"{array[i]}, ");
            }
        }
    }
}

namespace exercicio_09
{
    class Ex09
    {
        public static void Main(string[]args)
        {
            int[] array = new int [4];

            for (int i = 0; i < array.Length; i++){
                Console.WriteLine($"Digite o {i+1}° valor par do array:");
                array[i] = int.Parse(Console.ReadLine());

                while (array[i] % 2 != 0){
                    Console.WriteLine($"Digite o {i+1}° valor PAR do array:");
                    array[i] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = array.Length - 1; i >= 0; i--){
                Console.Write($"{array[i]}, ");
            }
        }
    }
}

namespace exercicio_10
{
    class Ex10
    {
        public static void Main(string[]args)
        {
            int[] array = new int [15];
            int soma = 0;

            for (int i = 0; i < array.Length; i++){
                Console.WriteLine($"Digite a nota do {i+1}° aluno:");
                array[i] = int.Parse(Console.ReadLine());
                soma += array[i];
            }

            Console.WriteLine($"A média geral é: {soma / array.Length - 1}");
        }
    }
}

namespace exercicio_11
{
    class Ex11
    {
        public static void Main(string[]args)
        {
            int[] array = new int [10];
            int cNegativos = 0, somaP = 0;

            for (int i = 0; i < array.Length; i++){
                Console.WriteLine($"Digite a nota do {i+1}° aluno:");
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] < 0) cNegativos++;
                else if (array[i] > 0) somaP += array[i];
            }

            Console.WriteLine($"São {cNegativos} números negativos e a soma é {somaP}");
        }
    }
}

namespace exercicio_12
{
    class Ex12
    {
        public static void Main(string[]args)
        {
            int[] array = new int [5];
            int b = 0, s = 0, m = 0;

            for (int i = 0; i < array.Length; i++){
                Console.WriteLine($"Digite a nota do {i+1}° aluno:");
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] == 0) s = array[i]; else if (array[i] < s) s = array[i];
                if (array[i] > b) b = array[i];
                m += array[i];
            }

            for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]}, ");

            Console.WriteLine($"Maior: {b}, menor: {s}, media: {m / array.Length - 1}");
        }
    }
}

namespace exercicio_13
{
    class Ex13
    {
        public static void Main(string[]args)
        {
            int[] array = new int [5];
            int b = 0, s = 0, pb = 0, ps = 0;

            for (int i = 0; i < array.Length; i++){
                Console.WriteLine($"Digite a nota do {i+1}° aluno:");
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] == 0){
                    s = array[i];
                    ps = i + 1;
                } else if (array[i] < s){
                    s = array[i];
                    ps = i + 1;
                } 
                if (array[i] > b){
                    b = array[i];
                    pb = i + 1;
                } 
            }

            Console.WriteLine($"A posição do menor valor é {ps}e do maior é {pb}");
        }
    }
}
*/
namespace exercicio_14
{
    class Ex14
    {
        public static void Main(string[]args)
        {
            int[] array = new int [10];

            for (int i = 0; i < array.Length; i++){
                Console.WriteLine($"Digite a nota do {i+1}° aluno:");
                int n = int.Parse(Console.ReadLine());

                for (int j = 0; j < i + 1; j++){
                    if (array[j] == n){
                        Console.WriteLine($"valores repetidos na posição: {i + 1} e {j + 1}");
                    } 
                }
            }

            for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]}, ");

        }
    }
}
