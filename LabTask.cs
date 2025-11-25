using System;

namespace LabWork
{
    public static class LabTask
    {
        public static void Execute()
        {
            try
            {
                int choice;
                Sphere sphere = new Sphere();
                Ellipsoid ellipsoid = new Ellipsoid();
                Console.Write("1. Ellipsoid \n2. Sphere\n");
                Console.WriteLine("Enter choice >> "); choice = int.Parse(Console.ReadLine());
                if (choice < 1 || choice > 2) throw new Exception("Choice must be between 1 and 2.");
                switch (choice)
                {
                    case 1:
                        ellipsoid.FillData();
                        Console.WriteLine(ellipsoid.ToString());
                        Console.WriteLine($"Volume of Ellipsoid: {ellipsoid.GetVolume()}");
                        break;
                    case 2:
                        sphere.FillData();
                        Console.WriteLine(sphere.ToString());
                        Console.WriteLine($"Volume of Sphere: {sphere.GetVolume()}");
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
