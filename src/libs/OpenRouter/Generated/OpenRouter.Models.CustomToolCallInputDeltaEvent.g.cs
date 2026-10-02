#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when a custom tool call's freeform input is being streamed. Mirrors `response.function_call_arguments.delta` but for `custom` tools whose input is opaque text rather than JSON arguments.<br/>
    /// Example: {"delta":"*** Begin Patch","item_id":"item-1","output_index":0,"sequence_number":4,"type":"response.custom_tool_call_input.delta"}
    /// </summary>
    public readonly partial struct CustomToolCallInputDeltaEvent : global::System.IEquatable<CustomToolCallInputDeltaEvent>
    {
        /// <summary>
        /// Event emitted when a custom tool call's freeform input is being streamed. Mirrors `response.function_call_arguments.delta` but for `custom` tools whose input is opaque text rather than JSON arguments.<br/>
        /// Example: {"delta":"*** Begin Patch","item_id":"item-1","output_index":0,"sequence_number":4,"type":"response.custom_tool_call_input.delta"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseCustomToolCallInputDeltaEvent? Base { get; init; }
#else
        public global::OpenRouter.BaseCustomToolCallInputDeltaEvent? Base { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.BaseCustomToolCallInputDeltaEvent? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseCustomToolCallInputDeltaEvent PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? CustomToolCallInputDeltaEventVariant2 { get; init; }
#else
        public object? CustomToolCallInputDeltaEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCallInputDeltaEventVariant2))]
#endif
        public bool IsCustomToolCallInputDeltaEventVariant2 => CustomToolCallInputDeltaEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustomToolCallInputDeltaEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = CustomToolCallInputDeltaEventVariant2;
            return IsCustomToolCallInputDeltaEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickCustomToolCallInputDeltaEventVariant2() => CustomToolCallInputDeltaEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCallInputDeltaEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CustomToolCallInputDeltaEvent(global::OpenRouter.BaseCustomToolCallInputDeltaEvent value) => new CustomToolCallInputDeltaEvent((global::OpenRouter.BaseCustomToolCallInputDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BaseCustomToolCallInputDeltaEvent?(CustomToolCallInputDeltaEvent @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public CustomToolCallInputDeltaEvent(global::OpenRouter.BaseCustomToolCallInputDeltaEvent? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CustomToolCallInputDeltaEvent FromBase(global::OpenRouter.BaseCustomToolCallInputDeltaEvent? value) => new CustomToolCallInputDeltaEvent(value);

        /// <summary>
        ///
        /// </summary>
        public CustomToolCallInputDeltaEvent(
            global::OpenRouter.BaseCustomToolCallInputDeltaEvent? @base,
            object? customToolCallInputDeltaEventVariant2
            )
        {
            Base = @base;
            CustomToolCallInputDeltaEventVariant2 = customToolCallInputDeltaEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CustomToolCallInputDeltaEventVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CustomToolCallInputDeltaEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCustomToolCallInputDeltaEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseCustomToolCallInputDeltaEvent, TResult>? @base = null,
            global::System.Func<object, TResult>? customToolCallInputDeltaEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0 && @base != null)
            {
                return @base(__value0);
            }
            else if (CustomToolCallInputDeltaEventVariant2 is { } __value1 && customToolCallInputDeltaEventVariant2 != null)
            {
                return customToolCallInputDeltaEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseCustomToolCallInputDeltaEvent>? @base = null,

            global::System.Action<object>? customToolCallInputDeltaEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (CustomToolCallInputDeltaEventVariant2 is { } __value1)
            {
                customToolCallInputDeltaEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.BaseCustomToolCallInputDeltaEvent>? @base = null,
            global::System.Action<object>? customToolCallInputDeltaEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (CustomToolCallInputDeltaEventVariant2 is { } __value1)
            {
                customToolCallInputDeltaEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::OpenRouter.BaseCustomToolCallInputDeltaEvent),
                CustomToolCallInputDeltaEventVariant2,
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
        public bool Equals(CustomToolCallInputDeltaEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseCustomToolCallInputDeltaEvent?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(CustomToolCallInputDeltaEventVariant2, other.CustomToolCallInputDeltaEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CustomToolCallInputDeltaEvent obj1, CustomToolCallInputDeltaEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CustomToolCallInputDeltaEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CustomToolCallInputDeltaEvent obj1, CustomToolCallInputDeltaEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CustomToolCallInputDeltaEvent o && Equals(o);
        }
    }
}
