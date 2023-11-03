using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling

// Use / create Student class,accept the name from constructor & if name is empty or null then raise an exception ie. NameException with message ‘name is required’

{
    public class Name_Exception : Exception
    {
        public Name_Exception(string error) : base(error)
        {

        }
    }
    public class student
    {
        public student(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Name_Exception("STRING IS FULLY EMPLTY ");
            }
        }
    }
    public class RunNameException
    {
      static void Main(string[]args)
        {
            try
            {
                student s1 = new student(null);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}    
