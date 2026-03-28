/*
order: 10
title: Models
slug: models

Shows how to list and search available models on OpenRouter.
*/

namespace OpenRouter.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListModels()
    {
        using var client = GetAuthenticatedClient();

        //// List all available models on OpenRouter.
        var response = await client.SubpackageModels.GetModelsAsync();

        response.Should().NotBeNull();
        response.Data.Should().NotBeNullOrEmpty();
        Console.WriteLine($"Available models: {response.Data.Count}");

        //// Each model includes pricing, context length, and capability info.
        var model = response.Data[0];
        model.Id.Should().NotBeNullOrEmpty();
        model.Name.Should().NotBeNullOrEmpty();
        model.Pricing.Should().NotBeNull();
        Console.WriteLine($"First model: {model.Id} ({model.Name})");
        Console.WriteLine($"  Context: {model.ContextLength}");
        Console.WriteLine($"  Prompt price: {model.Pricing.Prompt}");
    }

    [TestMethod]
    public async Task ListModelsCount()
    {
        using var client = GetAuthenticatedClient();

        //// Get the total count of available models.
        var response = await client.SubpackageModels.ListModelsCountAsync();

        response.Should().NotBeNull();
        response.Data.Count.Should().BeGreaterThan(0);
        Console.WriteLine($"Total models: {response.Data.Count}");
    }

    [TestMethod]
    public async Task ListModelsByCategory()
    {
        using var client = GetAuthenticatedClient();

        //// Filter models by category (e.g., programming).
        var response = await client.SubpackageModels.GetModelsAsync(
            category: ModelsGetParametersCategory.Programming);

        response.Should().NotBeNull();
        response.Data.Should().NotBeNullOrEmpty();
        Console.WriteLine($"Programming models: {response.Data.Count}");
    }
}
