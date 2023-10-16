Console.WriteLine($"Telefonou para a vítima");
string telefone = (Console.ReadLine().ToLower());

Console.WriteLine($"Esteve no local do crime");
string local = (Console.ReadLine().ToLower());

Console.WriteLine($"Mora perto da vítima");
string mora = (Console.ReadLine().ToLower());

Console.WriteLine($"Devia para a vítima");
string devia = (Console.ReadLine().ToLower());

Console.WriteLine($"Já trabalhou com a vítima");
string trabalho = (Console.ReadLine().ToLower());

if(telefone == "sim")
{
    telefone=telefone += 1;
}

if(local == "sim")
{
    local=local += 1;
}


if(mora == "sim")
{
    mora=mora += 1;
}

if(devia == "sim")
{
    devia=devia += 1;
}

if(trabalho == "sim")
{
    trabalho=trabalho += 1;
}

if(telefone + local + mora + devia + trabalho == 2)






