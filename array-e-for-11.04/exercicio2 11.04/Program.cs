string[] nome = new string[5];

int[] idade = new int[5];

for(var i = 0; i < 5; i++)
{
    Console.WriteLine($" {i+1}º Informe seu nome: ");
    nome[i] = Console.ReadLine();
    
    Console.WriteLine(@$" {i+1}º Informe sua idade: "
    
    );
    idade[i] = int.Parse(Console.ReadLine());
    
}

for( var i = 0; i < 5; i++)
{
    Console.WriteLine(@$" 
   
{i+1}º nome e idade: ");
    
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($" nome: {nome[0]}");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($" idade: {idade[0]}");
    Console.ResetColor();
    
}

