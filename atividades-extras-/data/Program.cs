Console.WriteLine($"Informe o dia de seu aniversário: ");
int dia = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o mes de seu aniversário: ");
int mes = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o ano de seu aniversário: ");
int ano = int.Parse(Console.ReadLine());

if(dia<=31 && mes<=12 && ano<=2013)
{
    Console.WriteLine($"Data válida!");
    
}
else
{
    Console.WriteLine($"Data inválida!");
    
}