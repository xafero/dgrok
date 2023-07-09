using System.Collections.Generic;
using DGrok.Framework;

namespace DGrok.DelphiNodes
{
	public partial class PropertyDataNode : NonterminalNode
	{
		private ListNode<Token> _nameNode;
		private AstNode _valueNode;

		public PropertyDataNode(ListNode<Token> name, AstNode value)
		{
			_nameNode = name;
			_valueNode = value;
		}

		public ListNode<Token> NameNode
		{
			get { return _nameNode; }
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
				if (ValueNode != null)
					yield return ValueNode;
			}
		}

		public override IEnumerable<KeyValuePair<string, AstNode>> Properties
		{
			get
			{
				yield return new KeyValuePair<string, AstNode>("NameNode", NameNode);
				yield return new KeyValuePair<string, AstNode>("ValueNode", ValueNode);
			}
		}

		public override void Accept(Visitor visitor)
		{
			visitor.VisitPropertyDataNode(this);
		}
	}
}