using System;

namespace LabWork
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int choice;
                Circle circle = new Circle();
                Ellipsoid ellipsoid = new Ellipsoid();
                Console.Write("1. Ellipsoid \n2. Circle\n");
                Console.WriteLine("Enter choice >> "); choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2) throw new Exception("Choice must be between 1 and 2.");
                switch (choice)
                {
                    case 1:
                        ellipsoid.FillData();
                        Console.WriteLine(ellipsoid.ToString());
                        Console.WriteLine($"Volume of Ellipsoid: {ellipsoid.GetVolume()}");
                        break;
                    case 2:
                        circle.FillData();
                        Console.WriteLine(circle.ToString());
                        Console.WriteLine($"Volume of Circle: {circle.GetVolume()}");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
