using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DogExceptionsAssignment
{
    public class Dog
    {

        private string name; //throw ApplicationException for name length lower than 2
        private int age; //throw ArgumentException for negative age 
                         //throw ApplicationException for age greater than 100
        

        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 2)
                {
                    this.name = value;
                }
                else //name length lower than 2
                {
                    throw new ApplicationException("The NAME should have at least 2 characters");
                }
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {

                if (value >= 0 && value <= 100)
                {
                    this.age = value;
                }
                else if (value < 0)
                {
                    throw new ArgumentException("The AGE should not be less then 0");
                }
                else // age greater than 100
                {
                    throw new ApplicationException("The AGE should not be greater then 100");
                }

            }
        }

        
    }
}
