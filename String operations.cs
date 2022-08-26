using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_string_operations_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            str = "I am Amit Kumar Dubey a student of Dotnet class";

            Console.WriteLine(left(str,14));
            Console.WriteLine(right(str,12));

            Program obj = new Program();

            obj.replace();

            obj.insert();

            

            obj.substr();

            obj.arry();

            obj.trimcmd();

            obj.splitcmd();

            obj.RemoveStr(str);

            obj.searchStr(str);

            obj.Bytestream();
            obj.splitjoin();

            Console.Read();
        }

        public void replace()
        {
            string stri = "This is sample";
            Console.WriteLine("Original String:Replaced Example"+stri);

            stri = stri.Replace("is","was");
            Console.WriteLine(stri);
        }

        public void insert()
        {
            string stri = "This sample";
            Console.WriteLine("Original String:" + stri);

            stri = stri.Insert(5,"is a");
            Console.WriteLine(stri);
        }

        public void splitjoin()
        {
            string str4 = "one if by land, two if by sea";
            char[] seps = {' ','.'};
            string[] parts = str4.Split(seps);
            Console.WriteLine("Pices from split:");

            for (int i = 0; i < parts.Length; i++)
                Console.WriteLine(parts[i]);

            string whole = string.Join("|", parts);
            Console.WriteLine("Result of join:");
            Console.WriteLine(whole);
        }

        public void substr()
        {
            string orgstr = "C# makes strings easy.";
            string substr = orgstr.Substring(5,12);
            Console.WriteLine("\n");
            Console.WriteLine("orgstr:"+orgstr);
            Console.WriteLine("substr:"+substr);
        }

        public void arry()
        {
            string[] str2 = {"This", "is", "a", "test."};
            Console.WriteLine("Original array:");

            for (int i = 0; i < str2.Length; i++)
                Console.WriteLine(str2[i]+"");
     
            Console.WriteLine("\n");
        }

        public void Bytestream()
        {
            string strOriginal;
            strOriginal = "I am Amit Kumar Dubey ans a student of dotnet class";
            byte[] byt = System.Text.Encoding.Unicode.GetBytes(strOriginal);

            foreach(byte brr in byt)
            {
                Console.Write(brr);
            }
            string strModified = Convert.ToBase64String(byt);
            Console.WriteLine(strModified);

            byte[] b = Convert.FromBase64String(strModified);
            strOriginal = System.Text.Encoding.UTF8.GetString(b);
            Console.WriteLine(strOriginal);
        }

        public void trimcmd()
        {
            string MyString1 = "  Hello, world!  ";
            string trim1 = MyString1.TrimStart();
            Console.WriteLine(trim1);
            string trim = MyString1.TrimEnd();
            Console.WriteLine(trim);

            string trim11 = MyString1.Trim().Trim(char.Parse("!"));
            Console.WriteLine(trim11);
        }

        public void splitcmd()
        {
            string MString = "The quick brown / for ran around";
            string[] MyStringSplit = new string[6];

            MyStringSplit = MString.Split(new char[] {'/'},2);
            Console.WriteLine(MyStringSplit[1]+MyStringSplit[0]);
        }

        public void RemoveStr(string searchin)
        {
            string str = searchin.Remove(6);
            Console.WriteLine(searchin.Remove(5,8));
            Console.Write(str);
        }

        public void searchStr(string searchin)
        {
            string searchFor = "dotnet";
            int firstCharacter = searchin.IndexOf(searchFor);

            Console.WriteLine("First occurance: {0}", firstCharacter);
            if (firstCharacter == -1)
            {
                Console.WriteLine("dotnet string doesnot exits in the main string");
            }

            if (firstCharacter >= 0)
            {
                Console.WriteLine("dotnet string exsits in the main string");
            }
        }

        public static string left(string s, int len)
        {
            return s.Substring(0, Math.Min(len, s.Length));
        }

        public static string right(string s, int count)
        {
            string newString = string.Empty;
            if(s != null && count > 0)
            {
                int startIndex = s.Length - count;

                if(startIndex > 0)
                    newString = s.Substring(startIndex, count);
                else
                    newString = s;
            }

            return newString;
        }
    }
}
