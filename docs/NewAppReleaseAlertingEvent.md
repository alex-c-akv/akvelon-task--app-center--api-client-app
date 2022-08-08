# AppCenterApiClientLib.Model.NewAppReleaseAlertingEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserIds** | **List&lt;string&gt;** | List of users who need to receive an email notification. If this is not null, then only sending emails will be triggered even if the event requires calling webhooks or doing other actions. | [optional] 
**DisableWebhook** | **bool?** | indicate whether notify via webhook or not | [optional] 
**AppReleaseProperties** | [**NewAppReleaseAlertingEventAppReleaseProperties**](NewAppReleaseAlertingEventAppReleaseProperties.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

