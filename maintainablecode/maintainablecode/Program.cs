using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;


namespace maintainablecode

{

    enum jobTypes {
        PM,
        DEV,
        Others
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            object ConfigurationManager = null;
            
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
            

           // var jobTypes = new string[] { "PM", "Dev", "Other" };
            const string JobType = "The job types are:";

            Console.WriteLine(JobType);
            foreach (var type in Enum.GetNames(typeof(jobTypes)){
                Console.WriteLine(type);
            }
               

            Console.WriteLine("Goodbye Cohort!");
        }


        /// <summary>
        /// Testable code
        /// </summary>
        public class C1
        {
            public void DoStuff() { }
        }
        public class C2
        {
            public void DoStuff() { }
        }
        public class C3
        {
            public void DoStuff() { }
        }

        public class C4
        {
            private C1 c1;
            private C2 c2;
            private C3 c3;

            //constructor injection
            public C4(C1 c1, C2 c2, C3 c3)
            {
                this.c1 = c1;
                this.c2 = c2;
                this.c3 = c3;
            }

            // Method injection
            public void DoStuff(C1 c1, C2 c2, C3 c3)
            {
               
                c1.DoStuff();
                c2.DoStuff();
                c3.DoStuff();
            }
        }





    }
}
