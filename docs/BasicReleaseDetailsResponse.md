# AppCenterApiClientLib.Model.BasicReleaseDetailsResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | ID identifying this unique release. | 
**Version** | **string** | The release&#x27;s version.&lt;br&gt; For iOS: CFBundleVersion from info.plist.&lt;br&gt; For Android: android:versionCode from AppManifest.xml.  | 
**Origin** | **string** | The release&#x27;s origin | [optional] 
**ShortVersion** | **string** | The release&#x27;s short version.&lt;br&gt; For iOS: CFBundleShortVersionString from info.plist.&lt;br&gt; For Android: android:versionName from AppManifest.xml.  | 
**Enabled** | **bool?** | This value determines the whether a release currently is enabled or disabled. | 
**UploadedAt** | **string** | UTC time in ISO 8601 format of the uploaded time. | 
**DestinationType** | **string** | OBSOLETE. Will be removed in next version. The destination type.&lt;br&gt; &lt;b&gt;group&lt;/b&gt;: The release distributed to internal groups and distribution_groups details will be returned.&lt;br&gt; &lt;b&gt;store&lt;/b&gt;: The release distributed to external stores and distribution_stores details will be returned. &lt;br&gt;  | [optional] 
**DistributionGroups** | **List&lt;AllOfBasicReleaseDetailsResponseDistributionGroupsItems&gt;** | OBSOLETE. Will be removed in next version. A list of distribution groups that are associated with this release. | [optional] 
**DistributionStores** | **List&lt;AllOfBasicReleaseDetailsResponseDistributionStoresItems&gt;** | OBSOLETE. Will be removed in next version. A list of distribution stores that are associated with this release. | [optional] 
**Destinations** | **List&lt;AllOfBasicReleaseDetailsResponseDestinationsItems&gt;** | A list of distribution groups or stores. | [optional] 
**Build** | [**V01appsownerNameappNamereleasesfilterByTesterBuild**](V01appsownerNameappNamereleasesfilterByTesterBuild.md) |  | [optional] 
**IsExternalBuild** | **bool?** | This value determines if a release is external or not. | [optional] 
**FileExtension** | **string** | The file extension of the main (user-uploaded) package file. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

