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

            return (double)left + (double)right;
        }
    }
}
