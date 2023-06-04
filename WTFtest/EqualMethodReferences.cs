using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTFtest
{
    //Compare the method .Equal vs others ("==", .ReferenceEqual, .SequenceEqual,...)
    internal class EqualMethodReferences
    {
        public static void EqualVs()
        {
            string first = new string(new[] { 'x', 'y', 'z' });
            int i1 = 123;
            string s1 = "test";
            string s2 = "test";
            string s3 = "test1".Substring(0, 4);
            object s4 = s3;

            //Console.WriteLine(ReferenceEquals(i1, i1));
            //Console.WriteLine($"{ReferenceEquals(s1, s2)} {s1 == s2} {s1.Equals(s2)}");
            //Console.WriteLine($"{ReferenceEquals(s1, s3)} {s1 == s3} {s1.Equals(s3)}");
            //Console.WriteLine($"{ReferenceEquals(s1, s4)} {s1 == s4} {s1.Equals(s4)}");

            //string[] strings0 = null;
            string[] strings1 = { "abc", "bcd" };
            string[] strings1_1 = new[] {first, s1, s3};
            string[] strings1_2 = new[] { s1, first, s3 };
            List<string> strings2 = new List<string> { "abc", "bcd" };
            List<string> strings2_1 = new List<string> { "abc", "bcd" };
            List<string> strings2_2 = strings2;
            List<string> strings2_3 = new List<string> { first, "test", s3 };

            //Console.WriteLine($"{strings0.Equals(strings2)}");
            Console.WriteLine($"{strings1.Equals(strings2)} {strings2.Equals(strings2_1)} {strings2.Equals(strings2_2)}");
            Console.WriteLine($"{strings1.SequenceEqual(strings2_1)} {strings1_1.SequenceEqual(strings2_3)} {strings1_1.SequenceEqual(strings1_2)}");
        }
    }
}
