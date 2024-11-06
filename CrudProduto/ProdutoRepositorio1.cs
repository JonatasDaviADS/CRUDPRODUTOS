using System;
using System.Collections.Generic;

namespace CrudProduto
{
    internal class ProdutoRepositorio
    {
        private List<Produto> produtos = new List<Produto>();  // Lista para armazenar os produtos

        public ProdutoRepositorio()
        {
        }

        internal void Adicionar(Produto novoProduto)
        {
            // Adiciona o novo produto à lista
            produtos.Add(novoProduto);
            Console.WriteLine("Produto adicionado com sucesso!");
        }

        internal List<Produto> Listar()
        {
            // Retorna a lista de produtos
            return produtos;
        }

        internal void Excluir(int idExcluir)
        {
            // Encontra o produto pelo ID e o remove
            var produto = produtos.Find(p => p.Id == idExcluir);
            if (produto != null)
            {
                produtos.Remove(produto);
                Console.WriteLine("Produto excluído com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        internal void Atualizar(int idAtualizar, Produto produtoAtualizado)
        {
            // Encontra o produto pelo ID e o atualiza
            var produto = produtos.Find(p => p.Id == idAtualizar);
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
    }
}
