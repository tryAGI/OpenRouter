#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Chat completion message with role-based discrimination
    /// </summary>
    public readonly partial struct ChatMessages : global::System.IEquatable<ChatMessages>
    {
        /// <summary>
        /// Assistant message for requests and responses
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatMessagesVariant1? Assistant { get; init; }
#else
        public global::OpenRouter.ChatMessagesVariant1? Assistant { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Assistant))]
#endif
        public bool IsAssistant => Assistant != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAssistant(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatMessagesVariant1? value)
        {
            value = Assistant;
            return IsAssistant;
        }

        /// <summary>
        /// Developer message
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatMessagesVariant2? Developer { get; init; }
#else
        public global::OpenRouter.ChatMessagesVariant2? Developer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Developer))]
#endif
        public bool IsDeveloper => Developer != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeveloper(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatMessagesVariant2? value)
        {
            value = Developer;
            return IsDeveloper;
        }

        /// <summary>
        /// System message for setting behavior
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatMessagesVariant3? System { get; init; }
#else
        public global::OpenRouter.ChatMessagesVariant3? System { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(System))]
#endif
        public bool IsSystem => System != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSystem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatMessagesVariant3? value)
        {
            value = System;
            return IsSystem;
        }

        /// <summary>
        /// Tool response message
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatMessagesVariant4? Tool { get; init; }
#else
        public global::OpenRouter.ChatMessagesVariant4? Tool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tool))]
#endif
        public bool IsTool => Tool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatMessagesVariant4? value)
        {
            value = Tool;
            return IsTool;
        }

        /// <summary>
        /// User message
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatMessagesVariant5? User { get; init; }
#else
        public global::OpenRouter.ChatMessagesVariant5? User { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(User))]
#endif
        public bool IsUser => User != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUser(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatMessagesVariant5? value)
        {
            value = User;
            return IsUser;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessages(global::OpenRouter.ChatMessagesVariant1 value) => new ChatMessages((global::OpenRouter.ChatMessagesVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatMessagesVariant1?(ChatMessages @this) => @this.Assistant;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessages(global::OpenRouter.ChatMessagesVariant1? value)
        {
            Assistant = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessages(global::OpenRouter.ChatMessagesVariant2 value) => new ChatMessages((global::OpenRouter.ChatMessagesVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatMessagesVariant2?(ChatMessages @this) => @this.Developer;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessages(global::OpenRouter.ChatMessagesVariant2? value)
        {
            Developer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessages(global::OpenRouter.ChatMessagesVariant3 value) => new ChatMessages((global::OpenRouter.ChatMessagesVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatMessagesVariant3?(ChatMessages @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessages(global::OpenRouter.ChatMessagesVariant3? value)
        {
            System = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessages(global::OpenRouter.ChatMessagesVariant4 value) => new ChatMessages((global::OpenRouter.ChatMessagesVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatMessagesVariant4?(ChatMessages @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessages(global::OpenRouter.ChatMessagesVariant4? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessages(global::OpenRouter.ChatMessagesVariant5 value) => new ChatMessages((global::OpenRouter.ChatMessagesVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatMessagesVariant5?(ChatMessages @this) => @this.User;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessages(global::OpenRouter.ChatMessagesVariant5? value)
        {
            User = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatMessages(
            global::OpenRouter.ChatMessagesVariant1? assistant,
            global::OpenRouter.ChatMessagesVariant2? developer,
            global::OpenRouter.ChatMessagesVariant3? system,
            global::OpenRouter.ChatMessagesVariant4? tool,
            global::OpenRouter.ChatMessagesVariant5? user
            )
        {
            Assistant = assistant;
            Developer = developer;
            System = system;
            Tool = tool;
            User = user;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            User as object ??
            Tool as object ??
            System as object ??
            Developer as object ??
            Assistant as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Assistant?.ToString() ??
            Developer?.ToString() ??
            System?.ToString() ??
            Tool?.ToString() ??
            User?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAssistant && !IsDeveloper && !IsSystem && !IsTool && !IsUser || !IsAssistant && IsDeveloper && !IsSystem && !IsTool && !IsUser || !IsAssistant && !IsDeveloper && IsSystem && !IsTool && !IsUser || !IsAssistant && !IsDeveloper && !IsSystem && IsTool && !IsUser || !IsAssistant && !IsDeveloper && !IsSystem && !IsTool && IsUser;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ChatMessagesVariant1, TResult>? assistant = null,
            global::System.Func<global::OpenRouter.ChatMessagesVariant2, TResult>? developer = null,
            global::System.Func<global::OpenRouter.ChatMessagesVariant3, TResult>? system = null,
            global::System.Func<global::OpenRouter.ChatMessagesVariant4, TResult>? tool = null,
            global::System.Func<global::OpenRouter.ChatMessagesVariant5, TResult>? user = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssistant && assistant != null)
            {
                return assistant(Assistant!);
            }
            else if (IsDeveloper && developer != null)
            {
                return developer(Developer!);
            }
            else if (IsSystem && system != null)
            {
                return system(System!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }
            else if (IsUser && user != null)
            {
                return user(User!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ChatMessagesVariant1>? assistant = null,

            global::System.Action<global::OpenRouter.ChatMessagesVariant2>? developer = null,

            global::System.Action<global::OpenRouter.ChatMessagesVariant3>? system = null,

            global::System.Action<global::OpenRouter.ChatMessagesVariant4>? tool = null,

            global::System.Action<global::OpenRouter.ChatMessagesVariant5>? user = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssistant)
            {
                assistant?.Invoke(Assistant!);
            }
            else if (IsDeveloper)
            {
                developer?.Invoke(Developer!);
            }
            else if (IsSystem)
            {
                system?.Invoke(System!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
            else if (IsUser)
            {
                user?.Invoke(User!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ChatMessagesVariant1>? assistant = null,
            global::System.Action<global::OpenRouter.ChatMessagesVariant2>? developer = null,
            global::System.Action<global::OpenRouter.ChatMessagesVariant3>? system = null,
            global::System.Action<global::OpenRouter.ChatMessagesVariant4>? tool = null,
            global::System.Action<global::OpenRouter.ChatMessagesVariant5>? user = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssistant)
            {
                assistant?.Invoke(Assistant!);
            }
            else if (IsDeveloper)
            {
                developer?.Invoke(Developer!);
            }
            else if (IsSystem)
            {
                system?.Invoke(System!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
            else if (IsUser)
            {
                user?.Invoke(User!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Assistant,
                typeof(global::OpenRouter.ChatMessagesVariant1),
                Developer,
                typeof(global::OpenRouter.ChatMessagesVariant2),
                System,
                typeof(global::OpenRouter.ChatMessagesVariant3),
                Tool,
                typeof(global::OpenRouter.ChatMessagesVariant4),
                User,
                typeof(global::OpenRouter.ChatMessagesVariant5),
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
        public bool Equals(ChatMessages other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatMessagesVariant1?>.Default.Equals(Assistant, other.Assistant) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatMessagesVariant2?>.Default.Equals(Developer, other.Developer) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatMessagesVariant3?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatMessagesVariant4?>.Default.Equals(Tool, other.Tool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatMessagesVariant5?>.Default.Equals(User, other.User) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatMessages obj1, ChatMessages obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatMessages>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatMessages obj1, ChatMessages obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatMessages o && Equals(o);
        }
    }
}
