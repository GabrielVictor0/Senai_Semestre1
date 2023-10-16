int nota;

do
{
    Console.WriteLine($"Informe uma nota de 0 a 10: ");
    nota = int.Parse(Console.ReadLine());
    
} while (nota < 0 || nota > 10 );