# AppCenterApiClientLib.Api.ExportApi

All URIs are relative to *https://api.appcenter.ms/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExportConfigurationsCreate**](ExportApi.md#exportconfigurationscreate) | **POST** /v0.1/apps/{owner_name}/{app_name}/export_configurations | 
[**ExportConfigurationsDelete**](ExportApi.md#exportconfigurationsdelete) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/export_configurations/{export_configuration_id} | 
[**ExportConfigurationsDisable**](ExportApi.md#exportconfigurationsdisable) | **POST** /v0.1/apps/{owner_name}/{app_name}/export_configurations/{export_configuration_id}/disable | 
[**ExportConfigurationsEnable**](ExportApi.md#exportconfigurationsenable) | **POST** /v0.1/apps/{owner_name}/{app_name}/export_configurations/{export_configuration_id}/enable | 
[**ExportConfigurationsGet**](ExportApi.md#exportconfigurationsget) | **GET** /v0.1/apps/{owner_name}/{app_name}/export_configurations/{export_configuration_id} | 
[**ExportConfigurationsList**](ExportApi.md#exportconfigurationslist) | **GET** /v0.1/apps/{owner_name}/{app_name}/export_configurations | 
[**ExportConfigurationsPartialUpdate**](ExportApi.md#exportconfigurationspartialupdate) | **PATCH** /v0.1/apps/{owner_name}/{app_name}/export_configurations/{export_configuration_id} | 

<a name="exportconfigurationscreate"></a>
# **ExportConfigurationsCreate**
> InlineResponse20036 ExportConfigurationsCreate (AppNameExportConfigurationsBody body, string ownerName, string appName)



Create new export configuration

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ExportConfigurationsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ExportApi();
            var body = new AppNameExportConfigurationsBody(); // AppNameExportConfigurationsBody | Export configurations.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20036 result = apiInstance.ExportConfigurationsCreate(body, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportConfigurationsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AppNameExportConfigurationsBody**](AppNameExportConfigurationsBody.md)| Export configurations. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20036**](InlineResponse20036.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportconfigurationsdelete"></a>
# **ExportConfigurationsDelete**
> void ExportConfigurationsDelete (string exportConfigurationId, string ownerName, string appName)



Delete export configuration.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ExportConfigurationsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ExportApi();
            var exportConfigurationId = exportConfigurationId_example;  // string | The id of the export configuration.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.ExportConfigurationsDelete(exportConfigurationId, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportConfigurationsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exportConfigurationId** | **string**| The id of the export configuration. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportconfigurationsdisable"></a>
# **ExportConfigurationsDisable**
> void ExportConfigurationsDisable (string exportConfigurationId, string ownerName, string appName)



Disable export configuration.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ExportConfigurationsDisableExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ExportApi();
            var exportConfigurationId = exportConfigurationId_example;  // string | The id of the export configuration.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.ExportConfigurationsDisable(exportConfigurationId, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportConfigurationsDisable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exportConfigurationId** | **string**| The id of the export configuration. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportconfigurationsenable"></a>
# **ExportConfigurationsEnable**
> void ExportConfigurationsEnable (string exportConfigurationId, string ownerName, string appName)



Enable export configuration.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ExportConfigurationsEnableExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ExportApi();
            var exportConfigurationId = exportConfigurationId_example;  // string | The id of the export configuration.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.ExportConfigurationsEnable(exportConfigurationId, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportConfigurationsEnable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exportConfigurationId** | **string**| The id of the export configuration. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportconfigurationsget"></a>
# **ExportConfigurationsGet**
> InlineResponse20036 ExportConfigurationsGet (string exportConfigurationId, string ownerName, string appName)



Get export configuration.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ExportConfigurationsGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ExportApi();
            var exportConfigurationId = exportConfigurationId_example;  // string | The id of the export configuration.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20036 result = apiInstance.ExportConfigurationsGet(exportConfigurationId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportConfigurationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exportConfigurationId** | **string**| The id of the export configuration. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20036**](InlineResponse20036.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportconfigurationslist"></a>
# **ExportConfigurationsList**
> InlineResponse20037 ExportConfigurationsList (string ownerName, string appName)



List export configurations.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ExportConfigurationsListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ExportApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20037 result = apiInstance.ExportConfigurationsList(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportConfigurationsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20037**](InlineResponse20037.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportconfigurationspartialupdate"></a>
# **ExportConfigurationsPartialUpdate**
> InlineResponse20036 ExportConfigurationsPartialUpdate (ExportConfigurationsExportConfigurationIdBody body, string exportConfigurationId, string ownerName, string appName)



Partially update export configuration.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ExportConfigurationsPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ExportApi();
            var body = new ExportConfigurationsExportConfigurationIdBody(); // ExportConfigurationsExportConfigurationIdBody | Export configurations.
            var exportConfigurationId = exportConfigurationId_example;  // string | The id of the export configuration.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20036 result = apiInstance.ExportConfigurationsPartialUpdate(body, exportConfigurationId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportConfigurationsPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExportConfigurationsExportConfigurationIdBody**](ExportConfigurationsExportConfigurationIdBody.md)| Export configurations. | 
 **exportConfigurationId** | **string**| The id of the export configuration. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20036**](InlineResponse20036.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
