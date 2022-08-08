# AppCenterApiClientLib.Model.InternalUserRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AppInvitation** | **string** | The token of the app invitation which lead to signup | [optional] 
**TesterInvitation** | **string** | The token of the test invitation which lead to signup | [optional] 
**OrganizationInvitation** | **string** | The token of the organization invitation which lead to signup | [optional] 
**AvatarUrl** | **string** | The avatar URL of the user | [optional] 
**DisplayName** | **string** | The full name of the user. Might for example be first and last name | [optional] 
**Email** | **string** | The email address of the user | 
**Name** | **string** | The unique name that is used to identify the user. | 
**Password** | **string** | The password of the user. Needs to be at least 8 characters long and contain at least one lower- and one uppercase letter. | 
**PortalSubdomain** | **string** | The sub-domain of the portal from which this request was made. Will be used to build the invitation link. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

