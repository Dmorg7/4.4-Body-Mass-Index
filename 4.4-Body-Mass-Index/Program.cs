using System;

namespace _4._4_Body_Mass_Index
{
    // author: Benjamin Daniel Morgan
    // date: 26/01/18

    class BMI
    {
        string input;
        double bmi;
        double weight, height;

        public static void Main(string[] args)
        {
            BMI myBMI = new BMI();                                              //create a new BMI object
            myBMI.getDetails(ref myBMI.weight, ref myBMI.height);
            myBMI.calcBMI();
            myBMI.display();
        }
        public void getDetails(ref double weight, ref double height)
        {
            Console.WriteLine("Please enter your Weight");

            input = Console.ReadLine();
            weight = Convert.ToInt32(input);

            Console.WriteLine("Please enter your Height");

            input = Console.ReadLine();
            height = Convert.ToInt32(input);

        }
        public void calcBMI()
        {
            bmi = weight / Math.Pow(height, 2);
        }
        public void display()
        {
            Console.WriteLine("Your BMI is " + bmi.ToString("0.00"));

            if(bmi < 18.5)
            {
                Console.WriteLine("You are Underweight");
            }

            if(bmi > 18.8 && bmi < 25)
            {
                Console.WriteLine("You are at a desirable Weight");
            }

            if(bmi > 25 && bmi < 30)
            {
                Console.WriteLine("You are Overweight");
            }

            if(bmi > 30 && bmi < 40)
            {
                Console.WriteLine("You are Obese");
            }

            if(bmi > 40)
            {
                Console.WriteLine("You are Severly Obese");
            }
        }
    } // end of BMI class
}
