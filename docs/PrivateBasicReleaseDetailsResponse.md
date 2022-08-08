# AppCenterApiClientLib.Model.PrivateBasicReleaseDetailsResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | ID identifying this unique release. | [optional] 
**Version** | **string** | The release&#x27;s version.&lt;br&gt; For iOS: CFBundleVersion from info.plist.&lt;br&gt; For Android: android:versionCode from AppManifest.xml.  | [optional] 
**Origin** | **string** | The release&#x27;s origin | [optional] 
**ShortVersion** | **string** | The release&#x27;s short version.&lt;br&gt; For iOS: CFBundleShortVersionString from info.plist.&lt;br&gt; For Android: android:versionName from AppManifest.xml.  | [optional] 
**UploadedAt** | **string** | UTC time in ISO 8601 format of the uploaded time. | [optional] 
**DistributionGroupId** | **string** | the destination id of release where it is distributed. | [optional] 
**DestinationType** | **string** | The destination type.&lt;br&gt; &lt;b&gt;group&lt;/b&gt;: The release distributed to internal groups and distribution_groups details will be returned.&lt;br&gt; &lt;b&gt;store&lt;/b&gt;: The release distributed to external stores and distribution_stores details will be returned. &lt;br&gt;  | [optional] 
**IsLatest** | **bool?** | Indicates if this is the latest release in the group. | [optional] 
**MandatoryUpdate** | **bool?** | A boolean which determines whether the release is a mandatory update or not. | [optional] 
**PublishingStatus** | **string** | the publishing status of the distributed release | [optional] 
**IsExternalBuild** | **bool?** | This value determines if a release is external or not. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

