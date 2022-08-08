# AppCenterApiClientLib.Model.MemberDevicesInfoResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid?** | The unique id (UUID) of the user | 
**AvatarUrl** | **string** | The avatar URL of the user | [optional] 
**CanChangePassword** | **bool?** | User is required to send an old password in order to change the password. | [optional] 
**DisplayName** | **string** | The full name of the user. Might for example be first and last name | [optional] 
**Email** | **string** | The email address of the user | 
**InvitePending** | **bool?** | Whether the has accepted the invite. Available when an invite is pending, and the value will be \&quot;true\&quot;. | [optional] 
**Name** | **string** | The unique name that is used to identify the user. | [optional] 
**Udid** | **string** | The Unique Device IDentifier of the device | 
**Model** | **string** | The model identifier of the device, in the format iDeviceM,N | 
**DeviceName** | **string** | The device description, in the format \&quot;iPhone 7 Plus (A1784)\&quot; | 
**FullDeviceName** | **string** | A combination of the device model name and the owner name. | [optional] 
**OsBuild** | **string** | The last known OS version running on the device | 
**OsVersion** | **string** | The last known OS version running on the device | 
**Serial** | **string** | The device&#x27;s serial number. Always empty or undefined at present. | [optional] 
**Imei** | **string** | The device&#x27;s International Mobile Equipment Identity number. Always empty or undefined at present. | [optional] 
**OwnerId** | **string** | The user ID of the device owner. | [optional] 
**Status** | **string** | The provisioning status of the device. | 
**RegisteredAt** | **string** | Timestamp of when the device was registered in ISO format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

