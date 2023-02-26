using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set
{
    internal class SetExemplo
    {
        static void Main(string[] args)
        {
            HashSet<string> s = new HashSet<string>();

            s.Add("1980");
            s.Add("1981");
            s.Add("1982");
            s.Add("1983");
            s.Add("1981");
            s.Add("2009");

            Console.WriteLine(s.Count);

            Console.WriteLine(s.Contains("1992"));

            s.Remove("2009");

            Console.WriteLine(s.Count);

            foreach (var valor in s)
            {
                Console.WriteLine(valor);
            }

            Console.ReadKey();
        }
    }
}
