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
    public class InterfaceSectionTests : ParserTestCase
    {
        protected override RuleType RuleType
        {
            get { return RuleType.InterfaceSection; }
        }

        [Test]
        public void EmptyInterfaceSection()
        {
            Assert.That("interface", ParsesAs(
                "UnitSectionNode",
                "  HeaderKeywordNode: InterfaceKeyword |interface|",
                "  UsesClauseNode: (none)",
                "  ContentListNode: ListNode"));
        }
        [Test]
        public void Uses()
        {
            Assert.That("interface uses Foo;", ParsesAs(
                "UnitSectionNode",
                "  HeaderKeywordNode: InterfaceKeyword |interface|",
                "  UsesClauseNode: UsesClauseNode",
                "    UsesKeywordNode: UsesKeyword |uses|",
                "    UnitListNode: ListNode",
                "      Items[0]: DelimitedItemNode",
                "        ItemNode: UsedUnitNode",
                "          NameNode: Identifier |Foo|",
                "          InKeywordNode: (none)",
                "          FileNameNode: (none)",
                "        DelimiterNode: (none)",
                "    SemicolonNode: Semicolon |;|",
                "  ContentListNode: ListNode"));
        }
        [Test]
        public void WithContents()
        {
            Assert.That("interface resourcestring Foo = 'Bar';", ParsesAs(
                "UnitSectionNode",
                "  HeaderKeywordNode: InterfaceKeyword |interface|",
                "  UsesClauseNode: (none)",
                "  ContentListNode: ListNode",
                "    Items[0]: ConstSectionNode",
                "      ConstKeywordNode: ResourceStringKeyword |resourcestring|",
                "      ConstListNode: ListNode",
                "        Items[0]: ConstantDeclNode",
                "          NameNode: Identifier |Foo|",
                "          ColonNode: (none)",
                "          TypeNode: (none)",
                "          EqualSignNode: EqualSign |=|",
                "          ValueNode: StringLiteral |'Bar'|",
                "          PortabilityDirectiveListNode: ListNode",
                "          SemicolonNode: Semicolon |;|"));
        }
    }
}
