namespace Obops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Operators
    {
        private static Func<object, object, object>[,] addFunctions = new Func<object, object, object>[20, 20];
        private static Func<object, object, object>[,] subtractFunctions = new Func<object, object, object>[20, 20];
        private static Func<object, object, object>[,] multiplyFunctions = new Func<object, object, object>[20, 20];
        private static Func<object, object, object>[,] divideFunctions = new Func<object, object, object>[20, 20];

        static Operators()
        {
            addFunctions[(int)TypeCode.Int16, (int)TypeCode.Int16] = (left, right) => (short)left + (short)right;
            addFunctions[(int)TypeCode.Int16, (int)TypeCode.Int32] = (left, right) => (short)left + (int)right;
            addFunctions[(int)TypeCode.Int16, (int)TypeCode.Int64] = (left, right) => (short)left + (long)right;
            addFunctions[(int)TypeCode.Int16, (int)TypeCode.Single] = (left, right) => (short)left + (float)right;
            addFunctions[(int)TypeCode.Int16, (int)TypeCode.Double] = (left, right) => (short)left + (double)right;

            addFunctions[(int)TypeCode.Int32, (int)TypeCode.Int16] = (left, right) => (int)left + (short)right;
            addFunctions[(int)TypeCode.Int32, (int)TypeCode.Int32] = (left, right) => (int)left + (int)right;
            addFunctions[(int)TypeCode.Int32, (int)TypeCode.Int64] = (left, right) => (int)left + (long)right;
            addFunctions[(int)TypeCode.Int32, (int)TypeCode.Single] = (left, right) => (int)left + (float)right;
            addFunctions[(int)TypeCode.Int32, (int)TypeCode.Double] = (left, right) => (int)left + (double)right;

            addFunctions[(int)TypeCode.Int64, (int)TypeCode.Int16] = (left, right) => (long)left + (short)right;
            addFunctions[(int)TypeCode.Int64, (int)TypeCode.Int32] = (left, right) => (long)left + (int)right;
            addFunctions[(int)TypeCode.Int64, (int)TypeCode.Int64] = (left, right) => (long)left + (long)right;
            addFunctions[(int)TypeCode.Int64, (int)TypeCode.Single] = (left, right) => (long)left + (float)right;
            addFunctions[(int)TypeCode.Int64, (int)TypeCode.Double] = (left, right) => (long)left + (double)right;

            addFunctions[(int)TypeCode.Single, (int)TypeCode.Int16] = (left, right) => (float)left + (short)right;
            addFunctions[(int)TypeCode.Single, (int)TypeCode.Int32] = (left, right) => (float)left + (int)right;
            addFunctions[(int)TypeCode.Single, (int)TypeCode.Int64] = (left, right) => (float)left + (long)right;
            addFunctions[(int)TypeCode.Single, (int)TypeCode.Single] = (left, right) => (float)left + (float)right;
            addFunctions[(int)TypeCode.Single, (int)TypeCode.Double] = (left, right) => (float)left + (double)right;

            addFunctions[(int)TypeCode.Double, (int)TypeCode.Int16] = (left, right) => (double)left + (short)right;
            addFunctions[(int)TypeCode.Double, (int)TypeCode.Int32] = (left, right) => (double)left + (int)right;
            addFunctions[(int)TypeCode.Double, (int)TypeCode.Int64] = (left, right) => (double)left + (long)right;
            addFunctions[(int)TypeCode.Double, (int)TypeCode.Single] = (left, right) => (double)left + (float)right;
            addFunctions[(int)TypeCode.Double, (int)TypeCode.Double] = (left, right) => (double)left + (double)right;

            subtractFunctions[(int)TypeCode.Int16, (int)TypeCode.Int16] = (left, right) => (short)left - (short)right;
            subtractFunctions[(int)TypeCode.Int16, (int)TypeCode.Int32] = (left, right) => (short)left - (int)right;
            subtractFunctions[(int)TypeCode.Int16, (int)TypeCode.Int64] = (left, right) => (short)left - (long)right;
            subtractFunctions[(int)TypeCode.Int16, (int)TypeCode.Single] = (left, right) => (short)left - (float)right;
            subtractFunctions[(int)TypeCode.Int16, (int)TypeCode.Double] = (left, right) => (short)left - (double)right;

            subtractFunctions[(int)TypeCode.Int32, (int)TypeCode.Int16] = (left, right) => (int)left - (short)right;
            subtractFunctions[(int)TypeCode.Int32, (int)TypeCode.Int32] = (left, right) => (int)left - (int)right;
            subtractFunctions[(int)TypeCode.Int32, (int)TypeCode.Int64] = (left, right) => (int)left - (long)right;
            subtractFunctions[(int)TypeCode.Int32, (int)TypeCode.Single] = (left, right) => (int)left - (float)right;
            subtractFunctions[(int)TypeCode.Int32, (int)TypeCode.Double] = (left, right) => (int)left - (double)right;

            subtractFunctions[(int)TypeCode.Int64, (int)TypeCode.Int16] = (left, right) => (long)left - (short)right;
            subtractFunctions[(int)TypeCode.Int64, (int)TypeCode.Int32] = (left, right) => (long)left - (int)right;
            subtractFunctions[(int)TypeCode.Int64, (int)TypeCode.Int64] = (left, right) => (long)left - (long)right;
            subtractFunctions[(int)TypeCode.Int64, (int)TypeCode.Single] = (left, right) => (long)left - (float)right;
            subtractFunctions[(int)TypeCode.Int64, (int)TypeCode.Double] = (left, right) => (long)left - (double)right;

            subtractFunctions[(int)TypeCode.Single, (int)TypeCode.Int16] = (left, right) => (float)left - (short)right;
            subtractFunctions[(int)TypeCode.Single, (int)TypeCode.Int32] = (left, right) => (float)left - (int)right;
            subtractFunctions[(int)TypeCode.Single, (int)TypeCode.Int64] = (left, right) => (float)left - (long)right;
            subtractFunctions[(int)TypeCode.Single, (int)TypeCode.Single] = (left, right) => (float)left - (float)right;
            subtractFunctions[(int)TypeCode.Single, (int)TypeCode.Double] = (left, right) => (float)left - (double)right;

            subtractFunctions[(int)TypeCode.Double, (int)TypeCode.Int16] = (left, right) => (double)left - (short)right;
            subtractFunctions[(int)TypeCode.Double, (int)TypeCode.Int32] = (left, right) => (double)left - (int)right;
            subtractFunctions[(int)TypeCode.Double, (int)TypeCode.Int64] = (left, right) => (double)left - (long)right;
            subtractFunctions[(int)TypeCode.Double, (int)TypeCode.Single] = (left, right) => (double)left - (float)right;
            subtractFunctions[(int)TypeCode.Double, (int)TypeCode.Double] = (left, right) => (double)left - (double)right;

            multiplyFunctions[(int)TypeCode.Int16, (int)TypeCode.Int16] = (left, right) => (short)left * (short)right;
            multiplyFunctions[(int)TypeCode.Int16, (int)TypeCode.Int32] = (left, right) => (short)left * (int)right;
            multiplyFunctions[(int)TypeCode.Int16, (int)TypeCode.Int64] = (left, right) => (short)left * (long)right;
            multiplyFunctions[(int)TypeCode.Int16, (int)TypeCode.Single] = (left, right) => (short)left * (float)right;
            multiplyFunctions[(int)TypeCode.Int16, (int)TypeCode.Double] = (left, right) => (short)left * (double)right;

            multiplyFunctions[(int)TypeCode.Int32, (int)TypeCode.Int16] = (left, right) => (int)left * (short)right;
            multiplyFunctions[(int)TypeCode.Int32, (int)TypeCode.Int32] = (left, right) => (int)left * (int)right;
            multiplyFunctions[(int)TypeCode.Int32, (int)TypeCode.Int64] = (left, right) => (int)left * (long)right;
            multiplyFunctions[(int)TypeCode.Int32, (int)TypeCode.Single] = (left, right) => (int)left * (float)right;
            multiplyFunctions[(int)TypeCode.Int32, (int)TypeCode.Double] = (left, right) => (int)left * (double)right;

            multiplyFunctions[(int)TypeCode.Int64, (int)TypeCode.Int16] = (left, right) => (long)left * (short)right;
            multiplyFunctions[(int)TypeCode.Int64, (int)TypeCode.Int32] = (left, right) => (long)left * (int)right;
            multiplyFunctions[(int)TypeCode.Int64, (int)TypeCode.Int64] = (left, right) => (long)left * (long)right;
            multiplyFunctions[(int)TypeCode.Int64, (int)TypeCode.Single] = (left, right) => (long)left * (float)right;
            multiplyFunctions[(int)TypeCode.Int64, (int)TypeCode.Double] = (left, right) => (long)left * (double)right;

            multiplyFunctions[(int)TypeCode.Single, (int)TypeCode.Int16] = (left, right) => (float)left * (short)right;
            multiplyFunctions[(int)TypeCode.Single, (int)TypeCode.Int32] = (left, right) => (float)left * (int)right;
            multiplyFunctions[(int)TypeCode.Single, (int)TypeCode.Int64] = (left, right) => (float)left * (long)right;
            multiplyFunctions[(int)TypeCode.Single, (int)TypeCode.Single] = (left, right) => (float)left * (float)right;
            multiplyFunctions[(int)TypeCode.Single, (int)TypeCode.Double] = (left, right) => (float)left * (double)right;

            multiplyFunctions[(int)TypeCode.Double, (int)TypeCode.Int16] = (left, right) => (double)left * (short)right;
            multiplyFunctions[(int)TypeCode.Double, (int)TypeCode.Int32] = (left, right) => (double)left * (int)right;
            multiplyFunctions[(int)TypeCode.Double, (int)TypeCode.Int64] = (left, right) => (double)left * (long)right;
            multiplyFunctions[(int)TypeCode.Double, (int)TypeCode.Single] = (left, right) => (double)left * (float)right;
            multiplyFunctions[(int)TypeCode.Double, (int)TypeCode.Double] = (left, right) => (double)left * (double)right;

            divideFunctions[(int)TypeCode.Int16, (int)TypeCode.Int16] = (left, right) => (short)left / (short)right;
            divideFunctions[(int)TypeCode.Int16, (int)TypeCode.Int32] = (left, right) => (short)left / (int)right;
            divideFunctions[(int)TypeCode.Int16, (int)TypeCode.Int64] = (left, right) => (short)left / (long)right;
            divideFunctions[(int)TypeCode.Int16, (int)TypeCode.Single] = (left, right) => (short)left / (float)right;
            divideFunctions[(int)TypeCode.Int16, (int)TypeCode.Double] = (left, right) => (short)left / (double)right;

            divideFunctions[(int)TypeCode.Int32, (int)TypeCode.Int16] = (left, right) => (int)left / (short)right;
            divideFunctions[(int)TypeCode.Int32, (int)TypeCode.Int32] = (left, right) => (int)left / (int)right;
            divideFunctions[(int)TypeCode.Int32, (int)TypeCode.Int64] = (left, right) => (int)left / (long)right;
            divideFunctions[(int)TypeCode.Int32, (int)TypeCode.Single] = (left, right) => (int)left / (float)right;
            divideFunctions[(int)TypeCode.Int32, (int)TypeCode.Double] = (left, right) => (int)left / (double)right;

            divideFunctions[(int)TypeCode.Int64, (int)TypeCode.Int16] = (left, right) => (long)left / (short)right;
            divideFunctions[(int)TypeCode.Int64, (int)TypeCode.Int32] = (left, right) => (long)left / (int)right;
            divideFunctions[(int)TypeCode.Int64, (int)TypeCode.Int64] = (left, right) => (long)left / (long)right;
            divideFunctions[(int)TypeCode.Int64, (int)TypeCode.Single] = (left, right) => (long)left / (float)right;
            divideFunctions[(int)TypeCode.Int64, (int)TypeCode.Double] = (left, right) => (long)left / (double)right;

            divideFunctions[(int)TypeCode.Single, (int)TypeCode.Int16] = (left, right) => (float)left / (short)right;
            divideFunctions[(int)TypeCode.Single, (int)TypeCode.Int32] = (left, right) => (float)left / (int)right;
            divideFunctions[(int)TypeCode.Single, (int)TypeCode.Int64] = (left, right) => (float)left / (long)right;
            divideFunctions[(int)TypeCode.Single, (int)TypeCode.Single] = (left, right) => (float)left / (float)right;
            divideFunctions[(int)TypeCode.Single, (int)TypeCode.Double] = (left, right) => (float)left / (double)right;

            divideFunctions[(int)TypeCode.Double, (int)TypeCode.Int16] = (left, right) => (double)left / (short)right;
            divideFunctions[(int)TypeCode.Double, (int)TypeCode.Int32] = (left, right) => (double)left / (int)right;
            divideFunctions[(int)TypeCode.Double, (int)TypeCode.Int64] = (left, right) => (double)left / (long)right;
            divideFunctions[(int)TypeCode.Double, (int)TypeCode.Single] = (left, right) => (double)left / (float)right;
            divideFunctions[(int)TypeCode.Double, (int)TypeCode.Double] = (left, right) => (double)left / (double)right;
        }

        public static object AddObject(object left, object right)
        {
            if (left is IConvertible && right is IConvertible)
            {
                return addFunctions[(int)((IConvertible)left).GetTypeCode(), (int)((IConvertible)right).GetTypeCode()](left, right);
            }

            throw new NotImplementedException();
        }

        public static object SubtractObject(object left, object right)
        {
            if (left is IConvertible && right is IConvertible)
            {
                return subtractFunctions[(int)((IConvertible)left).GetTypeCode(), (int)((IConvertible)right).GetTypeCode()](left, right);
            }

            throw new NotImplementedException();
        }

        public static object MultiplyObject(object left, object right)
        {
            if (left is IConvertible && right is IConvertible)
            {
                return multiplyFunctions[(int)((IConvertible)left).GetTypeCode(), (int)((IConvertible)right).GetTypeCode()](left, right);
            }

            throw new NotImplementedException();
        }

        public static object DivideObject(object left, object right)
        {
            if (left is IConvertible && right is IConvertible)
            {
                return divideFunctions[(int)((IConvertible)left).GetTypeCode(), (int)((IConvertible)right).GetTypeCode()](left, right);
            }

            throw new NotImplementedException();
        }
    }
}
