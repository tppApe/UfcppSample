﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTuples
{
    class Program
    {
        static void Main()
        {
            Write(ValueTuple.Create(1, 2, 3, "abc", "def"));
            Console.WriteLine();

            Write(new Point(10, 20));
            Console.WriteLine();

            Write(new Person(123, "abc def", "東京都千代田区千代田1-1"));
            Console.WriteLine();

            var x = (ITuple)new Student(999, "あｗせｄｒｆｔｇｙ ふじこ", "千葉県浦安市舞浜1-1", 5, 2).Value;

            Write(x);
            Console.WriteLine();

            x[0] = 1;
            x[1] = "a";
            x[2] = "b";
            x[3] = 2;
            x[4] = 3;
            Write(x);
            Console.WriteLine();

            var line = new Line(new Point(1, 2), new Point(3, 4));
            var lineClone = line.DeepClone();

            line.A.X = 10;
            line.A.Y = 20;
            line.B.X = 30;
            line.B.Y = 40;

            Write(line);
            Write(lineClone);
        }

        private static void Write(IRecord record) => Write(record.Value);

        private static void Write(ITuple tuple)
        {
            foreach (var item in tuple.Values)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < tuple.Count; i++)
            {
                Console.WriteLine(tuple[i]);
            }
        }
    }
}
