//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\users\ddong\documents\visual studio 2015\Projects\Kitten\Kitten\KittenGrammar.g4 by ANTLR 4.5.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Kitten {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="KittenGrammarParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public interface IKittenGrammarVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>integerLiteralExpr</c>
	/// labeled alternative in <see cref="KittenGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIntegerLiteralExpr([NotNull] KittenGrammarParser.IntegerLiteralExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>stringLiteralExpr</c>
	/// labeled alternative in <see cref="KittenGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringLiteralExpr([NotNull] KittenGrammarParser.StringLiteralExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>booleanExpr</c>
	/// labeled alternative in <see cref="KittenGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBooleanExpr([NotNull] KittenGrammarParser.BooleanExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>functionCallExpr</c>
	/// labeled alternative in <see cref="KittenGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCallExpr([NotNull] KittenGrammarParser.FunctionCallExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>booleanLiteralExpr</c>
	/// labeled alternative in <see cref="KittenGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBooleanLiteralExpr([NotNull] KittenGrammarParser.BooleanLiteralExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>blockExpr</c>
	/// labeled alternative in <see cref="KittenGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockExpr([NotNull] KittenGrammarParser.BlockExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>arithmaticExpr</c>
	/// labeled alternative in <see cref="KittenGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArithmaticExpr([NotNull] KittenGrammarParser.ArithmaticExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>parenExpr</c>
	/// labeled alternative in <see cref="KittenGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenExpr([NotNull] KittenGrammarParser.ParenExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>identifierExpr</c>
	/// labeled alternative in <see cref="KittenGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierExpr([NotNull] KittenGrammarParser.IdentifierExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="KittenGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] KittenGrammarParser.StatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="KittenGrammarParser.declStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclStatement([NotNull] KittenGrammarParser.DeclStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="KittenGrammarParser.assignStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignStatement([NotNull] KittenGrammarParser.AssignStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="KittenGrammarParser.exprStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprStatement([NotNull] KittenGrammarParser.ExprStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="KittenGrammarParser.statementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatementList([NotNull] KittenGrammarParser.StatementListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="KittenGrammarParser.identifierList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierList([NotNull] KittenGrammarParser.IdentifierListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="KittenGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] KittenGrammarParser.ExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="KittenGrammarParser.blockLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockLiteral([NotNull] KittenGrammarParser.BlockLiteralContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="KittenGrammarParser.exprList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprList([NotNull] KittenGrammarParser.ExprListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="KittenGrammarParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompileUnit([NotNull] KittenGrammarParser.CompileUnitContext context);
}
} // namespace Kitten