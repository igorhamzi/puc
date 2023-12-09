// Lista de 8 exercícios - Laboratório prático 12 (arquivos)
using System;
using System.IO;
using System.Text;

// Exercicio 01 -
class Ex1
{
    static void Main(string [] args)
    {
        try
        {
            StreamReader arq = new StreamReader("C:\\arquivo-01.txt", Encoding.UTF8);

            int count = 0;

            while (arq.ReadLine() != null)
            {
                count++;
            }

            arq.Close();

            Console.WriteLine($"A quantidade de linhas no arquivo é: {count}");
            
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception: {e.Message}");
        }
    }
}

// Exercicio 02 -
class Ex2
{
    static void Main(string[] args)
    {
        try
        {
            StreamReader arq = new StreamReader("C:\\arquivo-01.txt", Encoding.UTF8);

            while (!arq.EndOfStream)
            {
                string linha = arq.ReadLine();

                string[] dados = linha.Split(';');

                if (dados.Length >= 2)
                {
                    string nomeCientifico = dados[1].Trim();
                    Console.WriteLine($"Nome Científico: {nomeCientifico}");
                }
                else
                {
                    Console.WriteLine("Formato de linha inválido.");
                }

            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception: {e.Message}");
        }
    }
}

// Exercicio 03 -

class Ex3
{
    static void Main()
    {
        try
        {
            string caminhoArquivo = Path.Combine("C:", "arquivo-01.txt");
            var estatisticasPeso = ObterEstatisticasDePeso(caminhoArquivo);
            Console.WriteLine($"Peso Mínimo: {estatisticasPeso.PesoMinimo}");
            Console.WriteLine($"Peso Máximo: {estatisticasPeso.PesoMaximo}");
            Console.WriteLine($"Peso Médio: {estatisticasPeso.PesoMedio}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception: {e.Message}");
        }
    }

    static EstatisticasPeso ObterEstatisticasDePeso(string caminhoArquivo)
    {
        EstatisticasPeso estatisticas = new EstatisticasPeso();
        try
        {
            using (StreamReader arq = new StreamReader(caminhoArquivo, Encoding.UTF8))
            {
                double somaPesos = 0;
                int quantidadeAnimais = 0;
                estatisticas.PesoMinimo = double.MaxValue;
                estatisticas.PesoMaximo = double.MinValue;

                while (!arq.EndOfStream)
                {
                    string linha = arq.ReadLine();
                    string[] dados = linha.Split(';');

                    if (dados.Length >= 4)
                    {
                        double pesoAtual = double.Parse(dados[3].Trim());
                        estatisticas.PesoMinimo = Math.Min(estatisticas.PesoMinimo, pesoAtual);
                        estatisticas.PesoMaximo = Math.Max(estatisticas.PesoMaximo, pesoAtual);
                        somaPesos += pesoAtual;
                        quantidadeAnimais++;
                    }
                }

                if (quantidadeAnimais > 0)
                {
                    estatisticas.PesoMedio = somaPesos / quantidadeAnimais;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao processar o arquivo: {ex.Message}");
        }

        return estatisticas;
    }
}

class EstatisticasPeso
{
    public double PesoMinimo { get; set; }
    public double PesoMaximo { get; set; }
    public double PesoMedio { get; set; }
}


// Exercicio 04 -
class Ex4
{
    static void Main()
    {
        string caminhoArquivo = "C:\\arquivo-01.txt";
        ImprimirNomesPopularesPorIdade(caminhoArquivo, 10, 16);
    }

    static void ImprimirNomesPopularesPorIdade(string caminhoArquivo, int idadeMinima, int idadeMaxima)
    {
        try
        {
            StreamReader arq = new StreamReader(caminhoArquivo, Encoding.UTF8);
            while (!arq.EndOfStream)
            {
                string linha = arq.ReadLine();
                string[] dados = linha.Split(';');

                if (dados.Length >= 5)
                {
                    int idadeMaximaCativeiro = int.Parse(dados[4].Trim());

                    if (idadeMaximaCativeiro >= idadeMinima && idadeMaximaCativeiro <= idadeMaxima)
                    {
                        string nomePopular = dados[0].Trim();
                        Console.WriteLine($"Nome Popular: {nomePopular}");
                    }
                }
            }
            arq.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao processar o arquivo: {ex.Message}");
        }
    }
}


// Exercicio 05 -
class Ex5
{
    static void Main()
    {
        string caminhoArquivo = "C:\\arquivo-01.txt";
        ExibirInformacoesAnimaisDomesticos(caminhoArquivo);
    }

    static void ExibirInformacoesAnimaisDomesticos(string caminhoArquivo)
    {
        try
        {
            StreamReader arq = new StreamReader(caminhoArquivo, Encoding.UTF8);
            while (!arq.EndOfStream)
            {
                string linha = arq.ReadLine();
                string[] dados = linha.Split(';');

                if (dados.Length >= 3 && dados[2].Trim().ToLower() == "true")
                {
                    Console.WriteLine($"Nome Popular: {dados[0].Trim()}");
                    Console.WriteLine($"Nome Científico: {dados[1].Trim()}");
                    Console.WriteLine($"Doméstico: {dados[2].Trim()}");
                    Console.WriteLine($"Peso Máximo: {dados[3].Trim()}");
                    Console.WriteLine($"Idade Máxima em Cativeiro: {dados[4].Trim()}");
                    Console.WriteLine();
                }
            }
            arq.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao processar o arquivo: {ex.Message}");
        }
    }
}

// Exercicio 06 -
class Ex6
{
    static void Main()
    {
        string caminhoArquivoFelinos = "C:\\arquivo-01.txt";
        string caminhoArquivoIntervalos = "C:\\arquivo-02.txt";

        ExibirFelinosPorIntervalo(caminhoArquivoFelinos, caminhoArquivoIntervalos);
    }

    static void ExibirFelinosPorIntervalo(string caminhoArquivoFelinos, string caminhoArquivoIntervalos)
    {
        try
        {
            int[][] intervalos = LerIntervalos(caminhoArquivoIntervalos);

            StreamReader arqFelinos = new StreamReader(caminhoArquivoFelinos, Encoding.UTF8);
            while (!arqFelinos.EndOfStream)
            {
                string linhaFelino = arqFelinos.ReadLine();
                string[] dadosFelino = linhaFelino.Split(';');

                if (dadosFelino.Length >= 4)
                {
                    double pesoMaximoFelino = double.Parse(dadosFelino[3].Trim());

                    if (EstaDentroDosIntervalos(pesoMaximoFelino, intervalos))
                    {
                        string nomePopularFelino = dadosFelino[0].Trim();
                        Console.WriteLine($"Felino no intervalo: {nomePopularFelino}");
                    }
                }
            }

            arqFelinos.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao processar os arquivos: {ex.Message}");
        }
    }

    static int[][] LerIntervalos(string caminhoArquivoIntervalos)
    {
        StreamReader arqIntervalos = new StreamReader(caminhoArquivoIntervalos, Encoding.UTF8);
        int[][] intervalos = new int[0][];

        try
        {
            while (!arqIntervalos.EndOfStream)
            {
                string linhaIntervalo = arqIntervalos.ReadLine();
                string[] dadosIntervalo = linhaIntervalo.Split(';');

                if (dadosIntervalo.Length >= 2)
                {
                    int intervaloMinimo = int.Parse(dadosIntervalo[0].Trim());
                    int intervaloMaximo = int.Parse(dadosIntervalo[1].Trim());

                    Array.Resize(ref intervalos, intervalos.Length + 1);
                    intervalos[intervalos.Length - 1] = new int[] { intervaloMinimo, intervaloMaximo };
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao ler os intervalos: {ex.Message}");
        }
        finally
        {
            arqIntervalos.Close();
        }

        return intervalos;
    }

    static bool EstaDentroDosIntervalos(double peso, int[][] intervalos)
    {
        foreach (var intervalo in intervalos)
        {
            if (peso >= intervalo[0] && peso <= intervalo[1])
            {
                return true;
            }
        }
        return false;
    }
}


// Exercicio 07 -
class Ex7
{
    static void Main()
    {
        string caminhoArquivoFelinos = "C:\\arquivo-01.txt";
        string caminhoArquivoIntervalos = "C:\\arquivo-02.txt";
        string caminhoArquivoResultados = "C:\\arquivo-03.txt";

        SalvarFelinosPorIntervalo(caminhoArquivoFelinos, caminhoArquivoIntervalos, caminhoArquivoResultados);
    }

    static void SalvarFelinosPorIntervalo(string caminhoArquivoFelinos, string caminhoArquivoIntervalos, string caminhoArquivoResultados)
    {
        try
        {
            int[][] intervalos = LerIntervalos(caminhoArquivoIntervalos);

            using (StreamWriter arqResultados = new StreamWriter(caminhoArquivoResultados, false, Encoding.UTF8))
            using (StreamReader arqFelinos = new StreamReader(caminhoArquivoFelinos, Encoding.UTF8))
            {
                while (!arqFelinos.EndOfStream)
                {
                    string linhaFelino = arqFelinos.ReadLine();
                    string[] dadosFelino = linhaFelino.Split(';');

                    if (dadosFelino.Length >= 4)
                    {
                        double pesoMaximoFelino = double.Parse(dadosFelino[3].Trim());

                        if (EstaDentroDosIntervalos(pesoMaximoFelino, intervalos))
                        {
                            string nomePopularFelino = dadosFelino[0].Trim();
                            arqResultados.WriteLine($"Felino no intervalo: {nomePopularFelino}");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao processar os arquivos: {ex.Message}");
        }
    }

    static int[][] LerIntervalos(string caminhoArquivoIntervalos)
    {
        StreamReader arqIntervalos = new StreamReader(caminhoArquivoIntervalos, Encoding.UTF8);
        int[][] intervalos = new int[0][];

        try
        {
            while (!arqIntervalos.EndOfStream)
            {
                string linhaIntervalo = arqIntervalos.ReadLine();
                string[] dadosIntervalo = linhaIntervalo.Split(';');

                if (dadosIntervalo.Length >= 2)
                {
                    int intervaloMinimo = int.Parse(dadosIntervalo[0].Trim());
                    int intervaloMaximo = int.Parse(dadosIntervalo[1].Trim());

                    Array.Resize(ref intervalos, intervalos.Length + 1);
                    intervalos[intervalos.Length - 1] = new int[] { intervaloMinimo, intervaloMaximo };
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao ler os intervalos: {ex.Message}");
        }
        finally
        {
            arqIntervalos.Close();
        }

        return intervalos;
    }

    static bool EstaDentroDosIntervalos(double peso, int[][] intervalos)
    {
        foreach (var intervalo in intervalos)
        {
            if (peso >= intervalo[0] && peso <= intervalo[1])
            {
                return true;
            }
        }
        return false;
    }
}


// Exercicio 08S -
class Ex8
{
    static void Main()
    {
        string caminhoArquivoFelinos = "C:\\arquivo-01.txt";
        OrdenarNomesCientificos(caminhoArquivoFelinos);
    }

    static void OrdenarNomesCientificos(string caminhoArquivoFelinos)
    {
        try
        {
            string[] nomesCientificos = LerNomesCientificos(caminhoArquivoFelinos);

            Array.Sort(nomesCientificos);

            Console.WriteLine("Nomes Científicos Ordenados:");

            foreach (var nomeCientifico in nomesCientificos)
            {
                Console.WriteLine(nomeCientifico);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao processar o arquivo: {ex.Message}");
        }
    }

    static string[] LerNomesCientificos(string caminhoArquivoFelinos)
    {
        StreamReader arqFelinos = new StreamReader(caminhoArquivoFelinos, Encoding.UTF8);
        string[] nomesCientificos = new string[0];

        try
        {
            while (!arqFelinos.EndOfStream)
            {
                string linhaFelino = arqFelinos.ReadLine();
                string[] dadosFelino = linhaFelino.Split(';');

                if (dadosFelino.Length >= 2)
                {
                    string nomeCientifico = dadosFelino[1].Trim();

                    Array.Resize(ref nomesCientificos, nomesCientificos.Length + 1);
                    nomesCientificos[nomesCientificos.Length - 1] = nomeCientifico;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao ler os nomes científicos: {ex.Message}");
        }
        finally
        {
            arqFelinos.Close();
        }

        return nomesCientificos;
    }
}
