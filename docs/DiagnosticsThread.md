# AppCenterApiClientLib.Model.DiagnosticsThread
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | name of the thread | 
**Frames** | [**List&lt;ExceptionFrames&gt;**](ExceptionFrames.md) | frames of that thread | 
**Exception** | [**DiagnosticsException**](DiagnosticsException.md) |  | [optional] 
**Relevant** | **bool?** | Shows if a thread is relevant or not. Is false if all frames are non relevant, otherwise true | [optional] 
**Platform** | **string** | SDK/Platform this thread is beeing generated from | [optional] 
**Crashed** | **bool?** | True if this thread crashed | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

