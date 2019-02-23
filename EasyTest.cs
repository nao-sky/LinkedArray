using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace LinkedArray
{
    public class EasyTest
    {
        IList<decimal> list1, list2;
        DateTime prevTime;
        int testLength = 1000000;
        public TimeSpan[] total = new TimeSpan[2];

        public EasyTest(IList<decimal> list1, IList<decimal> list2)
        {
            this.list1 = list1;
            this.list2 = list2;

            
        }

        TimeSpan ComputeTimeSpan()
        {
            DateTime now = DateTime.Now;
            TimeSpan timeSpan = now - prevTime;
            prevTime = now;
            return timeSpan;
        }
        
        void TimeMark(int index)
        {
            TimeSpan span = ComputeTimeSpan();
            WriteLine(span);
            total[index] += span;
        }

        void DisplayTypeName(IList<decimal> list)
        {
            string s = list.GetType().Name;
            WriteLine("typename= " + s.Remove(s.LastIndexOf('`')) + "<decimal>");
        }

        public void IListMatching()
        {
            if(list1.Count != list2.Count)
                WriteLine($"not mached. count left={list1.Count}, right={list2.Count}");

            for (int i = 0; list1.Count > i; i++)
            {
                decimal leftV = list1[i];
                decimal rightV = list2[i];

                if (leftV.Equals(rightV))
                    ;// Console.WriteLine($"matche: index={i} left={leftV} right={rightV}");
                else
                {
                    Console.WriteLine($"not mached. index={i}  left={leftV}, right={rightV}");
                    return;
                }
            }
            WriteLine("matched.");
        }

        public void InitializeTime()
        {
            prevTime = DateTime.Now;
        }

        public void AddTest()
        {
            WriteLine($"add method * {this.testLength}");

            DisplayTypeName(list1);

            InitializeTime();

            for (int i = 0; testLength > i; i++)
            {
                list1.Add(i);
            }
            TimeMark(0);


            DisplayTypeName(list2);

            InitializeTime();

            for (int i = 0; testLength > i; i++)
            {
                list2.Add(i);
            }
            TimeMark(1);

            WriteLine();
        }

        public void ClearTest()
        {
            WriteLine($"clear method * {list2.Count}");

            DisplayTypeName(list1);

            InitializeTime();

            list1.Clear();

            TimeMark(0);


            DisplayTypeName(list2);

            InitializeTime();

            list2.Clear();

            TimeMark(1);

            WriteLine();
        }

        public void IncrimentTest()
        {
            int length = this.testLength / 10;

            WriteLine($"incriment [index: 0-] * {length}");

            DisplayTypeName(list1);

            InitializeTime();

            for (int i = 0; length > i; i++)
            {
                list1[i]++;
            }
            TimeMark(0);

            DisplayTypeName(list2);

            InitializeTime();

            for (int i = 0; length > i; i++)
            {
                list2[i]++;
            }
            TimeMark(1);

            WriteLine();
        }

        public void InsertTest1()
        {
            int length = this.testLength / 10000;

            WriteLine($"insert1 [index: 0] * {length}");

            DisplayTypeName(list1);

            InitializeTime();

            for (int i = 0; length > i; i++)
            {
                list1.Insert(0, i);
            }
            TimeMark(0);

            DisplayTypeName(list2);

            InitializeTime();

            for (int i = 0; length > i; i++)
            {
                list2.Insert(0, i);
            }
            TimeMark(1);

            WriteLine();
        }

        public void RemoveTest()
        {
            int length = this.testLength / 10000;

            WriteLine($"remove [index: -] * {length}");

            DisplayTypeName(list1);

            InitializeTime();

            for (int i = 0; length > i; i++)
            {
                list1.Remove(i);
            }
            TimeMark(0);

            DisplayTypeName(list2);

            InitializeTime();

            for (int i = 0; length > i; i++)
            {
                list2.Remove(i);
            }
            TimeMark(1);

            WriteLine();
        }

        public void RemoveAtTest()
        {
            int length = 50;

            WriteLine($"removeat [index: 0] * {length}");

            DisplayTypeName(list1);

            InitializeTime();

            for (int i = 0; length > i; i++)
            {
                list1.RemoveAt(0);
            }
            TimeMark(0);

            DisplayTypeName(list2);

            InitializeTime();

            for (int i = 0; length > i; i++)
            {
                list2.RemoveAt(0);
            }
            TimeMark(1);

            WriteLine();
        }

        public void InsertTest2()
        {
            int length = 50;
            int mul = 9999;

            WriteLine($"insert2 [index: * {mul}] * {length}");

            DisplayTypeName(list1);

            InitializeTime();

            for (int i = 0; length > i; i++)
            {
                list1.Insert(i * mul, i);
            }
            TimeMark(0);

            DisplayTypeName(list2);

            InitializeTime();

            for (int i = 0; length > i; i++)
            {
                list2.Insert(i * mul, i);
            }
            TimeMark(1);

            WriteLine();
        }

        public void AddRangeTest()
        {
            int length = this.testLength / 100;

            WriteLine($"addrange [index: -] * {length}");

            decimal[] buf = new decimal[length];
            for (int i = 0; buf.Length > i; i++)
                buf[i] = i;

            DisplayTypeName(list1);

            InitializeTime();

            List<decimal> vs1 = this.list1 as List<decimal>;

            for (int i = 0; length > i; i++)
            {
                vs1.AddRange(buf);
            }
            TimeMark(0);

            DisplayTypeName(list2);

            InitializeTime();

            LinkedArray<decimal> vs2 = this.list2 as LinkedArray<decimal>;

            for (int i = 0; length > i; i++)
            {
                vs2.AddRange(buf);
            }
            TimeMark(1);

            WriteLine();
        }

        public void InsertRangeTest()
        {
            int length = 10;
            int index = 20000;

            WriteLine($"insert range [index: +={index}] * {length}");

            decimal[] buf = new decimal[length];
            for (int i = 0; buf.Length > i; i++)
                buf[i] = i;

            DisplayTypeName(list1);

            InitializeTime();

            List<decimal> vs1 = this.list1 as List<decimal>;

            for (int i = 0; length > i; i++)
            {
                vs1.InsertRange(index* i, buf);
            }
            TimeMark(0);

            DisplayTypeName(list2);

            InitializeTime();

            LinkedArray<decimal> vs2 = this.list2 as LinkedArray<decimal>;

            for (int i = 0; length > i; i++)
            {
                vs2.InsertRange(index * i, buf);
            }
            TimeMark(1);

            WriteLine();
        }
    }
}
