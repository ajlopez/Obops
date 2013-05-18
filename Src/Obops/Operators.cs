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
            return (int)left + (int)right;
        }
    }
}
