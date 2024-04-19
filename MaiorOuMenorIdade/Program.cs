int idade;

Console.WriteLine("\n-----Calcular idade Maior-----\n");

Console.Write("Digite sua idade: ");
idade = int.Parse(Console.ReadLine());


if (idade < 0)
{
    Console.WriteLine("Idade inválida!");
}
else if (idade < 18)
{   
    Console.WriteLine("Voce é menor de idade!");
}
else
{
    Console.WriteLine("Voce é maior de idade!");
}

Console.WriteLine("Pressione qualquer tecla para continuar...");
Console.ReadKey();
