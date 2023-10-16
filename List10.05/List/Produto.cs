
namespace List
{
    public class Produto
    {
        //propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        //construtores
        public Produto()
        {

        }

        public Produto(string _nome, int _codigo, float _preco)
        {
            Nome = _nome;
            Codigo = _codigo;
            Preco = _preco;
        }

    }
}