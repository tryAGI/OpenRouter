#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A preset with its currently designated version.<br/>
    /// Example: {"created_at":"2026-04-20T10:00:00Z","creator_user_id":"user_2dHFtVWx2n56w6HkM0000000000","description":null,"designated_version":{"config":{"model":"openai/gpt-4o","temperature":0.7},"created_at":"2026-04-20T10:00:00Z","creator_id":"user_2dHFtVWx2n56w6HkM0000000000","id":"550e8400-e29b-41d4-a716-446655440000","preset_id":"650e8400-e29b-41d4-a716-446655440001","system_prompt":"You are a helpful assistant.","updated_at":"2026-04-20T10:00:00Z","version":1},"designated_version_id":"550e8400-e29b-41d4-a716-446655440000","id":"650e8400-e29b-41d4-a716-446655440001","name":"my-preset","slug":"my-preset","status":"active","status_updated_at":null,"updated_at":"2026-04-20T10:00:00Z","workspace_id":"750e8400-e29b-41d4-a716-446655440002"}
    /// </summary>
    public readonly partial struct PresetWithDesignatedVersion : global::System.IEquatable<PresetWithDesignatedVersion>
    {
        /// <summary>
        /// A preset without version details.<br/>
        /// Example: {"created_at":"2026-04-20T10:00:00Z","creator_user_id":"user_2dHFtVWx2n56w6HkM0000000000","description":null,"designated_version_id":"550e8400-e29b-41d4-a716-446655440000","id":"650e8400-e29b-41d4-a716-446655440001","name":"my-preset","slug":"my-preset","status":"active","status_updated_at":null,"updated_at":"2026-04-20T10:00:00Z","workspace_id":"750e8400-e29b-41d4-a716-446655440002"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.Preset? Preset { get; init; }
#else
        public global::OpenRouter.Preset? Preset { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Preset))]
#endif
        public bool IsPreset => Preset != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPreset(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.Preset? value)
        {
            value = Preset;
            return IsPreset;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Preset PickPreset() => Preset is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Preset' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.PresetWithDesignatedVersionVariant2? PresetWithDesignatedVersionVariant2 { get; init; }
#else
        public global::OpenRouter.PresetWithDesignatedVersionVariant2? PresetWithDesignatedVersionVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PresetWithDesignatedVersionVariant2))]
#endif
        public bool IsPresetWithDesignatedVersionVariant2 => PresetWithDesignatedVersionVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPresetWithDesignatedVersionVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.PresetWithDesignatedVersionVariant2? value)
        {
            value = PresetWithDesignatedVersionVariant2;
            return IsPresetWithDesignatedVersionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PresetWithDesignatedVersionVariant2 PickPresetWithDesignatedVersionVariant2() => PresetWithDesignatedVersionVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PresetWithDesignatedVersionVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PresetWithDesignatedVersion(global::OpenRouter.Preset value) => new PresetWithDesignatedVersion((global::OpenRouter.Preset?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.Preset?(PresetWithDesignatedVersion @this) => @this.Preset;

        /// <summary>
        ///
        /// </summary>
        public PresetWithDesignatedVersion(global::OpenRouter.Preset? value)
        {
            Preset = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PresetWithDesignatedVersion FromPreset(global::OpenRouter.Preset? value) => new PresetWithDesignatedVersion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PresetWithDesignatedVersion(global::OpenRouter.PresetWithDesignatedVersionVariant2 value) => new PresetWithDesignatedVersion((global::OpenRouter.PresetWithDesignatedVersionVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.PresetWithDesignatedVersionVariant2?(PresetWithDesignatedVersion @this) => @this.PresetWithDesignatedVersionVariant2;

        /// <summary>
        ///
        /// </summary>
        public PresetWithDesignatedVersion(global::OpenRouter.PresetWithDesignatedVersionVariant2? value)
        {
            PresetWithDesignatedVersionVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PresetWithDesignatedVersion FromPresetWithDesignatedVersionVariant2(global::OpenRouter.PresetWithDesignatedVersionVariant2? value) => new PresetWithDesignatedVersion(value);

        /// <summary>
        ///
        /// </summary>
        public PresetWithDesignatedVersion(
            global::OpenRouter.Preset? preset,
            global::OpenRouter.PresetWithDesignatedVersionVariant2? presetWithDesignatedVersionVariant2
            )
        {
            Preset = preset;
            PresetWithDesignatedVersionVariant2 = presetWithDesignatedVersionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PresetWithDesignatedVersionVariant2 as object ??
            Preset as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Preset?.ToString() ??
            PresetWithDesignatedVersionVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPreset && IsPresetWithDesignatedVersionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.Preset, TResult>? preset = null,
            global::System.Func<global::OpenRouter.PresetWithDesignatedVersionVariant2, TResult>? presetWithDesignatedVersionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Preset is { } __value0 && preset != null)
            {
                return preset(__value0);
            }
            else if (PresetWithDesignatedVersionVariant2 is { } __value1 && presetWithDesignatedVersionVariant2 != null)
            {
                return presetWithDesignatedVersionVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.Preset>? preset = null,

            global::System.Action<global::OpenRouter.PresetWithDesignatedVersionVariant2>? presetWithDesignatedVersionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Preset is { } __value0)
            {
                preset?.Invoke(__value0);
            }
            else if (PresetWithDesignatedVersionVariant2 is { } __value1)
            {
                presetWithDesignatedVersionVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.Preset>? preset = null,
            global::System.Action<global::OpenRouter.PresetWithDesignatedVersionVariant2>? presetWithDesignatedVersionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Preset is { } __value0)
            {
                preset?.Invoke(__value0);
            }
            else if (PresetWithDesignatedVersionVariant2 is { } __value1)
            {
                presetWithDesignatedVersionVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Preset,
                typeof(global::OpenRouter.Preset),
                PresetWithDesignatedVersionVariant2,
                typeof(global::OpenRouter.PresetWithDesignatedVersionVariant2),
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
        public bool Equals(PresetWithDesignatedVersion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.Preset?>.Default.Equals(Preset, other.Preset) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.PresetWithDesignatedVersionVariant2?>.Default.Equals(PresetWithDesignatedVersionVariant2, other.PresetWithDesignatedVersionVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PresetWithDesignatedVersion obj1, PresetWithDesignatedVersion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PresetWithDesignatedVersion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PresetWithDesignatedVersion obj1, PresetWithDesignatedVersion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PresetWithDesignatedVersion o && Equals(o);
        }
    }
}
