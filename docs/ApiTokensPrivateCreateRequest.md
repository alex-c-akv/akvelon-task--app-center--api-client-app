# AppCenterApiClientLib.Model.ApiTokensPrivateCreateRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PrincipalId** | **Guid?** | The principal ID assigned to the API token | 
**PrincipalType** | **string** | The principal type assigned to the API token | 
**Description** | **string** | The description of the token | [optional] 
**Scope** | **List&lt;string&gt;** | The scope for this token (default \&quot;all\&quot;). | [optional] 
**TokenType** | **string** | The token&#x27;s type (default \&quot;public\&quot;)   public: managed by the user   in_app_update: special token for in-app update scenario   buid: dedicated for CI usage for now   session: for CLI session management   tester_app: used for tester mobile app | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

