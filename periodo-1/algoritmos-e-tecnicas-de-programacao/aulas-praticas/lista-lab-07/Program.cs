// Lista de 8 exercícios - Laboratório prático 7 (Matriz e vetores)
using System;

/*

namespace exercicio_1
{
    class Ex1
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Digite a quantidade de linhas:");
            int l = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de colunas:");
            int c = int.Parse(Console.ReadLine());

            int [,] mat = new int[l,c];
            int[] array = new int [c];

            Random rnd = new Random();

            int soma = 0;

            for (int i = 0; i < l; i++){
                for (int j = 0; j < c; j++){
                    mat[i,j] = rnd.Next();
                    soma += mat[i,j];
                }
                array[i] = soma;
                soma = 0;
            }
        }
    }
}

namespace exercicio_2
{
    class Ex2
    {
        public static void Main(string[]args)
        {
            Random rnd = new Random();

            

            int[] v1 = new int [10];
            int[] v2 = new int [10];

            for (int i = 0; i < 10; i++){
                v1[i] = rnd.Next();
                v2[i] = rnd.Next();
            }

            int [,] mat = new int[2,5];

            for (int i = 0; i < 2; i++){
                for (int j = 0; j < 5; j++){
                    mat[i,j] = v1[i] * v2[j];
                }
            } 
        }
    }
}

namespace exercicio_3
{
    class Ex3
    {
        public static void Main(string[]args)
        {
            Random rnd = new Random();

            int[] v = new int [10];

            int [,] mat = new int[5,10];

            int nota = 0, soma = 0, bigger = 0;

            for (int i = 0; i < 5; i++){
                for (int j = 0; j < 10; j++){
                    if (mat[i,j] == v[j]) nota++;
                }
                Console.WriteLine($"A nota do {i + 1}º aluno foi: {nota}");
                if (nota > bigger) bigger = nota;
                soma += nota;
                nota = 0;
            }

            int media = soma / 50;
        }
    }
}

namespace exercicio_4
{
    class Ex4
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Digite a dimensão de uma matriz quadrada, linhas:");
            int l = int.Parse(Console.ReadLine());

            Console.WriteLine("Colunas:");
            int c = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            int [,] mat = new int[l,c];

            for (int i = 0; i < l; i++){
                for (int j = 0; j < c; j++){
                    mat[i,j] = rnd.Next();
                }
            }

            int[] v = new int [l * c];

            int x = 0, bigger = 0, soma = 0, count = 0;
            String h = "teste";

            for (int i = 0; i < l; i++){
                for (int j = 0; j < c; j++){
                    if (mat[i,j] > bigger){
                        bigger = mat[i,j];
                        x = j;
                    }
                }
                v[x] = bigger;
                x = 0;
                bigger = 0;
            }

            for (int i = 0; i < l * c; i++){
                Console.WriteLine(v[i]);
                soma += v[i];
                count++;
            }

            Console.WriteLine(soma / count);
        }
    }
}
*/