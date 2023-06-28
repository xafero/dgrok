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
}