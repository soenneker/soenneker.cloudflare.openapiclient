[![](https://img.shields.io/nuget/v/soenneker.cloudflare.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.cloudflare.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.cloudflare.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.cloudflare.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.cloudflare.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.cloudflare.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.cloudflare.openapiclient/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.cloudflare.openapiclient/actions/workflows/codeql.yml)

# Soenneker.Cloudflare.OpenApiClient

A Kiota-generated .NET client for Cloudflare's v4 API.

## Installation

```bash
dotnet add package Soenneker.Cloudflare.OpenApiClient
```

## Recommended setup

For dependency injection, bearer-token configuration, and managed HTTP-client reuse, install `Soenneker.Cloudflare.Utils.Client` and register its client utility.

```bash
dotnet add package Soenneker.Cloudflare.Utils.Client
```

```csharp
using Soenneker.Cloudflare.Utils.Client.Registrars;

services.AddCloudflareClientUtilAsSingleton();
```

## Direct construction

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Cloudflare.OpenApiClient;
using Soenneker.Cloudflare.OpenApiClient.Models;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", "your-api-token");

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);

var cloudflare = new CloudflareOpenApiClient(adapter);

Zones0Get200? response = await cloudflare.Zones[zoneId].GetAsync(
    cancellationToken: cancellationToken);
```

Keep the `HttpClient`, adapter, and generated client long-lived. Do not attach Cloudflare credentials to an HTTP client that can send requests to unrelated hosts.

## Generated surface

The root client mirrors Cloudflare's account-, zone-, user-, and certificate-level API paths. The generated API is very large, and names can reflect schema wording rather than idiomatic C# conventions. Endpoint methods typically accept a request-configuration callback and cancellation token.

Models, request builders, and nullable response shapes can change when Cloudflare's OpenAPI document changes. Review package upgrades when your code depends on generated names. Keep custom behavior outside the generated source tree.
