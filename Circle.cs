using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    public class Circle
    {
        public const double PI = Math.PI;
        public double Radius { get; set; }

        public double Perimetr()
        {
            return 2 * PI * Radius;
        }

        public double Ploshad()
        {
            return PI * Radius * Radius;
        }
    }
}
