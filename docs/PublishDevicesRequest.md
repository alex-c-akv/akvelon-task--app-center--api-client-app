# AppCenterApiClientLib.Model.PublishDevicesRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Username** | **string** | The username for the Apple Developer account to publish the devices to. | [optional] 
**Password** | **string** | The password for the Apple Developer account to publish the devices to. | [optional] 
**AccountServiceConnectionId** | **string** | The service_connection_id of the stored Apple credentials instead of username, password. | [optional] 
**PublishAllDevices** | **bool?** | When set to true, all unprovisioned devices will be published to the Apple Developer account.  When false, only the provided devices will be published to the Apple Developer account. | [optional] 
**Devices** | **List&lt;string&gt;** | Array of device UDID&#x27;s to be published to the Apple Developer account. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

