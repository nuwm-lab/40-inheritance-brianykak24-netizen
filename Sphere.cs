using System;

namespace LabWork
{
    public class Sphere
    {
        private double _x1, _x2, _x3, _b1, _b2, _b3, _r;

        public Sphere()
        {
            //fill this ctor
            this._x1 = 1;
            this._x2 = 1;
            this._x3 = 1;
            this._b1 = 1;
            this._b2 = 1;
            this._b3 = 1;
            this._r = 1;

        }
        public Sphere(double x_1, double x_2, double x_3, double b_1, double b_2, double b_3, double R)
        {
            this._x1 = x_1;
            this._x2 = x_2;
            this._x3 = x_3;

            this._b1 = b_1;
            this._b2 = b_2;
            this._b3 = b_3;
            
            this._r = R;
        }

        public double GetR() { return _r; }
        public double GetX_1() { return _x1; }
        public double GetX_2() { return _x2; }
        public double GetX_3() { return _x3; }

        public double GetB_1() { return _b1; }
        public double GetB_2() { return _b2; }
        public double GetB_3() { return _b3; }


        public virtual double GetVolume() { return (double)(4.0 / 3.0) * Math.PI * _r * _r * _r; }
        public override string ToString() {return $"({_x1} - {_b1})^2 - ({_x2} - {_b2})^2 + ({_x3} - {_b3})^2 = ({_r})^2";}

        public virtual void FillData()
        {
            Console.WriteLine("Enter R >>> "); _r = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter X_1 >>> "); _x1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter X_2 >>> "); _x2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter X_3 >>> "); _x3 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter B_1 >>> "); _b1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter B_2 >>> "); _b2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter B_3 >>> "); _b3 = Double.Parse(Console.ReadLine());
        }

    }
}
