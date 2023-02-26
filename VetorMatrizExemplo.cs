using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class VetorMatrizExemplo
{
    static void Main(string[] args)
    {
        int[] v = new int[5];
        int[,] m = new int[5, 5];

        int[] v1 = { 10, 25 };
        int[] v2 = new int[] { 1, 2, 3 };
        int[,] m1 = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        int[,] m2 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        int[,,] m3 = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };
        int[,,] m4 = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };
        int[,] m5 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

        v[0] = 70;
        v[3] = 45;
        m[0, 0] = 65;
        m[3, 2] = 17;

        int iV = v[0];
        int iM = m[0, 0];
        Console.WriteLine(iV);
        Console.WriteLine(iM);

        Console.WriteLine(v.Length);
        Console.WriteLine(m.Length);

        Console.ReadKey();
    }
}
