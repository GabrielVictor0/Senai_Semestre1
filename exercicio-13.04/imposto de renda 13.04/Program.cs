static float Imposto(float a )
{
  if(a <= 1500)
  {
    return 0 ;
  }
  else if(a > 1500 && a <= 3500)
  {
    return a/100 * 20;
  }
  else if(a >= 3501 && a <= 6000)
  {
    return a/100 * 25;
  }
  else
  {
    return a/100 * 35;
  }
}
Console.WriteLine($"Informe sua renda: ");
float renda = float.Parse(Console.ReadLine());


float impostoDevido = Imposto(renda);

Console.WriteLine($"O valor a ser pago pelo imposto de renda é: {impostoDevido}");


