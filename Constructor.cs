using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading
{
    class Overload
    {
        string name;
        int temp;

        public Overload()  //Default Constructor:
        {
            name = "karnataka";
            temp = 29;
            Console.WriteLine("{0} Yesterday Temperature : {1}°.", name, temp);
        }

        //Parameterized Constructor: Overloading-
        public Overload(string nam, int tem)
        {
            name = nam;
            temp = tem;
            Console.WriteLine("{0} Today Temperature  : {1}°.", name, temp);
        }
    }


    class Program
    {
        static void Main()
        {
            Overload load = new Overload(); //Calling Default constructor:

            //calling Overload Constructor.
            Overload load2 = new Overload("karnataka", 26);

            Console.ReadKey();
        }
    }
}
