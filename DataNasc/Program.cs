string nome;
int idade, nasc;


Console.WriteLine("\n-----Calcular idade-----\n");

Console.Write("Digite seu nome: ");
nome = Console.ReadLine();

Console.Write("Digite seu ano de nascimento: ");
nasc = int.Parse(Console.ReadLine());
idade = 2024 - nasc;

Console.WriteLine($"Bem-vindo {nome}!, sua idade é: {idade}\n");

Console.WriteLine("Digite qualquer tecla para sair");
Console.ReadKey();