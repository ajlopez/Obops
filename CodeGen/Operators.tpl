namespace Obops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Operators
    {
<#
    for each BinaryOperator in Model.BinaryOperators
#>
        private static Func<object, object, object>[,]${BinaryOperator.Name}Functions = new Func<object, object, object>[20, 20];
<#
    end for
#>

        static Operators()
        {
<#
    for each BinaryOperator in Model.BinaryOperators
        for each Type1 in Model.NumericTypes
            for each Type2 in Model.NumericTypes
#>
            ${BinaryOperator.Name}Functions[(int)TypeCode.${Type1.TypeName}, (int)TypeCode.${Type2.TypeName}] = (left, right) => (${Type1.CSharpName})left ${BinaryOperator.Symbol} (${Type2.CSharpName})right;
<#
            end for
            PrintLine ""
        end for
    end for
#>
        }

<#
    for each BinaryOperator in Model.BinaryOperators
#>
        public static object ${BinaryOperator.Name}Object(object left, object right)
        {
            if (left is IConvertible && right is IConvertible)
            {
                return ${BinaryOperator.Name}Functions[(int)((IConvertible)left).GetTypeCode(), (int)((IConvertible)right).GetTypeCode()](left, right);
            }

            throw new NotImplementedException();
        }

<#
    end for
#>
    }
}
