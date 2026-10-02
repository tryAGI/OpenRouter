#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The output from a custom (freeform-grammar) tool call execution. Mirrors `function_call_output` but is matched to a `custom_tool_call` rather than a `function_call`.<br/>
    /// Example: {"call_id":"call-abc123","id":"ctco-abc123","output":"patch applied successfully","type":"custom_tool_call_output"}
    /// </summary>
    public readonly partial struct CustomToolCallOutputItem : global::System.IEquatable<CustomToolCallOutputItem>
    {
        /// <summary>
        /// Example: {"call_id":"call-abc123","output":"patch applied successfully","type":"custom_tool_call_output"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponseCustomToolCallOutput? OpenAIResponse { get; init; }
#else
        public global::OpenRouter.OpenAIResponseCustomToolCallOutput? OpenAIResponse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIResponse))]
#endif
        public bool IsOpenAIResponse => OpenAIResponse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenAIResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenAIResponseCustomToolCallOutput? value)
        {
            value = OpenAIResponse;
            return IsOpenAIResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseCustomToolCallOutput PickOpenAIResponse() => OpenAIResponse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponse' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CustomToolCallOutputItemVariant2? CustomToolCallOutputItemVariant2 { get; init; }
#else
        public global::OpenRouter.CustomToolCallOutputItemVariant2? CustomToolCallOutputItemVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCallOutputItemVariant2))]
#endif
        public bool IsCustomToolCallOutputItemVariant2 => CustomToolCallOutputItemVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustomToolCallOutputItemVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CustomToolCallOutputItemVariant2? value)
        {
            value = CustomToolCallOutputItemVariant2;
            return IsCustomToolCallOutputItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallOutputItemVariant2 PickCustomToolCallOutputItemVariant2() => CustomToolCallOutputItemVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCallOutputItemVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CustomToolCallOutputItem(global::OpenRouter.OpenAIResponseCustomToolCallOutput value) => new CustomToolCallOutputItem((global::OpenRouter.OpenAIResponseCustomToolCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponseCustomToolCallOutput?(CustomToolCallOutputItem @this) => @this.OpenAIResponse;

        /// <summary>
        ///
        /// </summary>
        public CustomToolCallOutputItem(global::OpenRouter.OpenAIResponseCustomToolCallOutput? value)
        {
            OpenAIResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CustomToolCallOutputItem FromOpenAIResponse(global::OpenRouter.OpenAIResponseCustomToolCallOutput? value) => new CustomToolCallOutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CustomToolCallOutputItem(global::OpenRouter.CustomToolCallOutputItemVariant2 value) => new CustomToolCallOutputItem((global::OpenRouter.CustomToolCallOutputItemVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.CustomToolCallOutputItemVariant2?(CustomToolCallOutputItem @this) => @this.CustomToolCallOutputItemVariant2;

        /// <summary>
        ///
        /// </summary>
        public CustomToolCallOutputItem(global::OpenRouter.CustomToolCallOutputItemVariant2? value)
        {
            CustomToolCallOutputItemVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CustomToolCallOutputItem FromCustomToolCallOutputItemVariant2(global::OpenRouter.CustomToolCallOutputItemVariant2? value) => new CustomToolCallOutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public CustomToolCallOutputItem(
            global::OpenRouter.OpenAIResponseCustomToolCallOutput? openAIResponse,
            global::OpenRouter.CustomToolCallOutputItemVariant2? customToolCallOutputItemVariant2
            )
        {
            OpenAIResponse = openAIResponse;
            CustomToolCallOutputItemVariant2 = customToolCallOutputItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CustomToolCallOutputItemVariant2 as object ??
            OpenAIResponse as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OpenAIResponse?.ToString() ??
            CustomToolCallOutputItemVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIResponse && IsCustomToolCallOutputItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenAIResponseCustomToolCallOutput, TResult>? openAIResponse = null,
            global::System.Func<global::OpenRouter.CustomToolCallOutputItemVariant2, TResult>? customToolCallOutputItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenAIResponse is { } __value0 && openAIResponse != null)
            {
                return openAIResponse(__value0);
            }
            else if (CustomToolCallOutputItemVariant2 is { } __value1 && customToolCallOutputItemVariant2 != null)
            {
                return customToolCallOutputItemVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenAIResponseCustomToolCallOutput>? openAIResponse = null,

            global::System.Action<global::OpenRouter.CustomToolCallOutputItemVariant2>? customToolCallOutputItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenAIResponse is { } __value0)
            {
                openAIResponse?.Invoke(__value0);
            }
            else if (CustomToolCallOutputItemVariant2 is { } __value1)
            {
                customToolCallOutputItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OpenAIResponseCustomToolCallOutput>? openAIResponse = null,
            global::System.Action<global::OpenRouter.CustomToolCallOutputItemVariant2>? customToolCallOutputItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenAIResponse is { } __value0)
            {
                openAIResponse?.Invoke(__value0);
            }
            else if (CustomToolCallOutputItemVariant2 is { } __value1)
            {
                customToolCallOutputItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenAIResponse,
                typeof(global::OpenRouter.OpenAIResponseCustomToolCallOutput),
                CustomToolCallOutputItemVariant2,
                typeof(global::OpenRouter.CustomToolCallOutputItemVariant2),
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
        public bool Equals(CustomToolCallOutputItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponseCustomToolCallOutput?>.Default.Equals(OpenAIResponse, other.OpenAIResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CustomToolCallOutputItemVariant2?>.Default.Equals(CustomToolCallOutputItemVariant2, other.CustomToolCallOutputItemVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CustomToolCallOutputItem obj1, CustomToolCallOutputItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CustomToolCallOutputItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CustomToolCallOutputItem obj1, CustomToolCallOutputItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CustomToolCallOutputItem o && Equals(o);
        }
    }
}
