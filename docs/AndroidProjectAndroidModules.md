# AppCenterApiClientLib.Model.AndroidProjectAndroidModules
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the Android module | 
**HasBundle** | **bool?** | Module contains bundle settings | [optional] 
**ProductFlavors** | **List&lt;string&gt;** | The product flavors of the Android module | [optional] 
**BuildVariants** | **List&lt;string&gt;** | The detected build variants of the Android module (matrix of product flavor + build type (debug|release)) | [optional] 
**BuildTypes** | **List&lt;string&gt;** | The detected build types of the Android module | [optional] 
**BuildConfigurations** | [**List&lt;AndroidProjectBuildConfigurations&gt;**](AndroidProjectBuildConfigurations.md) | The detected build configurations of the Android module | [optional] 
**IsRoot** | **bool?** | Whether the module is at the root level of the project | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

