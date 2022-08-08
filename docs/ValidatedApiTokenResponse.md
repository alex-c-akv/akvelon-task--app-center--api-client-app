# AppCenterApiClientLib.Model.ValidatedApiTokenResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TokenId** | **Guid?** | The token&#x27;s unique id (UUID) | 
**TokenScope** | **List&lt;string&gt;** | The token&#x27;s scope. A list of allowed roles. | 
**PrincipalId** | **Guid?** | The ID of the owner of the API Token (user_id or app_id) | 
**PrincipalType** | **string** | Indicates the type of the principal (app or user) | 
**Claims** | [**List&lt;ValidatedApiTokenResponseClaims&gt;**](ValidatedApiTokenResponseClaims.md) | Collection of attributes that describe the principal of the specified API Token | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

