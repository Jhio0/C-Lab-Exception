using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Circle
    {
        private double radius;

        public void SetRadius(double r)
        {
            if (r > 0)
            {
                radius = r;
            }
            else
            {
                throw new InvalidRadiusException(r);
            }
        }

        public override string ToString()
        {
            return $"Circle with radius {radius}";
        }
    }
}
