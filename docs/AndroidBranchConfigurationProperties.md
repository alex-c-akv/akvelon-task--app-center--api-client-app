# AppCenterApiClientLib.Model.AndroidBranchConfigurationProperties
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GradleWrapperPath** | **string** | Path to the Gradle wrapper script | [optional] 
**Module** | **string** | The Gradle module to build | [optional] 
**BuildVariant** | **string** | The Android build variant to build | [optional] 
**RunTests** | **bool?** | Whether to run unit tests during the build (default) | [optional] [default to true]
**RunLint** | **bool?** | Whether to run lint checks during the build (default) | [optional] 
**IsRoot** | **bool?** | Whether it is the root module or not | [optional] 
**AutomaticSigning** | **bool?** | Whether to apply automatic signing or not | [optional] 
**KeystorePassword** | **string** | The password of the keystore | [optional] 
**KeyAlias** | **string** | The key alias | [optional] 
**KeyPassword** | **string** | The key password | [optional] 
**KeystoreFilename** | **string** | The name of the keystore file | [optional] 
**KeystoreEncoded** | **string** | The keystore encoded value | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

