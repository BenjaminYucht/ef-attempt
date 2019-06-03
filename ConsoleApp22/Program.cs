using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ORM ctx=new ORM())
            {
                foreach(var person in ctx.People)
                {
                    Console.WriteLine($"Person ID={person.PersonID}: First Name={person.FirstName}: Last Name={person.LastName}:");
                }
                

            }
            Console.ReadLine();
        }
    }
}
