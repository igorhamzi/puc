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

class Bingo{
    public static void Main(){
        
    }
}
