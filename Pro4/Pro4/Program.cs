using System;
class AddTwoNumbers
{
    static void Main()
    {
        try
        {
            //declare two variables
            int a = 0;
            int b = 0;

            //input numbers
            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            //calculating sum
            int sum = a + b;

            Console.WriteLine("Addition of " + a + " and " + b + " is = " + sum);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.ToString());
        }
    }
}

