# AppCenterApiClientLib.Model.LogFlowGenericLogContainerLogs
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Log type.  | 
**Timestamp** | **DateTime?** | Log creation timestamp.  | 
**InstallId** | **Guid?** | Install ID.  | 
**SessionId** | **Guid?** | Session ID.  | [optional] 
**EventId** | **string** | Event ID.  | [optional] 
**EventName** | **string** | Event name.  | [optional] 
**MessageId** | **string** | Message ID.  | [optional] 
**Properties** | **Dictionary&lt;string, string&gt;** | event specific properties.  | [optional] 
**Device** | [**LogContainerDevice**](LogContainerDevice.md) |  | 
**AuthProvider** | **string** | Auth service provider.  | [optional] 
**AccountId** | **string** | Account ID of the authenticated user.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

