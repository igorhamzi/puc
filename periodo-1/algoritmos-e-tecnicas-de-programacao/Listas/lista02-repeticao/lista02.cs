
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

            int i100 = 0, i50 =0, i20 = 0, i10 = 0, i5 = 0, i2 = 0, i1 = 0;

            while (s > 0) {
                if (100 < s){
                    i100++;
                    s -= 100;
                }else if (50 < s){
                    i50++;
                    s -= 50;
                }else if (20 < s){
                    i20++;
                    s -= 20;
                }else if (10 < s){
                    i10++;
                    s -= 10;
                }else if (5 < s){
                    i5++;
                    s -= 5;
                }else if (2 < s){
                    i2++;
                    s -= 2;
                }else if (1 == s){
                    i1++;
                    s -= 1;
                }
            }

            Console.WriteLine("Foi preciso das seguintes quantidades de notas: \n" +
            $"100: {i100} \n" + 
            $"50: {i50} \n" + 
            $"20: {i20} \n" + 
            $"10: {i10} \n" + 
            $"5: {i5} \n" + 
            $"2: {i2} \n" + 
            $"1: {i1} \n");
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

namespace exercicio_39
{
    class Ex39
    {
    
        public static void Main(string[]args)
        {
            Console.WriteLine("Digite a altura do triângulo");
            double height = double.Parse(Console.ReadLine());
            if(height <= 0) {
                Console.Write("Digite um valor maior que 0 para a altura:");
                height = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite a base do triângulo");
            double baseT = double.Parse(Console.ReadLine());
            if (baseT <= 0) {
                Console.Write("Digite um valor maior que 0 para a base:");
                baseT = double.Parse(Console.ReadLine());
            }
            
            Console.WriteLine($"A base do triângulo é: {baseT * height / 2}");
        }
    }
}

namespace exercicio_38
{
    class Ex38
    {
    
        public static void Main(string[]args)
        {

        }
    }
}

namespace exercicio_37
{
    class Ex37
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

namespace exercicio_36
{
    class Ex36
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

namespace exercicio_35
{
    class Ex35
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Digite o valor inicial e valor final:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int soma = 0;

            if(a < b){
                for(int i = a; i < b; i++){
                    if (i % 2 != 0) soma += i;
                }
                Console.WriteLine($"Soma dos ímpares nesse intervalo: {soma}");
            } else Console.WriteLine("Intervalo de valores inválidos");
        }
    }
}

namespace exercicio_34
{
    class Ex34
    {
        public static void Main(string[]args)
        {
            bool key = true;
            int controller = 0, number = 0;

            for(int i = 1; key; i++){
                for(int j = 1; j <= 20; j++){
                    if(i % j == 0) controller++;
                }
                if (controller == 20) {
                    number = i;
                    key = false;
                }
                controller = 0;
            }
            Console.WriteLine($"O menor número é {number}");
        }
    }
}

namespace exercicio_33
{
    class Ex33
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Digite o valor de n, i e j (maiores que 0):");
            int n = int.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());

            int count = 0;

            for(int h = 0; count < n; h++) {
                if(h % i == 0 || h % j == 0) {
                    Console.Write($"{h}, ");
                    count++;
                }
            }
        }
    }
}

namespace exercicio_32
{
    class Ex32
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Digite o número de lançamentos:");
            int n = int.Parse(Console.ReadLine());

            string result = "";

            for (int i = 0; i < n;i++){
                Console.WriteLine("Digite o valor de d1 e d2:");
                double d1 = double.Parse(Console.ReadLine());
                double d2 = double.Parse(Console.ReadLine());
                if (d1 == d2) result += $"{d1} = {d2} \n";
                else if (d1 > d2) result += $"{d1} > {d2} \n";
                else result += $"{d1} < {d2} \n";
            }
            Console.WriteLine(result);
        }
    }
}

namespace exercicio_31
{
    class Ex31
    {
        public static void Main(string[]args)
        {
            double s = 0;

            int denom = 1;

            for (int i = 1; i <= 100;i++){
                if (i % 2 != 0){
                    s += i / denom;
                    denom++;
                }
            }
            Console.WriteLine(s);
        }
    }
}

namespace exercicio_30
{
    class Ex30
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Digite o valor de n:");
            int n = int.Parse(Console.ReadLine());

            int r1 = 0, r2 = 0, r3 = 0;

            for(int i = 1; i <= n;i++) r1 += i;
            for(int i = 1; i <= (2*n - 1);i++) {
                if (i % 2 != 0) {
                    r2 -= i;
                    r3 += i;
                 } else r2 += i;
            } 

        }
    }
}

namespace exercicio_29
// Escreva um programa para calcular o valor da s  ́erie, para 5 termos.S = 0 + 1/2! + 2/4! + 3/6! + ...
{
    class Ex29
    {
        public static void Main(string[]args)
        {
            double s = 0;
            int fat = 1;
            int cont = 2;

            for (int i = 1; i <= 6;i++){
                for(int j = 1; j <= cont;j++) fat *= j;
                s += i / fat;
                cont += 2;
            }

            Console.WriteLine(s);
        }
    }
}

namespace exercicio_28
// Fac ̧a um programa que leia um valor N inteiro e positivo, calcule o mostre o valor E, 
// conforme a f  ́ormula a seguir E = 1 + 1/1! + 1/2! + 1/3! + ... + 1/N !
{
    class Ex28
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Digite o valor de N:");
            int n = int.Parse(Console.ReadLine());

            double e = 1;
            int fat = 1;

            for (int i = 1; i <= n;i++){
                for(int j = 1; j <= i;j++) fat *= j;
                e += 1 / fat;
                fat = 1;
            }
            Console.WriteLine(e);
        }
    }
}

namespace exercicio_27
// Em Matem  ́atica, o n  ́umero harm ˆonico designado por H(n) define-se como sendo a soma
// da s  ́erie harm  ́onica: H(n) = 1 + 1/2 + 1/3 + 1/4 + ... + 1/n
{
    class Ex27
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Digite o valor de N:");
            int n = int.Parse(Console.ReadLine());

            double hn = 1;

            for (int i = 2; i <= n;i++){
                hn += 1 / i;
            }
            Console.WriteLine(hn);
        }
    }
}

namespace exercicio_26
// Faca um algoritmo que encontre o primeiro m  ́ultiplo de 11, 13 ou 17 ap  ́os um n  ́umero dado.
{
    class Ex26
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

namespace exercicio_25
// Fac ̧a um programa que some todos os n  ́umeros naturais abaixo de 1000 que s  ̃ao m  ́ultiplos de 3 ou 5.
{
    class Ex25
    {
        public static void Main(string[]args)
        {
            int soma = 0;

            for (int i = 1; i <= 1000;i++){
                if (i % 3 == 0 || i % 5 == 0) soma += i;
            }
            Console.WriteLine(soma);
        }
    }
}

namespace exercicio_24
// escreva um programa que leia um n  ́umero inteiro e calcule a soma de todos os divisores
// desse n  ́umero, com excec ̧  ̃ao dele pr  ́oprio
{
    class Ex24
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i < n;i++){
                if (n % i == 0) soma += i;
            }
            Console.WriteLine(soma);
        }
    }
}

namespace exercicio_23
// Faca um algoritmo que leia um n  ́umero positivo e imprima seus divisores.
{
    class Ex23
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n;i++){
                if (n % i == 0) Console.WriteLine(i);
            }
        }
    }
}

namespace exercicio_22
// Escreva um programa completo que permita a qualquer aluno introduzir, pelo teclado,
// uma sequ ˆencia arbitr  ́aria de notas (v  ́alidas no intervalo de 10 a 20) e que mostre na tela,
// como resultado, a correspondente m  ́edia aritm  ́etica. O n  ́umero de notas com que o aluno
// pretenda efetuar o c  ́alculo n  ̃ao ser  ́a fornecido ao programa, o qual terminar  ́a quando for
// introduzido um valor que n  ̃ao seja v  ́alido como nota de aprovac ̧  ̃ao.
{
    class Ex22
    {
        public static void Main(string[]args)
        {
            double n, soma = 0;
            int alunos = 1;

            do {
                Console.WriteLine($"Digite a nota do {alunos}° aluno:");
                n = int.Parse(Console.ReadLine());
                soma += n;
                alunos++;
            } while (n > 10 && n < 20);

            Console.WriteLine($"a média das notas é: {soma / alunos}");
        }
    }
}

namespace exercicio_21
// Fac ̧a um programa que receba dois n  ́umeros. Calcule e mostre:
// • a soma dos n  ́umeros pares desse intervalo de n  ́umeros, incluindo os n  ́umeros digi-
// tados;
// • a multiplicac ̧  ̃ao dos n  ́umeros  ́ımpares desse intervalo, incluindo os digitados;

{
    class Ex21
    {
        public static void Main(string[]args)
        {
            Console.WriteLine($"Digite o primeiro e segundo número:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int s = 0, m = 1;

            for (int i = n1; i <= n2;i++) if(i % 2 == 0) s += i; else m *= i;

            Console.WriteLine($"A soma dos pares é: {s} \nA multiplicação dos ímpares é: {m}");
        }
    }
}

namespace exercicio_20
// Ler uma sequ ˆencia de n  ́umeros inteiros e determinar se eles s  ̃ao pares ou n  ̃ao. Dever  ́a
// ser informado o n  ́umero de dados lidos e n  ́umero de valores pares. O processo termina
// quando for digitado o n  ́umero 1000.
{
    class Ex20
    {
        public static void Main(string[]args)
        {
            int n1, n2, p = 0, count = 0;

            do {
                Console.WriteLine($"Digite o primeiro e segundo número:");
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());

                for (int i = n1; i <= n2;i++) {
                    if(i % 2 == 0) p++;
                    count++;
                } 
            } while (n1 != 1000 && n2 != 1000);

            Console.WriteLine($"foram lidos {count} número e {p} foram pares!");
        }
    }
}

namespace exercicio_19
// Escreva um algoritmo que leia um n  ́umero inteiro entre 100 e 999 e imprima na sa ́ıda
// cada um dos algarismos que comp  ̃oem o n  ́umero
{
    class Ex19
    {
        public static void Main(string[]args)
        {
            Console.WriteLine($"Digite um número de 100 a 999:");
            int n = int.Parse(Console.ReadLine());

            int c = n / 100;
            int d = n / 10 - (c * 10);
            int u = n - ((c * 100) + (d * 10));

            Console.WriteLine($"unidade: {u}\ndezena:{d}\ncentena:{c}");
        }
    }
}

namespace exercicio_18
// Escreva um algoritmo que leia certa quantidade de n  ́umeros e imprima o maior deles e
// quantas vezes o maior n  ́umero foi lido. A quantidade de n  ́umeros a serem lidos deve ser
// fornecida pelo usu  ́ario.
{
    class Ex18
    {
        public static void Main(string[]args)
        {
            Console.WriteLine($"Digite a quantidade de números lidos:");
            int n = int.Parse(Console.ReadLine());

            int count = 1, bigger = 0, cBigger = 0;

            do {
                Console.WriteLine($"Digite o {count}° valor:");
                int value = int.Parse(Console.ReadLine());
                if (value > bigger) {
                    bigger = value;
                    cBigger = 0;
                }
                if (value == bigger) cBigger++;
                count++;
            }while (count <= n);

            Console.WriteLine($"O maior número foi: {bigger} e foi lido {cBigger} vezes");
        }
    }
}

namespace exercicio_17
// Faça um programa que leia um número inteiro positivo n e calcule a soma dos n primeiros
// números naturais.
{
    class Ex17
    {
        public static void Main(string[]args)
        {
            Console.WriteLine($"Digite o valor de n:");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= n; i++) soma += i;

            Console.WriteLine($"A soma dos {n} primeiros números naturais é: {soma}");
        }
    }
}

namespace exercicio_16
// Faça um programa que leia um número inteiro positivo ímpar N e imprima todos os números
// ímpares de 1 até N em ordem decrescente.
{
    class Ex16
    {
        public static void Main(string[]args)
        {
            Console.WriteLine($"Digite o valor de n (ímpar):");
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i--) if (i % 2 != 0) Console.WriteLine(i);

        }
    }
}

namespace exercicio_15
// Faça um programa que leia um número inteiro positivo ímpar N e imprima todos os números
// ímpares de 1 até N em ordem crescente.
{
    class Ex15
    {
        public static void Main(string[]args)
        {
            Console.WriteLine($"Digite o valor de n (ímpar):");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) if (i % 2 != 0) Console.WriteLine(i);

        }
    }
}

namespace exercicio_14
// Faça um programa que leia um número inteiro positivo par N e imprima todos os números
// pares de 0 até N em ordem decrescente.
{
    class Ex14
    {
        public static void Main(string[]args)
        {
            Console.WriteLine($"Digite o valor de n (par):");
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i--) if (i % 2 == 0) Console.WriteLine(i);

        }
    }
}

namespace exercicio_13
// Faça um programa que leia um número inteiro positivo par N e imprima todos os números
// pares de 0 até N em ordem crescente.
{
    class Ex13
    {
        public static void Main(string[]args)
        {
            Console.WriteLine($"Digite o valor de n (par):");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) if (i % 2 == 0) Console.WriteLine(i);

        }
    }
}

namespace exercicio_12
// Faça um programa que leia um número inteiro positivo N e imprima todos os números
// naturais de 0 até N em ordem decrescente.
{
    class Ex12
    {
        public static void Main(string[]args)
        {
            Console.WriteLine($"Digite o valor de n (par):");
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i--) Console.WriteLine(i);

        }
    }
}

namespace exercicio_11
// Faça um programa que leia um número inteiro positivo N e imprima todos os números
//naturais de 0 até N em ordem crescente.
{
    class Ex11
    {
        public static void Main(string[]args)
        {
            Console.WriteLine($"Digite o valor de n (par):");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) Console.WriteLine(i);

        }
    }
}

namespace exercicio_10
// Faça um programa que calcule e mostre a soma dos 50 primeiros números pares.
{
    class Ex10
    {
        public static void Main(string[]args)
        {
            int soma = 0;

            for (int i = 1; i <= 50; i++) if (i % 2 == 0) soma += i;
            Console.WriteLine(soma);
        }
    }
}

namespace exercicio_09
// Faça um programa que leia um número inteiro N e depois imprima os N primeiros números
// naturais ímpares
{
    class Ex09
    {
        public static void Main(string[]args)
        {
            Console.WriteLine($"Digite o valor de n (ímpar):");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) if (i % 2 != 0) Console.WriteLine(i);
        }
    }
}

namespace exercicio_08
// Escreva um programa que leia 10 números e escreva o menor valor lido e o maior valor lido.
{
    class Ex08
    {
        public static void Main(string[]args)
        {
            int bigger = 0, smaller = 0;
            for(int i = 1; i <= 10; i++){
                Console.WriteLine($"Digite o {i}° valor:");
                int n = int.Parse(Console.ReadLine());

                if (smaller == 0 || smaller > n) smaller = n;
                else if(bigger < n) bigger = n;
            }
        }
    }
}

namespace exercicio_07
// Faça um programa que leia 10 inteiros positivos, ignorando não positivos, e imprima sua
// média.
{
    class Ex07
    {
        public static void Main(string[]args)
        {
            int soma = 0, count = 0;
            for(int i = 1; i <= 10; i++){
                Console.WriteLine($"Digite o {i}° valor:");
                int n = int.Parse(Console.ReadLine());
                if (n > 0) {
                    soma += n;
                    count++;
                }
            }
            Console.WriteLine($"A média é: {soma / count}");
        }
    }
}

namespace exercicio_06
// Faça um programa que leia 10 inteiros e imprima sua média
{
    class Ex06
    {
        public static void Main(string[]args)
        {
            int soma = 0, media = 0;
            for(int i = 1; i <= 10; i++){
                Console.WriteLine($"Digite o {i}° valor:");
                int n = int.Parse(Console.ReadLine());
                soma += n;
                media = soma / i;
            }
            Console.WriteLine($"A média é: {media}");
        }
    }
}

namespace exercicio_05
// Faça um programa que peça ao usuário para digitar 10 valores e some-os.
{
    class Ex05
    {
        public static void Main(string[]args)
        {
            int soma = 0;
            for(int i = 1; i <= 10; i++){
                Console.WriteLine($"Digite o {i}° valor:");
                int n = int.Parse(Console.ReadLine());
                soma += n;
            }
            Console.WriteLine($"A soma é: {soma}");
        }
    }
}

namespace exercicio_04
// Escreva um programa que declare um inteiro, inicialize-o com 0, e incremente-o de 1000 em
// 1000, imprimindo seu valor na tela, até que seu valor seja 100000 (cem mil).
{
    class Ex04
    {
        public static void Main(string[]args)
        {
            int n = 0;
            for(int i = 1; n < 100000; i++){
                n += 1000;
                Console.WriteLine(n);
            }
        }
    }
}

namespace exercicio_03
// Faça um algoritmo utilizando o comando while que mostra uma contagem regressiva na tela,
// iniciando em 10 e terminando em 0. Mostrar uma mensagem ͞ FIM!͟ apó s a contagem.
{
    class Ex03
    {
        public static void Main(string[]args)
        {
            int n = 10;
            while (n >= 0){
                Console.WriteLine(n);
                if (n == 0) Console.WriteLine("FIM!");
                n--;
            }
        }
    }
}

namespace exercicio_02
// Escreva um programa que escreva na tela, de 1 até 100, de 1 em 1, 3 vezes. A primeira vez
// deve usar a estrutura de repetição for, a segunda while, e a terceira do while
{
    class Ex02
    {
        public static void Main(string[]args)
        {
            for (int i = 1; i <= 100; i++) Console.Write($"{i}, ");

            int count = 1;
            while (count <= 100){
                Console.Write(count);
                count++;
            }

            count = 1;
            do {
                Console.Write(count);
                count++;
            } while (count <= 100);
        }
    }
}

namespace exercicio_01
// Faça um programa que determine o mostre os cinco primeiros múltiplos de 3, considerando
// números maiores que 0.
{
    class Ex01
    {
        public static void Main(string[]args)
        {
            int count = 0;
            for (int i = 1; count < 5; i++) {
                if (i % 3 == 0){
                    Console.Write($"{i}, ");
                    count++;
                }
            }
        }
    }
}
*/