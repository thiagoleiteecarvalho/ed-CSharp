using System;

public class No
{

    int dado;
    No filhoEsquerdo;
    No filhoDireito;

    public No(int valor)
    {
        dado = valor;
        filhoEsquerdo = null;
        filhoDireito = null;
    }

    public int Dado
    {
        get { return dado; }
        set { dado = value; }
    }

    public No FilhoEsquerdo
    {
        get { return filhoEsquerdo; }
        set { filhoEsquerdo = value; }
    }

    public No FilhoDireito
    {
        get { return filhoDireito; }
        set { filhoDireito = value; }
    }

    public bool Insert(int valor)
    {
        if (valor == dado)
        {
            return false;
        }
        else if (valor < dado)
        {
            if (filhoEsquerdo == null)
            {
                filhoEsquerdo = new No(valor);
                return true;
            }
            else
            {
                return filhoEsquerdo.Insert(valor);
            }
        }
        else if (valor > dado)
        {
            if (filhoDireito == null)
            {
                filhoDireito = new No(valor);
                return true;
            }
            else
            {
                return filhoDireito.Insert(valor);
            }
        }
        return false;
    }

    public No Delete(int valor, No pai)
    {
        if (valor == dado)
        {
            if (filhoEsquerdo == null && filhoDireito == null)
            {
                if (this == pai.filhoEsquerdo)
                {
                    pai.filhoEsquerdo = null;
                }
                else
                {
                    pai.filhoDireito = null;
                    return this;
                }
            }
            else if (filhoEsquerdo != null && filhoDireito == null)
            {
                if (this == pai.filhoEsquerdo)
                {
                    pai.filhoEsquerdo = filhoEsquerdo;
                }
                else
                {
                    pai.filhoDireito = filhoEsquerdo;
                    return this;
                }
            }
            else if (filhoEsquerdo == null && filhoDireito != null)
            {
                if (this == pai.filhoEsquerdo)
                {
                    pai.filhoEsquerdo = filhoDireito;
                }
                else
                {
                    pai.filhoDireito = filhoDireito;
                    return this;
                }
            }
            else if (filhoEsquerdo != null && filhoDireito != null)
            {
                dado = filhoDireito.MenorValor();
                return filhoDireito.Delete(dado, this);
            }
        }
        else if (valor < dado)
        {
            if (filhoEsquerdo != null)
            {
                return filhoEsquerdo.Delete(valor, this);
            }
            else
            {
                return null;
            }
        }
        else if (valor > dado)
        {
            if (filhoDireito != null)
            {
                return filhoDireito.Delete(valor, this);
            }
            else
            {
                return null;
            }
        }
        return null;
    }

    public int MenorValor()
    {
        if (filhoEsquerdo == null)
        {
            return dado;
        }
        else
        {
            return filhoEsquerdo.MenorValor();
        }
    }

    public bool Search(int valor)
    {
        if (valor == dado)
        {
            return true;
        }
        else if (valor < dado)
        {
            if (filhoEsquerdo == null)
            {
                return false;
            }
            else
            {
                return filhoEsquerdo.Search(valor);
            }
        }
        else if (valor > dado)
        {
            if (filhoDireito == null)
            {
                return false;
            }
            else
            {
                return filhoDireito.Search(valor);
            }
        }
        return false;
    }

    public void ExibirPreOrdem()
    {

        Console.Write(dado + " ");

        if (filhoEsquerdo != null)
        {
            filhoEsquerdo.ExibirPreOrdem();
        }

        if (filhoDireito != null)
        {
            filhoDireito.ExibirPreOrdem();
        }
    }

    public void ExibirEmOrdem()
    {

        if (filhoEsquerdo != null)
        {
            filhoEsquerdo.ExibirEmOrdem();
        }

        Console.Write(dado + " ");

        if (filhoDireito != null)
        {
            filhoDireito.ExibirEmOrdem();
        }
    }

    public void ExibirPosOrdem()
    {

        if (filhoEsquerdo != null)
        {
            filhoEsquerdo.ExibirPosOrdem();
        }

        if (filhoDireito != null)
        {
            filhoDireito.ExibirPosOrdem();
        }

        Console.Write(dado + " ");
    }

}
