using System;
using System.Linq;
using System.Text;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Username daxil edin :");
                string name = Console.ReadLine();
                Console.WriteLine("Passwordu daxil edin :");
                string passw = Console.ReadLine();
                User user = new User(name, passw);
            
               

            } while (true);

        }
    }
}  
    