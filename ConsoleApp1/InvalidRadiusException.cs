using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InvalidRadiusException : Exception
    {
        public InvalidRadiusException(double r) : base($"Invalid radius: {r}. Must be greater than zero.")
        {
        }
    }
}
