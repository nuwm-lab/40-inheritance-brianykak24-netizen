using System;

namespace LabWork
{
    public class Sphere
    {
        // Приватні поля
        private double _x1, _x2, _x3, _b1, _b2, _b3;
        private double _r;

        // Публічні властивості (PascalCase) - тільки для читання
        public double R => _r;
        public double X1 => _x1;
        public double X2 => _x2;
        public double X3 => _x3;
        public double B1 => _b1;
        public double B2 => _b2;
        public double B3 => _b3;

        /// <summary>Безпараметричний конструктор (дефолтна сфера: центр (1,1,1), радіус 1)</summary>
        public Sphere() : this(1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0)
        {
        }

        /// <summary>Параметризований конструктор</summary>
        public Sphere(double x1, double x2, double x3, double b1, double b2, double b3, double r)
        {
            // Присвоєння приватним полям
            this._x1 = x1;
            this._x2 = x2;
            this._x3 = x3;

            this._b1 = b1;
            this._b2 = b2;
            this._b3 = b3;

            this._r = r;
        }

        // Методи та перевизначення
        public virtual double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * R * R * R;
        }

        public override string ToString()
        {
            // Використання властивостей
            return $"({X1} - {B1})^2 + ({X2} - {B2})^2 + ({X3} - {B3})^2 = ({R})^2";
        }

        public virtual void FillData()
        {
            // Реалізація безпечного вводу
            _r = GetDoubleInput("Enter R >>> ");
            _x1 = GetDoubleInput("Enter X1 >>> ");
            _x2 = GetDoubleInput("Enter X2 >>> ");
            _x3 = GetDoubleInput("Enter X3 >>> ");
            _b1 = GetDoubleInput("Enter B1 >>> ");
            _b2 = GetDoubleInput("Enter B2 >>> ");
            _b3 = GetDoubleInput("Enter B3 >>> ");
        }

        // Допоміжний метод для безпечного вводу
        private double GetDoubleInput(string prompt)
        {
            Console.Write(prompt);
            double value;
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write(prompt);
            }
            return value;
        }
    }
}
