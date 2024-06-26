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

namespace DGrok.Framework {
	public enum TokenType {
		// Sentinel
		EndOfFile,
		// Comments
		SingleLineComment,
		CurlyBraceComment,
		ParenStarComment,
		CompilerDirective,
		// Values
		Identifier,
		Number,
		StringLiteral,
		#region Semikeywords (context keywords, can be used as identifiers)
		AbsoluteSemikeyword,
		AbstractSemikeyword,
		AssemblerSemikeyword,
		AssemblySemikeyword,
		AtSemikeyword,
		AutomatedSemikeyword,
		CdeclSemikeyword,
		ContainsSemikeyword,
		DefaultSemikeyword,
		DeprecatedSemikeyword,
		DispIdSemikeyword,
		DynamicSemikeyword,
		ExperimentalSemikeyword,
		ExportSemikeyword,
		ExternalSemikeyword,
		FarSemikeyword,
		FinalSemikeyword,
		ForwardSemikeyword,
		HelperSemikeyword,
		ImplementsSemikeyword,
		IndexSemikeyword,
		LocalSemikeyword,
		MessageSemikeyword,
		NameSemikeyword,
		NearSemikeyword,
		NoDefaultSemikeyword,
		OnSemikeyword,
		OperatorSemikeyword,
		OutSemikeyword,
		OverloadSemikeyword,
		OverrideSemikeyword,
		PackageSemikeyword,
		PascalSemikeyword,
		PlatformSemikeyword,
		PrivateSemikeyword,
		ProtectedSemikeyword,
		PublicSemikeyword,
		PublishedSemikeyword,
		ReadSemikeyword,
		ReadOnlySemikeyword,
		RegisterSemikeyword,
		ReintroduceSemikeyword,
		RequiresSemikeyword,
		ResidentSemikeyword,
		SafecallSemikeyword,
		SealedSemikeyword,
		StaticSemikeyword,
		StdcallSemikeyword,
		StoredSemikeyword,
		StrictSemikeyword,
		UnsafeSemikeyword,
		VarArgsSemikeyword,
		VirtualSemikeyword,
		WriteSemikeyword,
		WriteOnlySemikeyword,
		ReferenceSemikeyword,
		#endregion
		#region Real keywords (can't be used as identifiers, except after '.')
		AndKeyword,
		ArrayKeyword,
		AsKeyword,
		AsmKeyword,
		BeginKeyword,
		CaseKeyword,
		ClassKeyword,
		ConstKeyword,
		ConstructorKeyword,
		DestructorKeyword,
		DispInterfaceKeyword,
		DivKeyword,
		DoKeyword,
		DownToKeyword,
		ElseKeyword,
		EndKeyword,
		ExceptKeyword,
		ExportsKeyword,
		FileKeyword,
		FinalizationKeyword,
		FinallyKeyword,
		ForKeyword,
		FunctionKeyword,
		GotoKeyword,
		IfKeyword,
		ImplementationKeyword,
		InKeyword,
		InheritedKeyword,
		InitializationKeyword,
		InlineKeyword,
		InterfaceKeyword,
		IsKeyword,
		LabelKeyword,
		LibraryKeyword,
		ModKeyword,
		NilKeyword,
		NotKeyword,
		ObjectKeyword,
		OfKeyword,
		OrKeyword,
		PackedKeyword,
		ProcedureKeyword,
		ProgramKeyword,
		PropertyKeyword,
		RaiseKeyword,
		RecordKeyword,
		RepeatKeyword,
		ResourceStringKeyword,
		SetKeyword,
		ShlKeyword,
		ShrKeyword,
		StringKeyword,
		ThenKeyword,
		ThreadVarKeyword,
		ToKeyword,
		TryKeyword,
		TypeKeyword,
		UnitKeyword,
		UntilKeyword,
		UsesKeyword,
		VarKeyword,
		WhileKeyword,
		WithKeyword,
		XorKeyword,
		#endregion
		// Equality / inequality / assignment
		ColonEquals,
		EqualSign,
		GreaterOrEqual,
		GreaterThan,
		LessOrEqual,
		LessThan,
		NotEqual,
		// Punctuation
		AtSign,
		Caret,
		CloseBracket,
		CloseParenthesis,
		Colon,
		Comma,
		DivideBySign,
		Dot,
		DotDot,
		MinusSign,
		OpenBracket,
		OpenParenthesis,
		PlusSign,
		Semicolon,
		TimesSign,
	}
}
