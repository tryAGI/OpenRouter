#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems : global::System.IEquatable<EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 { get; init; }
#else
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0))]
#endif
        public bool IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 => EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0? value)
        {
            value = EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0;
            return IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 PickEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0() => IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0
            ? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 { get; init; }
#else
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1))]
#endif
        public bool IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 => EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1? value)
        {
            value = EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1;
            return IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 PickEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1() => IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1
            ? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ContentPartInputAudio? ContentPartInputAudio { get; init; }
#else
        public global::OpenRouter.ContentPartInputAudio? ContentPartInputAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentPartInputAudio))]
#endif
        public bool IsContentPartInputAudio => ContentPartInputAudio != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickContentPartInputAudio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ContentPartInputAudio? value)
        {
            value = ContentPartInputAudio;
            return IsContentPartInputAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ContentPartInputAudio PickContentPartInputAudio() => IsContentPartInputAudio
            ? ContentPartInputAudio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentPartInputAudio' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ContentPartInputVideo? ContentPartInputVideo { get; init; }
#else
        public global::OpenRouter.ContentPartInputVideo? ContentPartInputVideo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentPartInputVideo))]
#endif
        public bool IsContentPartInputVideo => ContentPartInputVideo != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickContentPartInputVideo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ContentPartInputVideo? value)
        {
            value = ContentPartInputVideo;
            return IsContentPartInputVideo;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ContentPartInputVideo PickContentPartInputVideo() => IsContentPartInputVideo
            ? ContentPartInputVideo!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentPartInputVideo' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ContentPartInputFile? ContentPartInputFile { get; init; }
#else
        public global::OpenRouter.ContentPartInputFile? ContentPartInputFile { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentPartInputFile))]
#endif
        public bool IsContentPartInputFile => ContentPartInputFile != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickContentPartInputFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ContentPartInputFile? value)
        {
            value = ContentPartInputFile;
            return IsContentPartInputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ContentPartInputFile PickContentPartInputFile() => IsContentPartInputFile
            ? ContentPartInputFile!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentPartInputFile' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems((global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0?(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems @this) => @this.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0? value)
        {
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems FromEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0? value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems((global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1?(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems @this) => @this.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1? value)
        {
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems FromEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1? value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(global::OpenRouter.ContentPartInputAudio value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems((global::OpenRouter.ContentPartInputAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ContentPartInputAudio?(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems @this) => @this.ContentPartInputAudio;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(global::OpenRouter.ContentPartInputAudio? value)
        {
            ContentPartInputAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems FromContentPartInputAudio(global::OpenRouter.ContentPartInputAudio? value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(global::OpenRouter.ContentPartInputVideo value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems((global::OpenRouter.ContentPartInputVideo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ContentPartInputVideo?(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems @this) => @this.ContentPartInputVideo;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(global::OpenRouter.ContentPartInputVideo? value)
        {
            ContentPartInputVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems FromContentPartInputVideo(global::OpenRouter.ContentPartInputVideo? value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(global::OpenRouter.ContentPartInputFile value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems((global::OpenRouter.ContentPartInputFile?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ContentPartInputFile?(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems @this) => @this.ContentPartInputFile;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(global::OpenRouter.ContentPartInputFile? value)
        {
            ContentPartInputFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems FromContentPartInputFile(global::OpenRouter.ContentPartInputFile? value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(value);

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(
            global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0,
            global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1,
            global::OpenRouter.ContentPartInputAudio? contentPartInputAudio,
            global::OpenRouter.ContentPartInputVideo? contentPartInputVideo,
            global::OpenRouter.ContentPartInputFile? contentPartInputFile
            )
        {
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 = embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0;
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 = embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1;
            ContentPartInputAudio = contentPartInputAudio;
            ContentPartInputVideo = contentPartInputVideo;
            ContentPartInputFile = contentPartInputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ContentPartInputFile as object ??
            ContentPartInputVideo as object ??
            ContentPartInputAudio as object ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 as object ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0?.ToString() ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1?.ToString() ??
            ContentPartInputAudio?.ToString() ??
            ContentPartInputVideo?.ToString() ??
            ContentPartInputFile?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 && !IsContentPartInputAudio && !IsContentPartInputVideo && !IsContentPartInputFile || !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 && IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 && !IsContentPartInputAudio && !IsContentPartInputVideo && !IsContentPartInputFile || !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 && IsContentPartInputAudio && !IsContentPartInputVideo && !IsContentPartInputFile || !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 && !IsContentPartInputAudio && IsContentPartInputVideo && !IsContentPartInputFile || !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 && !IsContentPartInputAudio && !IsContentPartInputVideo && IsContentPartInputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0, TResult>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 = null,
            global::System.Func<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1, TResult>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 = null,
            global::System.Func<global::OpenRouter.ContentPartInputAudio, TResult>? contentPartInputAudio = null,
            global::System.Func<global::OpenRouter.ContentPartInputVideo, TResult>? contentPartInputVideo = null,
            global::System.Func<global::OpenRouter.ContentPartInputFile, TResult>? contentPartInputFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 && embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 != null)
            {
                return embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0!);
            }
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 && embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 != null)
            {
                return embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1!);
            }
            else if (IsContentPartInputAudio && contentPartInputAudio != null)
            {
                return contentPartInputAudio(ContentPartInputAudio!);
            }
            else if (IsContentPartInputVideo && contentPartInputVideo != null)
            {
                return contentPartInputVideo(ContentPartInputVideo!);
            }
            else if (IsContentPartInputFile && contentPartInputFile != null)
            {
                return contentPartInputFile(ContentPartInputFile!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 = null,

            global::System.Action<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 = null,

            global::System.Action<global::OpenRouter.ContentPartInputAudio>? contentPartInputAudio = null,

            global::System.Action<global::OpenRouter.ContentPartInputVideo>? contentPartInputVideo = null,

            global::System.Action<global::OpenRouter.ContentPartInputFile>? contentPartInputFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0!);
            }
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1!);
            }
            else if (IsContentPartInputAudio)
            {
                contentPartInputAudio?.Invoke(ContentPartInputAudio!);
            }
            else if (IsContentPartInputVideo)
            {
                contentPartInputVideo?.Invoke(ContentPartInputVideo!);
            }
            else if (IsContentPartInputFile)
            {
                contentPartInputFile?.Invoke(ContentPartInputFile!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 = null,
            global::System.Action<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 = null,
            global::System.Action<global::OpenRouter.ContentPartInputAudio>? contentPartInputAudio = null,
            global::System.Action<global::OpenRouter.ContentPartInputVideo>? contentPartInputVideo = null,
            global::System.Action<global::OpenRouter.ContentPartInputFile>? contentPartInputFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0!);
            }
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1!);
            }
            else if (IsContentPartInputAudio)
            {
                contentPartInputAudio?.Invoke(ContentPartInputAudio!);
            }
            else if (IsContentPartInputVideo)
            {
                contentPartInputVideo?.Invoke(ContentPartInputVideo!);
            }
            else if (IsContentPartInputFile)
            {
                contentPartInputFile?.Invoke(ContentPartInputFile!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0,
                typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0),
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1,
                typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1),
                ContentPartInputAudio,
                typeof(global::OpenRouter.ContentPartInputAudio),
                ContentPartInputVideo,
                typeof(global::OpenRouter.ContentPartInputVideo),
                ContentPartInputFile,
                typeof(global::OpenRouter.ContentPartInputFile),
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
        public bool Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0?>.Default.Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0, other.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1?>.Default.Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1, other.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ContentPartInputAudio?>.Default.Equals(ContentPartInputAudio, other.ContentPartInputAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ContentPartInputVideo?>.Default.Equals(ContentPartInputVideo, other.ContentPartInputVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ContentPartInputFile?>.Default.Equals(ContentPartInputFile, other.ContentPartInputFile) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems obj1, EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems obj1, EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems o && Equals(o);
        }
    }
}
