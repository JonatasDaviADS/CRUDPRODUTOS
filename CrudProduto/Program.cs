using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CrudProduto
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            var repositorio = new ProdutoRepositorio();
            while (true)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Adicionar Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Atualizar Produto");
                Console.WriteLine("4 - Excluir Produto");
                Console.WriteLine("5 - Sair");

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        Console.Write("Digite o id:");
                        int Id = int.Parse(Console.ReadLine());
                        Console.Write("Digite o nome do produto:");
                        string Nome = Console.ReadLine();
                        Console.Write("Digite o preço do produto:");
                        decimal Preco = decimal.Parse(Console.ReadLine());
                        var novoProduto = new Produto(Id, Nome, Preco);
                        repositorio.Adicionar(novoProduto);
                        break;

                    case "2":
                        repositorio.Listar();
                        break;
                        

                    case "3":
                        Console.Write("Digite o ID do produtor a atualizar:");
                        int idAtualizar = int.Parse(Console.ReadLine());
                        Console.Write("Digite o novo nome do produto:");
                        Nome = Console.ReadLine();
                        Console.Write("Digite o novo preço do produto:");
                        Preco = decimal.Parse(Console.ReadLine());
                        var produtoAtualizado = new Produto(idAtualizar, Nome, Preco);
                        repositorio.Atualizar(idAtualizar, produtoAtualizado);
                        break;



                    case "4":
                        Console.Write("Digite o ID do produto para excluir:");
                        int idExcluir = int.Parse(Console.ReadLine());
                        repositorio.Excluir(idExcluir);
                        break;


                    case "5":
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
         
        }

        private static object NewMethod(ProdutoRepositorio repositorio)
        {
            return repositorio.Listar();
        }
    }
}
