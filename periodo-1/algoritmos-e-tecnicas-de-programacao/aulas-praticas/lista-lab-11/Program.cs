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


//Exercicio 01 -
class Cliente{
    public string nome;
    public string endereco;
    public int telefone;
    
    public Cliente(string n, string e,int t ){
        nome = n;
        endereco = e;
        telefone = t;
    }
}

class Loja{
    public static void Main(){
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite seu endereço:");
        string endereco = Console.ReadLine();
        Console.WriteLine("Digite seu telefone:");
        int telefone = int.Parse(Console.ReadLine());
        Cliente fulano = new Cliente(nome, endereco, telefone);

        Console.WriteLine("Fulano cadastrado com sucesso!");
    }
}



//Exercicio 02 -
class Cliente{
    public string nome;
    public string endereco;
    public int telefone;
    
    public Cliente(string n, string e,int t ){
        nome = n;
        endereco = e;
        telefone = t;
    }
}

class Loja{
    public static void Main(){
        Cliente[] clientes = new Cliente[50];
        int count = 0;

        for(int i = 0; i < 50; i++){
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu endereço:");
            string endereco = Console.ReadLine();
            Console.WriteLine("Digite seu telefone:");
            int telefone = int.Parse(Console.ReadLine());
            Cliente fulano = new Cliente(nome, endereco, telefone);
            clientes[count] = fulano;
            count++;
        }
    }
}




//Exercicio 03 -
class Aluno{
    private string nome;
    private int matricula;
    private int[] notas = new int[50];
    
    public Aluno(string name, int m,int[] n ){
        nome = name;
        matricula = m;
        notas = n;
    }
    public int ObterMedia(){
        int sum = 0;
        for(int i = 0; i < notas.Length;i++) sum += notas[i];
        return sum / notas.Length;
    }
}

class Escola{
    public static void Main(){
        Console.WriteLine("Digite o nome do aluno:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o número de matrícula do aluno:");
        int matricula = int.Parse(Console.ReadLine());
        Console.WriteLine("Quantas notas gostaria de armazenar?");
        int n = int.Parse(Console.ReadLine());

        int [] notas = new int[n];

        for(int i = 0; i < n; i++){
            Console.WriteLine($"Digite a {i+1}° nota:");
            int nota = int.Parse(Console.ReadLine());
            notas[i] = nota;
        }

        Aluno aluno = new Aluno(nome, matricula, notas);
    }
}



//Exercicio 04 -
class Triangulo{
    private int lado1;
    private int lado2;
    private int lado3;
    
    public Triangulo(int l1, int l2,int l3 ){
        lado1 = l1;
        lado2 = l2;
        lado3 = l3;
    }
    public Triangulo(){
        lado1 = 1;
        lado2 = 2;
        lado3 = 3;
    }
}




//Exercicio 06 -
class Funcionario{
    private string nome;
    private string cargo;
    private double salario;
    
    public Funcionario(string n, string c, double s){
        nome = n;
        cargo = c;
        salario = s;
    }

    public Funcionario(string n, string c){
        nome = n;
        cargo = c;
        salario = 1.000;
    }
}



//Exercicio 07 -
class Cargo{
    private int código_do_cargo;
    private double valor_hora_trabalhada;
    
    public Cargo(int n, double s ){
        código_do_cargo = n;
        valor_hora_trabalhada = s;
    }

    public double valorDaHora(){
        return valor_hora_trabalhada;
    }
}

class Funcionario{
    private Cargo cargo;
    private char sexo;
    private double qnt_hrs_trabalhadas;
    
    public Funcionario(Cargo c, char s, double h){
        cargo = c;
        sexo = s;
        qnt_hrs_trabalhadas = h;
    }
    public double SalarioFinal(){
        double value = this.cargo.valorDaHora();
        return value * this.qnt_hrs_trabalhadas;
    }
}

class Salarios{
    static void Main(string[] args){
        Cargo devJunior = new Cargo(1,20);
        Cargo devPleno = new Cargo(1,30);
        Cargo devSenior = new Cargo(1,40);
        Funcionario fulano = new Funcionario(devJunior,'s',3);
        Funcionario ciclano = new Funcionario(devPleno,'f',8);
        Funcionario beltrano = new Funcionario(devSenior,'s',5);
        Console.WriteLine(fulano.SalarioFinal());
    }
}



//Exercicio 08 -
class Cliente{
    private int code_cliente;
    private string email;
    private int hours;
    private char page;
    
    public Cliente(int n, string e, int h, char p){
        code_cliente = n;
        email = e;
        hours = h;
        page = p;
    }

    public double InserirRelatorio(){
        double value = 35;
        if(hours > 20) value += ((hours - 20) * 2.50);
        if(page == 's') value += 40;
        return value;
    }
}

class Cadastro{
    static void Main(string[] args){
        Cliente [] relatorios = new Cliente[500];

        Console.WriteLine("Quantos clientes voce quer cadastrar?");
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n;i++){
            Console.WriteLine($"Codigo do {i+1} cliente:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"email do {i+1} cliente:");
            string e = Console.ReadLine();
            Console.WriteLine($"horas do {i+1} cliente:");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine($"pagina do {i+1} cliente:");
            char p = char.Parse(Console.ReadLine());
            relatorios[i] = new Cliente(c, e, h, p);
        }
    }
}


*/
//Exercicio 09 -
class Agencia{
    public string nome;
    public int numero;
    public int digito;
    
    public Agencia(string n, int num, int d){
        nome = n;
        numero = num;
        digito = d;
    }
}
class ContaCorrente{
    private int digito;
    private int numero;
    private Agencia agencia;
    private double saldo;

    public ContaCorrente(int n, int num, Agencia a, double s){
        digito = n;
        numero = num;
        agencia = a;
        saldo = s;
    }

    public void Depositar(double v){
        saldo += v;
    }
    public void Sacar(double v){
        if (saldo - v >= 0) saldo -= v;
    }
    public string ConsultarSaldo(){
        return @$"Número da conta: {digito} {numero},
        Número da agência: {agencia.digito} {agencia.numero}
        Saldo na conta: {saldo}";
    }
}

class Cliente{
    private string nome;
    private string cpf;

    public ContaCorrente conta;

    public Cliente(string n, string e, ContaCorrente c){
        nome = n;
        cpf = e;
        conta = c;
    }
}

class CaixaElotronico{
    static void Main(string[] args){
        Agencia x = new Agencia("X",7890,5);
        ContaCorrente c = new ContaCorrente(4,1234,x,150);
        Cliente ademar = new Cliente("Ademar da Silva","123231518-12",c);

        ademar.conta.Sacar(140);
        Console.WriteLine(ademar.conta.ConsultarSaldo());
        ademar.conta.Sacar(200);
        Console.WriteLine(ademar.conta.ConsultarSaldo());
        ademar.conta.Depositar(25.45);
    }
}