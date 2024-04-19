int numero;

Console.WriteLine("\n-----Impar ou Par-----\n");

Console.Write("Digite um número: ");
numero = int.Parse(Console.ReadLine());

if(numero % 2 == 0)
{
    Console.WriteLine("O numero digitado é par\n");
}
else
{
    Console.WriteLine("O numero digitado é impar\n");
}

Console.WriteLine("Pressione qualquer tecla para continuar...");
Console.ReadKey();