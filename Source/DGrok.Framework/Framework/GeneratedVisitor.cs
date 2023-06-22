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
// Autogenerated file - do not edit

using DGrok.DelphiNodes;

namespace DGrok.Framework {
	public partial class Visitor {
		public virtual void VisitArrayTypeNode(ArrayTypeNode node) {
			Visit(node.ArrayKeywordNode);
			Visit(node.OpenBracketNode);
			Visit(node.IndexListNode);
			Visit(node.CloseBracketNode);
			Visit(node.OfKeywordNode);
			Visit(node.TypeNode);
		}
		public virtual void VisitAssemblerStatementNode(AssemblerStatementNode node) {
			Visit(node.AsmKeywordNode);
			Visit(node.EndKeywordNode);
		}
		public virtual void VisitAttributeNode(AttributeNode node) {
			Visit(node.OpenBracketNode);
			Visit(node.ScopeNode);
			Visit(node.ColonNode);
			Visit(node.ValueNode);
			Visit(node.CloseBracketNode);
		}
		public virtual void VisitBinaryOperationNode(BinaryOperationNode node) {
			Visit(node.LeftNode);
			Visit(node.OperatorNode);
			Visit(node.RightNode);
		}
		public virtual void VisitBlockNode(BlockNode node) {
			Visit(node.BeginKeywordNode);
			Visit(node.StatementListNode);
			Visit(node.EndKeywordNode);
		}
		public virtual void VisitCaseSelectorNode(CaseSelectorNode node) {
			Visit(node.ValueListNode);
			Visit(node.ColonNode);
			Visit(node.StatementNode);
			Visit(node.SemicolonNode);
		}
		public virtual void VisitCaseStatementNode(CaseStatementNode node) {
			Visit(node.CaseKeywordNode);
			Visit(node.ExpressionNode);
			Visit(node.OfKeywordNode);
			Visit(node.SelectorListNode);
			Visit(node.ElseKeywordNode);
			Visit(node.ElseStatementListNode);
			Visit(node.EndKeywordNode);
		}
		public virtual void VisitClassOfNode(ClassOfNode node) {
			Visit(node.ClassKeywordNode);
			Visit(node.OfKeywordNode);
			Visit(node.TypeNode);
		}
		public virtual void VisitClassTypeNode(ClassTypeNode node) {
			Visit(node.ClassKeywordNode);
			Visit(node.DispositionNode);
			Visit(node.OpenParenthesisNode);
			Visit(node.InheritanceListNode);
			Visit(node.CloseParenthesisNode);
			Visit(node.ContentListNode);
			Visit(node.EndKeywordNode);
		}
		internal void VisitAnonMethodImplementationNode(AnonMethodImplementationNode node) {
			Visit(node.AnonMethodHeading);
			Visit(node.FancyBlock);
		}
		internal void VisitTypeGenericNode(TypeGenericNode node) {
			Visit(node.TypeIdentifier);
			Visit(node.OpenParanthesis);
			Visit(node.GenericParameters);
			Visit(node.CloseParanthesis);
		}

		internal void VisitAnonMethodHeadingNode(AnonMethodHeadingNode node) {
			Visit(node.MethodType);
			Visit(node.OpenParenthesis);
			Visit(node.ParameterList);
			Visit(node.CloseParenthesis);
			Visit(node.Colon);
			Visit(node.ReturnType);
		}

		public virtual void VisitConstantDeclNode(ConstantDeclNode node) {
			Visit(node.NameNode);
			Visit(node.ColonNode);
			Visit(node.TypeNode);
			Visit(node.EqualSignNode);
			Visit(node.ValueNode);
			Visit(node.PortabilityDirectiveListNode);
			Visit(node.SemicolonNode);
		}
		public virtual void VisitConstantListNode(ConstantListNode node) {
			Visit(node.OpenParenthesisNode);
			Visit(node.ItemListNode);
			Visit(node.CloseParenthesisNode);
		}
		public virtual void VisitConstSectionNode(ConstSectionNode node) {
			Visit(node.ConstKeywordNode);
			Visit(node.ConstListNode);
		}
		public virtual void VisitDirectiveNode(DirectiveNode node) {
			Visit(node.SemicolonNode);
			Visit(node.KeywordNode);
			Visit(node.ValueNode);
			Visit(node.DataNode);
		}
		public virtual void VisitEnumeratedTypeElementNode(EnumeratedTypeElementNode node) {
			Visit(node.NameNode);
			Visit(node.EqualSignNode);
			Visit(node.ValueNode);
		}
		public virtual void VisitEnumeratedTypeNode(EnumeratedTypeNode node) {
			Visit(node.OpenParenthesisNode);
			Visit(node.ItemListNode);
			Visit(node.CloseParenthesisNode);
		}
		public virtual void VisitExceptionItemNode(ExceptionItemNode node) {
			Visit(node.OnSemikeywordNode);
			Visit(node.NameNode);
			Visit(node.ColonNode);
			Visit(node.TypeNode);
			Visit(node.DoKeywordNode);
			Visit(node.StatementNode);
			Visit(node.SemicolonNode);
		}
		public virtual void VisitExportsItemNode(ExportsItemNode node) {
			Visit(node.NameNode);
			Visit(node.SpecifierListNode);
		}
		public virtual void VisitExportsSpecifierNode(ExportsSpecifierNode node) {
			Visit(node.KeywordNode);
			Visit(node.ValueNode);
		}
		public virtual void VisitExportsStatementNode(ExportsStatementNode node) {
			Visit(node.ExportsKeywordNode);
			Visit(node.ItemListNode);
			Visit(node.SemicolonNode);
		}
		public virtual void VisitFancyBlockNode(FancyBlockNode node) {
			Visit(node.DeclListNode);
			Visit(node.BlockNode);
		}
		public virtual void VisitFieldDeclNode(FieldDeclNode node) {
			Visit(node.NameListNode);
			Visit(node.ColonNode);
			Visit(node.TypeNode);
			Visit(node.PortabilityDirectiveListNode);
			Visit(node.SemicolonNode);
		}
		public virtual void VisitFieldSectionNode(FieldSectionNode node) {
			Visit(node.ClassKeywordNode);
			Visit(node.VarKeywordNode);
			Visit(node.FieldListNode);
		}
		public virtual void VisitFileTypeNode(FileTypeNode node) {
			Visit(node.FileKeywordNode);
			Visit(node.OfKeywordNode);
			Visit(node.TypeNode);
		}
		public virtual void VisitForInStatementNode(ForInStatementNode node) {
			Visit(node.ForKeywordNode);
			Visit(node.LoopVariableNode);
			Visit(node.InKeywordNode);
			Visit(node.ExpressionNode);
			Visit(node.DoKeywordNode);
			Visit(node.StatementNode);
		}
		public virtual void VisitForStatementNode(ForStatementNode node) {
			Visit(node.ForKeywordNode);
			Visit(node.LoopVariableNode);
			Visit(node.ColonEqualsNode);
			Visit(node.StartingValueNode);
			Visit(node.DirectionNode);
			Visit(node.EndingValueNode);
			Visit(node.DoKeywordNode);
			Visit(node.StatementNode);
		}
		public virtual void VisitGotoStatementNode(GotoStatementNode node) {
			Visit(node.GotoKeywordNode);
			Visit(node.LabelIdNode);
		}
		public virtual void VisitIfStatementNode(IfStatementNode node) {
			Visit(node.IfKeywordNode);
			Visit(node.ConditionNode);
			Visit(node.ThenKeywordNode);
			Visit(node.ThenStatementNode);
			Visit(node.ElseKeywordNode);
			Visit(node.ElseStatementNode);
		}
		public virtual void VisitInitSectionNode(InitSectionNode node) {
			Visit(node.InitializationKeywordNode);
			Visit(node.InitializationStatementListNode);
			Visit(node.FinalizationKeywordNode);
			Visit(node.FinalizationStatementListNode);
			Visit(node.EndKeywordNode);
		}
		public virtual void VisitInterfaceTypeNode(InterfaceTypeNode node) {
			Visit(node.InterfaceKeywordNode);
			Visit(node.OpenParenthesisNode);
			Visit(node.BaseInterfaceNode);
			Visit(node.CloseParenthesisNode);
			Visit(node.OpenBracketNode);
			Visit(node.GuidNode);
			Visit(node.CloseBracketNode);
			Visit(node.MethodAndPropertyListNode);
			Visit(node.EndKeywordNode);
		}
		public virtual void VisitLabelDeclSectionNode(LabelDeclSectionNode node) {
			Visit(node.LabelKeywordNode);
			Visit(node.LabelListNode);
			Visit(node.SemicolonNode);
		}
		public virtual void VisitLabeledStatementNode(LabeledStatementNode node) {
			Visit(node.LabelIdNode);
			Visit(node.ColonNode);
			Visit(node.StatementNode);
		}
		public virtual void VisitMethodHeadingNode(MethodHeadingNode node) {
			Visit(node.ClassKeywordNode);
			Visit(node.MethodTypeNode);
			Visit(node.NameNode);
			Visit(node.OpenParenthesisNode);
			Visit(node.ParameterListNode);
			Visit(node.CloseParenthesisNode);
			Visit(node.ColonNode);
			Visit(node.ReturnTypeNode);
			Visit(node.DirectiveListNode);
			Visit(node.SemicolonNode);
		}
		public virtual void VisitMethodImplementationNode(MethodImplementationNode node) {
			Visit(node.MethodHeadingNode);
			Visit(node.FancyBlockNode);
			Visit(node.SemicolonNode);
		}
		public virtual void VisitMethodResolutionNode(MethodResolutionNode node) {
			Visit(node.MethodTypeNode);
			Visit(node.InterfaceMethodNode);
			Visit(node.EqualSignNode);
			Visit(node.ImplementationMethodNode);
			Visit(node.SemicolonNode);
		}
		public virtual void VisitNumberFormatNode(NumberFormatNode node) {
			Visit(node.ValueNode);
			Visit(node.SizeColonNode);
			Visit(node.SizeNode);
			Visit(node.PrecisionColonNode);
			Visit(node.PrecisionNode);
		}
		public virtual void VisitOpenArrayNode(OpenArrayNode node) {
			Visit(node.ArrayKeywordNode);
			Visit(node.OfKeywordNode);
			Visit(node.TypeNode);
		}
		public virtual void VisitPackageNode(PackageNode node) {
			Visit(node.PackageKeywordNode);
			Visit(node.NameNode);
			Visit(node.SemicolonNode);
			Visit(node.RequiresClauseNode);
			Visit(node.ContainsClauseNode);
			Visit(node.AttributeListNode);
			Visit(node.EndKeywordNode);
			Visit(node.DotNode);
		}
		public virtual void VisitPackedTypeNode(PackedTypeNode node) {
			Visit(node.PackedKeywordNode);
			Visit(node.TypeNode);
		}
		public virtual void VisitParameterizedNode(ParameterizedNode node) {
			Visit(node.LeftNode);
			Visit(node.OpenDelimiterNode);
			Visit(node.ParameterListNode);
			Visit(node.CloseDelimiterNode);
		}
		public virtual void VisitParameterNode(ParameterNode node) {
			Visit(node.ModifierNode);
			Visit(node.NameListNode);
			Visit(node.ColonNode);
			Visit(node.TypeNode);
			Visit(node.EqualSignNode);
			Visit(node.DefaultValueNode);
		}
		public virtual void VisitParenthesizedExpressionNode(ParenthesizedExpressionNode node) {
			Visit(node.OpenParenthesisNode);
			Visit(node.ExpressionNode);
			Visit(node.CloseParenthesisNode);
		}
		public virtual void VisitPointerDereferenceNode(PointerDereferenceNode node) {
			Visit(node.OperandNode);
			Visit(node.CaretNode);
		}
		public virtual void VisitPointerTypeNode(PointerTypeNode node) {
			Visit(node.CaretNode);
			Visit(node.TypeNode);
		}
		public virtual void VisitProcedureTypeNode(ProcedureTypeNode node) {
			Visit(node.MethodTypeNode);
			Visit(node.OpenParenthesisNode);
			Visit(node.ParameterListNode);
			Visit(node.CloseParenthesisNode);
			Visit(node.ColonNode);
			Visit(node.ReturnTypeNode);
			Visit(node.FirstDirectiveListNode);
			Visit(node.OfKeywordNode);
			Visit(node.ObjectKeywordNode);
			Visit(node.SecondDirectiveListNode);
		}
		public virtual void VisitProgramNode(ProgramNode node) {
			Visit(node.ProgramKeywordNode);
			Visit(node.NameNode);
			Visit(node.NoiseOpenParenthesisNode);
			Visit(node.NoiseContentListNode);
			Visit(node.NoiseCloseParenthesisNode);
			Visit(node.SemicolonNode);
			Visit(node.UsesClauseNode);
			Visit(node.DeclarationListNode);
			Visit(node.InitSectionNode);
			Visit(node.DotNode);
		}
		public virtual void VisitPropertyNode(PropertyNode node) {
			Visit(node.ClassKeywordNode);
			Visit(node.PropertyKeywordNode);
			Visit(node.NameNode);
			Visit(node.OpenBracketNode);
			Visit(node.ParameterListNode);
			Visit(node.CloseBracketNode);
			Visit(node.ColonNode);
			Visit(node.TypeNode);
			Visit(node.DirectiveListNode);
			Visit(node.SemicolonNode);
		}
		public virtual void VisitRaiseStatementNode(RaiseStatementNode node) {
			Visit(node.RaiseKeywordNode);
			Visit(node.ExceptionNode);
			Visit(node.AtSemikeywordNode);
			Visit(node.AddressNode);
		}
		public virtual void VisitRecordFieldConstantNode(RecordFieldConstantNode node) {
			Visit(node.NameNode);
			Visit(node.ColonNode);
			Visit(node.ValueNode);
		}
		public virtual void VisitRecordTypeNode(RecordTypeNode node) {
			Visit(node.RecordKeywordNode);
			Visit(node.ContentListNode);
			Visit(node.VariantSectionNode);
			Visit(node.EndKeywordNode);
		}
		public virtual void VisitRepeatStatementNode(RepeatStatementNode node) {
			Visit(node.RepeatKeywordNode);
			Visit(node.StatementListNode);
			Visit(node.UntilKeywordNode);
			Visit(node.ConditionNode);
		}
		public virtual void VisitRequiresClauseNode(RequiresClauseNode node) {
			Visit(node.RequiresSemikeywordNode);
			Visit(node.PackageListNode);
			Visit(node.SemicolonNode);
		}
		public virtual void VisitSetLiteralNode(SetLiteralNode node) {
			Visit(node.OpenBracketNode);
			Visit(node.ItemListNode);
			Visit(node.CloseBracketNode);
		}
		public virtual void VisitSetOfNode(SetOfNode node) {
			Visit(node.SetKeywordNode);
			Visit(node.OfKeywordNode);
			Visit(node.TypeNode);
		}
		public virtual void VisitStringOfLengthNode(StringOfLengthNode node) {
			Visit(node.StringKeywordNode);
			Visit(node.OpenBracketNode);
			Visit(node.LengthNode);
			Visit(node.CloseBracketNode);
		}
		public virtual void VisitTryExceptNode(TryExceptNode node) {
			Visit(node.TryKeywordNode);
			Visit(node.TryStatementListNode);
			Visit(node.ExceptKeywordNode);
			Visit(node.ExceptionItemListNode);
			Visit(node.ElseKeywordNode);
			Visit(node.ElseStatementListNode);
			Visit(node.EndKeywordNode);
		}
		public virtual void VisitTryFinallyNode(TryFinallyNode node) {
			Visit(node.TryKeywordNode);
			Visit(node.TryStatementListNode);
			Visit(node.FinallyKeywordNode);
			Visit(node.FinallyStatementListNode);
			Visit(node.EndKeywordNode);
		}
		public virtual void VisitTypeDeclNode(TypeDeclNode node) {
			Visit(node.NameNode);
			Visit(node.EqualSignNode);
			Visit(node.TypeKeywordNode);
			Visit(node.TypeNode);
			Visit(node.PortabilityDirectiveListNode);
			Visit(node.SemicolonNode);
		}
		public virtual void VisitTypeForwardDeclarationNode(TypeForwardDeclarationNode node) {
			Visit(node.NameNode);
			Visit(node.EqualSignNode);
			Visit(node.TypeNode);
			Visit(node.SemicolonNode);
		}
		public virtual void VisitTypeHelperNode(TypeHelperNode node) {
			Visit(node.TypeKeywordNode);
			Visit(node.HelperSemikeywordNode);
			Visit(node.OpenParenthesisNode);
			Visit(node.BaseHelperTypeNode);
			Visit(node.CloseParenthesisNode);
			Visit(node.ForKeywordNode);
			Visit(node.TypeNode);
			Visit(node.ContentListNode);
			Visit(node.EndKeywordNode);
		}
		public virtual void VisitTypeSectionNode(TypeSectionNode node) {
			Visit(node.TypeKeywordNode);
			Visit(node.TypeListNode);
		}
		public virtual void VisitUnaryOperationNode(UnaryOperationNode node) {
			Visit(node.OperatorNode);
			Visit(node.OperandNode);
		}
		public virtual void VisitUnitNode(UnitNode node) {
			Visit(node.UnitKeywordNode);
			Visit(node.UnitNameNode);
			Visit(node.PortabilityDirectiveListNode);
			Visit(node.SemicolonNode);
			Visit(node.InterfaceSectionNode);
			Visit(node.ImplementationSectionNode);
			Visit(node.InitSectionNode);
			Visit(node.DotNode);
		}
		public virtual void VisitUnitSectionNode(UnitSectionNode node) {
			Visit(node.HeaderKeywordNode);
			Visit(node.UsesClauseNode);
			Visit(node.ContentListNode);
		}
		public virtual void VisitUsedUnitNode(UsedUnitNode node) {
			Visit(node.NameNode);
			Visit(node.InKeywordNode);
			Visit(node.FileNameNode);
		}
		public virtual void VisitUsesClauseNode(UsesClauseNode node) {
			Visit(node.UsesKeywordNode);
			Visit(node.UnitListNode);
			Visit(node.SemicolonNode);
		}
		public virtual void VisitVarDeclNode(VarDeclNode node) {
			Visit(node.NameListNode);
			Visit(node.ColonNode);
			Visit(node.TypeNode);
			Visit(node.FirstPortabilityDirectiveListNode);
			Visit(node.AbsoluteSemikeywordNode);
			Visit(node.AbsoluteAddressNode);
			Visit(node.EqualSignNode);
			Visit(node.ValueNode);
			Visit(node.SecondPortabilityDirectiveListNode);
			Visit(node.SemicolonNode);
		}
		public virtual void VisitVariantGroupNode(VariantGroupNode node) {
			Visit(node.ValueListNode);
			Visit(node.ColonNode);
			Visit(node.OpenParenthesisNode);
			Visit(node.FieldDeclListNode);
			Visit(node.VariantSectionNode);
			Visit(node.CloseParenthesisNode);
			Visit(node.SemicolonNode);
		}
		public virtual void VisitVariantSectionNode(VariantSectionNode node) {
			Visit(node.CaseKeywordNode);
			Visit(node.NameNode);
			Visit(node.ColonNode);
			Visit(node.TypeNode);
			Visit(node.OfKeywordNode);
			Visit(node.VariantGroupListNode);
		}
		public virtual void VisitVarSectionNode(VarSectionNode node) {
			Visit(node.VarKeywordNode);
			Visit(node.VarListNode);
		}
		public virtual void VisitVisibilityNode(VisibilityNode node) {
			Visit(node.StrictSemikeywordNode);
			Visit(node.VisibilityKeywordNode);
		}
		public virtual void VisitVisibilitySectionNode(VisibilitySectionNode node) {
			Visit(node.VisibilityNode);
			Visit(node.ContentListNode);
		}
		public virtual void VisitWhileStatementNode(WhileStatementNode node) {
			Visit(node.WhileKeywordNode);
			Visit(node.ConditionNode);
			Visit(node.DoKeywordNode);
			Visit(node.StatementNode);
		}
		public virtual void VisitWithStatementNode(WithStatementNode node) {
			Visit(node.WithKeywordNode);
			Visit(node.ExpressionListNode);
			Visit(node.DoKeywordNode);
			Visit(node.StatementNode);
		}

		internal void VisitGotoStatementNode(GenericIdentifierNode node) {
			Visit(node.IdentifierNode);
			Visit(node.GenericOpen);
			Visit(node.TypeListNode);
			Visit(node.GenericClose);
		}

		internal void VisitGotoStatementNode(GenericConstraintsNode node) {
			Visit(node.IdentifierListNode);
			Visit(node.ColonNode);
			Visit(node.ConstraintListNode);
		}
	}
}
