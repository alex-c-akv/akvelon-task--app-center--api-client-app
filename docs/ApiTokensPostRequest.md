# AppCenterApiClientLib.Model.ApiTokensPostRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | The description of the token | [optional] 
**EncryptedToken** | **string** | An encrypted value of the token. | [optional] 
**Scope** | **List&lt;string&gt;** | The scope for this token. An array of supported roles. | [optional] 
**TokenHash** | **string** | The hashed value of api token | [optional] 
**TokenType** | **string** | The token&#x27;s type. public:managed by the user; in_app_update:special token for in-app update scenario; buid:dedicated for CI usage for now; session:for CLI session management; tester_app: used for tester mobile app; default is \&quot;public\&quot;.&#x27; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

