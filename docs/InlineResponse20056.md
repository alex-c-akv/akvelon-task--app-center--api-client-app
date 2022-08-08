# AppCenterApiClientLib.Model.InlineResponse20056
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**decimal?**](BigDecimal.md) | ID identifying this unique release. | [optional] 
**Status** | **string** | OBSOLETE. Will be removed in next version. The availability concept is now replaced with distributed. Any &#x27;available&#x27; release will be associated with the default distribution group of an app.&lt;/br&gt; The release state.&lt;br&gt; &lt;b&gt;available&lt;/b&gt;: The uploaded release has been distributed.&lt;br&gt; &lt;b&gt;unavailable&lt;/b&gt;: The uploaded release is not visible to the user. &lt;br&gt;  | [optional] 
**AppName** | **string** | The app&#x27;s name (extracted from the uploaded release). | [optional] 
**AppDisplayName** | **string** | The app&#x27;s display name. | [optional] 
**Version** | **string** | The release&#x27;s version.&lt;br&gt; For iOS: CFBundleVersion from info.plist. For Android: android:versionCode from AppManifest.xml.  | [optional] 
**ShortVersion** | **string** | The release&#x27;s short version.&lt;br&gt; For iOS: CFBundleShortVersionString from info.plist. For Android: android:versionName from AppManifest.xml.  | [optional] 
**ReleaseNotes** | **string** | The release&#x27;s release notes. | [optional] 
**Size** | [**decimal?**](BigDecimal.md) | The release&#x27;s size in bytes. | [optional] 
**MinOs** | **string** | The release&#x27;s minimum required operating system. | [optional] 
**AndroidMinApiLevel** | **string** | The release&#x27;s minimum required Android API level. | [optional] 
**BundleIdentifier** | **string** | The identifier of the apps bundle. | [optional] 
**Fingerprint** | **string** | MD5 checksum of the release binary. | [optional] 
**UploadedAt** | **string** | UTC time in ISO 8601 format of the uploaded time. | [optional] 
**DownloadUrl** | **string** | The URL that hosts the binary for this release. | [optional] 
**InstallUrl** | **string** | The href required to install a release on a mobile device. On iOS devices will be prefixed with &#x60;itms-services://?action&#x3D;download-manifest&amp;url&#x3D;&#x60; | [optional] 
**DistributionStores** | [**List&lt;V01appsownerNameappNamedistributionStoresstoreNamereleasesreleaseIdDistributionStores&gt;**](V01appsownerNameappNamedistributionStoresstoreNamereleasesreleaseIdDistributionStores.md) | a list of distribution stores that are associated with this release. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

