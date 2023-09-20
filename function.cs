using System;

class Program{
	public int multiplication(int x, int y){
		int total = x * y;
		return total;
	}
	public static void Main(string[] args){
		Program calculadora = new Program();
		int num1 = 8;
		int num2 = 6;
		int resultado;
		
		resultado = calculadora.multiplication(num1, num2);
		Console.WriteLine(resultado);
	}
}