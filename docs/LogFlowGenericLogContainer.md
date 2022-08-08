# AppCenterApiClientLib.Model.LogFlowGenericLogContainer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExceededMaxLimit** | **bool?** | indicates if the number of available logs are more than the max allowed return limit(100). | [optional] 
**LastReceivedLogTimestamp** | **DateTime?** | the timestamp of the last log received. This value can be used as the start time parameter in the consecutive API call. | [optional] 
**Logs** | [**List&lt;LogFlowGenericLogContainerLogs&gt;**](LogFlowGenericLogContainerLogs.md) | the list of logs | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

