// Lista de 9 exercícios - Laboratório prático 8 (String)
using System;

/*
namespace exercicio_1
{
    class Ex1
    {
        public static void Main(string[]args)
        {
            
            Console.WriteLine("Digite a 1° string:");
            string s1 = Console.ReadLine();

            Console.WriteLine("Digite a 2° string:");
            string s2 = Console.ReadLine();

            int ts1 = s1.Length - 1, ts2 = s2.Length - 1;
            bool equals = true;

            if (ts1 >= ts2) {
                for(int i = 0; i < ts1; i++) {
                    if (s1[i] != s2[i]) equals = false;
                }
                if (equals == false) Console.WriteLine($"{s1}, {s1 + s2}");
            } else {
                for(int i = 0; i < ts2; i++) {
                    if (s1[i] != s2[i]) equals = false;
                }
                if (equals == false) Console.WriteLine($"{s2}, {s1 + s2}");
            }

            if (equals) Console.WriteLine("Palavras iguais!");

        }
    }
}

namespace exercicio_2
{
    class Ex2
    {
        public static void Main(string[]args)
        {
            
            Console.WriteLine("Digite uma string:");
            string input = Console.ReadLine();

            string str = new String(input.Where(c => c != '-' && (c < '0' || c > '9')).ToArray());

            int countV = 0, countC = 0;

            for(int i = 0; i < str.Length; i++) {
                if ( str[i] != ' ' ) {
                    if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u') {
                        countV++;
                    } else countC++; 
                }
            }

            Console.WriteLine($"{countV}, {countC}");
        }
    }
}

namespace exercicio_3
{
    class Ex3
    {
        public static void Main(string[]args)
        {
            
            Console.WriteLine("Digite uma string:");
            string input = Console.ReadLine();

            int j = input.Length - 1;

            for(int i = j; i >= 0; i--) {
                Console.Write(input[i]);
            }
        }
    }
}

namespace exercicio_4
{
    class Ex4
    {
        public static void Main(string[]args)
        {
            
            Console.WriteLine("Digite uma string:");
            string str = Console.ReadLine();

            Console.WriteLine("Digite um caractere:");
            char l = char.Parse(Console.ReadLine());

            int count = 0;

            for(int i = 0; i < str.Length; i++) if (str[i] == l) count++;

            Console.WriteLine(count);
        }
    }
}

namespace exercicio_5
{
    class Ex5
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Digite uma string:");
            string str = Console.ReadLine();

            bool palindromo = true;

            for(int i = 0, j = str.Length - 1; i < j; i++, j--) if (str[i] != str[j]) palindromo = false;

            if (palindromo) Console.WriteLine($"{str} é palíndromo!");
            else Console.WriteLine($"{str} não é palíndromo!");
        }
    }
}

namespace exercicio_6
{
    class Ex6
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Digite um verbo regular:");
            string verbo = Console.ReadLine();

            string r1 = "",r2 = "",r3 = "";

            if (verbo.EndsWith("ar")) {
                r1 = verbo.Replace("ar", "o");
                r2 = verbo.Replace("ar", "ei");
                r3 = verbo.Insert(verbo.Length, "ei");
                Console.WriteLine(@$"
                Presente do indicativo = {r1}
                Pretérito perito do indicativo = {r2}
                Futuro de presente do indicativo = {r3}");
            } else Console.WriteLine("Error");

        }
    }
}

namespace exercicio_7
{
    class Ex7
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Digite uma palavra:");
            string s = Console.ReadLine();

            for (int i = 0; i < s.Length; i++) {
                if (s[i] == 'a') s = s.Replace("a", "*");
                else if (s[i] == 'e') s = s.Replace("e", "*");
                else if (s[i] == 'i') s = s.Replace("i", "*");
                else if (s[i] == 'o') s = s.Replace("o", "*");
                else if (s[i] == 'u') s = s.Replace("u", "*");
            }

            Console.WriteLine(s);
        }
    }
}

namespace exercicio_8
{
    class Ex8
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Digite uma frase com mais de 50 caracteres:");
            string a = Console.ReadLine();

            Console.WriteLine("Digite uma sílaba de 2 letras:");
            string b = Console.ReadLine();

            char p1 = a[0], p2 = a[1];
            int count = 0;

            for (int i = 2; i < a.Length; i++) {
                if (p1 == b[0] && p2 == b[1]) count++;
                p1 = p2;
                p2 = a[i];
            }

            Console.WriteLine(count);
        }
    }
}

namespace exercicio_9
{
    class Ex9
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Digite uma frase com mais de 50 caracteres:");
            string a = Console.ReadLine();

            Console.WriteLine("Digite uma sílaba de 2 letras:");
            string b = Console.ReadLine();

            int r = a.IndexOf($"{b}");

            Console.WriteLine(r);
        }
    }
}
*/