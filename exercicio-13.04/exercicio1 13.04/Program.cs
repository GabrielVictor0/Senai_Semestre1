


Console.WriteLine($"Informe o ano em que você nasceu: ");
int anoNasceu = int.Parse(Console.ReadLine());

int anoAtual = DateTime.Now.Year;
int podeVotar = DateTime.Now.Year - anoNasceu;
Console.WriteLine($" Você tem :{podeVotar} anos");

if(podeVotar <= 15 )
{
    Console.WriteLine($"Desculpe, mas você ainda não esta apto a votar!");
}
else if( podeVotar <= 16 && podeVotar < 18)
{
    Console.WriteLine($"Você esta apto a votar, mas não é obrigado!");   
}
else
{
    Console.WriteLine($"Você tem que votar obrigatoriamente!");
    
}