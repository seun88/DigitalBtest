using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBtest
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add("z");
            arr.Add("b");
            arr.Add("g");
            arr.Add("a");
            arr.Add("x");
            arr.Add("v");
            arr.Add("s");
            arr.Add("c");
            arr.Add("t");
            arr.Add("w");
            arr.Add("f");
            arr.Add("k");
            arr.Add("j");
            arr.Add("r");
            arr.Add("l");


            Console.Write("ArrayList elements: ");
        foreach (var i in arr)
        {
           Console.Write(i + " ");
        }
        arr.Sort();
        Console.WriteLine();
        Console.Write("Sorted ArrayList elements: ");
        foreach (var i in arr)
        {
           Console.Write(i + " ");
        }
            Console.WriteLine("\n\nCount = " + arr.Count);
            Console.ReadLine();
        }
    }
}
