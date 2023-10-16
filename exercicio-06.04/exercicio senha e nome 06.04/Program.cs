string nome;

string senha;

    Console.WriteLine($"Informe seu nome: ");
    nome = Console.ReadLine().ToLower();

    while(nome == "" || nome == " " )
    {
        Console.WriteLine($"Informe seu nome corretamente: ");
        nome = Console.ReadLine().ToLower();        
    }
    
do
{
    Console.WriteLine($"Informe sua senha: ");
    senha = Console.ReadLine().ToLower(); 
} while ( senha == nome);
