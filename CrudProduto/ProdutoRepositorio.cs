using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CrudProduto
{
    public class CrudProduto

    {
        // metodo para adicionar o produto 
        public List<Produto> produtos = new List<Produto>();
        //public int contandoId = 1; 
        // aqui temos a criação de uma lista com o List e um contador do Id

        public void Adicionar (Produto produto)
        {
            // produto.Id = contandoId++;
            produtos.Add(produto);
            Console.WriteLine("Produto adicionado!");
        }

        // metodo para listar todos os pordutos adicionados 
        public void Listar()
        {
            foreach (var produto in produtos)
            {
                Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Preço: {produto.Preco:C}");
            }
        }

        // metodo para atualizar um produto com busca pelo ID 
        public void Atualizar (int id, Produto produtoAtualizado)
        {
            var produto = produtos.FirstOrDefault(p => p.Id == id);
            if (produto != null)
            {
                produto.Nome = produtoAtualizado.Nome;
                produto.Preco = produtoAtualizado.Preco;
                Console.WriteLine("Produto atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
        // aqui temos a criação do metodo Excluir. Procura produto pelo Id
        public void Excluir(int id)
        {
            var produto = produtos.FirstOrDefault(p => p.Id == id);
            if(produto != null)
            {
                produtos.Remove(produto);
                Console.WriteLine("Produto excluído com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

    }
}
