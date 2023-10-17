//criar um array de strings para armazenar 3 carros
// string[] carros = new string[3];

// for (int i = 0; i < 3; i++)
// {
//     Console.WriteLine($"Informe o nome do carro: ");    
//     carros[i] = Console.ReadLine();    
// }

// Console.WriteLine($"Lista dos carros cadastrados: ");

// for (var i = 0; i < 3; i++)
// {
//     Console.WriteLine($"Nome do carro: {carros[i]}");    
// }

// foreach (var item in carros)
// {
//     Console.WriteLine(item);    
// }

int[] numeros = new int[5];

for(int i = 0; i <=4; i++)
{
    Console.WriteLine($"Informe um número inteiro qualquer: ");
    numeros [i] = int.Parse(Console.ReadLine());
}

foreach(int item in numeros)
{
    Console.WriteLine($" O dobro dos números informados: {item*2}");
    
}