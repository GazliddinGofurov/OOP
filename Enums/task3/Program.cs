using System;
namespace _task3
{
    class Program
    {
        static void Main (string[] args)
        {
           
            //task3 Flags
            
            Permissions permissions = Permissions.Read;
            permissions |= Permissions.Write;

            permissions &= ~Permissions.Read;

            permissions = Permissions.Write | Permissions.Execute;

            Console.WriteLine(permissions);
            Console.WriteLine(permissions.HasFlag(Permissions.Execute));

            permissions &= ~Permissions.Execute;
            Console.WriteLine(permissions);
            Console.WriteLine(permissions.HasFlag(Permissions.Execute));

        
            
        }

       

        [Flags]
        enum Permissions
        {
            None = 0,
            Read = 1,
            Write = 2,
            Execute = 4,
            Delete = 8
        }
    }
}