using System;
using System.Diagnostics;

namespace _delegateTask3
{
    class Program
    {
         
        static void Main(string[] args)
        {
            ProcessTextDelegate toUpper = ToUpperCase;
            ProcessTextDelegate addBracket = AddBracket;
            ProcessTextDelegate replaceSpace = ReplaceSpace;

         

            Console.WriteLine(ProcessText("ali",toUpper));
            Console.WriteLine(ProcessText("ali",addBracket));
            Console.WriteLine(ProcessText("Ali Far Tosh hecj kimsa",replaceSpace));


            
        }

        static string ProcessText(string text, ProcessTextDelegate processDel){
            string res = processDel(text);
            return res;
        }

        static string ToUpperCase(string str)
        {
            return str.ToUpper();
        }

        static string AddBracket(string str)
        {
            return $"[{str}]";
        }

        static string ReplaceSpace(string str)
        {
            return str.Replace(" ","-");
        }
    }

    delegate string ProcessTextDelegate (string str);


}
