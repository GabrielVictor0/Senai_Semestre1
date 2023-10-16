using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace construtores
{
    public class Produtos
    {   
        //PROPRIEDADES
        public string Nome {get;set;}

        public int Codigo {get;set;}

        public int Estoque {get;set;}

        //CONSTRUTORES
        public Produtos()
        {
            
        }

        public Produtos(int codigo)
        {
            Codigo = codigo;
        }

        public Produtos(string nome, int codigo, int estoque)
        {
            Nome = nome;
            Codigo = codigo;
            Estoque = estoque;
        }
    }
}