using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    public class Ellipsoid : Circle
    {
        private int a_1, a_2, a_3;
        public Ellipsoid(int x_1, int x_2, int x_3, int b_1, int b_2, int b_3, int a_1, int a_2, int a_3, int R = 1) : base(x_1, x_2, x_3, b_1, b_2, b_3, R)
        {
            this.a_1 = a_1;
            this.a_2 = a_2;
            this.a_3 = a_3;
        }

        public Ellipsoid() : base()
        {
            this.a_1 = 0;
            this.a_2 = 0;
            this.a_3 = 0;
        }

        public int GetA_1() { return a_1; }
        public int GetA_2() { return a_2; }
        public int GetA_3() { return a_3; }

        public override double GetVolume() { return (double)(4.0 / 3.0) * Math.PI * (a_1) * (a_2) * (a_3); }
        public override string ToString() { return $"(({GetX_1()} - {GetB_1()})^2)/({a_1}^2) + (({GetX_2()} - {GetB_2()})^2)/({a_2}^2) + (({GetX_3()} - {GetB_3()})^2)/({a_3}^2) = 1"; }

        public void FillData()
        {
            base.FillData();

            Console.WriteLine("Enter a_1 >>> "); a_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a_2 >>> "); a_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a_3 >>> "); a_3 = Convert.ToInt32(Console.ReadLine());
        }
    }
}

