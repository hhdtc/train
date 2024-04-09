using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Assignment02
    {
        // Test your Knowledge
        // 1. Use string when we do not need to modify the string. Use stringbuilder when we need to modify the string.
        // 2.System.Array
        // 3.Array.Sort(list); Array.Sort(list,ComparingFunction);
        // 4 list.Length
        // 5. by default no. But if you declare Object[], which is not recommanded, you could store multiple types.
        // 6. CopyTo() need to take an array and a start index as arguments. It will copy the element to an existing array.
        //   Clone() return an new array.
        //   Both perform shallow copy, which only copy refernce other than creating new object.

        public static void PerformCopy()
        {
            int[] array1 = { 1, 2, 7, 5, 4, 3, 5, 6, 7, 7 };
            int[] array2 = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++) { 
                array2[i] = array1[i];
            }

            Console.WriteLine("Array 1:");
            foreach (int i in array1) {
                Console.Write($"{i} ");
            }
            Console.WriteLine("");

            Console.WriteLine("Array 2:");
            foreach (int i in array2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("");
        }

        public static void ManageList()
        {
            List<String> grocery= new List<String>();
            while (true) {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                String command = Console.ReadLine();
                if (command != null)
                {
                    if (command.Equals("--")) {
                        grocery.Clear();
                    }
                    if (command.StartsWith("+"))
                    {
                        grocery.Add(command.Substring(1));
                    }
                    else if (command.StartsWith("-"))
                    {
                        if (grocery.Contains(command.Substring(1)))
                        {
                            grocery.Remove(command.Substring(1));
                        }
                        else {
                            Console.WriteLine("No such element");
                        }
                    }
                }
            }        
        }

        public static int[] FindPrimesInRange(int startNum, int endNum) {
            List<int> r = new List<int>();
            for (int i = startNum; i <= endNum; i++) {
                if (IsPrime(i)) {
                    r.Add(i);
                }
            }
            //Console.WriteLine(r.Count);
            return r.ToArray();
        }

        static bool IsPrime(int i) {
            if (i <= 1)
            {
                return false;
            }

            for (int d = 2; d < Math.Sqrt(i); d++) {
                if (i % d == 0) {
                    return false;
                }
            }
            return true;
        }


        public static int[] ArrayRotation(int[] arr, int k) {

            int[] res = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++) {
                res[i] = 0;
                for (int j = 0; j < k; j++) {
                    int offset = (k*arr.Length-j+i-1) % arr.Length;
                    res[i] += arr[offset];
                }
            }

            return res;
        }

        public static int[] FindLongestSeq(int[] arr) {

            if (arr.Length < 2) {
                return arr;
            }
            int tmpCount = 1;
            int maxCount = 0;
            int? current = arr[0];
            int? last = arr[0];
            int? maxSeqValue = null;
            for (int i = 1;i < arr.Length;i++)
            {
                if (arr[i] == current)
                {
                    tmpCount++;
                    last = current;
                }
                else {
                    if (tmpCount > maxCount) {
                        maxSeqValue = last;
                        maxCount = tmpCount;
                    }
                    current = arr[i];
                    last = arr[i - 1];
                    tmpCount = 1;
                }
            }

            if (tmpCount > maxCount)
            {
                maxSeqValue = last;
                maxCount = tmpCount;
            }

            int[] result = new int[maxCount];
            for (int i=0; i < maxCount; i++)
            {
                result[i] = maxSeqValue.Value;
            }

            return result;
        }

        public static int FindMostFreq(int[] arr) {
           Dictionary<int,int> d = new Dictionary<int, int> ();
            int max = 0;
            foreach (int i in arr) {
                if (d.ContainsKey(i))
                {
                    d[i] =  d[i] + 1;
                }
                else { 
                    d.Add(i, 1);
                }
                if (d[i] > max)
                {
                    max = d[i];
                    }
            }

            foreach (int i in arr)
            {
                if (d[i] == max) {
                    return i;
                }
            }

            return -1;

            
        }

        public static String ReverseString(String str) {
            char[] chars = str.ToCharArray();
            char[] res = new char[chars.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                res[i] = chars[chars.Length - 1 - i];
            }
            //foreach (char r in res) { 
            //    Console.Write(r);
            //}
            //res[res.Length - 1] = '\0';
            return new string(res);
        }

        public static string ReverseStringInWords(string str)
        {
            char[] chars = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            List<string> symbols = new List<string> ();
            int i = 0;
            while (i<str.Length) {
                if (chars.Contains(str[i]))
                {
                    string tmp = str[i].ToString();
                    i++;
                    while (i < str.Length && chars.Contains(str[i]) ) {
                        tmp += str[i];
                        i++;
                    }
                    symbols.Add(tmp);
                }
                else {
                    i++;
                }

                
            }
            foreach (char r in chars)
            {
                str = str.Replace(r, ' ');
            }

            String[] strList = str.Split(' ');
            strList = strList.Reverse().ToArray();
            List<String> strL = strList.ToList();
            strL.RemoveAll(word => word == " " || word.Length == 0);
            String res = "";
            for (i = 0;i < strL.Count;i++)
            {

                res += strL[i];
                if (i < symbols.Count)
                {
                    res += symbols[i];
                }

            }
            return res;
        }

        public static void FindPalindromes(String str) {
            char[] chars = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            List<String> symbols = new List<String>();
            int i = 0;
            while (i < str.Length)
            {
                if (chars.Contains(str[i]))
                {
                    String tmp = str[i].ToString();
                    i++;
                    while (i < str.Length && chars.Contains(str[i]))
                    {
                        tmp += str[i];
                        i++;
                    }
                    symbols.Add(tmp);
                }
                else
                {
                    i++;
                }


            }
            foreach (char r in chars)
            {
                str = str.Replace(r, ' ');
            }

            string[] strList = str.Split(' ');
            List<string> strL = strList.ToList();
            strL.RemoveAll(word => word == " " || word.Length == 0);

            List<string> res = new List<string>();
            foreach (string s in strL) {

                if (s.Equals(ReverseString(s))) {
                    res.Add(s);
                }
                //Console.WriteLine(s);
            }


            Console.WriteLine(string.Join(", ", res));

        }

        public static void ExtractURL(string url) {
            List<string> s = url.Split("://").ToList();
            if (s.Count < 2)
            {
                Console.WriteLine("[protocol] = \"\"");
            }
            else {
                Console.WriteLine($"[protocol] = \"{s[0]}\"");
            }
            string rest;
            if (s.Count < 2) {
                rest = s[0];
            }
            else {
                rest = s[1];
            }
            s = rest.Split("/").ToList();
            if (s.Count < 2)
            {
                Console.WriteLine($"[server] = \"{s[0]}\"");
                Console.WriteLine("[resource] = \"\"");
            }
            else
            {
                
                Console.WriteLine($"[server] = \"{s[0]}\"");
                s.RemoveAt(0);
                Console.WriteLine($"[resource] = \"{string.Join("/", s)}\"");
            }

        }
    }
}
