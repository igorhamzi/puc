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
