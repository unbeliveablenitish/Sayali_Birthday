
using System;
namespace csharptraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Iam learning C#");
            Console.WriteLine("Data types");
            DataTypes.displayDataTypes();
        }
    }
    class DataTypes{
        /**
        Display Data Types
        */
        public static void displayDataTypes(){
            string course="C#";
            //int duration=20;
            long mobile=9845547471;
            //float salary=40000.00;
            //char status='A';
            //bool isActive = true;
            Console.WriteLine("String Data Type "+course);
            Console.WriteLine("Long Data Type "+mobile);
        }
    }
}