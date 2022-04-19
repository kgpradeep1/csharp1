using System; //Basic Namespace-Datatypes,Arrays,Strings,I/O etc
//COMMENT-CTRL+K+C
//UNCOMMENT-CTRL+K+U

//create a namespace
//Collection of classes

namespace trainee
{
    //Summary   
    /// <summary>
    /// Introduction to C# Datatypes
    /// </summary>

    public class trainee_details
    {
        //Functions->Methods

        /// <summary>
        /// Main Method
        /// </summary>
        public static void Main()
        {
            
            //Accept Trainee Details
            int TID;
            string TName;
            string TDes;
            Console.WriteLine("Enter the Trainee ID");//100
            //Accept Input- Console.ReadLine()
            TID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Trainee Name and Designation");
            TName = Console.ReadLine();
            TDes = Console.ReadLine();
            //\n - newline
            Console.WriteLine($"The Trainee ID is {TID}.\nTrainee Name is {TName}.\nTrainee Designation is {TDes}");

        }
    }


}
