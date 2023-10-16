Console.WriteLine($"Insira o primeiro número: ");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Insira o segundo número: ");
float n2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Insira o terceiro número: ");
float n3 = float.Parse(Console.ReadLine());

//CONDIÇÃO MAIOR 
if(n1>n2 && n1>n3)
{
    Console.WriteLine($"O n1({n1}) é o maior número");    
}

if(n2>n1 && n2>n3){
    Console.WriteLine($"O n2({n2}) é o maior número");
}

if(n3>n2 && n3>n1)
{
    Console.WriteLine($"O n3({n3}) é o maior número");
}

//CONDIÇÃO MENOR
if(n1<n2 && n1<n3)
{
    Console.WriteLine($"O n1({n1}) é o menor número");
}

if(n2<n1 && n2<n3)
{
    Console.WriteLine($"O n2({n2}) é o menor número");  
}

if(n3<n2 && n3<n1)
{
    Console.WriteLine($"O n3({n3}) é menor número");  
}






