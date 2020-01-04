using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZoddProductions.ZoddLibraries.BasicMath;

namespace BasicMathTests
{
    [TestFixture]
    public class OperationTests
    {
        [TestCase(1, 1, ExpectedResult = 2)]
        [TestCase(1, 2, ExpectedResult = 3)]
        [TestCase(1, -1, ExpectedResult = 0)]
        [TestCase(5, 0, ExpectedResult = 5)]
        [TestCase(-5, -5, ExpectedResult = -10)]
        public int AdditionTests(int value1, int value2)
        {
            return Operation.Addition(value1, value2);
        }
    }
}
