using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;


namespace _task8
{
    class Program
    {

        static string ReplaceKeys(string text, Dictionary<string, string>dict)
        {
            int start  = text.IndexOf("$");

            while (start != -1)
            {
                int end =  text.IndexOf("$", start+1);
                if (end == -1)
                {
                    break;
                }

                string key  = text.Substring(start + 1,end - start -1);

                if (dict.ContainsKey(key))
                {
                   text =  text.Remove(start,end-start+1);
                    text = text.Insert(start,dict[key]);
                }
                else
                {
                    start = text.IndexOf("$",end+1);
                }

                start = text.IndexOf("$", end + 1);

            }

            return text ;
        
        }
        
        static void Main (string[] args)
        {
            string input = "$temp$ here comes the name $name$";

            Dictionary<string,string> diction1 =  new Dictionary<string, string>()
            {
                {"temp","temporary"},
                {"name","John Doe"}
            };

            string res =  ReplaceKeys(input, diction1);
            Console.WriteLine(res);

        }

        


    }
}