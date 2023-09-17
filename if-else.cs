using System;

class Program {
	public static void Main (string[] args) {
		Console.WriteLine("Digite dois números: ");
		int num1 = int.Parse(Console.ReadLine());
		int num2 = int.Parse(Console.ReadLine());
		if(num1 > num2){
			Console.WriteLine(num1+" é maior que "+num2);
		}
		else{
			Console.WriteLine(num1+" é menor que "+num2);      
		}
	}
}