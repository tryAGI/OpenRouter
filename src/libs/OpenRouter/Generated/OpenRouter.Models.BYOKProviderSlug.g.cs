
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The upstream provider this credential authenticates against, as a lowercase slug (e.g. `openai`, `anthropic`, `amazon-bedrock`).
    /// </summary>
    public enum BYOKProviderSlug
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
    public static class BYOKProviderSlugExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BYOKProviderSlug value)
        {
            return value switch
            {
                BYOKProviderSlug.Ai21 => "ai21",
                BYOKProviderSlug.AionLabs => "aion-labs",
                BYOKProviderSlug.Akashml => "akashml",
                BYOKProviderSlug.Alibaba => "alibaba",
                BYOKProviderSlug.AmazonBedrock => "amazon-bedrock",
                BYOKProviderSlug.AmazonNova => "amazon-nova",
                BYOKProviderSlug.Ambient => "ambient",
                BYOKProviderSlug.Anthropic => "anthropic",
                BYOKProviderSlug.ArceeAi => "arcee-ai",
                BYOKProviderSlug.AtlasCloud => "atlas-cloud",
                BYOKProviderSlug.Avian => "avian",
                BYOKProviderSlug.Azure => "azure",
                BYOKProviderSlug.Baidu => "baidu",
                BYOKProviderSlug.Baseten => "baseten",
                BYOKProviderSlug.BlackForestLabs => "black-forest-labs",
                BYOKProviderSlug.Byteplus => "byteplus",
                BYOKProviderSlug.Cerebras => "cerebras",
                BYOKProviderSlug.Chutes => "chutes",
                BYOKProviderSlug.Cirrascale => "cirrascale",
                BYOKProviderSlug.Clarifai => "clarifai",
                BYOKProviderSlug.Cloudflare => "cloudflare",
                BYOKProviderSlug.Cohere => "cohere",
                BYOKProviderSlug.Crusoe => "crusoe",
                BYOKProviderSlug.Deepinfra => "deepinfra",
                BYOKProviderSlug.Deepseek => "deepseek",
                BYOKProviderSlug.Dekallm => "dekallm",
                BYOKProviderSlug.Featherless => "featherless",
                BYOKProviderSlug.Fireworks => "fireworks",
                BYOKProviderSlug.Friendli => "friendli",
                BYOKProviderSlug.Gmicloud => "gmicloud",
                BYOKProviderSlug.GoogleAiStudio => "google-ai-studio",
                BYOKProviderSlug.GoogleVertex => "google-vertex",
                BYOKProviderSlug.Groq => "groq",
                BYOKProviderSlug.Hyperbolic => "hyperbolic",
                BYOKProviderSlug.Inception => "inception",
                BYOKProviderSlug.Inceptron => "inceptron",
                BYOKProviderSlug.InferenceNet => "inference-net",
                BYOKProviderSlug.Infermatic => "infermatic",
                BYOKProviderSlug.Inflection => "inflection",
                BYOKProviderSlug.IoNet => "io-net",
                BYOKProviderSlug.Ionstream => "ionstream",
                BYOKProviderSlug.Liquid => "liquid",
                BYOKProviderSlug.Mancer => "mancer",
                BYOKProviderSlug.Mara => "mara",
                BYOKProviderSlug.Minimax => "minimax",
                BYOKProviderSlug.Mistral => "mistral",
                BYOKProviderSlug.Modelrun => "modelrun",
                BYOKProviderSlug.Modular => "modular",
                BYOKProviderSlug.Moonshotai => "moonshotai",
                BYOKProviderSlug.Morph => "morph",
                BYOKProviderSlug.Ncompass => "ncompass",
                BYOKProviderSlug.Nebius => "nebius",
                BYOKProviderSlug.NexAgi => "nex-agi",
                BYOKProviderSlug.Nextbit => "nextbit",
                BYOKProviderSlug.Novita => "novita",
                BYOKProviderSlug.Nvidia => "nvidia",
                BYOKProviderSlug.OpenInference => "open-inference",
                BYOKProviderSlug.Openai => "openai",
                BYOKProviderSlug.Parasail => "parasail",
                BYOKProviderSlug.Perceptron => "perceptron",
                BYOKProviderSlug.Perplexity => "perplexity",
                BYOKProviderSlug.Phala => "phala",
                BYOKProviderSlug.Poolside => "poolside",
                BYOKProviderSlug.Recraft => "recraft",
                BYOKProviderSlug.Reka => "reka",
                BYOKProviderSlug.Relace => "relace",
                BYOKProviderSlug.Sambanova => "sambanova",
                BYOKProviderSlug.Seed => "seed",
                BYOKProviderSlug.Siliconflow => "siliconflow",
                BYOKProviderSlug.Sourceful => "sourceful",
                BYOKProviderSlug.Stepfun => "stepfun",
                BYOKProviderSlug.Streamlake => "streamlake",
                BYOKProviderSlug.Switchpoint => "switchpoint",
                BYOKProviderSlug.Together => "together",
                BYOKProviderSlug.Upstage => "upstage",
                BYOKProviderSlug.Venice => "venice",
                BYOKProviderSlug.Wandb => "wandb",
                BYOKProviderSlug.Xai => "xai",
                BYOKProviderSlug.Xiaomi => "xiaomi",
                BYOKProviderSlug.ZAi => "z-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BYOKProviderSlug? ToEnum(string value)
        {
            return value switch
            {
                "ai21" => BYOKProviderSlug.Ai21,
                "aion-labs" => BYOKProviderSlug.AionLabs,
                "akashml" => BYOKProviderSlug.Akashml,
                "alibaba" => BYOKProviderSlug.Alibaba,
                "amazon-bedrock" => BYOKProviderSlug.AmazonBedrock,
                "amazon-nova" => BYOKProviderSlug.AmazonNova,
                "ambient" => BYOKProviderSlug.Ambient,
                "anthropic" => BYOKProviderSlug.Anthropic,
                "arcee-ai" => BYOKProviderSlug.ArceeAi,
                "atlas-cloud" => BYOKProviderSlug.AtlasCloud,
                "avian" => BYOKProviderSlug.Avian,
                "azure" => BYOKProviderSlug.Azure,
                "baidu" => BYOKProviderSlug.Baidu,
                "baseten" => BYOKProviderSlug.Baseten,
                "black-forest-labs" => BYOKProviderSlug.BlackForestLabs,
                "byteplus" => BYOKProviderSlug.Byteplus,
                "cerebras" => BYOKProviderSlug.Cerebras,
                "chutes" => BYOKProviderSlug.Chutes,
                "cirrascale" => BYOKProviderSlug.Cirrascale,
                "clarifai" => BYOKProviderSlug.Clarifai,
                "cloudflare" => BYOKProviderSlug.Cloudflare,
                "cohere" => BYOKProviderSlug.Cohere,
                "crusoe" => BYOKProviderSlug.Crusoe,
                "deepinfra" => BYOKProviderSlug.Deepinfra,
                "deepseek" => BYOKProviderSlug.Deepseek,
                "dekallm" => BYOKProviderSlug.Dekallm,
                "featherless" => BYOKProviderSlug.Featherless,
                "fireworks" => BYOKProviderSlug.Fireworks,
                "friendli" => BYOKProviderSlug.Friendli,
                "gmicloud" => BYOKProviderSlug.Gmicloud,
                "google-ai-studio" => BYOKProviderSlug.GoogleAiStudio,
                "google-vertex" => BYOKProviderSlug.GoogleVertex,
                "groq" => BYOKProviderSlug.Groq,
                "hyperbolic" => BYOKProviderSlug.Hyperbolic,
                "inception" => BYOKProviderSlug.Inception,
                "inceptron" => BYOKProviderSlug.Inceptron,
                "inference-net" => BYOKProviderSlug.InferenceNet,
                "infermatic" => BYOKProviderSlug.Infermatic,
                "inflection" => BYOKProviderSlug.Inflection,
                "io-net" => BYOKProviderSlug.IoNet,
                "ionstream" => BYOKProviderSlug.Ionstream,
                "liquid" => BYOKProviderSlug.Liquid,
                "mancer" => BYOKProviderSlug.Mancer,
                "mara" => BYOKProviderSlug.Mara,
                "minimax" => BYOKProviderSlug.Minimax,
                "mistral" => BYOKProviderSlug.Mistral,
                "modelrun" => BYOKProviderSlug.Modelrun,
                "modular" => BYOKProviderSlug.Modular,
                "moonshotai" => BYOKProviderSlug.Moonshotai,
                "morph" => BYOKProviderSlug.Morph,
                "ncompass" => BYOKProviderSlug.Ncompass,
                "nebius" => BYOKProviderSlug.Nebius,
                "nex-agi" => BYOKProviderSlug.NexAgi,
                "nextbit" => BYOKProviderSlug.Nextbit,
                "novita" => BYOKProviderSlug.Novita,
                "nvidia" => BYOKProviderSlug.Nvidia,
                "open-inference" => BYOKProviderSlug.OpenInference,
                "openai" => BYOKProviderSlug.Openai,
                "parasail" => BYOKProviderSlug.Parasail,
                "perceptron" => BYOKProviderSlug.Perceptron,
                "perplexity" => BYOKProviderSlug.Perplexity,
                "phala" => BYOKProviderSlug.Phala,
                "poolside" => BYOKProviderSlug.Poolside,
                "recraft" => BYOKProviderSlug.Recraft,
                "reka" => BYOKProviderSlug.Reka,
                "relace" => BYOKProviderSlug.Relace,
                "sambanova" => BYOKProviderSlug.Sambanova,
                "seed" => BYOKProviderSlug.Seed,
                "siliconflow" => BYOKProviderSlug.Siliconflow,
                "sourceful" => BYOKProviderSlug.Sourceful,
                "stepfun" => BYOKProviderSlug.Stepfun,
                "streamlake" => BYOKProviderSlug.Streamlake,
                "switchpoint" => BYOKProviderSlug.Switchpoint,
                "together" => BYOKProviderSlug.Together,
                "upstage" => BYOKProviderSlug.Upstage,
                "venice" => BYOKProviderSlug.Venice,
                "wandb" => BYOKProviderSlug.Wandb,
                "xai" => BYOKProviderSlug.Xai,
                "xiaomi" => BYOKProviderSlug.Xiaomi,
                "z-ai" => BYOKProviderSlug.ZAi,
                _ => null,
            };
        }
    }
}