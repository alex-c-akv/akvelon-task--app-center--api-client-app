# AppCenterApiClientLib.Model.UpdateDevicesRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReleaseId** | [**decimal?**](BigDecimal.md) | When provided, will update the provided release with the new set of devices. By default the latest release of the distribution group is used when this property is omitted. If &#x60;release_id&#x60; is passed in the path, there is no need to pass in the body as well. | [optional] 
**Username** | **string** | The username for the Apple Developer account to publish the devices to. | [optional] 
**Password** | **string** | The password for the Apple Developer account to publish the devices to. | [optional] 
**AccountServiceConnectionId** | **string** | The service_connection_id of the stored Apple credentials instead of username, password. | [optional] 
**P12Base64** | **string** | The certificate to use for resigning the application with the updated provisioning profiles. | [optional] 
**P12ServiceConnectionId** | **string** | The service_connection_id of the stored Apple certificate instead of p12_base64 value. | [optional] 
**P12Password** | **string** | The password certificate if one is needed. | [optional] 
**PublishAllDevices** | **bool?** | When set to true, all unprovisioned devices will be published to the Apple Developer account.  When false, only the provided devices will be published to the Apple Developer account. | [optional] 
**Devices** | **List&lt;string&gt;** | Array of device UDID&#x27;s to be published to the Apple Developer account. | [optional] 
**Destinations** | [**List&lt;UpdateDevicesRequestDestinations&gt;**](UpdateDevicesRequestDestinations.md) | Array of distribution groups that the devices should be provisioned from. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

