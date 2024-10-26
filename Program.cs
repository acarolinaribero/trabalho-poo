using System;
using System.Collections.Generic;

namespace atividade_poo
{
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
}


