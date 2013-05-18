namespace Obops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Operators
    {
        public static object AddObject(object left, object right)
        {
            if (left is int)
                if (right is int)
                    return (int)left + (int)right;
                else
                    return (int)left + (double)right;

            if (right is int)
                return (double)left + (int)right;
            else if (right is long)
                return (double)left + (long)right;
            else
                return (double)left + (double)right;
        }
    }
}
