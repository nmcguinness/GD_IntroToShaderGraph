using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class IntExtensions
{
    public static int DoSomething(this int target, int value, bool squareAdd)
    {
        if (squareAdd)
            return target * target + value;
        else
            return target * target;
    }

    public static void DoSomethingRef(this ref int target, int value)
    {
        target *= value;
    }
}