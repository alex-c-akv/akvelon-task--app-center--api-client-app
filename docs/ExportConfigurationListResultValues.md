# AppCenterApiClientLib.Model.ExportConfigurationListResultValues
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Export configuration id | 
**ExportType** | **string** | Target resource type of export configuration | 
**CreationTime** | **string** | Creation time in ISO 8601 format | 
**LastRunTime** | **string** | Latest time in ISO 8601 format when export completed successfully | [optional] 
**ExportEntities** | **List&lt;string&gt;** |  | [optional] 
**State** | **string** | State of the export job | 
**StateInfo** | **string** | Additional information about export configuration state | [optional] 
**ResourceGroup** | **string** | resource group for the storage account/App Insights resource | [optional] 
**ResourceName** | **string** | Storage accout or Appinsights resource name | [optional] 
**ExportConfiguration** | [**ExportConfigurationResultExportConfiguration**](ExportConfigurationResultExportConfiguration.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

