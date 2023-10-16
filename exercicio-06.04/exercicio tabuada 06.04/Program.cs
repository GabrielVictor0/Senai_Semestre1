Console.WriteLine($"Informe um número para realizar a tabuada: ");
int i = int.Parse(Console.ReadLine());
int t;

for(t = 1; t<=10; t++)
{
    Console.WriteLine($"{i} * {t} = {i*t}");
}