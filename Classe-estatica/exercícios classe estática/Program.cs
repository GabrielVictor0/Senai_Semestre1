//Exercício : Faça um programa de conversão de moedas(câmbio) usando classe, membro e métodos estáticos.
//Menu de opções : dólar para real, real para dólar, sair
//Personalizar a resposta, usando recursos da linguagem(Bibliotecas)
using exercícios_classe_estática;
using System.Globalization;

CultureInfo culture = new CultureInfo("pt-BR");

string opcao;
do
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(@$"
===================
1 - Dólar para real
2 - Real para dólar
0 - Sair           
===================");
    opcao = Console.ReadLine();
    Console.ResetColor();
    switch (opcao)
    {
        case "1":
            Console.WriteLine(@$"
Informe a quantia de dolar a ser convertido: ");
            ConverterMoeda.qtdDolar = int.Parse(Console.ReadLine());

            Console.WriteLine(@$" 
A quantia de {ConverterMoeda.qtdDolar.ToString("C", CultureInfo.CreateSpecificCulture("en-us"))} convertida para real é de: {ConverterMoeda.DolarParaReal(ConverterMoeda.qtdDolar).ToString("C", CultureInfo.CreateSpecificCulture("pt-br"))}");

            break;
        case "2":
            Console.WriteLine($"Informe a quantia de real a ser convertida: ");
            ConverterMoeda.qtdReal = int.Parse(Console.ReadLine());

            Console.WriteLine(@$" 
A quantia de {ConverterMoeda.qtdReal.ToString("C", CultureInfo.CreateSpecificCulture("pt-br"))} convertida para dólar é de: {ConverterMoeda.RealParaDolar(ConverterMoeda.qtdReal).ToString("C", CultureInfo.CreateSpecificCulture("en-us"))}");

            break;
        default:
            Console.WriteLine(@$"
Sistema finalizado!");
            break;
    }

} while (opcao != "0");






