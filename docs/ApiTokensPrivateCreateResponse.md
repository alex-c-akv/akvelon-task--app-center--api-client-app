# AppCenterApiClientLib.Model.ApiTokensPrivateCreateResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique id (UUID) of the api token | 
**CreatedAt** | **string** | The creation time | 
**Scope** | **List&lt;string&gt;** | The scope for this token. | [optional] 
**EncryptedToken** | **string** | The encrypted value of a token. This value will only be returned for token of type in_app_update. | [optional] 
**Description** | **string** | The description of the token | [optional] 
**ApiToken** | **string** | The api token generated will not be accessible again | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

