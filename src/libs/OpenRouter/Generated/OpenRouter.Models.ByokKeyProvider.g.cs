
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The upstream provider this credential authenticates against, as a lowercase slug (e.g. `openai`, `anthropic`, `amazon-bedrock`).
    /// </summary>
    public enum ByokKeyProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Ai21,
        /// <summary>
        /// 
        /// </summary>
        AionLabs,
        /// <summary>
        /// 
        /// </summary>
        Akashml,
        /// <summary>
        /// 
        /// </summary>
        Alibaba,
        /// <summary>
        /// 
        /// </summary>
        AmazonBedrock,
        /// <summary>
        /// 
        /// </summary>
        AmazonNova,
        /// <summary>
        /// 
        /// </summary>
        Ambient,
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        ArceeAi,
        /// <summary>
        /// 
        /// </summary>
        AtlasCloud,
        /// <summary>
        /// 
        /// </summary>
        Avian,
        /// <summary>
        /// 
        /// </summary>
        Azure,
        /// <summary>
        /// 
        /// </summary>
        Baidu,
        /// <summary>
        /// 
        /// </summary>
        Baseten,
        /// <summary>
        /// 
        /// </summary>
        BlackForestLabs,
        /// <summary>
        /// 
        /// </summary>
        Byteplus,
        /// <summary>
        /// 
        /// </summary>
        Cerebras,
        /// <summary>
        /// 
        /// </summary>
        Chutes,
        /// <summary>
        /// 
        /// </summary>
        Cirrascale,
        /// <summary>
        /// 
        /// </summary>
        Clarifai,
        /// <summary>
        /// 
        /// </summary>
        Cloudflare,
        /// <summary>
        /// 
        /// </summary>
        Cohere,
        /// <summary>
        /// 
        /// </summary>
        Crusoe,
        /// <summary>
        /// 
        /// </summary>
        Deepinfra,
        /// <summary>
        /// 
        /// </summary>
        Deepseek,
        /// <summary>
        /// 
        /// </summary>
        Dekallm,
        /// <summary>
        /// 
        /// </summary>
        Featherless,
        /// <summary>
        /// 
        /// </summary>
        Fireworks,
        /// <summary>
        /// 
        /// </summary>
        Friendli,
        /// <summary>
        /// 
        /// </summary>
        Gmicloud,
        /// <summary>
        /// 
        /// </summary>
        GoogleAiStudio,
        /// <summary>
        /// 
        /// </summary>
        GoogleVertex,
        /// <summary>
        /// 
        /// </summary>
        Groq,
        /// <summary>
        /// 
        /// </summary>
        Hyperbolic,
        /// <summary>
        /// 
        /// </summary>
        Inception,
        /// <summary>
        /// 
        /// </summary>
        Inceptron,
        /// <summary>
        /// 
        /// </summary>
        InferenceNet,
        /// <summary>
        /// 
        /// </summary>
        Infermatic,
        /// <summary>
        /// 
        /// </summary>
        Inflection,
        /// <summary>
        /// 
        /// </summary>
        IoNet,
        /// <summary>
        /// 
        /// </summary>
        Ionstream,
        /// <summary>
        /// 
        /// </summary>
        Liquid,
        /// <summary>
        /// 
        /// </summary>
        Mancer,
        /// <summary>
        /// 
        /// </summary>
        Mara,
        /// <summary>
        /// 
        /// </summary>
        Minimax,
        /// <summary>
        /// 
        /// </summary>
        Mistral,
        /// <summary>
        /// 
        /// </summary>
        Modelrun,
        /// <summary>
        /// 
        /// </summary>
        Modular,
        /// <summary>
        /// 
        /// </summary>
        Moonshotai,
        /// <summary>
        /// 
        /// </summary>
        Morph,
        /// <summary>
        /// 
        /// </summary>
        Ncompass,
        /// <summary>
        /// 
        /// </summary>
        Nebius,
        /// <summary>
        /// 
        /// </summary>
        NexAgi,
        /// <summary>
        /// 
        /// </summary>
        Nextbit,
        /// <summary>
        /// 
        /// </summary>
        Novita,
        /// <summary>
        /// 
        /// </summary>
        Nvidia,
        /// <summary>
        /// 
        /// </summary>
        OpenInference,
        /// <summary>
        /// 
        /// </summary>
        Openai,
        /// <summary>
        /// 
        /// </summary>
        Parasail,
        /// <summary>
        /// 
        /// </summary>
        Perceptron,
        /// <summary>
        /// 
        /// </summary>
        Perplexity,
        /// <summary>
        /// 
        /// </summary>
        Phala,
        /// <summary>
        /// 
        /// </summary>
        Poolside,
        /// <summary>
        /// 
        /// </summary>
        Recraft,
        /// <summary>
        /// 
        /// </summary>
        Reka,
        /// <summary>
        /// 
        /// </summary>
        Relace,
        /// <summary>
        /// 
        /// </summary>
        Sambanova,
        /// <summary>
        /// 
        /// </summary>
        Seed,
        /// <summary>
        /// 
        /// </summary>
        Siliconflow,
        /// <summary>
        /// 
        /// </summary>
        Sourceful,
        /// <summary>
        /// 
        /// </summary>
        Stepfun,
        /// <summary>
        /// 
        /// </summary>
        Streamlake,
        /// <summary>
        /// 
        /// </summary>
        Switchpoint,
        /// <summary>
        /// 
        /// </summary>
        Together,
        /// <summary>
        /// 
        /// </summary>
        Upstage,
        /// <summary>
        /// 
        /// </summary>
        Venice,
        /// <summary>
        /// 
        /// </summary>
        Wandb,
        /// <summary>
        /// 
        /// </summary>
        Xai,
        /// <summary>
        /// 
        /// </summary>
        Xiaomi,
        /// <summary>
        /// 
        /// </summary>
        ZAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ByokKeyProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ByokKeyProvider value)
        {
            return value switch
            {
                ByokKeyProvider.Ai21 => "ai21",
                ByokKeyProvider.AionLabs => "aion-labs",
                ByokKeyProvider.Akashml => "akashml",
                ByokKeyProvider.Alibaba => "alibaba",
                ByokKeyProvider.AmazonBedrock => "amazon-bedrock",
                ByokKeyProvider.AmazonNova => "amazon-nova",
                ByokKeyProvider.Ambient => "ambient",
                ByokKeyProvider.Anthropic => "anthropic",
                ByokKeyProvider.ArceeAi => "arcee-ai",
                ByokKeyProvider.AtlasCloud => "atlas-cloud",
                ByokKeyProvider.Avian => "avian",
                ByokKeyProvider.Azure => "azure",
                ByokKeyProvider.Baidu => "baidu",
                ByokKeyProvider.Baseten => "baseten",
                ByokKeyProvider.BlackForestLabs => "black-forest-labs",
                ByokKeyProvider.Byteplus => "byteplus",
                ByokKeyProvider.Cerebras => "cerebras",
                ByokKeyProvider.Chutes => "chutes",
                ByokKeyProvider.Cirrascale => "cirrascale",
                ByokKeyProvider.Clarifai => "clarifai",
                ByokKeyProvider.Cloudflare => "cloudflare",
                ByokKeyProvider.Cohere => "cohere",
                ByokKeyProvider.Crusoe => "crusoe",
                ByokKeyProvider.Deepinfra => "deepinfra",
                ByokKeyProvider.Deepseek => "deepseek",
                ByokKeyProvider.Dekallm => "dekallm",
                ByokKeyProvider.Featherless => "featherless",
                ByokKeyProvider.Fireworks => "fireworks",
                ByokKeyProvider.Friendli => "friendli",
                ByokKeyProvider.Gmicloud => "gmicloud",
                ByokKeyProvider.GoogleAiStudio => "google-ai-studio",
                ByokKeyProvider.GoogleVertex => "google-vertex",
                ByokKeyProvider.Groq => "groq",
                ByokKeyProvider.Hyperbolic => "hyperbolic",
                ByokKeyProvider.Inception => "inception",
                ByokKeyProvider.Inceptron => "inceptron",
                ByokKeyProvider.InferenceNet => "inference-net",
                ByokKeyProvider.Infermatic => "infermatic",
                ByokKeyProvider.Inflection => "inflection",
                ByokKeyProvider.IoNet => "io-net",
                ByokKeyProvider.Ionstream => "ionstream",
                ByokKeyProvider.Liquid => "liquid",
                ByokKeyProvider.Mancer => "mancer",
                ByokKeyProvider.Mara => "mara",
                ByokKeyProvider.Minimax => "minimax",
                ByokKeyProvider.Mistral => "mistral",
                ByokKeyProvider.Modelrun => "modelrun",
                ByokKeyProvider.Modular => "modular",
                ByokKeyProvider.Moonshotai => "moonshotai",
                ByokKeyProvider.Morph => "morph",
                ByokKeyProvider.Ncompass => "ncompass",
                ByokKeyProvider.Nebius => "nebius",
                ByokKeyProvider.NexAgi => "nex-agi",
                ByokKeyProvider.Nextbit => "nextbit",
                ByokKeyProvider.Novita => "novita",
                ByokKeyProvider.Nvidia => "nvidia",
                ByokKeyProvider.OpenInference => "open-inference",
                ByokKeyProvider.Openai => "openai",
                ByokKeyProvider.Parasail => "parasail",
                ByokKeyProvider.Perceptron => "perceptron",
                ByokKeyProvider.Perplexity => "perplexity",
                ByokKeyProvider.Phala => "phala",
                ByokKeyProvider.Poolside => "poolside",
                ByokKeyProvider.Recraft => "recraft",
                ByokKeyProvider.Reka => "reka",
                ByokKeyProvider.Relace => "relace",
                ByokKeyProvider.Sambanova => "sambanova",
                ByokKeyProvider.Seed => "seed",
                ByokKeyProvider.Siliconflow => "siliconflow",
                ByokKeyProvider.Sourceful => "sourceful",
                ByokKeyProvider.Stepfun => "stepfun",
                ByokKeyProvider.Streamlake => "streamlake",
                ByokKeyProvider.Switchpoint => "switchpoint",
                ByokKeyProvider.Together => "together",
                ByokKeyProvider.Upstage => "upstage",
                ByokKeyProvider.Venice => "venice",
                ByokKeyProvider.Wandb => "wandb",
                ByokKeyProvider.Xai => "xai",
                ByokKeyProvider.Xiaomi => "xiaomi",
                ByokKeyProvider.ZAi => "z-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ByokKeyProvider? ToEnum(string value)
        {
            return value switch
            {
                "ai21" => ByokKeyProvider.Ai21,
                "aion-labs" => ByokKeyProvider.AionLabs,
                "akashml" => ByokKeyProvider.Akashml,
                "alibaba" => ByokKeyProvider.Alibaba,
                "amazon-bedrock" => ByokKeyProvider.AmazonBedrock,
                "amazon-nova" => ByokKeyProvider.AmazonNova,
                "ambient" => ByokKeyProvider.Ambient,
                "anthropic" => ByokKeyProvider.Anthropic,
                "arcee-ai" => ByokKeyProvider.ArceeAi,
                "atlas-cloud" => ByokKeyProvider.AtlasCloud,
                "avian" => ByokKeyProvider.Avian,
                "azure" => ByokKeyProvider.Azure,
                "baidu" => ByokKeyProvider.Baidu,
                "baseten" => ByokKeyProvider.Baseten,
                "black-forest-labs" => ByokKeyProvider.BlackForestLabs,
                "byteplus" => ByokKeyProvider.Byteplus,
                "cerebras" => ByokKeyProvider.Cerebras,
                "chutes" => ByokKeyProvider.Chutes,
                "cirrascale" => ByokKeyProvider.Cirrascale,
                "clarifai" => ByokKeyProvider.Clarifai,
                "cloudflare" => ByokKeyProvider.Cloudflare,
                "cohere" => ByokKeyProvider.Cohere,
                "crusoe" => ByokKeyProvider.Crusoe,
                "deepinfra" => ByokKeyProvider.Deepinfra,
                "deepseek" => ByokKeyProvider.Deepseek,
                "dekallm" => ByokKeyProvider.Dekallm,
                "featherless" => ByokKeyProvider.Featherless,
                "fireworks" => ByokKeyProvider.Fireworks,
                "friendli" => ByokKeyProvider.Friendli,
                "gmicloud" => ByokKeyProvider.Gmicloud,
                "google-ai-studio" => ByokKeyProvider.GoogleAiStudio,
                "google-vertex" => ByokKeyProvider.GoogleVertex,
                "groq" => ByokKeyProvider.Groq,
                "hyperbolic" => ByokKeyProvider.Hyperbolic,
                "inception" => ByokKeyProvider.Inception,
                "inceptron" => ByokKeyProvider.Inceptron,
                "inference-net" => ByokKeyProvider.InferenceNet,
                "infermatic" => ByokKeyProvider.Infermatic,
                "inflection" => ByokKeyProvider.Inflection,
                "io-net" => ByokKeyProvider.IoNet,
                "ionstream" => ByokKeyProvider.Ionstream,
                "liquid" => ByokKeyProvider.Liquid,
                "mancer" => ByokKeyProvider.Mancer,
                "mara" => ByokKeyProvider.Mara,
                "minimax" => ByokKeyProvider.Minimax,
                "mistral" => ByokKeyProvider.Mistral,
                "modelrun" => ByokKeyProvider.Modelrun,
                "modular" => ByokKeyProvider.Modular,
                "moonshotai" => ByokKeyProvider.Moonshotai,
                "morph" => ByokKeyProvider.Morph,
                "ncompass" => ByokKeyProvider.Ncompass,
                "nebius" => ByokKeyProvider.Nebius,
                "nex-agi" => ByokKeyProvider.NexAgi,
                "nextbit" => ByokKeyProvider.Nextbit,
                "novita" => ByokKeyProvider.Novita,
                "nvidia" => ByokKeyProvider.Nvidia,
                "open-inference" => ByokKeyProvider.OpenInference,
                "openai" => ByokKeyProvider.Openai,
                "parasail" => ByokKeyProvider.Parasail,
                "perceptron" => ByokKeyProvider.Perceptron,
                "perplexity" => ByokKeyProvider.Perplexity,
                "phala" => ByokKeyProvider.Phala,
                "poolside" => ByokKeyProvider.Poolside,
                "recraft" => ByokKeyProvider.Recraft,
                "reka" => ByokKeyProvider.Reka,
                "relace" => ByokKeyProvider.Relace,
                "sambanova" => ByokKeyProvider.Sambanova,
                "seed" => ByokKeyProvider.Seed,
                "siliconflow" => ByokKeyProvider.Siliconflow,
                "sourceful" => ByokKeyProvider.Sourceful,
                "stepfun" => ByokKeyProvider.Stepfun,
                "streamlake" => ByokKeyProvider.Streamlake,
                "switchpoint" => ByokKeyProvider.Switchpoint,
                "together" => ByokKeyProvider.Together,
                "upstage" => ByokKeyProvider.Upstage,
                "venice" => ByokKeyProvider.Venice,
                "wandb" => ByokKeyProvider.Wandb,
                "xai" => ByokKeyProvider.Xai,
                "xiaomi" => ByokKeyProvider.Xiaomi,
                "z-ai" => ByokKeyProvider.ZAi,
                _ => null,
            };
        }
    }
}