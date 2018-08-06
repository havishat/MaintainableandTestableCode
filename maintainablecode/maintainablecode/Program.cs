using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        /// <summary>
        /// Inverting Conditionals and Early Returns
       // Refactor the code below

        /// </summary>
        /// <param name="nums"></param>
        /// <param name="valueToMatch"></param>
        /// <returns></returns>

        public static int GetFirstMatchingIndex(List<int> nums, int valueToMatch)
        {
            int matchingIndex = -1;

            if(nums == null)
            {
                return matchingIndex;
            }

            if (nums.Count == 0)
            {
                return matchingIndex;
            }

            
            for (var i = 0; i < nums.Count; i++)
            {
                if (nums[i] == valueToMatch)
                {
                    return i;
                }
            }
           

            return matchingIndex;
        }

        /// <summary>
        /// Constants
        //1.	Copy the code below into visual studio: (you will need to add System.Threading to your using statements)

        /// </summary>

        public static void DoStuff()
        {

            const string welcomChort = "hello Cohort";
            const int DurationSleep = 2000;
            Console.WriteLine(welcomChort);
            Thread.Sleep(DurationSleep);
            

            var jobTypes = new string[] { "PM", "Dev", "Other" };
            Console.WriteLine("The job types are:");
            foreach (var type in jobTypes)
                Console.WriteLine(type);

            Console.WriteLine("Goodbye Cohort!");
        }



    }
}
