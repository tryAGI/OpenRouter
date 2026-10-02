#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// One OpenAI-compatible chat message, discriminated by `role`.<br/>
    /// Example: {"content":"Summarize the open pull requests.","role":"user"}
    /// </summary>
    public readonly partial struct InternChatMessage : global::System.IEquatable<InternChatMessage>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InternChatMessageDiscriminatorRole? Role { get; }

        /// <summary>
        /// A system message. Accepted for client compatibility and not forwarded.<br/>
        /// Example: {"content":"You are a helpful assistant.","role":"system"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InternChatSystemMessage? System { get; init; }
#else
        public global::OpenRouter.InternChatSystemMessage? System { get; }
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
            out global::OpenRouter.InternChatSystemMessage? value)
        {
            value = System;
            return IsSystem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InternChatSystemMessage PickSystem() => System is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'System' but the value was {ToString()}.");

        /// <summary>
        /// A developer message. Accepted for client compatibility and not forwarded.<br/>
        /// Example: {"content":"Answer briefly.","role":"developer"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InternChatDeveloperMessage? Developer { get; init; }
#else
        public global::OpenRouter.InternChatDeveloperMessage? Developer { get; }
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
            out global::OpenRouter.InternChatDeveloperMessage? value)
        {
            value = Developer;
            return IsDeveloper;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InternChatDeveloperMessage PickDeveloper() => Developer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Developer' but the value was {ToString()}.");

        /// <summary>
        /// A user message. When it is the last message its text is the prompt for a new run, at most 32000 characters.<br/>
        /// Example: {"content":"Summarize the open pull requests.","role":"user"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InternChatUserMessage? User { get; init; }
#else
        public global::OpenRouter.InternChatUserMessage? User { get; }
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
            out global::OpenRouter.InternChatUserMessage? value)
        {
            value = User;
            return IsUser;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InternChatUserMessage PickUser() => User is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'User' but the value was {ToString()}.");

        /// <summary>
        /// An assistant message from an earlier response. When answering an interaction, echo the streamed `tool_calls` here before the `tool` message.<br/>
        /// Example: {"content":null,"role":"assistant","tool_calls":[{"function":{"arguments":"{\u0022kind\u0022:\u0022permission\u0022,\u0022operation\u0022:\u0022shell\u0022,\u0022options\u0022:[\u0022allow_once\u0022,\u0022reject_once\u0022]}","name":"openrouter.provide_input"},"id":"15e90ad6-5320-4a59-af4f-b371428154fa"}]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InternChatAssistantMessage? Assistant { get; init; }
#else
        public global::OpenRouter.InternChatAssistantMessage? Assistant { get; }
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
            out global::OpenRouter.InternChatAssistantMessage? value)
        {
            value = Assistant;
            return IsAssistant;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InternChatAssistantMessage PickAssistant() => Assistant is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Assistant' but the value was {ToString()}.");

        /// <summary>
        /// The answer to an `openrouter.provide_input` tool call. `tool_call_id` is the streamed tool call id and `session_id` must name the same session. For a permission, `content` is one of the offered option kinds (`allow_once`, `allow_always`, `reject_once`, `reject_always`) or `cancel`. For a question (elicitation), `content` is a JSON object string with `action` (`accept`, `decline` or `cancel`) and, for `accept`, `content` holding the field values. The answer is delivered to the run that asked. It never starts a new run.<br/>
        /// Example: {"content":"allow_once","role":"tool","tool_call_id":"15e90ad6-5320-4a59-af4f-b371428154fa"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InternChatToolMessage? Tool { get; init; }
#else
        public global::OpenRouter.InternChatToolMessage? Tool { get; }
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
            out global::OpenRouter.InternChatToolMessage? value)
        {
            value = Tool;
            return IsTool;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InternChatToolMessage PickTool() => Tool is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Tool' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator InternChatMessage(global::OpenRouter.InternChatSystemMessage value) => new InternChatMessage((global::OpenRouter.InternChatSystemMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.InternChatSystemMessage?(InternChatMessage @this) => @this.System;

        /// <summary>
        ///
        /// </summary>
        public InternChatMessage(global::OpenRouter.InternChatSystemMessage? value)
        {
            System = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InternChatMessage FromSystem(global::OpenRouter.InternChatSystemMessage? value) => new InternChatMessage(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InternChatMessage(global::OpenRouter.InternChatDeveloperMessage value) => new InternChatMessage((global::OpenRouter.InternChatDeveloperMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.InternChatDeveloperMessage?(InternChatMessage @this) => @this.Developer;

        /// <summary>
        ///
        /// </summary>
        public InternChatMessage(global::OpenRouter.InternChatDeveloperMessage? value)
        {
            Developer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InternChatMessage FromDeveloper(global::OpenRouter.InternChatDeveloperMessage? value) => new InternChatMessage(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InternChatMessage(global::OpenRouter.InternChatUserMessage value) => new InternChatMessage((global::OpenRouter.InternChatUserMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.InternChatUserMessage?(InternChatMessage @this) => @this.User;

        /// <summary>
        ///
        /// </summary>
        public InternChatMessage(global::OpenRouter.InternChatUserMessage? value)
        {
            User = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InternChatMessage FromUser(global::OpenRouter.InternChatUserMessage? value) => new InternChatMessage(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InternChatMessage(global::OpenRouter.InternChatAssistantMessage value) => new InternChatMessage((global::OpenRouter.InternChatAssistantMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.InternChatAssistantMessage?(InternChatMessage @this) => @this.Assistant;

        /// <summary>
        ///
        /// </summary>
        public InternChatMessage(global::OpenRouter.InternChatAssistantMessage? value)
        {
            Assistant = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InternChatMessage FromAssistant(global::OpenRouter.InternChatAssistantMessage? value) => new InternChatMessage(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InternChatMessage(global::OpenRouter.InternChatToolMessage value) => new InternChatMessage((global::OpenRouter.InternChatToolMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.InternChatToolMessage?(InternChatMessage @this) => @this.Tool;

        /// <summary>
        ///
        /// </summary>
        public InternChatMessage(global::OpenRouter.InternChatToolMessage? value)
        {
            Tool = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InternChatMessage FromTool(global::OpenRouter.InternChatToolMessage? value) => new InternChatMessage(value);

        /// <summary>
        ///
        /// </summary>
        public InternChatMessage(
            global::OpenRouter.InternChatMessageDiscriminatorRole? role,
            global::OpenRouter.InternChatSystemMessage? system,
            global::OpenRouter.InternChatDeveloperMessage? developer,
            global::OpenRouter.InternChatUserMessage? user,
            global::OpenRouter.InternChatAssistantMessage? assistant,
            global::OpenRouter.InternChatToolMessage? tool
            )
        {
            Role = role;

            System = system;
            Developer = developer;
            User = user;
            Assistant = assistant;
            Tool = tool;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Tool as object ??
            Assistant as object ??
            User as object ??
            Developer as object ??
            System as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            System?.ToString() ??
            Developer?.ToString() ??
            User?.ToString() ??
            Assistant?.ToString() ??
            Tool?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSystem && !IsDeveloper && !IsUser && !IsAssistant && !IsTool || !IsSystem && IsDeveloper && !IsUser && !IsAssistant && !IsTool || !IsSystem && !IsDeveloper && IsUser && !IsAssistant && !IsTool || !IsSystem && !IsDeveloper && !IsUser && IsAssistant && !IsTool || !IsSystem && !IsDeveloper && !IsUser && !IsAssistant && IsTool;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.InternChatSystemMessage, TResult>? system = null,
            global::System.Func<global::OpenRouter.InternChatDeveloperMessage, TResult>? developer = null,
            global::System.Func<global::OpenRouter.InternChatUserMessage, TResult>? user = null,
            global::System.Func<global::OpenRouter.InternChatAssistantMessage, TResult>? assistant = null,
            global::System.Func<global::OpenRouter.InternChatToolMessage, TResult>? tool = null,
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
            else if (Developer is { } __value1 && developer != null)
            {
                return developer(__value1);
            }
            else if (User is { } __value2 && user != null)
            {
                return user(__value2);
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
            global::System.Action<global::OpenRouter.InternChatSystemMessage>? system = null,

            global::System.Action<global::OpenRouter.InternChatDeveloperMessage>? developer = null,

            global::System.Action<global::OpenRouter.InternChatUserMessage>? user = null,

            global::System.Action<global::OpenRouter.InternChatAssistantMessage>? assistant = null,

            global::System.Action<global::OpenRouter.InternChatToolMessage>? tool = null,
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
            else if (Developer is { } __value1)
            {
                developer?.Invoke(__value1);
            }
            else if (User is { } __value2)
            {
                user?.Invoke(__value2);
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
            global::System.Action<global::OpenRouter.InternChatSystemMessage>? system = null,
            global::System.Action<global::OpenRouter.InternChatDeveloperMessage>? developer = null,
            global::System.Action<global::OpenRouter.InternChatUserMessage>? user = null,
            global::System.Action<global::OpenRouter.InternChatAssistantMessage>? assistant = null,
            global::System.Action<global::OpenRouter.InternChatToolMessage>? tool = null,
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
            else if (Developer is { } __value1)
            {
                developer?.Invoke(__value1);
            }
            else if (User is { } __value2)
            {
                user?.Invoke(__value2);
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
                typeof(global::OpenRouter.InternChatSystemMessage),
                Developer,
                typeof(global::OpenRouter.InternChatDeveloperMessage),
                User,
                typeof(global::OpenRouter.InternChatUserMessage),
                Assistant,
                typeof(global::OpenRouter.InternChatAssistantMessage),
                Tool,
                typeof(global::OpenRouter.InternChatToolMessage),
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
        public bool Equals(InternChatMessage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InternChatSystemMessage?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InternChatDeveloperMessage?>.Default.Equals(Developer, other.Developer) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InternChatUserMessage?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InternChatAssistantMessage?>.Default.Equals(Assistant, other.Assistant) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InternChatToolMessage?>.Default.Equals(Tool, other.Tool)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(InternChatMessage obj1, InternChatMessage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InternChatMessage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InternChatMessage obj1, InternChatMessage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InternChatMessage o && Equals(o);
        }
    }
}
