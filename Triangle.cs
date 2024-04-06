using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    public class Triangle
    {
        public double a {  get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double h { get; set; }

        public double S()
        {
            return (a * h) / 2;
        }

        public double P()
        {
            return a + b + c;
        }
    }
}
