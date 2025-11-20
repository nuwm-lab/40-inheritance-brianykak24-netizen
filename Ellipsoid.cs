using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    public class Ellipsoid : Circle
    {
        private double A_1, A_2, A_3;
        public Ellipsoid(double x_1, double x_2, double x_3, double b_1, double b_2, double b_3, double a_1, double a_2, double a_3, double R = 1)
            : base(x_1, x_2, x_3, b_1, b_2, b_3, R)
        {
            this.A_1 = a_1;
            this.A_2 = a_2;
            this.A_3 = a_3;
        }

        public Ellipsoid() : base()
        {
            this.A_1 = 0;
            this.A_2 = 0;
            this.A_3 = 0;
        }

        public double GetA_1() { return A_1; }
        public double GetA_2() { return A_2; }
        public double GetA_3() { return A_3; }

        public override double GetVolume() { return (double)(4.0 / 3.0) * Math.PI * (A_1) * (A_2) * (A_3); }
        public override string ToString() { return $"(({GetX_1()} - {GetB_1()})^2)/({A_1}^2) + (({GetX_2()} - {GetB_2()})^2)/({A_2}^2) + (({GetX_3()} - {GetB_3()})^2)/({A_3}^2) = 1"; }

        public override void FillData()
        {
            base.FillData();

            Console.WriteLine("Enter A_1 >>> "); A_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A_2 >>> "); A_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A_3 >>> "); A_3 = Convert.ToInt32(Console.ReadLine());
        }
    }
}

