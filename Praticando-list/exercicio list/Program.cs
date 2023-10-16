using exercicio_list;

Carro x = new Carro();

List<Carro> carros = new List<Carro>();

for (var i = 1; i <= 2; i++)
{

    Console.WriteLine($"Informe a marca do {i}º carro: ");
    x.Marca = Console.ReadLine();

    Console.WriteLine($"Informe a cor do {i}º carro: ");
    x.Cor = Console.ReadLine();

    carros.Add(new Carro(x.Marca, x.Cor));
    
}

foreach (var item in carros)
{
    Console.WriteLine(@$" 
    Nome do carro: {item.Marca} 
    Marca do carro: {item.Cor} 
    Índice do carro: {carros.IndexOf(item)} ");
    
}
