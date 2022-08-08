# AppCenterApiClientLib.Model.DistributionGroupRelease
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | ID identifying this unique release. | 
**Version** | **string** | The release&#x27;s version.&lt;br&gt; For iOS: CFBundleVersion from info.plist.&lt;br&gt; For Android: android:versionCode from AppManifest.xml.  | 
**Origin** | **string** | The release&#x27;s origin | [optional] 
**ShortVersion** | **string** | The release&#x27;s short version.&lt;br&gt; For iOS: CFBundleShortVersionString from info.plist.&lt;br&gt; For Android: android:versionName from AppManifest.xml.  | 
**MandatoryUpdate** | **bool?** | A boolean which determines whether the release is a mandatory update or not. | 
**UploadedAt** | **string** | UTC time in ISO 8601 format of the uploaded time. | 
**Enabled** | **bool?** | This value determines the whether a release currently is enabled or disabled. | 
**IsExternalBuild** | **bool?** | This value determines if a release is external or not. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

