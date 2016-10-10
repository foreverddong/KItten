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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class KittenGrammarParser : Parser {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, IntegerLiteral=20, BooleanLiteral=21, StringLiteral=22, 
		ID=23, WS=24;
	public const int
		RULE_statement = 0, RULE_declStatement = 1, RULE_assignStatement = 2, 
		RULE_exprStatement = 3, RULE_statementList = 4, RULE_identifierList = 5, 
		RULE_expr = 6, RULE_blockLiteral = 7, RULE_exprList = 8, RULE_compileUnit = 9;
	public static readonly string[] ruleNames = {
		"statement", "declStatement", "assignStatement", "exprStatement", "statementList", 
		"identifierList", "expr", "blockLiteral", "exprList", "compileUnit"
	};

	private static readonly string[] _LiteralNames = {
		null, "'var'", "'='", "';'", "'('", "')'", "'*'", "'/'", "'+'", "'-'", 
		"'=='", "'>='", "'<='", "'!='", "'>'", "'<'", "'['", "'}'", "'{'", "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, "IntegerLiteral", "BooleanLiteral", 
		"StringLiteral", "ID", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "KittenGrammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public KittenGrammarParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class StatementContext : ParserRuleContext {
		public DeclStatementContext declStatement() {
			return GetRuleContext<DeclStatementContext>(0);
		}
		public AssignStatementContext assignStatement() {
			return GetRuleContext<AssignStatementContext>(0);
		}
		public ExprStatementContext exprStatement() {
			return GetRuleContext<ExprStatementContext>(0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		public override void EnterRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IKittenGrammarVisitor<TResult> typedVisitor = visitor as IKittenGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStatement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_statement);
		try {
			State = 23;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,0,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 20; declStatement();
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 21; assignStatement();
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 22; exprStatement();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DeclStatementContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(KittenGrammarParser.ID, 0); }
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public DeclStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declStatement; } }
		public override void EnterRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.EnterDeclStatement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.ExitDeclStatement(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IKittenGrammarVisitor<TResult> typedVisitor = visitor as IKittenGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDeclStatement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DeclStatementContext declStatement() {
		DeclStatementContext _localctx = new DeclStatementContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_declStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 25; Match(T__0);
			State = 26; Match(ID);
			State = 27; Match(T__1);
			State = 28; expr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AssignStatementContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(KittenGrammarParser.ID, 0); }
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public AssignStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignStatement; } }
		public override void EnterRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.EnterAssignStatement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.ExitAssignStatement(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IKittenGrammarVisitor<TResult> typedVisitor = visitor as IKittenGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAssignStatement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AssignStatementContext assignStatement() {
		AssignStatementContext _localctx = new AssignStatementContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_assignStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 30; Match(ID);
			State = 31; Match(T__1);
			State = 32; expr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprStatementContext : ParserRuleContext {
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ExprStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_exprStatement; } }
		public override void EnterRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.EnterExprStatement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.ExitExprStatement(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IKittenGrammarVisitor<TResult> typedVisitor = visitor as IKittenGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExprStatement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprStatementContext exprStatement() {
		ExprStatementContext _localctx = new ExprStatementContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_exprStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 34; expr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatementListContext : ParserRuleContext {
		public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public StatementListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statementList; } }
		public override void EnterRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.EnterStatementList(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.ExitStatementList(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IKittenGrammarVisitor<TResult> typedVisitor = visitor as IKittenGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStatementList(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatementListContext statementList() {
		StatementListContext _localctx = new StatementListContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_statementList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 41;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__3) | (1L << T__15) | (1L << T__17) | (1L << IntegerLiteral) | (1L << BooleanLiteral) | (1L << StringLiteral) | (1L << ID))) != 0)) {
				{
				{
				State = 36; statement();
				State = 37; Match(T__2);
				}
				}
				State = 43;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IdentifierListContext : ParserRuleContext {
		public ITerminalNode[] ID() { return GetTokens(KittenGrammarParser.ID); }
		public ITerminalNode ID(int i) {
			return GetToken(KittenGrammarParser.ID, i);
		}
		public IdentifierListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_identifierList; } }
		public override void EnterRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.EnterIdentifierList(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.ExitIdentifierList(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IKittenGrammarVisitor<TResult> typedVisitor = visitor as IKittenGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIdentifierList(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IdentifierListContext identifierList() {
		IdentifierListContext _localctx = new IdentifierListContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_identifierList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 47;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==ID) {
				{
				{
				State = 44; Match(ID);
				}
				}
				State = 49;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
	 
		public ExprContext() { }
		public virtual void CopyFrom(ExprContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class IntegerLiteralExprContext : ExprContext {
		public ITerminalNode IntegerLiteral() { return GetToken(KittenGrammarParser.IntegerLiteral, 0); }
		public IntegerLiteralExprContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.EnterIntegerLiteralExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.ExitIntegerLiteralExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IKittenGrammarVisitor<TResult> typedVisitor = visitor as IKittenGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIntegerLiteralExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class StringLiteralExprContext : ExprContext {
		public ITerminalNode StringLiteral() { return GetToken(KittenGrammarParser.StringLiteral, 0); }
		public StringLiteralExprContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.EnterStringLiteralExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.ExitStringLiteralExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IKittenGrammarVisitor<TResult> typedVisitor = visitor as IKittenGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStringLiteralExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class BooleanExprContext : ExprContext {
		public ExprContext left;
		public IToken op;
		public ExprContext right;
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public BooleanExprContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.EnterBooleanExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.ExitBooleanExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IKittenGrammarVisitor<TResult> typedVisitor = visitor as IKittenGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBooleanExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class FunctionCallExprContext : ExprContext {
		public ITerminalNode ID() { return GetToken(KittenGrammarParser.ID, 0); }
		public ExprListContext exprList() {
			return GetRuleContext<ExprListContext>(0);
		}
		public FunctionCallExprContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.EnterFunctionCallExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.ExitFunctionCallExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IKittenGrammarVisitor<TResult> typedVisitor = visitor as IKittenGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFunctionCallExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class BooleanLiteralExprContext : ExprContext {
		public ITerminalNode BooleanLiteral() { return GetToken(KittenGrammarParser.BooleanLiteral, 0); }
		public BooleanLiteralExprContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.EnterBooleanLiteralExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.ExitBooleanLiteralExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IKittenGrammarVisitor<TResult> typedVisitor = visitor as IKittenGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBooleanLiteralExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class BlockExprContext : ExprContext {
		public BlockLiteralContext blockLiteral() {
			return GetRuleContext<BlockLiteralContext>(0);
		}
		public BlockExprContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.EnterBlockExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.ExitBlockExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IKittenGrammarVisitor<TResult> typedVisitor = visitor as IKittenGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBlockExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ArithmaticExprContext : ExprContext {
		public ExprContext left;
		public IToken op;
		public ExprContext right;
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public ArithmaticExprContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.EnterArithmaticExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.ExitArithmaticExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IKittenGrammarVisitor<TResult> typedVisitor = visitor as IKittenGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitArithmaticExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ParenExprContext : ExprContext {
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ParenExprContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.EnterParenExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.ExitParenExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IKittenGrammarVisitor<TResult> typedVisitor = visitor as IKittenGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParenExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IdentifierExprContext : ExprContext {
		public ITerminalNode ID() { return GetToken(KittenGrammarParser.ID, 0); }
		public IdentifierExprContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.EnterIdentifierExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.ExitIdentifierExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IKittenGrammarVisitor<TResult> typedVisitor = visitor as IKittenGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIdentifierExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		return expr(0);
	}

	private ExprContext expr(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		ExprContext _localctx = new ExprContext(_ctx, _parentState);
		ExprContext _prevctx = _localctx;
		int _startState = 12;
		EnterRecursionRule(_localctx, 12, RULE_expr, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 68;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,3,_ctx) ) {
			case 1:
				{
				_localctx = new IdentifierExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;

				State = 51; Match(ID);
				}
				break;

			case 2:
				{
				_localctx = new IntegerLiteralExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 52; Match(IntegerLiteral);
				}
				break;

			case 3:
				{
				_localctx = new StringLiteralExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 53; Match(StringLiteral);
				}
				break;

			case 4:
				{
				_localctx = new BooleanLiteralExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 54; Match(BooleanLiteral);
				}
				break;

			case 5:
				{
				_localctx = new BlockExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 55; blockLiteral();
				}
				break;

			case 6:
				{
				_localctx = new ParenExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 56; Match(T__3);
				State = 57; expr(0);
				State = 58; Match(T__4);
				}
				break;

			case 7:
				{
				_localctx = new FunctionCallExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 60; Match(ID);
				State = 61; Match(T__3);
				State = 62; exprList();
				State = 63; Match(T__4);
				}
				break;

			case 8:
				{
				_localctx = new FunctionCallExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 65; Match(ID);
				State = 66; Match(T__3);
				State = 67; Match(T__4);
				}
				break;
			}
			_ctx.stop = _input.Lt(-1);
			State = 81;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,5,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 79;
					_errHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(_input,4,_ctx) ) {
					case 1:
						{
						_localctx = new ArithmaticExprContext(new ExprContext(_parentctx, _parentState));
						((ArithmaticExprContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 70;
						if (!(Precpred(_ctx, 5))) throw new FailedPredicateException(this, "Precpred(_ctx, 5)");
						State = 71;
						((ArithmaticExprContext)_localctx).op = _input.Lt(1);
						_la = _input.La(1);
						if ( !(_la==T__5 || _la==T__6) ) {
							((ArithmaticExprContext)_localctx).op = _errHandler.RecoverInline(this);
						} else {
							Consume();
						}
						State = 72; ((ArithmaticExprContext)_localctx).right = expr(6);
						}
						break;

					case 2:
						{
						_localctx = new ArithmaticExprContext(new ExprContext(_parentctx, _parentState));
						((ArithmaticExprContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 73;
						if (!(Precpred(_ctx, 4))) throw new FailedPredicateException(this, "Precpred(_ctx, 4)");
						State = 74;
						((ArithmaticExprContext)_localctx).op = _input.Lt(1);
						_la = _input.La(1);
						if ( !(_la==T__7 || _la==T__8) ) {
							((ArithmaticExprContext)_localctx).op = _errHandler.RecoverInline(this);
						} else {
							Consume();
						}
						State = 75; ((ArithmaticExprContext)_localctx).right = expr(5);
						}
						break;

					case 3:
						{
						_localctx = new BooleanExprContext(new ExprContext(_parentctx, _parentState));
						((BooleanExprContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 76;
						if (!(Precpred(_ctx, 3))) throw new FailedPredicateException(this, "Precpred(_ctx, 3)");
						State = 77;
						((BooleanExprContext)_localctx).op = _input.Lt(1);
						_la = _input.La(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__9) | (1L << T__10) | (1L << T__11) | (1L << T__12) | (1L << T__13) | (1L << T__14))) != 0)) ) {
							((BooleanExprContext)_localctx).op = _errHandler.RecoverInline(this);
						} else {
							Consume();
						}
						State = 78; ((BooleanExprContext)_localctx).right = expr(4);
						}
						break;
					}
					} 
				}
				State = 83;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,5,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class BlockLiteralContext : ParserRuleContext {
		public StatementListContext statementList() {
			return GetRuleContext<StatementListContext>(0);
		}
		public IdentifierListContext identifierList() {
			return GetRuleContext<IdentifierListContext>(0);
		}
		public BlockLiteralContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_blockLiteral; } }
		public override void EnterRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.EnterBlockLiteral(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.ExitBlockLiteral(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IKittenGrammarVisitor<TResult> typedVisitor = visitor as IKittenGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBlockLiteral(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public BlockLiteralContext blockLiteral() {
		BlockLiteralContext _localctx = new BlockLiteralContext(_ctx, State);
		EnterRule(_localctx, 14, RULE_blockLiteral);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 88;
			_la = _input.La(1);
			if (_la==T__15) {
				{
				State = 84; Match(T__15);
				State = 85; identifierList();
				State = 86; Match(T__16);
				}
			}

			State = 90; Match(T__17);
			State = 91; statementList();
			State = 92; Match(T__16);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprListContext : ParserRuleContext {
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public ExprListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_exprList; } }
		public override void EnterRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.EnterExprList(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.ExitExprList(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IKittenGrammarVisitor<TResult> typedVisitor = visitor as IKittenGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExprList(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprListContext exprList() {
		ExprListContext _localctx = new ExprListContext(_ctx, State);
		EnterRule(_localctx, 16, RULE_exprList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 94; expr(0);
			State = 99;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==T__18) {
				{
				{
				State = 95; Match(T__18);
				State = 96; expr(0);
				}
				}
				State = 101;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CompileUnitContext : ParserRuleContext {
		public StatementListContext statementList() {
			return GetRuleContext<StatementListContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(KittenGrammarParser.Eof, 0); }
		public CompileUnitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compileUnit; } }
		public override void EnterRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.EnterCompileUnit(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IKittenGrammarListener typedListener = listener as IKittenGrammarListener;
			if (typedListener != null) typedListener.ExitCompileUnit(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IKittenGrammarVisitor<TResult> typedVisitor = visitor as IKittenGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCompileUnit(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CompileUnitContext compileUnit() {
		CompileUnitContext _localctx = new CompileUnitContext(_ctx, State);
		EnterRule(_localctx, 18, RULE_compileUnit);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 102; statementList();
			State = 103; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 6: return expr_sempred((ExprContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expr_sempred(ExprContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(_ctx, 5);

		case 1: return Precpred(_ctx, 4);

		case 2: return Precpred(_ctx, 3);
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x1Al\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t"+
		"\t\x4\n\t\n\x4\v\t\v\x3\x2\x3\x2\x3\x2\x5\x2\x1A\n\x2\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\a\x6"+
		"*\n\x6\f\x6\xE\x6-\v\x6\x3\a\a\a\x30\n\a\f\a\xE\a\x33\v\a\x3\b\x3\b\x3"+
		"\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3"+
		"\b\x3\b\x5\bG\n\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\a\bR\n"+
		"\b\f\b\xE\bU\v\b\x3\t\x3\t\x3\t\x3\t\x5\t[\n\t\x3\t\x3\t\x3\t\x3\t\x3"+
		"\n\x3\n\x3\n\a\n\x64\n\n\f\n\xE\ng\v\n\x3\v\x3\v\x3\v\x3\v\x2\x2\x3\xE"+
		"\f\x2\x2\x4\x2\x6\x2\b\x2\n\x2\f\x2\xE\x2\x10\x2\x12\x2\x14\x2\x2\x5\x3"+
		"\x2\b\t\x3\x2\n\v\x3\x2\f\x11q\x2\x19\x3\x2\x2\x2\x4\x1B\x3\x2\x2\x2\x6"+
		" \x3\x2\x2\x2\b$\x3\x2\x2\x2\n+\x3\x2\x2\x2\f\x31\x3\x2\x2\x2\xE\x46\x3"+
		"\x2\x2\x2\x10Z\x3\x2\x2\x2\x12`\x3\x2\x2\x2\x14h\x3\x2\x2\x2\x16\x1A\x5"+
		"\x4\x3\x2\x17\x1A\x5\x6\x4\x2\x18\x1A\x5\b\x5\x2\x19\x16\x3\x2\x2\x2\x19"+
		"\x17\x3\x2\x2\x2\x19\x18\x3\x2\x2\x2\x1A\x3\x3\x2\x2\x2\x1B\x1C\a\x3\x2"+
		"\x2\x1C\x1D\a\x19\x2\x2\x1D\x1E\a\x4\x2\x2\x1E\x1F\x5\xE\b\x2\x1F\x5\x3"+
		"\x2\x2\x2 !\a\x19\x2\x2!\"\a\x4\x2\x2\"#\x5\xE\b\x2#\a\x3\x2\x2\x2$%\x5"+
		"\xE\b\x2%\t\x3\x2\x2\x2&\'\x5\x2\x2\x2\'(\a\x5\x2\x2(*\x3\x2\x2\x2)&\x3"+
		"\x2\x2\x2*-\x3\x2\x2\x2+)\x3\x2\x2\x2+,\x3\x2\x2\x2,\v\x3\x2\x2\x2-+\x3"+
		"\x2\x2\x2.\x30\a\x19\x2\x2/.\x3\x2\x2\x2\x30\x33\x3\x2\x2\x2\x31/\x3\x2"+
		"\x2\x2\x31\x32\x3\x2\x2\x2\x32\r\x3\x2\x2\x2\x33\x31\x3\x2\x2\x2\x34\x35"+
		"\b\b\x1\x2\x35G\a\x19\x2\x2\x36G\a\x16\x2\x2\x37G\a\x18\x2\x2\x38G\a\x17"+
		"\x2\x2\x39G\x5\x10\t\x2:;\a\x6\x2\x2;<\x5\xE\b\x2<=\a\a\x2\x2=G\x3\x2"+
		"\x2\x2>?\a\x19\x2\x2?@\a\x6\x2\x2@\x41\x5\x12\n\x2\x41\x42\a\a\x2\x2\x42"+
		"G\x3\x2\x2\x2\x43\x44\a\x19\x2\x2\x44\x45\a\x6\x2\x2\x45G\a\a\x2\x2\x46"+
		"\x34\x3\x2\x2\x2\x46\x36\x3\x2\x2\x2\x46\x37\x3\x2\x2\x2\x46\x38\x3\x2"+
		"\x2\x2\x46\x39\x3\x2\x2\x2\x46:\x3\x2\x2\x2\x46>\x3\x2\x2\x2\x46\x43\x3"+
		"\x2\x2\x2GS\x3\x2\x2\x2HI\f\a\x2\x2IJ\t\x2\x2\x2JR\x5\xE\b\bKL\f\x6\x2"+
		"\x2LM\t\x3\x2\x2MR\x5\xE\b\aNO\f\x5\x2\x2OP\t\x4\x2\x2PR\x5\xE\b\x6QH"+
		"\x3\x2\x2\x2QK\x3\x2\x2\x2QN\x3\x2\x2\x2RU\x3\x2\x2\x2SQ\x3\x2\x2\x2S"+
		"T\x3\x2\x2\x2T\xF\x3\x2\x2\x2US\x3\x2\x2\x2VW\a\x12\x2\x2WX\x5\f\a\x2"+
		"XY\a\x13\x2\x2Y[\x3\x2\x2\x2ZV\x3\x2\x2\x2Z[\x3\x2\x2\x2[\\\x3\x2\x2\x2"+
		"\\]\a\x14\x2\x2]^\x5\n\x6\x2^_\a\x13\x2\x2_\x11\x3\x2\x2\x2`\x65\x5\xE"+
		"\b\x2\x61\x62\a\x15\x2\x2\x62\x64\x5\xE\b\x2\x63\x61\x3\x2\x2\x2\x64g"+
		"\x3\x2\x2\x2\x65\x63\x3\x2\x2\x2\x65\x66\x3\x2\x2\x2\x66\x13\x3\x2\x2"+
		"\x2g\x65\x3\x2\x2\x2hi\x5\n\x6\x2ij\a\x2\x2\x3j\x15\x3\x2\x2\x2\n\x19"+
		"+\x31\x46QSZ\x65";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Kitten