# AppCenterApiClientLib.Api.ErrorsApi

All URIs are relative to *https://api.appcenter.ms/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ErrorsAppBuildsList**](ErrorsApi.md#errorsappbuildslist) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/availableAppBuilds | 
[**ErrorsAvailableVersions**](ErrorsApi.md#errorsavailableversions) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/available_versions | 
[**ErrorsCountsPerDay**](ErrorsApi.md#errorscountsperday) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/errorCountsPerDay | 
[**ErrorsDeleteError**](ErrorsApi.md#errorsdeleteerror) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/errors/errorGroups/{errorGroupId}/errors/{errorId} | 
[**ErrorsErrorAttachmentLocation**](ErrorsApi.md#errorserrorattachmentlocation) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/{errorId}/attachments/{attachmentId}/location | 
[**ErrorsErrorAttachmentText**](ErrorsApi.md#errorserrorattachmenttext) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/{errorId}/attachments/{attachmentId}/text | 
[**ErrorsErrorAttachments**](ErrorsApi.md#errorserrorattachments) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/{errorId}/attachments | 
[**ErrorsErrorDownload**](ErrorsApi.md#errorserrordownload) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/errorGroups/{errorGroupId}/errors/{errorId}/download | 
[**ErrorsErrorFreeDevicePercentages**](ErrorsApi.md#errorserrorfreedevicepercentages) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/errorfreeDevicePercentages | 
[**ErrorsErrorGroupsSearch**](ErrorsApi.md#errorserrorgroupssearch) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/errorGroups/search | 
[**ErrorsErrorLocation**](ErrorsApi.md#errorserrorlocation) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/errorGroups/{errorGroupId}/errors/{errorId}/location | 
[**ErrorsErrorSearch**](ErrorsApi.md#errorserrorsearch) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/search | 
[**ErrorsErrorStackTrace**](ErrorsApi.md#errorserrorstacktrace) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/errorGroups/{errorGroupId}/errors/{errorId}/stacktrace | 
[**ErrorsGetErrorDetails**](ErrorsApi.md#errorsgeterrordetails) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/errorGroups/{errorGroupId}/errors/{errorId} | 
[**ErrorsGetRetentionSettings**](ErrorsApi.md#errorsgetretentionsettings) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/retention_settings | gets the retention settings in days
[**ErrorsGroupCountsPerDay**](ErrorsApi.md#errorsgroupcountsperday) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/errorGroups/{errorGroupId}/errorCountsPerDay | 
[**ErrorsGroupDetails**](ErrorsApi.md#errorsgroupdetails) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/errorGroups/{errorGroupId} | 
[**ErrorsGroupErrorFreeDevicePercentages**](ErrorsApi.md#errorsgrouperrorfreedevicepercentages) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/errorGroups/{errorGroupId}/errorfreeDevicePercentages | 
[**ErrorsGroupErrorStackTrace**](ErrorsApi.md#errorsgrouperrorstacktrace) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/errorGroups/{errorGroupId}/stacktrace | 
[**ErrorsGroupList**](ErrorsApi.md#errorsgrouplist) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/errorGroups | 
[**ErrorsGroupModelCounts**](ErrorsApi.md#errorsgroupmodelcounts) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/errorGroups/{errorGroupId}/models | 
[**ErrorsGroupOperatingSystemCounts**](ErrorsApi.md#errorsgroupoperatingsystemcounts) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/errorGroups/{errorGroupId}/operatingSystems | 
[**ErrorsLatestErrorDetails**](ErrorsApi.md#errorslatesterrordetails) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/errorGroups/{errorGroupId}/errors/latest | 
[**ErrorsListForGroup**](ErrorsApi.md#errorslistforgroup) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/errorGroups/{errorGroupId}/errors | 
[**ErrorsListSessionLogs**](ErrorsApi.md#errorslistsessionlogs) | **GET** /v0.1/apps/{owner_name}/{app_name}/errors/{errorId}/sessionLogs | 
[**ErrorsUpdateState**](ErrorsApi.md#errorsupdatestate) | **PATCH** /v0.1/apps/{owner_name}/{app_name}/errors/errorGroups/{errorGroupId} | 

<a name="errorsappbuildslist"></a>
# **ErrorsAppBuildsList**
> InlineResponse20055 ErrorsAppBuildsList (string version, DateTime? start, string ownerName, string appName, DateTime? end = null, long? top = null, string errorType = null)



List of app builds

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsAppBuildsListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var version = version_example;  // string | 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format (optional) 
            var top = 789;  // long? | The maximum number of results to return. (0 will fetch all results till the max number.) (optional)  (default to 30)
            var errorType = errorType_example;  // string | Type of error (handled vs unhandled), including All (optional) 

            try
            {
                InlineResponse20055 result = apiInstance.ErrorsAppBuildsList(version, start, ownerName, appName, end, top, errorType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsAppBuildsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**|  | 
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format | [optional] 
 **top** | **long?**| The maximum number of results to return. (0 will fetch all results till the max number.) | [optional] [default to 30]
 **errorType** | **string**| Type of error (handled vs unhandled), including All | [optional] 

### Return type

[**InlineResponse20055**](InlineResponse20055.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorsavailableversions"></a>
# **ErrorsAvailableVersions**
> InlineResponse20054 ErrorsAvailableVersions (DateTime? start, string ownerName, string appName, DateTime? end = null, long? top = null, long? skip = null, string filter = null, string inlinecount = null, string errorType = null)



Get all available versions in the time range.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsAvailableVersionsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format (optional) 
            var top = 789;  // long? | The maximum number of results to return. (0 will fetch all results till the max number.) (optional)  (default to 30)
            var skip = 789;  // long? | The offset (starting at 0) of the first result to return. This parameter along with limit is used to perform pagination. (optional)  (default to 0)
            var filter = filter_example;  // string | A filter as specified in https://github.com/Microsoft/api-guidelines/blob/master/Guidelines.md#97-filtering. (optional) 
            var inlinecount = inlinecount_example;  // string | Controls whether or not to include a count of all the items across all pages. (optional)  (default to none)
            var errorType = errorType_example;  // string | Type of error (handled vs unhandled), including All (optional) 

            try
            {
                InlineResponse20054 result = apiInstance.ErrorsAvailableVersions(start, ownerName, appName, end, top, skip, filter, inlinecount, errorType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsAvailableVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format | [optional] 
 **top** | **long?**| The maximum number of results to return. (0 will fetch all results till the max number.) | [optional] [default to 30]
 **skip** | **long?**| The offset (starting at 0) of the first result to return. This parameter along with limit is used to perform pagination. | [optional] [default to 0]
 **filter** | **string**| A filter as specified in https://github.com/Microsoft/api-guidelines/blob/master/Guidelines.md#97-filtering. | [optional] 
 **inlinecount** | **string**| Controls whether or not to include a count of all the items across all pages. | [optional] [default to none]
 **errorType** | **string**| Type of error (handled vs unhandled), including All | [optional] 

### Return type

[**InlineResponse20054**](InlineResponse20054.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorscountsperday"></a>
# **ErrorsCountsPerDay**
> InlineResponse20050 ErrorsCountsPerDay (DateTime? start, string ownerName, string appName, string version = null, DateTime? end = null, string appBuild = null, string errorType = null)



Count of crashes or errors by day in the time range based the selected versions. If SingleErrorTypeParameter is not provided, defaults to handlederror.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsCountsPerDayExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var version = version_example;  // string |  (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format (optional) 
            var appBuild = appBuild_example;  // string | app build (optional) 
            var errorType = errorType_example;  // string | Type of error (handled vs unhandled), excluding All (optional) 

            try
            {
                InlineResponse20050 result = apiInstance.ErrorsCountsPerDay(start, ownerName, appName, version, end, appBuild, errorType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsCountsPerDay: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **version** | **string**|  | [optional] 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format | [optional] 
 **appBuild** | **string**| app build | [optional] 
 **errorType** | **string**| Type of error (handled vs unhandled), excluding All | [optional] 

### Return type

[**InlineResponse20050**](InlineResponse20050.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorsdeleteerror"></a>
# **ErrorsDeleteError**
> InlineResponse20048 ErrorsDeleteError (string errorGroupId, string errorId, string ownerName, string appName)



Delete a specific error and related attachments and blobs for an app. Searchable data will not be deleted immediately and may take up to 30 days.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsDeleteErrorExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var errorGroupId = errorGroupId_example;  // string | The id of the error group
            var errorId = errorId_example;  // string | The id of the error
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20048 result = apiInstance.ErrorsDeleteError(errorGroupId, errorId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsDeleteError: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **errorGroupId** | **string**| The id of the error group | 
 **errorId** | **string**| The id of the error | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20048**](InlineResponse20048.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorserrorattachmentlocation"></a>
# **ErrorsErrorAttachmentLocation**
> InlineResponse20040 ErrorsErrorAttachmentLocation (string errorId, string attachmentId, string ownerName, string appName)



Error attachment location.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsErrorAttachmentLocationExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var errorId = errorId_example;  // string | The id of the error
            var attachmentId = attachmentId_example;  // string | Error attachment id.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20040 result = apiInstance.ErrorsErrorAttachmentLocation(errorId, attachmentId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsErrorAttachmentLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **errorId** | **string**| The id of the error | 
 **attachmentId** | **string**| Error attachment id. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20040**](InlineResponse20040.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorserrorattachmenttext"></a>
# **ErrorsErrorAttachmentText**
> InlineResponse20039 ErrorsErrorAttachmentText (string errorId, string attachmentId, string ownerName, string appName)



Error attachment text.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsErrorAttachmentTextExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var errorId = errorId_example;  // string | The id of the error
            var attachmentId = attachmentId_example;  // string | Error attachment id.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20039 result = apiInstance.ErrorsErrorAttachmentText(errorId, attachmentId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsErrorAttachmentText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **errorId** | **string**| The id of the error | 
 **attachmentId** | **string**| Error attachment id. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20039**](InlineResponse20039.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorserrorattachments"></a>
# **ErrorsErrorAttachments**
> List<InlineResponse20041> ErrorsErrorAttachments (string errorId, string ownerName, string appName)



List error attachments.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsErrorAttachmentsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var errorId = errorId_example;  // string | The id of the error
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse20041&gt; result = apiInstance.ErrorsErrorAttachments(errorId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsErrorAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **errorId** | **string**| The id of the error | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**List<InlineResponse20041>**](InlineResponse20041.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorserrordownload"></a>
# **ErrorsErrorDownload**
> Object ErrorsErrorDownload (string errorGroupId, string errorId, string ownerName, string appName, string format = null)



Download details for a specific error.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsErrorDownloadExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var errorGroupId = errorGroupId_example;  // string | The id of the error group
            var errorId = errorId_example;  // string | The id of the error
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var format = format_example;  // string | the format of the crash log (optional) 

            try
            {
                Object result = apiInstance.ErrorsErrorDownload(errorGroupId, errorId, ownerName, appName, format);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsErrorDownload: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **errorGroupId** | **string**| The id of the error group | 
 **errorId** | **string**| The id of the error | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **format** | **string**| the format of the crash log | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorserrorfreedevicepercentages"></a>
# **ErrorsErrorFreeDevicePercentages**
> InlineResponse20044 ErrorsErrorFreeDevicePercentages (DateTime? start, string ownerName, string appName, DateTime? end = null, List<string> versions = null, string appBuild = null, string errorType = null)



Percentage of error-free devices by day in the time range based on the selected versions. If SingleErrorTypeParameter is not provided, defaults to handlederror. API will return -1 if crash devices is greater than active devices

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsErrorFreeDevicePercentagesExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format (optional) 
            var versions = new List<string>(); // List<string> |  (optional) 
            var appBuild = appBuild_example;  // string | app build (optional) 
            var errorType = errorType_example;  // string | Type of error (handled vs unhandled), excluding All (optional) 

            try
            {
                InlineResponse20044 result = apiInstance.ErrorsErrorFreeDevicePercentages(start, ownerName, appName, end, versions, appBuild, errorType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsErrorFreeDevicePercentages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format | [optional] 
 **versions** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **appBuild** | **string**| app build | [optional] 
 **errorType** | **string**| Type of error (handled vs unhandled), excluding All | [optional] 

### Return type

[**InlineResponse20044**](InlineResponse20044.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorserrorgroupssearch"></a>
# **ErrorsErrorGroupsSearch**
> InlineResponse20052 ErrorsErrorGroupsSearch (string ownerName, string appName, string filter = null, string q = null, string order = null, string sort = null, long? top = null, long? skip = null)



Error groups list based on search parameters

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsErrorGroupsSearchExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var filter = filter_example;  // string | A filter as specified in OData notation (optional) 
            var q = q_example;  // string | A query string (optional) 
            var order = order_example;  // string | It controls the order of sorting (optional)  (default to desc)
            var sort = sort_example;  // string | It controls the sort based on specified field (optional)  (default to matchingReportsCount)
            var top = 789;  // long? | The maximum number of results to return (optional)  (default to 100)
            var skip = 789;  // long? | The offset (starting at 0) of the first result to return. This parameter along with limit is used to perform pagination. (optional)  (default to 0)

            try
            {
                InlineResponse20052 result = apiInstance.ErrorsErrorGroupsSearch(ownerName, appName, filter, q, order, sort, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsErrorGroupsSearch: " + e.Message );
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
 **filter** | **string**| A filter as specified in OData notation | [optional] 
 **q** | **string**| A query string | [optional] 
 **order** | **string**| It controls the order of sorting | [optional] [default to desc]
 **sort** | **string**| It controls the sort based on specified field | [optional] [default to matchingReportsCount]
 **top** | **long?**| The maximum number of results to return | [optional] [default to 100]
 **skip** | **long?**| The offset (starting at 0) of the first result to return. This parameter along with limit is used to perform pagination. | [optional] [default to 0]

### Return type

[**InlineResponse20052**](InlineResponse20052.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorserrorlocation"></a>
# **ErrorsErrorLocation**
> InlineResponse20040 ErrorsErrorLocation (string errorGroupId, string errorId, string ownerName, string appName)



Error location.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsErrorLocationExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var errorGroupId = errorGroupId_example;  // string | The id of the error group
            var errorId = errorId_example;  // string | The id of the error
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20040 result = apiInstance.ErrorsErrorLocation(errorGroupId, errorId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsErrorLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **errorGroupId** | **string**| The id of the error group | 
 **errorId** | **string**| The id of the error | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20040**](InlineResponse20040.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorserrorsearch"></a>
# **ErrorsErrorSearch**
> InlineResponse20042 ErrorsErrorSearch (string ownerName, string appName, string filter = null, string q = null, string order = null, string sort = null, long? top = null, long? skip = null)



Errors list based on search parameters

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsErrorSearchExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var filter = filter_example;  // string | A filter as specified in OData notation (optional) 
            var q = q_example;  // string | A query string (optional) 
            var order = order_example;  // string | It controls the order of sorting (optional)  (default to desc)
            var sort = sort_example;  // string | It controls the sort based on specified field (optional)  (default to timestamp)
            var top = 789;  // long? | The maximum number of results to return (optional)  (default to 100)
            var skip = 789;  // long? | The offset (starting at 0) of the first result to return. This parameter along with limit is used to perform pagination. (optional)  (default to 0)

            try
            {
                InlineResponse20042 result = apiInstance.ErrorsErrorSearch(ownerName, appName, filter, q, order, sort, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsErrorSearch: " + e.Message );
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
 **filter** | **string**| A filter as specified in OData notation | [optional] 
 **q** | **string**| A query string | [optional] 
 **order** | **string**| It controls the order of sorting | [optional] [default to desc]
 **sort** | **string**| It controls the sort based on specified field | [optional] [default to timestamp]
 **top** | **long?**| The maximum number of results to return | [optional] [default to 100]
 **skip** | **long?**| The offset (starting at 0) of the first result to return. This parameter along with limit is used to perform pagination. | [optional] [default to 0]

### Return type

[**InlineResponse20042**](InlineResponse20042.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorserrorstacktrace"></a>
# **ErrorsErrorStackTrace**
> DiagnosticsStackTrace ErrorsErrorStackTrace (string errorGroupId, string errorId, string ownerName, string appName)



Error Stacktrace details.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsErrorStackTraceExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var errorGroupId = errorGroupId_example;  // string | The id of the error group
            var errorId = errorId_example;  // string | The id of the error
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                DiagnosticsStackTrace result = apiInstance.ErrorsErrorStackTrace(errorGroupId, errorId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsErrorStackTrace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **errorGroupId** | **string**| The id of the error group | 
 **errorId** | **string**| The id of the error | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**DiagnosticsStackTrace**](DiagnosticsStackTrace.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorsgeterrordetails"></a>
# **ErrorsGetErrorDetails**
> InlineResponse20047 ErrorsGetErrorDetails (string errorGroupId, string errorId, string ownerName, string appName)



Error details.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsGetErrorDetailsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var errorGroupId = errorGroupId_example;  // string | The id of the error group
            var errorId = errorId_example;  // string | The id of the error
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20047 result = apiInstance.ErrorsGetErrorDetails(errorGroupId, errorId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsGetErrorDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **errorGroupId** | **string**| The id of the error group | 
 **errorId** | **string**| The id of the error | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20047**](InlineResponse20047.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorsgetretentionsettings"></a>
# **ErrorsGetRetentionSettings**
> InlineResponse20043 ErrorsGetRetentionSettings (string ownerName, string appName)

gets the retention settings in days

gets the retention settings in days

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsGetRetentionSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                // gets the retention settings in days
                InlineResponse20043 result = apiInstance.ErrorsGetRetentionSettings(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsGetRetentionSettings: " + e.Message );
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

[**InlineResponse20043**](InlineResponse20043.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorsgroupcountsperday"></a>
# **ErrorsGroupCountsPerDay**
> InlineResponse20050 ErrorsGroupCountsPerDay (string errorGroupId, DateTime? start, string ownerName, string appName, string version = null, DateTime? end = null)



Count of errors by day in the time range of the selected error group with selected version

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsGroupCountsPerDayExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var errorGroupId = errorGroupId_example;  // string | The id of the error group
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var version = version_example;  // string |  (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format (optional) 

            try
            {
                InlineResponse20050 result = apiInstance.ErrorsGroupCountsPerDay(errorGroupId, start, ownerName, appName, version, end);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsGroupCountsPerDay: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **errorGroupId** | **string**| The id of the error group | 
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **version** | **string**|  | [optional] 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format | [optional] 

### Return type

[**InlineResponse20050**](InlineResponse20050.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorsgroupdetails"></a>
# **ErrorsGroupDetails**
> InlineResponse20051 ErrorsGroupDetails (string errorGroupId, string ownerName, string appName)



Error group details

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsGroupDetailsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var errorGroupId = errorGroupId_example;  // string | The id of the error group
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20051 result = apiInstance.ErrorsGroupDetails(errorGroupId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsGroupDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **errorGroupId** | **string**| The id of the error group | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20051**](InlineResponse20051.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorsgrouperrorfreedevicepercentages"></a>
# **ErrorsGroupErrorFreeDevicePercentages**
> InlineResponse20044 ErrorsGroupErrorFreeDevicePercentages (string errorGroupId, DateTime? start, string ownerName, string appName, DateTime? end = null)



Percentage of error-free devices by day in the time range. Api will return -1 if crash devices is greater than active devices

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsGroupErrorFreeDevicePercentagesExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var errorGroupId = errorGroupId_example;  // string | The id of the error group
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format (optional) 

            try
            {
                InlineResponse20044 result = apiInstance.ErrorsGroupErrorFreeDevicePercentages(errorGroupId, start, ownerName, appName, end);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsGroupErrorFreeDevicePercentages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **errorGroupId** | **string**| The id of the error group | 
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format | [optional] 

### Return type

[**InlineResponse20044**](InlineResponse20044.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorsgrouperrorstacktrace"></a>
# **ErrorsGroupErrorStackTrace**
> DiagnosticsStackTrace ErrorsGroupErrorStackTrace (string errorGroupId, string ownerName, string appName)



Gets the stack trace for the error group.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsGroupErrorStackTraceExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var errorGroupId = errorGroupId_example;  // string | The id of the error group
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                DiagnosticsStackTrace result = apiInstance.ErrorsGroupErrorStackTrace(errorGroupId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsGroupErrorStackTrace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **errorGroupId** | **string**| The id of the error group | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**DiagnosticsStackTrace**](DiagnosticsStackTrace.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorsgrouplist"></a>
# **ErrorsGroupList**
> InlineResponse20053 ErrorsGroupList (DateTime? start, string ownerName, string appName, string version = null, string appBuild = null, string groupState = null, DateTime? end = null, string orderby = null, long? top = null, string errorType = null)



List of error groups

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsGroupListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var version = version_example;  // string |  (optional) 
            var appBuild = appBuild_example;  // string | app build (optional) 
            var groupState = groupState_example;  // string |  (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format (optional) 
            var orderby = orderby_example;  // string | controls the sorting order and sorting based on which column (optional)  (default to count desc)
            var top = 789;  // long? | The maximum number of results to return. (0 will fetch all results till the max number.) (optional)  (default to 30)
            var errorType = errorType_example;  // string | Type of error (handled vs unhandled), including All (optional) 

            try
            {
                InlineResponse20053 result = apiInstance.ErrorsGroupList(start, ownerName, appName, version, appBuild, groupState, end, orderby, top, errorType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsGroupList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **version** | **string**|  | [optional] 
 **appBuild** | **string**| app build | [optional] 
 **groupState** | **string**|  | [optional] 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format | [optional] 
 **orderby** | **string**| controls the sorting order and sorting based on which column | [optional] [default to count desc]
 **top** | **long?**| The maximum number of results to return. (0 will fetch all results till the max number.) | [optional] [default to 30]
 **errorType** | **string**| Type of error (handled vs unhandled), including All | [optional] 

### Return type

[**InlineResponse20053**](InlineResponse20053.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorsgroupmodelcounts"></a>
# **ErrorsGroupModelCounts**
> InlineResponse20046 ErrorsGroupModelCounts (string errorGroupId, string ownerName, string appName, long? top = null)



Top models of the selected error group.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsGroupModelCountsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var errorGroupId = errorGroupId_example;  // string | The id of the error group
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var top = 789;  // long? | The maximum number of results to return. (0 will fetch all results till the max number.) (optional)  (default to 30)

            try
            {
                InlineResponse20046 result = apiInstance.ErrorsGroupModelCounts(errorGroupId, ownerName, appName, top);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsGroupModelCounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **errorGroupId** | **string**| The id of the error group | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **top** | **long?**| The maximum number of results to return. (0 will fetch all results till the max number.) | [optional] [default to 30]

### Return type

[**InlineResponse20046**](InlineResponse20046.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorsgroupoperatingsystemcounts"></a>
# **ErrorsGroupOperatingSystemCounts**
> InlineResponse20045 ErrorsGroupOperatingSystemCounts (string errorGroupId, string ownerName, string appName, long? top = null)



Top OSes of the selected error group.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsGroupOperatingSystemCountsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var errorGroupId = errorGroupId_example;  // string | The id of the error group
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var top = 789;  // long? | The maximum number of results to return. (0 will fetch all results till the max number.) (optional)  (default to 30)

            try
            {
                InlineResponse20045 result = apiInstance.ErrorsGroupOperatingSystemCounts(errorGroupId, ownerName, appName, top);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsGroupOperatingSystemCounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **errorGroupId** | **string**| The id of the error group | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **top** | **long?**| The maximum number of results to return. (0 will fetch all results till the max number.) | [optional] [default to 30]

### Return type

[**InlineResponse20045**](InlineResponse20045.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorslatesterrordetails"></a>
# **ErrorsLatestErrorDetails**
> InlineResponse20047 ErrorsLatestErrorDetails (string errorGroupId, string ownerName, string appName)



Latest error details.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsLatestErrorDetailsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var errorGroupId = errorGroupId_example;  // string | The id of the error group
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20047 result = apiInstance.ErrorsLatestErrorDetails(errorGroupId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsLatestErrorDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **errorGroupId** | **string**| The id of the error group | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20047**](InlineResponse20047.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorslistforgroup"></a>
# **ErrorsListForGroup**
> InlineResponse20049 ErrorsListForGroup (string errorGroupId, DateTime? start, string ownerName, string appName, DateTime? end = null, long? top = null, string model = null, string os = null)



Get all errors for group

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsListForGroupExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var errorGroupId = errorGroupId_example;  // string | The id of the error group
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format (optional) 
            var top = 789;  // long? | The maximum number of results to return. (0 will fetch all results till the max number.) (optional)  (default to 30)
            var model = model_example;  // string |  (optional) 
            var os = os_example;  // string |  (optional) 

            try
            {
                InlineResponse20049 result = apiInstance.ErrorsListForGroup(errorGroupId, start, ownerName, appName, end, top, model, os);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsListForGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **errorGroupId** | **string**| The id of the error group | 
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format | [optional] 
 **top** | **long?**| The maximum number of results to return. (0 will fetch all results till the max number.) | [optional] [default to 30]
 **model** | **string**|  | [optional] 
 **os** | **string**|  | [optional] 

### Return type

[**InlineResponse20049**](InlineResponse20049.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorslistsessionlogs"></a>
# **ErrorsListSessionLogs**
> InlineResponse20038 ErrorsListSessionLogs (string errorId, string ownerName, string appName, DateTime? date = null)



Get session logs by error ID

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsListSessionLogsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var errorId = errorId_example;  // string | The id of the error
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | Date of data requested (optional) 

            try
            {
                InlineResponse20038 result = apiInstance.ErrorsListSessionLogs(errorId, ownerName, appName, date);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsListSessionLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **errorId** | **string**| The id of the error | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **date** | **DateTime?**| Date of data requested | [optional] 

### Return type

[**InlineResponse20038**](InlineResponse20038.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="errorsupdatestate"></a>
# **ErrorsUpdateState**
> InlineResponse20051 ErrorsUpdateState (ErrorGroupsErrorGroupIdBody body, string errorGroupId, string ownerName, string appName)



Update error group state

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ErrorsUpdateStateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new ErrorsApi();
            var body = new ErrorGroupsErrorGroupIdBody(); // ErrorGroupsErrorGroupIdBody | The state of the error group
            var errorGroupId = errorGroupId_example;  // string | The id of the error group
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20051 result = apiInstance.ErrorsUpdateState(body, errorGroupId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorsApi.ErrorsUpdateState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ErrorGroupsErrorGroupIdBody**](ErrorGroupsErrorGroupIdBody.md)| The state of the error group | 
 **errorGroupId** | **string**| The id of the error group | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20051**](InlineResponse20051.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
