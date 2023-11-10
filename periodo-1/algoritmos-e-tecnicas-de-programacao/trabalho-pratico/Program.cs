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
        
    }
}
