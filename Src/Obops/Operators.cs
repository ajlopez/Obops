namespace Obops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Operators
    {
        private static Func<object, object, object>[,]addops = new Func<object, object, object>[20, 20];

        static Operators()
        {
            addops[(int)TypeCode.Int16, (int)TypeCode.Int16] = (left, right) => (short)left + (short)right;
            addops[(int)TypeCode.Int16, (int)TypeCode.Int32] = (left, right) => (short)left + (int)right;
            addops[(int)TypeCode.Int16, (int)TypeCode.Int64] = (left, right) => (short)left + (long)right;
            addops[(int)TypeCode.Int16, (int)TypeCode.Double] = (left, right) => (short)left + (double)right;

            addops[(int)TypeCode.Int32, (int)TypeCode.Int16] = (left, right) => (int)left + (short)right;
            addops[(int)TypeCode.Int32, (int)TypeCode.Int32] = (left, right) => (int)left + (int)right;
            addops[(int)TypeCode.Int32, (int)TypeCode.Int64] = (left, right) => (int)left + (long)right;
            addops[(int)TypeCode.Int32, (int)TypeCode.Double] = (left, right) => (int)left + (double)right;

            addops[(int)TypeCode.Double, (int)TypeCode.Int32] = (left, right) => (double)left + (int)right;
            addops[(int)TypeCode.Double, (int)TypeCode.Int64] = (left, right) => (double)left + (long)right;
            addops[(int)TypeCode.Double, (int)TypeCode.Double] = (left, right) => (double)left + (double)right;
        }

        public static object AddObject(object left, object right)
        {
            if (left is IConvertible && right is IConvertible)
            {
                return addops[(int)((IConvertible)left).GetTypeCode(), (int)((IConvertible)right).GetTypeCode()](left, right);
            }

            throw new NotImplementedException();
        }
    }
}
