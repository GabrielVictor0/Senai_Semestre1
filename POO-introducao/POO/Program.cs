// using POO;

// //instaciamos um objeto da classe Personagem 
// Personagem tony = new Personagem();

// //exibindo as informções do objeto 
// Console.WriteLine(tony.nome);
// Console.WriteLine(tony.idade);
// Console.WriteLine(tony.armadura);
// Console.WriteLine(tony.ia);

// //chamando os métodos 

// //só invocar pois ele só exibe (void)
// tony.Atacar();

// //chamei o cwl pois o método retorna uma string
// Console.WriteLine(tony.Defender());

// // só invocar pois ele só exibe (void)
// tony.RestaurarArmadura();

using POO;

Personagem p1 = new Personagem();

Console.WriteLine($"Digite o nome do seu personagem: ");
p1.nome = Console.ReadLine();

Console.WriteLine($"DIgite a idade do seu personagem: ");
p1.idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o nome da armadura de seu personagem: ");
p1.armadura = Console.ReadLine();

Console.WriteLine($"Digite o nome da ia do seu personagem: ");
p1.ia = Console.ReadLine();

Console.WriteLine(@$"
{p1.nome}
{p1.idade}
{p1.armadura}
{p1.ia}
");












