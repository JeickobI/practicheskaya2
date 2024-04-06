using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    public class Square
    {
        public double Side { get; set; }

        public double Perimetr()
        {
            return 4 * Side;
        }

        public double Ploshad()
        {
            return Side * Side;
        }
    }
}
