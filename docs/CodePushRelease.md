# AppCenterApiClientLib.Model.CodePushRelease
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** |  | [optional] 
**PackageHash** | **string** |  | [optional] 
**BlobUrl** | **string** |  | [optional] 
**DiffPackageMap** | [**Dictionary&lt;string, CodePushReleaseDiffPackageMap&gt;**](CodePushReleaseDiffPackageMap.md) |  | [optional] 
**OriginalDeployment** | **string** | Set on &#x27;Promote&#x27; | [optional] 
**OriginalLabel** | **string** | Set on &#x27;Promote&#x27; and &#x27;Rollback&#x27; | [optional] 
**ReleasedBy** | **string** |  | [optional] 
**ReleaseMethod** | **string** | The release method is unknown if unspecified | [optional] 
**Size** | [**decimal?**](BigDecimal.md) |  | [optional] 
**UploadTime** | **int?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

