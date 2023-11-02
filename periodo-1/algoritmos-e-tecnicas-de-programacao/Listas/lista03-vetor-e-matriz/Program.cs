
// 3° lista de exercícios(64) - Vetores e Matrizes

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Net.Http.Headers;
using System.Runtime.Intrinsics.Arm;

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

namespace exercicio_14
{
    class Ex14
    {
        public static void Main(string[]args)
        {
            int[] array = new int [10];

            for (int i = 0; i < array.Length; i++){
                Console.WriteLine($"Digite a nota do {i+1}° aluno:");
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < array.Length; i++){
                for (int j = 0; j < i; j++){
                    if (array[j] == array[i]){
                        Console.WriteLine($"valor {array[i]} repetido nas posições: {i + 1} e {j + 1}");
                    }
                }
            }

        }
    }
}

namespace exercicio_15
{
    class Ex15
    {
        public static void Main(string[]args)
        {
            int[] array = new int [5];

            for (int i = 0; i < array.Length; i++){
                Console.WriteLine($"Digite a nota do {i+1}° aluno:");
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < array.Length; i++){
                for (int j = 0; j < i; j++){
                    if (array[j] == array[i]){
                        array[j] = 0;
                        array[i] = 0;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++) Console.WriteLine($"{array[i]}, ");
        }
    }
}

namespace exercicio_16
{
    class Ex16
    {
        public static void Main(string[]args)
        {
            double[] array = new double [5];

            for (int i = 0; i < array.Length; i++){
                Console.WriteLine($"Digite o valor da {i+1}° posição:");
                array[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Digite o valor do código:");
            int c = int.Parse(Console.ReadLine());

            switch (c) {
                case 1:
                for (int i = 0; i < array.Length; i++) Console.WriteLine($"{array[i]}, ");
                break;

                case 2:
                for (int i = array.Length - 1; i >= 0; i--) Console.WriteLine($"{array[i]}, ");
                break;
            }

            if (c != 0 && c != 1 && c != 1) Console.WriteLine("O código é inválido");

        }
    }
}

namespace exercicio_17
{
    class Ex17
    {
        public static void Main(string[]args)
        {
            double[] array = new double [5];

            for (int i = 0; i < array.Length; i++){
                Console.WriteLine($"Digite o valor da {i+1}° posição:");
                array[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++) if(array[i] < 0) array[i] = 0;
        }
    }
}

namespace exercicio_18
{
    class Ex18
    {
        public static void Main(string[]args)
        {
            double[] array = new double [10];

            for (int i = 0; i < array.Length; i++){
                Console.WriteLine($"Digite o valor da {i+1}° posição:");
                array[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Informe um valor inteiro:");
            int x = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < array.Length; i++) if(array[i] % x == 0) count++;

            Console.WriteLine($"{count}");
        }
    }
}

namespace exercicio_19
{
    class Ex19
    {
        public static void Main(string[]args)
        {
            double[] array = new double [50];

            for (int i = 0; i < array.Length; i++){
                int p = i + 1;
                array[i] = (p + 5 * p) % (p + 1);
            }

            for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]}, ");
        }
    }
}

namespace exercicio_20
{
    class Ex20
    {
        public static void Main(string[]args)
        {
            int[] array = new int [5];

            int countImpares = 0;

            for (int i = 0; i < array.Length; i++){
                do{
                    Console.WriteLine($"Digite o valor (inteiro) da {i+1}° posição:");
                    array[i] = int.Parse(Console.ReadLine());
                    if(array[i] % 2 != 0) countImpares++;
                }while (array[i] < 0 || array[i] > 50);
            }

            int[] impares = new int [countImpares];

            for (int i = 0, j = 0; i < array.Length; i++){
                if(array[i] % 2 != 0){
                    impares[j]= array[i];
                    j++;
                }  
            }

            for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]}, ");
            Console.WriteLine($"");
            for (int i = 0; i < impares.Length; i++) Console.Write($"{impares[i]}, ");
        }
    }
}

namespace exercicio_31
{
    class Ex31
    {
        public static void Main(string[]args)
        {
            int[] veta = new int[10];
            int[] vetb = new int[10];
            Random rand = new Random();
        
            for(int i = 0;i<veta.Length;i++){
                veta[i] = rand.Next(1, 20);
                vetb[i] = rand.Next(1, 20);
            }
        
            int[] vetc = new int[20];
            int cont = 0;
        
            for(int i=0;i<veta.Length;i++){
                vetc[cont] = veta[i];
                vetc[cont+1] = vetb[i];
                cont+=2;
            }
        
            for(int i = 0;i<vetc.Length;i++){
                for(int j = i+1;j<vetc.Length;j++){
                    if(vetc[i]==vetc[j]){
                        vetc[i] = 0;
                    }
                }
            }
            for (int i = 0; i < vetc.Length; i++) Console.Write($"{vetc[i]}, ");
        }
    }
}

namespace exercicio_21
{
    class Ex21
    {
        public static void Main(string[]args)
        {
            int[] a = new int [10];
            int[] b = new int [10];
            int[] c = new int [10];

            for (int i = 0; i < a.Length; i++){
                Console.WriteLine($"Digite o valor (inteiro) da {i+1}° posição do vetor A:");
                Console.WriteLine($"Digite o valor (inteiro) da {i+1}° posição do vetor B:");
                a[i] = int.Parse(Console.ReadLine());
                b[i] = int.Parse(Console.ReadLine());
                c[i] = a[i] - b[i];
            }

            for (int i = 0; i < c.Length; i++) Console.Write($"{c[i]}, ");

        }
    }
}

namespace exercicio_22
{
    class Ex22
    {
        public static void Main(string[]args)
        {
            int[] a = new int [5];
            int[] b = new int [5];

            for (int i = 0; i < a.Length; i++){
                Console.WriteLine($"Digite o valor (inteiro) da {i+1}° posição do vetor A:");
                Console.WriteLine($"Digite o valor (inteiro) da {i+1}° posição do vetor B:");
                a[i] = int.Parse(Console.ReadLine());
                b[i] = int.Parse(Console.ReadLine());
            }

            int[] c = new int [10];

            for (int i = 0, j = 0; i < c.Length; i++){
                if (i % 2 == 0) c[i] = a[j];
                else {
                    c[i] = b[j];
                    j++;
                }
            }

            for (int i = 0; i < c.Length; i++) Console.Write($"{c[i]}, ");
        }
    }
}

namespace exercicio_23
{
    class Ex23
    {
        public static void Main(string[]args)
        {
            float[] a = new float [5];
            float[] b = new float [5];

            for (int i = 0; i < a.Length; i++){
                Console.WriteLine($"Digite o valor (inteiro) da {i+1}° posição do vetor A:");
                Console.WriteLine($"Digite o valor (inteiro) da {i+1}° posição do vetor B:");
                a[i] = float.Parse(Console.ReadLine());
                b[i] = float.Parse(Console.ReadLine());
            }

            float r = 0;

            for (int i = 0; i < a.Length; i++) r += a[i] * b[i];

            for (int i = 0; i < a.Length; i++) Console.Write($"{a[i]}, ");
            Console.WriteLine(" ");
            for (int i = 0; i < b.Length; i++) Console.Write($"{b[i]}, ");
            Console.WriteLine(" ");
            Console.Write(r);
        }
    }
}

namespace exercicio_24
{
    class Ex24
    {
        public static void Main(string[]args)
        {

            float smaller = 0, height = 0;

            for (int i = 0, j = 0; i < 10; i++){
                float[] b = new float [2];
                Console.WriteLine($"Digite o número do {i+1} aluno:");
                b[j] = float.Parse(Console.ReadLine());
                Console.WriteLine($"Digite a altura do {i+1} aluno:");
                b[j+1] = float.Parse(Console.ReadLine());

                if (height == 0) {
                    smaller = b[j];
                    height = b[j+1];
                } else if (height > b[j+1]) {
                    smaller = b[j];
                    height = b[j+1];
                }
            }

            Console.Write($"O aluno mais baixo é de número{smaller} e altura {height}");
        }
    }
}

namespace exercicio_25
{
    class Ex25
    {
        public static void Main(string[]args)
        {
            int[] array = new int [100];

            for (int i = 0, j = 0; i < array.Length; j++){
                if (j % 7 != 0 && j % 10 != 7){
                    array[i] = j;
                    i++;
                }
            }

            for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]}, ");
        }
    }
}

namespace exercicio_26
{
    class Ex26
    {
        public static void Main(string[]args)
        {
            int[] v = new int [10];

            int m = 0;
            double somatorio = 0;

            for (int i = 0; i < v.Length; i++){
                Console.WriteLine($"Digite o valor (inteiro) da {i+1}° posição do vetor V:");
                v[i] = int.Parse(Console.ReadLine());
                m += v[i];
            }

            for (int j = 0; j < v.Length; j++){
                for (int i = 1; j <= v[j]; i++) {
                    int x = v[i] - (m / v.Length);
                    somatorio += Math.Pow(x, 2);
                }
            }

            double desvioPadrao = 0;



            
            
            for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]}, ");
        }
    }
}

namespace exercicio_27
{
    class Ex27
    {
        public static void Main(string[]args)
        {
            int[] array = new int [10];


            for (int i = 0; i < array.Length; i++){
                Console.WriteLine($"Digite o valor (inteiro) da {i+1}° posição do vetor V:");
                array[i] = int.Parse(Console.ReadLine());
            }

            bool primo = true;

            for (int i = 0; i < array.Length; i++){
                for (int j = 2; j < array[i]; j++){
                    if ( array[i] % j == 0 ) primo = false;
                }
                if (primo) Console.WriteLine($"{array[i]} posição: {i+1}");
                else primo = true;
            }
            
            for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]}, ");
        }
    }
}

namespace exercicio_28
{
    class Ex28
    {
        public static void Main(string[]args)
        {
            int[] v = new int [10];


            for (int i = 0; i < v.Length; i++){
                Console.WriteLine($"Digite o valor (inteiro) da {i+1}° posição do vetor V:");
                v[i] = int.Parse(Console.ReadLine());
            }

            int[] v1 = new int [10];
            int[] v2 = new int [10];

            for (int i = 0, j = 0, h = 0; i < v.Length; i++){
                if (v[i] % 2 == 0){
                    v1[j] = v[i];
                    j++;
                } else {
                    v2[h] = v[i];
                    h++;
                }
            }
            
            for (int i = 0; i < v.Length; i++) Console.Write($"{v[i]}, ");
            Console.WriteLine($"");
            for (int i = 0; i < v1.Length; i++) Console.Write($"{v1[i]}, ");
            Console.WriteLine($"");
            for (int i = 0; i < v2.Length; i++) Console.Write($"{v2[i]}, ");
        }
    }
}

namespace exercicio_29
{
    class Ex29
    {
        public static void Main(string[]args)
        {
            int[] array = new int [6];


            for (int i = 0; i < array.Length; i++){
                Console.WriteLine($"Digite o valor (inteiro) da {i+1}° posição do vetor V:");
                array[i] = int.Parse(Console.ReadLine());
            }

            int somaPares = 0, countImpares = 0, countPares = 0;

            for (int i = 0; i < array.Length; i++){
                if (array[i] % 2 == 0){
                    countPares++;
                    somaPares += array[i];
                }
                else countImpares++;
            }

            int[] impares = new int [countImpares];
            int[] pares = new int [countPares];

            for (int i = 0, h = 0, j = 0; i < array.Length; i++){
                if (array[i] % 2 == 0){
                    pares[h] = array[i];
                    h++;
                } else{
                    impares[j] = array[i];
                    j++;
                }
            }

            Console.Write($"numeros pares digitados: ");
            for (int i = 0; i < pares.Length; i++) Console.Write($"{pares[i]}, ");
            Console.WriteLine($"");
            Console.WriteLine($"soma dos numeros pares digitados: {somaPares}");
            Console.Write($"numeros impares digitados: ");
            for (int i = 0; i < impares.Length; i++) Console.Write($"{impares[i]}, ");
            Console.WriteLine($"");
            Console.WriteLine($"quantidade de numeros  impares digitados: {countImpares}");
        }
    }
}

namespace exercicio_30
{
    class Ex30
    {
        public static void Main(string[]args)
        {
            int[] a1 = new int [10];
            int[] a2 = new int [10];

            for (int i = 0; i < a1.Length; i++){
                Console.WriteLine($"Digite o valor (inteiro) da {i+1}° posição do vetor V:");
                a1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < a2.Length; i++){
                Console.WriteLine($"Digite o valor (inteiro) da {i+1}° posição do vetor V:");
                a2[i] = int.Parse(Console.ReadLine());
            }

            int countEquals = 0;

            for (int i = 0; i < a1.Length; i++){
                for (int j = 0; j < a2.Length; j++){
                    if (a1[i] == a2[j]) countEquals++;
                }
            }

            int[] equals = new int [countEquals];

            Console.WriteLine($"{countEquals}");

            for (int i = 0, h = 0; i < a1.Length; i++){
                for (int j = 0; j < a2.Length; j++){
                    if (a1[i] == a2[j]){
                        equals[h] = a1[i];
                        h++;
                    } 
                }
            }

            for (int i = 0; i < a1.Length; i++) Console.Write($"{a1[i]}, ");
            Console.WriteLine($"");
            for (int i = 0; i < a2.Length; i++) Console.Write($"{a2[i]}, ");
            Console.WriteLine($"");
            for (int i = 0; i < equals.Length; i++) Console.Write($"{equals[i]}, ");
        }
    }
}

namespace exercicio_31
{
    class Ex31
    {
        public static void Main(string[] args)
        {
        int[] vet1 = new int[5];
        int[] vet2 = new int[5];
        int[] uniao = new int[10];
      
        for(int i = 0; i < vet1.Length; i++)
        {
            Console.WriteLine("Digite um valor para o primeiro vetor");
            vet1[i] = int.Parse(Console.ReadLine());
            
        }
        for (int i = 0; i < vet2.Length; i++)
        {
            Console.WriteLine("Digite um valor para o segundo vetor");
            vet2[i] = int.Parse(Console.ReadLine());

        }
        int cont = 0;
        for (int i = 0; i < vet1.Length; i++)
        {
            bool equals = false;
            for (int j = i + 1; j < vet1.Length; j++)
            {
                if (vet1[i] == vet1[j])
                {
                    equals = true;
                }
            }
            if(equals == false)
            {
                uniao[cont] = vet1[i];
                cont++;
            }
        }

        for (int i = 0; i < vet2.Length; i++)
        {
            bool equals = false;
            for (int j = i + 1; j < vet2.Length; j++)
            {
                if (vet2[i] == vet2[j])
                {
                    equals = true;
                }
            }
            bool equals2 = false;
            for(int k = 0; k< uniao.Length; k++)
            {
                if (uniao[k] == vet2[i])
                {
                    equals2 = true;
                }
            }
            if (equals == false && equals2 == false)
            {
                uniao[cont] = vet2[i];
                cont++;
            }
        }

        for (int i = 0; i < cont; i++)
        {
            Console.WriteLine(uniao[i]);
        }
        }
    }
}

namespace exercicio_32
{
    class Ex32
    {
        public static void Main(string[] args)
        {
            int[] x = new int[5];
            int[] y = new int[5];

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"Digite o valor da {i + 1}° posição de 'a':");
                x[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine($"Digite o valor da {i + 1}° posição de 'b':");
                y[i] = int.Parse(Console.ReadLine());
            }

            int[] sum = new int[5];
            int[] mult = new int[5];
            int[] difference = new int[5];
            int[] inter = new int[5];

            int[] unity = new int[10];

            int counterInter = 0, counterDifference = 0, counterUnity = 5;

            for (int i = 0; i < x.Length; i++)
            {
                sum[i] = x[i] + y[i];
                mult[i] = x[i] * y[i];

                bool key = true;
                for (int j = i + 1; j < x.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        inter[counterInter] = x[i];
                        counterInter++;
                        key = false;
                    }
                }
                if (key == true)
                {
                    difference[counterDifference] = x[i];
                }
                if (i < 5) unity[i] = x[i];
            }

            for (int i = 0; i < y.Length; i++)
            {
                bool equals = false;
                for (int j = 0; j < 5; j++) if (unity[j] == y[i]) equals = true;
                if (equals == false)
                {
                    unity[counterUnity] = y[i];
                    counterUnity++;
                }
            }

            Console.WriteLine("SOMA:");
            for (int i = 0; i < sum.Length; i++) Console.Write($"{sum[i]}, ");
            Console.WriteLine("\n");
            Console.WriteLine("MULTIPLICAÇÃO:");
            for (int i = 0; i < mult.Length; i++) Console.Write($"{mult[i]}, ");
            Console.WriteLine("\n");
            Console.WriteLine("DIFERENÇA:");
            for (int i = 0; i < difference.Length; i++) Console.Write($"{difference[i]}, ");
            Console.WriteLine("\n");
            Console.WriteLine("INTER:");
            for (int i = 0; i < inter.Length; i++) Console.Write($"{inter[i]}, ");
            Console.WriteLine("\n");
            Console.WriteLine("UNIÃO:");
            for (int i = 0; i < unity.Length; i++) Console.Write($"{unity[i]}, ");
        }
    }
}

namespace exercicio_33
{
    class Ex33
    {
        public static void Main(string[] args)
        {
            int[] x = new int[15];

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"Digite o valor da {i + 1}° /15 posição:");
                x[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("X (ANTES): ");
            for (int i = 0; i < x.Length; i++) Console.Write($"{x[i]}, ");

            for (int i = 0, j = x.Length - 1; i < j; i++)
            {
                if (x[j] == 0)j--;
                if (x[i] == 0)
                {
                    x[i] = x[j];
                    x[j] = 0;
                    j--;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("X: ");
            for (int i = 0; i < x.Length; i++) Console.Write($"{x[i]}, ");
        }
    }
}

namespace exercicio_34
{
    class Ex34
    {
        public static void Main(string[] args)
        {
            int[] x = new int[10];

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"Digite o valor da {i + 1}° /15 posição:");
                int n = int.Parse(Console.ReadLine());

                for (int j = 0; j < i + 1; j++){
                    if (x[j] == n){
                        Console.WriteLine($"Esse valor ja existe no array, digite outro valor para a {i + 1}° /15 posição:");
                        n = int.Parse(Console.ReadLine());
                        j = 0;
                    }
                }

                x[i] = n;
            }

            for (int i = 0; i < x.Length; i++) Console.Write($"{x[i]}, ");
        }
    }
}

namespace exercicio_35
{
    class Ex35
    {
        public static void Main(string[] args)
        {

            double[] x = new double[10];

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"Digite o valor da {i + 1}° /10 posição:");
                x[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < x.Length - 1; i++){
                if (x[i] > x[i+1]){
                    double y = x[i];
                    x[i] = x[i+1];
                    x[i+1] = y;
                }
            }

            for (int i = 0; i < x.Length; i++) Console.Write($"{x[i]}, ");
        }
    }
}

namespace exercicio_36
{
    class Ex36
    {
        public static void Main(string[] args)
        {

            double[] x = new double[10];

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"Digite o valor da {i + 1}° /10 posição:");
                x[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < x.Length - 1; i++){
                if (x[i] > x[i+1]){
                    double y = x[i];
                    x[i] = x[i+1];
                    x[i+1] = y;
                }
            }

            for (int i = 0; i < x.Length; i++) Console.Write($"{x[i]}, ");
        }
    }
}

namespace exercicio_37
{
    class Ex37
    {
        public static void Main(string[] args)
        {

            int[] x = new int[11];

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"Digite o valor da {i + 1}° /11 posição:");
                x[i] = int.Parse(Console.ReadLine());
            }

            for (int i = x.Length - 1, j = 5; i > j; i--, j++){
                int z = x[i];
                x[i] = x[j];
                x[j] = z;
            }

            for (int i = 0; i < x.Length; i++) Console.Write($"{x[i]}, ");
        }
    }
}

namespace exercicio_38
{
    class Ex38
    {
        public static void Main(string[] args)
        {

            int[] x = new int[10];

            Console.WriteLine($"Digite o valor da {1}° /10 posição:");
            int n  = int.Parse(Console.ReadLine());

            for (int i = 1; i < x.Length; i++)
            {
                Console.WriteLine($"Digite o valor da {i + 1}° /10 posição:");
                x[i]  = int.Parse(Console.ReadLine());
                for (int j = 0; j <= i; j++){
                    if (x[i] < x[j]) {
                        int m = 
                    }
                }
            }


            for (int i = 0; i < x.Length; i++) Console.Write($"{x[i]}, ");
        }
    }
}

// MATRIZ 

namespace exercicio_01
{
    class Ex01
    {
        public static void Main(string[] args)
        {

            int[,] mat = new int[4,4];

            for (int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    Console.WriteLine($"Digite o valor da posição{i},{j}:");
                    mat[i,j]  = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    if(mat[i,j] > 10) Console.Write($"{mat[i,j]}  ");
                }
            }
        }
    }
}

namespace exercicio_02
{
    class Ex02
    {
        public static void Main(string[] args)
        {

            int[,] mat = new int[5,5];

            for (int i = 0; i < 5; i++){
                for(int j = 0; j < 5; j++){
                    Console.WriteLine($"Digite o valor da posição{i},{j}:");
                    mat[i,j]  = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i <= 5; i++){
                for(int j = 0; j <= 5; j++){
                    if(i == j) mat[i,j] = 1;
                    else mat[i,j] = 0;
                }
            }

            for (int i = 0; i < 5; i++){
                for(int j = 0; j < 5; j++){
                    Console.Write($"{mat[i,j]}  ");
                }
                Console.Write($"\n");
            }
        }
    }
}

namespace exercicio_03
{
    class Ex03
    {
        public static void Main(string[] args)
        {

            int[,] mat = new int[4,4];

            for (int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++) mat[i,j] = i * j;
            }

            for (int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    Console.Write($"{mat[i,j]}  ");
                }
                Console.Write($"\n");
            }
        }
    }
}

namespace exercicio_04
{
    class Ex04
    {
        public static void Main(string[] args)
        {

            int[,] mat = new int[4,4];

            for (int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    Console.WriteLine($"Digite o valor da posição{i},{j}:");
                    mat[i,j]  = int.Parse(Console.ReadLine());
                }
            }

            int bigger = 0, row = 0, colum = 0;

            for (int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    if (bigger < mat[i,j]){
                        bigger = mat[i,j];
                        row = i;
                        colum = j;
                    }
                }
            }

            Console.WriteLine($"Linha: {row}, coluna: {colum}");
        }
    }
}

namespace exercicio_05
{
    class Ex05
    {
        public static void Main(string[] args)
        {

            int[,] mat = new int[5,5];

            Console.WriteLine($"Digite o valor de X:");
            int x  = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++){
                for(int j = 0; j < 5; j++){
                    Console.WriteLine($"Digite o valor da posição {i},{j}:");
                    mat[i,j]  = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    if (x == mat[i,j]){
                        Console.WriteLine($"{x} encontrado na linha {i} e coluna {j}");
                    }
                }
            }
        }
    }
}

namespace exercicio_06
{
    class Ex06
    {
        public static void Main(string[] args)
        {

            int[,] mat1 = new int[5,5];
            int[,] mat2 = new int[5,5];


            for (int i = 0; i < 5; i++){
                for(int j = 0; j < 5; j++){
                    Console.WriteLine($"Digite o valor da posição {i},{j} da matriz 1");
                    mat1[i,j]  = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Digite o valor da posição {i},{j} da matriz 2");
                    mat2[i,j]  = int.Parse(Console.ReadLine());
                }
            }

            int[,] mat3 = new int[5,5];

            for (int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    if (mat1[i,j] > mat2[i,j]) mat3[i,j] = mat1[i,j];
                    else mat3[i,j] = mat2[i,j];
                }
            }

            for (int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    Console.Write($"{mat3[i,j]}  ");
                }
                Console.Write($"\n");
            }
        }
    }
}

namespace exercicio_07
{
    class Ex07
    {
        public static void Main(string[] args)
        {

            double[,] mat = new double[5,5];


            for (int i = 0; i < 5; i++){
                for(int j = 0; j < 5; j++){
                    if(i < j) mat[i,j] = (2 * i) + (7 * j);
                    else if(i == j) mat[i,j] = Math.Pow(3 * i, 2) - 1;
                    else mat[i,j] = Math.Pow(4 * i, 2) - Math.Pow(5 * j, 2)  + 1;
                }
            }

            for (int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    Console.Write($"{mat[i,j]}  ");
                }
                Console.Write($"\n");
            }
        }
    }
}

namespace exercicio_08
{
    class Ex08
    {
        public static void Main(string[] args)
        {

            int[,] mat = new int[3,3];

            for (int i = 0; i < 5; i++){
                for(int j = 0; j < 5; j++){
                    Console.WriteLine($"Digite o valor da posição{i},{j}:");
                    mat[i,j]  = int.Parse(Console.ReadLine());
                }
            }

            int soma = 0;

            for (int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    if(i == j) soma += mat[i-1,j];
                }
            }

            Console.Write($"{soma}");
        }
    }
}

namespace exercicio_09
{
    class Ex09
    {
        public static void Main(string[] args)
        {

            int[,] mat = new int[3,3];

            for (int i = 0; i < 5; i++){
                for(int j = 0; j < 5; j++){
                    Console.WriteLine($"Digite o valor da posição{i},{j}:");
                    mat[i,j]  = int.Parse(Console.ReadLine());
                }
            }

            int soma = 0;

            for (int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    if(i == j) soma += mat[i+1,j];
                }
            }

            Console.Write($"{soma}");
        }
    }
}

namespace exercicio_10
{
    class Ex10
    {
        public static void Main(string[] args)
        {

            int[,] mat = new int[3,3];

            for (int i = 0; i < 5; i++){
                for(int j = 0; j < 5; j++){
                    Console.WriteLine($"Digite o valor da posição{i},{j}:");
                    mat[i,j]  = int.Parse(Console.ReadLine());
                }
            }

            int soma = 0;

            for (int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    if(i == j) soma += mat[i,j];
                }
            }

            Console.Write($"{soma}");
        }
    }
}

namespace exercicio_11
{
    class Ex11
    {
        public static void Main(string[] args)
        {

            int[,] mat = new int[3,3];

            for (int i = 0; i < 3; i++){
                for(int j = 0; j < 3; j++){
                    Console.WriteLine($"Digite o valor da posição{i},{j}:");
                    mat[i,j]  = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++){
                for(int j = 0; j < 3; j++){
                    Console.Write($"{mat[i,j]}  ");
                }
                Console.Write($"\n");
            }

            Console.WriteLine($"\n");

            int soma = 0;

            for (int i = 0, j = 2; i <= 2; i++, j--){
                Console.WriteLine($"{mat[i,j]}  ");
            }

            Console.Write($"{soma}");
        }
    }
}

namespace exercicio_12
{
    class Ex12
    {
        public static void Main(string[] args)
        {

            int[,] mat1 = new int[3,3];

            for (int i = 0; i < 3; i++){
                for(int j = 0; j < 3; j++){
                    Console.WriteLine($"Digite o valor da posição{i},{j}:");
                    mat1[i,j]  = int.Parse(Console.ReadLine());
                }
            }

            int[,] mat2 = new int[3,3];

            for (int i = 0; i < 3; i++){
                for(int j = 0; j < 3; j++){
                    mat2[j,i] = mat1[i,j];
                }
                Console.Write($"\n");
            }

            Console.WriteLine($"\n");

            for (int i = 0; i < 3; i++){
                for(int j = 0; j < 3; j++){
                    Console.Write($"{mat1[i,j]}  ");
                }
                Console.Write($"\n");
            }

            Console.WriteLine($"\n");

            for (int i = 0; i < 3; i++){
                for(int j = 0; j < 3; j++){
                    Console.Write($"{mat2[i,j]}  ");
                }
                Console.Write($"\n");
            }
        }
    }
}

namespace exercicio_13
{
    class Ex13
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] mat = new int[4,4];

            for (int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++) mat[i,j] = rnd.Next(1,20);
            }

            // PRINT
            for (int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    Console.Write($"{mat[i,j]}  ");
                }
                Console.Write($"\n");
            }

            Console.WriteLine($"\n");

            for (int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    if(i > j) mat[j,i] = 0;
                }
                Console.Write($"\n");
            }

            Console.WriteLine($"\n");

            // PRINT
            for (int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    Console.Write($"{mat[i,j]}  ");
                }
                Console.Write($"\n");
            }
        }
    }
}

[NÃO FEITA]namespace exercicio_14
{
    class Ex14
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] mat = new int[5,5];

            int insert = 0;
            bool hasBreak = false;

            while (insert <= 25){
                int n = rnd.Next(0,99);
                for (int i = 0; i <= insert; i++){
                    for(int j = 0; j < 5; j++){
                        if(n == mat[i,j]){
                            hasBreak = true;
                            break;
                        }else{
                            mat[i,j] = n;
                            insert++;
                        }
                    }
                    if(hasBreak) break;
                    hasBreak = false;
                }
            }


            // PRINT
            for (int i = 0; i < 5; i++){
                for(int j = 0; j < 5; j++){
                    Console.Write($"{mat[i,j]}  ");
                }
                Console.Write($"\n");
            }
        }
    }
}

namespace exercicio_15
{
    class Ex15
    {
        public static void Main(string[] args)
        {
            char[,] mat = new char[5,10];


            for (int i = 0; i < 5; i++){
                for(int j = 0; j < 10; j++){
                    Console.WriteLine($"Digite a resposta da {j} questao do {i} aluno:");
                    mat[i,j]  = char.Parse(Console.ReadLine());
                }
            }

            char[] gab = new char[10];

            for (int i = 0; i < 10; i++){
                Console.WriteLine($"Digite a resposta da {i} questao");
                gab[i]  = char.Parse(Console.ReadLine());
            }

            int[] res = new int[10];

            for (int i = 0; i < 5; i++){
                int points = 0;
                for(int j = 0; j < 10; j++){
                    if (mat[i,j] == gab[j]) points++;
                }
                res[i] = points;
            }

            // PRINT
            for (int i = 0; i < 5; i++){
                Console.WriteLine($"{res[i]},  ");
            }
        }
    }
}
*/
namespace exercicio_16
{
    class Ex16
    {
        public static void Main(string[] args)
        {
            char[,] mat = new char[5,10];


            for (int i = 0; i < 5; i++){
                for(int j = 0; j < 10; j++){
                    Console.WriteLine($"Digite a resposta da {j} questao do {i} aluno:");
                    mat[i,j]  = char.Parse(Console.ReadLine());
                }
            }

            char[] gab = new char[10];

            for (int i = 0; i < 10; i++){
                Console.WriteLine($"Digite a resposta da {i} questao");
                gab[i]  = char.Parse(Console.ReadLine());
            }

            int[] res = new int[10];

            for (int i = 0; i < 5; i++){
                int points = 0;
                for(int j = 0; j < 10; j++){
                    if (mat[i,j] == gab[j]) points++;
                }
                res[i] = points;
            }

            // PRINT
            for (int i = 0; i < 5; i++){
                Console.WriteLine($"{res[i]},  ");
            }
        }
    }
}