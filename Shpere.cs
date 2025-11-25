using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    public class Shpere
    {
        private double _X_1, _X_2, _X_3, _B_1, _B_2, _B_3, _R;

        public Shpere()
        {
            //fill this ctor
            _X_1 = 0;
            _X_2 = 0;
            _X_3 = 0;
            _B_1 = 0;
            _B_2 = 0;
            _B_3 = 0;
            _R = 1;
               
        }
        public Shpere(double x_1, double x_2, double x_3, double b_1, double b_2, double b_3, double R)
        {
            this._X_1 = x_1;
            this._X_2 = x_2;
            this._X_3 = x_3;

            this._B_1 = b_1;
            this._B_2 = b_2;
            this._B_3 = b_3;
            
            this._R = R;
        }

        public double GetR() { return _R; }
        public double GetX_1() { return _X_1; }
        public double GetX_2() { return _X_2; }
        public double GetX_3() { return _X_3; }

        public double GetB_1() { return _B_1; }
        public double GetB_2() { return _B_2; }
        public double GetB_3() { return _B_3; }


        public virtual double GetVolume() { return (double)(4.0 / 3.0) * Math.PI * _R * _R * _R; }
        public override string ToString() {return $"({_X_1} - {_B_1})^2 - ({_X_2} - {_B_2})^2 + ({_X_3} - {_B_3})^2 = ({_R})^2";}

        public virtual void FillData()
        {
            Console.WriteLine("Enter R >>> "); _R = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter X_1 >>> "); _X_1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter X_2 >>> "); _X_2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter X_3 >>> "); _X_3 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter B_1 >>> "); _B_1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter B_2 >>> "); _B_2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter B_3 >>> "); _B_3 = Double.Parse(Console.ReadLine());

        }

    }
}
