using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace LinkedArray
{
    public class EasyTest
    {
        IList<long> list1, list2;
        DateTime prevTime;
        int testLength = 6000000;
        public TimeSpan[] total = new TimeSpan[2];

        public EasyTest(IList<long> list1, IList<long> list2)
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

        void DisplayTypeName(IList<long> list)
        {
            string s = list.GetType().Name;
            WriteLine("typename= " + s.Remove(s.LastIndexOf('`')) + "<long>");
        }

        public void IListMatching()
        {
            if(list1.Count != list2.Count)
                WriteLine($"not mached. count left={list1.Count}, right={list2.Count}");

            for (int i = 0; list1.Count > i; i++)
            {
                long leftV = list1[i];
                long rightV = list2[i];

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

        public void SetAllTest()
        {
            int length = list1.Count;

            WriteLine($"Set all method * {length}");

            DisplayTypeName(list1);

            InitializeTime();

            for (int i = length - 1; 0 < i; i--)
            {
                list1[i]=i;
            }
            TimeMark(0);


            DisplayTypeName(list2);

            InitializeTime();

            for (int i = length - 1; 0 < i; i--)
            {
                list2[i]=i;
            }
            TimeMark(1);

            WriteLine();
        }

        public void Remove2Test()
        {
            int length = 100;

            WriteLine($"remove item method * {length}");

            DisplayTypeName(list1);

            InitializeTime();

            for (int i = 0; length > i; i++)
            {
                long d = list1[0];

                list1.Remove(d);
            }
            TimeMark(0);


            DisplayTypeName(list2);

            InitializeTime();

            for (int i = 0; length > i; i++)
            {
                long d = list2[0];

                list2.Remove(d);
            }
            TimeMark(1);

            WriteLine();
        }
        public void RemoveAtLastTest()
        {
            int length = list1.Count/2;

            WriteLine($"remove at last method * {length}");

            DisplayTypeName(list1);

            InitializeTime();

            for (int i = length - 1; 0 < i; i--)
            {
                list1.RemoveAt(list1.Count-1);
            }
            TimeMark(0);


            DisplayTypeName(list2);

            InitializeTime();
            LinkedArray<long> vs = list2 as LinkedArray<long>;

            for (int i = length - 1; 0 < i; i--)
            {
                vs.RemoveLast(out long dummy);
                //list2.RemoveAt(list2.Count - 1);
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

        public void ComputeAddAllTest()
        {
            int length = list1.Count;

            WriteLine($"ComputeAddAll * {length}");

            DisplayTypeName(list1);

            InitializeTime();

            double d1 = 0;

            foreach (long l in list1)
                d1 += l;

            TimeMark(0);

            DisplayTypeName(list2);

            InitializeTime();

            double d2 = 0;

            

            foreach (long l in list2)
                d2 += l;

            TimeMark(1);
            if (d1 != d2)
                throw new Exception();

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
            int length = 100;

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
            int length = this.testLength / 2000;

            WriteLine($"addrange [index: -] * {length}");

            long[] buf = new long[length];
            for (int i = 0; buf.Length > i; i++)
                buf[i] = i;

            DisplayTypeName(list1);

            InitializeTime();

            List<long> vs1 = this.list1 as List<long>;

            for (int i = 0; length > i; i++)
            {
                vs1.AddRange(buf);
            }
            TimeMark(0);

            DisplayTypeName(list2);

            InitializeTime();

            LinkedArray<long> vs2 = this.list2 as LinkedArray<long>;

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

            long[] buf = new long[length];
            for (int i = 0; buf.Length > i; i++)
                buf[i] = i;

            DisplayTypeName(list1);

            InitializeTime();

            List<long> vs1 = this.list1 as List<long>;

            for (int i = 0; length > i; i++)
            {
                vs1.InsertRange(index* i, buf);
            }
            TimeMark(0);

            DisplayTypeName(list2);

            InitializeTime();

            LinkedArray<long> vs2 = this.list2 as LinkedArray<long>;

            for (int i = 0; length > i; i++)
            {
                vs2.InsertRange(index * i, buf);
            }
            TimeMark(1);

            WriteLine();
        }
        public void ExtForEachTest()
        {
            int length = list1.Count;

            WriteLine($"ExtForEachTest  * {length}");

            DisplayTypeName(list1);

            InitializeTime();

            List<long> vs1 = this.list1 as List<long>;

            double d1 = 0;

            vs1.ForEach(x =>
            {
                d1 += x;
            });

            TimeMark(0);

            DisplayTypeName(list2);

            InitializeTime();

            LinkedArray<long> vs2 = this.list2 as LinkedArray<long>;

            double d2 = 0;

            vs2.ForEach(x =>
            {
                d2 += x;
            });
            TimeMark(1);

            if (d1 != d2)
                ;

            WriteLine();
        }
        public void FindAllTest()
        {
            int length = list1.Count;

            WriteLine($"FindAll  * {length}");

            DisplayTypeName(list1);

            InitializeTime();

            List<long> vs1 = this.list1 as List<long>;

            List<long> ret1 = vs1.FindAll( x =>
            {
                String s = x.ToString();

                return s.IndexOf('1') >= 0;
            });

            TimeMark(0);

            DisplayTypeName(list2);

            InitializeTime();

            LinkedArray<long> vs2 = this.list2 as LinkedArray<long>;

            List<long> ret2 = vs2.FindAll(x =>
            {
                String s = x.ToString();

                return s.IndexOf('1') >= 0;
            });
            TimeMark(1);

            long f1 = 0;
            ret1.ForEach(x =>
            {
                f1 += x;
            });

            long f2 = 0;
            ret2.ForEach(x =>
            {
                f2 += x;
            });

            if (f1 != f2)
                throw new Exception();

            WriteLine();
        }
    }
}
