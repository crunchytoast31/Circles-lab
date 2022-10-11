namespace Circle_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                i++;

                Console.WriteLine("Enter Radius:");
                double radius = 0;
                try
                {
                    radius = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("The value you entered is not a number try again!");
                    i--;
                }

                Circles c = new Circles(radius);
                c.CalculateCircumference(radius);

                Console.WriteLine($"Circumfrence: {c.CalculateCircumference(radius)}");

                Console.WriteLine($"Area: {c.CalculateArea(radius)}");




                if (GoOn() == false)
                {
                    Console.WriteLine("Number of circles :" + i);
                    break;
                }

            }
        }

        static bool GoOn()
        {


            Console.WriteLine("Would you like another radius? Y/N");
            string restart = Console.ReadLine().ToLower();
            if (restart == "y")
            {
                return true;
            }
            else if (restart == "n")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("Could you try again?");
                return GoOn();
            }
        }
    }
}