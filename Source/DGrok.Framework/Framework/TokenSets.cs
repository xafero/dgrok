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
using System.Collections.Generic;
using System.Text;

namespace DGrok.Framework {
	public static class TokenSets {
		public static TokenSet AddOp { get; }
		public static TokenSet Block { get; }
		public static TokenSet ClassDisposition { get; }
		public static TokenSet ConstHeader { get; }
		public static TokenSet Directive { get; }
		public static TokenSet ExportsSpecifier { get; }
		public static TokenSet Expression { get; }
		public static TokenSet ExtendedIdent { get; }
		public static TokenSet ForDirection { get; }
		public static TokenSet ForwardableType { get; }
		public static TokenSet Ident { get; }
		public static TokenSet IdentNoVisibility { get; }
		public static TokenSet InitSection { get; }
		public static TokenSet InterfaceType { get; }
		public static TokenSet Keyword { get; }
		public static TokenSet LabelId { get; }
		public static TokenSet MethodType { get; }
		public static TokenSet MulOp { get; }
		public static TokenSet Parameter { get; }
		public static TokenSet ParameterizedPropertyDirective { get; }
		public static TokenSet ParameterlessPropertyDirective { get; }
		public static TokenSet ParameterModifier { get; }
		public static TokenSet Particle { get; }
		public static TokenSet PortabilityDirective { get; }
		public static TokenSet Program { get; }
		public static TokenSet RelOp { get; }
		public static TokenSet Semikeyword { get; }
		public static TokenSet SimpleParameterType { get; }
		public static TokenSet UnaryOperator { get; }
		public static TokenSet Uses { get; }
		public static TokenSet VarHeader { get; }
		public static TokenSet Visibility { get; }
		public static TokenSet VisibilitySingleWord { get; }

		static TokenSets() {
			AddOp = new TokenSet("addition operator");
			AddOp.Add(TokenType.PlusSign);
			AddOp.Add(TokenType.MinusSign);
			AddOp.Add(TokenType.OrKeyword);
			AddOp.Add(TokenType.XorKeyword);

			Block = new TokenSet("block");
			Block.Add(TokenType.BeginKeyword);
			Block.Add(TokenType.AsmKeyword);

			ClassDisposition = new TokenSet("class disposition");
			ClassDisposition.Add(TokenType.AbstractSemikeyword);
			ClassDisposition.Add(TokenType.SealedSemikeyword);

			ConstHeader = new TokenSet("const section");
			ConstHeader.Add(TokenType.ConstKeyword);
			ConstHeader.Add(TokenType.ResourceStringKeyword);

			Directive = new TokenSet("directive");
			Directive.Add(TokenType.AbstractSemikeyword);
			Directive.Add(TokenType.AssemblerSemikeyword);
			Directive.Add(TokenType.CdeclSemikeyword);
			Directive.Add(TokenType.DispIdSemikeyword);
			Directive.Add(TokenType.DynamicSemikeyword);
			Directive.Add(TokenType.ExportSemikeyword);
			Directive.Add(TokenType.ExternalSemikeyword);
			Directive.Add(TokenType.FarSemikeyword);
			Directive.Add(TokenType.FinalSemikeyword);
			Directive.Add(TokenType.ForwardSemikeyword);
			Directive.Add(TokenType.InlineKeyword);
			Directive.Add(TokenType.LocalSemikeyword);
			Directive.Add(TokenType.MessageSemikeyword);
			Directive.Add(TokenType.NearSemikeyword);
			Directive.Add(TokenType.OverloadSemikeyword);
			Directive.Add(TokenType.OverrideSemikeyword);
			Directive.Add(TokenType.PascalSemikeyword);
			Directive.Add(TokenType.RegisterSemikeyword);
			Directive.Add(TokenType.ReintroduceSemikeyword);
			Directive.Add(TokenType.SafecallSemikeyword);
			Directive.Add(TokenType.StaticSemikeyword);
			Directive.Add(TokenType.StdcallSemikeyword);
			Directive.Add(TokenType.VarArgsSemikeyword);
			Directive.Add(TokenType.VirtualSemikeyword);
			// also includes PortabilityDirective, see below

			ExportsSpecifier = new TokenSet("'index' or 'name'");
			ExportsSpecifier.Add(TokenType.IndexSemikeyword);
			ExportsSpecifier.Add(TokenType.NameSemikeyword);

			ForDirection = new TokenSet("'to' or 'downto'");
			ForDirection.Add(TokenType.ToKeyword);
			ForDirection.Add(TokenType.DownToKeyword);

			ForwardableType = new TokenSet("forwardable type");
			ForwardableType.Add(TokenType.ClassKeyword);
			ForwardableType.Add(TokenType.DispInterfaceKeyword);
			ForwardableType.Add(TokenType.InterfaceKeyword);

			InitSection = new TokenSet("initialization section");
			InitSection.Add(TokenType.AsmKeyword);
			InitSection.Add(TokenType.BeginKeyword);
			InitSection.Add(TokenType.InitializationKeyword);
			InitSection.Add(TokenType.EndKeyword);

			InterfaceType = new TokenSet("interface type");
			InterfaceType.Add(TokenType.InterfaceKeyword);
			InterfaceType.Add(TokenType.DispInterfaceKeyword);

			Keyword = new TokenSet("keyword");
			Keyword.Add(TokenType.AndKeyword);
			Keyword.Add(TokenType.ArrayKeyword);
			Keyword.Add(TokenType.AsKeyword);
			Keyword.Add(TokenType.AsmKeyword);
			Keyword.Add(TokenType.BeginKeyword);
			Keyword.Add(TokenType.CaseKeyword);
			Keyword.Add(TokenType.ClassKeyword);
			Keyword.Add(TokenType.ConstKeyword);
			Keyword.Add(TokenType.ConstructorKeyword);
			Keyword.Add(TokenType.DestructorKeyword);
			Keyword.Add(TokenType.DispInterfaceKeyword);
			Keyword.Add(TokenType.DivKeyword);
			Keyword.Add(TokenType.DoKeyword);
			Keyword.Add(TokenType.DownToKeyword);
			Keyword.Add(TokenType.ElseKeyword);
			Keyword.Add(TokenType.EndKeyword);
			Keyword.Add(TokenType.ExceptKeyword);
			Keyword.Add(TokenType.ExportsKeyword);
			Keyword.Add(TokenType.FileKeyword);
			Keyword.Add(TokenType.FinalizationKeyword);
			Keyword.Add(TokenType.FinallyKeyword);
			Keyword.Add(TokenType.ForKeyword);
			Keyword.Add(TokenType.FunctionKeyword);
			Keyword.Add(TokenType.GotoKeyword);
			Keyword.Add(TokenType.IfKeyword);
			Keyword.Add(TokenType.ImplementationKeyword);
			Keyword.Add(TokenType.InKeyword);
			Keyword.Add(TokenType.InheritedKeyword);
			Keyword.Add(TokenType.InitializationKeyword);
			Keyword.Add(TokenType.InlineKeyword);
			Keyword.Add(TokenType.InterfaceKeyword);
			Keyword.Add(TokenType.IsKeyword);
			Keyword.Add(TokenType.LabelKeyword);
			Keyword.Add(TokenType.LibraryKeyword);
			Keyword.Add(TokenType.ModKeyword);
			Keyword.Add(TokenType.NilKeyword);
			Keyword.Add(TokenType.NotKeyword);
			Keyword.Add(TokenType.ObjectKeyword);
			Keyword.Add(TokenType.OfKeyword);
			Keyword.Add(TokenType.OrKeyword);
			Keyword.Add(TokenType.PackedKeyword);
			Keyword.Add(TokenType.ProcedureKeyword);
			Keyword.Add(TokenType.ProgramKeyword);
			Keyword.Add(TokenType.PropertyKeyword);
			Keyword.Add(TokenType.RaiseKeyword);
			Keyword.Add(TokenType.RecordKeyword);
			Keyword.Add(TokenType.RepeatKeyword);
			Keyword.Add(TokenType.ResourceStringKeyword);
			Keyword.Add(TokenType.SetKeyword);
			Keyword.Add(TokenType.ShlKeyword);
			Keyword.Add(TokenType.ShrKeyword);
			Keyword.Add(TokenType.StringKeyword);
			Keyword.Add(TokenType.ThenKeyword);
			Keyword.Add(TokenType.ThreadVarKeyword);
			Keyword.Add(TokenType.ToKeyword);
			Keyword.Add(TokenType.TryKeyword);
			Keyword.Add(TokenType.TypeKeyword);
			Keyword.Add(TokenType.UnitKeyword);
			Keyword.Add(TokenType.UntilKeyword);
			Keyword.Add(TokenType.UsesKeyword);
			Keyword.Add(TokenType.VarKeyword);
			Keyword.Add(TokenType.WhileKeyword);
			Keyword.Add(TokenType.WithKeyword);
			Keyword.Add(TokenType.XorKeyword);

			MethodType = new TokenSet("method heading");
			MethodType.Add(TokenType.ConstructorKeyword);
			MethodType.Add(TokenType.DestructorKeyword);
			MethodType.Add(TokenType.FunctionKeyword);
			MethodType.Add(TokenType.ProcedureKeyword);
			MethodType.Add(TokenType.OperatorSemikeyword);

			MulOp = new TokenSet("multiplication operator");
			MulOp.Add(TokenType.TimesSign);
			MulOp.Add(TokenType.DivideBySign);
			MulOp.Add(TokenType.DivKeyword);
			MulOp.Add(TokenType.AndKeyword);
			MulOp.Add(TokenType.ModKeyword);
			MulOp.Add(TokenType.ShlKeyword);
			MulOp.Add(TokenType.ShrKeyword);

			ParameterizedPropertyDirective = new TokenSet("property directive");
			ParameterizedPropertyDirective.Add(TokenType.DefaultSemikeyword);
			ParameterizedPropertyDirective.Add(TokenType.DispIdSemikeyword);
			ParameterizedPropertyDirective.Add(TokenType.ImplementsSemikeyword);
			ParameterizedPropertyDirective.Add(TokenType.IndexSemikeyword);
			ParameterizedPropertyDirective.Add(TokenType.ReadSemikeyword);
			ParameterizedPropertyDirective.Add(TokenType.StoredSemikeyword);
			ParameterizedPropertyDirective.Add(TokenType.WriteSemikeyword);

			ParameterlessPropertyDirective = new TokenSet("property directive");
			ParameterlessPropertyDirective.Add(TokenType.NoDefaultSemikeyword);
			ParameterlessPropertyDirective.Add(TokenType.ReadOnlySemikeyword);
			ParameterlessPropertyDirective.Add(TokenType.WriteOnlySemikeyword);

			ParameterModifier = new TokenSet("parameter modifier");
			ParameterModifier.Add(TokenType.ConstKeyword);
			ParameterModifier.Add(TokenType.OutSemikeyword);
			ParameterModifier.Add(TokenType.VarKeyword);

			PortabilityDirective = new TokenSet("portability directive");
			PortabilityDirective.Add(TokenType.PlatformSemikeyword);
			PortabilityDirective.Add(TokenType.DeprecatedSemikeyword);
			PortabilityDirective.Add(TokenType.LibraryKeyword);
			PortabilityDirective.Add(TokenType.ExperimentalSemikeyword);

			Program = new TokenSet("program");
			Program.Add(TokenType.ProgramKeyword);
			Program.Add(TokenType.LibraryKeyword);

			RelOp = new TokenSet("relational operator");
			RelOp.Add(TokenType.EqualSign);
			RelOp.Add(TokenType.GreaterThan);
			RelOp.Add(TokenType.LessThan);
			RelOp.Add(TokenType.LessOrEqual);
			RelOp.Add(TokenType.GreaterOrEqual);
			RelOp.Add(TokenType.NotEqual);
			RelOp.Add(TokenType.InKeyword);
			RelOp.Add(TokenType.IsKeyword);
			RelOp.Add(TokenType.AsKeyword);

			Semikeyword = new TokenSet("semikeyword");
			Semikeyword.Add(TokenType.AbsoluteSemikeyword);
			Semikeyword.Add(TokenType.AbstractSemikeyword);
			Semikeyword.Add(TokenType.AssemblerSemikeyword);
			Semikeyword.Add(TokenType.AssemblySemikeyword);
			Semikeyword.Add(TokenType.AtSemikeyword);
			Semikeyword.Add(TokenType.AutomatedSemikeyword);
			Semikeyword.Add(TokenType.CdeclSemikeyword);
			Semikeyword.Add(TokenType.ContainsSemikeyword);
			Semikeyword.Add(TokenType.DefaultSemikeyword);
			Semikeyword.Add(TokenType.DeprecatedSemikeyword);
			Semikeyword.Add(TokenType.DispIdSemikeyword);
			Semikeyword.Add(TokenType.DynamicSemikeyword);
			Semikeyword.Add(TokenType.ExperimentalSemikeyword);
			Semikeyword.Add(TokenType.ExportSemikeyword);
			Semikeyword.Add(TokenType.ExternalSemikeyword);
			Semikeyword.Add(TokenType.FarSemikeyword);
			Semikeyword.Add(TokenType.FinalSemikeyword);
			Semikeyword.Add(TokenType.ForwardSemikeyword);
			Semikeyword.Add(TokenType.HelperSemikeyword);
			Semikeyword.Add(TokenType.ImplementsSemikeyword);
			Semikeyword.Add(TokenType.IndexSemikeyword);
			Semikeyword.Add(TokenType.LocalSemikeyword);
			Semikeyword.Add(TokenType.MessageSemikeyword);
			Semikeyword.Add(TokenType.NameSemikeyword);
			Semikeyword.Add(TokenType.NearSemikeyword);
			Semikeyword.Add(TokenType.NoDefaultSemikeyword);
			Semikeyword.Add(TokenType.OnSemikeyword);
			Semikeyword.Add(TokenType.OperatorSemikeyword);
			Semikeyword.Add(TokenType.OutSemikeyword);
			Semikeyword.Add(TokenType.OverloadSemikeyword);
			Semikeyword.Add(TokenType.OverrideSemikeyword);
			Semikeyword.Add(TokenType.PackageSemikeyword);
			Semikeyword.Add(TokenType.PascalSemikeyword);
			Semikeyword.Add(TokenType.PlatformSemikeyword);
			Semikeyword.Add(TokenType.PrivateSemikeyword);
			Semikeyword.Add(TokenType.ProtectedSemikeyword);
			Semikeyword.Add(TokenType.PublicSemikeyword);
			Semikeyword.Add(TokenType.PublishedSemikeyword);
			Semikeyword.Add(TokenType.ReadSemikeyword);
			Semikeyword.Add(TokenType.ReadOnlySemikeyword);
			Semikeyword.Add(TokenType.RegisterSemikeyword);
			Semikeyword.Add(TokenType.ReintroduceSemikeyword);
			Semikeyword.Add(TokenType.RequiresSemikeyword);
			Semikeyword.Add(TokenType.ResidentSemikeyword);
			Semikeyword.Add(TokenType.SafecallSemikeyword);
			Semikeyword.Add(TokenType.SealedSemikeyword);
			Semikeyword.Add(TokenType.StaticSemikeyword);
			Semikeyword.Add(TokenType.StdcallSemikeyword);
			Semikeyword.Add(TokenType.StoredSemikeyword);
			Semikeyword.Add(TokenType.StrictSemikeyword);
			Semikeyword.Add(TokenType.UnsafeSemikeyword);
			Semikeyword.Add(TokenType.VarArgsSemikeyword);
			Semikeyword.Add(TokenType.VirtualSemikeyword);
			Semikeyword.Add(TokenType.WriteSemikeyword);
			Semikeyword.Add(TokenType.WriteOnlySemikeyword);

			UnaryOperator = new TokenSet("unary operator");
			UnaryOperator.Add(TokenType.AtSign);
			UnaryOperator.Add(TokenType.InheritedKeyword);
			UnaryOperator.Add(TokenType.MinusSign);
			UnaryOperator.Add(TokenType.NotKeyword);
			UnaryOperator.Add(TokenType.PlusSign);

			Uses = new TokenSet("uses clause");
			Uses.Add(TokenType.UsesKeyword);
			Uses.Add(TokenType.ContainsSemikeyword);

			VarHeader = new TokenSet("var section");
			VarHeader.Add(TokenType.VarKeyword);
			VarHeader.Add(TokenType.ThreadVarKeyword);

			VisibilitySingleWord = new TokenSet("'private', 'protected', 'public', or 'published'");
			VisibilitySingleWord.Add(TokenType.PrivateSemikeyword);
			VisibilitySingleWord.Add(TokenType.ProtectedSemikeyword);
			VisibilitySingleWord.Add(TokenType.PublicSemikeyword);
			VisibilitySingleWord.Add(TokenType.PublishedSemikeyword);

			Ident = new TokenSet("identifier");
			Ident.Add(TokenType.Identifier);
			Ident.AddRange(Semikeyword);

			IdentNoVisibility = new TokenSet("identifier no visibility");
			IdentNoVisibility.AddRange(Ident);
			IdentNoVisibility.RemoveRange(VisibilitySingleWord);
			IdentNoVisibility.Remove(TokenType.StrictSemikeyword);

			Directive.AddRange(PortabilityDirective);

			Particle = new TokenSet("expression");
			Particle.Add(TokenType.FileKeyword);
			Particle.Add(TokenType.NilKeyword);
			Particle.Add(TokenType.Number);
			Particle.Add(TokenType.OpenBracket);
			Particle.Add(TokenType.OpenParenthesis);
			Particle.Add(TokenType.StringKeyword);
			Particle.Add(TokenType.StringLiteral);
			Particle.AddRange(Ident);

			Expression = new TokenSet("expression");
			Expression.AddRange(Particle);
			Expression.AddRange(UnaryOperator);
			Expression.Add(TokenType.FunctionKeyword);
			Expression.Add(TokenType.ProcedureKeyword);

			ExtendedIdent = new TokenSet("identifier (including keyword)");
			ExtendedIdent.AddRange(Ident);
			ExtendedIdent.AddRange(Keyword);

			LabelId = new TokenSet("label");
			LabelId.Add(TokenType.Number);
			LabelId.AddRange(Ident);

			Parameter = new TokenSet("parameter");
			Parameter.AddRange(Ident);
			Parameter.AddRange(ParameterModifier);

			SimpleParameterType = new TokenSet("parameter type");
			SimpleParameterType.Add(TokenType.FileKeyword);
			SimpleParameterType.Add(TokenType.StringKeyword);
			SimpleParameterType.AddRange(Ident);

			Visibility = new TokenSet("visibility specifier");
			Visibility.Add(TokenType.StrictSemikeyword);
			Visibility.AddRange(VisibilitySingleWord);
		}

	}
}
