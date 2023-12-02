// Trabalho prático BINGO

using System;

class Cartela
{
    
    private int qntCartelas;
    
    public static int[,] ObterCartela()
    {
        Random rnd = new Random();
        int[,] cartela = new int[5, 5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i == 2 && j == 2) cartela[i, j] = 0;
                else switch (j)
                    {
                        case 0:
                            cartela[i, j] = rnd.Next(1, 15);
                            break;
                        case 1:
                            cartela[i, j] = rnd.Next(16, 30);
                            break;
                        case 2:
                            cartela[i, j] = rnd.Next(31, 45);
                            break;
                        case 3:
                            cartela[i, j] = rnd.Next(46, 60);
                            break;
                        case 4:
                            cartela[i, j] = rnd.Next(61, 75);
                            break;
                    }
            }
        }
        return cartela;
    }

    public static void ImprimirCartela(int[,] cartela)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{cartela[i, j]}  ");
            }
            Console.WriteLine($"\n");
        }
    }
}

class Jogador
{
    public string nome;
    public int idade;
    public string sexo;
    public int qntCartelas;
    public int[][,] cartelas;
    // https://stackoverflow.com/questions/1582555/initialize-int-in-c-sharp
    public int[][,] copyCartelas;
    public bool status = true;

    public Jogador(string nome, string sexo, int idade, int qntCartelas)
    {
        this.nome = nome;
        this.idade = idade;
        this.sexo = sexo;
        this.qntCartelas = qntCartelas;
        cartelas = new int[qntCartelas][,];
        copyCartelas = new int[qntCartelas][,];
        ObterCartelas(qntCartelas);
    }

    public void ObterCartelas(int x)
    {
        for (int i = 0; i < x; i++)
        {
            cartelas[i] = Cartela.ObterCartela();
            copyCartelas[i] = cartelas[i];
        }
    }
}

class Roulette
{
    public int[] sortedNumbers = new int[75];
    public int count = 0;
    public int sortedNumber()
    {
        Random rnd = new Random();

        bool exists;
        int n;

        do
        {
            exists = false;
            n = rnd.Next(1, 75);

            for (int i = 0; i < sortedNumbers.Length; i++)
            {
                if (n == sortedNumbers[i]){
                    exists = true;
                    break;
                }
            }
        } while (exists);

        sortedNumbers[count] = n;
        count++;

        return n;
    }
}

class Bingo
{
    public static Jogador[] Preparation()
    {
        int qntJogadores;
        do
        {
            Console.WriteLine("Quantas pessoas irão jogar? (min:2 max:5)");
            qntJogadores = int.Parse(Console.ReadLine());
        } while (qntJogadores < 2 || qntJogadores > 5);

        Jogador[] jogadores = new Jogador[qntJogadores];

        for (int i = 0; i < jogadores.Length; i++)
        {
            Console.WriteLine($"jogador {i + 1}: qual seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine($"jogador {i + 1}: qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"jogador {i + 1}: qual seu sexo?");
            string sexo = Console.ReadLine();

            int qntCartelas;

            do
            {
                Console.WriteLine($"jogador {i + 1}: quantas cartelas você quer? (min:1 max:4)");
                qntCartelas = int.Parse(Console.ReadLine());
            } while (qntCartelas < 1 || qntCartelas > 4);

            jogadores[i] = new Jogador(nome, sexo, idade, qntCartelas);
        }

        for (int i = 0; i < qntJogadores; i++)
        {
            Console.WriteLine($"Imprimir as cartelas de {jogadores[i].nome}:");
            Console.Write($"\n");

            for (int j = 0; j < jogadores[i].cartelas.Length; j++)
            {
                Cartela.ImprimirCartela(jogadores[i].cartelas[j]);
                Console.WriteLine($"\n");
                Console.WriteLine($"\n");
            }
        }

        return jogadores;
    }

    public static bool ConfereBingo(int [] sortedNumbers, int [,] copyCartela, char where, int index, Jogador jogador, int indexCartela){
        bool bingo = false;
        int count = 0;

        for(int i = 0; i < 5; i++){
            for(int j = 0; j < sortedNumbers.Length; j++){
                if (where == 'l' && copyCartela[index,i] == sortedNumbers[j]) count++;
                else if (copyCartela[i,index] == sortedNumbers[j]) count++;
            }
        }

        if (count == 5) bingo = true;
        else if (jogador.cartelas.Length > 1){
            jogador.cartelas[indexCartela][0,0] = -1;

            bool key = true;
            for (int i = 0; i < jogador.cartelas.Length; i++){
                if(jogador.cartelas[i][0,0] != -1){
                    key = false;
                    break;
                }
            }
            if(key) jogador.status = false;
        } else {
            jogador.status = false;
        }

        return bingo;
    }

    public static void printRanking(Jogador [] winners){
        Console.WriteLine($"RANKING DA PARTIDA:");

        for(int i = 0; i < winners.Length; i++){
            Console.WriteLine(@$"{i+1}° lugar:
            nome: {winners[i].nome}
            idade: {winners[i].idade}
            sexo: {winners[i].sexo}");
            Console.WriteLine("");
        }
    }

    public static void Main()
    {
        Jogador[] jogadores = Preparation();
        
        Jogador [] ganhadores = new Jogador[jogadores.Length];

        Console.WriteLine("Todos com suas devidas cartelas, vamos iniciar o BINGO!");

        Roulette roulette = new Roulette();

        bool gameON = true;
        int round = 0;
        int playersOff = 0;
        int winners = 0;
        int losers = jogadores.Length -1;

        while (gameON)
        {
            int number = roulette.sortedNumber();
            for (int i = 0; i < jogadores.Length; i++)
            {
                Console.WriteLine($"Numero sorteado: {number}");
                if (jogadores[i].status == true)
                {
                    Console.WriteLine($"{jogadores[i].nome}: você possui o {number} em alguma de suas cartelas? (s ou n)");
                    if (char.Parse(Console.ReadLine()) == 's')
                    {
                        for (int j = 0; j < jogadores[i].cartelas.Length; j++)
                        {
                            if (jogadores[i].cartelas[j][0, 0] >= 0)
                            {
                                Cartela.ImprimirCartela(jogadores[i].cartelas[j]);
                                Console.WriteLine($"{jogadores[i].nome}: Possui o {number} em sua {j + 1}º cartela? (s ou n)");
                                if (char.Parse(Console.ReadLine()) == 's')
                                {
                                    Console.WriteLine($"{jogadores[i].nome}: O {number} está em qual linha da cartela?");
                                    int linha = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"{jogadores[i].nome}: O {number} está em qual coluna da cartela?");
                                    int coluna = int.Parse(Console.ReadLine());
                                    jogadores[i].cartelas[j][linha - 1, coluna - 1] = 0;

                                    if (round >= 5)
                                    {
                                        Console.WriteLine($"{jogadores[i].nome}: Você fez bingo nessa cartela? (s ou n)");
                                        if (char.Parse(Console.ReadLine()) == 's')
                                        {
                                            Console.WriteLine($"{jogadores[i].nome}: Informe se foi em uma linha (l) ou coluna (c):");
                                            if (char.Parse(Console.ReadLine()) == 'l'){
                                                Console.WriteLine($"{jogadores[i].nome}: Informe qual foi a linha:");
                                                bool bingo = ConfereBingo(roulette.sortedNumbers, jogadores[i].copyCartelas[j], 'l', int.Parse(Console.ReadLine()) - 1, jogadores[i], j);
                                                if(jogadores[i].status == false){
                                                    ganhadores[losers] = jogadores[i];
                                                    playersOff++;
                                                    losers--;
                                                }else if (bingo){
                                                    jogadores[i].status = false;
                                                    ganhadores[winners] = jogadores[i];
                                                    playersOff++;
                                                    winners++;
                                                }
                                            } else {
                                                Console.WriteLine($"{jogadores[i].nome}: Informe qual foi a coluna:");
                                                bool bingo = ConfereBingo(roulette.sortedNumbers,jogadores[i].copyCartelas[j], 'c', int.Parse(Console.ReadLine()) - 1, jogadores[i], j);
                                                if(jogadores[i].status == false){
                                                    ganhadores[losers] = jogadores[i];
                                                    playersOff++;
                                                    losers--;
                                                }else if (bingo){
                                                    jogadores[i].status = false;
                                                    ganhadores[winners] = jogadores[i];
                                                    playersOff++;
                                                    winners++;
                                                }
                                            }
                                        }

                                    }
                                }
                            }
                        }

                    }
                }
            }
            round++;
            if (playersOff == jogadores.Length - 1){
                for(int i = 0; i < jogadores.Length; i++){
                    if(jogadores[i].status == true){
                        ganhadores[losers] = jogadores[i];
                        break;
                    }
                }
                gameON = false;
            }
        }
        printRanking(ganhadores);
    }
}


/* RASCUNHO
jogadores = [
    {
        nome: "******",
        sexo: "***",
        idade: xx,
        cartelas: [{cartela1},{cartela2},{cartela3},{cartela4}];
    },
    {
        nome: "******",
        sexo: "***",
        idade: xx,
        cartelas: [{cartela1},{cartela2}];
    },
    {
        nome: "******",
        sexo: "***",
        idade: xx,
        cartelas: [{cartela1}];
    }
]
*/