using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRepo1;

namespace TestRepo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Repo 2 Works !!!");
            TestClass tc1 = new TestClass();
            tc1.DoSomethingGreat();
        }

        private void HellowWorld()
        {
            Console.WriteLine("hop hop");
        }
    }
}