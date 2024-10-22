using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        ERP erp = new ERP();
        erp.PopularBancoDados();
        int opcao;

        do
        {
            Console.WriteLine("BEM VINDO AO MEU ERP DE VENDAS DE CELULARES");
            Separador('=', 50);
            Console.WriteLine("(1) - Cadastro de Categorias");
            Console.WriteLine("(2) - Cadastro de Fornecedores");
            Console.WriteLine("(3) - Cadastro de Produtos");
            Console.WriteLine("(4) - Listar Categorias");
            Console.WriteLine("(5) - Listar Fornecedores");
            Console.WriteLine("(6) - Listar Produtos");
            Console.WriteLine("(0) - Sair");
            Separador('-', 50);
            Console.Write("Digite sua opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    erp.CadastrarCategoria();
                    break;
                case 2:
                    erp.CadastrarFornecedor();
                    break;
                case 3:
                    erp.CadastrarProduto();
                    break;
                case 4:
                    erp.ListarCategorias();
                    break;
                case 5:
                    erp.ListarFornecedores();
                    break;
                case 6:
                    erp.ListarProdutos();
                    break;
                case 0:
                    Console.WriteLine("Saindo do sistema...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

        } while (opcao != 0);
    }

    static void Separador(char simbolo, int quantidade)
    {
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write(simbolo);
        }
        Console.WriteLine();
    }
}

class Categoria
{
    public string Nome { get; set; }

    public Categoria(string nome)
    {
        Nome = nome;
    }
}

class Fornecedor
{
    public string Nome { get; set; }

    public Fornecedor(string nome)
    {
        Nome = nome;
    }
}

class Produto
{
    public string Nome { get; set; }
    public Categoria Categoria { get; set; }
    public Fornecedor Fornecedor { get; set; }

    public Produto(string nome, Categoria categoria, Fornecedor fornecedor)
    {
        Nome = nome;
        Categoria = categoria;
        Fornecedor = fornecedor;
    }
}

class ERP
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
