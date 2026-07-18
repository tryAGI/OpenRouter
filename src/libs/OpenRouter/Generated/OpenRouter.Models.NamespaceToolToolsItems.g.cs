#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct NamespaceToolToolsItems : global::System.IEquatable<NamespaceToolToolsItems>
    {
        /// <summary>
        /// A function tool grouped inside a namespace tool
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.NamespaceFunctionTool? NamespaceFunctionTool { get; init; }
#else
        public global::OpenRouter.NamespaceFunctionTool? NamespaceFunctionTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamespaceFunctionTool))]
#endif
        public bool IsNamespaceFunctionTool => NamespaceFunctionTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickNamespaceFunctionTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.NamespaceFunctionTool? value)
        {
            value = NamespaceFunctionTool;
            return IsNamespaceFunctionTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.NamespaceFunctionTool PickNamespaceFunctionTool() => IsNamespaceFunctionTool
            ? NamespaceFunctionTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'NamespaceFunctionTool' but the value was {ToString()}.");

        /// <summary>
        /// Custom tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CustomTool? CustomTool { get; init; }
#else
        public global::OpenRouter.CustomTool? CustomTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomTool))]
#endif
        public bool IsCustomTool => CustomTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCustomTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CustomTool? value)
        {
            value = CustomTool;
            return IsCustomTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CustomTool PickCustomTool() => IsCustomTool
            ? CustomTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomTool' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamespaceToolToolsItems(global::OpenRouter.NamespaceFunctionTool value) => new NamespaceToolToolsItems((global::OpenRouter.NamespaceFunctionTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.NamespaceFunctionTool?(NamespaceToolToolsItems @this) => @this.NamespaceFunctionTool;

        /// <summary>
        /// 
        /// </summary>
        public NamespaceToolToolsItems(global::OpenRouter.NamespaceFunctionTool? value)
        {
            NamespaceFunctionTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static NamespaceToolToolsItems FromNamespaceFunctionTool(global::OpenRouter.NamespaceFunctionTool? value) => new NamespaceToolToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamespaceToolToolsItems(global::OpenRouter.CustomTool value) => new NamespaceToolToolsItems((global::OpenRouter.CustomTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CustomTool?(NamespaceToolToolsItems @this) => @this.CustomTool;

        /// <summary>
        /// 
        /// </summary>
        public NamespaceToolToolsItems(global::OpenRouter.CustomTool? value)
        {
            CustomTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static NamespaceToolToolsItems FromCustomTool(global::OpenRouter.CustomTool? value) => new NamespaceToolToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public NamespaceToolToolsItems(
            global::OpenRouter.NamespaceFunctionTool? namespaceFunctionTool,
            global::OpenRouter.CustomTool? customTool
            )
        {
            NamespaceFunctionTool = namespaceFunctionTool;
            CustomTool = customTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomTool as object ??
            NamespaceFunctionTool as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            NamespaceFunctionTool?.ToString() ??
            CustomTool?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNamespaceFunctionTool && !IsCustomTool || !IsNamespaceFunctionTool && IsCustomTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.NamespaceFunctionTool, TResult>? namespaceFunctionTool = null,
            global::System.Func<global::OpenRouter.CustomTool, TResult>? customTool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNamespaceFunctionTool && namespaceFunctionTool != null)
            {
                return namespaceFunctionTool(NamespaceFunctionTool!);
            }
            else if (IsCustomTool && customTool != null)
            {
                return customTool(CustomTool!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.NamespaceFunctionTool>? namespaceFunctionTool = null,

            global::System.Action<global::OpenRouter.CustomTool>? customTool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNamespaceFunctionTool)
            {
                namespaceFunctionTool?.Invoke(NamespaceFunctionTool!);
            }
            else if (IsCustomTool)
            {
                customTool?.Invoke(CustomTool!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.NamespaceFunctionTool>? namespaceFunctionTool = null,
            global::System.Action<global::OpenRouter.CustomTool>? customTool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNamespaceFunctionTool)
            {
                namespaceFunctionTool?.Invoke(NamespaceFunctionTool!);
            }
            else if (IsCustomTool)
            {
                customTool?.Invoke(CustomTool!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                NamespaceFunctionTool,
                typeof(global::OpenRouter.NamespaceFunctionTool),
                CustomTool,
                typeof(global::OpenRouter.CustomTool),
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
        public bool Equals(NamespaceToolToolsItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.NamespaceFunctionTool?>.Default.Equals(NamespaceFunctionTool, other.NamespaceFunctionTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CustomTool?>.Default.Equals(CustomTool, other.CustomTool) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NamespaceToolToolsItems obj1, NamespaceToolToolsItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NamespaceToolToolsItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NamespaceToolToolsItems obj1, NamespaceToolToolsItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NamespaceToolToolsItems o && Equals(o);
        }
    }
}
