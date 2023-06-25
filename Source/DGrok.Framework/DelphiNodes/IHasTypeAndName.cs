using DGrok.Framework;

namespace DGrok.DelphiNodes
{
    public interface IHasTypeAndName
    {
        ListNode<DelimitedItemNode<Token>> NameListNode { get; }
        AstNode TypeNode { get; }
    }
}