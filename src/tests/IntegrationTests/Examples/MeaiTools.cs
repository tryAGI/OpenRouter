/*
order: 20
title: MEAI Tools
slug: meai-tools

Shows how to use OpenRouter as AIFunction tools with any IChatClient.
*/

namespace OpenRouter.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsListModelsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a model listing tool from the OpenRouter client for use with any IChatClient.
        var tool = client.AsListModelsTool();
        tool.Name.Should().Be("ListOpenRouterModels");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsGetModelTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a model details tool for looking up specific model info.
        var tool = client.AsGetModelTool();
        tool.Name.Should().Be("GetOpenRouterModel");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsGetGenerationTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a generation stats tool for auditing request usage.
        var tool = client.AsGetGenerationTool();
        tool.Name.Should().Be("GetOpenRouterGeneration");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsGetCreditsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a credits tool to check remaining balance.
        var tool = client.AsGetCreditsTool();
        tool.Name.Should().Be("GetOpenRouterCredits");
        tool.Description.Should().NotBeNullOrEmpty();
    }
}
