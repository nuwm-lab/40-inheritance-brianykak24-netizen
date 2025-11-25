using System;

namespace LabWork
{
    public class Ellipsoid : Sphere
    {
        private double _a1, _a2, _a3;

        public double A1 => _a1;
        public double A2 => _a2;
        public double A3 => _a3;

        public Ellipsoid(double x1, double x2, double x3, double b1, double b2, double b3, double a1, double a2, double a3)
            : base(x1, x2, x3, b1, b2, b3, 1.0) // Передаємо 1.0 як R до базового класу
        {
            this._a1 = a1;
            this._a2 = a2;
            this._a3 = a3;
        }

        public Ellipsoid() : this(1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0)
        {
        }

        public override double GetVolume()
        {
            // V = (4/3) * pi * a1 * a2 * a3
            return (4.0 / 3.0) * Math.PI * A1 * A2 * A3;
        }

        public override string ToString()
        {
            // (x-b1)^2/a1^2 + (y-b2)^2/a2^2 + (z-b3)^2/a3^2 = 1
            return $"(({X1} - {B1})^2)/({A1}^2) + (({X2} - {B2})^2)/({A2}^2) + (({X3} - {B3})^2)/({A3}^2) = 1";
        }

        public override void FillData()
        {
            base.FillData(); // Заповнює X1, B1, R і т.д.
                             // Заповнює A1, A2, A3 з використанням допоміжного методу GetDoubleInput (якщо він у Sphere є protected або private у Sphere та Ellipsoid є вкладеним)
                             // Якщо GetDoubleInput - private у Sphere, його потрібно продублювати або зробити protected.
        }
    }
}

