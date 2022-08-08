# AppCenterApiClientLib.Model.ResignAttemptResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The status of the resigning operation. | 
**UserId** | **string** | ID of the user performing the resign operaiton. | 
**AppId** | **string** | App ID that the resign operation is being performed against. | 
**OriginalReleaseId** | [**decimal?**](BigDecimal.md) | ID of the release which is being resigned. | 
**ResignId** | **string** | ID of the resign operation. | 
**ContextId** | **string** | Context ID for the resigning operation. | 
**StartTime** | [**decimal?**](BigDecimal.md) | The time that the resign operation was started. | 
**Destinations** | **List&lt;Object&gt;** | List of destinations that the resign operation is being performed against. | [optional] 
**ErrorCode** | **string** | Error code associated with the exception. | [optional] 
**ErrorMessage** | **string** | Error message associated with the exception. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

