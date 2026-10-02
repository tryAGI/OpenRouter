#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: [{"content":"What is the weather today?","role":"user"}]
    /// </summary>
    public readonly partial struct BaseInputs : global::System.IEquatable<BaseInputs>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BaseInputsVariant1 { get; init; }
#else
        public string? BaseInputsVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseInputsVariant1))]
#endif
        public bool IsBaseInputsVariant1 => BaseInputsVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBaseInputsVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BaseInputsVariant1;
            return IsBaseInputsVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBaseInputsVariant1() => BaseInputsVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BaseInputsVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.BaseInputsVariant2Item2, global::OpenRouter.OpenAIResponseInputMessageItem, global::OpenRouter.OpenAIResponseFunctionToolCallOutput, global::OpenRouter.OpenAIResponseFunctionToolCall, global::OpenRouter.OutputItemImageGenerationCall, global::OpenRouter.OutputMessage, global::OpenRouter.OpenAIResponseCustomToolCall, global::OpenRouter.OpenAIResponseCustomToolCallOutput, global::OpenRouter.ApplyPatchCallItem, global::OpenRouter.ApplyPatchCallOutputItem, global::OpenRouter.ConfigurationUpdateItem>>? BaseInputsVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.BaseInputsVariant2Item2, global::OpenRouter.OpenAIResponseInputMessageItem, global::OpenRouter.OpenAIResponseFunctionToolCallOutput, global::OpenRouter.OpenAIResponseFunctionToolCall, global::OpenRouter.OutputItemImageGenerationCall, global::OpenRouter.OutputMessage, global::OpenRouter.OpenAIResponseCustomToolCall, global::OpenRouter.OpenAIResponseCustomToolCallOutput, global::OpenRouter.ApplyPatchCallItem, global::OpenRouter.ApplyPatchCallOutputItem, global::OpenRouter.ConfigurationUpdateItem>>? BaseInputsVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseInputsVariant2))]
#endif
        public bool IsBaseInputsVariant2 => BaseInputsVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBaseInputsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.BaseInputsVariant2Item2, global::OpenRouter.OpenAIResponseInputMessageItem, global::OpenRouter.OpenAIResponseFunctionToolCallOutput, global::OpenRouter.OpenAIResponseFunctionToolCall, global::OpenRouter.OutputItemImageGenerationCall, global::OpenRouter.OutputMessage, global::OpenRouter.OpenAIResponseCustomToolCall, global::OpenRouter.OpenAIResponseCustomToolCallOutput, global::OpenRouter.ApplyPatchCallItem, global::OpenRouter.ApplyPatchCallOutputItem, global::OpenRouter.ConfigurationUpdateItem>>? value)
        {
            value = BaseInputsVariant2;
            return IsBaseInputsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.BaseInputsVariant2Item2, global::OpenRouter.OpenAIResponseInputMessageItem, global::OpenRouter.OpenAIResponseFunctionToolCallOutput, global::OpenRouter.OpenAIResponseFunctionToolCall, global::OpenRouter.OutputItemImageGenerationCall, global::OpenRouter.OutputMessage, global::OpenRouter.OpenAIResponseCustomToolCall, global::OpenRouter.OpenAIResponseCustomToolCallOutput, global::OpenRouter.ApplyPatchCallItem, global::OpenRouter.ApplyPatchCallOutputItem, global::OpenRouter.ConfigurationUpdateItem>> PickBaseInputsVariant2() => BaseInputsVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BaseInputsVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? BaseInputsVariant3 { get; init; }
#else
        public object? BaseInputsVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseInputsVariant3))]
#endif
        public bool IsBaseInputsVariant3 => BaseInputsVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBaseInputsVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = BaseInputsVariant3;
            return IsBaseInputsVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickBaseInputsVariant3() => BaseInputsVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BaseInputsVariant3' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BaseInputs(string value) => new BaseInputs((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(BaseInputs @this) => @this.BaseInputsVariant1;

        /// <summary>
        ///
        /// </summary>
        public BaseInputs(string? value)
        {
            BaseInputsVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BaseInputs FromBaseInputsVariant1(string? value) => new BaseInputs(value);

        /// <summary>
        ///
        /// </summary>
        public BaseInputs(
            string? baseInputsVariant1,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.BaseInputsVariant2Item2, global::OpenRouter.OpenAIResponseInputMessageItem, global::OpenRouter.OpenAIResponseFunctionToolCallOutput, global::OpenRouter.OpenAIResponseFunctionToolCall, global::OpenRouter.OutputItemImageGenerationCall, global::OpenRouter.OutputMessage, global::OpenRouter.OpenAIResponseCustomToolCall, global::OpenRouter.OpenAIResponseCustomToolCallOutput, global::OpenRouter.ApplyPatchCallItem, global::OpenRouter.ApplyPatchCallOutputItem, global::OpenRouter.ConfigurationUpdateItem>>? baseInputsVariant2,
            object? baseInputsVariant3
            )
        {
            BaseInputsVariant1 = baseInputsVariant1;
            BaseInputsVariant2 = baseInputsVariant2;
            BaseInputsVariant3 = baseInputsVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BaseInputsVariant3 as object ??
            BaseInputsVariant2 as object ??
            BaseInputsVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BaseInputsVariant1?.ToString() ??
            BaseInputsVariant2?.ToString() ??
            BaseInputsVariant3?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBaseInputsVariant1 || IsBaseInputsVariant2 || IsBaseInputsVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? baseInputsVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.BaseInputsVariant2Item2, global::OpenRouter.OpenAIResponseInputMessageItem, global::OpenRouter.OpenAIResponseFunctionToolCallOutput, global::OpenRouter.OpenAIResponseFunctionToolCall, global::OpenRouter.OutputItemImageGenerationCall, global::OpenRouter.OutputMessage, global::OpenRouter.OpenAIResponseCustomToolCall, global::OpenRouter.OpenAIResponseCustomToolCallOutput, global::OpenRouter.ApplyPatchCallItem, global::OpenRouter.ApplyPatchCallOutputItem, global::OpenRouter.ConfigurationUpdateItem>>, TResult>? baseInputsVariant2 = null,
            global::System.Func<object, TResult>? baseInputsVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BaseInputsVariant1 is { } __value0 && baseInputsVariant1 != null)
            {
                return baseInputsVariant1(__value0);
            }
            else if (BaseInputsVariant2 is { } __value1 && baseInputsVariant2 != null)
            {
                return baseInputsVariant2(__value1);
            }
            else if (BaseInputsVariant3 is { } __value2 && baseInputsVariant3 != null)
            {
                return baseInputsVariant3(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? baseInputsVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.BaseInputsVariant2Item2, global::OpenRouter.OpenAIResponseInputMessageItem, global::OpenRouter.OpenAIResponseFunctionToolCallOutput, global::OpenRouter.OpenAIResponseFunctionToolCall, global::OpenRouter.OutputItemImageGenerationCall, global::OpenRouter.OutputMessage, global::OpenRouter.OpenAIResponseCustomToolCall, global::OpenRouter.OpenAIResponseCustomToolCallOutput, global::OpenRouter.ApplyPatchCallItem, global::OpenRouter.ApplyPatchCallOutputItem, global::OpenRouter.ConfigurationUpdateItem>>>? baseInputsVariant2 = null,

            global::System.Action<object>? baseInputsVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BaseInputsVariant1 is { } __value0)
            {
                baseInputsVariant1?.Invoke(__value0);
            }
            else if (BaseInputsVariant2 is { } __value1)
            {
                baseInputsVariant2?.Invoke(__value1);
            }
            else if (BaseInputsVariant3 is { } __value2)
            {
                baseInputsVariant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? baseInputsVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.BaseInputsVariant2Item2, global::OpenRouter.OpenAIResponseInputMessageItem, global::OpenRouter.OpenAIResponseFunctionToolCallOutput, global::OpenRouter.OpenAIResponseFunctionToolCall, global::OpenRouter.OutputItemImageGenerationCall, global::OpenRouter.OutputMessage, global::OpenRouter.OpenAIResponseCustomToolCall, global::OpenRouter.OpenAIResponseCustomToolCallOutput, global::OpenRouter.ApplyPatchCallItem, global::OpenRouter.ApplyPatchCallOutputItem, global::OpenRouter.ConfigurationUpdateItem>>>? baseInputsVariant2 = null,
            global::System.Action<object>? baseInputsVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BaseInputsVariant1 is { } __value0)
            {
                baseInputsVariant1?.Invoke(__value0);
            }
            else if (BaseInputsVariant2 is { } __value1)
            {
                baseInputsVariant2?.Invoke(__value1);
            }
            else if (BaseInputsVariant3 is { } __value2)
            {
                baseInputsVariant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseInputsVariant1,
                typeof(string),
                BaseInputsVariant2,
                typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.BaseInputsVariant2Item2, global::OpenRouter.OpenAIResponseInputMessageItem, global::OpenRouter.OpenAIResponseFunctionToolCallOutput, global::OpenRouter.OpenAIResponseFunctionToolCall, global::OpenRouter.OutputItemImageGenerationCall, global::OpenRouter.OutputMessage, global::OpenRouter.OpenAIResponseCustomToolCall, global::OpenRouter.OpenAIResponseCustomToolCallOutput, global::OpenRouter.ApplyPatchCallItem, global::OpenRouter.ApplyPatchCallOutputItem, global::OpenRouter.ConfigurationUpdateItem>>),
                BaseInputsVariant3,
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
        public bool Equals(BaseInputs other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BaseInputsVariant1, other.BaseInputsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.BaseInputsVariant2Item2, global::OpenRouter.OpenAIResponseInputMessageItem, global::OpenRouter.OpenAIResponseFunctionToolCallOutput, global::OpenRouter.OpenAIResponseFunctionToolCall, global::OpenRouter.OutputItemImageGenerationCall, global::OpenRouter.OutputMessage, global::OpenRouter.OpenAIResponseCustomToolCall, global::OpenRouter.OpenAIResponseCustomToolCallOutput, global::OpenRouter.ApplyPatchCallItem, global::OpenRouter.ApplyPatchCallOutputItem, global::OpenRouter.ConfigurationUpdateItem>>?>.Default.Equals(BaseInputsVariant2, other.BaseInputsVariant2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(BaseInputsVariant3, other.BaseInputsVariant3)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BaseInputs obj1, BaseInputs obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseInputs>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BaseInputs obj1, BaseInputs obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseInputs o && Equals(o);
        }
    }
}
