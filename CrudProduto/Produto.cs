using System;
using System.Collections.Generic;
using System.Text;

namespace CrudProduto
{
    public class Produto
    {
        public int Id { get; set; }
        // Aqui coloquei um número inteiro que identifica o produto
        public string Nome { get; set; }
        // Aqui temos no nome do produto. Um tipo String 
        public decimal Preco { get; set; }

        public Produto(int id, string nome, decimal preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }
        // Aqui temos o valor do produto. Como é um valor usamos um decimal



    }
}
