using System;

namespace LabWork
{
    public class Ellipsoid : Sphere
    {
        private double _a1, _a2, _a3;
        public Ellipsoid(double x_1, double x_2, double x_3, double b_1, double b_2, double b_3, double a_1, double a_2, double a_3, double R = 1)
            : base(x_1, x_2, x_3, b_1, b_2, b_3, R)
        {
            this._a1 = a_1;
            this._a2 = a_2;
            this._a3 = a_3;
        }

        public Ellipsoid() : base()
        {
            this._a1 = 0;
            this._a2 = 0;
            this._a3 = 0;
        }

        public double GetA_1() { return _a1; }
        public double GetA_2() { return _a2; }
        public double GetA_3() { return _a3; }

        public override double GetVolume() { return (double)(4.0 / 3.0) * Math.PI * (_a1) * (_a2) * (_a3); }
        public override string ToString() { return $"(({GetX_1()} - {GetB_1()})^2)/({_a1}^2) + (({GetX_2()} - {GetB_2()})^2)/({_a2}^2) + (({GetX_3()} - {GetB_3()})^2)/({_a3}^2) = 1"; }

        public override void FillData()
        {
            base.FillData();

            Console.WriteLine("Enter _a1 >>> "); _a1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter _a2 >>> "); _a2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter _a3 >>> "); _a3 = Double.Parse(Console.ReadLine());
        }
    }
}

