using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._6
{
    public class Square : Shape
    {
        public double A;

        public Square(double a)
        {
            A = a;
        }

        public override double GetArea()
        {
            return A * A;
        }
    }
}
