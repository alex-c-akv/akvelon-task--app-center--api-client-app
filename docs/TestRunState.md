# AppCenterApiClientLib.Model.TestRunState
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Message** | **List&lt;string&gt;** | Multi-line message that describes the status | [optional] 
**WaitTime** | **int?** | Time (in seconds) that the client should wait for before checking the status again | [optional] 
**ExitCode** | **int?** | The exit code that the client should use when exiting. Used for indicating status to the caller of the client. 0: test run completes with no failing tests 1: test run completes with at least one failing test 2: test run failed to complete. Status for test run is unknown  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

