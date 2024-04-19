float n1, n2, media = 0;

Console.WriteLine("\n-----Calcular notas-----\n");

Console.Write("Digite a nota(1): ");
n1 = float.Parse(Console.ReadLine());

Console.Write("Digite a nota(2): ");
n2 = float.Parse(Console.ReadLine());

if(n1 < 0 || n2 < 0 || n1 > 10 || n2 > 10)
{
    Console.WriteLine("Entradas inválidas! Os valores devem ser entre 0-10");
}
else
{
    media = (n1 + n2) / 2;
    Console.WriteLine($"Media: {media}");

    if (media <= 3)
    {
        Console.WriteLine("Aluno reprovado!");
    }
    else if (media > 3 && media <= 5)
    {
        Console.WriteLine("Aluno em exame!");
    }
    else
    {
        Console.WriteLine("Aluno Aprovado!");
    }
}

Console.WriteLine("Pressione qualquer tecla para continuar...");
Console.ReadKey();
