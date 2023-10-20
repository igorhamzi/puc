
// 3° lista de exercícios(64) - Vetores e Matrizes

using System;
using System.Net.Http.Headers;

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
*/
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