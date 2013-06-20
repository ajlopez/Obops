namespace Obops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Operators
    {
        private Func<object, object, object>[,] AddFunctions = new Func<object, object, object>[20, 20];
        private Func<object, object, object>[,] SubtractFunctions = new Func<object, object, object>[20, 20];
        private Func<object, object, object>[,] MultiplyFunctions = new Func<object, object, object>[20, 20];
        private Func<object, object, object>[,] DivideFunctions = new Func<object, object, object>[20, 20];
        private Func<object, object, object>[,] EqualFunctions = new Func<object, object, object>[20, 20];
        private Func<object, object, object>[,] NotEqualFunctions = new Func<object, object, object>[20, 20];
        private Func<object, object, object>[,] GreaterFunctions = new Func<object, object, object>[20, 20];
        private Func<object, object, object>[,] GreaterEqualFunctions = new Func<object, object, object>[20, 20];
        private Func<object, object, object>[,] LessFunctions = new Func<object, object, object>[20, 20];
        private Func<object, object, object>[,] LessEqualFunctions = new Func<object, object, object>[20, 20];

        public Operators()
        {
            this.AddFunctions[(int)TypeCode.Int16, (int)TypeCode.Int16] = (left, right) => (short)left + (short)right;
            this.AddFunctions[(int)TypeCode.Int16, (int)TypeCode.Int32] = (left, right) => (short)left + (int)right;
            this.AddFunctions[(int)TypeCode.Int16, (int)TypeCode.Int64] = (left, right) => (short)left + (long)right;
            this.AddFunctions[(int)TypeCode.Int16, (int)TypeCode.Single] = (left, right) => (short)left + (float)right;
            this.AddFunctions[(int)TypeCode.Int16, (int)TypeCode.Double] = (left, right) => (short)left + (double)right;

            this.AddFunctions[(int)TypeCode.Int32, (int)TypeCode.Int16] = (left, right) => (int)left + (short)right;
            this.AddFunctions[(int)TypeCode.Int32, (int)TypeCode.Int32] = (left, right) => (int)left + (int)right;
            this.AddFunctions[(int)TypeCode.Int32, (int)TypeCode.Int64] = (left, right) => (int)left + (long)right;
            this.AddFunctions[(int)TypeCode.Int32, (int)TypeCode.Single] = (left, right) => (int)left + (float)right;
            this.AddFunctions[(int)TypeCode.Int32, (int)TypeCode.Double] = (left, right) => (int)left + (double)right;

            this.AddFunctions[(int)TypeCode.Int64, (int)TypeCode.Int16] = (left, right) => (long)left + (short)right;
            this.AddFunctions[(int)TypeCode.Int64, (int)TypeCode.Int32] = (left, right) => (long)left + (int)right;
            this.AddFunctions[(int)TypeCode.Int64, (int)TypeCode.Int64] = (left, right) => (long)left + (long)right;
            this.AddFunctions[(int)TypeCode.Int64, (int)TypeCode.Single] = (left, right) => (long)left + (float)right;
            this.AddFunctions[(int)TypeCode.Int64, (int)TypeCode.Double] = (left, right) => (long)left + (double)right;

            this.AddFunctions[(int)TypeCode.Single, (int)TypeCode.Int16] = (left, right) => (float)left + (short)right;
            this.AddFunctions[(int)TypeCode.Single, (int)TypeCode.Int32] = (left, right) => (float)left + (int)right;
            this.AddFunctions[(int)TypeCode.Single, (int)TypeCode.Int64] = (left, right) => (float)left + (long)right;
            this.AddFunctions[(int)TypeCode.Single, (int)TypeCode.Single] = (left, right) => (float)left + (float)right;
            this.AddFunctions[(int)TypeCode.Single, (int)TypeCode.Double] = (left, right) => (float)left + (double)right;

            this.AddFunctions[(int)TypeCode.Double, (int)TypeCode.Int16] = (left, right) => (double)left + (short)right;
            this.AddFunctions[(int)TypeCode.Double, (int)TypeCode.Int32] = (left, right) => (double)left + (int)right;
            this.AddFunctions[(int)TypeCode.Double, (int)TypeCode.Int64] = (left, right) => (double)left + (long)right;
            this.AddFunctions[(int)TypeCode.Double, (int)TypeCode.Single] = (left, right) => (double)left + (float)right;
            this.AddFunctions[(int)TypeCode.Double, (int)TypeCode.Double] = (left, right) => (double)left + (double)right;

            this.SubtractFunctions[(int)TypeCode.Int16, (int)TypeCode.Int16] = (left, right) => (short)left - (short)right;
            this.SubtractFunctions[(int)TypeCode.Int16, (int)TypeCode.Int32] = (left, right) => (short)left - (int)right;
            this.SubtractFunctions[(int)TypeCode.Int16, (int)TypeCode.Int64] = (left, right) => (short)left - (long)right;
            this.SubtractFunctions[(int)TypeCode.Int16, (int)TypeCode.Single] = (left, right) => (short)left - (float)right;
            this.SubtractFunctions[(int)TypeCode.Int16, (int)TypeCode.Double] = (left, right) => (short)left - (double)right;

            this.SubtractFunctions[(int)TypeCode.Int32, (int)TypeCode.Int16] = (left, right) => (int)left - (short)right;
            this.SubtractFunctions[(int)TypeCode.Int32, (int)TypeCode.Int32] = (left, right) => (int)left - (int)right;
            this.SubtractFunctions[(int)TypeCode.Int32, (int)TypeCode.Int64] = (left, right) => (int)left - (long)right;
            this.SubtractFunctions[(int)TypeCode.Int32, (int)TypeCode.Single] = (left, right) => (int)left - (float)right;
            this.SubtractFunctions[(int)TypeCode.Int32, (int)TypeCode.Double] = (left, right) => (int)left - (double)right;

            this.SubtractFunctions[(int)TypeCode.Int64, (int)TypeCode.Int16] = (left, right) => (long)left - (short)right;
            this.SubtractFunctions[(int)TypeCode.Int64, (int)TypeCode.Int32] = (left, right) => (long)left - (int)right;
            this.SubtractFunctions[(int)TypeCode.Int64, (int)TypeCode.Int64] = (left, right) => (long)left - (long)right;
            this.SubtractFunctions[(int)TypeCode.Int64, (int)TypeCode.Single] = (left, right) => (long)left - (float)right;
            this.SubtractFunctions[(int)TypeCode.Int64, (int)TypeCode.Double] = (left, right) => (long)left - (double)right;

            this.SubtractFunctions[(int)TypeCode.Single, (int)TypeCode.Int16] = (left, right) => (float)left - (short)right;
            this.SubtractFunctions[(int)TypeCode.Single, (int)TypeCode.Int32] = (left, right) => (float)left - (int)right;
            this.SubtractFunctions[(int)TypeCode.Single, (int)TypeCode.Int64] = (left, right) => (float)left - (long)right;
            this.SubtractFunctions[(int)TypeCode.Single, (int)TypeCode.Single] = (left, right) => (float)left - (float)right;
            this.SubtractFunctions[(int)TypeCode.Single, (int)TypeCode.Double] = (left, right) => (float)left - (double)right;

            this.SubtractFunctions[(int)TypeCode.Double, (int)TypeCode.Int16] = (left, right) => (double)left - (short)right;
            this.SubtractFunctions[(int)TypeCode.Double, (int)TypeCode.Int32] = (left, right) => (double)left - (int)right;
            this.SubtractFunctions[(int)TypeCode.Double, (int)TypeCode.Int64] = (left, right) => (double)left - (long)right;
            this.SubtractFunctions[(int)TypeCode.Double, (int)TypeCode.Single] = (left, right) => (double)left - (float)right;
            this.SubtractFunctions[(int)TypeCode.Double, (int)TypeCode.Double] = (left, right) => (double)left - (double)right;

            this.MultiplyFunctions[(int)TypeCode.Int16, (int)TypeCode.Int16] = (left, right) => (short)left * (short)right;
            this.MultiplyFunctions[(int)TypeCode.Int16, (int)TypeCode.Int32] = (left, right) => (short)left * (int)right;
            this.MultiplyFunctions[(int)TypeCode.Int16, (int)TypeCode.Int64] = (left, right) => (short)left * (long)right;
            this.MultiplyFunctions[(int)TypeCode.Int16, (int)TypeCode.Single] = (left, right) => (short)left * (float)right;
            this.MultiplyFunctions[(int)TypeCode.Int16, (int)TypeCode.Double] = (left, right) => (short)left * (double)right;

            this.MultiplyFunctions[(int)TypeCode.Int32, (int)TypeCode.Int16] = (left, right) => (int)left * (short)right;
            this.MultiplyFunctions[(int)TypeCode.Int32, (int)TypeCode.Int32] = (left, right) => (int)left * (int)right;
            this.MultiplyFunctions[(int)TypeCode.Int32, (int)TypeCode.Int64] = (left, right) => (int)left * (long)right;
            this.MultiplyFunctions[(int)TypeCode.Int32, (int)TypeCode.Single] = (left, right) => (int)left * (float)right;
            this.MultiplyFunctions[(int)TypeCode.Int32, (int)TypeCode.Double] = (left, right) => (int)left * (double)right;

            this.MultiplyFunctions[(int)TypeCode.Int64, (int)TypeCode.Int16] = (left, right) => (long)left * (short)right;
            this.MultiplyFunctions[(int)TypeCode.Int64, (int)TypeCode.Int32] = (left, right) => (long)left * (int)right;
            this.MultiplyFunctions[(int)TypeCode.Int64, (int)TypeCode.Int64] = (left, right) => (long)left * (long)right;
            this.MultiplyFunctions[(int)TypeCode.Int64, (int)TypeCode.Single] = (left, right) => (long)left * (float)right;
            this.MultiplyFunctions[(int)TypeCode.Int64, (int)TypeCode.Double] = (left, right) => (long)left * (double)right;

            this.MultiplyFunctions[(int)TypeCode.Single, (int)TypeCode.Int16] = (left, right) => (float)left * (short)right;
            this.MultiplyFunctions[(int)TypeCode.Single, (int)TypeCode.Int32] = (left, right) => (float)left * (int)right;
            this.MultiplyFunctions[(int)TypeCode.Single, (int)TypeCode.Int64] = (left, right) => (float)left * (long)right;
            this.MultiplyFunctions[(int)TypeCode.Single, (int)TypeCode.Single] = (left, right) => (float)left * (float)right;
            this.MultiplyFunctions[(int)TypeCode.Single, (int)TypeCode.Double] = (left, right) => (float)left * (double)right;

            this.MultiplyFunctions[(int)TypeCode.Double, (int)TypeCode.Int16] = (left, right) => (double)left * (short)right;
            this.MultiplyFunctions[(int)TypeCode.Double, (int)TypeCode.Int32] = (left, right) => (double)left * (int)right;
            this.MultiplyFunctions[(int)TypeCode.Double, (int)TypeCode.Int64] = (left, right) => (double)left * (long)right;
            this.MultiplyFunctions[(int)TypeCode.Double, (int)TypeCode.Single] = (left, right) => (double)left * (float)right;
            this.MultiplyFunctions[(int)TypeCode.Double, (int)TypeCode.Double] = (left, right) => (double)left * (double)right;

            this.DivideFunctions[(int)TypeCode.Int16, (int)TypeCode.Int16] = (left, right) => (short)left / (short)right;
            this.DivideFunctions[(int)TypeCode.Int16, (int)TypeCode.Int32] = (left, right) => (short)left / (int)right;
            this.DivideFunctions[(int)TypeCode.Int16, (int)TypeCode.Int64] = (left, right) => (short)left / (long)right;
            this.DivideFunctions[(int)TypeCode.Int16, (int)TypeCode.Single] = (left, right) => (short)left / (float)right;
            this.DivideFunctions[(int)TypeCode.Int16, (int)TypeCode.Double] = (left, right) => (short)left / (double)right;

            this.DivideFunctions[(int)TypeCode.Int32, (int)TypeCode.Int16] = (left, right) => (int)left / (short)right;
            this.DivideFunctions[(int)TypeCode.Int32, (int)TypeCode.Int32] = (left, right) => (int)left / (int)right;
            this.DivideFunctions[(int)TypeCode.Int32, (int)TypeCode.Int64] = (left, right) => (int)left / (long)right;
            this.DivideFunctions[(int)TypeCode.Int32, (int)TypeCode.Single] = (left, right) => (int)left / (float)right;
            this.DivideFunctions[(int)TypeCode.Int32, (int)TypeCode.Double] = (left, right) => (int)left / (double)right;

            this.DivideFunctions[(int)TypeCode.Int64, (int)TypeCode.Int16] = (left, right) => (long)left / (short)right;
            this.DivideFunctions[(int)TypeCode.Int64, (int)TypeCode.Int32] = (left, right) => (long)left / (int)right;
            this.DivideFunctions[(int)TypeCode.Int64, (int)TypeCode.Int64] = (left, right) => (long)left / (long)right;
            this.DivideFunctions[(int)TypeCode.Int64, (int)TypeCode.Single] = (left, right) => (long)left / (float)right;
            this.DivideFunctions[(int)TypeCode.Int64, (int)TypeCode.Double] = (left, right) => (long)left / (double)right;

            this.DivideFunctions[(int)TypeCode.Single, (int)TypeCode.Int16] = (left, right) => (float)left / (short)right;
            this.DivideFunctions[(int)TypeCode.Single, (int)TypeCode.Int32] = (left, right) => (float)left / (int)right;
            this.DivideFunctions[(int)TypeCode.Single, (int)TypeCode.Int64] = (left, right) => (float)left / (long)right;
            this.DivideFunctions[(int)TypeCode.Single, (int)TypeCode.Single] = (left, right) => (float)left / (float)right;
            this.DivideFunctions[(int)TypeCode.Single, (int)TypeCode.Double] = (left, right) => (float)left / (double)right;

            this.DivideFunctions[(int)TypeCode.Double, (int)TypeCode.Int16] = (left, right) => (double)left / (short)right;
            this.DivideFunctions[(int)TypeCode.Double, (int)TypeCode.Int32] = (left, right) => (double)left / (int)right;
            this.DivideFunctions[(int)TypeCode.Double, (int)TypeCode.Int64] = (left, right) => (double)left / (long)right;
            this.DivideFunctions[(int)TypeCode.Double, (int)TypeCode.Single] = (left, right) => (double)left / (float)right;
            this.DivideFunctions[(int)TypeCode.Double, (int)TypeCode.Double] = (left, right) => (double)left / (double)right;

            this.EqualFunctions[(int)TypeCode.Int16, (int)TypeCode.Int16] = (left, right) => (short)left == (short)right;
            this.EqualFunctions[(int)TypeCode.Int16, (int)TypeCode.Int32] = (left, right) => (short)left == (int)right;
            this.EqualFunctions[(int)TypeCode.Int16, (int)TypeCode.Int64] = (left, right) => (short)left == (long)right;
            this.EqualFunctions[(int)TypeCode.Int16, (int)TypeCode.Single] = (left, right) => (short)left == (float)right;
            this.EqualFunctions[(int)TypeCode.Int16, (int)TypeCode.Double] = (left, right) => (short)left == (double)right;

            this.EqualFunctions[(int)TypeCode.Int32, (int)TypeCode.Int16] = (left, right) => (int)left == (short)right;
            this.EqualFunctions[(int)TypeCode.Int32, (int)TypeCode.Int32] = (left, right) => (int)left == (int)right;
            this.EqualFunctions[(int)TypeCode.Int32, (int)TypeCode.Int64] = (left, right) => (int)left == (long)right;
            this.EqualFunctions[(int)TypeCode.Int32, (int)TypeCode.Single] = (left, right) => (int)left == (float)right;
            this.EqualFunctions[(int)TypeCode.Int32, (int)TypeCode.Double] = (left, right) => (int)left == (double)right;

            this.EqualFunctions[(int)TypeCode.Int64, (int)TypeCode.Int16] = (left, right) => (long)left == (short)right;
            this.EqualFunctions[(int)TypeCode.Int64, (int)TypeCode.Int32] = (left, right) => (long)left == (int)right;
            this.EqualFunctions[(int)TypeCode.Int64, (int)TypeCode.Int64] = (left, right) => (long)left == (long)right;
            this.EqualFunctions[(int)TypeCode.Int64, (int)TypeCode.Single] = (left, right) => (long)left == (float)right;
            this.EqualFunctions[(int)TypeCode.Int64, (int)TypeCode.Double] = (left, right) => (long)left == (double)right;

            this.EqualFunctions[(int)TypeCode.Single, (int)TypeCode.Int16] = (left, right) => (float)left == (short)right;
            this.EqualFunctions[(int)TypeCode.Single, (int)TypeCode.Int32] = (left, right) => (float)left == (int)right;
            this.EqualFunctions[(int)TypeCode.Single, (int)TypeCode.Int64] = (left, right) => (float)left == (long)right;
            this.EqualFunctions[(int)TypeCode.Single, (int)TypeCode.Single] = (left, right) => (float)left == (float)right;
            this.EqualFunctions[(int)TypeCode.Single, (int)TypeCode.Double] = (left, right) => (float)left == (double)right;

            this.EqualFunctions[(int)TypeCode.Double, (int)TypeCode.Int16] = (left, right) => (double)left == (short)right;
            this.EqualFunctions[(int)TypeCode.Double, (int)TypeCode.Int32] = (left, right) => (double)left == (int)right;
            this.EqualFunctions[(int)TypeCode.Double, (int)TypeCode.Int64] = (left, right) => (double)left == (long)right;
            this.EqualFunctions[(int)TypeCode.Double, (int)TypeCode.Single] = (left, right) => (double)left == (float)right;
            this.EqualFunctions[(int)TypeCode.Double, (int)TypeCode.Double] = (left, right) => (double)left == (double)right;

            this.NotEqualFunctions[(int)TypeCode.Int16, (int)TypeCode.Int16] = (left, right) => (short)left != (short)right;
            this.NotEqualFunctions[(int)TypeCode.Int16, (int)TypeCode.Int32] = (left, right) => (short)left != (int)right;
            this.NotEqualFunctions[(int)TypeCode.Int16, (int)TypeCode.Int64] = (left, right) => (short)left != (long)right;
            this.NotEqualFunctions[(int)TypeCode.Int16, (int)TypeCode.Single] = (left, right) => (short)left != (float)right;
            this.NotEqualFunctions[(int)TypeCode.Int16, (int)TypeCode.Double] = (left, right) => (short)left != (double)right;

            this.NotEqualFunctions[(int)TypeCode.Int32, (int)TypeCode.Int16] = (left, right) => (int)left != (short)right;
            this.NotEqualFunctions[(int)TypeCode.Int32, (int)TypeCode.Int32] = (left, right) => (int)left != (int)right;
            this.NotEqualFunctions[(int)TypeCode.Int32, (int)TypeCode.Int64] = (left, right) => (int)left != (long)right;
            this.NotEqualFunctions[(int)TypeCode.Int32, (int)TypeCode.Single] = (left, right) => (int)left != (float)right;
            this.NotEqualFunctions[(int)TypeCode.Int32, (int)TypeCode.Double] = (left, right) => (int)left != (double)right;

            this.NotEqualFunctions[(int)TypeCode.Int64, (int)TypeCode.Int16] = (left, right) => (long)left != (short)right;
            this.NotEqualFunctions[(int)TypeCode.Int64, (int)TypeCode.Int32] = (left, right) => (long)left != (int)right;
            this.NotEqualFunctions[(int)TypeCode.Int64, (int)TypeCode.Int64] = (left, right) => (long)left != (long)right;
            this.NotEqualFunctions[(int)TypeCode.Int64, (int)TypeCode.Single] = (left, right) => (long)left != (float)right;
            this.NotEqualFunctions[(int)TypeCode.Int64, (int)TypeCode.Double] = (left, right) => (long)left != (double)right;

            this.NotEqualFunctions[(int)TypeCode.Single, (int)TypeCode.Int16] = (left, right) => (float)left != (short)right;
            this.NotEqualFunctions[(int)TypeCode.Single, (int)TypeCode.Int32] = (left, right) => (float)left != (int)right;
            this.NotEqualFunctions[(int)TypeCode.Single, (int)TypeCode.Int64] = (left, right) => (float)left != (long)right;
            this.NotEqualFunctions[(int)TypeCode.Single, (int)TypeCode.Single] = (left, right) => (float)left != (float)right;
            this.NotEqualFunctions[(int)TypeCode.Single, (int)TypeCode.Double] = (left, right) => (float)left != (double)right;

            this.NotEqualFunctions[(int)TypeCode.Double, (int)TypeCode.Int16] = (left, right) => (double)left != (short)right;
            this.NotEqualFunctions[(int)TypeCode.Double, (int)TypeCode.Int32] = (left, right) => (double)left != (int)right;
            this.NotEqualFunctions[(int)TypeCode.Double, (int)TypeCode.Int64] = (left, right) => (double)left != (long)right;
            this.NotEqualFunctions[(int)TypeCode.Double, (int)TypeCode.Single] = (left, right) => (double)left != (float)right;
            this.NotEqualFunctions[(int)TypeCode.Double, (int)TypeCode.Double] = (left, right) => (double)left != (double)right;

            this.GreaterFunctions[(int)TypeCode.Int16, (int)TypeCode.Int16] = (left, right) => (short)left > (short)right;
            this.GreaterFunctions[(int)TypeCode.Int16, (int)TypeCode.Int32] = (left, right) => (short)left > (int)right;
            this.GreaterFunctions[(int)TypeCode.Int16, (int)TypeCode.Int64] = (left, right) => (short)left > (long)right;
            this.GreaterFunctions[(int)TypeCode.Int16, (int)TypeCode.Single] = (left, right) => (short)left > (float)right;
            this.GreaterFunctions[(int)TypeCode.Int16, (int)TypeCode.Double] = (left, right) => (short)left > (double)right;

            this.GreaterFunctions[(int)TypeCode.Int32, (int)TypeCode.Int16] = (left, right) => (int)left > (short)right;
            this.GreaterFunctions[(int)TypeCode.Int32, (int)TypeCode.Int32] = (left, right) => (int)left > (int)right;
            this.GreaterFunctions[(int)TypeCode.Int32, (int)TypeCode.Int64] = (left, right) => (int)left > (long)right;
            this.GreaterFunctions[(int)TypeCode.Int32, (int)TypeCode.Single] = (left, right) => (int)left > (float)right;
            this.GreaterFunctions[(int)TypeCode.Int32, (int)TypeCode.Double] = (left, right) => (int)left > (double)right;

            this.GreaterFunctions[(int)TypeCode.Int64, (int)TypeCode.Int16] = (left, right) => (long)left > (short)right;
            this.GreaterFunctions[(int)TypeCode.Int64, (int)TypeCode.Int32] = (left, right) => (long)left > (int)right;
            this.GreaterFunctions[(int)TypeCode.Int64, (int)TypeCode.Int64] = (left, right) => (long)left > (long)right;
            this.GreaterFunctions[(int)TypeCode.Int64, (int)TypeCode.Single] = (left, right) => (long)left > (float)right;
            this.GreaterFunctions[(int)TypeCode.Int64, (int)TypeCode.Double] = (left, right) => (long)left > (double)right;

            this.GreaterFunctions[(int)TypeCode.Single, (int)TypeCode.Int16] = (left, right) => (float)left > (short)right;
            this.GreaterFunctions[(int)TypeCode.Single, (int)TypeCode.Int32] = (left, right) => (float)left > (int)right;
            this.GreaterFunctions[(int)TypeCode.Single, (int)TypeCode.Int64] = (left, right) => (float)left > (long)right;
            this.GreaterFunctions[(int)TypeCode.Single, (int)TypeCode.Single] = (left, right) => (float)left > (float)right;
            this.GreaterFunctions[(int)TypeCode.Single, (int)TypeCode.Double] = (left, right) => (float)left > (double)right;

            this.GreaterFunctions[(int)TypeCode.Double, (int)TypeCode.Int16] = (left, right) => (double)left > (short)right;
            this.GreaterFunctions[(int)TypeCode.Double, (int)TypeCode.Int32] = (left, right) => (double)left > (int)right;
            this.GreaterFunctions[(int)TypeCode.Double, (int)TypeCode.Int64] = (left, right) => (double)left > (long)right;
            this.GreaterFunctions[(int)TypeCode.Double, (int)TypeCode.Single] = (left, right) => (double)left > (float)right;
            this.GreaterFunctions[(int)TypeCode.Double, (int)TypeCode.Double] = (left, right) => (double)left > (double)right;

            this.GreaterEqualFunctions[(int)TypeCode.Int16, (int)TypeCode.Int16] = (left, right) => (short)left >= (short)right;
            this.GreaterEqualFunctions[(int)TypeCode.Int16, (int)TypeCode.Int32] = (left, right) => (short)left >= (int)right;
            this.GreaterEqualFunctions[(int)TypeCode.Int16, (int)TypeCode.Int64] = (left, right) => (short)left >= (long)right;
            this.GreaterEqualFunctions[(int)TypeCode.Int16, (int)TypeCode.Single] = (left, right) => (short)left >= (float)right;
            this.GreaterEqualFunctions[(int)TypeCode.Int16, (int)TypeCode.Double] = (left, right) => (short)left >= (double)right;

            this.GreaterEqualFunctions[(int)TypeCode.Int32, (int)TypeCode.Int16] = (left, right) => (int)left >= (short)right;
            this.GreaterEqualFunctions[(int)TypeCode.Int32, (int)TypeCode.Int32] = (left, right) => (int)left >= (int)right;
            this.GreaterEqualFunctions[(int)TypeCode.Int32, (int)TypeCode.Int64] = (left, right) => (int)left >= (long)right;
            this.GreaterEqualFunctions[(int)TypeCode.Int32, (int)TypeCode.Single] = (left, right) => (int)left >= (float)right;
            this.GreaterEqualFunctions[(int)TypeCode.Int32, (int)TypeCode.Double] = (left, right) => (int)left >= (double)right;

            this.GreaterEqualFunctions[(int)TypeCode.Int64, (int)TypeCode.Int16] = (left, right) => (long)left >= (short)right;
            this.GreaterEqualFunctions[(int)TypeCode.Int64, (int)TypeCode.Int32] = (left, right) => (long)left >= (int)right;
            this.GreaterEqualFunctions[(int)TypeCode.Int64, (int)TypeCode.Int64] = (left, right) => (long)left >= (long)right;
            this.GreaterEqualFunctions[(int)TypeCode.Int64, (int)TypeCode.Single] = (left, right) => (long)left >= (float)right;
            this.GreaterEqualFunctions[(int)TypeCode.Int64, (int)TypeCode.Double] = (left, right) => (long)left >= (double)right;

            this.GreaterEqualFunctions[(int)TypeCode.Single, (int)TypeCode.Int16] = (left, right) => (float)left >= (short)right;
            this.GreaterEqualFunctions[(int)TypeCode.Single, (int)TypeCode.Int32] = (left, right) => (float)left >= (int)right;
            this.GreaterEqualFunctions[(int)TypeCode.Single, (int)TypeCode.Int64] = (left, right) => (float)left >= (long)right;
            this.GreaterEqualFunctions[(int)TypeCode.Single, (int)TypeCode.Single] = (left, right) => (float)left >= (float)right;
            this.GreaterEqualFunctions[(int)TypeCode.Single, (int)TypeCode.Double] = (left, right) => (float)left >= (double)right;

            this.GreaterEqualFunctions[(int)TypeCode.Double, (int)TypeCode.Int16] = (left, right) => (double)left >= (short)right;
            this.GreaterEqualFunctions[(int)TypeCode.Double, (int)TypeCode.Int32] = (left, right) => (double)left >= (int)right;
            this.GreaterEqualFunctions[(int)TypeCode.Double, (int)TypeCode.Int64] = (left, right) => (double)left >= (long)right;
            this.GreaterEqualFunctions[(int)TypeCode.Double, (int)TypeCode.Single] = (left, right) => (double)left >= (float)right;
            this.GreaterEqualFunctions[(int)TypeCode.Double, (int)TypeCode.Double] = (left, right) => (double)left >= (double)right;

            this.LessFunctions[(int)TypeCode.Int16, (int)TypeCode.Int16] = (left, right) => (short)left < (short)right;
            this.LessFunctions[(int)TypeCode.Int16, (int)TypeCode.Int32] = (left, right) => (short)left < (int)right;
            this.LessFunctions[(int)TypeCode.Int16, (int)TypeCode.Int64] = (left, right) => (short)left < (long)right;
            this.LessFunctions[(int)TypeCode.Int16, (int)TypeCode.Single] = (left, right) => (short)left < (float)right;
            this.LessFunctions[(int)TypeCode.Int16, (int)TypeCode.Double] = (left, right) => (short)left < (double)right;

            this.LessFunctions[(int)TypeCode.Int32, (int)TypeCode.Int16] = (left, right) => (int)left < (short)right;
            this.LessFunctions[(int)TypeCode.Int32, (int)TypeCode.Int32] = (left, right) => (int)left < (int)right;
            this.LessFunctions[(int)TypeCode.Int32, (int)TypeCode.Int64] = (left, right) => (int)left < (long)right;
            this.LessFunctions[(int)TypeCode.Int32, (int)TypeCode.Single] = (left, right) => (int)left < (float)right;
            this.LessFunctions[(int)TypeCode.Int32, (int)TypeCode.Double] = (left, right) => (int)left < (double)right;

            this.LessFunctions[(int)TypeCode.Int64, (int)TypeCode.Int16] = (left, right) => (long)left < (short)right;
            this.LessFunctions[(int)TypeCode.Int64, (int)TypeCode.Int32] = (left, right) => (long)left < (int)right;
            this.LessFunctions[(int)TypeCode.Int64, (int)TypeCode.Int64] = (left, right) => (long)left < (long)right;
            this.LessFunctions[(int)TypeCode.Int64, (int)TypeCode.Single] = (left, right) => (long)left < (float)right;
            this.LessFunctions[(int)TypeCode.Int64, (int)TypeCode.Double] = (left, right) => (long)left < (double)right;

            this.LessFunctions[(int)TypeCode.Single, (int)TypeCode.Int16] = (left, right) => (float)left < (short)right;
            this.LessFunctions[(int)TypeCode.Single, (int)TypeCode.Int32] = (left, right) => (float)left < (int)right;
            this.LessFunctions[(int)TypeCode.Single, (int)TypeCode.Int64] = (left, right) => (float)left < (long)right;
            this.LessFunctions[(int)TypeCode.Single, (int)TypeCode.Single] = (left, right) => (float)left < (float)right;
            this.LessFunctions[(int)TypeCode.Single, (int)TypeCode.Double] = (left, right) => (float)left < (double)right;

            this.LessFunctions[(int)TypeCode.Double, (int)TypeCode.Int16] = (left, right) => (double)left < (short)right;
            this.LessFunctions[(int)TypeCode.Double, (int)TypeCode.Int32] = (left, right) => (double)left < (int)right;
            this.LessFunctions[(int)TypeCode.Double, (int)TypeCode.Int64] = (left, right) => (double)left < (long)right;
            this.LessFunctions[(int)TypeCode.Double, (int)TypeCode.Single] = (left, right) => (double)left < (float)right;
            this.LessFunctions[(int)TypeCode.Double, (int)TypeCode.Double] = (left, right) => (double)left < (double)right;

            this.LessEqualFunctions[(int)TypeCode.Int16, (int)TypeCode.Int16] = (left, right) => (short)left <= (short)right;
            this.LessEqualFunctions[(int)TypeCode.Int16, (int)TypeCode.Int32] = (left, right) => (short)left <= (int)right;
            this.LessEqualFunctions[(int)TypeCode.Int16, (int)TypeCode.Int64] = (left, right) => (short)left <= (long)right;
            this.LessEqualFunctions[(int)TypeCode.Int16, (int)TypeCode.Single] = (left, right) => (short)left <= (float)right;
            this.LessEqualFunctions[(int)TypeCode.Int16, (int)TypeCode.Double] = (left, right) => (short)left <= (double)right;

            this.LessEqualFunctions[(int)TypeCode.Int32, (int)TypeCode.Int16] = (left, right) => (int)left <= (short)right;
            this.LessEqualFunctions[(int)TypeCode.Int32, (int)TypeCode.Int32] = (left, right) => (int)left <= (int)right;
            this.LessEqualFunctions[(int)TypeCode.Int32, (int)TypeCode.Int64] = (left, right) => (int)left <= (long)right;
            this.LessEqualFunctions[(int)TypeCode.Int32, (int)TypeCode.Single] = (left, right) => (int)left <= (float)right;
            this.LessEqualFunctions[(int)TypeCode.Int32, (int)TypeCode.Double] = (left, right) => (int)left <= (double)right;

            this.LessEqualFunctions[(int)TypeCode.Int64, (int)TypeCode.Int16] = (left, right) => (long)left <= (short)right;
            this.LessEqualFunctions[(int)TypeCode.Int64, (int)TypeCode.Int32] = (left, right) => (long)left <= (int)right;
            this.LessEqualFunctions[(int)TypeCode.Int64, (int)TypeCode.Int64] = (left, right) => (long)left <= (long)right;
            this.LessEqualFunctions[(int)TypeCode.Int64, (int)TypeCode.Single] = (left, right) => (long)left <= (float)right;
            this.LessEqualFunctions[(int)TypeCode.Int64, (int)TypeCode.Double] = (left, right) => (long)left <= (double)right;

            this.LessEqualFunctions[(int)TypeCode.Single, (int)TypeCode.Int16] = (left, right) => (float)left <= (short)right;
            this.LessEqualFunctions[(int)TypeCode.Single, (int)TypeCode.Int32] = (left, right) => (float)left <= (int)right;
            this.LessEqualFunctions[(int)TypeCode.Single, (int)TypeCode.Int64] = (left, right) => (float)left <= (long)right;
            this.LessEqualFunctions[(int)TypeCode.Single, (int)TypeCode.Single] = (left, right) => (float)left <= (float)right;
            this.LessEqualFunctions[(int)TypeCode.Single, (int)TypeCode.Double] = (left, right) => (float)left <= (double)right;

            this.LessEqualFunctions[(int)TypeCode.Double, (int)TypeCode.Int16] = (left, right) => (double)left <= (short)right;
            this.LessEqualFunctions[(int)TypeCode.Double, (int)TypeCode.Int32] = (left, right) => (double)left <= (int)right;
            this.LessEqualFunctions[(int)TypeCode.Double, (int)TypeCode.Int64] = (left, right) => (double)left <= (long)right;
            this.LessEqualFunctions[(int)TypeCode.Double, (int)TypeCode.Single] = (left, right) => (double)left <= (float)right;
            this.LessEqualFunctions[(int)TypeCode.Double, (int)TypeCode.Double] = (left, right) => (double)left <= (double)right;

        }

        public object AddObject(object left, object right)
        {
            if (left is IConvertible && right is IConvertible)
            {
                return this.AddFunctions[(int)((IConvertible)left).GetTypeCode(), (int)((IConvertible)right).GetTypeCode()](left, right);
            }

            throw new NotImplementedException();
        }

        public object SubtractObject(object left, object right)
        {
            if (left is IConvertible && right is IConvertible)
            {
                return this.SubtractFunctions[(int)((IConvertible)left).GetTypeCode(), (int)((IConvertible)right).GetTypeCode()](left, right);
            }

            throw new NotImplementedException();
        }

        public object MultiplyObject(object left, object right)
        {
            if (left is IConvertible && right is IConvertible)
            {
                return this.MultiplyFunctions[(int)((IConvertible)left).GetTypeCode(), (int)((IConvertible)right).GetTypeCode()](left, right);
            }

            throw new NotImplementedException();
        }

        public object DivideObject(object left, object right)
        {
            if (left is IConvertible && right is IConvertible)
            {
                return this.DivideFunctions[(int)((IConvertible)left).GetTypeCode(), (int)((IConvertible)right).GetTypeCode()](left, right);
            }

            throw new NotImplementedException();
        }

        public object EqualObject(object left, object right)
        {
            if (left is IConvertible && right is IConvertible)
            {
                return this.EqualFunctions[(int)((IConvertible)left).GetTypeCode(), (int)((IConvertible)right).GetTypeCode()](left, right);
            }

            throw new NotImplementedException();
        }

        public object NotEqualObject(object left, object right)
        {
            if (left is IConvertible && right is IConvertible)
            {
                return this.NotEqualFunctions[(int)((IConvertible)left).GetTypeCode(), (int)((IConvertible)right).GetTypeCode()](left, right);
            }

            throw new NotImplementedException();
        }

        public object GreaterObject(object left, object right)
        {
            if (left is IConvertible && right is IConvertible)
            {
                return this.GreaterFunctions[(int)((IConvertible)left).GetTypeCode(), (int)((IConvertible)right).GetTypeCode()](left, right);
            }

            throw new NotImplementedException();
        }

        public object GreaterEqualObject(object left, object right)
        {
            if (left is IConvertible && right is IConvertible)
            {
                return this.GreaterEqualFunctions[(int)((IConvertible)left).GetTypeCode(), (int)((IConvertible)right).GetTypeCode()](left, right);
            }

            throw new NotImplementedException();
        }

        public object LessObject(object left, object right)
        {
            if (left is IConvertible && right is IConvertible)
            {
                return this.LessFunctions[(int)((IConvertible)left).GetTypeCode(), (int)((IConvertible)right).GetTypeCode()](left, right);
            }

            throw new NotImplementedException();
        }

        public object LessEqualObject(object left, object right)
        {
            if (left is IConvertible && right is IConvertible)
            {
                return this.LessEqualFunctions[(int)((IConvertible)left).GetTypeCode(), (int)((IConvertible)right).GetTypeCode()](left, right);
            }

            throw new NotImplementedException();
        }
    }
}
