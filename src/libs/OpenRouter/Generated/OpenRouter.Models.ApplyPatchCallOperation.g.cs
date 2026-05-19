#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The patch operation requested by an `apply_patch_call`. `create_file` and `update_file` carry a V4A diff; `delete_file` omits it.
    /// </summary>
    public readonly partial struct ApplyPatchCallOperation : global::System.IEquatable<ApplyPatchCallOperation>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiscriminatorType? Type { get; }

        /// <summary>
        /// The `create_file` variant of an `apply_patch_call.operation`. Carries a V4A diff describing the new file contents.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchCallOperationVariant1? CreateFile { get; init; }
#else
        public global::OpenRouter.ApplyPatchCallOperationVariant1? CreateFile { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateFile))]
#endif
        public bool IsCreateFile => CreateFile != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCreateFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchCallOperationVariant1? value)
        {
            value = CreateFile;
            return IsCreateFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationVariant1 PickCreateFile() => IsCreateFile
            ? CreateFile!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateFile' but the value was {ToString()}.");

        /// <summary>
        /// The `delete_file` variant of an `apply_patch_call.operation`. Identifies the file to remove; no diff is required.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchCallOperationVariant2? DeleteFile { get; init; }
#else
        public global::OpenRouter.ApplyPatchCallOperationVariant2? DeleteFile { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteFile))]
#endif
        public bool IsDeleteFile => DeleteFile != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeleteFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchCallOperationVariant2? value)
        {
            value = DeleteFile;
            return IsDeleteFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationVariant2 PickDeleteFile() => IsDeleteFile
            ? DeleteFile!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeleteFile' but the value was {ToString()}.");

        /// <summary>
        /// The `update_file` variant of an `apply_patch_call.operation`. Carries a V4A diff describing edits to an existing file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchCallOperationVariant3? UpdateFile { get; init; }
#else
        public global::OpenRouter.ApplyPatchCallOperationVariant3? UpdateFile { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateFile))]
#endif
        public bool IsUpdateFile => UpdateFile != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUpdateFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchCallOperationVariant3? value)
        {
            value = UpdateFile;
            return IsUpdateFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationVariant3 PickUpdateFile() => IsUpdateFile
            ? UpdateFile!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpdateFile' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplyPatchCallOperation(global::OpenRouter.ApplyPatchCallOperationVariant1 value) => new ApplyPatchCallOperation((global::OpenRouter.ApplyPatchCallOperationVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchCallOperationVariant1?(ApplyPatchCallOperation @this) => @this.CreateFile;

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchCallOperation(global::OpenRouter.ApplyPatchCallOperationVariant1? value)
        {
            CreateFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ApplyPatchCallOperation FromCreateFile(global::OpenRouter.ApplyPatchCallOperationVariant1? value) => new ApplyPatchCallOperation(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplyPatchCallOperation(global::OpenRouter.ApplyPatchCallOperationVariant2 value) => new ApplyPatchCallOperation((global::OpenRouter.ApplyPatchCallOperationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchCallOperationVariant2?(ApplyPatchCallOperation @this) => @this.DeleteFile;

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchCallOperation(global::OpenRouter.ApplyPatchCallOperationVariant2? value)
        {
            DeleteFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ApplyPatchCallOperation FromDeleteFile(global::OpenRouter.ApplyPatchCallOperationVariant2? value) => new ApplyPatchCallOperation(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplyPatchCallOperation(global::OpenRouter.ApplyPatchCallOperationVariant3 value) => new ApplyPatchCallOperation((global::OpenRouter.ApplyPatchCallOperationVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchCallOperationVariant3?(ApplyPatchCallOperation @this) => @this.UpdateFile;

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchCallOperation(global::OpenRouter.ApplyPatchCallOperationVariant3? value)
        {
            UpdateFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ApplyPatchCallOperation FromUpdateFile(global::OpenRouter.ApplyPatchCallOperationVariant3? value) => new ApplyPatchCallOperation(value);

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchCallOperation(
            global::OpenRouter.ApplyPatchCallOperationDiscriminatorType? type,
            global::OpenRouter.ApplyPatchCallOperationVariant1? createFile,
            global::OpenRouter.ApplyPatchCallOperationVariant2? deleteFile,
            global::OpenRouter.ApplyPatchCallOperationVariant3? updateFile
            )
        {
            Type = type;

            CreateFile = createFile;
            DeleteFile = deleteFile;
            UpdateFile = updateFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UpdateFile as object ??
            DeleteFile as object ??
            CreateFile as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreateFile?.ToString() ??
            DeleteFile?.ToString() ??
            UpdateFile?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreateFile && !IsDeleteFile && !IsUpdateFile || !IsCreateFile && IsDeleteFile && !IsUpdateFile || !IsCreateFile && !IsDeleteFile && IsUpdateFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ApplyPatchCallOperationVariant1, TResult>? createFile = null,
            global::System.Func<global::OpenRouter.ApplyPatchCallOperationVariant2, TResult>? deleteFile = null,
            global::System.Func<global::OpenRouter.ApplyPatchCallOperationVariant3, TResult>? updateFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateFile && createFile != null)
            {
                return createFile(CreateFile!);
            }
            else if (IsDeleteFile && deleteFile != null)
            {
                return deleteFile(DeleteFile!);
            }
            else if (IsUpdateFile && updateFile != null)
            {
                return updateFile(UpdateFile!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ApplyPatchCallOperationVariant1>? createFile = null,

            global::System.Action<global::OpenRouter.ApplyPatchCallOperationVariant2>? deleteFile = null,

            global::System.Action<global::OpenRouter.ApplyPatchCallOperationVariant3>? updateFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateFile)
            {
                createFile?.Invoke(CreateFile!);
            }
            else if (IsDeleteFile)
            {
                deleteFile?.Invoke(DeleteFile!);
            }
            else if (IsUpdateFile)
            {
                updateFile?.Invoke(UpdateFile!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ApplyPatchCallOperationVariant1>? createFile = null,
            global::System.Action<global::OpenRouter.ApplyPatchCallOperationVariant2>? deleteFile = null,
            global::System.Action<global::OpenRouter.ApplyPatchCallOperationVariant3>? updateFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateFile)
            {
                createFile?.Invoke(CreateFile!);
            }
            else if (IsDeleteFile)
            {
                deleteFile?.Invoke(DeleteFile!);
            }
            else if (IsUpdateFile)
            {
                updateFile?.Invoke(UpdateFile!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateFile,
                typeof(global::OpenRouter.ApplyPatchCallOperationVariant1),
                DeleteFile,
                typeof(global::OpenRouter.ApplyPatchCallOperationVariant2),
                UpdateFile,
                typeof(global::OpenRouter.ApplyPatchCallOperationVariant3),
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
        public bool Equals(ApplyPatchCallOperation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchCallOperationVariant1?>.Default.Equals(CreateFile, other.CreateFile) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchCallOperationVariant2?>.Default.Equals(DeleteFile, other.DeleteFile) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchCallOperationVariant3?>.Default.Equals(UpdateFile, other.UpdateFile) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ApplyPatchCallOperation obj1, ApplyPatchCallOperation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ApplyPatchCallOperation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ApplyPatchCallOperation obj1, ApplyPatchCallOperation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ApplyPatchCallOperation o && Equals(o);
        }
    }
}
