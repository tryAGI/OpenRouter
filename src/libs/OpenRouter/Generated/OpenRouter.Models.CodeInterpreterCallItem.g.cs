#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A code interpreter execution call with outputs<br/>
    /// Example: {"code":"print(\u0022Hello, World!\u0022)","container_id":"container-xyz789","id":"code-abc123","outputs":[{"logs":"Hello, World!","type":"logs"}],"status":"completed","type":"code_interpreter_call"}
    /// </summary>
    public readonly partial struct CodeInterpreterCallItem : global::System.IEquatable<CodeInterpreterCallItem>
    {
        /// <summary>
        /// Example: {"code":"print(\u0022hello\u0022)","id":"ci_abc123","outputs":[{"logs":"hello\n","type":"logs"}],"status":"completed","type":"code_interpreter_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemCodeInterpreterCall? Output { get; init; }
#else
        public global::OpenRouter.OutputItemCodeInterpreterCall? Output { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Output))]
#endif
        public bool IsOutput => Output != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemCodeInterpreterCall? value)
        {
            value = Output;
            return IsOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCodeInterpreterCall PickOutput() => Output is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Output' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? CodeInterpreterCallItemVariant2 { get; init; }
#else
        public object? CodeInterpreterCallItemVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCallItemVariant2))]
#endif
        public bool IsCodeInterpreterCallItemVariant2 => CodeInterpreterCallItemVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeInterpreterCallItemVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = CodeInterpreterCallItemVariant2;
            return IsCodeInterpreterCallItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickCodeInterpreterCallItemVariant2() => CodeInterpreterCallItemVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeInterpreterCallItemVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CodeInterpreterCallItem(global::OpenRouter.OutputItemCodeInterpreterCall value) => new CodeInterpreterCallItem((global::OpenRouter.OutputItemCodeInterpreterCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemCodeInterpreterCall?(CodeInterpreterCallItem @this) => @this.Output;

        /// <summary>
        ///
        /// </summary>
        public CodeInterpreterCallItem(global::OpenRouter.OutputItemCodeInterpreterCall? value)
        {
            Output = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CodeInterpreterCallItem FromOutput(global::OpenRouter.OutputItemCodeInterpreterCall? value) => new CodeInterpreterCallItem(value);

        /// <summary>
        ///
        /// </summary>
        public CodeInterpreterCallItem(
            global::OpenRouter.OutputItemCodeInterpreterCall? output,
            object? codeInterpreterCallItemVariant2
            )
        {
            Output = output;
            CodeInterpreterCallItemVariant2 = codeInterpreterCallItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CodeInterpreterCallItemVariant2 as object ??
            Output as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Output?.ToString() ??
            CodeInterpreterCallItemVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOutput && IsCodeInterpreterCallItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputItemCodeInterpreterCall, TResult>? output = null,
            global::System.Func<object, TResult>? codeInterpreterCallItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Output is { } __value0 && output != null)
            {
                return output(__value0);
            }
            else if (CodeInterpreterCallItemVariant2 is { } __value1 && codeInterpreterCallItemVariant2 != null)
            {
                return codeInterpreterCallItemVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputItemCodeInterpreterCall>? output = null,

            global::System.Action<object>? codeInterpreterCallItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Output is { } __value0)
            {
                output?.Invoke(__value0);
            }
            else if (CodeInterpreterCallItemVariant2 is { } __value1)
            {
                codeInterpreterCallItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputItemCodeInterpreterCall>? output = null,
            global::System.Action<object>? codeInterpreterCallItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Output is { } __value0)
            {
                output?.Invoke(__value0);
            }
            else if (CodeInterpreterCallItemVariant2 is { } __value1)
            {
                codeInterpreterCallItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Output,
                typeof(global::OpenRouter.OutputItemCodeInterpreterCall),
                CodeInterpreterCallItemVariant2,
                typeof(object),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(CodeInterpreterCallItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemCodeInterpreterCall?>.Default.Equals(Output, other.Output) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(CodeInterpreterCallItemVariant2, other.CodeInterpreterCallItemVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CodeInterpreterCallItem obj1, CodeInterpreterCallItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CodeInterpreterCallItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CodeInterpreterCallItem obj1, CodeInterpreterCallItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CodeInterpreterCallItem o && Equals(o);
        }
    }
}
