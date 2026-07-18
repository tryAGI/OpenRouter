#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AgentMessageItemContentItems : global::System.IEquatable<AgentMessageItemContentItems>
    {
        /// <summary>
        /// Text input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InputText? InputText { get; init; }
#else
        public global::OpenRouter.InputText? InputText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputText))]
#endif
        public bool IsInputText => InputText != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.InputText? value)
        {
            value = InputText;
            return IsInputText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.InputText PickInputText() => IsInputText
            ? InputText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputText' but the value was {ToString()}.");

        /// <summary>
        /// Image input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AgentMessageItemContentItems1? AgentMessageItemContentItems1 { get; init; }
#else
        public global::OpenRouter.AgentMessageItemContentItems1? AgentMessageItemContentItems1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentMessageItemContentItems1))]
#endif
        public bool IsAgentMessageItemContentItems1 => AgentMessageItemContentItems1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentMessageItemContentItems1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AgentMessageItemContentItems1? value)
        {
            value = AgentMessageItemContentItems1;
            return IsAgentMessageItemContentItems1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.AgentMessageItemContentItems1 PickAgentMessageItemContentItems1() => IsAgentMessageItemContentItems1
            ? AgentMessageItemContentItems1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentMessageItemContentItems1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AgentMessageItemContentItems2? AgentMessageItemContentItems2 { get; init; }
#else
        public global::OpenRouter.AgentMessageItemContentItems2? AgentMessageItemContentItems2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentMessageItemContentItems2))]
#endif
        public bool IsAgentMessageItemContentItems2 => AgentMessageItemContentItems2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentMessageItemContentItems2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AgentMessageItemContentItems2? value)
        {
            value = AgentMessageItemContentItems2;
            return IsAgentMessageItemContentItems2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.AgentMessageItemContentItems2 PickAgentMessageItemContentItems2() => IsAgentMessageItemContentItems2
            ? AgentMessageItemContentItems2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentMessageItemContentItems2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentMessageItemContentItems(global::OpenRouter.InputText value) => new AgentMessageItemContentItems((global::OpenRouter.InputText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.InputText?(AgentMessageItemContentItems @this) => @this.InputText;

        /// <summary>
        /// 
        /// </summary>
        public AgentMessageItemContentItems(global::OpenRouter.InputText? value)
        {
            InputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentMessageItemContentItems FromInputText(global::OpenRouter.InputText? value) => new AgentMessageItemContentItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentMessageItemContentItems(global::OpenRouter.AgentMessageItemContentItems1 value) => new AgentMessageItemContentItems((global::OpenRouter.AgentMessageItemContentItems1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AgentMessageItemContentItems1?(AgentMessageItemContentItems @this) => @this.AgentMessageItemContentItems1;

        /// <summary>
        /// 
        /// </summary>
        public AgentMessageItemContentItems(global::OpenRouter.AgentMessageItemContentItems1? value)
        {
            AgentMessageItemContentItems1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentMessageItemContentItems FromAgentMessageItemContentItems1(global::OpenRouter.AgentMessageItemContentItems1? value) => new AgentMessageItemContentItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentMessageItemContentItems(global::OpenRouter.AgentMessageItemContentItems2 value) => new AgentMessageItemContentItems((global::OpenRouter.AgentMessageItemContentItems2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AgentMessageItemContentItems2?(AgentMessageItemContentItems @this) => @this.AgentMessageItemContentItems2;

        /// <summary>
        /// 
        /// </summary>
        public AgentMessageItemContentItems(global::OpenRouter.AgentMessageItemContentItems2? value)
        {
            AgentMessageItemContentItems2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentMessageItemContentItems FromAgentMessageItemContentItems2(global::OpenRouter.AgentMessageItemContentItems2? value) => new AgentMessageItemContentItems(value);

        /// <summary>
        /// 
        /// </summary>
        public AgentMessageItemContentItems(
            global::OpenRouter.InputText? inputText,
            global::OpenRouter.AgentMessageItemContentItems1? agentMessageItemContentItems1,
            global::OpenRouter.AgentMessageItemContentItems2? agentMessageItemContentItems2
            )
        {
            InputText = inputText;
            AgentMessageItemContentItems1 = agentMessageItemContentItems1;
            AgentMessageItemContentItems2 = agentMessageItemContentItems2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgentMessageItemContentItems2 as object ??
            AgentMessageItemContentItems1 as object ??
            InputText as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputText?.ToString() ??
            AgentMessageItemContentItems1?.ToString() ??
            AgentMessageItemContentItems2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputText && !IsAgentMessageItemContentItems1 && !IsAgentMessageItemContentItems2 || !IsInputText && IsAgentMessageItemContentItems1 && !IsAgentMessageItemContentItems2 || !IsInputText && !IsAgentMessageItemContentItems1 && IsAgentMessageItemContentItems2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.InputText, TResult>? inputText = null,
            global::System.Func<global::OpenRouter.AgentMessageItemContentItems1, TResult>? agentMessageItemContentItems1 = null,
            global::System.Func<global::OpenRouter.AgentMessageItemContentItems2, TResult>? agentMessageItemContentItems2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText && inputText != null)
            {
                return inputText(InputText!);
            }
            else if (IsAgentMessageItemContentItems1 && agentMessageItemContentItems1 != null)
            {
                return agentMessageItemContentItems1(AgentMessageItemContentItems1!);
            }
            else if (IsAgentMessageItemContentItems2 && agentMessageItemContentItems2 != null)
            {
                return agentMessageItemContentItems2(AgentMessageItemContentItems2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.InputText>? inputText = null,

            global::System.Action<global::OpenRouter.AgentMessageItemContentItems1>? agentMessageItemContentItems1 = null,

            global::System.Action<global::OpenRouter.AgentMessageItemContentItems2>? agentMessageItemContentItems2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText)
            {
                inputText?.Invoke(InputText!);
            }
            else if (IsAgentMessageItemContentItems1)
            {
                agentMessageItemContentItems1?.Invoke(AgentMessageItemContentItems1!);
            }
            else if (IsAgentMessageItemContentItems2)
            {
                agentMessageItemContentItems2?.Invoke(AgentMessageItemContentItems2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.InputText>? inputText = null,
            global::System.Action<global::OpenRouter.AgentMessageItemContentItems1>? agentMessageItemContentItems1 = null,
            global::System.Action<global::OpenRouter.AgentMessageItemContentItems2>? agentMessageItemContentItems2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText)
            {
                inputText?.Invoke(InputText!);
            }
            else if (IsAgentMessageItemContentItems1)
            {
                agentMessageItemContentItems1?.Invoke(AgentMessageItemContentItems1!);
            }
            else if (IsAgentMessageItemContentItems2)
            {
                agentMessageItemContentItems2?.Invoke(AgentMessageItemContentItems2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputText,
                typeof(global::OpenRouter.InputText),
                AgentMessageItemContentItems1,
                typeof(global::OpenRouter.AgentMessageItemContentItems1),
                AgentMessageItemContentItems2,
                typeof(global::OpenRouter.AgentMessageItemContentItems2),
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
        public bool Equals(AgentMessageItemContentItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputText?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AgentMessageItemContentItems1?>.Default.Equals(AgentMessageItemContentItems1, other.AgentMessageItemContentItems1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AgentMessageItemContentItems2?>.Default.Equals(AgentMessageItemContentItems2, other.AgentMessageItemContentItems2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentMessageItemContentItems obj1, AgentMessageItemContentItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentMessageItemContentItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentMessageItemContentItems obj1, AgentMessageItemContentItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentMessageItemContentItems o && Equals(o);
        }
    }
}
