using System;
using System.Collections.Generic;

using System;

class Program
{
    const int LIMITE = 30;
    static string[] categorias = new string[LIMITE];
    static string[] fornecedores = new string[LIMITE];
    static string[] produtos = new string[LIMITE];
    static int[] produto_categoria = new int[LIMITE];
    static int[] produto_fornecedor = new int[LIMITE];
    static int contador_categoria = 0;
    static int contador_fornecedor = 0;
    static int contador_produto = 0;

    static void Main()
    {
        PopularBancoDados();
        int opcao;

        do
        {
            Console.WriteLine("BEM VINDO AO MEU ERP DE VENDAS DE CELULARES \n");
            Separador('=', 100);
            Console.WriteLine("CADASTRO GERAL DO SISTEMA \n");
            Console.WriteLine("(1) - Cadastro de Categorias");
            Console.WriteLine("(2) - Cadastro de Fornecedores");
            Console.WriteLine("(3) - Cadastro de Produtos");
            Console.WriteLine("(4) - Listar Categorias");
            Console.WriteLine("(5) - Listar Fornecedores");
            Console.WriteLine("(6) - Listar Produtos");
            Console.WriteLine("(0) - Sair");
            Separador('-', 100);
            Console.Write("Digite sua opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    ModuloCategoria();
                    break;
                case 2:
                    ModuloFornecedor();
                    break;
                case 3:
                    ModuloProduto();
                    break;
                case 4:
                    ListarCategorias();
                    break;
                case 5:
                    ListarFornecedores();
                    break;
                case 6:
                    ListarProdutos();
                    break;
                case 0:
                    Console.WriteLine("Saindo do sistema...\n");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.\n");
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

    static void ModuloCategoria()
    {
        if (contador_categoria < 10)
        {
            Console.Write("Digite o nome da nova categoria (ex: Smartphones, Acessórios, etc.): ");
            categorias[contador_categoria] = Console.ReadLine();
            contador_categoria++;
            Console.WriteLine("Categoria cadastrada com sucesso!\n");
        }
        else
        {
            Console.WriteLine("Limite de categorias atingido!\n");
        }
    }

    static void ModuloFornecedor()
    {
        if (contador_fornecedor < 10)
        {
            Console.Write("Digite o nome do fornecedor (ex: Samsung, Apple, Xiaomi): ");
            fornecedores[contador_fornecedor] = Console.ReadLine();
            contador_fornecedor++;
            Console.WriteLine("Fornecedor cadastrado com sucesso!\n");
        }
        else
        {
            Console.WriteLine("Limite de fornecedores atingido!\n");
        }
    }

    static void ModuloProduto()
    {
        if (contador_produto < 10)
        {
            Console.Write("Digite o nome do produto (ex: iPhone 13, Galaxy S21): ");
            produtos[contador_produto] = Console.ReadLine();

            Console.WriteLine("Escolha uma categoria para o produto: ");
            ListarCategorias();
            Console.Write("Digite o número da categoria: ");
            int categoriaEscolhida = int.Parse(Console.ReadLine());
            produto_categoria[contador_produto] = categoriaEscolhida - 1;

            Console.WriteLine("Escolha um fornecedor para o produto: ");
            ListarFornecedores();
            Console.Write("Digite o número do fornecedor: ");
            int fornecedorEscolhido = int.Parse(Console.ReadLine());
            produto_fornecedor[contador_produto] = fornecedorEscolhido - 1;

            contador_produto++;
            Console.WriteLine("Produto cadastrado com sucesso!\n");
        }
        else
        {
            Console.WriteLine("Limite de produtos atingido!\n");
        }
    }

    static void ListarCategorias()
    {
        if (contador_categoria > 0)
        {
            Console.WriteLine("CATEGORIAS CADASTRADAS: ");
            for (int i = 0; i < contador_categoria; i++)
            {
                Console.WriteLine($"{i + 1}. {categorias[i]}");
            }
        }
        else
        {
            Console.WriteLine("Nenhuma categoria cadastrada.\n");
        }
    }

    static void ListarFornecedores()
    {
        if (contador_fornecedor > 0)
        {
            Console.WriteLine("FORNECEDORES CADASTRADOS: ");
            for (int i = 0; i < contador_fornecedor; i++)
            {
                Console.WriteLine($"{i + 1}. {fornecedores[i]}");
            }
        }
        else
        {
            Console.WriteLine("Nenhum fornecedor cadastrado.\n");
        }
    }

    static void ListarProdutos()
    {
        if (contador_produto > 0)
        {
            Console.WriteLine("PRODUTOS CADASTRADOS: ");
            for (int i = 0; i < contador_produto; i++)
            {
                Console.WriteLine($"Produto: {produtos[i]}, Categoria: {categorias[produto_categoria[i]]}, Fornecedor: {fornecedores[produto_fornecedor[i]]}");
            }
        }
        else
        {
            Console.WriteLine("Nenhum produto cadastrado.\n");
        }
    }

    static void PopularBancoDados()
    {
        string[] categoriasLote = { "Smartphones", "Acessórios", "Carregadores", "Capinhas", "Fones de ouvido" };
        string[] fornecedoresLote = { "Samsung", "Apple", "Xiaomi", "Motorola", "LG" };
        string[] produtosLote = { "Galaxy S21", "iPhone 13", "Redmi Note 10", "Moto G100", "LG Velvet" };

        for (int i = 0; i < 5; i++)
        {
            if (contador_categoria < 10)
            {
                categorias[contador_categoria] = categoriasLote[i];
                contador_categoria++;
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (contador_fornecedor < 10)
            {
                fornecedores[contador_fornecedor] = fornecedoresLote[i];
                contador_fornecedor++;
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (contador_produto < 10)
            {
                produtos[contador_produto] = produtosLote[i];
                produto_categoria[contador_produto] = i;
                produto_fornecedor[contador_produto] = i;
                contador_produto++;
            }
        }

        Console.WriteLine("Banco de dados inicializado com sucesso!\n");
    }
}
