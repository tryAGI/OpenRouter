#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Response format configuration
    /// </summary>
    public readonly partial struct ChatRequestResponseFormat : global::System.IEquatable<ChatRequestResponseFormat>
    {
        /// <summary>
        /// Custom grammar response format
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestResponseFormatVariant1? Grammar { get; init; }
#else
        public global::OpenRouter.ChatRequestResponseFormatVariant1? Grammar { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Grammar))]
#endif
        public bool IsGrammar => Grammar != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGrammar(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatRequestResponseFormatVariant1? value)
        {
            value = Grammar;
            return IsGrammar;
        }

        /// <summary>
        /// JSON object response format
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestResponseFormatVariant2? JsonObject { get; init; }
#else
        public global::OpenRouter.ChatRequestResponseFormatVariant2? JsonObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonObject))]
#endif
        public bool IsJsonObject => JsonObject != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickJsonObject(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatRequestResponseFormatVariant2? value)
        {
            value = JsonObject;
            return IsJsonObject;
        }

        /// <summary>
        /// JSON Schema response format for structured outputs
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestResponseFormatVariant3? JsonSchema { get; init; }
#else
        public global::OpenRouter.ChatRequestResponseFormatVariant3? JsonSchema { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonSchema))]
#endif
        public bool IsJsonSchema => JsonSchema != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickJsonSchema(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatRequestResponseFormatVariant3? value)
        {
            value = JsonSchema;
            return IsJsonSchema;
        }

        /// <summary>
        /// Python code response format
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestResponseFormatVariant4? Python { get; init; }
#else
        public global::OpenRouter.ChatRequestResponseFormatVariant4? Python { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Python))]
#endif
        public bool IsPython => Python != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPython(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatRequestResponseFormatVariant4? value)
        {
            value = Python;
            return IsPython;
        }

        /// <summary>
        /// Default text response format
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestResponseFormatVariant5? Text { get; init; }
#else
        public global::OpenRouter.ChatRequestResponseFormatVariant5? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatRequestResponseFormatVariant5? value)
        {
            value = Text;
            return IsText;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestResponseFormat(global::OpenRouter.ChatRequestResponseFormatVariant1 value) => new ChatRequestResponseFormat((global::OpenRouter.ChatRequestResponseFormatVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestResponseFormatVariant1?(ChatRequestResponseFormat @this) => @this.Grammar;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestResponseFormat(global::OpenRouter.ChatRequestResponseFormatVariant1? value)
        {
            Grammar = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestResponseFormat(global::OpenRouter.ChatRequestResponseFormatVariant2 value) => new ChatRequestResponseFormat((global::OpenRouter.ChatRequestResponseFormatVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestResponseFormatVariant2?(ChatRequestResponseFormat @this) => @this.JsonObject;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestResponseFormat(global::OpenRouter.ChatRequestResponseFormatVariant2? value)
        {
            JsonObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestResponseFormat(global::OpenRouter.ChatRequestResponseFormatVariant3 value) => new ChatRequestResponseFormat((global::OpenRouter.ChatRequestResponseFormatVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestResponseFormatVariant3?(ChatRequestResponseFormat @this) => @this.JsonSchema;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestResponseFormat(global::OpenRouter.ChatRequestResponseFormatVariant3? value)
        {
            JsonSchema = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestResponseFormat(global::OpenRouter.ChatRequestResponseFormatVariant4 value) => new ChatRequestResponseFormat((global::OpenRouter.ChatRequestResponseFormatVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestResponseFormatVariant4?(ChatRequestResponseFormat @this) => @this.Python;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestResponseFormat(global::OpenRouter.ChatRequestResponseFormatVariant4? value)
        {
            Python = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestResponseFormat(global::OpenRouter.ChatRequestResponseFormatVariant5 value) => new ChatRequestResponseFormat((global::OpenRouter.ChatRequestResponseFormatVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestResponseFormatVariant5?(ChatRequestResponseFormat @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestResponseFormat(global::OpenRouter.ChatRequestResponseFormatVariant5? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestResponseFormat(
            global::OpenRouter.ChatRequestResponseFormatVariant1? grammar,
            global::OpenRouter.ChatRequestResponseFormatVariant2? jsonObject,
            global::OpenRouter.ChatRequestResponseFormatVariant3? jsonSchema,
            global::OpenRouter.ChatRequestResponseFormatVariant4? python,
            global::OpenRouter.ChatRequestResponseFormatVariant5? text
            )
        {
            Grammar = grammar;
            JsonObject = jsonObject;
            JsonSchema = jsonSchema;
            Python = python;
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object ??
            Python as object ??
            JsonSchema as object ??
            JsonObject as object ??
            Grammar as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Grammar?.ToString() ??
            JsonObject?.ToString() ??
            JsonSchema?.ToString() ??
            Python?.ToString() ??
            Text?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGrammar && !IsJsonObject && !IsJsonSchema && !IsPython && !IsText || !IsGrammar && IsJsonObject && !IsJsonSchema && !IsPython && !IsText || !IsGrammar && !IsJsonObject && IsJsonSchema && !IsPython && !IsText || !IsGrammar && !IsJsonObject && !IsJsonSchema && IsPython && !IsText || !IsGrammar && !IsJsonObject && !IsJsonSchema && !IsPython && IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ChatRequestResponseFormatVariant1, TResult>? grammar = null,
            global::System.Func<global::OpenRouter.ChatRequestResponseFormatVariant2, TResult>? jsonObject = null,
            global::System.Func<global::OpenRouter.ChatRequestResponseFormatVariant3, TResult>? jsonSchema = null,
            global::System.Func<global::OpenRouter.ChatRequestResponseFormatVariant4, TResult>? python = null,
            global::System.Func<global::OpenRouter.ChatRequestResponseFormatVariant5, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGrammar && grammar != null)
            {
                return grammar(Grammar!);
            }
            else if (IsJsonObject && jsonObject != null)
            {
                return jsonObject(JsonObject!);
            }
            else if (IsJsonSchema && jsonSchema != null)
            {
                return jsonSchema(JsonSchema!);
            }
            else if (IsPython && python != null)
            {
                return python(Python!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ChatRequestResponseFormatVariant1>? grammar = null,

            global::System.Action<global::OpenRouter.ChatRequestResponseFormatVariant2>? jsonObject = null,

            global::System.Action<global::OpenRouter.ChatRequestResponseFormatVariant3>? jsonSchema = null,

            global::System.Action<global::OpenRouter.ChatRequestResponseFormatVariant4>? python = null,

            global::System.Action<global::OpenRouter.ChatRequestResponseFormatVariant5>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGrammar)
            {
                grammar?.Invoke(Grammar!);
            }
            else if (IsJsonObject)
            {
                jsonObject?.Invoke(JsonObject!);
            }
            else if (IsJsonSchema)
            {
                jsonSchema?.Invoke(JsonSchema!);
            }
            else if (IsPython)
            {
                python?.Invoke(Python!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ChatRequestResponseFormatVariant1>? grammar = null,
            global::System.Action<global::OpenRouter.ChatRequestResponseFormatVariant2>? jsonObject = null,
            global::System.Action<global::OpenRouter.ChatRequestResponseFormatVariant3>? jsonSchema = null,
            global::System.Action<global::OpenRouter.ChatRequestResponseFormatVariant4>? python = null,
            global::System.Action<global::OpenRouter.ChatRequestResponseFormatVariant5>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGrammar)
            {
                grammar?.Invoke(Grammar!);
            }
            else if (IsJsonObject)
            {
                jsonObject?.Invoke(JsonObject!);
            }
            else if (IsJsonSchema)
            {
                jsonSchema?.Invoke(JsonSchema!);
            }
            else if (IsPython)
            {
                python?.Invoke(Python!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Grammar,
                typeof(global::OpenRouter.ChatRequestResponseFormatVariant1),
                JsonObject,
                typeof(global::OpenRouter.ChatRequestResponseFormatVariant2),
                JsonSchema,
                typeof(global::OpenRouter.ChatRequestResponseFormatVariant3),
                Python,
                typeof(global::OpenRouter.ChatRequestResponseFormatVariant4),
                Text,
                typeof(global::OpenRouter.ChatRequestResponseFormatVariant5),
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
        public bool Equals(ChatRequestResponseFormat other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestResponseFormatVariant1?>.Default.Equals(Grammar, other.Grammar) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestResponseFormatVariant2?>.Default.Equals(JsonObject, other.JsonObject) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestResponseFormatVariant3?>.Default.Equals(JsonSchema, other.JsonSchema) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestResponseFormatVariant4?>.Default.Equals(Python, other.Python) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestResponseFormatVariant5?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatRequestResponseFormat obj1, ChatRequestResponseFormat obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatRequestResponseFormat>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatRequestResponseFormat obj1, ChatRequestResponseFormat obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatRequestResponseFormat o && Equals(o);
        }
    }
}
