# AppCenterApiClientLib.Model.ApiTokenResponsev2
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid?** | The unique id (UUID) of the api token | 
**CreatedAt** | **string** | The creation time | 
**Scope** | **List&lt;string&gt;** | The token&#x27;s scope. A list of allowed roles. | [optional] 
**EncryptedToken** | **string** | The encrypted value of a token. This value will only be returned for token of type in_app_update. | [optional] 
**Description** | **string** | The description of the token | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

