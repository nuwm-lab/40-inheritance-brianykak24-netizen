using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    public class Circle
    {
        private int x_1, x_2, x_3, b_1, b_2, b_3, R;

        public Circle()
        {
            
        }
        public Circle(int x_1, int x_2, int x_3, int b_1, int b_2, int b_3, int R)
        {
            this.x_1 = x_1;
            this.x_2 = x_2;
            this.x_3 = x_3;

            this.b_1 = b_1;
            this.b_2 = b_2;
            this.b_3 = b_3;
            
            this.R = R;
        }

        public int GetR() { return R; }
        public int GetX_1() { return x_1; }
        public int GetX_2() { return x_2; }
        public int GetX_3() { return x_3; }

        public int GetB_1() { return b_1; }
        public int GetB_2() { return b_2; }
        public int GetB_3() { return b_3; }


        public virtual double GetVolume() { return (double)(4.0 / 3.0) * Math.PI * R * R * R; }
        public override string ToString() {return $"({x_1} - {b_1})^2 - ({x_2} - {b_2})^2 + ({x_3} - {b_3})^2 = ({R})^2";}

        public void FillData()
        {
            Console.WriteLine("Enter R >>> "); R = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter x_1 >>> "); x_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x_2 >>> "); x_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x_3 >>> "); x_3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b_1 >>> "); b_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b_2 >>> "); b_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b_3 >>> "); b_3 = Convert.ToInt32(Console.ReadLine());

        }

    }
}
