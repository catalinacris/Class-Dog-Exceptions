using System;

namespace DogExceptionsAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {

            try
            {
                Dog dog = new Dog("Lola", 5);
                dog.Name = "a";
                Console.WriteLine(dog.Name);

            }
            catch (ApplicationException ae)
            {
                Console.WriteLine(ae.Message);
            }

            try
            {
                Dog dog = new Dog("Lola", 5);
                dog.Age = -3;
                Console.WriteLine(dog.Age);

            }
            catch (ArgumentException aen)
            {
                Console.WriteLine(aen.Message);
            }

            try
            {
                Dog dog = new Dog("Lola", 5);
                dog.Age = 111;
                Console.WriteLine(dog.Age);
            }
            catch (ApplicationException fe)
            {
                Console.WriteLine(fe.Message);
            }

            finally
            {
                Console.WriteLine("Thank you!");
            }

            






        }
    }
}
