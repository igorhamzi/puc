// 4° lista de exercícios(34) - String

using System;


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