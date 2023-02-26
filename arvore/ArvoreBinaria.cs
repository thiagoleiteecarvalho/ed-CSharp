using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class ArvoreBinaria
{

    private No raiz;

    public ArvoreBinaria()
    {
        raiz = null;
    }

    public No Raiz
    {
        get { return raiz; }
        set { raiz = value; }
    }

    public void CriarRaiz(int valor)
    {

        if (raiz == null)
        {
            raiz = new No(valor);
            Console.WriteLine("Raiz criada com sucesso.");
        }
        else
        {
            Console.WriteLine("Raiz já existente.");
        }
    }

    public bool Adicionar(int valor)
    {

        if (raiz == null)
        {
            raiz = new No(valor);
            return true;
        }
        else
        {
            return raiz.Insert(valor);
        }
    }

    public bool Remover(int valor)
    {

        if (raiz == null)
        {
            return false;
        }
        else
        {

            No removido = raiz;

            if (valor != raiz.Dado)
            {
                removido = raiz.Delete(valor, null);
            }
            else
            {

                if (raiz.FilhoEsquerdo == null && raiz.FilhoDireito == null)
                {
                    raiz = null;
                }
                else if (raiz.FilhoEsquerdo != null && raiz.FilhoDireito == null)
                {
                    raiz = raiz.FilhoEsquerdo;
                }
                else if (raiz.FilhoEsquerdo == null && raiz.FilhoDireito != null)
                {
                    raiz = raiz.FilhoDireito;
                }
                else if (raiz.FilhoEsquerdo != null && raiz.FilhoDireito != null)
                {

                    raiz.Dado = raiz.FilhoDireito.MenorValor();
                    removido = raiz.FilhoDireito.Delete(raiz.Dado, raiz);
                }
            }

            if (removido != null)
            {

                removido.FilhoEsquerdo = null;
                removido.FilhoDireito = null;
                return true;
            }
            else
                return false;
        }
    }

    public bool Pesquisar(int valor)
    {

        if (raiz == null)
        {
            return false;
        }
        else
        {
            return raiz.Search(valor);
        }
    }

    public void Exibir(String opcao)
    {

        switch (opcao.ToLower())
        {
            case "pre":
                raiz.ExibirPreOrdem();
                break;

            case "em":
                raiz.ExibirEmOrdem();
                break;

            case "pos":
                raiz.ExibirPosOrdem();
                break;
            default:
                throw new ArgumentException("Opção de navegação desconhecida");
        }
    }
}
