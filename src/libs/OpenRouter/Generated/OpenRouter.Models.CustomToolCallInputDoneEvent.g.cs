#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when a custom tool call's freeform input streaming is complete. Mirrors `response.function_call_arguments.done` but for `custom` tools.<br/>
    /// Example: {"input":"*** Begin Patch\n*** End Patch","item_id":"item-1","output_index":0,"sequence_number":6,"type":"response.custom_tool_call_input.done"}
    /// </summary>
    public readonly partial struct CustomToolCallInputDoneEvent : global::System.IEquatable<CustomToolCallInputDoneEvent>
    {
        /// <summary>
        /// Event emitted when a custom tool call's freeform input streaming is complete. Mirrors `response.function_call_arguments.done` but for `custom` tools.<br/>
        /// Example: {"input":"*** Begin Patch\n*** End Patch","item_id":"item-1","output_index":0,"sequence_number":6,"type":"response.custom_tool_call_input.done"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseCustomToolCallInputDoneEvent? Base { get; init; }
#else
        public global::OpenRouter.BaseCustomToolCallInputDoneEvent? Base { get; }
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
            out global::OpenRouter.BaseCustomToolCallInputDoneEvent? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseCustomToolCallInputDoneEvent PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? CustomToolCallInputDoneEventVariant2 { get; init; }
#else
        public object? CustomToolCallInputDoneEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCallInputDoneEventVariant2))]
#endif
        public bool IsCustomToolCallInputDoneEventVariant2 => CustomToolCallInputDoneEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustomToolCallInputDoneEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = CustomToolCallInputDoneEventVariant2;
            return IsCustomToolCallInputDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickCustomToolCallInputDoneEventVariant2() => CustomToolCallInputDoneEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCallInputDoneEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CustomToolCallInputDoneEvent(global::OpenRouter.BaseCustomToolCallInputDoneEvent value) => new CustomToolCallInputDoneEvent((global::OpenRouter.BaseCustomToolCallInputDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BaseCustomToolCallInputDoneEvent?(CustomToolCallInputDoneEvent @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public CustomToolCallInputDoneEvent(global::OpenRouter.BaseCustomToolCallInputDoneEvent? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CustomToolCallInputDoneEvent FromBase(global::OpenRouter.BaseCustomToolCallInputDoneEvent? value) => new CustomToolCallInputDoneEvent(value);

        /// <summary>
        ///
        /// </summary>
        public CustomToolCallInputDoneEvent(
            global::OpenRouter.BaseCustomToolCallInputDoneEvent? @base,
            object? customToolCallInputDoneEventVariant2
            )
        {
            Base = @base;
            CustomToolCallInputDoneEventVariant2 = customToolCallInputDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CustomToolCallInputDoneEventVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CustomToolCallInputDoneEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCustomToolCallInputDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseCustomToolCallInputDoneEvent, TResult>? @base = null,
            global::System.Func<object, TResult>? customToolCallInputDoneEventVariant2 = null,
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
            else if (CustomToolCallInputDoneEventVariant2 is { } __value1 && customToolCallInputDoneEventVariant2 != null)
            {
                return customToolCallInputDoneEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseCustomToolCallInputDoneEvent>? @base = null,

            global::System.Action<object>? customToolCallInputDoneEventVariant2 = null,
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
            else if (CustomToolCallInputDoneEventVariant2 is { } __value1)
            {
                customToolCallInputDoneEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.BaseCustomToolCallInputDoneEvent>? @base = null,
            global::System.Action<object>? customToolCallInputDoneEventVariant2 = null,
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
            else if (CustomToolCallInputDoneEventVariant2 is { } __value1)
            {
                customToolCallInputDoneEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.BaseCustomToolCallInputDoneEvent),
                CustomToolCallInputDoneEventVariant2,
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
        public bool Equals(CustomToolCallInputDoneEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseCustomToolCallInputDoneEvent?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(CustomToolCallInputDoneEventVariant2, other.CustomToolCallInputDoneEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CustomToolCallInputDoneEvent obj1, CustomToolCallInputDoneEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CustomToolCallInputDoneEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CustomToolCallInputDoneEvent obj1, CustomToolCallInputDoneEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CustomToolCallInputDoneEvent o && Equals(o);
        }
    }
}
