using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace Janyee.Utilty {
    public class Range : IEnumerable<int> {
        private int _start;
        private int _end;
        private Script<IncrementorBase> _script;
        private StringBuilder _tab;
        private const string TAB = "    ";

        private string CodeGen(int index, int end) {
            return $"System.Func<{typeof(Range).Namespace}.IncrementorBase> Continue = () => new {typeof(Range).Namespace}.Incrementor() {{\n" +
                   $"{TAB}Value = {index},\n" +
                   $"{TAB}Continue = {CodeGen2(index + 1, end)}\n" +
                   $"}};";
        }

        private string CodeGen2(int index, int end, int tabIndent = 1) {
            if (index <= end) {
                return $"() => new {typeof(Range).Namespace}.Incrementor() {{\n" +
                       $"{GetTabIndent(tabIndent)}Value = {(index == 0 ? string.Empty : index.ToString())},\n" +
                       $"{GetTabIndent(tabIndent)}Continue = {CodeGen2(index + 1, end, tabIndent + 1)}\n" +
                       $"{GetTabIndent(tabIndent - 1)}}}\n";
            }
            else {
                return "null";
            }
        }

        private string GetTabIndent(int level) {
            for (int i = 0; i < level; i++) {
                this._tab.Append(TAB);
            }
            return this._tab.ToString();
        }

        public Range(int start, int end) {
            if (start <= end) {
                this._start = start;
                this._end = end;
                this._tab = new StringBuilder(TAB);
                string code = CodeGen(start, end);
                System.Diagnostics.Debug.WriteLine($"code.Length = {code.Length}");
                this._script = CSharpScript.Create<IncrementorBase>(code, ScriptOptions.Default.WithReferences(
                                                                            typeof(IncrementorBase).Assembly,
                                                                            typeof(Func<IncrementorBase>).Assembly
                                                                    )).
                                            ContinueWith<IncrementorBase>("Continue()", ScriptOptions.Default.WithReferences(
                                                                            typeof(IncrementorBase).Assembly,
                                                                            typeof(Func<IncrementorBase>).Assembly));
            }
            else {
                throw new ArgumentOutOfRangeException($"The start large than end. start = {start}, end = {end}.");
            }
        }

        public IncrementorBase GetIncrementor() => this._script.RunAsync().Result.ReturnValue;

        IEnumerator<int> IEnumerable<int>.GetEnumerator() {
            for (IncrementorBase i = this.GetIncrementor(); i != null; i = i.Continue?.Invoke()) {
                yield return i.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() {
            for (IncrementorBase i = this.GetIncrementor(); i != null; i = i.Continue?.Invoke()) {
                yield return i.Value;
            }
        }
    }

    public abstract class IncrementorBase {
        public int Value { get; set; }
        public Func<IncrementorBase> Continue { get; set; }
    }

    public class Incrementor : IncrementorBase {
        public Incrementor() { }
        public Incrementor(int seed) => base.Value = seed;
    }
}
