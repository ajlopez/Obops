namespace Obops.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class OperatorsTests
    {
        private Operators operators;
        
        [TestInitialize]
        public void Setup()
        {
            this.operators = new Operators();
        }
        
<#
    for each BinaryOperator in Model.BinaryOperators
        for each Type1 in Model.NumericTypes
            for each Type2 in Model.NumericTypes
#>
        [TestMethod]
        public void ${BinaryOperator.Name}${Type1.Name}${Type2.Name}()
        {
<#
    for each value1 in Type1.Values
        for each value2 in Type2.Values
#>
            Assert.AreEqual((${Type1.CSharpName})${value1} ${BinaryOperator.Symbol} (${Type2.CSharpName})${value2}, this.operators.${BinaryOperator.Name}Object((${Type1.CSharpName})${value1}, (${Type2.CSharpName})${value2}));
<#
        end for
    end for
#>
        }
        
<#
            end for
        end for
    end for
#>
    }
}
