using System;

namespace LabWork
{
    using System;

    public class Sphere // Змінні поля, R може бути змінене через FillData
    {
        // Поля, які мають змінюватися в FillData, не повинні бути readonly
        private double _x1, _x2, _x3, _b1, _b2, _b3, _r;

        public double R => _r;
        public double X1 => _x1;
        public double X2 => _x2;
        public double X3 => _x3;
        public double B1 => _b1;
        public double B2 => _b2;
        public double B3 => _b3;
        // Конструктори
        public Sphere() : this(0, 0, 0, 0, 0, 0, 1) { }

        public Sphere(double x1, double x2, double x3, double b1, double b2, double b3, double r)
        {
            this._x1 = x1;
            this._x2 = x2;
            this._x3 = x3;
            this._b1 = b1;
            this._b2 = b2;
            this._b3 = b3;
            // Перевірка позитивності R
            if (r <= 0) throw new ArgumentException("Radius (R) must be positive.");
            this._r = r;
        }

        // Допоміжний метод для безпечного парсингу (доступний похідним класам)
        protected double GetDoubleInput(string prompt)
        {
            Console.Write(prompt);
            double value;
            // Перевірка на null/некоректний ввід
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write(prompt);
            }
            return value;
        }

        protected double GetPositiveDoubleInput(string prompt)
        {
            double value;
            do
            {
                value = GetDoubleInput(prompt);
                if (value > 0)
                {
                    return value;
                }
                Console.WriteLine("Error: The value must be positive (greater than 0).");
            } while (true);
        }

        public virtual double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * R * R * R;
        }

        public override string ToString()
        {
            double rSquared = R * R;
            return $"({X1} - {B1})^2 + ({X2} - {B2})^2 + ({X3} - {B3})^2 = {rSquared}";
        }

        public virtual void FillData()
        {
            Console.WriteLine("--- Entering Sphere Data ---");

            // Покращений порядок: Центр (B) -> Координати (X) -> Розмір (R)
            _b1 = GetDoubleInput("Enter B1 (Center X) >>> ");
            _b2 = GetDoubleInput("Enter B2 (Center Y) >>> ");
            _b3 = GetDoubleInput("Enter B3 (Center Z) >>> ");

            _x1 = GetDoubleInput("Enter X1 (Coordinate X) >>> ");
            _x2 = GetDoubleInput("Enter X2 (Coordinate Y) >>> ");
            _x3 = GetDoubleInput("Enter X3 (Coordinate Z) >>> ");

            // Використання валідації на позитивність
            _r = GetPositiveDoubleInput("Enter R (Radius) >>> ");
        }
    }
}
