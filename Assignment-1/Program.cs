using System;

namespace Assignment_1
{
    class Program
    {
        static int Power (int x,int y)
        {
            int temp;
            if (y == 0)
                return 1;
            temp = Power(x, y / 2);
            if (y % 2 == 0)
                return temp * temp;
            else
                return x * temp * temp;
        }
    }
}
