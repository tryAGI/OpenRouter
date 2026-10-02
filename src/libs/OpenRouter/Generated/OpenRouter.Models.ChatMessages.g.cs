#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Chat completion message with role-based discrimination<br/>
    /// Example: {"content":"What is the capital of France?","role":"user"}
    /// </summary>
    public readonly partial struct ChatMessages : global::System.IEquatable<ChatMessages>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessagesDiscriminatorRole? Role { get; }

        /// <summary>
        /// System message for setting behavior<br/>
        /// Example: {"content":"You are a helpful assistant.","name":"Assistant Config","role":"system"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatSystemMessage? System { get; init; }
#else
        public global::OpenRouter.ChatSystemMessage? System { get; }
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
            out global::OpenRouter.ChatSystemMessage? value)
        {
            value = System;
            return IsSystem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatSystemMessage PickSystem() => System is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'System' but the value was {ToString()}.");

        /// <summary>
        /// User message<br/>
        /// Example: {"content":"What is the capital of France?","role":"user"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatUserMessage? User { get; init; }
#else
        public global::OpenRouter.ChatUserMessage? User { get; }
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
            out global::OpenRouter.ChatUserMessage? value)
        {
            value = User;
            return IsUser;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatUserMessage PickUser() => User is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'User' but the value was {ToString()}.");

        /// <summary>
        /// Developer message<br/>
        /// Example: {"content":"This is a message from the developer.","role":"developer"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatDeveloperMessage? Developer { get; init; }
#else
        public global::OpenRouter.ChatDeveloperMessage? Developer { get; }
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
            out global::OpenRouter.ChatDeveloperMessage? value)
        {
            value = Developer;
            return IsDeveloper;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatDeveloperMessage PickDeveloper() => Developer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Developer' but the value was {ToString()}.");

        /// <summary>
        /// Assistant message for requests and responses<br/>
        /// Example: {"content":"The capital of France is Paris.","model":"openai/gpt-4o","role":"assistant"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatAssistantMessage? Assistant { get; init; }
#else
        public global::OpenRouter.ChatAssistantMessage? Assistant { get; }
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
            out global::OpenRouter.ChatAssistantMessage? value)
        {
            value = Assistant;
            return IsAssistant;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatAssistantMessage PickAssistant() => Assistant is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Assistant' but the value was {ToString()}.");

        /// <summary>
        /// Tool response message<br/>
        /// Example: {"content":"The weather in San Francisco is 72\u00B0F and sunny.","role":"tool","tool_call_id":"call_abc123"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatToolMessage? Tool { get; init; }
#else
        public global::OpenRouter.ChatToolMessage? Tool { get; }
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
            out global::OpenRouter.ChatToolMessage? value)
        {
            value = Tool;
            return IsTool;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolMessage PickTool() => Tool is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Tool' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatMessages(global::OpenRouter.ChatSystemMessage value) => new ChatMessages((global::OpenRouter.ChatSystemMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatSystemMessage?(ChatMessages @this) => @this.System;

        /// <summary>
        ///
        /// </summary>
        public ChatMessages(global::OpenRouter.ChatSystemMessage? value)
        {
            System = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatMessages FromSystem(global::OpenRouter.ChatSystemMessage? value) => new ChatMessages(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatMessages(global::OpenRouter.ChatUserMessage value) => new ChatMessages((global::OpenRouter.ChatUserMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatUserMessage?(ChatMessages @this) => @this.User;

        /// <summary>
        ///
        /// </summary>
        public ChatMessages(global::OpenRouter.ChatUserMessage? value)
        {
            User = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatMessages FromUser(global::OpenRouter.ChatUserMessage? value) => new ChatMessages(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatMessages(global::OpenRouter.ChatDeveloperMessage value) => new ChatMessages((global::OpenRouter.ChatDeveloperMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatDeveloperMessage?(ChatMessages @this) => @this.Developer;

        /// <summary>
        ///
        /// </summary>
        public ChatMessages(global::OpenRouter.ChatDeveloperMessage? value)
        {
            Developer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatMessages FromDeveloper(global::OpenRouter.ChatDeveloperMessage? value) => new ChatMessages(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatMessages(global::OpenRouter.ChatAssistantMessage value) => new ChatMessages((global::OpenRouter.ChatAssistantMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatAssistantMessage?(ChatMessages @this) => @this.Assistant;

        /// <summary>
        ///
        /// </summary>
        public ChatMessages(global::OpenRouter.ChatAssistantMessage? value)
        {
            Assistant = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatMessages FromAssistant(global::OpenRouter.ChatAssistantMessage? value) => new ChatMessages(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatMessages(global::OpenRouter.ChatToolMessage value) => new ChatMessages((global::OpenRouter.ChatToolMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatToolMessage?(ChatMessages @this) => @this.Tool;

        /// <summary>
        ///
        /// </summary>
        public ChatMessages(global::OpenRouter.ChatToolMessage? value)
        {
            Tool = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatMessages FromTool(global::OpenRouter.ChatToolMessage? value) => new ChatMessages(value);

        /// <summary>
        ///
        /// </summary>
        public ChatMessages(
            global::OpenRouter.ChatMessagesDiscriminatorRole? role,
            global::OpenRouter.ChatSystemMessage? system,
            global::OpenRouter.ChatUserMessage? user,
            global::OpenRouter.ChatDeveloperMessage? developer,
            global::OpenRouter.ChatAssistantMessage? assistant,
            global::OpenRouter.ChatToolMessage? tool
            )
        {
            Role = role;

            System = system;
            User = user;
            Developer = developer;
            Assistant = assistant;
            Tool = tool;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Tool as object ??
            Assistant as object ??
            Developer as object ??
            User as object ??
            System as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            System?.ToString() ??
            User?.ToString() ??
            Developer?.ToString() ??
            Assistant?.ToString() ??
            Tool?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSystem && !IsUser && !IsDeveloper && !IsAssistant && !IsTool || !IsSystem && IsUser && !IsDeveloper && !IsAssistant && !IsTool || !IsSystem && !IsUser && IsDeveloper && !IsAssistant && !IsTool || !IsSystem && !IsUser && !IsDeveloper && IsAssistant && !IsTool || !IsSystem && !IsUser && !IsDeveloper && !IsAssistant && IsTool;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ChatSystemMessage, TResult>? system = null,
            global::System.Func<global::OpenRouter.ChatUserMessage, TResult>? user = null,
            global::System.Func<global::OpenRouter.ChatDeveloperMessage, TResult>? developer = null,
            global::System.Func<global::OpenRouter.ChatAssistantMessage, TResult>? assistant = null,
            global::System.Func<global::OpenRouter.ChatToolMessage, TResult>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (System is { } __value0 && system != null)
            {
                return system(__value0);
            }
            else if (User is { } __value1 && user != null)
            {
                return user(__value1);
            }
            else if (Developer is { } __value2 && developer != null)
            {
                return developer(__value2);
            }
            else if (Assistant is { } __value3 && assistant != null)
            {
                return assistant(__value3);
            }
            else if (Tool is { } __value4 && tool != null)
            {
                return tool(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ChatSystemMessage>? system = null,

            global::System.Action<global::OpenRouter.ChatUserMessage>? user = null,

            global::System.Action<global::OpenRouter.ChatDeveloperMessage>? developer = null,

            global::System.Action<global::OpenRouter.ChatAssistantMessage>? assistant = null,

            global::System.Action<global::OpenRouter.ChatToolMessage>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (System is { } __value0)
            {
                system?.Invoke(__value0);
            }
            else if (User is { } __value1)
            {
                user?.Invoke(__value1);
            }
            else if (Developer is { } __value2)
            {
                developer?.Invoke(__value2);
            }
            else if (Assistant is { } __value3)
            {
                assistant?.Invoke(__value3);
            }
            else if (Tool is { } __value4)
            {
                tool?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ChatSystemMessage>? system = null,
            global::System.Action<global::OpenRouter.ChatUserMessage>? user = null,
            global::System.Action<global::OpenRouter.ChatDeveloperMessage>? developer = null,
            global::System.Action<global::OpenRouter.ChatAssistantMessage>? assistant = null,
            global::System.Action<global::OpenRouter.ChatToolMessage>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (System is { } __value0)
            {
                system?.Invoke(__value0);
            }
            else if (User is { } __value1)
            {
                user?.Invoke(__value1);
            }
            else if (Developer is { } __value2)
            {
                developer?.Invoke(__value2);
            }
            else if (Assistant is { } __value3)
            {
                assistant?.Invoke(__value3);
            }
            else if (Tool is { } __value4)
            {
                tool?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                System,
                typeof(global::OpenRouter.ChatSystemMessage),
                User,
                typeof(global::OpenRouter.ChatUserMessage),
                Developer,
                typeof(global::OpenRouter.ChatDeveloperMessage),
                Assistant,
                typeof(global::OpenRouter.ChatAssistantMessage),
                Tool,
                typeof(global::OpenRouter.ChatToolMessage),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatSystemMessage?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatUserMessage?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatDeveloperMessage?>.Default.Equals(Developer, other.Developer) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatAssistantMessage?>.Default.Equals(Assistant, other.Assistant) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatToolMessage?>.Default.Equals(Tool, other.Tool)
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
