// Lista de 8 exercícios - Laboratório prático 5
using System;

/*
namespace exercicio_1
{
    class Ex1
    {
        public static void Main(string[]args)
        {
            int nRandom = new Random().Next(1,5);
            int n = 0;
            int i = 0;

            for(i = 0; n != nRandom; i++){
                Console.WriteLine("Acerte o número gerado aleatoriamente de 1 a 100:");
                n = int.Parse(Console.ReadLine());

                if (n < nRandom) Console.WriteLine("o número é maior!");
                else Console.WriteLine("O número é menor!");    
            }

            Console.WriteLine($"Uhuu! você acertou o número em {i} tentativas :)");

        }
    }
}

namespace exercicio_2
{
    class Ex2
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("digite o valor de a");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor de b");
            int b = int.Parse(Console.ReadLine());

            int count = 0,primos = 0,soma = 0;

            for(int i = a; i <= b; i++){
                for(int j = 1; j <= i; j++){
                    if (i % j == 0) count++;
                }
                if (count == 2){
                    primos++;
                    soma += i;
                }
                    count = 0;
            }

            Console.WriteLine($"Foram {primos} números primos entre {a} e {b}");

        }
    }
}

namespace exercicio_3
{
    class Ex3
    {
        public static void Main(string[]args)
        {

            int n = 1, soma = 0, qnt = 0, bigger = 0, smaller = 0;
            int somaP = 0, qntP = 0;

            while (n != 0) {
                Console.WriteLine("digite um valor:");
                n = int.Parse(Console.ReadLine());
                soma += n;
                qnt++;
                if(n > bigger) bigger = n;
                if (smaller == 0) smaller = n;
                else if (n < smaller) smaller = n;
                if (n % 2 == 0){
                    somaP += n;
                    qntP++;
                }
            }

            Console.WriteLine($"A soma dos números digitados é {soma} \n" +
            $"A quantidade de números digitados foi {qnt} \n" +
            $"A media dos números digitados foi {soma / qnt} \n" +
            $"O maior número foi {bigger} \n" +
            $"o menor número foi {smaller} \n" +
            $"A média dos números pares foi {somaP / qntP} \n");
        }
    }
}

namespace exercicio_4
{
    class Ex4
    {
        public static void Main(string[]args)
        {

            double soma = 0, somaQ = 0;

            for (int i = 1; i <= 100; i++){
                soma += i;
                somaQ += Math.Pow(i, 2);
            }
            double result = Math.Pow(soma, 2);

            Console.WriteLine($"A diferença é {result - somaQ}");
        }
    }
}

namespace exercicio_5
{
    class Ex5
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Digite um número:");
            int n = int.Parse(Console.ReadLine());

            double s = 0;
            int sub = 0;
            int denom = 1;

            for(int i = 1; i < n;i++) {
                for(int h = 1; h <= n - sub; h++){
                   denom *= h;
                }
                sub++;
                if(s == 0) s = i / denom;
                else if ( i != 0) s -= i / denom;
                else s += i / denom;
                denom = 1;
            };

            Console.WriteLine(s);
        }
    }
}

namespace exercicio_6
{
    class Ex6
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Digite um número:");
            int n = int.Parse(Console.ReadLine());

            int controller = 0;
            int count = 1;

            while (controller == 0) {
                if((n + count) % 11 == 0) {
                    Console.WriteLine($"{n + count} múltiplo de 11");
                    controller++;
                }
                if ((n + count) % 13 == 0) {
                    Console.WriteLine($"{n + count} múltiplo de 13");
                    controller++;
                }
                if ((n + count) % 17 == 0) {
                    Console.WriteLine($"{n + count} múltiplo de 17");
                    controller++;
                }
                count++;
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
            double salary = 2000, aumentoAtual = salary * 0.015;

            for (int i = 1996; i <= 2023; i++){
                salary += aumentoAtual;
                aumentoAtual *= 2; 
            }
            Console.WriteLine($"O salário atual é: {salary}");
        }
    }
}

namespace exercicio_8
{
    class Ex8
    {
        public static void Main(string[]args)
        {
            for (int i = 1000; i <= 9999;i++) {
                int soma = (i / 100) + (i % 1000);
                if (Math.Pow(soma, 2) == i) Console.WriteLine(i);
            }
        }
    }
}
*/