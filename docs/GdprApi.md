# AppCenterApiClientLib.Api.GdprApi

All URIs are relative to *https://api.appcenter.ms/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DataSubjectRightCancelDeleteRequest**](GdprApi.md#datasubjectrightcanceldeleterequest) | **POST** /v0.1/user/dsr/delete/{token}/cancel | 
[**DataSubjectRightCancelExportRequest**](GdprApi.md#datasubjectrightcancelexportrequest) | **POST** /v0.1/user/dsr/export/{token}/cancel | 
[**DataSubjectRightDeleteRequest**](GdprApi.md#datasubjectrightdeleterequest) | **POST** /v0.1/user/dsr/delete | 
[**DataSubjectRightDeleteStatusRequest**](GdprApi.md#datasubjectrightdeletestatusrequest) | **GET** /v0.1/user/dsr/delete/{token} | 
[**DataSubjectRightExportRequest**](GdprApi.md#datasubjectrightexportrequest) | **POST** /v0.1/user/dsr/export | 
[**DataSubjectRightExportStatusRequest**](GdprApi.md#datasubjectrightexportstatusrequest) | **GET** /v0.1/user/dsr/export/{token} | 

<a name="datasubjectrightcanceldeleterequest"></a>
# **DataSubjectRightCancelDeleteRequest**
> InlineResponse202 DataSubjectRightCancelDeleteRequest (Guid? token, TokenCancelBody body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DataSubjectRightCancelDeleteRequestExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new GdprApi();
            var token = new Guid?(); // Guid? | Unique request ID (GUID)
            var body = new TokenCancelBody(); // TokenCancelBody |  (optional) 

            try
            {
                InlineResponse202 result = apiInstance.DataSubjectRightCancelDeleteRequest(token, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GdprApi.DataSubjectRightCancelDeleteRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | [**Guid?**](Guid?.md)| Unique request ID (GUID) | 
 **body** | [**TokenCancelBody**](TokenCancelBody.md)|  | [optional] 

### Return type

[**InlineResponse202**](InlineResponse202.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="datasubjectrightcancelexportrequest"></a>
# **DataSubjectRightCancelExportRequest**
> InlineResponse202 DataSubjectRightCancelExportRequest (Guid? token)



### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DataSubjectRightCancelExportRequestExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new GdprApi();
            var token = new Guid?(); // Guid? | Unique request ID (GUID)

            try
            {
                InlineResponse202 result = apiInstance.DataSubjectRightCancelExportRequest(token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GdprApi.DataSubjectRightCancelExportRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | [**Guid?**](Guid?.md)| Unique request ID (GUID) | 

### Return type

[**InlineResponse202**](InlineResponse202.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="datasubjectrightdeleterequest"></a>
# **DataSubjectRightDeleteRequest**
> InlineResponse202 DataSubjectRightDeleteRequest ()



### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DataSubjectRightDeleteRequestExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new GdprApi();

            try
            {
                InlineResponse202 result = apiInstance.DataSubjectRightDeleteRequest();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GdprApi.DataSubjectRightDeleteRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse202**](InlineResponse202.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="datasubjectrightdeletestatusrequest"></a>
# **DataSubjectRightDeleteStatusRequest**
> InlineResponse2002 DataSubjectRightDeleteStatusRequest (Guid? token, string email)



### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DataSubjectRightDeleteStatusRequestExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new GdprApi();
            var token = new Guid?(); // Guid? | Unique request ID (GUID)
            var email = email_example;  // string | Email used for delete with x-authz-bypass headers

            try
            {
                InlineResponse2002 result = apiInstance.DataSubjectRightDeleteStatusRequest(token, email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GdprApi.DataSubjectRightDeleteStatusRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | [**Guid?**](Guid?.md)| Unique request ID (GUID) | 
 **email** | **string**| Email used for delete with x-authz-bypass headers | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="datasubjectrightexportrequest"></a>
# **DataSubjectRightExportRequest**
> InlineResponse202 DataSubjectRightExportRequest ()



### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DataSubjectRightExportRequestExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new GdprApi();

            try
            {
                InlineResponse202 result = apiInstance.DataSubjectRightExportRequest();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GdprApi.DataSubjectRightExportRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse202**](InlineResponse202.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="datasubjectrightexportstatusrequest"></a>
# **DataSubjectRightExportStatusRequest**
> InlineResponse2002 DataSubjectRightExportStatusRequest (Guid? token)



### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DataSubjectRightExportStatusRequestExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new GdprApi();
            var token = new Guid?(); // Guid? | Unique request ID (GUID)

            try
            {
                InlineResponse2002 result = apiInstance.DataSubjectRightExportStatusRequest(token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GdprApi.DataSubjectRightExportStatusRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | [**Guid?**](Guid?.md)| Unique request ID (GUID) | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
