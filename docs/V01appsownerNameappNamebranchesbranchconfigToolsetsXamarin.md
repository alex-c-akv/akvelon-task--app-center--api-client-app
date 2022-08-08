# AppCenterApiClientLib.Model.V01appsownerNameappNamebranchesbranchconfigToolsetsXamarin
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SlnPath** | **string** |  | [optional] 
**IsSimBuild** | **bool?** |  | [optional] 
**Args** | **string** |  | [optional] 
**Configuration** | **string** |  | [optional] 
**P12File** | **string** |  | [optional] 
**P12Pwd** | **string** |  | [optional] 
**ProvProfile** | **string** |  | [optional] 
**MonoVersion** | **string** |  | [optional] 
**SdkBundle** | **string** |  | [optional] 
**Symlink** | **string** | Symlink of the SDK Bundle and Mono installation. The build will use the associated Mono bundled with related Xamarin SDK. If both symlink and monoVersion or sdkBundle are passed, the symlink is taking precedence. If non-existing symlink is passed, the current stable Mono version will be configured for building.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

