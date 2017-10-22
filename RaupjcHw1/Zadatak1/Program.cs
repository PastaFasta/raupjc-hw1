using System;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerList integerList = new IntegerList(2);
            integerList.Add(5);
            integerList.Add(6);
            integerList.Add(7);

            Console.WriteLine(integerList.GetElement(2));
            Console.ReadLine();
        }
    }
}
