# AppCenterApiClientLib.Model.DiagnosticsException
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reason** | **string** | Reason of the exception | [optional] 
**Type** | **string** | Type of the exception (NSSomethingException, NullPointerException) | [optional] 
**Frames** | [**List&lt;ExceptionFrames&gt;**](ExceptionFrames.md) | frames of the excetpion | 
**Relevant** | **bool?** | relevant exception (crashed) | [optional] 
**InnerExceptions** | [**List&lt;DiagnosticsException&gt;**](DiagnosticsException.md) |  | [optional] 
**Platform** | **string** | SDK/Platform this thread is beeing generated from | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

