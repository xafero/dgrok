using System.Collections.Generic;
using DGrok.Framework;

namespace DGrok.DelphiNodes
{
	public partial class PropertyDataNode : NonterminalNode
	{
		private ListNode<Token> _nameNode;
		private Token _equalNode;
		private AstNode _valueNode;

		public PropertyDataNode(ListNode<Token> name, Token equalSign, AstNode value)
		{
			_nameNode = name;
			_equalNode = equalSign;
			_valueNode = value;
		}

		public ListNode<Token> NameNode
		{
			get { return _nameNode; }
		}

		public Token EqualNode
		{
			get { return _equalNode; }
		}

		public AstNode ValueNode
		{
			get { return _valueNode; }
		}

		public override IEnumerable<AstNode> ChildNodes
		{
			get
			{
				if (NameNode != null)
					yield return NameNode;
				if (EqualNode != null)
					yield return EqualNode;
				if (ValueNode != null)
					yield return ValueNode;
			}
		}

		public override IEnumerable<KeyValuePair<string, AstNode>> Properties
		{
			get
			{
				yield return new KeyValuePair<string, AstNode>("NameNode", NameNode);
				yield return new KeyValuePair<string, AstNode>("EqualNode", EqualNode);
				yield return new KeyValuePair<string, AstNode>("ValueNode", ValueNode);
			}
		}

		public override void Accept(Visitor visitor)
		{
			visitor.VisitPropertyDataNode(this);
		}
	}
}