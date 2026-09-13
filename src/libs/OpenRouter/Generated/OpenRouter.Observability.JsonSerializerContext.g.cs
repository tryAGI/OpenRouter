
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadRequestResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnauthorizedResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnauthorizedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ForbiddenResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ForbiddenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.NotFoundResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.NotFoundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InternalServerResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InternalServerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ConflictResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ConflictResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingArizeConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityFilterRuleGroupLogic), TypeInfoPropertyName = "ObservabilityFilterRuleGroupLogic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityFilterRuleGroupRulesItemsField), TypeInfoPropertyName = "ObservabilityFilterRuleGroupRulesItemsField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityFilterRuleGroupRulesItemsOperator), TypeInfoPropertyName = "ObservabilityFilterRuleGroupRulesItemsOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityFilterRuleGroupRulesItemsValue), TypeInfoPropertyName = "ObservabilityFilterRuleGroupRulesItemsValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityFilterRuleGroupRulesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityFilterRuleGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityFilterRuleGroupRulesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityFilterRulesConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityFilterRuleGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingBraintrustConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingClickhouseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingDatadogConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingGrafanaConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingLangfuseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingLangsmithConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegion), TypeInfoPropertyName = "UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingOpikConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingOtelCollectorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingPosthogConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingRampConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingS3Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingSentryConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingSnowflakeConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingWeaveConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethod), TypeInfoPropertyName = "UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestination), TypeInfoPropertyName = "ObservabilityDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant1Type), TypeInfoPropertyName = "ObservabilityDestinationVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant2Type), TypeInfoPropertyName = "ObservabilityDestinationVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant3Type), TypeInfoPropertyName = "ObservabilityDestinationVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant4Type), TypeInfoPropertyName = "ObservabilityDestinationVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant5Type), TypeInfoPropertyName = "ObservabilityDestinationVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant6Type), TypeInfoPropertyName = "ObservabilityDestinationVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant7Type), TypeInfoPropertyName = "ObservabilityDestinationVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant8Type), TypeInfoPropertyName = "ObservabilityDestinationVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant9Type), TypeInfoPropertyName = "ObservabilityDestinationVariant9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant10Type), TypeInfoPropertyName = "ObservabilityDestinationVariant10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant11Type), TypeInfoPropertyName = "ObservabilityDestinationVariant11Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant12Type), TypeInfoPropertyName = "ObservabilityDestinationVariant12Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant13Type), TypeInfoPropertyName = "ObservabilityDestinationVariant13Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant14Type), TypeInfoPropertyName = "ObservabilityDestinationVariant14Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant15Type), TypeInfoPropertyName = "ObservabilityDestinationVariant15Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant16Type), TypeInfoPropertyName = "ObservabilityDestinationVariant16Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant17Type), TypeInfoPropertyName = "ObservabilityDestinationVariant17Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationDiscriminatorType), TypeInfoPropertyName = "ObservabilityDestinationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ListObservabilityDestinationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityDestination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityFilterRulesConfigNullable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationRequestType), TypeInfoPropertyName = "CreateObservabilityDestinationRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseData), TypeInfoPropertyName = "CreateObservabilityDestinationResponseData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1Type), TypeInfoPropertyName = "CreateObservabilityDestinationResponseDataVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2Type), TypeInfoPropertyName = "CreateObservabilityDestinationResponseDataVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3Type), TypeInfoPropertyName = "CreateObservabilityDestinationResponseDataVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4Type), TypeInfoPropertyName = "CreateObservabilityDestinationResponseDataVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5Type), TypeInfoPropertyName = "CreateObservabilityDestinationResponseDataVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6Type), TypeInfoPropertyName = "CreateObservabilityDestinationResponseDataVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7Type), TypeInfoPropertyName = "CreateObservabilityDestinationResponseDataVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8Type), TypeInfoPropertyName = "CreateObservabilityDestinationResponseDataVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9Type), TypeInfoPropertyName = "CreateObservabilityDestinationResponseDataVariant9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10Type), TypeInfoPropertyName = "CreateObservabilityDestinationResponseDataVariant10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11Type), TypeInfoPropertyName = "CreateObservabilityDestinationResponseDataVariant11Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12Type), TypeInfoPropertyName = "CreateObservabilityDestinationResponseDataVariant12Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13Type), TypeInfoPropertyName = "CreateObservabilityDestinationResponseDataVariant13Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14Type), TypeInfoPropertyName = "CreateObservabilityDestinationResponseDataVariant14Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15Type), TypeInfoPropertyName = "CreateObservabilityDestinationResponseDataVariant15Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16Type), TypeInfoPropertyName = "CreateObservabilityDestinationResponseDataVariant16Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17Type), TypeInfoPropertyName = "CreateObservabilityDestinationResponseDataVariant17Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType), TypeInfoPropertyName = "CreateObservabilityDestinationResponseDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseData), TypeInfoPropertyName = "GetObservabilityDestinationResponseData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant1Type), TypeInfoPropertyName = "GetObservabilityDestinationResponseDataVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant2Type), TypeInfoPropertyName = "GetObservabilityDestinationResponseDataVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant3Type), TypeInfoPropertyName = "GetObservabilityDestinationResponseDataVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant4Type), TypeInfoPropertyName = "GetObservabilityDestinationResponseDataVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant5Type), TypeInfoPropertyName = "GetObservabilityDestinationResponseDataVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant6Type), TypeInfoPropertyName = "GetObservabilityDestinationResponseDataVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant7Type), TypeInfoPropertyName = "GetObservabilityDestinationResponseDataVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant8Type), TypeInfoPropertyName = "GetObservabilityDestinationResponseDataVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant9Type), TypeInfoPropertyName = "GetObservabilityDestinationResponseDataVariant9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant10Type), TypeInfoPropertyName = "GetObservabilityDestinationResponseDataVariant10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant11Type), TypeInfoPropertyName = "GetObservabilityDestinationResponseDataVariant11Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant12Type), TypeInfoPropertyName = "GetObservabilityDestinationResponseDataVariant12Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant13Type), TypeInfoPropertyName = "GetObservabilityDestinationResponseDataVariant13Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant14Type), TypeInfoPropertyName = "GetObservabilityDestinationResponseDataVariant14Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant15Type), TypeInfoPropertyName = "GetObservabilityDestinationResponseDataVariant15Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant16Type), TypeInfoPropertyName = "GetObservabilityDestinationResponseDataVariant16Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant17Type), TypeInfoPropertyName = "GetObservabilityDestinationResponseDataVariant17Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType), TypeInfoPropertyName = "GetObservabilityDestinationResponseDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DeleteObservabilityDestinationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationRequestFilterRules))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseData), TypeInfoPropertyName = "UpdateObservabilityDestinationResponseData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant1Type), TypeInfoPropertyName = "UpdateObservabilityDestinationResponseDataVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant2Type), TypeInfoPropertyName = "UpdateObservabilityDestinationResponseDataVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant3Type), TypeInfoPropertyName = "UpdateObservabilityDestinationResponseDataVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant4Type), TypeInfoPropertyName = "UpdateObservabilityDestinationResponseDataVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant5Type), TypeInfoPropertyName = "UpdateObservabilityDestinationResponseDataVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant6Type), TypeInfoPropertyName = "UpdateObservabilityDestinationResponseDataVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant7Type), TypeInfoPropertyName = "UpdateObservabilityDestinationResponseDataVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant8Type), TypeInfoPropertyName = "UpdateObservabilityDestinationResponseDataVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant9Type), TypeInfoPropertyName = "UpdateObservabilityDestinationResponseDataVariant9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10Type), TypeInfoPropertyName = "UpdateObservabilityDestinationResponseDataVariant10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant11Type), TypeInfoPropertyName = "UpdateObservabilityDestinationResponseDataVariant11Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant12Type), TypeInfoPropertyName = "UpdateObservabilityDestinationResponseDataVariant12Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant13Type), TypeInfoPropertyName = "UpdateObservabilityDestinationResponseDataVariant13Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant14Type), TypeInfoPropertyName = "UpdateObservabilityDestinationResponseDataVariant14Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant15Type), TypeInfoPropertyName = "UpdateObservabilityDestinationResponseDataVariant15Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant16Type), TypeInfoPropertyName = "UpdateObservabilityDestinationResponseDataVariant16Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant17Type), TypeInfoPropertyName = "UpdateObservabilityDestinationResponseDataVariant17Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType), TypeInfoPropertyName = "UpdateObservabilityDestinationResponseDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityFilterRuleGroupLogic?), TypeInfoPropertyName = "NullableObservabilityFilterRuleGroupLogic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityFilterRuleGroupRulesItemsField?), TypeInfoPropertyName = "NullableObservabilityFilterRuleGroupRulesItemsField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityFilterRuleGroupRulesItemsOperator?), TypeInfoPropertyName = "NullableObservabilityFilterRuleGroupRulesItemsOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityFilterRuleGroupRulesItemsValue?), TypeInfoPropertyName = "NullableObservabilityFilterRuleGroupRulesItemsValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegion?), TypeInfoPropertyName = "NullableUpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethod?), TypeInfoPropertyName = "NullableUpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestination?), TypeInfoPropertyName = "NullableObservabilityDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant1Type?), TypeInfoPropertyName = "NullableObservabilityDestinationVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant2Type?), TypeInfoPropertyName = "NullableObservabilityDestinationVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant3Type?), TypeInfoPropertyName = "NullableObservabilityDestinationVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant4Type?), TypeInfoPropertyName = "NullableObservabilityDestinationVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant5Type?), TypeInfoPropertyName = "NullableObservabilityDestinationVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant6Type?), TypeInfoPropertyName = "NullableObservabilityDestinationVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant7Type?), TypeInfoPropertyName = "NullableObservabilityDestinationVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant8Type?), TypeInfoPropertyName = "NullableObservabilityDestinationVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant9Type?), TypeInfoPropertyName = "NullableObservabilityDestinationVariant9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant10Type?), TypeInfoPropertyName = "NullableObservabilityDestinationVariant10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant11Type?), TypeInfoPropertyName = "NullableObservabilityDestinationVariant11Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant12Type?), TypeInfoPropertyName = "NullableObservabilityDestinationVariant12Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant13Type?), TypeInfoPropertyName = "NullableObservabilityDestinationVariant13Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant14Type?), TypeInfoPropertyName = "NullableObservabilityDestinationVariant14Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant15Type?), TypeInfoPropertyName = "NullableObservabilityDestinationVariant15Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant16Type?), TypeInfoPropertyName = "NullableObservabilityDestinationVariant16Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationVariant17Type?), TypeInfoPropertyName = "NullableObservabilityDestinationVariant17Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ObservabilityDestinationDiscriminatorType?), TypeInfoPropertyName = "NullableObservabilityDestinationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationRequestType?), TypeInfoPropertyName = "NullableCreateObservabilityDestinationRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseData?), TypeInfoPropertyName = "NullableCreateObservabilityDestinationResponseData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1Type?), TypeInfoPropertyName = "NullableCreateObservabilityDestinationResponseDataVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2Type?), TypeInfoPropertyName = "NullableCreateObservabilityDestinationResponseDataVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3Type?), TypeInfoPropertyName = "NullableCreateObservabilityDestinationResponseDataVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4Type?), TypeInfoPropertyName = "NullableCreateObservabilityDestinationResponseDataVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5Type?), TypeInfoPropertyName = "NullableCreateObservabilityDestinationResponseDataVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6Type?), TypeInfoPropertyName = "NullableCreateObservabilityDestinationResponseDataVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7Type?), TypeInfoPropertyName = "NullableCreateObservabilityDestinationResponseDataVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8Type?), TypeInfoPropertyName = "NullableCreateObservabilityDestinationResponseDataVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9Type?), TypeInfoPropertyName = "NullableCreateObservabilityDestinationResponseDataVariant9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10Type?), TypeInfoPropertyName = "NullableCreateObservabilityDestinationResponseDataVariant10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11Type?), TypeInfoPropertyName = "NullableCreateObservabilityDestinationResponseDataVariant11Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12Type?), TypeInfoPropertyName = "NullableCreateObservabilityDestinationResponseDataVariant12Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13Type?), TypeInfoPropertyName = "NullableCreateObservabilityDestinationResponseDataVariant13Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14Type?), TypeInfoPropertyName = "NullableCreateObservabilityDestinationResponseDataVariant14Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15Type?), TypeInfoPropertyName = "NullableCreateObservabilityDestinationResponseDataVariant15Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16Type?), TypeInfoPropertyName = "NullableCreateObservabilityDestinationResponseDataVariant16Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17Type?), TypeInfoPropertyName = "NullableCreateObservabilityDestinationResponseDataVariant17Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType?), TypeInfoPropertyName = "NullableCreateObservabilityDestinationResponseDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseData?), TypeInfoPropertyName = "NullableGetObservabilityDestinationResponseData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant1Type?), TypeInfoPropertyName = "NullableGetObservabilityDestinationResponseDataVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant2Type?), TypeInfoPropertyName = "NullableGetObservabilityDestinationResponseDataVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant3Type?), TypeInfoPropertyName = "NullableGetObservabilityDestinationResponseDataVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant4Type?), TypeInfoPropertyName = "NullableGetObservabilityDestinationResponseDataVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant5Type?), TypeInfoPropertyName = "NullableGetObservabilityDestinationResponseDataVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant6Type?), TypeInfoPropertyName = "NullableGetObservabilityDestinationResponseDataVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant7Type?), TypeInfoPropertyName = "NullableGetObservabilityDestinationResponseDataVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant8Type?), TypeInfoPropertyName = "NullableGetObservabilityDestinationResponseDataVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant9Type?), TypeInfoPropertyName = "NullableGetObservabilityDestinationResponseDataVariant9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant10Type?), TypeInfoPropertyName = "NullableGetObservabilityDestinationResponseDataVariant10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant11Type?), TypeInfoPropertyName = "NullableGetObservabilityDestinationResponseDataVariant11Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant12Type?), TypeInfoPropertyName = "NullableGetObservabilityDestinationResponseDataVariant12Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant13Type?), TypeInfoPropertyName = "NullableGetObservabilityDestinationResponseDataVariant13Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant14Type?), TypeInfoPropertyName = "NullableGetObservabilityDestinationResponseDataVariant14Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant15Type?), TypeInfoPropertyName = "NullableGetObservabilityDestinationResponseDataVariant15Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant16Type?), TypeInfoPropertyName = "NullableGetObservabilityDestinationResponseDataVariant16Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant17Type?), TypeInfoPropertyName = "NullableGetObservabilityDestinationResponseDataVariant17Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType?), TypeInfoPropertyName = "NullableGetObservabilityDestinationResponseDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseData?), TypeInfoPropertyName = "NullableUpdateObservabilityDestinationResponseData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant1Type?), TypeInfoPropertyName = "NullableUpdateObservabilityDestinationResponseDataVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant2Type?), TypeInfoPropertyName = "NullableUpdateObservabilityDestinationResponseDataVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant3Type?), TypeInfoPropertyName = "NullableUpdateObservabilityDestinationResponseDataVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant4Type?), TypeInfoPropertyName = "NullableUpdateObservabilityDestinationResponseDataVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant5Type?), TypeInfoPropertyName = "NullableUpdateObservabilityDestinationResponseDataVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant6Type?), TypeInfoPropertyName = "NullableUpdateObservabilityDestinationResponseDataVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant7Type?), TypeInfoPropertyName = "NullableUpdateObservabilityDestinationResponseDataVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant8Type?), TypeInfoPropertyName = "NullableUpdateObservabilityDestinationResponseDataVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant9Type?), TypeInfoPropertyName = "NullableUpdateObservabilityDestinationResponseDataVariant9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10Type?), TypeInfoPropertyName = "NullableUpdateObservabilityDestinationResponseDataVariant10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant11Type?), TypeInfoPropertyName = "NullableUpdateObservabilityDestinationResponseDataVariant11Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant12Type?), TypeInfoPropertyName = "NullableUpdateObservabilityDestinationResponseDataVariant12Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant13Type?), TypeInfoPropertyName = "NullableUpdateObservabilityDestinationResponseDataVariant13Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant14Type?), TypeInfoPropertyName = "NullableUpdateObservabilityDestinationResponseDataVariant14Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant15Type?), TypeInfoPropertyName = "NullableUpdateObservabilityDestinationResponseDataVariant15Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant16Type?), TypeInfoPropertyName = "NullableUpdateObservabilityDestinationResponseDataVariant16Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant17Type?), TypeInfoPropertyName = "NullableUpdateObservabilityDestinationResponseDataVariant17Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType?), TypeInfoPropertyName = "NullableUpdateObservabilityDestinationResponseDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ObservabilityFilterRuleGroupRulesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ObservabilityFilterRuleGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ObservabilityDestination>))]
    internal sealed partial class ObservabilitySourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ObservabilitySourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ObservabilitySourceGenerationContext Default { get; } = new(DefaultOptions);

        private ObservabilitySourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::OpenRouter.JsonConverters.ObservabilityFilterRuleGroupRulesItemsValueJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ObservabilityDestinationJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::OpenRouter.ObservabilityFilterRuleGroupLogic)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityFilterRuleGroupLogic?)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityFilterRuleGroupRulesItemsField)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityFilterRuleGroupRulesItemsField?)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityFilterRuleGroupRulesItemsOperator)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityFilterRuleGroupRulesItemsOperator?)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegion)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegion?)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethod)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethod?)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant1Type)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant1Type?)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant2Type)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant2Type?)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant3Type)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant3Type?)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant4Type)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant4Type?)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant5Type)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant5Type?)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant6Type)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant6Type?)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant7Type)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant7Type?)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant8Type)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant8Type?)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant9Type)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant9Type?)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant10Type)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant10Type?)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant11Type)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant11Type?)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant12Type)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant12Type?)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant13Type)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant13Type?)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant14Type)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant14Type?)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant15Type)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant15Type?)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant16Type)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant16Type?)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant17Type)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant17Type?)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationRequestType)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationRequestType?)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1Type)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1Type?)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2Type)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2Type?)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3Type)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3Type?)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4Type)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4Type?)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5Type)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5Type?)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6Type)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6Type?)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7Type)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7Type?)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8Type)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8Type?)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9Type)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9Type?)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10Type)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10Type?)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11Type)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11Type?)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12Type)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12Type?)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13Type)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13Type?)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14Type)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14Type?)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15Type)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15Type?)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16Type)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16Type?)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17Type)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17Type?)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant1Type)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant1Type?)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant2Type)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant2Type?)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant3Type)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant3Type?)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant4Type)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant4Type?)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant5Type)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant5Type?)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant6Type)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant6Type?)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant7Type)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant7Type?)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant8Type)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant8Type?)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant9Type)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant9Type?)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant10Type)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant10Type?)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant11Type)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant11Type?)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant12Type)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant12Type?)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant13Type)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant13Type?)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant14Type)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant14Type?)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant15Type)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant15Type?)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant16Type)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant16Type?)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant17Type)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant17Type?)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant1Type)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant1Type?)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant2Type)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant2Type?)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant3Type)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant3Type?)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant4Type)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant4Type?)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant5Type)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant5Type?)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant6Type)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant6Type?)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant7Type)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant7Type?)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant8Type)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant8Type?)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant9Type)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant9Type?)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10Type)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10Type?)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant11Type)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant11Type?)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant12Type)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant12Type?)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant13Type)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant13Type?)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant14Type)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant14Type?)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant15Type)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant15Type?)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant16Type)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant16Type?)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant17Type)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant17Type?)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::OpenRouter.ObservabilityFilterRuleGroupLogic))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityFilterRuleGroupLogicJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityFilterRuleGroupLogic?))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityFilterRuleGroupLogicNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityFilterRuleGroupRulesItemsField))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityFilterRuleGroupRulesItemsFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityFilterRuleGroupRulesItemsField?))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityFilterRuleGroupRulesItemsFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityFilterRuleGroupRulesItemsOperator))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityFilterRuleGroupRulesItemsOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityFilterRuleGroupRulesItemsOperator?))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityFilterRuleGroupRulesItemsOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegion))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegion?))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethod))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethod?))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant1Type))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant1Type?))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant2Type))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant2Type?))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant3Type))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant3Type?))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant4Type))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant4Type?))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant5Type))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant5TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant5Type?))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant5TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant6Type))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant6TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant6Type?))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant6TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant7Type))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant7TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant7Type?))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant7TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant8Type))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant8TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant8Type?))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant8TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant9Type))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant9TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant9Type?))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant9TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant10Type))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant10TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant10Type?))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant10TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant11Type))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant11TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant11Type?))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant11TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant12Type))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant12TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant12Type?))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant12TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant13Type))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant13TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant13Type?))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant13TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant14Type))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant14TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant14Type?))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant14TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant15Type))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant15TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant15Type?))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant15TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant16Type))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant16TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant16Type?))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant16TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant17Type))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant17TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationVariant17Type?))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationVariant17TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ObservabilityDestinationDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.ObservabilityDestinationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationRequestType))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationRequestType?))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1Type))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1Type?))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2Type))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2Type?))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3Type))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3Type?))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4Type))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4Type?))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5Type))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant5TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5Type?))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant5TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6Type))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant6TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6Type?))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant6TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7Type))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant7TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7Type?))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant7TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8Type))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant8TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8Type?))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant8TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9Type))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant9TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9Type?))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant9TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10Type))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant10TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10Type?))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant10TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11Type))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant11TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11Type?))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant11TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12Type))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant12TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12Type?))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant12TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13Type))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant13TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13Type?))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant13TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14Type))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant14TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14Type?))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant14TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15Type))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant15TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15Type?))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant15TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16Type))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant16TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16Type?))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant16TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17Type))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant17TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17Type?))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataVariant17TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.CreateObservabilityDestinationResponseDataDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant1Type))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant1Type?))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant2Type))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant2Type?))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant3Type))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant3Type?))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant4Type))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant4Type?))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant5Type))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant5TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant5Type?))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant5TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant6Type))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant6TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant6Type?))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant6TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant7Type))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant7TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant7Type?))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant7TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant8Type))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant8TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant8Type?))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant8TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant9Type))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant9TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant9Type?))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant9TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant10Type))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant10TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant10Type?))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant10TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant11Type))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant11TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant11Type?))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant11TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant12Type))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant12TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant12Type?))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant12TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant13Type))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant13TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant13Type?))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant13TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant14Type))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant14TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant14Type?))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant14TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant15Type))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant15TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant15Type?))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant15TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant16Type))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant16TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant16Type?))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant16TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant17Type))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant17TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant17Type?))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataVariant17TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant1Type))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant1Type?))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant2Type))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant2Type?))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant3Type))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant3Type?))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant4Type))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant4Type?))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant5Type))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant5TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant5Type?))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant5TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant6Type))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant6TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant6Type?))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant6TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant7Type))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant7TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant7Type?))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant7TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant8Type))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant8TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant8Type?))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant8TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant9Type))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant9TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant9Type?))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant9TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10Type))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant10TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10Type?))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant10TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant11Type))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant11TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant11Type?))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant11TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant12Type))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant12TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant12Type?))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant12TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant13Type))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant13TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant13Type?))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant13TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant14Type))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant14TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant14Type?))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant14TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant15Type))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant15TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant15Type?))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant15TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant16Type))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant16TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant16Type?))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant16TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant17Type))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant17TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant17Type?))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant17TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataDiscriminatorTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ObservabilitySourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}