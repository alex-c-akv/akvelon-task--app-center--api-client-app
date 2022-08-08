# AppCenterApiClientLib.Api.AlertingApi

All URIs are relative to *https://api.appcenter.ms/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BugTrackerGetRepoIssueFromCrash**](AlertingApi.md#bugtrackergetrepoissuefromcrash) | **GET** /v0.1/apps/{owner_name}/{app_name}/bugtracker/crashGroup/{crash_group_id} | 
[**BugtrackerGetSettings**](AlertingApi.md#bugtrackergetsettings) | **GET** /v0.1/apps/{owner_name}/{app_name}/bugtracker | 
[**NotificationsGetAppEmailSettings**](AlertingApi.md#notificationsgetappemailsettings) | **GET** /v0.1/apps/{owner_name}/{app_name}/notifications/emailSettings | 
[**NotificationsGetUserEmailSettings**](AlertingApi.md#notificationsgetuseremailsettings) | **GET** /v0.1/user/notifications/emailSettings | 
[**WebhooksList**](AlertingApi.md#webhookslist) | **GET** /v0.1/apps/{owner_name}/{app_name}/webhooks | 

<a name="bugtrackergetrepoissuefromcrash"></a>
# **BugTrackerGetRepoIssueFromCrash**
> Object BugTrackerGetRepoIssueFromCrash (string crashGroupId, string ownerName, string appName)



Get project issue related to a crash group

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BugTrackerGetRepoIssueFromCrashExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AlertingApi();
            var crashGroupId = crashGroupId_example;  // string | CrashGroup Id
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.BugTrackerGetRepoIssueFromCrash(crashGroupId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.BugTrackerGetRepoIssueFromCrash: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **crashGroupId** | **string**| CrashGroup Id | 
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
<a name="bugtrackergetsettings"></a>
# **BugtrackerGetSettings**
> Object BugtrackerGetSettings (string ownerName, string appName)



Get bug tracker settings for a particular app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BugtrackerGetSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AlertingApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.BugtrackerGetSettings(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.BugtrackerGetSettings: " + e.Message );
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
<a name="notificationsgetappemailsettings"></a>
# **NotificationsGetAppEmailSettings**
> InlineResponse20035 NotificationsGetAppEmailSettings (string ownerName, string appName)



Get Email notification settings of user for a particular app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class NotificationsGetAppEmailSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AlertingApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20035 result = apiInstance.NotificationsGetAppEmailSettings(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.NotificationsGetAppEmailSettings: " + e.Message );
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

[**InlineResponse20035**](InlineResponse20035.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="notificationsgetuseremailsettings"></a>
# **NotificationsGetUserEmailSettings**
> InlineResponse200 NotificationsGetUserEmailSettings ()



Get Default email notification settings for the user

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class NotificationsGetUserEmailSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AlertingApi();

            try
            {
                InlineResponse200 result = apiInstance.NotificationsGetUserEmailSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.NotificationsGetUserEmailSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="webhookslist"></a>
# **WebhooksList**
> Object WebhooksList (string ownerName, string appName)



Get web hooks configured for a particular app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class WebhooksListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AlertingApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.WebhooksList(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.WebhooksList: " + e.Message );
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
