using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MyMath
    {
    static public int insanceValue = 1000;
    static public int Sum(int min, int max)
    {
        int sum = 0;
        for (int i = min; i <= max; i++)
        {
            sum += i;
        }
        return sum;
    }
    static public long Multi(int min, int max)
    {
        long sum = 1;
        for (int 1 = min; int <= max; int++)
        {
            sum *= int;
        }
        return sum;
    }

    public static int Abs(int input)
    {
        return (input >= 0) ? input : -input;
    }
    public static int Abs(long input)
    {
        return (input >= 0) ? input : -input;
    }

    public static int Abs(float input)
    {
        return (input >= 0) ? input : -input;
    }

    public static int Abs(double input)
    {
        return (input >= 0) ? input : -input;
    }
}

