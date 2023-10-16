Console.WriteLine($"Tipo de combustível ('a' para Álcool e 'g' para Gasolina): ");
char combustivel = char.Parse(Console.ReadLine().ToLower());

Console.WriteLine($"Quantos litros você ira abastecer: ");
float quantidade = float.Parse(Console.ReadLine());

static float ValorPagar(float a, char b)
{   
   if(b == 'a' && a <=20)
   {
    return a * 4.90f / 100 * 3;
    
   }
   return 0;
}

ValorPagar(quantidade, combustivel);