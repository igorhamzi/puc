// Lista de 25 exercicios - Programção orientada a objetos (POO)
using System;

/*
class Pessoa{
    private string nome;
    public string endereco;
    
    public void InformarDados(string novoNome, string novoEndereco ){
        nome = novoNome;
        endereco = novoEndereco;
    }
    public string ObterNome(){
        return nome;
    }
}

class Agenda{
    private Pessoa[] pessoas = new Pessoa[5];
    private int quantidadePessoas;
    
    public Agenda(int quantidade){
        quantidadePessoas = quantidade;
    }
    public void InserirPessoa(string nome, string endereco){
        Pessoa pessoa = new Pessoa();
        pessoa.InformarDados(nome, endereco);
        pessoas[quantidadePessoas] = pessoa;
        quantidadePessoas++;
    }
    public Pessoa ObterPessoa(int posicao){
        if (posicao < quantidadePessoas){
        Pessoa p = pessoas[posicao];
        return p;
        }
        else{
            Console.WriteLine("Erro!!! A posição informada não contém uma pessoa");
            return null;
        }
    }
}

class TesteAgenda{
    public static void Main(){
        Agenda agenda = new Agenda(0); 
        for(int i=0; i<5; i++){
            Console.WriteLine("Digite seu nome e endereço:");
            string nome = Console.ReadLine();
            string endereco = Console.ReadLine();
            agenda.InserirPessoa(nome, endereco);
            Console.WriteLine();
        }
        for(int i=0; i<5; i++){
            Pessoa pessoa = agenda.ObterPessoa(i);
            Console.WriteLine(pessoa.ObterNome() + " - " + pessoa.endereco);
            Console.WriteLine();
        }
    }
}
*/

//Exercicio 01 -
