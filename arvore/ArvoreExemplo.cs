using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArvoreExemplo
{
    static void Main(string[] args)
    {

        ArvoreBinaria arvore = new ArvoreBinaria();
        LeitoraDados leitoraDados = new LeitoraDados();

        Console.WriteLine("Exemplo de Árvore Binária Ordenada");

        String opcao = "";

        while (!opcao.Equals("22")) {

            Console.WriteLine("\n");
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Criar raiz");
            Console.WriteLine("2 - INSERT");
            Console.WriteLine("3 - DELETE");
            Console.WriteLine("4 - SEARCH");
            Console.WriteLine("5 - Exibir Pré-ordem");
            Console.WriteLine("6 - Exibir Em-ordem");
            Console.WriteLine("7 - Exibir Pós-ordem");
            Console.WriteLine("8 - Sair");

            opcao = leitoraDados.LerTexto();

            switch (opcao) {
                case "1":

                    Console.WriteLine("Digite o valor(numérico e inteiro) da raiz:");
                    String raiz = leitoraDados.LerTexto();
                    arvore.CriarRaiz(Int32.Parse(raiz));
                    break;
                case "2":
                    Console.WriteLine("Digite o valor(numérico e inteiro) a ser inserido:");
                    String novoValor = leitoraDados.LerTexto();
                    arvore.Adicionar(Int32.Parse(novoValor));
                    break;
                case "3":
                    Console.WriteLine("Digite o valor(numérico e inteiro) a ser excluido:");
                    String valorExcluir = leitoraDados.LerTexto();
                    bool resultadoRemover = arvore.Remover(Int32.Parse(valorExcluir));
                    if (resultadoRemover) {
                        Console.WriteLine("O valor " + valorExcluir + " foi excluido da árvore.");
                    } else
                    {
                        Console.WriteLine("O valor " + valorExcluir + " não foi excluido da árvore, pois não pertence à mesma.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Digite o valor(numérico e inteiro) a ser excluido:");
                    String valorPesquisa = leitoraDados.LerTexto();
                    bool resultadoPesquisa = arvore.Remover(Int32.Parse(valorPesquisa));
                    if (resultadoPesquisa)
                    {
                        Console.WriteLine("O valor " + valorPesquisa + " pertence a árvore.");
                    }
                    else
                    {
                        Console.WriteLine("O valor " + valorPesquisa + " não pertence a árvore.");
                    }

                    break;
                case "5":
                    Console.WriteLine("Exibindo Pré-ordem");
                    arvore.Exibir("Pre");
                    break;
                case "6":
                    Console.WriteLine("Exibindo Em-ordem");
                    arvore.Exibir("Em");
                    break;
                case "7":
                    Console.WriteLine("Exibindo Pós-ordem");
                    arvore.Exibir("Pos");
                    break;
                case "8":
                    Console.WriteLine("Volte sempre e bons estudos!");
                    break;
                default:
                    throw new ArgumentException("Opção desconhecida");
            }

        }
    }
}

