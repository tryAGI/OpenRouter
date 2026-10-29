#nullable enable

namespace OpenRouter
{
    public partial interface IPrivateProvidersClient
    {
        /// <summary>
        /// Create a private provider<br/>
        /// Create a private, bring-your-own-key provider visible only to your organization. Use its slug as `provider_slug` when creating private endpoints. Requires both the private endpoints and the private providers entitlements. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreatePrivateProviderResponse> CreateAsync(

            global::OpenRouter.CreatePrivateProviderRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a private provider<br/>
        /// Create a private, bring-your-own-key provider visible only to your organization. Use its slug as `provider_slug` when creating private endpoints. Requires both the private endpoints and the private providers entitlements. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.CreatePrivateProviderResponse>> CreateAsResponseAsync(

            global::OpenRouter.CreatePrivateProviderRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a private provider<br/>
        /// Create a private, bring-your-own-key provider visible only to your organization. Use its slug as `provider_slug` when creating private endpoints. Requires both the private endpoints and the private providers entitlements. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="baseUrl">
        /// HTTPS base URL of an OpenAI-compatible API, used by private endpoints under this provider that set no URL of their own. Without it, each endpoint must set its own. Private, internal, metadata and OpenRouter hosts are rejected.<br/>
        /// Example: https://inference.example.com/v1
        /// </param>
        /// <param name="dataPolicy">
        /// Defaults to training on and retaining prompts, the most conservative declaration. Your own declaration; it applies to your own traffic and OpenRouter does not verify it.<br/>
        /// Example: {"prompt_retention_days":null,"retains_prompts":false,"training":false}
        /// </param>
        /// <param name="displayName">
        /// Defaults to `name`.<br/>
        /// Example: Acme
        /// </param>
        /// <param name="name">
        /// Provider name, shown in your activity, logs and Broadcast output. 2-64 letters, numbers, spaces, dots, underscores or hyphens. Cannot be changed later. Neither the name nor its slug may match a public provider name or slug (case-insensitive); other customers may use the same name.<br/>
        /// Example: Acme
        /// </param>
        /// <param name="slug">
        /// 2-64 lowercase letters and numbers, separated by single hyphens. Cannot be changed later. Defaults to the name lowercased, with every run of other characters replaced by a hyphen (`Acme Inference` becomes `acme-inference`).<br/>
        /// Example: acme
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreatePrivateProviderResponse> CreateAsync(
            string name,
            string? baseUrl = default,
            global::OpenRouter.PrivateProviderDataPolicy2? dataPolicy = default,
            string? displayName = default,
            string? slug = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}