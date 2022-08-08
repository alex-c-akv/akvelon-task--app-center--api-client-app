# AppCenterApiClientLib.Model.InlineResponse20028
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SymbolId** | **string** | The unique id for this symbol (uuid) | 
**Type** | **string** | The type of the symbol for the current symbol upload | 
**AppId** | **string** | The application that this symbol belongs to | 
**Platform** | **string** | The platform that this symbol is associated with | 
**Url** | **string** | The path name of the symbol file in blob storage | 
**Origin** | **string** | The origin of the symbol file | 
**AlternateSymbolIds** | **List&lt;string&gt;** | The other symbols in the same file | 
**Status** | **string** | Whether the symbol is ignored. | 
**Version** | **string** | The version number. Optional for Apple. Required for Android. | [optional] 
**Build** | **string** | The build number. Optional for Apple. Required for Android. | [optional] 
**SymbolUploadId** | **string** | The id of the symbol upload this symbol belongs to. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

