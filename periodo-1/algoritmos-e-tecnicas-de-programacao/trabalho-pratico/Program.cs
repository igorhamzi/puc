// Trabalho prático BINGO

using System;

class Cartela{
/*
    private int qntCartelas;
*/
    public static int[,] ObterCartela(){
        Random rnd = new Random();
        int [,] cartela = new int[5,5];
        for (int i = 0; i < 5; i++){
            for(int j = 0; j < 5; j++){
                if(i == 2 && j == 2) cartela[i,j] = 0;
                else cartela[i,j] = rnd.Next(1, 75);
            }
        }
        return cartela;
    }

    public static void ImprimirCartela(int[,] cartela){
        for (int i = 0; i < 5; i++){
            for(int j = 0; j < 5; j++){
                Console.Write($"{cartela[i,j]}  ");
            }
            Console.WriteLine($"\n");
        }
    }
}

class Jogador{
    public string nome;
    public int idade;
    public string sexo;
    public int qntCartelas;

    public int [,] cartela1 = new int[5,5];
    public int [,] cartela2 = new int[5,5];
    public int [,] cartela3 = new int[5,5];
    public int [,] cartela4 = new int[5,5];
    
    public Jogador(string nome,string sexo,int idade, int qntCartelas ){
        this.nome = nome;
        this.idade = idade;
        this.sexo = sexo;
        this.qntCartelas = qntCartelas;
        ObterCartelas(qntCartelas);
    }
    public void ObterCartelas(int x){
        switch(x){
            case 1:
                cartela1 = Cartela.ObterCartela();
                break;
            case 2:
                cartela1 = Cartela.ObterCartela();
                cartela2 = Cartela.ObterCartela();
                break;
            case 3:
                cartela1 = Cartela.ObterCartela();
                cartela2 = Cartela.ObterCartela();
                cartela3 = Cartela.ObterCartela();
                break;
            case 4:
                cartela1 = Cartela.ObterCartela();
                cartela2 = Cartela.ObterCartela();
                cartela3 = Cartela.ObterCartela();
                cartela4 = Cartela.ObterCartela();
                break;
        }
    }
}

class Bingo{
    public static void Main(){
        int qntJogadores;

        do{
            Console.WriteLine("Quantas pessoas irão jogar? (min:2 max:5)");
            qntJogadores = int.Parse(Console.ReadLine());
        } while (qntJogadores < 2 || qntJogadores > 5);

        Jogador[] jogadores = new Jogador[qntJogadores];

        for (int i = 0; i < jogadores.Length; i++){
            Console.WriteLine($"jogador {i + 1}: qual? seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine($"jogador {i + 1}: qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"jogador {i + 1}: qual seu sexo?");
            string sexo = Console.ReadLine();

            int qntCartelas;

            do{
                Console.WriteLine($"jogador {i + 1}: quantas cartelas você quer? (min:1 max:4)");
                qntCartelas = int.Parse(Console.ReadLine());
            } while (qntCartelas < 1 || qntCartelas > 4);

            jogadores[i] = new Jogador(nome, sexo, idade, qntCartelas);
        }
        /* IMPRIME AS CARTELAS DOS JOGADORES
        for (int i = 0; i < x; i++){
            Console.WriteLine($"Imprimir as cartelas do {jogadores[i].nome}:");
            Console.Write($"\n");

            
            int qnt = jogadores[i].qntCartelas;

            switch(qnt){
                case 1:
                    Cartela.ImprimirCartela(jogadores[i].cartela1);
                break;
                case 2:
                    Cartela.ImprimirCartela(jogadores[i].cartela1);
                    Console.WriteLine($"\n");
                    Cartela.ImprimirCartela(jogadores[i].cartela2);
                break;
                case 3:
                    Cartela.ImprimirCartela(jogadores[i].cartela1);
                    Console.WriteLine($"\n");

                    Cartela.ImprimirCartela(jogadores[i].cartela2);
                    Console.WriteLine($"\n");
                    Cartela.ImprimirCartela(jogadores[i].cartela3);
                break;
                case 4:
                    Cartela.ImprimirCartela(jogadores[i].cartela1);
                    Console.WriteLine($"\n");
                    Cartela.ImprimirCartela(jogadores[i].cartela2);
                    Console.WriteLine($"\n");
                    Cartela.ImprimirCartela(jogadores[i].cartela3);
                    Console.WriteLine($"\n");
                    Cartela.ImprimirCartela(jogadores[i].cartela4);
                break;
            }
            Console.WriteLine($"\n");
            Console.WriteLine($"\n");
            Console.WriteLine($"\n");
        }
        */

        Console.WriteLine("Todos com suas devidas cartelas, vamos iniciar o BINGO!");
    }
}
