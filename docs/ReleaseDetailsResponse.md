# AppCenterApiClientLib.Model.ReleaseDetailsResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | ID identifying this unique release. | 
**AppName** | **string** | The app&#x27;s name (extracted from the uploaded release). | 
**AppDisplayName** | **string** | The app&#x27;s display name. | 
**AppOs** | **string** | The app&#x27;s OS. | [optional] 
**Version** | **string** | The release&#x27;s version.&lt;br&gt; For iOS: CFBundleVersion from info.plist. For Android: android:versionCode from AppManifest.xml.  | 
**Origin** | **string** | The release&#x27;s origin | [optional] 
**ShortVersion** | **string** | The release&#x27;s short version.&lt;br&gt; For iOS: CFBundleShortVersionString from info.plist. For Android: android:versionName from AppManifest.xml.  | 
**ReleaseNotes** | **string** | The release&#x27;s release notes. | [optional] 
**ProvisioningProfileName** | **string** | The release&#x27;s provisioning profile name. | [optional] 
**ProvisioningProfileType** | **string** | The type of the provisioning profile for the requested app version. | [optional] 
**ProvisioningProfileExpiryDate** | **string** | expiration date of provisioning profile in UTC format. | [optional] 
**IsProvisioningProfileSyncing** | **bool?** | A flag that determines whether the release&#x27;s provisioning profile is still extracted or not. | [optional] 
**Size** | **int?** | The release&#x27;s size in bytes. | [optional] 
**MinOs** | **string** | The release&#x27;s minimum required operating system. | [optional] 
**DeviceFamily** | **string** | The release&#x27;s device family. | [optional] 
**AndroidMinApiLevel** | **string** | The release&#x27;s minimum required Android API level. | [optional] 
**BundleIdentifier** | **string** | The identifier of the apps bundle. | [optional] 
**PackageHashes** | **List&lt;string&gt;** | Hashes for the packages. | [optional] 
**Fingerprint** | **string** | MD5 checksum of the release binary. | [optional] 
**UploadedAt** | **string** | UTC time in ISO 8601 format of the uploaded time. | 
**DownloadUrl** | **string** | The URL that hosts the binary for this release. | [optional] 
**SecondaryDownloadUrl** | **string** | The URL that hosts the secondary binary for this release, such as the apk file for aab releases. | [optional] 
**AppIconUrl** | **string** | A URL to the app&#x27;s icon. | 
**InstallUrl** | **string** | The href required to install a release on a mobile device. On iOS devices will be prefixed with &#x60;itms-services://?action&#x3D;download-manifest&amp;url&#x3D;&#x60; | [optional] 
**DestinationType** | **string** | OBSOLETE. Will be removed in next version. The destination type.&lt;br&gt; &lt;b&gt;group&lt;/b&gt;: The release distributed to internal groups and distribution_groups details will be returned.&lt;br&gt; &lt;b&gt;store&lt;/b&gt;: The release distributed to external stores and distribution_stores details will be returned.&lt;br&gt; &lt;b&gt;tester&lt;/b&gt;: The release distributed testers details will be returned.&lt;br&gt;  | [optional] 
**DistributionGroups** | [**List&lt;ReleaseDetailsResponseDistributionGroups&gt;**](ReleaseDetailsResponseDistributionGroups.md) | OBSOLETE. Will be removed in next version. A list of distribution groups that are associated with this release. | [optional] 
**DistributionStores** | [**List&lt;ReleaseDetailsResponseDistributionStores&gt;**](ReleaseDetailsResponseDistributionStores.md) | OBSOLETE. Will be removed in next version. A list of distribution stores that are associated with this release. | [optional] 
**Destinations** | **List&lt;AllOfReleaseDetailsResponseDestinationsItems&gt;** | A list of distribution groups or stores. | [optional] 
**IsUdidProvisioned** | **bool?** | In calls that allow passing &#x60;udid&#x60; in the query string, this value will hold the provisioning status of that UDID in this release. Will be ignored for non-iOS platforms. | [optional] 
**CanResign** | **bool?** | In calls that allow passing &#x60;udid&#x60; in the query string, this value determines if a release can be re-signed. When true, after a re-sign, the tester will be able to install the release from his registered devices. Will not be returned for non-iOS platforms. | [optional] 
**Build** | [**V01appsownerNameappNamereleasesreleaseIdBuild**](V01appsownerNameappNamereleasesreleaseIdBuild.md) |  | [optional] 
**Enabled** | **bool?** | This value determines the whether a release currently is enabled or disabled. | 
**Status** | **string** | Status of the release. | [optional] 
**IsExternalBuild** | **bool?** | This value determines if a release is external or not. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

