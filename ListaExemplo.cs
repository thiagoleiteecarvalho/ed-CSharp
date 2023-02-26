using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ListaExemplo
{
    static void Main(string[] args)
    {

        List<string> l = new List<string>();

        l.Add("Fla");
        l.Add("men");
        l.Add("go");

        Console.WriteLine(l[0]);

        l.RemoveAt(1);
        l.RemoveAt(1);

        Console.WriteLine(l.Count);

        Console.ReadKey();
    }
}
