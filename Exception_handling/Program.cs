using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = null;
                if (string.IsNullOrEmpty(str))
                {
                    throw new Exception("name is required");
                }
                Console.WriteLine(str);
            }
             catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("inside the finally block");
            }
           
            
            
        }
    }
}
