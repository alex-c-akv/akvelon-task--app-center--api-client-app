# AppCenterApiClientLib.Model.SymbolUpload
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SymbolUploadId** | **string** | The id for the current symbol upload | 
**AppId** | **string** | The application that this symbol upload belongs to | 
**User** | [**V01appsownerNameappNamesymbolUploadsUser**](V01appsownerNameappNamesymbolUploadsUser.md) |  | [optional] 
**Status** | **string** | The current status for the symbol upload | 
**SymbolType** | **string** | The type of the symbol for the current symbol upload | 
**SymbolsUploaded** | [**List&lt;V01appsownerNameappNamesymbolUploadsSymbolsUploaded&gt;**](V01appsownerNameappNamesymbolUploadsSymbolsUploaded.md) | The symbols found in the upload. This may be empty until the status is indexed | [optional] 
**Origin** | **string** | The origin of the symbol upload | [optional] 
**FileName** | **string** | The file name for the symbol upload | [optional] 
**FileSize** | [**decimal?**](BigDecimal.md) | The size of the file in Mebibytes. This may be 0 until the status is indexed | [optional] 
**Timestamp** | **DateTime?** | When the symbol upload was committed, or last transaction time if not committed | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

