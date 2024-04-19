int numero = 0, max = 0, contador = 0, aux = 0;

Console.WriteLine("\n-----Incrementar Numero-----\n");

Console.Write("Digite o numero que será incrementado: ");
numero = int.Parse(Console.ReadLine());

Console.Write("Digite o numero incrementador: ");
max = int.Parse(Console.ReadLine());


Console.WriteLine("Aqui é o for-loop");
aux = numero;
Console.WriteLine(aux);
for (contador = 0; contador < max; contador++)
{
    aux++;
    Console.WriteLine(aux);
}


Console.WriteLine("Aqui é o do-while");
aux = numero;
contador = 0;
Console.WriteLine(aux);
do
{
    aux++;
    contador++;
    Console.WriteLine(aux);
} while (contador < max);


Console.WriteLine("Aqui é o while");
contador = 0;
aux = numero;
Console.WriteLine(aux);
while (contador < max)
{
    aux++;
    contador++;
    Console.WriteLine(aux);
}


Console.WriteLine("Pressione qualquer tecla para continuar...");
Console.ReadKey();