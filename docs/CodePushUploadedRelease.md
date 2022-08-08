# AppCenterApiClientLib.Model.CodePushUploadedRelease
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReleaseUpload** | [**V01appsownerNameappNamedeploymentsdeploymentNamereleasesReleaseUpload**](V01appsownerNameappNamedeploymentsdeploymentNamereleasesReleaseUpload.md) |  | 
**TargetBinaryVersion** | **string** | the binary version of the application | 
**DeploymentName** | **string** | This specifies which deployment you want to release the update to. Default is Staging. | [optional] 
**Description** | **string** | This provides an optional \&quot;change log\&quot; for the deployment. | [optional] 
**Disabled** | **bool?** | This specifies whether an update should be downloadable by end users or not. | [optional] 
**Mandatory** | **bool?** | This specifies whether the update should be considered mandatory or not (e.g. it includes a critical security fix). | [optional] 
**NoDuplicateReleaseError** | **bool?** | This specifies that if the update is identical to the latest release on the deployment, the CLI should generate a warning instead of an error. | [optional] 
**Rollout** | **int?** | This specifies the percentage of users (as an integer between 1 and 100) that should be eligible to receive this update. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

