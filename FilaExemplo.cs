using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FilaExemplo
{
    static void Main(string[] args)
    {

        Queue<Int32> f = new Queue<Int32>();

        f.Enqueue(2);
        f.Enqueue(6);
        f.Enqueue(8);

        Console.WriteLine(f.Peek());

        f.Dequeue();

        Console.WriteLine(f.Peek());

        Console.WriteLine(f.Count);

        Console.WriteLine(f.Contains(10));

        Console.ReadKey();
    }
}
