using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
    internal class HashtableExemplo
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> d = new Dictionary<string, int>();

            d.Add("Brasil", 5);
            d.Add("Alemanha", 4);
            d.Add("Itália", 4);
            d.Add("Argentina", 2);
            d.Add("França", 2);
            d.Add("Uruguai", 2);
            d.Add("Inglaterra", 1);
            d.Add("Espanha", 1);

            Console.WriteLine(d.Count);

            Console.WriteLine(d.ContainsKey("Brasil"));

            Console.WriteLine(d.ContainsValue(10));

            Console.WriteLine(d["Alemanha"]);

            Console.WriteLine(d["Argentina"]);
            d["Argentina"] = 3;
            Console.WriteLine(d["Argentina"]);

            d.Remove("Argentina");

            Console.WriteLine(d.Count);

            //Pelas chaves
            foreach (var valor in d.Keys)
            {
                Console.WriteLine(valor);
            }

            //Pelos valores
            foreach (var valor in d.Values)
            {
                Console.WriteLine(valor);
            }

            Console.ReadKey();

        }
    }
}
