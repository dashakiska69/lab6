using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ооо
{
    class Otchet3 : Otchet, maxmin
    {
        

        public Otchet3() { }
        public Otchet3(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

        public double Sred()
        {
            return (x + y) / 2;
        }

    }
}
