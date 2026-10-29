#nullable enable

namespace OpenRouter
{
    public partial interface IVaultClient
    {
        /// <summary>
        /// List the connections an intern can use<br/>
        /// Lists the connections in scope for the intern, by the key of their card on the dashboard's Connections tab: `github`, `slack`, `google`, a catalog MCP server such as `linear` or `notion`, or `mcp:&lt;host&gt;` for a custom MCP server. A connection is listed when it is stored, enabled, and not turned off or hidden for this intern, as the Connections tab lists it; whether its last test passed is not part of the rule. `ori features add` checks a feature's `ori.requires.connections` against this list. `routing` is the vault's routing table for the intern: the credentials it holds and what it would inject each for, from the same lookups the egress proxy picks a credential with, GitHub repository coverage read through the installation token and cached. `routing_text` is that table as the lines the intern reads in its instructions. Never credentials. Returns 404 for an intern the key cannot see. The scope is selected by the API key: workspace routes act on the key's active workspace and intern routes act on one intern inside that workspace. There is no default workspace and no fallback to another scope. Every vault route, including reads, requires access to the Intern API programme and returns 404 outside it. An intern's own API key is confined to that intern: it can always read the intern's secrets and effective secrets, writes to them follow the rules above, and every other intern and every workspace route answers 404. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="internId">
        /// UUID of an intern in the workspace selected by the API key.<br/>
        /// Example: 7c9e6679-7425-40de-944b-e07fc1f90ae7
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ListInternConnectionsResponse> ListInternConnectionsAsync(
            global::System.Guid internId,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List the connections an intern can use<br/>
        /// Lists the connections in scope for the intern, by the key of their card on the dashboard's Connections tab: `github`, `slack`, `google`, a catalog MCP server such as `linear` or `notion`, or `mcp:&lt;host&gt;` for a custom MCP server. A connection is listed when it is stored, enabled, and not turned off or hidden for this intern, as the Connections tab lists it; whether its last test passed is not part of the rule. `ori features add` checks a feature's `ori.requires.connections` against this list. `routing` is the vault's routing table for the intern: the credentials it holds and what it would inject each for, from the same lookups the egress proxy picks a credential with, GitHub repository coverage read through the installation token and cached. `routing_text` is that table as the lines the intern reads in its instructions. Never credentials. Returns 404 for an intern the key cannot see. The scope is selected by the API key: workspace routes act on the key's active workspace and intern routes act on one intern inside that workspace. There is no default workspace and no fallback to another scope. Every vault route, including reads, requires access to the Intern API programme and returns 404 outside it. An intern's own API key is confined to that intern: it can always read the intern's secrets and effective secrets, writes to them follow the rules above, and every other intern and every workspace route answers 404. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="internId">
        /// UUID of an intern in the workspace selected by the API key.<br/>
        /// Example: 7c9e6679-7425-40de-944b-e07fc1f90ae7
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ListInternConnectionsResponse>> ListInternConnectionsAsResponseAsync(
            global::System.Guid internId,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}