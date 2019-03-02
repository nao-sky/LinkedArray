using LinkedArray;
using System;
using System.Collections.Generic;

namespace TestCon
{
    class Program
    {
        static void Main(string[] args)
        {
            EasyTest test = new EasyTest(new List<long>(), new LinkedArray<long>());

            test.AddTest();
            test.IncrimentTest();
            test.InsertTest1();
            test.AddRangeTest();
            test.InsertTest2();
            test.RemoveTest();
            test.RemoveAtTest();
            test.InsertRangeTest();
            //test.ClearTest();
            test.AddRangeTest();
            test.SetAllTest();
            test.ComputeAddAllTest();
            test.ExtForEachTest();
            test.FindAllTest();

            test.RemoveAtLastTest();
            test.Remove2Test();

            //test.ClearTest();
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
