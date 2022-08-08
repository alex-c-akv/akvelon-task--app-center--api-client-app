# AppCenterApiClientLib.Api.CrashApi

All URIs are relative to *https://api.appcenter.ms/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CrashGroupsGet**](CrashApi.md#crashgroupsget) | **GET** /v0.1/apps/{owner_name}/{app_name}/crash_groups/{crash_group_id} | 
[**CrashGroupsGetStacktrace**](CrashApi.md#crashgroupsgetstacktrace) | **GET** /v0.1/apps/{owner_name}/{app_name}/crash_groups/{crash_group_id}/stacktrace | 
[**CrashGroupsList**](CrashApi.md#crashgroupslist) | **GET** /v0.1/apps/{owner_name}/{app_name}/crash_groups | 
[**CrashGroupsUpdate**](CrashApi.md#crashgroupsupdate) | **PATCH** /v0.1/apps/{owner_name}/{app_name}/crash_groups/{crash_group_id} | 
[**CrashesDelete**](CrashApi.md#crashesdelete) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/crash_groups/{crash_group_id}/crashes/{crash_id} | 
[**CrashesGet**](CrashApi.md#crashesget) | **GET** /v0.1/apps/{owner_name}/{app_name}/crash_groups/{crash_group_id}/crashes/{crash_id} | 
[**CrashesGetAppCrashesInfo**](CrashApi.md#crashesgetappcrashesinfo) | **GET** /v0.1/apps/{owner_name}/{app_name}/crashes_info | 
[**CrashesGetAppVersions**](CrashApi.md#crashesgetappversions) | **GET** /v0.1/apps/{owner_name}/{app_name}/versions | 
[**CrashesGetCrashAttachmentLocation**](CrashApi.md#crashesgetcrashattachmentlocation) | **GET** /v0.1/apps/{owner_name}/{app_name}/crashes/{crash_id}/attachments/{attachment_id}/location | 
[**CrashesGetCrashTextAttachmentContent**](CrashApi.md#crashesgetcrashtextattachmentcontent) | **GET** /v0.1/apps/{owner_name}/{app_name}/crashes/{crash_id}/attachments/{attachment_id}/text | 
[**CrashesGetNativeCrash**](CrashApi.md#crashesgetnativecrash) | **GET** /v0.1/apps/{owner_name}/{app_name}/crash_groups/{crash_group_id}/crashes/{crash_id}/native | 
[**CrashesGetNativeCrashDownload**](CrashApi.md#crashesgetnativecrashdownload) | **GET** /v0.1/apps/{owner_name}/{app_name}/crash_groups/{crash_group_id}/crashes/{crash_id}/native/download | 
[**CrashesGetRawCrashLocation**](CrashApi.md#crashesgetrawcrashlocation) | **GET** /v0.1/apps/{owner_name}/{app_name}/crash_groups/{crash_group_id}/crashes/{crash_id}/raw/location | 
[**CrashesGetStacktrace**](CrashApi.md#crashesgetstacktrace) | **GET** /v0.1/apps/{owner_name}/{app_name}/crash_groups/{crash_group_id}/crashes/{crash_id}/stacktrace | 
[**CrashesList**](CrashApi.md#crasheslist) | **GET** /v0.1/apps/{owner_name}/{app_name}/crash_groups/{crash_group_id}/crashes | 
[**CrashesListAttachments**](CrashApi.md#crasheslistattachments) | **GET** /v0.1/apps/{owner_name}/{app_name}/crashes/{crash_id}/attachments | 
[**MissingSymbolGroupsGet**](CrashApi.md#missingsymbolgroupsget) | **GET** /v0.1/apps/{owner_name}/{app_name}/diagnostics/symbol_groups/{symbol_group_id} | Gets missing symbol crash group by its id
[**MissingSymbolGroupsInfo**](CrashApi.md#missingsymbolgroupsinfo) | **GET** /v0.1/apps/{owner_name}/{app_name}/diagnostics/symbol_groups_info | Gets application level statistics for all missing symbol groups
[**MissingSymbolGroupsList**](CrashApi.md#missingsymbolgroupslist) | **GET** /v0.1/apps/{owner_name}/{app_name}/diagnostics/symbol_groups | Gets top N (ordered by crash count) of crash groups by missing symbol
[**SymbolUploadsComplete**](CrashApi.md#symboluploadscomplete) | **PATCH** /v0.1/apps/{owner_name}/{app_name}/symbol_uploads/{symbol_upload_id} | 
[**SymbolUploadsCreate**](CrashApi.md#symboluploadscreate) | **POST** /v0.1/apps/{owner_name}/{app_name}/symbol_uploads | 
[**SymbolUploadsDelete**](CrashApi.md#symboluploadsdelete) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/symbol_uploads/{symbol_upload_id} | 
[**SymbolUploadsGet**](CrashApi.md#symboluploadsget) | **GET** /v0.1/apps/{owner_name}/{app_name}/symbol_uploads/{symbol_upload_id} | 
[**SymbolUploadsGetLocation**](CrashApi.md#symboluploadsgetlocation) | **GET** /v0.1/apps/{owner_name}/{app_name}/symbol_uploads/{symbol_upload_id}/location | 
[**SymbolUploadsList**](CrashApi.md#symboluploadslist) | **GET** /v0.1/apps/{owner_name}/{app_name}/symbol_uploads | 
[**SymbolsGet**](CrashApi.md#symbolsget) | **GET** /v0.1/apps/{owner_name}/{app_name}/symbols/{symbol_id} | 
[**SymbolsGetLocation**](CrashApi.md#symbolsgetlocation) | **GET** /v0.1/apps/{owner_name}/{app_name}/symbols/{symbol_id}/location | 
[**SymbolsGetStatus**](CrashApi.md#symbolsgetstatus) | **GET** /v0.1/apps/{owner_name}/{app_name}/symbols/{symbol_id}/status | 
[**SymbolsIgnore**](CrashApi.md#symbolsignore) | **POST** /v0.1/apps/{owner_name}/{app_name}/symbols/{symbol_id}/ignore | 
[**SymbolsList**](CrashApi.md#symbolslist) | **GET** /v0.1/apps/{owner_name}/{app_name}/symbols | 

<a name="crashgroupsget"></a>
# **CrashGroupsGet**
> InlineResponse20070 CrashGroupsGet (string crashGroupId, string ownerName, string appName)



Gets a specific group.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CrashGroupsGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var crashGroupId = crashGroupId_example;  // string | id of a specific group
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20070 result = apiInstance.CrashGroupsGet(crashGroupId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.CrashGroupsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **crashGroupId** | **string**| id of a specific group | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20070**](InlineResponse20070.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="crashgroupsgetstacktrace"></a>
# **CrashGroupsGetStacktrace**
> Stacktrace CrashGroupsGetStacktrace (string crashGroupId, string ownerName, string appName, bool? groupingOnly = null)



Gets a stacktrace for a specific crash.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CrashGroupsGetStacktraceExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var crashGroupId = crashGroupId_example;  // string | id of a specific group
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var groupingOnly = true;  // bool? | true if the stacktrace should be only the relevant thread / exception. Default is false (optional)  (default to false)

            try
            {
                Stacktrace result = apiInstance.CrashGroupsGetStacktrace(crashGroupId, ownerName, appName, groupingOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.CrashGroupsGetStacktrace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **crashGroupId** | **string**| id of a specific group | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **groupingOnly** | **bool?**| true if the stacktrace should be only the relevant thread / exception. Default is false | [optional] [default to false]

### Return type

[**Stacktrace**](Stacktrace.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="crashgroupslist"></a>
# **CrashGroupsList**
> InlineResponse20071 CrashGroupsList (string ownerName, string appName, DateTime? lastOccurrenceFrom = null, DateTime? lastOccurrenceTo = null, string appVersion = null, string groupType = null, string groupStatus = null, string groupTextSearch = null, string orderby = null, string continuationToken = null)



Gets a list of crash groups and whether the list contains all available groups.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CrashGroupsListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var lastOccurrenceFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | Earliest date when the last time a crash occured in a crash group (optional) 
            var lastOccurrenceTo = 2013-10-20T19:20:30+01:00;  // DateTime? | Latest date when the last time a crash occured in a crash group (optional) 
            var appVersion = appVersion_example;  // string | version (optional) 
            var groupType = groupType_example;  // string |  (optional) 
            var groupStatus = groupStatus_example;  // string |  (optional) 
            var groupTextSearch = groupTextSearch_example;  // string | A freetext search that matches in crash, crash types, crash stack_traces and crash user (optional) 
            var orderby = orderby_example;  // string | the OData-like $orderby argument (optional)  (default to last_occurrence desc)
            var continuationToken = continuationToken_example;  // string | Cassandra request continuation token. The token is used for pagination. (optional) 

            try
            {
                InlineResponse20071 result = apiInstance.CrashGroupsList(ownerName, appName, lastOccurrenceFrom, lastOccurrenceTo, appVersion, groupType, groupStatus, groupTextSearch, orderby, continuationToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.CrashGroupsList: " + e.Message );
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
 **lastOccurrenceFrom** | **DateTime?**| Earliest date when the last time a crash occured in a crash group | [optional] 
 **lastOccurrenceTo** | **DateTime?**| Latest date when the last time a crash occured in a crash group | [optional] 
 **appVersion** | **string**| version | [optional] 
 **groupType** | **string**|  | [optional] 
 **groupStatus** | **string**|  | [optional] 
 **groupTextSearch** | **string**| A freetext search that matches in crash, crash types, crash stack_traces and crash user | [optional] 
 **orderby** | **string**| the OData-like $orderby argument | [optional] [default to last_occurrence desc]
 **continuationToken** | **string**| Cassandra request continuation token. The token is used for pagination. | [optional] 

### Return type

[**InlineResponse20071**](InlineResponse20071.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="crashgroupsupdate"></a>
# **CrashGroupsUpdate**
> InlineResponse20070 CrashGroupsUpdate (CrashGroupsCrashGroupIdBody body, string crashGroupId, string ownerName, string appName)



Updates a group.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CrashGroupsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var body = new CrashGroupsCrashGroupIdBody(); // CrashGroupsCrashGroupIdBody | Group change object. All fields are optional and only provided fields will get updated.
            var crashGroupId = crashGroupId_example;  // string | id of a specific group
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20070 result = apiInstance.CrashGroupsUpdate(body, crashGroupId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.CrashGroupsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CrashGroupsCrashGroupIdBody**](CrashGroupsCrashGroupIdBody.md)| Group change object. All fields are optional and only provided fields will get updated. | 
 **crashGroupId** | **string**| id of a specific group | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20070**](InlineResponse20070.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="crashesdelete"></a>
# **CrashesDelete**
> InlineResponse20069 CrashesDelete (string crashGroupId, string crashId, string ownerName, string appName, bool? retentionDelete = null)



Delete a specific crash and related attachments and blobs for an app.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CrashesDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var crashGroupId = crashGroupId_example;  // string | id of a specific group
            var crashId = crashId_example;  // string | id of a specific crash
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var retentionDelete = true;  // bool? | true in that case if the method should skip update counts (optional)  (default to false)

            try
            {
                InlineResponse20069 result = apiInstance.CrashesDelete(crashGroupId, crashId, ownerName, appName, retentionDelete);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.CrashesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **crashGroupId** | **string**| id of a specific group | 
 **crashId** | **string**| id of a specific crash | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **retentionDelete** | **bool?**| true in that case if the method should skip update counts | [optional] [default to false]

### Return type

[**InlineResponse20069**](InlineResponse20069.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="crashesget"></a>
# **CrashesGet**
> Crash CrashesGet (string crashGroupId, string crashId, string ownerName, string appName, bool? includeReport = null, bool? includeLog = null, bool? includeDetails = null, bool? includeStacktrace = null, bool? groupingOnly = null)



Gets a specific crash for an app.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CrashesGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var crashGroupId = crashGroupId_example;  // string | id of a specific group
            var crashId = crashId_example;  // string | id of a specific crash
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var includeReport = true;  // bool? | true if the crash should include the raw crash report. Default is false (optional)  (default to false)
            var includeLog = true;  // bool? | true if the crash should include the custom log report. Default is false (optional)  (default to false)
            var includeDetails = true;  // bool? | true if the crash should include in depth crash details (optional)  (default to false)
            var includeStacktrace = true;  // bool? | true if the crash should include the stacktrace information (optional)  (default to false)
            var groupingOnly = true;  // bool? | true if the stacktrace should be only the relevant thread / exception. Default is false (optional)  (default to false)

            try
            {
                Crash result = apiInstance.CrashesGet(crashGroupId, crashId, ownerName, appName, includeReport, includeLog, includeDetails, includeStacktrace, groupingOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.CrashesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **crashGroupId** | **string**| id of a specific group | 
 **crashId** | **string**| id of a specific crash | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **includeReport** | **bool?**| true if the crash should include the raw crash report. Default is false | [optional] [default to false]
 **includeLog** | **bool?**| true if the crash should include the custom log report. Default is false | [optional] [default to false]
 **includeDetails** | **bool?**| true if the crash should include in depth crash details | [optional] [default to false]
 **includeStacktrace** | **bool?**| true if the crash should include the stacktrace information | [optional] [default to false]
 **groupingOnly** | **bool?**| true if the stacktrace should be only the relevant thread / exception. Default is false | [optional] [default to false]

### Return type

[**Crash**](Crash.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="crashesgetappcrashesinfo"></a>
# **CrashesGetAppCrashesInfo**
> InlineResponse20064 CrashesGetAppCrashesInfo (string ownerName, string appName)



Gets whether the application has any crashes.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CrashesGetAppCrashesInfoExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20064 result = apiInstance.CrashesGetAppCrashesInfo(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.CrashesGetAppCrashesInfo: " + e.Message );
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

[**InlineResponse20064**](InlineResponse20064.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="crashesgetappversions"></a>
# **CrashesGetAppVersions**
> List<InlineResponse20018> CrashesGetAppVersions (string ownerName, string appName)



Gets a list of application versions.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CrashesGetAppVersionsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse20018&gt; result = apiInstance.CrashesGetAppVersions(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.CrashesGetAppVersions: " + e.Message );
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

[**List<InlineResponse20018>**](InlineResponse20018.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="crashesgetcrashattachmentlocation"></a>
# **CrashesGetCrashAttachmentLocation**
> InlineResponse20066 CrashesGetCrashAttachmentLocation (string crashId, string attachmentId, string ownerName, string appName)



Gets the URI location to download crash attachment.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CrashesGetCrashAttachmentLocationExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var crashId = crashId_example;  // string | id of a specific crash
            var attachmentId = attachmentId_example;  // string | attachment id
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20066 result = apiInstance.CrashesGetCrashAttachmentLocation(crashId, attachmentId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.CrashesGetCrashAttachmentLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **crashId** | **string**| id of a specific crash | 
 **attachmentId** | **string**| attachment id | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20066**](InlineResponse20066.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="crashesgetcrashtextattachmentcontent"></a>
# **CrashesGetCrashTextAttachmentContent**
> string CrashesGetCrashTextAttachmentContent (string crashId, string attachmentId, string ownerName, string appName)



Gets content of the text attachment.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CrashesGetCrashTextAttachmentContentExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var crashId = crashId_example;  // string | id of a specific crash
            var attachmentId = attachmentId_example;  // string | attachment id
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                string result = apiInstance.CrashesGetCrashTextAttachmentContent(crashId, attachmentId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.CrashesGetCrashTextAttachmentContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **crashId** | **string**| id of a specific crash | 
 **attachmentId** | **string**| attachment id | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

**string**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="crashesgetnativecrash"></a>
# **CrashesGetNativeCrash**
> string CrashesGetNativeCrash (string crashGroupId, string crashId, string ownerName, string appName)



Gets the native log of a specific crash.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CrashesGetNativeCrashExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var crashGroupId = crashGroupId_example;  // string | id of a specific group
            var crashId = crashId_example;  // string | id of a specific crash
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                string result = apiInstance.CrashesGetNativeCrash(crashGroupId, crashId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.CrashesGetNativeCrash: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **crashGroupId** | **string**| id of a specific group | 
 **crashId** | **string**| id of a specific crash | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

**string**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="crashesgetnativecrashdownload"></a>
# **CrashesGetNativeCrashDownload**
> string CrashesGetNativeCrashDownload (string crashGroupId, string crashId, string ownerName, string appName)



Gets the native log of a specific crash as a text attachment.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CrashesGetNativeCrashDownloadExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var crashGroupId = crashGroupId_example;  // string | id of a specific group
            var crashId = crashId_example;  // string | id of a specific crash
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                string result = apiInstance.CrashesGetNativeCrashDownload(crashGroupId, crashId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.CrashesGetNativeCrashDownload: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **crashGroupId** | **string**| id of a specific group | 
 **crashId** | **string**| id of a specific crash | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

**string**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="crashesgetrawcrashlocation"></a>
# **CrashesGetRawCrashLocation**
> InlineResponse20068 CrashesGetRawCrashLocation (string crashGroupId, string crashId, string ownerName, string appName)



Gets the URI location to download json of a specific crash.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CrashesGetRawCrashLocationExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var crashGroupId = crashGroupId_example;  // string | id of a specific group
            var crashId = crashId_example;  // string | id of a specific crash
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20068 result = apiInstance.CrashesGetRawCrashLocation(crashGroupId, crashId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.CrashesGetRawCrashLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **crashGroupId** | **string**| id of a specific group | 
 **crashId** | **string**| id of a specific crash | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20068**](InlineResponse20068.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="crashesgetstacktrace"></a>
# **CrashesGetStacktrace**
> Stacktrace CrashesGetStacktrace (string crashGroupId, string crashId, string ownerName, string appName, bool? groupingOnly = null)



Gets a stacktrace for a specific crash.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CrashesGetStacktraceExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var crashGroupId = crashGroupId_example;  // string | id of a specific group
            var crashId = crashId_example;  // string | id of a specific crash
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var groupingOnly = true;  // bool? | true if the stacktrace should be only the relevant thread / exception. Default is false (optional)  (default to false)

            try
            {
                Stacktrace result = apiInstance.CrashesGetStacktrace(crashGroupId, crashId, ownerName, appName, groupingOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.CrashesGetStacktrace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **crashGroupId** | **string**| id of a specific group | 
 **crashId** | **string**| id of a specific crash | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **groupingOnly** | **bool?**| true if the stacktrace should be only the relevant thread / exception. Default is false | [optional] [default to false]

### Return type

[**Stacktrace**](Stacktrace.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="crasheslist"></a>
# **CrashesList**
> List<Crash> CrashesList (string crashGroupId, string ownerName, string appName, bool? includeReport = null, bool? includeLog = null, DateTime? dateFrom = null, DateTime? dateTo = null, string appVersion = null, string errorType = null)



Gets all crashes of a group.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CrashesListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var crashGroupId = crashGroupId_example;  // string | id of a specific group
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var includeReport = true;  // bool? | true if the crash should include the raw crash report. Default is false (optional)  (default to false)
            var includeLog = true;  // bool? | true if the crash should include the custom log report. Default is false (optional)  (default to false)
            var dateFrom = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var dateTo = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var appVersion = appVersion_example;  // string | version (optional) 
            var errorType = errorType_example;  // string |  (optional) 

            try
            {
                List&lt;Crash&gt; result = apiInstance.CrashesList(crashGroupId, ownerName, appName, includeReport, includeLog, dateFrom, dateTo, appVersion, errorType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.CrashesList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **crashGroupId** | **string**| id of a specific group | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **includeReport** | **bool?**| true if the crash should include the raw crash report. Default is false | [optional] [default to false]
 **includeLog** | **bool?**| true if the crash should include the custom log report. Default is false | [optional] [default to false]
 **dateFrom** | **DateTime?**|  | [optional] 
 **dateTo** | **DateTime?**|  | [optional] 
 **appVersion** | **string**| version | [optional] 
 **errorType** | **string**|  | [optional] 

### Return type

[**List<Crash>**](Crash.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="crasheslistattachments"></a>
# **CrashesListAttachments**
> List<InlineResponse20067> CrashesListAttachments (string crashId, string ownerName, string appName)



Gets all attachments for a specific crash.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CrashesListAttachmentsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var crashId = crashId_example;  // string | id of a specific crash
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse20067&gt; result = apiInstance.CrashesListAttachments(crashId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.CrashesListAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **crashId** | **string**| id of a specific crash | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**List<InlineResponse20067>**](InlineResponse20067.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="missingsymbolgroupsget"></a>
# **MissingSymbolGroupsGet**
> Object MissingSymbolGroupsGet (string symbolGroupId, string ownerName, string appName)

Gets missing symbol crash group by its id

Gets missing symbol crash group by its id

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class MissingSymbolGroupsGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var symbolGroupId = symbolGroupId_example;  // string | missing symbol crash group id
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                // Gets missing symbol crash group by its id
                Object result = apiInstance.MissingSymbolGroupsGet(symbolGroupId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.MissingSymbolGroupsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbolGroupId** | **string**| missing symbol crash group id | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="missingsymbolgroupsinfo"></a>
# **MissingSymbolGroupsInfo**
> Object MissingSymbolGroupsInfo (string ownerName, string appName)

Gets application level statistics for all missing symbol groups

Gets application level statistics for all missing symbol groups

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class MissingSymbolGroupsInfoExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                // Gets application level statistics for all missing symbol groups
                Object result = apiInstance.MissingSymbolGroupsInfo(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.MissingSymbolGroupsInfo: " + e.Message );
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

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="missingsymbolgroupslist"></a>
# **MissingSymbolGroupsList**
> Object MissingSymbolGroupsList (int? top, string ownerName, string appName, string filter = null)

Gets top N (ordered by crash count) of crash groups by missing symbol

Gets top N (ordered by crash count) of crash groups by missing symbol

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class MissingSymbolGroupsListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var top = 56;  // int? | top N elements
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var filter = filter_example;  // string | query filter (optional) 

            try
            {
                // Gets top N (ordered by crash count) of crash groups by missing symbol
                Object result = apiInstance.MissingSymbolGroupsList(top, ownerName, appName, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.MissingSymbolGroupsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **top** | **int?**| top N elements | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **filter** | **string**| query filter | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="symboluploadscomplete"></a>
# **SymbolUploadsComplete**
> Object SymbolUploadsComplete (SymbolUploadsSymbolUploadIdBody body, string symbolUploadId, string ownerName, string appName)



Commits or aborts the symbol upload process for a new set of symbols for the specified application

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class SymbolUploadsCompleteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var body = new SymbolUploadsSymbolUploadIdBody(); // SymbolUploadsSymbolUploadIdBody | The symbol information
            var symbolUploadId = symbolUploadId_example;  // string | The ID of the symbol upload
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.SymbolUploadsComplete(body, symbolUploadId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.SymbolUploadsComplete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SymbolUploadsSymbolUploadIdBody**](SymbolUploadsSymbolUploadIdBody.md)| The symbol information | 
 **symbolUploadId** | **string**| The ID of the symbol upload | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="symboluploadscreate"></a>
# **SymbolUploadsCreate**
> Object SymbolUploadsCreate (AppNameSymbolUploadsBody body, string ownerName, string appName)



Begins the symbol upload process for a new set of symbols for the specified application

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class SymbolUploadsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var body = new AppNameSymbolUploadsBody(); // AppNameSymbolUploadsBody | The symbol information
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.SymbolUploadsCreate(body, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.SymbolUploadsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AppNameSymbolUploadsBody**](AppNameSymbolUploadsBody.md)| The symbol information | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="symboluploadsdelete"></a>
# **SymbolUploadsDelete**
> Object SymbolUploadsDelete (string symbolUploadId, string ownerName, string appName)



Deletes a symbol upload by id for the specified application

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class SymbolUploadsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var symbolUploadId = symbolUploadId_example;  // string | The ID of the symbol upload
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.SymbolUploadsDelete(symbolUploadId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.SymbolUploadsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbolUploadId** | **string**| The ID of the symbol upload | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="symboluploadsget"></a>
# **SymbolUploadsGet**
> Object SymbolUploadsGet (string symbolUploadId, string ownerName, string appName)



Gets a symbol upload by id for the specified application

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class SymbolUploadsGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var symbolUploadId = symbolUploadId_example;  // string | The ID of the symbol upload
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.SymbolUploadsGet(symbolUploadId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.SymbolUploadsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbolUploadId** | **string**| The ID of the symbol upload | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="symboluploadsgetlocation"></a>
# **SymbolUploadsGetLocation**
> InlineResponse20029 SymbolUploadsGetLocation (string symbolUploadId, string ownerName, string appName)



Gets the URL to download the symbol upload

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class SymbolUploadsGetLocationExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var symbolUploadId = symbolUploadId_example;  // string | The ID of the symbol upload
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20029 result = apiInstance.SymbolUploadsGetLocation(symbolUploadId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.SymbolUploadsGetLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbolUploadId** | **string**| The ID of the symbol upload | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20029**](InlineResponse20029.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="symboluploadslist"></a>
# **SymbolUploadsList**
> List<InlineResponse20030> SymbolUploadsList (string ownerName, string appName, long? top = null, string status = null, string symbolType = null)



Gets a list of all uploads for the specified application

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class SymbolUploadsListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var top = 789;  // long? | The maximum number of results to return. (optional)  (default to 30)
            var status = status_example;  // string | Filter results by the current status of a symbol upload: * all: all states in the symbol upload process. Includes created, aborted, committed, processing, indexed and failed states * uploaded: all states after package is uploaded. Includes committed, processing, indexed and failed states * processed: symbol upload processing is completed. Includes indexed and failed states.  (optional) 
            var symbolType = symbolType_example;  // string | The type of symbols (optional) 

            try
            {
                List&lt;InlineResponse20030&gt; result = apiInstance.SymbolUploadsList(ownerName, appName, top, status, symbolType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.SymbolUploadsList: " + e.Message );
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
 **top** | **long?**| The maximum number of results to return. | [optional] [default to 30]
 **status** | **string**| Filter results by the current status of a symbol upload: * all: all states in the symbol upload process. Includes created, aborted, committed, processing, indexed and failed states * uploaded: all states after package is uploaded. Includes committed, processing, indexed and failed states * processed: symbol upload processing is completed. Includes indexed and failed states.  | [optional] 
 **symbolType** | **string**| The type of symbols | [optional] 

### Return type

[**List<InlineResponse20030>**](InlineResponse20030.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="symbolsget"></a>
# **SymbolsGet**
> Object SymbolsGet (string symbolId, string ownerName, string appName)



Returns a particular symbol by id (uuid) for the provided application

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class SymbolsGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var symbolId = symbolId_example;  // string | The ID of the symbol (uuid of the symbol)
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.SymbolsGet(symbolId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.SymbolsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbolId** | **string**| The ID of the symbol (uuid of the symbol) | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="symbolsgetlocation"></a>
# **SymbolsGetLocation**
> InlineResponse20027 SymbolsGetLocation (string symbolId, string ownerName, string appName)



Gets the URL to download the symbol

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class SymbolsGetLocationExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var symbolId = symbolId_example;  // string | The ID of the symbol (uuid of the symbol)
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20027 result = apiInstance.SymbolsGetLocation(symbolId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.SymbolsGetLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbolId** | **string**| The ID of the symbol (uuid of the symbol) | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20027**](InlineResponse20027.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="symbolsgetstatus"></a>
# **SymbolsGetStatus**
> Object SymbolsGetStatus (string symbolId, string ownerName, string appName)



Returns a particular symbol by id (uuid) for the provided application

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class SymbolsGetStatusExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var symbolId = symbolId_example;  // string | The ID of the symbol (uuid of the symbol)
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.SymbolsGetStatus(symbolId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.SymbolsGetStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbolId** | **string**| The ID of the symbol (uuid of the symbol) | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="symbolsignore"></a>
# **SymbolsIgnore**
> Object SymbolsIgnore (string symbolId, string ownerName, string appName)



Marks a symbol by id (uuid) as ignored

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class SymbolsIgnoreExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var symbolId = symbolId_example;  // string | The ID of the symbol (uuid of the symbol)
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.SymbolsIgnore(symbolId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.SymbolsIgnore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbolId** | **string**| The ID of the symbol (uuid of the symbol) | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="symbolslist"></a>
# **SymbolsList**
> List<InlineResponse20028> SymbolsList (string ownerName, string appName)



Returns the list of all symbols for the provided application

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class SymbolsListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CrashApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse20028&gt; result = apiInstance.SymbolsList(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrashApi.SymbolsList: " + e.Message );
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

[**List<InlineResponse20028>**](InlineResponse20028.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
