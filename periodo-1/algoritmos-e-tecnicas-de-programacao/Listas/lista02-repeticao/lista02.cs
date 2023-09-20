
// 2° lista de exercícios(60) - Comandos de Repetição

using System;

/*
namespace exercicio_60
{
    class Ex60
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

namespace exercicio_59
{
    class Ex59
    {
        public static void Main(string[]args)
        {

            Console.WriteLine("digite o número de habitantes:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor do kwh:");
            int kwh = int.Parse(Console.ReadLine());

            int biggerConsumo = 0, smallerConsumo = 0, somaTotal = 0,soma1 = 0, soma2 = 0, soma3 = 0;

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Digite o consumo do {i}° habitante");
                int consumo = int.Parse(Console.ReadLine());
                Console.WriteLine($"Digite o código do {i}° consumidor(1 a 3):");
                int codigo = int.Parse(Console.ReadLine());
                if (smallerConsumo == 0 || smallerConsumo > consumo) smallerConsumo = consumo;
                if (biggerConsumo < consumo) biggerConsumo = consumo;
                somaTotal += consumo;

                switch (codigo) {
                    case 1:
                        soma1 += consumo;
                    break;
                    case 2:
                        soma1 += consumo;
                    break;
                    case 3:
                        soma1 += consumo;
                    break;
                }

            }

            Console.WriteLine($"maior consumo: {biggerConsumo} \n" +
            $"menor consumo: {smallerConsumo} \n" +
            $"media dos consumos: {somaTotal / n} \n" +
            $"consumo total Recidencial: {soma1} \n" +
            $"consumo total Comercial: {soma2} \n" +
            $"consumo total Industrial: {soma3}");
        }
    }
}

namespace exercicio_58
{
    class Ex58
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

            Console.WriteLine($"A soma dos número primos entre {a} e {b} foi: {soma}");

        }
    }
}

namespace exercicio_57
{
    class Ex57
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("digite o valor de a");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor de b");
            int b = int.Parse(Console.ReadLine());

            int count = 0,primos = 0;

            for(int i = a; i <= b; i++){
                for(int j = 1; j <= i; j++){
                    if (i % j == 0) count++;
                }
                if (count == 2){
                    primos++;
                }
                    count = 0;
            }

            Console.WriteLine($"Foram {primos} números primos entre {a} e {b}");

        }
    }
}

namespace exercicio_56
{
    class Ex56
    {
        public static void Main(string[]args)
        {
            int count = 0,primos = 0, soma = 0;

            for(int i = 1; i <= 10; i++){
                for(int j = 1; j <= i; j++){
                    if (i % j == 0) count++;
                }
                if (count == 2){
                    primos++;
                    soma += i;
                }
                    count = 0;
            }

            Console.WriteLine($"A soma de todos os números primos menores de 2M é {soma}");

        }
    }
}

namespace exercicio_55
{
    class Ex55
    {
        public static void Main(string[]args)
        {

            Console.WriteLine("Digite um número:");
            int n = int.Parse(Console.ReadLine());

            int count = 0, p = 1;

            for(int i = 1; p <= n; i++){
                for(int j = 1; j <= i; j++){
                    if (i % j == 0) count++;
                }
                if (count == 2){
                    Console.WriteLine(i);
                    p++;
                }
                count = 0;
            }
        }
    }
}

namespace exercicio_54
{
    class Ex54
    {
        public static void Main(string[]args)
        {

            Console.WriteLine("Digite um número:");
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for(int i = 1; i <= n; i++){
                if (n % i == 0) count++;
            }
            if (count == 2) Console.WriteLine("O número é primo");
            else Console.WriteLine("O número não é primo");
        }
    }
}

namespace exercicio_53
{
	class Ex53
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Digite o valor de n:");
			int n = int.Parse(Console.ReadLine());

			int cont = 1, value = 0;
			while (n >= cont)
			{
				for(int h = 0; h < cont; h++)
				{
					value++;
					Console.Write(value);
				}
                Console.Write("\n");
				cont++;
			}
		}
	}
}

namespace exercicio_52
{
	class Ex52
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Digite o valor de saque:");
			int s = int.Parse(Console.ReadLine());

            int cem = 0, cinquenta =0, vinte = 0, dez = 0, cinco = 0, dois = 0, um = 0;

            if (s >= 100) {
                if (s % 100 == 0) {
                    cem = s / 100;
                } else {
                    if (s % 100 > 50) {

                    }
                }
            }
		}
	}
}

namespace exercicio_51
{
    class Ex51
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

namespace exercicio_50
{
    class Ex50
    {
        public static void Main(string[]args)
        {
            double chico = 1.50, ze = 1.10;
            int years = 0;

            while (chico > ze) {
                chico += 0.02;
                ze += 0.03;
                years++;
            }

            Console.WriteLine($"Serão necessários {years} anos para ze ser mais alto que Chico");
        }
    }
}

namespace exercicio_49
{
    class Ex49
    {
        public static void Main(string[]args)
        {
            double carlos = 1000;
            double joao = carlos / 3;
            int meses = 0;

            while (joao <= carlos) {
                carlos += carlos * 0.02;
                joao += joao * 0.05;
                meses++;
            }


            Console.WriteLine($"Serão necessários {meses} meses para joao e carlos terem o mesmo valor");
        }
    }
}

namespace exercicio_48
{
    class Ex48
    {
        public static void Main(string[]args)
        {
            int soma = 0;
            int a = 1;
            int b = 1;
            int p = 0;

            while (b < 4000000) {
                p = a + b;
                if (p % 2 == 0) soma += p;
                a = b;
                b = p;
            }

            Console.WriteLine($"A soma dos números pares de Fibonnaci é {soma}");
        }
    }
}

namespace exercicio_47
{
    class Ex47
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Escolha uma opção do menu: \n" +
            "1 - adição: \n" +
            "2 - subtração: \n" +
            "3 - multiplicação: \n" +
            "4 - divisão: \n" +
            "5 - sair:");
            int menu = int.Parse(Console.ReadLine());
            
            while (menu != 5) {
                Console.WriteLine("Digite o primeiro número:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Deseja visualizar o resultado da operação? (s ou n):");
                char resultado = char.Parse(Console.ReadLine());
                if (resultado == 's') {
                    switch (menu) {
                        case 1:
                        Console.WriteLine($"{a} + {b} = {a + b}");
                        break;
                        case 2:
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;
                        case 3:
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;
                        case 4:
                        Console.WriteLine($"{a} / {b} = {a / b}");
                        break;
                    }
                }
                Console.WriteLine("Deseja voltar ao menu? (s ou n)");
                char backMenu = char.Parse(Console.ReadLine());
                if (backMenu == 's') {
                    Console.WriteLine("Escolha uma opção do menu: \n" +
                        "1 - adição: \n" +
                        "2 - subtração: \n" +
                        "3 - multiplicação: \n" +
                        "4 - divisão: \n" +
                        "5 - sair:");
                    menu = int.Parse(Console.ReadLine());
                }else break;
            }
        }
    }
}

namespace exercicio_46
{
    class Ex46
    {
        public static void Main(string[]args)
        {
            int nRandom = new Random().Next(1,100);
            int n = 0, i = 0;

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

namespace exercicio_45
{
    class Ex45
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Escolha uma opção do menu: \n" +
            "1 - converter km/h para m/s: \n" +
            "2 - converter m/s para km/h: \n" +
            "3 - sair:");
            int menu = int.Parse(Console.ReadLine());

            double valor = 0, result = 0;

            while (menu != 3) {
                if (menu == 1) {
                    Console.WriteLine("Digite quantos km/h");
                    valor = double.Parse(Console.ReadLine());
                    result = valor * 1000 / 60 / 60;
                    Console.WriteLine($"{valor}km/h são {result}m/s");
                }
                else {
                    Console.WriteLine("Digite quantos m/s");
                    valor = double.Parse(Console.ReadLine());
                    result = valor / 1000 * 60 * 60;
                    Console.WriteLine($"{valor}m/s são {result}km/h");
                }

                Console.WriteLine("\n Escolha uma opção do menu: \n" +
                    "1 - converter km/h para m/s: \n" +
                    "2 - converter m/s para km/h: \n" +
                    "3 - sair:");
                menu = int.Parse(Console.ReadLine());
            }
        }
    }
}

namespace exercicio_44
{
    class Ex44
    {
    
        public static void Main(string[]args)
        {
            Console.WriteLine("digite um número inteiro positivo:");
            int n = int.Parse(Console.ReadLine());

            int a = 1;
            int b = 1;
            int p = 0;

            Console.Write("0 1 1 ");

            while (p < n) {
                p = a + b;
                Console.Write($"{p} ");
                a = b;
                b = p;
            }
        }
    }
}

namespace exercicio_43
{
    class Ex43
    {
    
        public static void Main(string[]args)
        {
            int soma = 0, count = 1, age = 0;

            do {
                Console.WriteLine($"digite a idade da {count}° pessoa:");
                age = int.Parse(Console.ReadLine());
                soma+= age;
                count++;
            } while (age != 0);

            Console.WriteLine($"A média das idades é {soma / count}");
        }
    }
}

namespace exercicio_42
{
    class Ex42
    {
    
        public static void Main(string[]args)
        {
            int n = 0;

            do {
                Console.WriteLine($"digite um valor:");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine($"O quadrado de {n} é {Math.Pow(n, 2)}");
                Console.WriteLine($"O cubo de {n} é {Math.Pow(n, 3)}");
                Console.WriteLine($"A raiz quadrada de {n} é {Math.Sqrt(n)}");
            } while (n > 0);
        }
    }
}

namespace exercicio_41
{
    class Ex41
    {
    
        public static void Main(string[]args)
        {
            double r1 = 0, r2 = 0;
            do {
                Console.WriteLine($"digite o valor de R1:");
                r1 = int.Parse(Console.ReadLine());
                Console.WriteLine($"digite o valor de R2:");
                r2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"{r1 * r2 / (r1 + r2)}");
                
            } while (r1 == 0 || r2 == 0);
        }
    }
}

namespace exercicio_40
{
    class Ex40
    {
    
        public static void Main(string[]args)
        {
            int bigger = 0, smaller = 0, n = 0;
            do {
                Console.WriteLine($"digite um valor positivo:");
                n = int.Parse(Console.ReadLine());

                if (smaller == 0) smaller = n;
                else if (smaller > n && n > 0) smaller = n;

                if (n > bigger) bigger = n;

            } while (n > 0);

            Console.WriteLine($"O maior número lido foi {bigger} e o menor {smaller}");
        }
    }
}
*/
namespace exercicio_39
{
    class Ex39
    {
    
        public static void Main(string[]args)
        {
            
        }
    }
}