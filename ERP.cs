using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_poo
{
    internal class ERP
    {
        private const int LIMITE = 30;
        private List<Categoria> categorias = new List<Categoria>();
        private List<Fornecedor> fornecedores = new List<Fornecedor>();
        private List<Produto> produtos = new List<Produto>();

        public void CadastrarCategoria()
        {
            if (categorias.Count < LIMITE)
            {
                Console.Write("Digite o nome da nova categoria: ");
                string nomeCategoria = Console.ReadLine();
                categorias.Add(new Categoria(nomeCategoria));
                Console.WriteLine("Categoria cadastrada com sucesso!");
            }
            else
            {
                Console.WriteLine("Limite de categorias atingido!");
            }
        }

        public void CadastrarFornecedor()
        {
            if (fornecedores.Count < LIMITE)
            {
                Console.Write("Digite o nome do fornecedor: ");
                string nomeFornecedor = Console.ReadLine();
                fornecedores.Add(new Fornecedor(nomeFornecedor));
                Console.WriteLine("Fornecedor cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Limite de fornecedores atingido!");
            }
        }

        public void CadastrarProduto()
        {
            if (produtos.Count < LIMITE)
            {
                Console.Write("Digite o nome do produto: ");
                string nomeProduto = Console.ReadLine();

                Console.WriteLine("Escolha uma categoria:");
                ListarCategorias();
                Console.Write("Digite o número da categoria: ");
                int indiceCategoria = int.Parse(Console.ReadLine()) - 1;

                Console.WriteLine("Escolha um fornecedor:");
                ListarFornecedores();
                Console.Write("Digite o número do fornecedor: ");
                int indiceFornecedor = int.Parse(Console.ReadLine()) - 1;

                Produto novoProduto = new Produto(nomeProduto, categorias[indiceCategoria], fornecedores[indiceFornecedor]);
                produtos.Add(novoProduto);
                Console.WriteLine("Produto cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Limite de produtos atingido!");
            }
        }

        public void ListarCategorias()
        {
            if (categorias.Count > 0)
            {
                Console.WriteLine("CATEGORIAS CADASTRADAS:");
                for (int i = 0; i < categorias.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {categorias[i].Nome}");
                }
            }
            else
            {
                Console.WriteLine("Nenhuma categoria cadastrada.");
            }
        }

        public void ListarFornecedores()
        {
            if (fornecedores.Count > 0)
            {
                Console.WriteLine("FORNECEDORES CADASTRADOS:");
                for (int i = 0; i < fornecedores.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {fornecedores[i].Nome}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum fornecedor cadastrado.");
            }
        }

        public void ListarProdutos()
        {
            if (produtos.Count > 0)
            {
                Console.WriteLine("PRODUTOS CADASTRADOS:");
                for (int i = 0; i < produtos.Count; i++)
                {
                    Produto produto = produtos[i];
                    Console.WriteLine($"{i + 1}. Produto: {produto.Nome}, Categoria: {produto.Categoria.Nome}, Fornecedor: {produto.Fornecedor.Nome}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum produto cadastrado.");
            }
        }

        public void PopularBancoDados()
        {
            // Cadastrar categorias e fornecedores iniciais
            string[] categoriasLote = { "Smartphones", "Acessórios", "Carregadores", "Capinhas", "Fones de ouvido" };
            string[] fornecedoresLote = { "Samsung", "Apple", "Xiaomi", "Motorola", "LG" };
            string[] produtosLote = { "Galaxy S21", "iPhone 13", "Redmi Note 10", "Moto G100", "LG Velvet" };

            for (int i = 0; i < 5; i++)
            {
                categorias.Add(new Categoria(categoriasLote[i]));
                fornecedores.Add(new Fornecedor(fornecedoresLote[i]));
                produtos.Add(new Produto(produtosLote[i], categorias[i], fornecedores[i]));
            }

            Console.WriteLine("Banco de dados inicializado com sucesso!");
        }
    }
}
