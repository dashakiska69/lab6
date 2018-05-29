using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ооо
{
    class Otchet1 : Otchet
    {
        public int z;

        public Otchet1(int z, int x, int y)
            : base(x, y)
        {
            this.z = z;
        }

        // Переопределим метод Sum
        public override int Sum()
        {
            return base.x + base.y + z;
        }

        public override void reWrite()
        {
            base.reWrite();
            Console.WriteLine("количество дней: " + z);
        }
    }
}

