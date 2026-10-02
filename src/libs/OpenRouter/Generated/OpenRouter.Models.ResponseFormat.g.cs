#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Response format configuration<br/>
    /// Example: {"type":"json_object"}
    /// </summary>
    public readonly partial struct ResponseFormat : global::System.IEquatable<ResponseFormat>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestResponseFormatDiscriminatorType? Type { get; }

        /// <summary>
        /// Default text response format<br/>
        /// Example: {"type":"text"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatFormatTextConfig? Text { get; init; }
#else
        public global::OpenRouter.ChatFormatTextConfig? Text { get; }
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
            out global::OpenRouter.ChatFormatTextConfig? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatTextConfig PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// JSON object response format<br/>
        /// Example: {"type":"json_object"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatFormatJsonObjectConfig? JsonObject { get; init; }
#else
        public global::OpenRouter.ChatFormatJsonObjectConfig? JsonObject { get; }
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
            out global::OpenRouter.ChatFormatJsonObjectConfig? value)
        {
            value = JsonObject;
            return IsJsonObject;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatJsonObjectConfig PickJsonObject() => JsonObject is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonObject' but the value was {ToString()}.");

        /// <summary>
        /// JSON Schema response format for structured outputs<br/>
        /// Example: {"json_schema":{"name":"math_response","schema":{"properties":{"answer":{"type":"number"}},"required":["answer"],"type":"object"}},"type":"json_schema"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatFormatJsonSchemaConfig? JsonSchema { get; init; }
#else
        public global::OpenRouter.ChatFormatJsonSchemaConfig? JsonSchema { get; }
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
            out global::OpenRouter.ChatFormatJsonSchemaConfig? value)
        {
            value = JsonSchema;
            return IsJsonSchema;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatJsonSchemaConfig PickJsonSchema() => JsonSchema is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonSchema' but the value was {ToString()}.");

        /// <summary>
        /// Custom grammar response format<br/>
        /// Example: {"grammar":"root ::= \u0022yes\u0022 | \u0022no\u0022","type":"grammar"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatFormatGrammarConfig? Grammar { get; init; }
#else
        public global::OpenRouter.ChatFormatGrammarConfig? Grammar { get; }
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
            out global::OpenRouter.ChatFormatGrammarConfig? value)
        {
            value = Grammar;
            return IsGrammar;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatGrammarConfig PickGrammar() => Grammar is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Grammar' but the value was {ToString()}.");

        /// <summary>
        /// Python code response format<br/>
        /// Example: {"type":"python"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatFormatPythonConfig? Python { get; init; }
#else
        public global::OpenRouter.ChatFormatPythonConfig? Python { get; }
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
            out global::OpenRouter.ChatFormatPythonConfig? value)
        {
            value = Python;
            return IsPython;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatPythonConfig PickPython() => Python is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Python' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseFormat(global::OpenRouter.ChatFormatTextConfig value) => new ResponseFormat((global::OpenRouter.ChatFormatTextConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatFormatTextConfig?(ResponseFormat @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public ResponseFormat(global::OpenRouter.ChatFormatTextConfig? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseFormat FromText(global::OpenRouter.ChatFormatTextConfig? value) => new ResponseFormat(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseFormat(global::OpenRouter.ChatFormatJsonObjectConfig value) => new ResponseFormat((global::OpenRouter.ChatFormatJsonObjectConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatFormatJsonObjectConfig?(ResponseFormat @this) => @this.JsonObject;

        /// <summary>
        ///
        /// </summary>
        public ResponseFormat(global::OpenRouter.ChatFormatJsonObjectConfig? value)
        {
            JsonObject = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseFormat FromJsonObject(global::OpenRouter.ChatFormatJsonObjectConfig? value) => new ResponseFormat(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseFormat(global::OpenRouter.ChatFormatJsonSchemaConfig value) => new ResponseFormat((global::OpenRouter.ChatFormatJsonSchemaConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatFormatJsonSchemaConfig?(ResponseFormat @this) => @this.JsonSchema;

        /// <summary>
        ///
        /// </summary>
        public ResponseFormat(global::OpenRouter.ChatFormatJsonSchemaConfig? value)
        {
            JsonSchema = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseFormat FromJsonSchema(global::OpenRouter.ChatFormatJsonSchemaConfig? value) => new ResponseFormat(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseFormat(global::OpenRouter.ChatFormatGrammarConfig value) => new ResponseFormat((global::OpenRouter.ChatFormatGrammarConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatFormatGrammarConfig?(ResponseFormat @this) => @this.Grammar;

        /// <summary>
        ///
        /// </summary>
        public ResponseFormat(global::OpenRouter.ChatFormatGrammarConfig? value)
        {
            Grammar = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseFormat FromGrammar(global::OpenRouter.ChatFormatGrammarConfig? value) => new ResponseFormat(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseFormat(global::OpenRouter.ChatFormatPythonConfig value) => new ResponseFormat((global::OpenRouter.ChatFormatPythonConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatFormatPythonConfig?(ResponseFormat @this) => @this.Python;

        /// <summary>
        ///
        /// </summary>
        public ResponseFormat(global::OpenRouter.ChatFormatPythonConfig? value)
        {
            Python = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseFormat FromPython(global::OpenRouter.ChatFormatPythonConfig? value) => new ResponseFormat(value);

        /// <summary>
        ///
        /// </summary>
        public ResponseFormat(
            global::OpenRouter.ChatRequestResponseFormatDiscriminatorType? type,
            global::OpenRouter.ChatFormatTextConfig? text,
            global::OpenRouter.ChatFormatJsonObjectConfig? jsonObject,
            global::OpenRouter.ChatFormatJsonSchemaConfig? jsonSchema,
            global::OpenRouter.ChatFormatGrammarConfig? grammar,
            global::OpenRouter.ChatFormatPythonConfig? python
            )
        {
            Type = type;

            Text = text;
            JsonObject = jsonObject;
            JsonSchema = jsonSchema;
            Grammar = grammar;
            Python = python;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Python as object ??
            Grammar as object ??
            JsonSchema as object ??
            JsonObject as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            JsonObject?.ToString() ??
            JsonSchema?.ToString() ??
            Grammar?.ToString() ??
            Python?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsJsonObject && !IsJsonSchema && !IsGrammar && !IsPython || !IsText && IsJsonObject && !IsJsonSchema && !IsGrammar && !IsPython || !IsText && !IsJsonObject && IsJsonSchema && !IsGrammar && !IsPython || !IsText && !IsJsonObject && !IsJsonSchema && IsGrammar && !IsPython || !IsText && !IsJsonObject && !IsJsonSchema && !IsGrammar && IsPython;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ChatFormatTextConfig, TResult>? text = null,
            global::System.Func<global::OpenRouter.ChatFormatJsonObjectConfig, TResult>? jsonObject = null,
            global::System.Func<global::OpenRouter.ChatFormatJsonSchemaConfig, TResult>? jsonSchema = null,
            global::System.Func<global::OpenRouter.ChatFormatGrammarConfig, TResult>? grammar = null,
            global::System.Func<global::OpenRouter.ChatFormatPythonConfig, TResult>? python = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0 && text != null)
            {
                return text(__value0);
            }
            else if (JsonObject is { } __value1 && jsonObject != null)
            {
                return jsonObject(__value1);
            }
            else if (JsonSchema is { } __value2 && jsonSchema != null)
            {
                return jsonSchema(__value2);
            }
            else if (Grammar is { } __value3 && grammar != null)
            {
                return grammar(__value3);
            }
            else if (Python is { } __value4 && python != null)
            {
                return python(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ChatFormatTextConfig>? text = null,

            global::System.Action<global::OpenRouter.ChatFormatJsonObjectConfig>? jsonObject = null,

            global::System.Action<global::OpenRouter.ChatFormatJsonSchemaConfig>? jsonSchema = null,

            global::System.Action<global::OpenRouter.ChatFormatGrammarConfig>? grammar = null,

            global::System.Action<global::OpenRouter.ChatFormatPythonConfig>? python = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (JsonObject is { } __value1)
            {
                jsonObject?.Invoke(__value1);
            }
            else if (JsonSchema is { } __value2)
            {
                jsonSchema?.Invoke(__value2);
            }
            else if (Grammar is { } __value3)
            {
                grammar?.Invoke(__value3);
            }
            else if (Python is { } __value4)
            {
                python?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ChatFormatTextConfig>? text = null,
            global::System.Action<global::OpenRouter.ChatFormatJsonObjectConfig>? jsonObject = null,
            global::System.Action<global::OpenRouter.ChatFormatJsonSchemaConfig>? jsonSchema = null,
            global::System.Action<global::OpenRouter.ChatFormatGrammarConfig>? grammar = null,
            global::System.Action<global::OpenRouter.ChatFormatPythonConfig>? python = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (JsonObject is { } __value1)
            {
                jsonObject?.Invoke(__value1);
            }
            else if (JsonSchema is { } __value2)
            {
                jsonSchema?.Invoke(__value2);
            }
            else if (Grammar is { } __value3)
            {
                grammar?.Invoke(__value3);
            }
            else if (Python is { } __value4)
            {
                python?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::OpenRouter.ChatFormatTextConfig),
                JsonObject,
                typeof(global::OpenRouter.ChatFormatJsonObjectConfig),
                JsonSchema,
                typeof(global::OpenRouter.ChatFormatJsonSchemaConfig),
                Grammar,
                typeof(global::OpenRouter.ChatFormatGrammarConfig),
                Python,
                typeof(global::OpenRouter.ChatFormatPythonConfig),
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
        public bool Equals(ResponseFormat other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatFormatTextConfig?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatFormatJsonObjectConfig?>.Default.Equals(JsonObject, other.JsonObject) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatFormatJsonSchemaConfig?>.Default.Equals(JsonSchema, other.JsonSchema) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatFormatGrammarConfig?>.Default.Equals(Grammar, other.Grammar) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatFormatPythonConfig?>.Default.Equals(Python, other.Python)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponseFormat obj1, ResponseFormat obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseFormat>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponseFormat obj1, ResponseFormat obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseFormat o && Equals(o);
        }
    }
}
