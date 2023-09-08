using System;
namespace AdamAndEve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Create();
        }

        public static Human[] Create()
        {
            Human[] people = new Human[2];
            Man adam = new Man();
            Woman eve = new Woman();
            people[0] = adam;
            people[1] = eve;
            return people;
        }

    }//class

    public class Human
    {
    }
    public class Man : Human
    {
    }
    public class Woman : Human
    {
    }


}//namespace