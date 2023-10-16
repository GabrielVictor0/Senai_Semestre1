Console.WriteLine($"Informe o raio da circunferência: ");
float raio = float.Parse(Console.ReadLine());

float diametro = raio*2;
double comprimento = Math.PI*diametro;
double area = Math.PI*Math.Pow(raio,2);

Console.WriteLine($"O diâmetro da circunferência é {diametro}");

Console.WriteLine($"O comprimento da circunferência é {comprimento}");

Console.WriteLine($"A área da circunferência é {area}");




