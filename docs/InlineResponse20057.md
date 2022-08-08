# AppCenterApiClientLib.Model.InlineResponse20057
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**decimal?**](BigDecimal.md) | ID identifying this unique release. | [optional] 
**Version** | **string** | The release&#x27;s version. For iOS: CFBundleVersion from info.plist. For Android: android:versionCode from AppManifest.xml.  | [optional] 
**ShortVersion** | **string** | The release&#x27;s short version. For iOS: CFBundleShortVersionString from info.plist. For Android: android:versionName from AppManifest.xml.  | [optional] 
**UploadedAt** | **string** | UTC time in ISO 8601 format of the uploaded time. | [optional] 
**DestinationType** | **string** | Destination for this release. | [optional] 
**DistributionStores** | [**List&lt;V01appsownerNameappNamedistributionStoresstoreNamereleasesDistributionStores&gt;**](V01appsownerNameappNamedistributionStoresstoreNamereleasesDistributionStores.md) | a list of distribution stores that are associated with this release. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

