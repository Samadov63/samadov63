using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rabota_3
{
    class Class4
    {
        class TryFinallyTest
        {
            static void ProcessString(string s)
            {
                if (s == null)
                {
                    throw new ArgumentNullException(paramName: nameof(s), message: "parameter can't be null.");
                }
            }

            public static void Main()
            {
                string s = null; // For demonstration purposes.

                try
                {
                    ProcessString(s);
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} Exception caught.", e);
                }
            }
        }
    }
}
