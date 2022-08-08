# AppCenterApiClientLib.Model.ManagementReleaseDetailsResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DistinctId** | **int?** | ID identifying this unique release. | [optional] 
**Origin** | **string** | The release&#x27;s origin | [optional] 
**Version** | **string** | The release&#x27;s short version.&lt;br&gt; For iOS: CFBundleShortVersionString from info.plist.&lt;br&gt; For Android: android:versionName from AppManifest.xml.  | [optional] 
**BuildVersion** | **string** | The release&#x27;s buildVersion.&lt;br&gt; For iOS: CFBundleVersion from info.plist.&lt;br&gt; For Android: android:versionCode from AppManifest.xml.  | [optional] 
**SortVersion** | **string** | The release&#x27;s sortVersion. | [optional] 
**CreatedAt** | **string** | UTC time the release was created in ISO 8601 format. | [optional] 
**Enabled** | **bool?** | This value determines the whether a release currently is enabled or disabled. | [optional] 
**DeletedAt** | **string** | UTC time the release was created in ISO 8601 format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

