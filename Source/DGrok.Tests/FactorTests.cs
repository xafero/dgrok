// Copyright (c) 2007-2014 Joe White
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using DGrok.Framework;
using NUnit.Framework;

namespace DGrok.Tests
{
    [TestFixture]
    public class FactorTests : ParserTestCase
    {
        protected override RuleType RuleType
        {
            get { return RuleType.Factor; }
        }

        [Test]
        public void Particle()
        {
            Assert.That("42", ParsesAs("Number |42|"));
        }
        [Test]
        public void UnaryNot()
        {
            Assert.That("not not 42", ParsesAs(
                "UnaryOperationNode",
                "  OperatorNode: NotKeyword |not|",
                "  OperandNode: UnaryOperationNode",
                "    OperatorNode: NotKeyword |not|",
                "    OperandNode: Number |42|"));
        }

        [Test, Ignore("TODO Wanted behaviour is unknown!")]
        public void NotAloneDoesNotParse()
        {
            AssertDoesNotParse("not");
        }

        [Test]
        public void DotOperator()
        {
            Assert.That("Foo.Bar", ParsesAs(
                "BinaryOperationNode",
                "  LeftNode: Identifier |Foo|",
                "  OperatorNode: Dot |.|",
                "  RightNode: Identifier |Bar|"));
        }
    }
}
