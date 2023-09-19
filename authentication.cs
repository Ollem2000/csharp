using system;

class Program{
	public static void Main(string[] args){
		String nome, senha;
		
		Console.WriteLine("Digite o nome do usuário");
		name = Console.ReadLine();
		
		Console.WriteLine("Digite o senha do usuário");
		password = Console.ReadLine();
		
		if(name == "Maria" && password == "pass"){
			Console.WriteLine("Bem-vindo: "+name);
		}
		else{
			Console.WriteLine("Verifique o usuário ou senha");
		}
	}
}