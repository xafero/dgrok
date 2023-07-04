using DGrok.Framework;

namespace DGrok.DelphiNodes
{
	public interface IHasTypeAndName
	{
		ListNode<DelimitedItemNode<Token>> NameListNode { get; }
		AstNode TypeNode { get; }
	}

	public interface IHasTypeNameAndVal : IHasTypeAndName
	{
		AstNode ValueNode { get; }
	}

	public interface IMethodLike
	{
		Token MethodTypeNode { get; }
		AstNode ReturnTypeNode { get; }
		ListNode<DelimitedItemNode<ParameterNode>> ParameterListNode { get; }
	}
}