# AppCenterApiClientLib.Model.TestRun1
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid?** | The unique id of the test upload | [optional] 
**Date** | **string** | The date and time the test was uploaded | [optional] 
**AppVersion** | **string** | The compiled version of the app binary | [optional] 
**TestSeries** | **string** | The name of the test series with which this test upload is associated | [optional] 
**Platform** | **string** | The device platform targeted by the test. Possible values are &#x27;ios&#x27; or &#x27;android&#x27; | [optional] 
**RunStatus** | **string** | The current status of the test run, in relation to the various phases | [optional] 
**ResultStatus** | **string** | The passed/failed state | [optional] 
**State** | **string** | Deprecated. Use runStatus instead. | [optional] 
**Status** | **string** | Deprecated. Use resultStatus instead. | [optional] 
**Description** | **string** | Human readable explanation of the current test status | [optional] 
**Stats** | [**TestRunStatistics**](TestRunStatistics.md) |  | [optional] 
**TestType** | **string** | The name of the test framework used to run this test | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

