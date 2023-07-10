namespace BMISummer2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight in pounds: ");
            if (Int32.TryParse(Console.ReadLine(), out int _weight)) {
                Console.Write("Enter your height in inches: ");
                if (Int32.TryParse(Console.ReadLine(), out int _height)) {
                    double bmi = (_weight * 703D) / (_height * _height);
                    //double bmi = (_weight * 703D) / Math.Pow(_height, 2);
                    Console.WriteLine($"Your BMI is {bmi:N2}");
                    if (bmi < 18.5D)
                    {
                        Console.WriteLine("BMI < 18.5 - Underweight");
                    } else if (bmi < 24.9D)
                    {
                        Console.WriteLine("BMI between 18.5 and 24.9 - Normal");
                    }
                    else if(bmi < 29.9D)
                    {
                        Console.WriteLine("BMI between 25 and 29.9 - Overweight");
                    } else
                    {
                        Console.WriteLine("BMI >= 30 - Obese");
                    }
                }
            }
        }
    }
}