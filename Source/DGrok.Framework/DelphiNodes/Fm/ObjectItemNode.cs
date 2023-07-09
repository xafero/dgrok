using System.Collections.Generic;
using DGrok.Framework;

namespace DGrok.DelphiNodes
{
	public partial class ObjectItemNode : NonterminalNode
	{
		private Token _objectTypeNode;
		private ListNode<AstNode> _properties;
		private Token _endNode;

		public ObjectItemNode(Token type, ListNode<AstNode> properties, Token theEnd)
		{
			_objectTypeNode = type;
			_properties = properties;
			_endNode = theEnd;
		}

		public Token ObjectTypeNode
		{
			get { return _objectTypeNode; }
		}

		public ListNode<AstNode> PropertiesNode
		{
			get { return _properties; }
		}

		public Token EndNode
		{
			get { return _endNode; }
		}

		public override IEnumerable<AstNode> ChildNodes
		{
			get
			{
				if (ObjectTypeNode != null)
					yield return ObjectTypeNode;
				if (PropertiesNode != null)
					yield return PropertiesNode;
				if (EndNode != null)
					yield return EndNode;
			}
		}

		public override IEnumerable<KeyValuePair<string, AstNode>> Properties
		{
			get
			{
				yield return new KeyValuePair<string, AstNode>("TypeNode", ObjectTypeNode);
				yield return new KeyValuePair<string, AstNode>("Properties", PropertiesNode);
				yield return new KeyValuePair<string, AstNode>("EndNode", EndNode);
			}
		}

		public override void Accept(Visitor visitor)
		{
			visitor.VisitObjectItemNode(this);
		}
	}
}