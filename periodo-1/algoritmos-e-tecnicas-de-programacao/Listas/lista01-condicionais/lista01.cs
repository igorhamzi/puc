
// 1° lista de exercícios - Comandos Condicionais

using System;
/*
namespace Exercicio_1
{
    class Ex1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double secondNumber = double.Parse(Console.ReadLine());

            if(firstNumber > secondNumber) {
                Console.WriteLine($"{firstNumber}");
            } else {
                Console.WriteLine($"{secondNumber}");
            }

        }
    }
}

namespace Exercicio_2
{
    class Ex2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            double number = double.Parse(Console.ReadLine());

            if(number > 0) {
                Console.WriteLine($"{Math.Sqrt(number)}");
            } else {
                Console.WriteLine("Número inválido");
            }

        }
    }
}

namespace Exercicio_3
{
    class Ex3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            double number = double.Parse(Console.ReadLine());

            if(number < 0) {
                Console.WriteLine($"{number * number}");
            } else {
                Console.WriteLine($"{Math.Sqrt(number)}");
            }

        }
    }
}

namespace Exercicio_4
{
    class Ex4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            double number = double.Parse(Console.ReadLine());

            if(number > 0) {
                Console.WriteLine($"Valor ao quadrado: {number * number} \n" +
                $"Valor da raiz quadrada: {Math.Sqrt(number)}");
            } 
        }
    }
}

namespace Exercicio_5
{
    class Ex5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            double number = double.Parse(Console.ReadLine());

            if(number % 2 == 0) {
                Console.WriteLine("O número é par");
            }else{
                Console.WriteLine("O número é impar");
            }
        }
    }
}

namespace Exercicio_6
{
    class Ex6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double secondNumber = double.Parse(Console.ReadLine());

            if(firstNumber > secondNumber) {
                Console.WriteLine($"O maior número é:{firstNumber} \n" +
                $"A diferença entre eles é: {firstNumber - secondNumber}");
            } else {
                Console.WriteLine($"O maior número é:{secondNumber} \n" +
                $"A diferença entre eles é: {secondNumber - firstNumber}");
            }
        }
    }
}

namespace Exercicio_7
{
    class Ex7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double secondNumber = double.Parse(Console.ReadLine());

            if(firstNumber == secondNumber) {
                Console.WriteLine("Números iguais");
            } else if (firstNumber > secondNumber) {
                Console.WriteLine($"{firstNumber}");
            } else {
                Console.WriteLine($"{secondNumber}");
            }
        }
    }
}

namespace Exercicio_8
{
    class Ex8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            double firstNote = double.Parse(Console.ReadLine());

            if (firstNote > 0.0 && firstNote < 10.0) {

                Console.WriteLine("Digite o segundo número:");
                double secondNote = double.Parse(Console.ReadLine());

                if( secondNote > 0.0 && secondNote < 10.0) {
                Console.WriteLine($"A média das notas é: {(firstNote + secondNote) / 2 }");
                } else {
                Console.WriteLine("Nota inválida");
                }

            }else{
                Console.WriteLine("Nota inválida");
            }
        }
    }
}

namespace Exercicio_9
{
    class Ex9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double loan = double.Parse(Console.ReadLine());

            if(loan > salary * 0.20) {
                Console.WriteLine("Empréstimo não concedido");
            } else {
                Console.WriteLine("Empréstimo concedido");
            }
        }
    }
}

namespace Exercicio_10
{
    class Ex10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            char sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double heigth = double.Parse(Console.ReadLine());

            if(sexo == 'M') {
                Console.WriteLine($"Peso ideaL: {72.7 * heigth - 58}");
            } else {
                Console.WriteLine($"Peso ideaL: {62.1 * heigth - 44.7}");
            }
        }
    }
}

namespace Exercicio_11
{
    class Ex11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um número:");
            string number = (Console.ReadLine());

            int soma = 0;

            for (int i = 0; i < number.Length; i++){
                int v = number[i] - '0';
                soma += v;
            }

            Console.WriteLine($"A soma dos algarismos é: {soma}");

           // https://stackoverflow.com/questions/239103/convert-char-to-int-in-c-sharp
        }
    }
}

namespace Exercicio_12
{
    class Ex12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um número:");
            int number = int.Parse(Console.ReadLine());

            if(number > 0) {
                Math.Log(number);
            } else {
                Console.WriteLine("Número inválido");
            }
        }
    }
}

namespace Exercicio_13
{
    class Ex13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota da prova 1:");
            double test1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da prova 2:");
            double test2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da prova 3:");
            double test3 = double.Parse(Console.ReadLine());

            double mean = test1 + test2 + (test3 * 2) / 4;

            Console.Write($"Sua média foi: {mean} ");

            if(mean > 60) {
                Console.Write($"e você foi APROVADO!!!");
            } else {
                Console.WriteLine("e você não foi aprovado :(");
            }
        }
    }
}

namespace Exercicio_14
{
    class Ex14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota da prova 1:");
            double labNote = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da prova 2:");
            double testNote = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da prova 3:");
            double finalNote = double.Parse(Console.ReadLine());

            double mean = ((labNote * 2) + (testNote * 3) + (finalNote * 5)) / 10;

            switch (mean){
                case < 2.5:
                Console.WriteLine("Reprovado");
                break;

                case < 4.9:
                Console.WriteLine("Recuperação");
                break;

                default:
                Console.WriteLine("Aprovado");
                break;
            }
        }
    }
}

namespace Exercicio_15

{
    class Ex15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de 1 a 7:");
            int number = int.Parse(Console.ReadLine());

            switch (number){
                case 1:
                Console.WriteLine("Domingo");
                break;

                case 2:
                Console.WriteLine("Segunda");
                break;

                case 3:
                Console.WriteLine("Terça");
                break;

                case 4:
                Console.WriteLine("Quarta");
                break;

                case 5:
                Console.WriteLine("Quinta");
                break;

                case 6:
                Console.WriteLine("Sexta");
                break;

                case 7:
                Console.WriteLine("Sábado");
                break;
            }
        }
    }
}

namespace Exercicio_16
{
    class Ex16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de 1 a 12:");
            int number = int.Parse(Console.ReadLine());

            switch (number){
                case 1:
                Console.WriteLine("Janeiro");
                break;

                case 2:
                Console.WriteLine("Fevereiro");
                break;

                case 3:
                Console.WriteLine("Março");
                break;

                case 4:
                Console.WriteLine("Abril");
                break;

                case 5:
                Console.WriteLine("Maio");
                break;

                case 6:
                Console.WriteLine("Junho");
                break;

                case 7:
                Console.WriteLine("Julho");
                break;

                case 8:
                Console.WriteLine("Agosto");
                break;

                case 9:
                Console.WriteLine("Setembro");
                break;

                case 10:
                Console.WriteLine("Outubro");
                break;

                case 11:
                Console.WriteLine("Novembro");
                break;

                case 12:
                Console.WriteLine("Dezembro");
                break;
            }
        }
    }
}

namespace Exercicio_17
{
    class Ex17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da base maior:");
            double biggerBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da base menor:");
            double minorBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura:");
            double height = double.Parse(Console.ReadLine());

             if (biggerBase > 0 && minorBase > 0) {
                double area = (biggerBase + minorBase) * height / 2;
                Console.WriteLine($"O valor da área é: {area}");
             }else{
                Console.WriteLine("Valores tem de ser maiores que 0");
             }
            
        }
    }
}

namespace Exercicio_18
{
    class Ex18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a operação que deseja fazer: \n" +
            "1. Adição \n2. Subtração \n3.Multiplicação \n4.Divisão");
            int operation = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite o primeiro número:");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("E o segundo número:");
            double secondNumber = double.Parse(Console.ReadLine());

            switch (operation) {
                case 1:
                    Console.WriteLine(firstNumber + secondNumber);
                    break;
                case 2:
                    Console.WriteLine(firstNumber - secondNumber);
                    break;
                case 3:
                    Console.WriteLine(firstNumber * secondNumber);
                    break;
                case 4:
                    Console.WriteLine(firstNumber / secondNumber);
                    break;
            }
        }
    }
}

namespace Exercicio_19
{
    class Ex19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int number = int.Parse(Console.ReadLine());

            if (number % 3 == 0) Console.WriteLine($"{number} é divisível por 3");
            if (number % 5 == 0) Console.WriteLine($"{number} é divisível por 5");
        }
    }
}

namespace Exercicio_20
{
    class Ex20
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número:");
            int c = int.Parse(Console.ReadLine());

            if (a < (b + c) && c < (a + b) && b < (a + c)) {
                if (a == b && b == c) {
                    Console.WriteLine("É um triângulo equilátero");
                } else if (a == b || b == c || a == c) {
                    Console.WriteLine("É um triângulo isósceles");
                } else if (a != b && b != c && a != c) {
                    Console.WriteLine("É um triângulo escaleno");
                }
            }else {
                Console.WriteLine("Não é um triângulo");
            }
        }
    }
}

namespace Exercicio_21
{
    class Ex21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a opção: \n" +
            "1- Soma de 2 números. \n" +
            "2- Diferençca entre 2 números (maior pelo menor) \n" +
            "3- Produto entre 2 números. \n" +
            "4- Divisão entre 2 números .");
            int operation = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
            int b = int.Parse(Console.ReadLine());

            switch (operation) {
                case 1:
                    Console.WriteLine(a + b);
                    break;
                case 2:
                    Console.WriteLine((a > b) ? a - b : b - a);
                    break;
                case 3:
                    Console.WriteLine(a * b);
                    break;
                case 4:
                    if (b == 0) {
                        Console.WriteLine("O demonominador não pode ser 0");
                    } else Console.WriteLine((a / b));
                    break;
            }
        }
    }
}

namespace Exercicio_22
{
    class Ex22
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu tempo de trabalho (anos):");
            int workTime = int.Parse(Console.ReadLine());

            bool x = age >= 60 && workTime >= 25;
            bool y = age >= 65 || workTime >= 30;

            if (x || y) {
                Console.WriteLine("Pode aposentar");
            } else {
                Console.WriteLine("Não Pode aposentar");
            }
        }
    }
}

namespace Exercicio_23
{
    class Ex23
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um ano:");
            int y = int.Parse(Console.ReadLine());

            bool x = y % 400 == 0 || y % 4 == 0;

            if (y % 100 != 0 && x) {
                Console.WriteLine($"{y} é um ano bissexto!");
            } else {
                Console.WriteLine($"{y} não é um ano bissexto!");
            }
        }
    }
}

namespace Exercicio_24
{
    class Ex24
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a sigla do seu estado:");
            string loc = (Console.ReadLine()).ToUpper();

            Console.WriteLine("Digite o valor do produto:");
            double value = double.Parse(Console.ReadLine());

            switch (loc) {
                case "MG":
                    Console.WriteLine($"Valor total:{value += value * 0.07}");
                break;

                case "SP":
                    Console.WriteLine($"Valor total:{value += value * 0.12}");
                break;

                case "RJ":
                    Console.WriteLine($"Valor total:{value += value * 0.15}");
                break;

                case "MS":
                    Console.WriteLine($"Valor total: {value += value * 0.08}");
                break;
            }
        }
    }
}

namespace Exercicio_25
{
    class Ex25
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de 'a':");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de 'b':");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de 'b':");
            int c = int.Parse(Console.ReadLine());

            if (a != 0) {
                double delta = Math.Pow(b, 2) - (4 * a * c);
                if (delta < 0) {
                    Console.WriteLine("Não existe Raiz");
                } else if (delta == 0) {
                    Console.WriteLine("Raiz única");
                } else {
                    double xP = (-b + Math.Sqrt(delta)) / (2 * a);
                    double xN = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Raiz positiva: {xP} \n" +
                    $"Raiz negativa {xN}");
                }
            } else Console.WriteLine("Não é equação de segundo grau");
        }
    }
}

namespace Exercicio_26
{
    class Ex26
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de litros:");
            double liters = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite qual foi a distancia percorrida:");
            double distance = double.Parse(Console.ReadLine());

            double consumption = distance / liters;

            if (consumption < 8) Console.WriteLine("Venda o carro!");
            else if (consumption < 14) Console.WriteLine("Econômico!");
            else if (consumption > 12) Console.WriteLine("Super econômico!");
        }
    }
}

namespace Exercicio_27
{
    class Ex27
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a idade do nadador:");
            int age = int.Parse(Console.ReadLine());

            if (5 <= age && age <= 7) Console.WriteLine("Infantil A");
            else if (8 <= age && age <= 10) Console.WriteLine("Infantil B");
            else if (11 <= age && age <= 13) Console.WriteLine("Juvenil A");
            else if (14 <= age && age <= 17) Console.WriteLine("Juvenil B");
            else if (age > 18) Console.WriteLine("Sênior");
        }
    }
}

namespace Exercicio_28
{
    class Ex28
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha qual média gostaria de calcular: \n" +
            "1 - Geométrica.\n" +
            "2. Ponderada \n" +
            "3. Harmônica \n" +
            "4. Aritmética.");
            int media = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            int c = int.Parse(Console.ReadLine());

            double geometrica = Math.Cbrt((a * b * c));
            double ponderada = (a + (2 * b) + (3 * c)) / 6;
            double harmonica = 1 / (1 / a) + (1 / b) + (1 / c);
            double aritmetica = (a + b + c) / 3;

            switch(media) {
                case 1:
                    Console.WriteLine($"A média é: {geometrica}");
                break;

                case 2:
                    Console.WriteLine($"A média é: {ponderada}");
                break;

                case 3:
                    Console.WriteLine($"A média é: {harmonica}");
                break;

                case 4:
                    Console.WriteLine($"A média é: {aritmetica}");
                break;
            }
        }
    }
}

namespace Exercicio_29
{
    class Ex29
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int count = 0;
            int correct = 0;

            while (count < 5) {
                int a = rnd.Next(100);
                int b = rnd.Next(100);
                Console.WriteLine($"Qual o valor da soma: {a} + {b} = ?");
                int response = int.Parse(Console.ReadLine());
                if (response == a + b) correct++;
                count++;
            }
            Console.WriteLine($" Você acertou {correct} de 5 questões!");
        }
    }
}

namespace Exercicio_30
{
    class Ex30
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;

            int count = 0;

            while (count < 3) {
                Console.WriteLine("Digite um valor");
                int number = int.Parse(Console.ReadLine());
                if (number > a && number > b) {
                    a = b;
                    b = c;
                    c = number;
                }else if(number > b && number < c) {
                    a = b;
                    b = number;
                }else {
                    a = number;
                }
                count++;
            }
            Console.WriteLine($"Os números em ordem crescente são: {a}, {b}, {c}");
        }
    }
}

namespace Exercicio_31
{
    class Ex31
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite seu peso:");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura:");
            double altura = double.Parse(Console.ReadLine());

            switch (altura) {
                case < 1.20:
                if(peso < 60) Console.WriteLine("Classificação A");
                else if(peso <= 90) Console.WriteLine("Classificação D");
                else Console.WriteLine("Classificação G");
                break;

                case <= 1.70:
                if(peso < 60) Console.WriteLine("Classificação B");
                else if(peso <= 90) Console.WriteLine("Classificação E");
                else Console.WriteLine("Classificação H");
                break;

                case > 1.70:
                if(peso < 60) Console.WriteLine("Classificação C");
                else if(peso <= 90) Console.WriteLine("Classificação F");
                else Console.WriteLine("Classificação I");
                break;
                
            }
        }
    }
}

namespace Exercicio_32
{
    class Ex32
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o código do produto:");
            int produto = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do pedido:");
            int quantidade = int.Parse(Console.ReadLine());

            switch (produto) {
                case 100:
                Console.WriteLine($"O valor a ser pago é: R${quantidade * 1.20}");
                break;

                case 101:
                Console.WriteLine($"O valor a ser pago é: R${quantidade * 1.30}");
                break;

                case 102:
                Console.WriteLine($"O valor a ser pago é: R${quantidade * 1.50}");
                break;

                case 103:
                Console.WriteLine($"O valor a ser pago é: R${quantidade * 1.20}");
                break;

                case 104:
                Console.WriteLine($"O valor a ser pago é: R${quantidade * 1.70}");
                break;

                case 105:
                Console.WriteLine($"O valor a ser pago é: R${quantidade * 2.20}");
                break;

                case 106:
                Console.WriteLine($"O valor a ser pago é: R${quantidade * 1}");
                break;      
            }
        }
    }
}

namespace Exercicio_33
{
    class Ex33
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o código do produto:");
            double oldPrice = double.Parse(Console.ReadLine());

            switch (oldPrice) {
                case < 50:
                Console.WriteLine($"O novo preço é: R${oldPrice + (oldPrice * 0.05)}");
                break;

                case < 100:
                Console.WriteLine($"O novo preço é: R${oldPrice + (oldPrice * 0.10)}");
                break;

                case > 100:
                Console.WriteLine($"O novo preço é: R${oldPrice + (oldPrice * 0.15)}");
                break; 
            }
        }
    }
}

namespace Exercicio_34
{
    class Ex34
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a nota do aluno:");
            double nota = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de faltas do aluno:");
            int faltas = int.Parse(Console.ReadLine());

            switch (nota) {
                case <= 3.9:
                if(faltas < 20) Console.WriteLine("Conceito A");
                else Console.WriteLine("Conceito B");
                break;

                case <= 4.9:
                if(faltas < 20) Console.WriteLine("Conceito B");
                else Console.WriteLine("Conceito C");
                break;

                case <= 7.4:
                if(faltas < 20) Console.WriteLine("Conceito C");
                else Console.WriteLine("Conceito D");
                break;

                case <= 8.9:
                if(faltas < 20) Console.WriteLine("Conceito D");
                else Console.WriteLine("Conceito E");
                break;

                case <= 10:
                if(faltas < 20) Console.WriteLine("Conceito E");
                else Console.WriteLine("Conceito E");
                break;
            }
        }
    }
}

namespace Exercicio_35
{
    class Ex35
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o dia do ano:");
            int days = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o mês do ano:");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano:");
            int year = int.Parse(Console.ReadLine());

            if (month > 0 || month < 12) {
                if (days == 29 && month == 2) {
                    bool x = year % 400 == 0 || year % 4 == 0;
                    if (year % 100 != 0 && x) {
                        Console.WriteLine($"Data inválida! {year} é um ano bissexto.");
                    } else {
                        Console.WriteLine($"Data {days}/{month}/{year} é válida!");
                    }
                } else Console.WriteLine($"Data {days}/{month}/{year} válida!!");
            }else Console.WriteLine($"Data inválida, o mês {month} não existe!");

        }
    }
}

namespace Exercicio_36
{
    class Ex36
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor de venda:");
            double valueOfSale = double.Parse(Console.ReadLine());

            switch (valueOfSale){
                case >= 100000.00:
                Console.WriteLine($"O valor de comissão é {700 + valueOfSale * 0.16}");
                break;

                case >= 80000.00:
                Console.WriteLine($"O valor de comissão é {650 + valueOfSale * 0.14}");
                break;

                case >= 60000.00:
                Console.WriteLine($"O valor de comissão é {600 + valueOfSale * 0.14}");
                break;

                case >= 40000.00:
                Console.WriteLine($"O valor de comissão é {550 + valueOfSale * 0.14}");
                break;

                case >= 20000.00:
                Console.WriteLine(500 + valueOfSale * 0.14);
                break;

                case < 20000.00:
                Console.WriteLine(450 + valueOfSale * 0.14);
                break;
            }
        }
    }
}

namespace Exercicio_37
{
    class Ex37
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o horário de chegada:");
            string arrivalTime = (Console.ReadLine());
            int hora_c = int.Parse(arrivalTime.Substring(0, 2));
            int minutos_c = int.Parse(arrivalTime.Substring(3));

            Console.WriteLine("Digite o horário de saída:");
            string exitTime = (Console.ReadLine());
            int hora_s = int.Parse(exitTime.Substring(0, 2));
            int minutos_s = int.Parse(exitTime.Substring(3));

            int horasTotais = 0;
            int minutosTotais = 0;

            if (hora_s > hora_c) horasTotais = hora_s - hora_c;
            else if (hora_s == 0) horasTotais = 24 - hora_c;
            else horasTotais = (24 - hora_c) + hora_s;

            
            if (minutos_c == 0) minutosTotais = minutos_s;
            else if (((60 - minutos_c) + minutos_s) > 60){
                horasTotais++;
                minutosTotais = (60 - minutos_c) + minutos_s - 60;
            }else if (minutosTotais != 0) {
                minutosTotais = (60 - minutos_c) + minutos_s;
            }

            Console.WriteLine(horasTotais);
            Console.WriteLine(minutosTotais);

            switch (horasTotais) {
                case 0:
                Console.WriteLine("Valor: R$ 1,00");
                break;

                case 1:
                if (minutosTotais > 0) Console.WriteLine("Valor: R$ 2,00");
                else Console.WriteLine("Valor: R$ 1,00");
                break;

                case 2:
                if (minutosTotais > 0) Console.WriteLine("Valor: R$ 3,40");
                else Console.WriteLine("Valor: R$ 2,00");
                break;

                case 3:
                if (minutosTotais > 0) Console.WriteLine("Valor: R$ 4,80");
                else Console.WriteLine("Valor: R$ 3,40");
                break;

                case 4:
                if (minutosTotais > 0) Console.WriteLine("Valor: R$ 6,80");
                else Console.WriteLine("Valor: R$ 4,80");
                break;

                case >= 5:
                double value = 4.80 + (2.00 * horasTotais);
                if (minutosTotais == 0) Console.WriteLine($"Valor: R$ {value}");
                else Console.WriteLine($"Valor: R$ {value + 2.00}");
                break;
            }
        }
    }
}

namespace Exercicio_38
{
    class Ex38
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o dia da data de nascimento:");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o mês da data de nascimento:");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano da data de nascimento:");
            int year = int.Parse(Console.ReadLine());

            switch (day){
                case < 0:
                    Console.WriteLine("Dia inválido");
                break;

                case > 31:
                    Console.WriteLine("Dia inválido");
                break;

                case 31:
                    if(month == 4 || month == 6 || month == 9 || month == 11) {
                        Console.WriteLine("Dia inválido");
                    }
                break;
            }

            switch (month){
                case < 0:
                    Console.WriteLine("mês inválido");
                break;

                case > 12:
                    Console.WriteLine("mês inválido");
                break;

                case 2:
                    if (day == 28) {
                        bool x = year % 400 == 0 || year % 4 == 0;
                        if (year % 100 != 0 && x) {
                            Console.WriteLine($"Dia inválido! {year} é um ano bissexto.");
                        }
                    }
                break;
            }

            switch (year){
                case > 2023:
                    Console.WriteLine("ano inválido");
                break;
            }
        }
    }
}

namespace Exercicio_39
{
    class Ex39
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor atual do salário:");
            int atualSalary = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de anos trabalhados na empresa:");
            int workYears = int.Parse(Console.ReadLine());

            switch (atualSalary) {
                case <= 500:
                    if (workYears < 1) Console.WriteLine("Não tem direito a bônus");
                    else Console.WriteLine(atualSalary + (atualSalary * 0.25));
                break;

                case <= 1000:
                    if (workYears > 1 && workYears < 3) {
                        Console.WriteLine(atualSalary + (atualSalary * 0.20) + 100);
                    }
                break;

                case <= 1500:
                    if (workYears > 4 && workYears < 6) {
                        Console.WriteLine(atualSalary + (atualSalary * 0.15) + 200);
                    }
                break;

                case <= 2000:
                    if (workYears > 7 && workYears < 10) {
                        Console.WriteLine(atualSalary + (atualSalary * 0.10) + 300);
                    }
                break;

                case > 2000:
                    if (workYears > 10) Console.WriteLine(atualSalary + 500);
                break;
            }
        }
    }
}

namespace Exercicio_40
{
    class Ex40
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o custo de fábrica:");
            double cost = double.Parse(Console.ReadLine());

            switch (cost) {
                case <= 12000:
                    Console.WriteLine(cost + (cost * 0.05));
                break;

                case <= 25000:
                    Console.WriteLine(cost + (cost * 0.10) + (cost * 0.15));
                break;

                case > 25000:
                    Console.WriteLine(cost + (cost * 0.15) + (cost * 0.20));
                break;
            }
        }
    }
}

namespace Exercicio_41
{
    class Ex41
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite seu peso:");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura:");
            double alt = double.Parse(Console.ReadLine());

            double imc = peso / Math.Pow(alt, 2);
            Console.WriteLine(imc);
            switch (imc) {
                case <= 18.5:
                    Console.WriteLine("Abaixo do peso");
                break;

                case <= 24.9:
                    Console.WriteLine("Saudável");
                break;

                case <= 29.9:
                    Console.WriteLine("Peso em excesso");
                break;

                case <= 34.9:
                    Console.WriteLine("Obesidade grau 1");
                break;

                case <= 39.9:
                    Console.WriteLine("Obesidade grau 2 (severa)");
                break;

                case >= 40:
                    Console.WriteLine("Obesidade grau 3 (mórbida)");
                break;
            }
        }
    }
}
