// Lista de 9 exercícios - Laboratório prático 9 (modularização)
using System;

/*
namespace exercicio_1
{
    class Ex1
    {
        public static int Operation(int a, int b, int c, char x){   
            switch (x) {
                case 'A':
                return (a + b + c) / 3;
                case 'P':
                return ((a * 5) + (b * 3) + (c * 2)) / (5 + 3 + 2);
                default:
                return 0;
            }
        }

        public static void Main(string[]args)
        {
            
            Console.WriteLine("Digite 3 valores inteiros:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite 'A' para média aritmetica e 'P' para média ponderada:");
            char media = char.Parse(Console.ReadLine());

            switch (media) {
                case 'A':
                Console.WriteLine($"A média aritmética é {Operation(a, b, c, media)}");
                break;
                case 'P':
                Console.WriteLine($"A média ponderada é {Operation(a, b, c, media)}");
                break;
                default:
                Console.WriteLine($"Não é possível fazer nenhum cálculo");
                break;
            }

        }

    }
}

namespace exercicio_2
{
    class Ex2
    {
        public static int SmallerValue(int a, int b, int c){   
            int smaller = a;
            if ( b < smaller) smaller = b;
            if ( c < smaller) smaller = c;
            return smaller;
        }

        public static void Main(string[]args)
        {
            
            Console.WriteLine("Digite 3 valores inteiros:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"O menor valor é {SmallerValue(a, b, c)}");

        }

    }
}

namespace exercicio_3
{
    class Ex3
    {
        public static double Media(double salary, int people){   
            return salary / people;
        }

        public static void Main(string[]args)
        {
            int people = 0;
            double salarySum = 0, salary;

            do {
                Console.WriteLine($"Digite o salário da {people + 1}° pessoa");
                salary = double.Parse(Console.ReadLine());
                salarySum += salary;
                people++;
                Console.WriteLine($"A média do salário das {people} pessoas é: {Media(salarySum, people)}");
            } while (salary != 0);

        }

    }
}

namespace exercicio_4
{
    class Ex4
    {
        public static char Conceito(int m){   
            switch (m){
                case <= 39:
                return 'F';

                case <= 59:
                return 'E';

                case <= 69:
                return 'D';

                case <= 79:
                return 'C';

                case <= 89:
                return 'B';

                default:
                return 'A';
            }
        }

        public static void Main(string[]args)
        {
            Console.WriteLine("Digite quantos alunos deseja saber o conceito:");
            int n = int.Parse(Console.ReadLine());

            int [] alunos = new int[n];

            for (int i = 0; i < alunos.Length; i++){
                Console.WriteLine($"Digite a média da nota do {i + 1}° aluno:");
                alunos[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < alunos.Length; i++){
                if (i == 0) Console.WriteLine("ALUNOS:      CONCEITOS:");
                Console.WriteLine($"{i + 1}°               {Conceito(alunos[i])}");
            }

        }

    }
}

namespace exercicio_5
{
    class Ex5
    {
        public static double CalculaE(int n){   
            double e = 1;

            for (int i = 1; i <= n; i++) {
                int f = 1;
                for(int j = 1; j <= i; j++) f *= j;
                e += 1 / f;
            }

            return e;
        }

        public static void Main(string[]args)
        {
            Console.WriteLine("Digite o valor de 'n':");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"O valor de E = {CalculaE(n)}");

        }

    }
}

namespace exercicio_6
{
    class Ex6
    {
        public static int SearchVogals(string x){   
            int countVogals = 0;

            for (int i = 0; i < x.Length; i++) {
                if(i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u') countVogals++;
            }

            return countVogals;
        }

        public static void Main(string[]args)
        {
            Console.WriteLine("Digite uma palavra:");
            string y = Console.ReadLine();

            Console.WriteLine($"Na palavra {y} tem {SearchVogals(y)}");

        }

    }
}

namespace exercicio_7
{
    class Ex7
    {
        public static double CalculationS(int n)
        {   
            double s = 1;

            for (int i = 2; i <= n; i++) s += 1 / i;

            return s;
        }

        public static void Main(string[]args)
        {
            Console.WriteLine("Digite o valor de 'n':");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"S = {CalculationS(n)}");

        }

    }
}

namespace exercicio_8
{
    class Ex8
    {
        public static double CalculationS(int n){   
            double s = 0;

            for (int i = 1; i <= n; i++) s += (Math.Pow(i,2) + 1) / (i + 3);

            return s;
        }

        public static void Main(string[]args)
        {
            Console.WriteLine("Digite o valor de 'n':");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"S = {CalculationS(n)}");

        }

    }
}

namespace exercicio_9
{
    class Ex9
    {
        public static string CalculationT(int x, int y, int z){   
            if(x > y + z || y > x + z || z > y + y) return "Não é um triângulo";
            else if (x == y && x == z) return "Triangulo Equilátero";
            else if (x == y || x == z || z == y) return "Triangulo Equilátero";
            else if (x != y && x != z && z != y) return "Triangulo Escaleno";
            else return "";
        }

        public static void Main(string[]args)
        {
            Console.WriteLine("Digite o valor das 3 medidas do triangulo':");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine($"{CalculationT(x, y, z)}");

        }

    }
}
*/