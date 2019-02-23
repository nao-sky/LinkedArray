using LinkedArray;
using System;
using System.Collections.Generic;

namespace TestCon
{
    class Program
    {
        static void Main(string[] args)
        {
            EasyTest test = new EasyTest(new List<decimal>(), new LinkedArray<decimal>());

            test.AddTest();
            test.IncrimentTest();
            test.InsertTest1();
            test.AddRangeTest();
            test.InsertTest2();
            test.RemoveTest();
            test.RemoveAtTest();
            test.InsertRangeTest();
            test.ClearTest();
            test.AddTest();
            test.RemoveTest();
            test.InsertRangeTest();

            test.IListMatching();

            Console.WriteLine("List time" + test.total[0]);
            Console.WriteLine("LinkedArray time" + test.total[1]);


            //ArrayTest();
            //List<int> list = new List<int>();

            //Console.WriteLine(list[0]);

            Console.ReadLine();

        }
    }
}
