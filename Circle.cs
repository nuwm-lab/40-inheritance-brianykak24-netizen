using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    public class Circle
    {
        private double X_1, X_2, X_3, B_1, B_2, B_3, R;

        public Circle()
        {
            //fill this ctor
            X_1 = 0;
            X_2 = 0;
            X_3 = 0;
            B_1 = 0;
            B_2 = 0;
            B_3 = 0;
            R = 1;
               
        }
        public Circle(double x_1, double x_2, double x_3, double b_1, double b_2, double b_3, double R)
        {
            this.X_1 = x_1;
            this.X_2 = x_2;
            this.X_3 = x_3;

            this.B_1 = b_1;
            this.B_2 = b_2;
            this.B_3 = b_3;
            
            this.R = R;
        }

        public double GetR() { return R; }
        public double GetX_1() { return X_1; }
        public double GetX_2() { return X_2; }
        public double GetX_3() { return X_3; }

        public double GetB_1() { return B_1; }
        public double GetB_2() { return B_2; }
        public double GetB_3() { return B_3; }


        public virtual double GetVolume() { return (double)(4.0 / 3.0) * Math.PI * R * R * R; }
        public override string ToString() {return $"({X_1} - {B_1})^2 - ({X_2} - {B_2})^2 + ({X_3} - {B_3})^2 = ({R})^2";}

        public virtual void FillData()
        {
            Console.WriteLine("Enter R >>> "); R = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter X_1 >>> "); X_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter X_2 >>> "); X_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter X_3 >>> "); X_3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter B_1 >>> "); B_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B_2 >>> "); B_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B_3 >>> "); B_3 = Convert.ToInt32(Console.ReadLine());

        }

    }
}
