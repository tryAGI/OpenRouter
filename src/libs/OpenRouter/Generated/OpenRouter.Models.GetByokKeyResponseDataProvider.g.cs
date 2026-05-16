
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The upstream provider this credential authenticates against, as a lowercase slug (e.g. `openai`, `anthropic`, `amazon-bedrock`).
    /// </summary>
    public enum GetByokKeyResponseDataProvider
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
    public static class GetByokKeyResponseDataProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetByokKeyResponseDataProvider value)
        {
            return value switch
            {
                GetByokKeyResponseDataProvider.Ai21 => "ai21",
                GetByokKeyResponseDataProvider.AionLabs => "aion-labs",
                GetByokKeyResponseDataProvider.Akashml => "akashml",
                GetByokKeyResponseDataProvider.Alibaba => "alibaba",
                GetByokKeyResponseDataProvider.AmazonBedrock => "amazon-bedrock",
                GetByokKeyResponseDataProvider.AmazonNova => "amazon-nova",
                GetByokKeyResponseDataProvider.Ambient => "ambient",
                GetByokKeyResponseDataProvider.Anthropic => "anthropic",
                GetByokKeyResponseDataProvider.ArceeAi => "arcee-ai",
                GetByokKeyResponseDataProvider.AtlasCloud => "atlas-cloud",
                GetByokKeyResponseDataProvider.Avian => "avian",
                GetByokKeyResponseDataProvider.Azure => "azure",
                GetByokKeyResponseDataProvider.Baidu => "baidu",
                GetByokKeyResponseDataProvider.Baseten => "baseten",
                GetByokKeyResponseDataProvider.BlackForestLabs => "black-forest-labs",
                GetByokKeyResponseDataProvider.Byteplus => "byteplus",
                GetByokKeyResponseDataProvider.Cerebras => "cerebras",
                GetByokKeyResponseDataProvider.Chutes => "chutes",
                GetByokKeyResponseDataProvider.Cirrascale => "cirrascale",
                GetByokKeyResponseDataProvider.Clarifai => "clarifai",
                GetByokKeyResponseDataProvider.Cloudflare => "cloudflare",
                GetByokKeyResponseDataProvider.Cohere => "cohere",
                GetByokKeyResponseDataProvider.Crusoe => "crusoe",
                GetByokKeyResponseDataProvider.Deepinfra => "deepinfra",
                GetByokKeyResponseDataProvider.Deepseek => "deepseek",
                GetByokKeyResponseDataProvider.Dekallm => "dekallm",
                GetByokKeyResponseDataProvider.Featherless => "featherless",
                GetByokKeyResponseDataProvider.Fireworks => "fireworks",
                GetByokKeyResponseDataProvider.Friendli => "friendli",
                GetByokKeyResponseDataProvider.Gmicloud => "gmicloud",
                GetByokKeyResponseDataProvider.GoogleAiStudio => "google-ai-studio",
                GetByokKeyResponseDataProvider.GoogleVertex => "google-vertex",
                GetByokKeyResponseDataProvider.Groq => "groq",
                GetByokKeyResponseDataProvider.Hyperbolic => "hyperbolic",
                GetByokKeyResponseDataProvider.Inception => "inception",
                GetByokKeyResponseDataProvider.Inceptron => "inceptron",
                GetByokKeyResponseDataProvider.InferenceNet => "inference-net",
                GetByokKeyResponseDataProvider.Infermatic => "infermatic",
                GetByokKeyResponseDataProvider.Inflection => "inflection",
                GetByokKeyResponseDataProvider.IoNet => "io-net",
                GetByokKeyResponseDataProvider.Ionstream => "ionstream",
                GetByokKeyResponseDataProvider.Liquid => "liquid",
                GetByokKeyResponseDataProvider.Mancer => "mancer",
                GetByokKeyResponseDataProvider.Mara => "mara",
                GetByokKeyResponseDataProvider.Minimax => "minimax",
                GetByokKeyResponseDataProvider.Mistral => "mistral",
                GetByokKeyResponseDataProvider.Modelrun => "modelrun",
                GetByokKeyResponseDataProvider.Modular => "modular",
                GetByokKeyResponseDataProvider.Moonshotai => "moonshotai",
                GetByokKeyResponseDataProvider.Morph => "morph",
                GetByokKeyResponseDataProvider.Ncompass => "ncompass",
                GetByokKeyResponseDataProvider.Nebius => "nebius",
                GetByokKeyResponseDataProvider.NexAgi => "nex-agi",
                GetByokKeyResponseDataProvider.Nextbit => "nextbit",
                GetByokKeyResponseDataProvider.Novita => "novita",
                GetByokKeyResponseDataProvider.Nvidia => "nvidia",
                GetByokKeyResponseDataProvider.OpenInference => "open-inference",
                GetByokKeyResponseDataProvider.Openai => "openai",
                GetByokKeyResponseDataProvider.Parasail => "parasail",
                GetByokKeyResponseDataProvider.Perceptron => "perceptron",
                GetByokKeyResponseDataProvider.Perplexity => "perplexity",
                GetByokKeyResponseDataProvider.Phala => "phala",
                GetByokKeyResponseDataProvider.Poolside => "poolside",
                GetByokKeyResponseDataProvider.Recraft => "recraft",
                GetByokKeyResponseDataProvider.Reka => "reka",
                GetByokKeyResponseDataProvider.Relace => "relace",
                GetByokKeyResponseDataProvider.Sambanova => "sambanova",
                GetByokKeyResponseDataProvider.Seed => "seed",
                GetByokKeyResponseDataProvider.Siliconflow => "siliconflow",
                GetByokKeyResponseDataProvider.Sourceful => "sourceful",
                GetByokKeyResponseDataProvider.Stepfun => "stepfun",
                GetByokKeyResponseDataProvider.Streamlake => "streamlake",
                GetByokKeyResponseDataProvider.Switchpoint => "switchpoint",
                GetByokKeyResponseDataProvider.Together => "together",
                GetByokKeyResponseDataProvider.Upstage => "upstage",
                GetByokKeyResponseDataProvider.Venice => "venice",
                GetByokKeyResponseDataProvider.Wandb => "wandb",
                GetByokKeyResponseDataProvider.Xai => "xai",
                GetByokKeyResponseDataProvider.Xiaomi => "xiaomi",
                GetByokKeyResponseDataProvider.ZAi => "z-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetByokKeyResponseDataProvider? ToEnum(string value)
        {
            return value switch
            {
                "ai21" => GetByokKeyResponseDataProvider.Ai21,
                "aion-labs" => GetByokKeyResponseDataProvider.AionLabs,
                "akashml" => GetByokKeyResponseDataProvider.Akashml,
                "alibaba" => GetByokKeyResponseDataProvider.Alibaba,
                "amazon-bedrock" => GetByokKeyResponseDataProvider.AmazonBedrock,
                "amazon-nova" => GetByokKeyResponseDataProvider.AmazonNova,
                "ambient" => GetByokKeyResponseDataProvider.Ambient,
                "anthropic" => GetByokKeyResponseDataProvider.Anthropic,
                "arcee-ai" => GetByokKeyResponseDataProvider.ArceeAi,
                "atlas-cloud" => GetByokKeyResponseDataProvider.AtlasCloud,
                "avian" => GetByokKeyResponseDataProvider.Avian,
                "azure" => GetByokKeyResponseDataProvider.Azure,
                "baidu" => GetByokKeyResponseDataProvider.Baidu,
                "baseten" => GetByokKeyResponseDataProvider.Baseten,
                "black-forest-labs" => GetByokKeyResponseDataProvider.BlackForestLabs,
                "byteplus" => GetByokKeyResponseDataProvider.Byteplus,
                "cerebras" => GetByokKeyResponseDataProvider.Cerebras,
                "chutes" => GetByokKeyResponseDataProvider.Chutes,
                "cirrascale" => GetByokKeyResponseDataProvider.Cirrascale,
                "clarifai" => GetByokKeyResponseDataProvider.Clarifai,
                "cloudflare" => GetByokKeyResponseDataProvider.Cloudflare,
                "cohere" => GetByokKeyResponseDataProvider.Cohere,
                "crusoe" => GetByokKeyResponseDataProvider.Crusoe,
                "deepinfra" => GetByokKeyResponseDataProvider.Deepinfra,
                "deepseek" => GetByokKeyResponseDataProvider.Deepseek,
                "dekallm" => GetByokKeyResponseDataProvider.Dekallm,
                "featherless" => GetByokKeyResponseDataProvider.Featherless,
                "fireworks" => GetByokKeyResponseDataProvider.Fireworks,
                "friendli" => GetByokKeyResponseDataProvider.Friendli,
                "gmicloud" => GetByokKeyResponseDataProvider.Gmicloud,
                "google-ai-studio" => GetByokKeyResponseDataProvider.GoogleAiStudio,
                "google-vertex" => GetByokKeyResponseDataProvider.GoogleVertex,
                "groq" => GetByokKeyResponseDataProvider.Groq,
                "hyperbolic" => GetByokKeyResponseDataProvider.Hyperbolic,
                "inception" => GetByokKeyResponseDataProvider.Inception,
                "inceptron" => GetByokKeyResponseDataProvider.Inceptron,
                "inference-net" => GetByokKeyResponseDataProvider.InferenceNet,
                "infermatic" => GetByokKeyResponseDataProvider.Infermatic,
                "inflection" => GetByokKeyResponseDataProvider.Inflection,
                "io-net" => GetByokKeyResponseDataProvider.IoNet,
                "ionstream" => GetByokKeyResponseDataProvider.Ionstream,
                "liquid" => GetByokKeyResponseDataProvider.Liquid,
                "mancer" => GetByokKeyResponseDataProvider.Mancer,
                "mara" => GetByokKeyResponseDataProvider.Mara,
                "minimax" => GetByokKeyResponseDataProvider.Minimax,
                "mistral" => GetByokKeyResponseDataProvider.Mistral,
                "modelrun" => GetByokKeyResponseDataProvider.Modelrun,
                "modular" => GetByokKeyResponseDataProvider.Modular,
                "moonshotai" => GetByokKeyResponseDataProvider.Moonshotai,
                "morph" => GetByokKeyResponseDataProvider.Morph,
                "ncompass" => GetByokKeyResponseDataProvider.Ncompass,
                "nebius" => GetByokKeyResponseDataProvider.Nebius,
                "nex-agi" => GetByokKeyResponseDataProvider.NexAgi,
                "nextbit" => GetByokKeyResponseDataProvider.Nextbit,
                "novita" => GetByokKeyResponseDataProvider.Novita,
                "nvidia" => GetByokKeyResponseDataProvider.Nvidia,
                "open-inference" => GetByokKeyResponseDataProvider.OpenInference,
                "openai" => GetByokKeyResponseDataProvider.Openai,
                "parasail" => GetByokKeyResponseDataProvider.Parasail,
                "perceptron" => GetByokKeyResponseDataProvider.Perceptron,
                "perplexity" => GetByokKeyResponseDataProvider.Perplexity,
                "phala" => GetByokKeyResponseDataProvider.Phala,
                "poolside" => GetByokKeyResponseDataProvider.Poolside,
                "recraft" => GetByokKeyResponseDataProvider.Recraft,
                "reka" => GetByokKeyResponseDataProvider.Reka,
                "relace" => GetByokKeyResponseDataProvider.Relace,
                "sambanova" => GetByokKeyResponseDataProvider.Sambanova,
                "seed" => GetByokKeyResponseDataProvider.Seed,
                "siliconflow" => GetByokKeyResponseDataProvider.Siliconflow,
                "sourceful" => GetByokKeyResponseDataProvider.Sourceful,
                "stepfun" => GetByokKeyResponseDataProvider.Stepfun,
                "streamlake" => GetByokKeyResponseDataProvider.Streamlake,
                "switchpoint" => GetByokKeyResponseDataProvider.Switchpoint,
                "together" => GetByokKeyResponseDataProvider.Together,
                "upstage" => GetByokKeyResponseDataProvider.Upstage,
                "venice" => GetByokKeyResponseDataProvider.Venice,
                "wandb" => GetByokKeyResponseDataProvider.Wandb,
                "xai" => GetByokKeyResponseDataProvider.Xai,
                "xiaomi" => GetByokKeyResponseDataProvider.Xiaomi,
                "z-ai" => GetByokKeyResponseDataProvider.ZAi,
                _ => null,
            };
        }
    }
}