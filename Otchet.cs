using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ооо
{
    class Otchet : Interface1

    {
        int My_x, My_y;

        public int x
        {
            set { My_x = value; }
            get { return My_x; }
        }

        public int y
        {
            set { My_y = value; }
            get { return My_y; }
        }

        public Otchet() { }
        public Otchet(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

        public virtual int Sum()

        {
            return x + y;
        
        }

        public int Otr()
        {
            return x - y;
        }

        public int Prz()
        {
            return x * y;
        }

        public int Del()
        {
            return x / y;
        }

        public virtual void reWrite()
        {
            Console.WriteLine("Переменная x: {0}\nПеременная y: {1}",x,y)
        }

    }
}
