// 1° lista de exercícios(4) - Nivelamento

using System;

01 - Criar um programa que carregue uma matriz 12 x 4 com os valores (em reais) das vendas de uma loja de
carros, em que cada linha represente um mês do ano, e cada coluna, uma semana do mês. Para fins de
simplificação considere que cada mês possui somente 4 semanas. Calcule e imprima:
-Total vendido em cada mês do ano;
- Total vendido no ano;
- Considerando todas as vendas do ano, informe qual é a melhor semana para vender carros (1ª, 2ª, 3ª ou 4ª)

namespace exercicio_01
{
    class Ex01
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] sales = new int[12,4];

            for (int i = 0; i < 12; i++){
                for(int j = 0; j < 4; j++) sales[i,j] = rnd.Next(1,10000);
            }

            // PRINT
            for (int i = 0; i < 12; i++){
                for(int j = 0; j < 4; j++){
                    Console.Write($"{sales[i,j]}  ");
                }
                Console.Write($"\n");
            }

            Console.WriteLine($"\n");

            double salesTotal = 0;
            double[] weeks = new double [4];

            for (int i = 0; i < 12; i++){
                double sum = 0;
                for(int j = 0; j < 4; j++){
                    sum += sales[i,j];
                    weeks[j] += sales[i,j];
                }
                Console.Write($"\n");
                Console.Write($"Total de vendas no mês {i+1}: R$ {sum}");
                salesTotal += sum;
            }

            double bestWeek = 1;
            double value = weeks[0];

            for(int i = 1; i < 4; i++){
                if (value < weeks[i]) bestWeek = i + 1;
            }
            Console.WriteLine($"\n");
            Console.WriteLine($"O valor total de vendas anual foi: R$ {salesTotal}");
            Console.WriteLine($"A melhor semana para venda de carros é a {bestWeek}° semana.");
        }
    }
}


02 - Faça um programa que leia uma sequência de números inteiros positivos, até que seja informado o valor -1.
Este programa deve responder qual é o tamanho da maior sequência crescente recebida

namespace exercicio_02
{
    class Ex02
    {
        public static void Main(string[] args)
        {
            int n = 0, x, count = 0, biggerCount = 0;
            do {
                Console.WriteLine("Digite um valor:");
                x = int.Parse(Console.ReadLine());
                if(x > n){
                    count++;
                    n = x;
                } else {
                    if(biggerCount < count) biggerCount = count;
                    count = 0;
                }
            }while (x != -1);

            Console.WriteLine($"Este programa teve a maior sequencia crescente com {biggerCount} numeros");
        }
    }
}


03 - Escreva um programa que calcule e mostre o valor da série:

namespace exercicio_03
{
    class Ex03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de n:");
            int n = int.Parse(Console.ReadLine());

            double p = 4;
            int count = 1;

            for (int i = 3; i <= n; i=i+2){
                if(count % 2 == 0){
                    p += 4/i;
                } else p += 4/i;
            }

            Console.WriteLine($"O valor de P é:{p}");
        }
    }
}
