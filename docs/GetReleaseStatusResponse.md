# AppCenterApiClientLib.Model.GetReleaseStatusResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid?** | The ID for the upload. | 
**UploadStatus** | **string** | The current upload status. | 
**ErrorDetails** | **string** | Details describing what went wrong processing the upload. Will only be set if status &#x3D; &#x27;error&#x27;. | [optional] 
**ReleaseDistinctId** | [**decimal?**](BigDecimal.md) | The distinct ID of the release. Will only be set when the status &#x3D; &#x27;readyToBePublished&#x27;. | [optional] 
**ReleaseUrl** | **Object** | The URL of the release. Will only be set when the status &#x3D; &#x27;readyToBePublished&#x27;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

