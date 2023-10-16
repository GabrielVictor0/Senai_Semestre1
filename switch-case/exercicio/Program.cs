Console.WriteLine($"Informe a bebida que você deseja (Opções: suco de uva, suco de laranja, coca-cola, h2o): ");
string escolhida = Console.ReadLine().ToLower();

Console.WriteLine($" Você quer acrescentar gelo em sua bebida?(sim ou nao) ");
string gelo = Console.ReadLine().ToLower();

switch (escolhida)
{
    case "coca-cola":
        if (gelo == "sim")
        {
            Console.WriteLine($"Sua coca-cola esta com gelo!");

        }
        else
        {   
            Console.WriteLine($"Sua coca-cola sem gelo!");
            
        }
        break;

    case "suco de uva":
        if (gelo == "sim")
        {
            Console.WriteLine($"Seu suco de uva esta com gelo! ");
        }
        else
        {
            Console.WriteLine($"Seu suco de uva sem gelo!");
            
        }
        break;

    case "suco de laranja":
        if (gelo == "sim")
        {
            Console.WriteLine($"Desculpe, mas no momento está bebida esta sem a opção de gelo :( ");
        }
        else
        {
            Console.WriteLine($"Seu suco de laranja sem gelo!");
        }
        break;

    case "h2o":
        if (gelo == "sim")
        {
            Console.WriteLine($"Sua h20 esta com gelo!");
        }
        else 
        {
            Console.WriteLine($"Sua h2o sem gelo!");
        }
        break;

    default:
        Console.WriteLine($"A bebida escolhida não existe em nosso menu!");
        break;
}


