using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PilhaExemplo
{
    static void Main(string[] args)
    {

        Stack<string> p = new Stack<string>();

        p.Push("F");
        p.Push("L");
        p.Push("A");

        Console.WriteLine(p.Peek());

        Console.WriteLine(p.Pop());

        Console.WriteLine(p.Count);

        Console.WriteLine(p.Contains("F"));

        Console.ReadKey();
    }
}

