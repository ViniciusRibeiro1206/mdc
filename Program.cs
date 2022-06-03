int dividendo, divisor, resto;

Console.WriteLine("Máximo divisor Comum (método interativo)\n");

Console.Write("Digite o dividendo (a):");
dividendo = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Digite o divisor (a):");
divisor = Convert.ToInt32(Console.ReadLine()!);

do
{
    resto = dividendo % divisor;
    dividendo = divisor;
    divisor = resto;
}
while (resto != 0);

Console.WriteLine($"MDC (a,b) = {dividendo}");
