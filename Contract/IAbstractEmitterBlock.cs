﻿using System;
namespace Bridge.Contract
{
    public interface IAbstractEmitterBlock
    {
        string AddLocal(string name, ICSharpCode.NRefactory.CSharp.AstType type);
        void AddLocals(System.Collections.Generic.IEnumerable<ICSharpCode.NRefactory.CSharp.ParameterDeclaration> declarations, ICSharpCode.NRefactory.CSharp.AstNode statement);
        void BeginBlock();
        System.Collections.Generic.Dictionary<string, string> BuildLocalsMap();
        void ClearLocalsMap(System.Collections.Generic.Dictionary<string, string> prevMap = null);
        System.Collections.Generic.Dictionary<string, string> BuildLocalsNamesMap();
        void ClearLocalsNamesMap(System.Collections.Generic.Dictionary<string, string> prevMap = null);
        void Emit();
        void EmitBlockOrIndentedLine(ICSharpCode.NRefactory.CSharp.AstNode node);
        Bridge.Contract.IEmitter Emitter { get; set; }
        void EndBlock();
        void EnsureComma(bool newLine = true);
        int GetNumberOfEmptyLinesAtEnd();
        void Indent();
        bool IsOnlyWhitespaceOnPenultimateLine(bool lastTwoLines = true);
        System.Text.StringBuilder NewWriter();
        bool NoValueableSiblings(ICSharpCode.NRefactory.CSharp.AstNode node);
        void Outdent();
        void PopLocals();
        string PopWriter(bool preventWrite = false);
        void PushLocals();
        void PushWriter(string format);
        void RemovePenultimateEmptyLines(bool withLast = false);
        void ResetLocals();
        bool RestoreWriter(IWriterInfo writer);
        IWriterInfo SaveWriter();
        void Write(params object[] values);
        void Write(object value);
        void WriteCatch();
        void WriteCloseBrace();
        void WriteCloseBrace(bool addSpace);
        void WriteCloseBracket();
        void WriteCloseBracket(bool addSpace);
        void WriteCloseParentheses();
        void WriteCloseParentheses(bool addSpace);
        void WriteColon();
        void WriteComma();
        void WriteComma(bool newLine);
        void WriteDo();
        void WriteDot();
        void WriteElse();
        void WriteFinally();
        void WriteFor();
        void WriteFunction();
        void WriteIf();
        void WriteIndent();
        string WriteIndentToString(string value);
        void WriteNew();
        void WriteNewLine();
        void WriteOpenBrace();
        void WriteOpenBrace(bool addSpace);
        void WriteOpenBracket();
        void WriteOpenBracket(bool addSpace);
        void WriteOpenCloseBrace();
        void WriteOpenCloseParentheses();
        void WriteOpenCloseParentheses(bool addSpace);
        void WriteOpenParentheses();
        void WriteOpenParentheses(bool addSpace);
        void WriteReturn(bool addSpace);
        void WriteScript(object value);
        void WriteSemiColon();
        void WriteSemiColon(bool newLine);
        void WriteSpace();
        void WriteSpace(bool addSpace);
        void WriteSwitch();
        void WriteThis();
        void WriteThrow();
        void WriteTry();
        void WriteVar(bool ignoreAsync = false);
        void WriteWhile();
    }
}
