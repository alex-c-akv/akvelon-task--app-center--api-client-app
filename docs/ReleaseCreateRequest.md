# AppCenterApiClientLib.Model.ReleaseCreateRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Version** | **string** | The release&#x27;s version.&lt;br&gt; For iOS: CFBundleVersion from info.plist.&lt;br&gt; For Android: android:versionCode from AppManifest.xml.  | [optional] 
**BuildVersion** | **string** | The release&#x27;s short version.&lt;br&gt; For iOS: CFBundleShortVersionString from info.plist.&lt;br&gt; For Android: android:versionName from AppManifest.xml.  | [optional] 
**UniqueIdentifier** | **string** | The identifier of the app&#x27;s bundle. | [optional] 
**MinimumOsVersion** | **string** | The release&#x27;s minimum required operating system. | [optional] 
**DeviceFamily** | **string** | The release&#x27;s device family. | [optional] 
**Languages** | **List&lt;string&gt;** | The languages supported by the release. Limited to 510 characters in a serialized array. | [optional] 
**Fingerprint** | **string** | MD5 checksum of the release binary. | 
**Size** | **int?** | The release&#x27;s size in bytes. | 
**PackageUrl** | **string** | The URL to the release&#x27;s binary. | [optional] 
**FileExtension** | **string** | The file extension of the asset. Does not include the initial period. | [optional] 
**UploadId** | **string** | The upload id associated with the release, to map to the releases upload table. | 
**IconAssetId** | **string** | The assetId associated with the icon uploaded to app center file upload service. | [optional] 
**IpaUuids** | [**List&lt;ReleaseCreateRequestIpaUuids&gt;**](ReleaseCreateRequestIpaUuids.md) | A list of UUIDs for architectures for an iOS app. | [optional] 
**Provision** | [**ReleaseCreateRequestProvision**](ReleaseCreateRequestProvision.md) |  | [optional] 
**AppexProvisioningProfiles** | [**List&lt;ReleaseCreateRequestProvision&gt;**](ReleaseCreateRequestProvision.md) | iOS app extension provisioning profiles included in the release. | [optional] 
**ProxyFlow** | **bool?** | If true this release was uploaded to the AKS upload proxy | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

