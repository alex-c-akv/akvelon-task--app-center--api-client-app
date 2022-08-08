# AppCenterApiClientLib.Model.AppInvitationDetailResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid?** | The unique ID (UUID) of the invitation | 
**App** | **AllOfAppInvitationDetailResponseApp** |  | 
**Email** | **string** | The email address of the invited user | 
**InviteType** | **string** | The invitation type | 
**InvitedBy** | [**AppInvitationDetailResponseInvitedBy**](AppInvitationDetailResponseInvitedBy.md) |  | 
**IsExistingUser** | **bool?** | Indicates whether the invited user already exists | 
**Permissions** | **List&lt;string&gt;** | The permissions the user has for the app | [optional] 
**AppCount** | [**decimal?**](BigDecimal.md) | The number of apps in the group | [optional] 
**DistributionGroup** | [**AppInvitationDetailResponseDistributionGroup**](AppInvitationDetailResponseDistributionGroup.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

