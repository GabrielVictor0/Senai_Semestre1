//SOMA-------------------------------------------
float primeiroNumero;
float segundoNumero;

Console.WriteLine($"Qual operação você deseja realizar( adição, subtração, multiplicação, divisão): ");
string operacao = Console.ReadLine().ToLower();

if (operacao == "adição")
{
    static float Somar(float n1, float n2)
    {
        return (n1 + n2);
    }

    Console.WriteLine($"Informe o primeiro número: ");
    primeiroNumero = float.Parse(Console.ReadLine());

    Console.WriteLine($"Informe o segundo número: ");
    segundoNumero = float.Parse(Console.ReadLine());

    Console.WriteLine($"A soma de {primeiroNumero} + {segundoNumero} é : {Somar(primeiroNumero, segundoNumero)}");
}




// //SUBTRAÇÃO----------------------------------------
// static float Subtrair(float n1, float n2)
// {
//     return(n1 - n2);
// }

// Console.WriteLine($"Informe o primeiro número: ");
// float primeiroNumeroSubtrair = float.Parse(Console.ReadLine());

// Console.WriteLine($"Informe o segundo número: ");
// float segundoNumeroSubtrair = float.Parse(Console.ReadLine());

// //Console.WriteLine($"A subtração de {primeiroNumeroSubtrair} - {segundoNumeroSubtrair} é : {Subtrair(primeiroNumeroSubtrair, segundoNumeroSubtrair)}");


// //DIVISÃO------------------------------------
// static float Divisao(float n1, float n2)
// {
//     return(n1 / n2);
// }

// Console.WriteLine($"Informe o primeiro número: ");
// float primeiroNumeroDiv = float.Parse(Console.ReadLine());

// Console.WriteLine($"Informe o segundo número: ");
// float segundoNumeroDiv = float.Parse(Console.ReadLine());

// //Console.WriteLine($"A divisão de {primeiroNumeroDiv} / {segundoNumeroDiv} é : {Divisao(primeiroNumeroDiv, segundoNumeroDiv)}");



// //MULTIPLICAÇÃO
// static float Multiplicacao(float n1, float n2)
// {
//     return(n1 * n2);
// }

// Console.WriteLine($"Informe o primeiro número: ");
// float primeiroNumeroMult = float.Parse(Console.ReadLine());

// Console.WriteLine($"Informe o segundo número: ");
// float segundoNumeroMult = float.Parse(Console.ReadLine());

// //Console.WriteLine($"A multiplicação de {primeiroNumeroMult} X {segundoNumeroMult} é : {Multiplicacao(primeiroNumeroMult, segundoNumeroMult)}");



