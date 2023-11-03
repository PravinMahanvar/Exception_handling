using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{

    //If number is negative then throw negative number exception.
    public class Number_ex : Exception
    {
        public Number_ex(string error) : base(error)

        {

        }

    }
    class program2
    {
        static void Main(string[] args)
        {
            try
            {
                int number = -5;
                if (number < 0)
                {
                    throw new Number_ex("negative number is not");
                }
                Console.WriteLine("number is:" + number);
            }
            catch (Number_ex e)
            {
                Console.WriteLine("number is " + e.Message);
            }
        }
    }

}      
