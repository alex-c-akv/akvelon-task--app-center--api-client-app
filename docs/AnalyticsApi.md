# AppCenterApiClientLib.Api.AnalyticsApi

All URIs are relative to *https://api.appcenter.ms/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnalyticsAudienceNameExists**](AnalyticsApi.md#analyticsaudiencenameexists) | **HEAD** /v0.1/apps/{owner_name}/{app_name}/analytics/audiences/{audience_name} | 
[**AnalyticsCrashCounts**](AnalyticsApi.md#analyticscrashcounts) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/crash_counts | Available for UWP apps only.
[**AnalyticsCrashFreeDevicePercentages**](AnalyticsApi.md#analyticscrashfreedevicepercentages) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/crashfree_device_percentages | 
[**AnalyticsCrashGroupCounts**](AnalyticsApi.md#analyticscrashgroupcounts) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/crash_groups/{crash_group_id}/crash_counts | Available for UWP apps only.
[**AnalyticsCrashGroupModelCounts**](AnalyticsApi.md#analyticscrashgroupmodelcounts) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/crash_groups/{crash_group_id}/models | Available for UWP apps only.
[**AnalyticsCrashGroupOperatingSystemCounts**](AnalyticsApi.md#analyticscrashgroupoperatingsystemcounts) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/crash_groups/{crash_group_id}/operating_systems | Available for UWP apps only.
[**AnalyticsCrashGroupTotals**](AnalyticsApi.md#analyticscrashgrouptotals) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/crash_groups/{crash_group_id}/overall | Available for UWP apps only.
[**AnalyticsCrashGroupsTotals**](AnalyticsApi.md#analyticscrashgroupstotals) | **POST** /v0.1/apps/{owner_name}/{app_name}/analytics/crash_groups | 
[**AnalyticsCreateOrUpdateAudience**](AnalyticsApi.md#analyticscreateorupdateaudience) | **PUT** /v0.1/apps/{owner_name}/{app_name}/analytics/audiences/{audience_name} | 
[**AnalyticsDeleteAudience**](AnalyticsApi.md#analyticsdeleteaudience) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/analytics/audiences/{audience_name} | 
[**AnalyticsDeviceCounts**](AnalyticsApi.md#analyticsdevicecounts) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/active_device_counts | 
[**AnalyticsDistributionReleaseCounts**](AnalyticsApi.md#analyticsdistributionreleasecounts) | **POST** /v0.1/apps/{owner_name}/{app_name}/analytics/distribution/release_counts | 
[**AnalyticsEventCount**](AnalyticsApi.md#analyticseventcount) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/events/{event_name}/event_count | 
[**AnalyticsEventDeviceCount**](AnalyticsApi.md#analyticseventdevicecount) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/events/{event_name}/device_count | 
[**AnalyticsEventPerDeviceCount**](AnalyticsApi.md#analyticseventperdevicecount) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/events/{event_name}/count_per_device | 
[**AnalyticsEventPerSessionCount**](AnalyticsApi.md#analyticseventpersessioncount) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/events/{event_name}/count_per_session | 
[**AnalyticsEventProperties**](AnalyticsApi.md#analyticseventproperties) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/events/{event_name}/properties | 
[**AnalyticsEventPropertyCounts**](AnalyticsApi.md#analyticseventpropertycounts) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/events/{event_name}/properties/{event_property_name}/counts | 
[**AnalyticsEvents**](AnalyticsApi.md#analyticsevents) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/events | 
[**AnalyticsEventsDelete**](AnalyticsApi.md#analyticseventsdelete) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/analytics/events/{event_name} | 
[**AnalyticsEventsDeleteLogs**](AnalyticsApi.md#analyticseventsdeletelogs) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/analytics/event_logs/{event_name} | 
[**AnalyticsGenericLogFlow**](AnalyticsApi.md#analyticsgenericlogflow) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/generic_log_flow | 
[**AnalyticsGetAudience**](AnalyticsApi.md#analyticsgetaudience) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/audiences/{audience_name} | 
[**AnalyticsLanguageCounts**](AnalyticsApi.md#analyticslanguagecounts) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/languages | 
[**AnalyticsListAudiences**](AnalyticsApi.md#analyticslistaudiences) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/audiences | 
[**AnalyticsListCustomProperties**](AnalyticsApi.md#analyticslistcustomproperties) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/audiences/metadata/custom_properties | 
[**AnalyticsListDeviceProperties**](AnalyticsApi.md#analyticslistdeviceproperties) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/audiences/metadata/device_properties | 
[**AnalyticsListDevicePropertyValues**](AnalyticsApi.md#analyticslistdevicepropertyvalues) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/audiences/metadata/device_properties/{property_name}/values | 
[**AnalyticsLogFlow**](AnalyticsApi.md#analyticslogflow) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/log_flow | 
[**AnalyticsModelCounts**](AnalyticsApi.md#analyticsmodelcounts) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/models | 
[**AnalyticsOperatingSystemCounts**](AnalyticsApi.md#analyticsoperatingsystemcounts) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/oses | 
[**AnalyticsPerDeviceCounts**](AnalyticsApi.md#analyticsperdevicecounts) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/sessions_per_device | 
[**AnalyticsPlaceCounts**](AnalyticsApi.md#analyticsplacecounts) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/places | 
[**AnalyticsSessionCounts**](AnalyticsApi.md#analyticssessioncounts) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/session_counts | 
[**AnalyticsSessionDurationsDistribution**](AnalyticsApi.md#analyticssessiondurationsdistribution) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/session_durations_distribution | 
[**AnalyticsTestAudience**](AnalyticsApi.md#analyticstestaudience) | **POST** /v0.1/apps/{owner_name}/{app_name}/analytics/audiences/definition/test | 
[**AnalyticsVersions**](AnalyticsApi.md#analyticsversions) | **GET** /v0.1/apps/{owner_name}/{app_name}/analytics/versions | 
[**AppBlockLogs**](AnalyticsApi.md#appblocklogs) | **PUT** /v0.1/apps/{owner_name}/{app_name}/devices/block_logs | 
[**CrashesListSessionLogs**](AnalyticsApi.md#crasheslistsessionlogs) | **GET** /v0.1/apps/{owner_name}/{app_name}/crashes/{crash_id}/session_logs | 
[**DevicesBlockLogs**](AnalyticsApi.md#devicesblocklogs) | **PUT** /v0.1/apps/{owner_name}/{app_name}/devices/block_logs/{install_id} | 

<a name="analyticsaudiencenameexists"></a>
# **AnalyticsAudienceNameExists**
> void AnalyticsAudienceNameExists (string audienceName, string ownerName, string appName)



Returns whether audience definition exists.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsAudienceNameExistsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var audienceName = audienceName_example;  // string | The name of the audience
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.AnalyticsAudienceNameExists(audienceName, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsAudienceNameExists: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **audienceName** | **string**| The name of the audience | 
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
<a name="analyticscrashcounts"></a>
# **AnalyticsCrashCounts**
> InlineResponse20095 AnalyticsCrashCounts (DateTime? start, string ownerName, string appName, DateTime? end = null, List<string> versions = null)

Available for UWP apps only.

Count of crashes by day in the time range based the selected versions. Available for UWP apps only.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsCrashCountsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format. (optional) 
            var versions = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Available for UWP apps only.
                InlineResponse20095 result = apiInstance.AnalyticsCrashCounts(start, ownerName, appName, end, versions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsCrashCounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format. | [optional] 
 **versions** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**InlineResponse20095**](InlineResponse20095.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticscrashfreedevicepercentages"></a>
# **AnalyticsCrashFreeDevicePercentages**
> InlineResponse20091 AnalyticsCrashFreeDevicePercentages (DateTime? start, string version, string ownerName, string appName, DateTime? end = null)



Percentage of crash-free device by day in the time range based on the selected versions. Api will return -1 if crash devices is greater than active devices.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsCrashFreeDevicePercentagesExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format.
            var version = version_example;  // string | 
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format. (optional) 

            try
            {
                InlineResponse20091 result = apiInstance.AnalyticsCrashFreeDevicePercentages(start, version, ownerName, appName, end);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsCrashFreeDevicePercentages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format. | 
 **version** | **string**|  | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format. | [optional] 

### Return type

[**InlineResponse20091**](InlineResponse20091.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticscrashgroupcounts"></a>
# **AnalyticsCrashGroupCounts**
> InlineResponse20095 AnalyticsCrashGroupCounts (string crashGroupId, string version, DateTime? start, string ownerName, string appName, DateTime? end = null)

Available for UWP apps only.

Count of crashes by day in the time range of the selected crash group with selected version. Available for UWP apps only.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsCrashGroupCountsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var crashGroupId = crashGroupId_example;  // string | The id of the crash group.
            var version = version_example;  // string | 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format. (optional) 

            try
            {
                // Available for UWP apps only.
                InlineResponse20095 result = apiInstance.AnalyticsCrashGroupCounts(crashGroupId, version, start, ownerName, appName, end);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsCrashGroupCounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **crashGroupId** | **string**| The id of the crash group. | 
 **version** | **string**|  | 
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format. | [optional] 

### Return type

[**InlineResponse20095**](InlineResponse20095.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticscrashgroupmodelcounts"></a>
# **AnalyticsCrashGroupModelCounts**
> InlineResponse20094 AnalyticsCrashGroupModelCounts (string crashGroupId, string version, string ownerName, string appName, long? top = null)

Available for UWP apps only.

Top models of the selected crash group with selected version. Available for UWP apps only.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsCrashGroupModelCountsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var crashGroupId = crashGroupId_example;  // string | The id of the crash group.
            var version = version_example;  // string | 
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var top = 789;  // long? | The maximum number of results to return. (0 will fetch all results) (optional)  (default to 30)

            try
            {
                // Available for UWP apps only.
                InlineResponse20094 result = apiInstance.AnalyticsCrashGroupModelCounts(crashGroupId, version, ownerName, appName, top);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsCrashGroupModelCounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **crashGroupId** | **string**| The id of the crash group. | 
 **version** | **string**|  | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **top** | **long?**| The maximum number of results to return. (0 will fetch all results) | [optional] [default to 30]

### Return type

[**InlineResponse20094**](InlineResponse20094.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticscrashgroupoperatingsystemcounts"></a>
# **AnalyticsCrashGroupOperatingSystemCounts**
> InlineResponse20093 AnalyticsCrashGroupOperatingSystemCounts (string crashGroupId, string version, string ownerName, string appName, long? top = null)

Available for UWP apps only.

Top OSes of the selected crash group with selected version. Available for UWP apps only.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsCrashGroupOperatingSystemCountsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var crashGroupId = crashGroupId_example;  // string | The id of the crash group.
            var version = version_example;  // string | 
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var top = 789;  // long? | The maximum number of results to return. (0 will fetch all results) (optional)  (default to 30)

            try
            {
                // Available for UWP apps only.
                InlineResponse20093 result = apiInstance.AnalyticsCrashGroupOperatingSystemCounts(crashGroupId, version, ownerName, appName, top);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsCrashGroupOperatingSystemCounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **crashGroupId** | **string**| The id of the crash group. | 
 **version** | **string**|  | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **top** | **long?**| The maximum number of results to return. (0 will fetch all results) | [optional] [default to 30]

### Return type

[**InlineResponse20093**](InlineResponse20093.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticscrashgrouptotals"></a>
# **AnalyticsCrashGroupTotals**
> InlineResponse20092 AnalyticsCrashGroupTotals (string crashGroupId, string version, string ownerName, string appName)

Available for UWP apps only.

Overall crashes and affected users count of the selected crash group with selected version. Available for UWP apps only.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsCrashGroupTotalsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var crashGroupId = crashGroupId_example;  // string | The id of the crash group.
            var version = version_example;  // string | 
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                // Available for UWP apps only.
                InlineResponse20092 result = apiInstance.AnalyticsCrashGroupTotals(crashGroupId, version, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsCrashGroupTotals: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **crashGroupId** | **string**| The id of the crash group. | 
 **version** | **string**|  | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20092**](InlineResponse20092.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticscrashgroupstotals"></a>
# **AnalyticsCrashGroupsTotals**
> List<InlineResponse20096> AnalyticsCrashGroupsTotals (AnalyticsCrashGroupsBody body, string ownerName, string appName)



Overall crashes and affected users count of the selected crash groups with selected versions.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsCrashGroupsTotalsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var body = new AnalyticsCrashGroupsBody(); // AnalyticsCrashGroupsBody | 
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse20096&gt; result = apiInstance.AnalyticsCrashGroupsTotals(body, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsCrashGroupsTotals: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AnalyticsCrashGroupsBody**](AnalyticsCrashGroupsBody.md)|  | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**List<InlineResponse20096>**](InlineResponse20096.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticscreateorupdateaudience"></a>
# **AnalyticsCreateOrUpdateAudience**
> Object AnalyticsCreateOrUpdateAudience (AudiencesAudienceNameBody body, string audienceName, string ownerName, string appName)



Creates or updates audience definition.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsCreateOrUpdateAudienceExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var body = new AudiencesAudienceNameBody(); // AudiencesAudienceNameBody | Audience definition
            var audienceName = audienceName_example;  // string | The name of the audience
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.AnalyticsCreateOrUpdateAudience(body, audienceName, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsCreateOrUpdateAudience: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AudiencesAudienceNameBody**](AudiencesAudienceNameBody.md)| Audience definition | 
 **audienceName** | **string**| The name of the audience | 
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
<a name="analyticsdeleteaudience"></a>
# **AnalyticsDeleteAudience**
> void AnalyticsDeleteAudience (string audienceName, string ownerName, string appName)



Deletes audience definition.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsDeleteAudienceExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var audienceName = audienceName_example;  // string | The name of the audience
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.AnalyticsDeleteAudience(audienceName, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsDeleteAudience: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **audienceName** | **string**| The name of the audience | 
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
<a name="analyticsdevicecounts"></a>
# **AnalyticsDeviceCounts**
> Object AnalyticsDeviceCounts (DateTime? start, string appBuild, string ownerName, string appName, DateTime? end = null, List<string> versions = null)



Count of active devices by interval in the time range.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsDeviceCountsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format.
            var appBuild = appBuild_example;  // string | 
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format. (optional) 
            var versions = new List<string>(); // List<string> |  (optional) 

            try
            {
                Object result = apiInstance.AnalyticsDeviceCounts(start, appBuild, ownerName, appName, end, versions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsDeviceCounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format. | 
 **appBuild** | **string**|  | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format. | [optional] 
 **versions** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticsdistributionreleasecounts"></a>
# **AnalyticsDistributionReleaseCounts**
> InlineResponse20090 AnalyticsDistributionReleaseCounts (DistributionReleaseCountsBody body, string ownerName, string appName)



Count of total downloads for the provided distribution releases.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsDistributionReleaseCountsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var body = new DistributionReleaseCountsBody(); // DistributionReleaseCountsBody | The releases to retrieve.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20090 result = apiInstance.AnalyticsDistributionReleaseCounts(body, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsDistributionReleaseCounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DistributionReleaseCountsBody**](DistributionReleaseCountsBody.md)| The releases to retrieve. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20090**](InlineResponse20090.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticseventcount"></a>
# **AnalyticsEventCount**
> InlineResponse20086 AnalyticsEventCount (string eventName, DateTime? start, string ownerName, string appName, DateTime? end = null, List<string> versions = null)



Count of events by interval in the time range.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsEventCountExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var eventName = eventName_example;  // string | The id of the event.
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format. (optional) 
            var versions = new List<string>(); // List<string> |  (optional) 

            try
            {
                InlineResponse20086 result = apiInstance.AnalyticsEventCount(eventName, start, ownerName, appName, end, versions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsEventCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventName** | **string**| The id of the event. | 
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format. | [optional] 
 **versions** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**InlineResponse20086**](InlineResponse20086.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticseventdevicecount"></a>
# **AnalyticsEventDeviceCount**
> InlineResponse20087 AnalyticsEventDeviceCount (string eventName, DateTime? start, string ownerName, string appName, DateTime? end = null, List<string> versions = null)



Count of devices for an event by interval in the time range.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsEventDeviceCountExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var eventName = eventName_example;  // string | The id of the event.
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format. (optional) 
            var versions = new List<string>(); // List<string> |  (optional) 

            try
            {
                InlineResponse20087 result = apiInstance.AnalyticsEventDeviceCount(eventName, start, ownerName, appName, end, versions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsEventDeviceCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventName** | **string**| The id of the event. | 
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format. | [optional] 
 **versions** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**InlineResponse20087**](InlineResponse20087.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticseventperdevicecount"></a>
# **AnalyticsEventPerDeviceCount**
> InlineResponse20089 AnalyticsEventPerDeviceCount (string eventName, DateTime? start, string ownerName, string appName, DateTime? end = null, List<string> versions = null)



Count of events per device by interval in the time range.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsEventPerDeviceCountExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var eventName = eventName_example;  // string | The id of the event.
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format. (optional) 
            var versions = new List<string>(); // List<string> |  (optional) 

            try
            {
                InlineResponse20089 result = apiInstance.AnalyticsEventPerDeviceCount(eventName, start, ownerName, appName, end, versions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsEventPerDeviceCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventName** | **string**| The id of the event. | 
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format. | [optional] 
 **versions** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**InlineResponse20089**](InlineResponse20089.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticseventpersessioncount"></a>
# **AnalyticsEventPerSessionCount**
> InlineResponse20088 AnalyticsEventPerSessionCount (string eventName, DateTime? start, string ownerName, string appName, DateTime? end = null, List<string> versions = null)



Count of events per session by interval in the time range.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsEventPerSessionCountExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var eventName = eventName_example;  // string | The id of the event.
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format. (optional) 
            var versions = new List<string>(); // List<string> |  (optional) 

            try
            {
                InlineResponse20088 result = apiInstance.AnalyticsEventPerSessionCount(eventName, start, ownerName, appName, end, versions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsEventPerSessionCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventName** | **string**| The id of the event. | 
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format. | [optional] 
 **versions** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**InlineResponse20088**](InlineResponse20088.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticseventproperties"></a>
# **AnalyticsEventProperties**
> InlineResponse20085 AnalyticsEventProperties (string eventName, string ownerName, string appName)



Event properties.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsEventPropertiesExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var eventName = eventName_example;  // string | The id of the event.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20085 result = apiInstance.AnalyticsEventProperties(eventName, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsEventProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventName** | **string**| The id of the event. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20085**](InlineResponse20085.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticseventpropertycounts"></a>
# **AnalyticsEventPropertyCounts**
> InlineResponse20084 AnalyticsEventPropertyCounts (string eventName, string eventPropertyName, DateTime? start, string ownerName, string appName, DateTime? end = null, List<string> versions = null, long? top = null)



Event properties value counts during the time range in descending order.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsEventPropertyCountsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var eventName = eventName_example;  // string | The id of the event.
            var eventPropertyName = eventPropertyName_example;  // string | The id of the event property.
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format. (optional) 
            var versions = new List<string>(); // List<string> |  (optional) 
            var top = 789;  // long? | The number of property values to return. Set to 0 in order to fetch all results available. (optional)  (default to 10)

            try
            {
                InlineResponse20084 result = apiInstance.AnalyticsEventPropertyCounts(eventName, eventPropertyName, start, ownerName, appName, end, versions, top);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsEventPropertyCounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventName** | **string**| The id of the event. | 
 **eventPropertyName** | **string**| The id of the event property. | 
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format. | [optional] 
 **versions** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **top** | **long?**| The number of property values to return. Set to 0 in order to fetch all results available. | [optional] [default to 10]

### Return type

[**InlineResponse20084**](InlineResponse20084.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticsevents"></a>
# **AnalyticsEvents**
> Object AnalyticsEvents (DateTime? start, string ownerName, string appName, DateTime? end = null, List<string> versions = null, List<string> eventName = null, long? top = null, long? skip = null, string inlinecount = null, string orderby = null)



Count of active events in the time range ordered by event.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsEventsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format. (optional) 
            var versions = new List<string>(); // List<string> |  (optional) 
            var eventName = new List<string>(); // List<string> | To select the specific events. (optional) 
            var top = 789;  // long? | The maximum number of results to return. (0 will fetch all results) (optional)  (default to 30)
            var skip = 789;  // long? | The offset (starting at 0) of the first result to return. This parameter along with limit is used to perform pagination. (optional)  (default to 0)
            var inlinecount = inlinecount_example;  // string | Controls whether or not to include a count of all the items across all pages. (optional)  (default to none)
            var orderby = orderby_example;  // string | controls the sorting order and sorting based on which column (optional)  (default to count desc)

            try
            {
                Object result = apiInstance.AnalyticsEvents(start, ownerName, appName, end, versions, eventName, top, skip, inlinecount, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format. | [optional] 
 **versions** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **eventName** | [**List&lt;string&gt;**](string.md)| To select the specific events. | [optional] 
 **top** | **long?**| The maximum number of results to return. (0 will fetch all results) | [optional] [default to 30]
 **skip** | **long?**| The offset (starting at 0) of the first result to return. This parameter along with limit is used to perform pagination. | [optional] [default to 0]
 **inlinecount** | **string**| Controls whether or not to include a count of all the items across all pages. | [optional] [default to none]
 **orderby** | **string**| controls the sorting order and sorting based on which column | [optional] [default to count desc]

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticseventsdelete"></a>
# **AnalyticsEventsDelete**
> void AnalyticsEventsDelete (string eventName, string ownerName, string appName)



Delete the set of Events with the specified event names.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsEventsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var eventName = eventName_example;  // string | The id of the event.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.AnalyticsEventsDelete(eventName, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsEventsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventName** | **string**| The id of the event. | 
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
<a name="analyticseventsdeletelogs"></a>
# **AnalyticsEventsDeleteLogs**
> void AnalyticsEventsDeleteLogs (string eventName, string ownerName, string appName)



Delete the set of Events with the specified event names.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsEventsDeleteLogsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var eventName = eventName_example;  // string | The id of the event.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.AnalyticsEventsDeleteLogs(eventName, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsEventsDeleteLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventName** | **string**| The id of the event. | 
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
<a name="analyticsgenericlogflow"></a>
# **AnalyticsGenericLogFlow**
> InlineResponse20083 AnalyticsGenericLogFlow (string ownerName, string appName, DateTime? start = null)



Logs received between the specified start time and the current time. The API will return a maximum of 100 logs per call.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsGenericLogFlowExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format. It must be within the current day in the UTC timezone. The default value is the start time of the current day in UTC timezone. (optional) 

            try
            {
                InlineResponse20083 result = apiInstance.AnalyticsGenericLogFlow(ownerName, appName, start);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsGenericLogFlow: " + e.Message );
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
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format. It must be within the current day in the UTC timezone. The default value is the start time of the current day in UTC timezone. | [optional] 

### Return type

[**InlineResponse20083**](InlineResponse20083.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticsgetaudience"></a>
# **AnalyticsGetAudience**
> Object AnalyticsGetAudience (string audienceName, string ownerName, string appName)



Gets audience definition.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsGetAudienceExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var audienceName = audienceName_example;  // string | The name of the audience
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.AnalyticsGetAudience(audienceName, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsGetAudience: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **audienceName** | **string**| The name of the audience | 
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
<a name="analyticslanguagecounts"></a>
# **AnalyticsLanguageCounts**
> InlineResponse20082 AnalyticsLanguageCounts (DateTime? start, string ownerName, string appName, DateTime? end = null, long? top = null, List<string> versions = null)



Languages in the time range.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsLanguageCountsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format. (optional) 
            var top = 789;  // long? | The maximum number of results to return. (0 will fetch all results) (optional)  (default to 30)
            var versions = new List<string>(); // List<string> |  (optional) 

            try
            {
                InlineResponse20082 result = apiInstance.AnalyticsLanguageCounts(start, ownerName, appName, end, top, versions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsLanguageCounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format. | [optional] 
 **top** | **long?**| The maximum number of results to return. (0 will fetch all results) | [optional] [default to 30]
 **versions** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**InlineResponse20082**](InlineResponse20082.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticslistaudiences"></a>
# **AnalyticsListAudiences**
> Object AnalyticsListAudiences (string ownerName, string appName, bool? includeDisabled = null)



Get list of audiences.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsListAudiencesExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var includeDisabled = true;  // bool? | Include disabled audience definitions (optional) 

            try
            {
                Object result = apiInstance.AnalyticsListAudiences(ownerName, appName, includeDisabled);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsListAudiences: " + e.Message );
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
 **includeDisabled** | **bool?**| Include disabled audience definitions | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticslistcustomproperties"></a>
# **AnalyticsListCustomProperties**
> Object AnalyticsListCustomProperties (string ownerName, string appName)



Get list of custom properties.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsListCustomPropertiesExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.AnalyticsListCustomProperties(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsListCustomProperties: " + e.Message );
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
<a name="analyticslistdeviceproperties"></a>
# **AnalyticsListDeviceProperties**
> Object AnalyticsListDeviceProperties (string ownerName, string appName)



Get list of device properties.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsListDevicePropertiesExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.AnalyticsListDeviceProperties(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsListDeviceProperties: " + e.Message );
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
<a name="analyticslistdevicepropertyvalues"></a>
# **AnalyticsListDevicePropertyValues**
> Object AnalyticsListDevicePropertyValues (string propertyName, string ownerName, string appName, string contains = null)



Get list of device property values.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsListDevicePropertyValuesExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var propertyName = propertyName_example;  // string | Device property
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var contains = contains_example;  // string | Contains string (optional) 

            try
            {
                Object result = apiInstance.AnalyticsListDevicePropertyValues(propertyName, ownerName, appName, contains);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsListDevicePropertyValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **propertyName** | **string**| Device property | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **contains** | **string**| Contains string | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticslogflow"></a>
# **AnalyticsLogFlow**
> InlineResponse20081 AnalyticsLogFlow (string ownerName, string appName, DateTime? start = null)



Logs received between the specified start time and the current time. The API will return a maximum of 100 logs per call.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsLogFlowExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format. It must be within the current day in the UTC timezone. The default value is the start time of the current day in UTC timezone. (optional) 

            try
            {
                InlineResponse20081 result = apiInstance.AnalyticsLogFlow(ownerName, appName, start);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsLogFlow: " + e.Message );
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
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format. It must be within the current day in the UTC timezone. The default value is the start time of the current day in UTC timezone. | [optional] 

### Return type

[**InlineResponse20081**](InlineResponse20081.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticsmodelcounts"></a>
# **AnalyticsModelCounts**
> InlineResponse20080 AnalyticsModelCounts (DateTime? start, string ownerName, string appName, DateTime? end = null, long? top = null, List<string> versions = null)



Models in the time range.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsModelCountsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format. (optional) 
            var top = 789;  // long? | The maximum number of results to return. (0 will fetch all results) (optional)  (default to 30)
            var versions = new List<string>(); // List<string> |  (optional) 

            try
            {
                InlineResponse20080 result = apiInstance.AnalyticsModelCounts(start, ownerName, appName, end, top, versions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsModelCounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format. | [optional] 
 **top** | **long?**| The maximum number of results to return. (0 will fetch all results) | [optional] [default to 30]
 **versions** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**InlineResponse20080**](InlineResponse20080.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticsoperatingsystemcounts"></a>
# **AnalyticsOperatingSystemCounts**
> InlineResponse20079 AnalyticsOperatingSystemCounts (DateTime? start, string ownerName, string appName, DateTime? end = null, long? top = null, List<string> versions = null)



OSes in the time range.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsOperatingSystemCountsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format. (optional) 
            var top = 789;  // long? | The maximum number of results to return. (0 will fetch all results) (optional)  (default to 30)
            var versions = new List<string>(); // List<string> |  (optional) 

            try
            {
                InlineResponse20079 result = apiInstance.AnalyticsOperatingSystemCounts(start, ownerName, appName, end, top, versions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsOperatingSystemCounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format. | [optional] 
 **top** | **long?**| The maximum number of results to return. (0 will fetch all results) | [optional] [default to 30]
 **versions** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**InlineResponse20079**](InlineResponse20079.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticsperdevicecounts"></a>
# **AnalyticsPerDeviceCounts**
> InlineResponse20076 AnalyticsPerDeviceCounts (DateTime? start, string interval, string ownerName, string appName, DateTime? end = null, List<string> versions = null)



Count of sessions per device in the time range.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsPerDeviceCountsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format.
            var interval = interval_example;  // string | Size of interval in ISO 8601 duration format. (PnYnMnDTnHnMnS|PnW|P<date>T<time>). The valid durations are 1 day (P1D), 1 week (P1W), and 30 days (P30D).
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format. (optional) 
            var versions = new List<string>(); // List<string> |  (optional) 

            try
            {
                InlineResponse20076 result = apiInstance.AnalyticsPerDeviceCounts(start, interval, ownerName, appName, end, versions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsPerDeviceCounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format. | 
 **interval** | **string**| Size of interval in ISO 8601 duration format. (PnYnMnDTnHnMnS|PnW|P&lt;date&gt;T&lt;time&gt;). The valid durations are 1 day (P1D), 1 week (P1W), and 30 days (P30D). | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format. | [optional] 
 **versions** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**InlineResponse20076**](InlineResponse20076.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticsplacecounts"></a>
# **AnalyticsPlaceCounts**
> Object AnalyticsPlaceCounts (DateTime? start, string ownerName, string appName, DateTime? end = null, long? top = null, List<string> versions = null)



Places in the time range.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsPlaceCountsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format. (optional) 
            var top = 789;  // long? | The maximum number of results to return. (0 will fetch all results) (optional)  (default to 30)
            var versions = new List<string>(); // List<string> |  (optional) 

            try
            {
                Object result = apiInstance.AnalyticsPlaceCounts(start, ownerName, appName, end, top, versions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsPlaceCounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format. | [optional] 
 **top** | **long?**| The maximum number of results to return. (0 will fetch all results) | [optional] [default to 30]
 **versions** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticssessioncounts"></a>
# **AnalyticsSessionCounts**
> List<InlineResponse20078> AnalyticsSessionCounts (DateTime? start, string interval, string ownerName, string appName, DateTime? end = null, List<string> versions = null)



Count of sessions in the time range.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsSessionCountsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format.
            var interval = interval_example;  // string | Size of interval in ISO 8601 duration format. (PnYnMnDTnHnMnS|PnW|P<date>T<time>). The valid durations are 1 day (P1D), 1 week (P1W), and 30 days (P30D).
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format. (optional) 
            var versions = new List<string>(); // List<string> |  (optional) 

            try
            {
                List&lt;InlineResponse20078&gt; result = apiInstance.AnalyticsSessionCounts(start, interval, ownerName, appName, end, versions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsSessionCounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format. | 
 **interval** | **string**| Size of interval in ISO 8601 duration format. (PnYnMnDTnHnMnS|PnW|P&lt;date&gt;T&lt;time&gt;). The valid durations are 1 day (P1D), 1 week (P1W), and 30 days (P30D). | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format. | [optional] 
 **versions** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**List<InlineResponse20078>**](InlineResponse20078.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticssessiondurationsdistribution"></a>
# **AnalyticsSessionDurationsDistribution**
> InlineResponse20077 AnalyticsSessionDurationsDistribution (DateTime? start, string ownerName, string appName, DateTime? end = null, List<string> versions = null)



Gets session duration.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsSessionDurationsDistributionExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format. (optional) 
            var versions = new List<string>(); // List<string> |  (optional) 

            try
            {
                InlineResponse20077 result = apiInstance.AnalyticsSessionDurationsDistribution(start, ownerName, appName, end, versions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsSessionDurationsDistribution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format. | [optional] 
 **versions** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**InlineResponse20077**](InlineResponse20077.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analyticstestaudience"></a>
# **AnalyticsTestAudience**
> Object AnalyticsTestAudience (DefinitionTestBody body, string ownerName, string appName)



Tests audience definition.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsTestAudienceExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var body = new DefinitionTestBody(); // DefinitionTestBody | Audience definition
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.AnalyticsTestAudience(body, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsTestAudience: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DefinitionTestBody**](DefinitionTestBody.md)| Audience definition | 
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
<a name="analyticsversions"></a>
# **AnalyticsVersions**
> Object AnalyticsVersions (DateTime? start, string ownerName, string appName, DateTime? end = null, long? top = null, List<string> versions = null)



Count of active versions in the time range ordered by version.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AnalyticsVersionsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time in data in ISO 8601 date time format.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Last date time in data in ISO 8601 date time format. (optional) 
            var top = 789;  // long? | The maximum number of results to return. (0 will fetch all results) (optional)  (default to 30)
            var versions = new List<string>(); // List<string> |  (optional) 

            try
            {
                Object result = apiInstance.AnalyticsVersions(start, ownerName, appName, end, top, versions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime?**| Start date time in data in ISO 8601 date time format. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **end** | **DateTime?**| Last date time in data in ISO 8601 date time format. | [optional] 
 **top** | **long?**| The maximum number of results to return. (0 will fetch all results) | [optional] [default to 30]
 **versions** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appblocklogs"></a>
# **AppBlockLogs**
> string AppBlockLogs (string ownerName, string appName)



**Warning, this operation is not reversible.**   A successful call to this API will permanently stop ingesting any logs received via SDK by app_id, and cannot be restored. We advise caution when using this API, it is designed to permanently disable an app_id. 

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppBlockLogsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                string result = apiInstance.AppBlockLogs(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AppBlockLogs: " + e.Message );
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

**string**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="crasheslistsessionlogs"></a>
# **CrashesListSessionLogs**
> InlineResponse20065 CrashesListSessionLogs (string crashId, string ownerName, string appName, DateTime? date = null)



Get session logs by crash ID

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CrashesListSessionLogsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var crashId = crashId_example;  // string | The id of the a crash
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | Date of data requested (optional) 

            try
            {
                InlineResponse20065 result = apiInstance.CrashesListSessionLogs(crashId, ownerName, appName, date);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.CrashesListSessionLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **crashId** | **string**| The id of the a crash | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **date** | **DateTime?**| Date of data requested | [optional] 

### Return type

[**InlineResponse20065**](InlineResponse20065.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="devicesblocklogs"></a>
# **DevicesBlockLogs**
> string DevicesBlockLogs (string installId, string ownerName, string appName)



**Warning, this operation is not reversible.**   A successful call to this API will permanently stop ingesting any logs received via SDK for the given installation ID, and cannot be restored. We advise caution when using this API, it is designed to permanently disable collection from a specific installation of the app on a device, usually following the request from a user. 

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DevicesBlockLogsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AnalyticsApi();
            var installId = installId_example;  // string | The id of the device
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                string result = apiInstance.DevicesBlockLogs(installId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.DevicesBlockLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **installId** | **string**| The id of the device | 
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
