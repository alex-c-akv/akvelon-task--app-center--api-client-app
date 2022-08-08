# AppCenterApiClientLib.Model.UserProfileResponsev2
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid?** | The unique id (UUID) of the user | 
**AvatarUrl** | **string** | The avatar URL of the user | [optional] 
**CanChangePassword** | **bool?** | User is required to send an old password in order to change the password. | [optional] 
**DisplayName** | **string** | The full name of the user. Might for example be first and last name | 
**Email** | **string** | The email address of the user | 
**Name** | **string** | The unique name that is used to identify the user. | 
**CreatedAt** | **string** | The created date of the user | [optional] 
**NextNpsSurveyDate** | **string** | The date in the future when the user should be checked again for NPS eligibility | [optional] 
**Origin** | **string** | The creation origin of this user | 
**FeatureFlags** | **List&lt;string&gt;** | The feature flags that are enabled for this user | [optional] 
**AdminRole** | **string** | The new admin_role | [optional] 
**Settings** | **Object** | The user&#x27;s settings | [optional] 
**SessionHash** | **string** | The session hash of the user | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

