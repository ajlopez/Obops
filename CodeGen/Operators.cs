namespace Obops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Operators
    {
        private static Func<object, object, object>[,]AddFunctions = new Func<object, object, object>[20, 20];
        private static Func<object, object, object>[,]SubtractFunctions = new Func<object, object, object>[20, 20];
        private static Func<object, object, object>[,]MultiplyFunctions = new Func<object, object, object>[20, 20];
        private static Func<object, object, object>[,]DivideFunctions = new Func<object, object, object>[20, 20];

        static Operators()
        {
            AddFunctions[(int)TypeCode.Int16, (int)TypeCode.Int16] = (left, right) => (short)left + (short)right;
            AddFunctions[(int)TypeCode.Int16, (int)TypeCode.Int32] = (left, right) => (short)left + (int)right;
            AddFunctions[(int)TypeCode.Int16, (int)TypeCode.Int64] = (left, right) => (short)left + (long)right;
            AddFunctions[(int)TypeCode.Int16, (int)TypeCode.Single] = (left, right) => (short)left + (float)right;
            AddFunctions[(int)TypeCode.Int16, (int)TypeCode.Double] = (left, right) => (short)left + (double)right;

            AddFunctions[(int)TypeCode.Int32, (int)TypeCode.Int16] = (left, right) => (int)left + (short)right;
            AddFunctions[(int)TypeCode.Int32, (int)TypeCode.Int32] = (left, right) => (int)left + (int)right;
            AddFunctions[(int)TypeCode.Int32, (int)TypeCode.Int64] = (left, right) => (int)left + (long)right;
            AddFunctions[(int)TypeCode.Int32, (int)TypeCode.Single] = (left, right) => (int)left + (float)right;
            AddFunctions[(int)TypeCode.Int32, (int)TypeCode.Double] = (left, right) => (int)left + (double)right;

            AddFunctions[(int)TypeCode.Int64, (int)TypeCode.Int16] = (left, right) => (long)left + (short)right;
            AddFunctions[(int)TypeCode.Int64, (int)TypeCode.Int32] = (left, right) => (long)left + (int)right;
            AddFunctions[(int)TypeCode.Int64, (int)TypeCode.Int64] = (left, right) => (long)left + (long)right;
            AddFunctions[(int)TypeCode.Int64, (int)TypeCode.Single] = (left, right) => (long)left + (float)right;
            AddFunctions[(int)TypeCode.Int64, (int)TypeCode.Double] = (left, right) => (long)left + (double)right;

            AddFunctions[(int)TypeCode.Single, (int)TypeCode.Int16] = (left, right) => (float)left + (short)right;
            AddFunctions[(int)TypeCode.Single, (int)TypeCode.Int32] = (left, right) => (float)left + (int)right;
            AddFunctions[(int)TypeCode.Single, (int)TypeCode.Int64] = (left, right) => (float)left + (long)right;
            AddFunctions[(int)TypeCode.Single, (int)TypeCode.Single] = (left, right) => (float)left + (float)right;
            AddFunctions[(int)TypeCode.Single, (int)TypeCode.Double] = (left, right) => (float)left + (double)right;

            AddFunctions[(int)TypeCode.Double, (int)TypeCode.Int16] = (left, right) => (double)left + (short)right;
            AddFunctions[(int)TypeCode.Double, (int)TypeCode.Int32] = (left, right) => (double)left + (int)right;
            AddFunctions[(int)TypeCode.Double, (int)TypeCode.Int64] = (left, right) => (double)left + (long)right;
            AddFunctions[(int)TypeCode.Double, (int)TypeCode.Single] = (left, right) => (double)left + (float)right;
            AddFunctions[(int)TypeCode.Double, (int)TypeCode.Double] = (left, right) => (double)left + (double)right;

            SubtractFunctions[(int)TypeCode.Int16, (int)TypeCode.Int16] = (left, right) => (short)left - (short)right;
            SubtractFunctions[(int)TypeCode.Int16, (int)TypeCode.Int32] = (left, right) => (short)left - (int)right;
            SubtractFunctions[(int)TypeCode.Int16, (int)TypeCode.Int64] = (left, right) => (short)left - (long)right;
            SubtractFunctions[(int)TypeCode.Int16, (int)TypeCode.Single] = (left, right) => (short)left - (float)right;
            SubtractFunctions[(int)TypeCode.Int16, (int)TypeCode.Double] = (left, right) => (short)left - (double)right;

            SubtractFunctions[(int)TypeCode.Int32, (int)TypeCode.Int16] = (left, right) => (int)left - (short)right;
            SubtractFunctions[(int)TypeCode.Int32, (int)TypeCode.Int32] = (left, right) => (int)left - (int)right;
            SubtractFunctions[(int)TypeCode.Int32, (int)TypeCode.Int64] = (left, right) => (int)left - (long)right;
            SubtractFunctions[(int)TypeCode.Int32, (int)TypeCode.Single] = (left, right) => (int)left - (float)right;
            SubtractFunctions[(int)TypeCode.Int32, (int)TypeCode.Double] = (left, right) => (int)left - (double)right;

            SubtractFunctions[(int)TypeCode.Int64, (int)TypeCode.Int16] = (left, right) => (long)left - (short)right;
            SubtractFunctions[(int)TypeCode.Int64, (int)TypeCode.Int32] = (left, right) => (long)left - (int)right;
            SubtractFunctions[(int)TypeCode.Int64, (int)TypeCode.Int64] = (left, right) => (long)left - (long)right;
            SubtractFunctions[(int)TypeCode.Int64, (int)TypeCode.Single] = (left, right) => (long)left - (float)right;
            SubtractFunctions[(int)TypeCode.Int64, (int)TypeCode.Double] = (left, right) => (long)left - (double)right;

            SubtractFunctions[(int)TypeCode.Single, (int)TypeCode.Int16] = (left, right) => (float)left - (short)right;
            SubtractFunctions[(int)TypeCode.Single, (int)TypeCode.Int32] = (left, right) => (float)left - (int)right;
            SubtractFunctions[(int)TypeCode.Single, (int)TypeCode.Int64] = (left, right) => (float)left - (long)right;
            SubtractFunctions[(int)TypeCode.Single, (int)TypeCode.Single] = (left, right) => (float)left - (float)right;
            SubtractFunctions[(int)TypeCode.Single, (int)TypeCode.Double] = (left, right) => (float)left - (double)right;

            SubtractFunctions[(int)TypeCode.Double, (int)TypeCode.Int16] = (left, right) => (double)left - (short)right;
            SubtractFunctions[(int)TypeCode.Double, (int)TypeCode.Int32] = (left, right) => (double)left - (int)right;
            SubtractFunctions[(int)TypeCode.Double, (int)TypeCode.Int64] = (left, right) => (double)left - (long)right;
            SubtractFunctions[(int)TypeCode.Double, (int)TypeCode.Single] = (left, right) => (double)left - (float)right;
            SubtractFunctions[(int)TypeCode.Double, (int)TypeCode.Double] = (left, right) => (double)left - (double)right;

            MultiplyFunctions[(int)TypeCode.Int16, (int)TypeCode.Int16] = (left, right) => (short)left * (short)right;
            MultiplyFunctions[(int)TypeCode.Int16, (int)TypeCode.Int32] = (left, right) => (short)left * (int)right;
            MultiplyFunctions[(int)TypeCode.Int16, (int)TypeCode.Int64] = (left, right) => (short)left * (long)right;
            MultiplyFunctions[(int)TypeCode.Int16, (int)TypeCode.Single] = (left, right) => (short)left * (float)right;
            MultiplyFunctions[(int)TypeCode.Int16, (int)TypeCode.Double] = (left, right) => (short)left * (double)right;

            MultiplyFunctions[(int)TypeCode.Int32, (int)TypeCode.Int16] = (left, right) => (int)left * (short)right;
            MultiplyFunctions[(int)TypeCode.Int32, (int)TypeCode.Int32] = (left, right) => (int)left * (int)right;
            MultiplyFunctions[(int)TypeCode.Int32, (int)TypeCode.Int64] = (left, right) => (int)left * (long)right;
            MultiplyFunctions[(int)TypeCode.Int32, (int)TypeCode.Single] = (left, right) => (int)left * (float)right;
            MultiplyFunctions[(int)TypeCode.Int32, (int)TypeCode.Double] = (left, right) => (int)left * (double)right;

            MultiplyFunctions[(int)TypeCode.Int64, (int)TypeCode.Int16] = (left, right) => (long)left * (short)right;
            MultiplyFunctions[(int)TypeCode.Int64, (int)TypeCode.Int32] = (left, right) => (long)left * (int)right;
            MultiplyFunctions[(int)TypeCode.Int64, (int)TypeCode.Int64] = (left, right) => (long)left * (long)right;
            MultiplyFunctions[(int)TypeCode.Int64, (int)TypeCode.Single] = (left, right) => (long)left * (float)right;
            MultiplyFunctions[(int)TypeCode.Int64, (int)TypeCode.Double] = (left, right) => (long)left * (double)right;

            MultiplyFunctions[(int)TypeCode.Single, (int)TypeCode.Int16] = (left, right) => (float)left * (short)right;
            MultiplyFunctions[(int)TypeCode.Single, (int)TypeCode.Int32] = (left, right) => (float)left * (int)right;
            MultiplyFunctions[(int)TypeCode.Single, (int)TypeCode.Int64] = (left, right) => (float)left * (long)right;
            MultiplyFunctions[(int)TypeCode.Single, (int)TypeCode.Single] = (left, right) => (float)left * (float)right;
            MultiplyFunctions[(int)TypeCode.Single, (int)TypeCode.Double] = (left, right) => (float)left * (double)right;

            MultiplyFunctions[(int)TypeCode.Double, (int)TypeCode.Int16] = (left, right) => (double)left * (short)right;
            MultiplyFunctions[(int)TypeCode.Double, (int)TypeCode.Int32] = (left, right) => (double)left * (int)right;
            MultiplyFunctions[(int)TypeCode.Double, (int)TypeCode.Int64] = (left, right) => (double)left * (long)right;
            MultiplyFunctions[(int)TypeCode.Double, (int)TypeCode.Single] = (left, right) => (double)left * (float)right;
            MultiplyFunctions[(int)TypeCode.Double, (int)TypeCode.Double] = (left, right) => (double)left * (double)right;

            DivideFunctions[(int)TypeCode.Int16, (int)TypeCode.Int16] = (left, right) => (short)left / (short)right;
            DivideFunctions[(int)TypeCode.Int16, (int)TypeCode.Int32] = (left, right) => (short)left / (int)right;
            DivideFunctions[(int)TypeCode.Int16, (int)TypeCode.Int64] = (left, right) => (short)left / (long)right;
            DivideFunctions[(int)TypeCode.Int16, (int)TypeCode.Single] = (left, right) => (short)left / (float)right;
            DivideFunctions[(int)TypeCode.Int16, (int)TypeCode.Double] = (left, right) => (short)left / (double)right;

            DivideFunctions[(int)TypeCode.Int32, (int)TypeCode.Int16] = (left, right) => (int)left / (short)right;
            DivideFunctions[(int)TypeCode.Int32, (int)TypeCode.Int32] = (left, right) => (int)left / (int)right;
            DivideFunctions[(int)TypeCode.Int32, (int)TypeCode.Int64] = (left, right) => (int)left / (long)right;
            DivideFunctions[(int)TypeCode.Int32, (int)TypeCode.Single] = (left, right) => (int)left / (float)right;
            DivideFunctions[(int)TypeCode.Int32, (int)TypeCode.Double] = (left, right) => (int)left / (double)right;

            DivideFunctions[(int)TypeCode.Int64, (int)TypeCode.Int16] = (left, right) => (long)left / (short)right;
            DivideFunctions[(int)TypeCode.Int64, (int)TypeCode.Int32] = (left, right) => (long)left / (int)right;
            DivideFunctions[(int)TypeCode.Int64, (int)TypeCode.Int64] = (left, right) => (long)left / (long)right;
            DivideFunctions[(int)TypeCode.Int64, (int)TypeCode.Single] = (left, right) => (long)left / (float)right;
            DivideFunctions[(int)TypeCode.Int64, (int)TypeCode.Double] = (left, right) => (long)left / (double)right;

            DivideFunctions[(int)TypeCode.Single, (int)TypeCode.Int16] = (left, right) => (float)left / (short)right;
            DivideFunctions[(int)TypeCode.Single, (int)TypeCode.Int32] = (left, right) => (float)left / (int)right;
            DivideFunctions[(int)TypeCode.Single, (int)TypeCode.Int64] = (left, right) => (float)left / (long)right;
            DivideFunctions[(int)TypeCode.Single, (int)TypeCode.Single] = (left, right) => (float)left / (float)right;
            DivideFunctions[(int)TypeCode.Single, (int)TypeCode.Double] = (left, right) => (float)left / (double)right;

            DivideFunctions[(int)TypeCode.Double, (int)TypeCode.Int16] = (left, right) => (double)left / (short)right;
            DivideFunctions[(int)TypeCode.Double, (int)TypeCode.Int32] = (left, right) => (double)left / (int)right;
            DivideFunctions[(int)TypeCode.Double, (int)TypeCode.Int64] = (left, right) => (double)left / (long)right;
            DivideFunctions[(int)TypeCode.Double, (int)TypeCode.Single] = (left, right) => (double)left / (float)right;
            DivideFunctions[(int)TypeCode.Double, (int)TypeCode.Double] = (left, right) => (double)left / (double)right;

        }

        public static object AddObject(object left, object right)
        {
            if (left is IConvertible && right is IConvertible)
            {
                return AddFunctions[(int)((IConvertible)left).GetTypeCode(), (int)((IConvertible)right).GetTypeCode()](left, right);
            }

            throw new NotImplementedException();
        }

        public static object SubtractObject(object left, object right)
        {
            if (left is IConvertible && right is IConvertible)
            {
                return SubtractFunctions[(int)((IConvertible)left).GetTypeCode(), (int)((IConvertible)right).GetTypeCode()](left, right);
            }

            throw new NotImplementedException();
        }

        public static object MultiplyObject(object left, object right)
        {
            if (left is IConvertible && right is IConvertible)
            {
                return MultiplyFunctions[(int)((IConvertible)left).GetTypeCode(), (int)((IConvertible)right).GetTypeCode()](left, right);
            }

            throw new NotImplementedException();
        }

        public static object DivideObject(object left, object right)
        {
            if (left is IConvertible && right is IConvertible)
            {
                return DivideFunctions[(int)((IConvertible)left).GetTypeCode(), (int)((IConvertible)right).GetTypeCode()](left, right);
            }

            throw new NotImplementedException();
        }

    }
}
