using List;

//criar uma lista de objetos (Produtos) create
List<Produto> produtos = new List<Produto>();

//inserir objetos de produtos dentro da lista
//através de uma instância direta (com construtor)
produtos.Add(new Produto("camiseta lacoste", 1234, 19.99f));

// através de uma instância básica de objeto
Produto camisetaArmani = new Produto("camiseta armani", 1235, 46.89f);
produtos.Add(camisetaArmani);

Console.WriteLine($"Produto antes da alteração");


//read
foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo} Nome: {item.Nome} Preço: {item.Preco:C} Índice: {produtos.IndexOf(item)}");
}

Console.WriteLine(@$"
************************************");

//Update

// acessar um objeto da lista para poder manipular
Produto produtoEncontrado = produtos.Find(item => item.Codigo == 1235);

//encontrar o indice do produto encontrado
int index = produtos.IndexOf(produtoEncontrado);

//exibir o indice no console 
Console.WriteLine($"O índice do produto encontrado {produtoEncontrado.Nome} é o: {index}");

//fazer alteração 
produtoEncontrado.Preco = 599f;

//remover o item antigo da lista
produtos.RemoveAt(index);

//devolver o item atualizado no lugar
produtos.Insert(index, produtoEncontrado);

Console.WriteLine($"Produtos depois da alteração");

foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo} Nome: {item.Nome} Preço: {item.Preco:C} Índice: {produtos.IndexOf(item)}");
}

//delete

produtos.RemoveAt(0);

Console.WriteLine(@$"
Produtos após exclusão");
Console.WriteLine($"***********************************");

foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo} Nome: {item.Nome} Preço: {item.Preco:C} Índice: {produtos.IndexOf(item)}");
}







