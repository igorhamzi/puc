// Lista de 08 exercícios - Laboratório prático 10 (modularização, vetores e matrizes)
using System;

class Ex01{
	public static bool Magic (int [,] x, int l, int c){
		bool magic = true;
		int sumLinha = 0, sumColuna = 0, sumDiagonal = 0;

		for (int i = 0; i < l; i++){
			int sL = 0, sC = 0;
			for(int y = 0; y < c; y++){
				x[i,y] += sL;
				x[y,i] += sC;
				if(i == y) sumDiagonal += x[i,y];
			}
			if(i == 0) {
				sumLinha = sL;
				sumColuna = sC;
			}
			if (sL != sumLinha || sC != sumColuna){
				magic = false;
				break;
			}
		}
	
		return magic;
	}
}

class Ex02{
	public static bool IfPrimo (int x){
		bool primo = true;
		for (int i = 2; i < x; i++) if(x % i == 0) primo = false;
		return primo;
	}

	public static int Primos (int [] x){
		int qntPrimos = 0;
		for (int i = 0; i < x.Length; i++) if (IfPrimo(x[i])) qntPrimos++;
		return qntPrimos;
	}

	public static void Main (){	
		Console.WriteLine("Digite a quantidade de elementos do vetor:");
		int n = int.Parse(Console.ReadLine());

		int [] array = new int [n];

		for (int i = 0; i < n; i++){
			Console.WriteLine($"Digite o {i+1}° valor do vetor:");
			array[i] = int.Parse(Console.ReadLine());
		}

		Console.WriteLine($"No array possui {Primos(array)} números primos!");
	}
}

class Ex03{
	public static string[] NewArray (string [] x){
		int count = 0;
		for (int i = 0; i < x.Length; i++){
			for (int y = 0; y < x[i].Length; y++){
				if (y == 3) count++;
				break;
			} 
		}

		string [] array = new string [count];

		count = 0;

		for (int i = 0; i < x.Length; i++){
			for (int y = 0; y < x[i].Length; y++) if (y >= 3){
				array[count] = x[i];
				count++;
			}
		}

		return array;
	}



	public static void Main (){	
		Console.WriteLine("Digite a quantidade de elementos do vetor:");
		int n = int.Parse(Console.ReadLine());

		string [] array = new string [n];

		for (int i = 0; i < n; i++){
			Console.WriteLine($"Digite a {i+1}° palavra do vetor:");
			array[i] = Console.ReadLine();
		}

		Console.WriteLine($"{NewArray(array)}");
	}
}

class Ex05{
	public static bool Palindromoo (char [] x){
		bool palindromo = true;
		for (int i = 0, y = x.Length - 1; i <= y; i++) if (x[i] != x[y]) palindromo = false;

		return palindromo;
	}

	public static void Main (){	
		Console.WriteLine("Digite a quantidade de elementos do vetor:");
		int n = int.Parse(Console.ReadLine());

		char [] array = new char [n];

		for (int i = 0; i < n; i++){
			Console.WriteLine($"Digite a {i+1}° letra do vetor:");
			array[i] = char.Parse(Console.ReadLine());
		}
		if (Palindromoo(array)) Console.WriteLine($"É palíndromo");
		else Console.WriteLine($"Não é palíndromo");
	}
}

class Ex06{
	public static bool BiggerSum (int [,] mat, int l, int c){
		int bigger = 0, linha = 0, sumDiag = 0;
		bool colum = false, diag = false;
		for (int i = 0; i < l; i++){
			int sumLinha = 0, sumColuna = 0;
            for(int j = 0; j < c; j++){
				mat[i,j] += sumLinha;
				mat[j,i] += sumColuna;
				if(i==j) mat[i,j] += sumDiag;
			}
			if (sumLinha > sumColuna && sumLinha > bigger) {
				bigger = sumLinha;
				linha = i;
				colum = false;
			} else if (sumLinha < sumColuna && sumColuna > bigger){
				bigger = sumLinha;
				linha = i;
				colum = true;
			}
        }
		if (sumDiag > bigger) diag = true;

		int [] result = new int[l];
		int count = 0;

		for (int i = 0; i < l; i++){
            for(int j = 0; j < c; j++){
				if (diag && i == j){
					result[count] = mat[i,j];
					count++;
				}
				if (colum){
					result[count] = mat[i,j];
					count++;
				}
			}
        }

		return colum;
	}

	public static void Main (){	
		int [,] mat = new int [3,3];

		for (int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
				Console.WriteLine($"Digite a {i+1}° letra do vetor:");
				mat[i,j] = int.Parse(Console.ReadLine());
			}
        }

		if (BiggerSum(mat, 3, 3)) Console.WriteLine($"É palíndromo");
		else Console.WriteLine($"Não é palíndromo");
	}
}

class Ex07{
	public static int[,] Multip (int [,] mat, int l, int c, int n){

		for (int i = 0; i < l; i++){
            for(int j = 0; j < c; j++){
				mat[i,j] *= n;
			}
        }

		return mat;
	}

	public static void Main (){	
		int [,] mat = new int [3,3];

		for (int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
				Console.WriteLine($"Digite a {i+1}° letra do vetor:");
				mat[i,j] = int.Parse(Console.ReadLine());
			}
        }

		Console.WriteLine("Digite o valor escalar:");
		int n = int.Parse(Console.ReadLine());

		Multip(mat, 3, 3, n);
	}
}

class Ex08{
	public static int[] Sums (int [,] mat, int l, int c){

		int [] result = new int[l+c];

		for (int i = 0, h = 0; i < l; i++){
			int sumColum = 0, sumLinha = 0;
            for(int j = 0; j < c; j++){
				mat[i,j] += sumLinha;
				mat[j,i] += sumColum;
			}
			result[h] = sumLinha;
			result[h+1] = sumColum;
			h += 2;
        }

		return result;
	}

	public static void Main (){	
		int [,] mat = new int [3,3];

		for (int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
				Console.WriteLine($"Digite a {i+1}° letra do vetor:");
				mat[i,j] = int.Parse(Console.ReadLine());
			}
        }

		Console.WriteLine("Digite o valor escalar:");
		int n = int.Parse(Console.ReadLine());

		Sums(mat, 3, 3);
	}
}

class Ex04{
	public static int[] Sums (int [,] mat, int l, int c){

		int [] result = new int[l*c];
		int position = 0;

		for (int i = 0, h = 0; i < l; i++){
            for(int j = 0; j < c; j++){
				int n = mat[i,j], count = 0;
				for(int p = 0; p < l; p++){
					for(int q = 0; q < c; q++){
						if(mat[p,q] == n) count++;
					}
				}
				if (count == 1){
					result[position] = n;
				}
			}
        }

		return result;
	}

	public static void Main (){	
		int [,] mat = new int [3,3];

		for (int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
				Console.WriteLine($"Digite a {i+1}° letra do vetor:");
				mat[i,j] = int.Parse(Console.ReadLine());
			}
        }

		Console.WriteLine("Digite o valor escalar:");
		int n = int.Parse(Console.ReadLine());

		Sums(mat, 3, 3);
	}
}