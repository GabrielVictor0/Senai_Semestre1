
namespace exercícios_classe_estática
{
    public static class ConverterMoeda
    {
        public static float dolar {get;set;} = 5;

        public static float qtdDolar {get;set;}

        public static float qtdReal {get; set;}
        public static float DolarParaReal(float qtdDolar)
        {
           return (qtdDolar * dolar);
        }

        public static float RealParaDolar(float qtdReal)
        {
            float real = qtdReal;

            return real / dolar;  
        }

    }
}