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
using System;
using DGrok.DelphiNodes;
using DGrok.Framework;
using NUnit.Framework;

namespace DGrok.Tests
{
    [TestFixture]
    public class ParserTests
    {
        private Parser _parser;

        [SetUp]
        public void SetUp()
        {
            _parser = Parser.FromText("Foo.Bar.Baz", "test.pas",
                CompilerDefines.CreateEmpty(), new MemoryFileLoader());
        }

        [Test]
        public void ParseRuleSetsParentReferences()
        {
            BinaryOperationNode top = (BinaryOperationNode) _parser.ParseRule(RuleType.Expression);
            Assert.That(top.LeftNode.ParentNode, Is.SameAs(top), "Top.Left");
            Assert.That(top.OperatorNode.ParentNode, Is.SameAs(top), "Top.Operator");
            Assert.That(top.RightNode.ParentNode, Is.SameAs(top), "Top.Right");
            BinaryOperationNode left = (BinaryOperationNode) top.LeftNode;
            Assert.That(left.LeftNode.ParentNode, Is.SameAs(left), "Left.Left");
            Assert.That(left.OperatorNode.ParentNode, Is.SameAs(left), "Left.Operator");
            Assert.That(left.RightNode.ParentNode, Is.SameAs(left), "Left.Right");
        }

        [Test]
        public void CanParseRuleThrowsOnUnrecognizedRule()
        {
            Assert.Throws<IndexOutOfRangeException>(delegate
            {
                _parser.CanParseRule((RuleType)999);
            });
        }

        [Test]
        public void ParseRuleThrowsOnUnrecognizedRule()
        {
            Assert.Throws<IndexOutOfRangeException>(delegate
            {
                _parser.ParseRule((RuleType)999);
            });
        }
    }
}
