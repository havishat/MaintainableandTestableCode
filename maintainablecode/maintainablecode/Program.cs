using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maintainablecode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        /// <summary>
        /// checking equals program is getting accessed to only object Program and if it is not to Prgrams then it will return false
        /// otherwise it will return Program. 
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>

        public override bool Equals(object o)
        {
            var program = o as Program;
            if (program == null)
                return false;

            return this == program;
        }

    }
}
