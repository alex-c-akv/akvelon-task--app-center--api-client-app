# AppCenterApiClientLib.Model.LegacyCodePushRelease
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AppVersion** | **string** | The version of the release | [optional] 
**IsDisabled** | **bool?** | Flag used to determine if release is disabled | [optional] 
**IsMandatory** | **bool?** | Flag used to determine if release is mandatory | [optional] 
**Rollout** | **int?** | Percentage (out of 100) that release is deployed to | [optional] 
**BlobUrl** | **string** | Location (URL) of release package | [optional] 
**Size** | **int?** | Size of release package | [optional] 
**ReleaseMethod** | **string** | Method used to deploy release | [optional] 
**UploadTime** | **int?** | Release upload time as epoch Unix timestamp | [optional] 
**Label** | **string** | Release label (aka release name) | [optional] 
**ReleasedByUserId** | **string** | User ID that triggered most recent release | [optional] 
**ManifestBlobUrl** | **string** | The URL location of the package&#x27;s manifest file. | [optional] 
**DiffPackageMap** | **Object** | Object containing URL and size of changed package hashes contained in the release | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

