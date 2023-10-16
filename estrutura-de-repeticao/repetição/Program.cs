
Console.WriteLine($"Informe o seu nome: ");
string nome = Console.ReadLine();

while (nome == "" || nome == " ")
{
    Console.WriteLine($"Informe o seu nome novamente:");
    nome = Console.ReadLine();  
}

Console.WriteLine($"Informe sua idade(entre 0 e 100 anos): ");
int idade = int.Parse(Console.ReadLine());

while (idade > 100 || idade < 0)
{
    Console.WriteLine($"Informe sua idade novamente(entre 0 e 100 anos):");
    idade = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Informe seu salário: ");
float salario = float.Parse(Console.ReadLine());

while(salario <= 0)
{
    Console.WriteLine($"Informe seu salário novamente: ");
    salario = float.Parse(Console.ReadLine());
}

Console.WriteLine($"Informe seu Estado Civil ('s'solteiro(a), 'c'casado(a), 'v'viuvo(a), 'd'divorciado(a) ): ");
char estadoCivil = char.Parse(Console.ReadLine().ToLower());

while (estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd')
{
    Console.WriteLine($"Informe seu Estado Civil novamente");
    estadoCivil = char.Parse(Console.ReadLine());
}
    Console.WriteLine(@$"
    
                                                    Obrigado por utilizar nosso sistema! :)
    
    
    ");
    

