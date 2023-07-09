using System.Collections.Generic;
using DGrok.Framework;

namespace DGrok.DelphiNodes
{
	public partial class ObjectNode : NonterminalNode
	{
		private Token _objectKeywordNode;
		private Token _objectNameNode;
		private Token _colonNode;
		private Token _objectTypeNode;
		private ListNode<AstNode> _properties;
		private Token _endNode;

		public ObjectNode(Token theObject, Token name, Token theColon,
			Token type, ListNode<AstNode> properties, Token theEnd)
		{
			_objectKeywordNode = theObject;
			_objectNameNode = name;
			_colonNode = theColon;
			_objectTypeNode = type;
			_properties = properties;
			_endNode = theEnd;
		}

		public Token ObjectKeywordNode
		{
			get { return _objectKeywordNode; }
		}

		public Token ObjectNameNode
		{
			get { return _objectNameNode; }
		}

		public Token TheColonNode
		{
			get { return _colonNode; }
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
				if (ObjectKeywordNode != null)
					yield return ObjectKeywordNode;
				if (ObjectNameNode != null)
					yield return ObjectNameNode;
				if (TheColonNode != null)
					yield return TheColonNode;
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
				yield return new KeyValuePair<string, AstNode>("ObjectKeywordNode", ObjectKeywordNode);
				yield return new KeyValuePair<string, AstNode>("ObjectNameNode", ObjectNameNode);
				yield return new KeyValuePair<string, AstNode>("ColonNode", TheColonNode);
				yield return new KeyValuePair<string, AstNode>("TypeNode", ObjectTypeNode);
				yield return new KeyValuePair<string, AstNode>("Properties", PropertiesNode);
				yield return new KeyValuePair<string, AstNode>("EndNode", EndNode);
			}
		}

		public override void Accept(Visitor visitor)
		{
			visitor.VisitObjectNode(this);
		}
	}
}