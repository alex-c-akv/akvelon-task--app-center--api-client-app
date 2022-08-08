# AppCenterApiClientLib.Api.TestApi

All URIs are relative to *https://api.appcenter.ms/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TestArchiveTestRun**](TestApi.md#testarchivetestrun) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/test_runs/{test_run_id} | 
[**TestCreateDeviceSelection**](TestApi.md#testcreatedeviceselection) | **POST** /v0.1/apps/{owner_name}/{app_name}/device_selection | 
[**TestCreateDeviceSetOfOwner**](TestApi.md#testcreatedevicesetofowner) | **POST** /v0.1/apps/{owner_name}/{app_name}/owner/device_sets | 
[**TestCreateDeviceSetOfUser**](TestApi.md#testcreatedevicesetofuser) | **POST** /v0.1/apps/{owner_name}/{app_name}/user/device_sets | 
[**TestCreateSubscription**](TestApi.md#testcreatesubscription) | **POST** /v0.1/apps/{owner_name}/{app_name}/subscriptions | 
[**TestCreateTestRun**](TestApi.md#testcreatetestrun) | **POST** /v0.1/apps/{owner_name}/{app_name}/test_runs | 
[**TestCreateTestSeries**](TestApi.md#testcreatetestseries) | **POST** /v0.1/apps/{owner_name}/{app_name}/test_series | 
[**TestDeleteDeviceSetOfOwner**](TestApi.md#testdeletedevicesetofowner) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/owner/device_sets/{id} | 
[**TestDeleteDeviceSetOfUser**](TestApi.md#testdeletedevicesetofuser) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/user/device_sets/{id} | 
[**TestDeleteTestSeries**](TestApi.md#testdeletetestseries) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/test_series/{test_series_slug} | 
[**TestGdprExportAccount**](TestApi.md#testgdprexportaccount) | **GET** /v0.1/account/test/export/accounts | 
[**TestGdprExportAccounts**](TestApi.md#testgdprexportaccounts) | **GET** /v0.1/account/test/export | 
[**TestGdprExportApp**](TestApi.md#testgdprexportapp) | **GET** /v0.1/apps/{owner_name}/{app_name}/test/export/apps | 
[**TestGdprExportApps**](TestApi.md#testgdprexportapps) | **GET** /v0.1/apps/{owner_name}/{app_name}/test/export | 
[**TestGdprExportFeatureFlag**](TestApi.md#testgdprexportfeatureflag) | **GET** /v0.1/account/test/export/featureFlags | 
[**TestGdprExportFileSetFile**](TestApi.md#testgdprexportfilesetfile) | **GET** /v0.1/apps/{owner_name}/{app_name}/test/export/fileSetFiles | 
[**TestGdprExportHashFile**](TestApi.md#testgdprexporthashfile) | **GET** /v0.1/apps/{owner_name}/{app_name}/test/export/hashFiles | 
[**TestGdprExportPipelineTest**](TestApi.md#testgdprexportpipelinetest) | **GET** /v0.1/apps/{owner_name}/{app_name}/test/export/pipelineTests | 
[**TestGdprExportTestRun**](TestApi.md#testgdprexporttestrun) | **GET** /v0.1/apps/{owner_name}/{app_name}/test/export/testRuns | 
[**TestGetAllTestRunsForSeries**](TestApi.md#testgetalltestrunsforseries) | **GET** /v0.1/apps/{owner_name}/{app_name}/test_series/{test_series_slug}/test_runs | 
[**TestGetAllTestSeries**](TestApi.md#testgetalltestseries) | **GET** /v0.1/apps/{owner_name}/{app_name}/test_series | 
[**TestGetDeviceConfigurations**](TestApi.md#testgetdeviceconfigurations) | **GET** /v0.1/apps/{owner_name}/{app_name}/device_configurations | 
[**TestGetDeviceSetOfOwner**](TestApi.md#testgetdevicesetofowner) | **GET** /v0.1/apps/{owner_name}/{app_name}/owner/device_sets/{id} | 
[**TestGetDeviceSetOfUser**](TestApi.md#testgetdevicesetofuser) | **GET** /v0.1/apps/{owner_name}/{app_name}/user/device_sets/{id} | 
[**TestGetSubscriptions**](TestApi.md#testgetsubscriptions) | **GET** /v0.1/apps/{owner_name}/{app_name}/subscriptions | 
[**TestGetTestReport**](TestApi.md#testgettestreport) | **GET** /v0.1/apps/{owner_name}/{app_name}/test_runs/{test_run_id}/report | 
[**TestGetTestRun**](TestApi.md#testgettestrun) | **GET** /v0.1/apps/{owner_name}/{app_name}/test_runs/{test_run_id} | 
[**TestGetTestRunState**](TestApi.md#testgettestrunstate) | **GET** /v0.1/apps/{owner_name}/{app_name}/test_runs/{test_run_id}/state | 
[**TestGetTestRuns**](TestApi.md#testgettestruns) | **GET** /v0.1/apps/{owner_name}/{app_name}/test_runs | 
[**TestListDeviceSetsOfOwner**](TestApi.md#testlistdevicesetsofowner) | **GET** /v0.1/apps/{owner_name}/{app_name}/owner/device_sets | 
[**TestListDeviceSetsOfUser**](TestApi.md#testlistdevicesetsofuser) | **GET** /v0.1/apps/{owner_name}/{app_name}/user/device_sets | 
[**TestPatchTestSeries**](TestApi.md#testpatchtestseries) | **PATCH** /v0.1/apps/{owner_name}/{app_name}/test_series/{test_series_slug} | 
[**TestStartTestRun**](TestApi.md#teststarttestrun) | **POST** /v0.1/apps/{owner_name}/{app_name}/test_runs/{test_run_id}/start | 
[**TestStartUploadingFile**](TestApi.md#teststartuploadingfile) | **POST** /v0.1/apps/{owner_name}/{app_name}/test_runs/{test_run_id}/files | 
[**TestStopTestRun**](TestApi.md#teststoptestrun) | **PUT** /v0.1/apps/{owner_name}/{app_name}/test_runs/{test_run_id}/stop | 
[**TestUpdateDeviceSetOfOwner**](TestApi.md#testupdatedevicesetofowner) | **PUT** /v0.1/apps/{owner_name}/{app_name}/owner/device_sets/{id} | 
[**TestUpdateDeviceSetOfUser**](TestApi.md#testupdatedevicesetofuser) | **PUT** /v0.1/apps/{owner_name}/{app_name}/user/device_sets/{id} | 
[**TestUploadHash**](TestApi.md#testuploadhash) | **POST** /v0.1/apps/{owner_name}/{app_name}/test_runs/{test_run_id}/hashes | 
[**TestUploadHashesBatch**](TestApi.md#testuploadhashesbatch) | **POST** /v0.1/apps/{owner_name}/{app_name}/test_runs/{test_run_id}/hashes/batch | 

<a name="testarchivetestrun"></a>
# **TestArchiveTestRun**
> TestRun1 TestArchiveTestRun (Guid? testRunId, string ownerName, string appName)



Logically deletes a test run

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestArchiveTestRunExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var testRunId = new Guid?(); // Guid? | The ID of the test run
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                TestRun1 result = apiInstance.TestArchiveTestRun(testRunId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestArchiveTestRun: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **testRunId** | [**Guid?**](Guid?.md)| The ID of the test run | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**TestRun1**](TestRun1.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testcreatedeviceselection"></a>
# **TestCreateDeviceSelection**
> DeviceSelection TestCreateDeviceSelection (DeviceList body, string ownerName, string appName)



Creates a short ID for a list of devices

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestCreateDeviceSelectionExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var body = new DeviceList(); // DeviceList | 
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                DeviceSelection result = apiInstance.TestCreateDeviceSelection(body, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestCreateDeviceSelection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeviceList**](DeviceList.md)|  | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**DeviceSelection**](DeviceSelection.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testcreatedevicesetofowner"></a>
# **TestCreateDeviceSetOfOwner**
> DeviceSet TestCreateDeviceSetOfOwner (DeviceSetUpdateInformation3 body, string ownerName, string appName)



Creates a device set belonging to the owner

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestCreateDeviceSetOfOwnerExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var body = new DeviceSetUpdateInformation3(); // DeviceSetUpdateInformation3 | 
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                DeviceSet result = apiInstance.TestCreateDeviceSetOfOwner(body, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestCreateDeviceSetOfOwner: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeviceSetUpdateInformation3**](DeviceSetUpdateInformation3.md)|  | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**DeviceSet**](DeviceSet.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testcreatedevicesetofuser"></a>
# **TestCreateDeviceSetOfUser**
> DeviceSet TestCreateDeviceSetOfUser (DeviceSetUpdateInformation1 body, string ownerName, string appName)



Creates a device set belonging to the user

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestCreateDeviceSetOfUserExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var body = new DeviceSetUpdateInformation1(); // DeviceSetUpdateInformation1 | 
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                DeviceSet result = apiInstance.TestCreateDeviceSetOfUser(body, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestCreateDeviceSetOfUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeviceSetUpdateInformation1**](DeviceSetUpdateInformation1.md)|  | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**DeviceSet**](DeviceSet.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testcreatesubscription"></a>
# **TestCreateSubscription**
> Subscription1 TestCreateSubscription (string ownerName, string appName)



Accept a free trial subscription

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestCreateSubscriptionExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Subscription1 result = apiInstance.TestCreateSubscription(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestCreateSubscription: " + e.Message );
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

[**Subscription1**](Subscription1.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testcreatetestrun"></a>
# **TestCreateTestRun**
> void TestCreateTestRun (string ownerName, string appName)



Creates a new test run

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestCreateTestRunExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.TestCreateTestRun(ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestCreateTestRun: " + e.Message );
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

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testcreatetestseries"></a>
# **TestCreateTestSeries**
> TestSeries TestCreateTestSeries (NameOfTheTestSeries1 body, string ownerName, string appName)



Creates new test series for an application

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestCreateTestSeriesExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var body = new NameOfTheTestSeries1(); // NameOfTheTestSeries1 | 
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                TestSeries result = apiInstance.TestCreateTestSeries(body, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestCreateTestSeries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NameOfTheTestSeries1**](NameOfTheTestSeries1.md)|  | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**TestSeries**](TestSeries.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testdeletedevicesetofowner"></a>
# **TestDeleteDeviceSetOfOwner**
> void TestDeleteDeviceSetOfOwner (Guid? id, string ownerName, string appName)



Deletes a device set belonging to the owner

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestDeleteDeviceSetOfOwnerExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var id = new Guid?(); // Guid? | The UUID of the device set
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.TestDeleteDeviceSetOfOwner(id, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestDeleteDeviceSetOfOwner: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The UUID of the device set | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testdeletedevicesetofuser"></a>
# **TestDeleteDeviceSetOfUser**
> void TestDeleteDeviceSetOfUser (Guid? id, string ownerName, string appName)



Deletes a device set belonging to the user

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestDeleteDeviceSetOfUserExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var id = new Guid?(); // Guid? | The UUID of the device set
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.TestDeleteDeviceSetOfUser(id, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestDeleteDeviceSetOfUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The UUID of the device set | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testdeletetestseries"></a>
# **TestDeleteTestSeries**
> void TestDeleteTestSeries (string testSeriesSlug, string ownerName, string appName)



Deletes a single test series

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestDeleteTestSeriesExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var testSeriesSlug = testSeriesSlug_example;  // string | The slug of the test series
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.TestDeleteTestSeries(testSeriesSlug, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestDeleteTestSeries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **testSeriesSlug** | **string**| The slug of the test series | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testgdprexportaccount"></a>
# **TestGdprExportAccount**
> InlineResponse20099 TestGdprExportAccount ()



Lists account data

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestGdprExportAccountExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();

            try
            {
                InlineResponse20099 result = apiInstance.TestGdprExportAccount();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestGdprExportAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20099**](InlineResponse20099.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testgdprexportaccounts"></a>
# **TestGdprExportAccounts**
> InlineResponse20026 TestGdprExportAccounts ()



Lists all the endpoints available for Test accounts data

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestGdprExportAccountsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();

            try
            {
                InlineResponse20026 result = apiInstance.TestGdprExportAccounts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestGdprExportAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20026**](InlineResponse20026.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testgdprexportapp"></a>
# **TestGdprExportApp**
> InlineResponse20025 TestGdprExportApp (string ownerName, string appName)



Lists app data

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestGdprExportAppExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20025 result = apiInstance.TestGdprExportApp(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestGdprExportApp: " + e.Message );
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

[**InlineResponse20025**](InlineResponse20025.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testgdprexportapps"></a>
# **TestGdprExportApps**
> InlineResponse20026 TestGdprExportApps (string ownerName, string appName)



Lists all the endpoints available for Test apps data

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestGdprExportAppsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20026 result = apiInstance.TestGdprExportApps(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestGdprExportApps: " + e.Message );
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

[**InlineResponse20026**](InlineResponse20026.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testgdprexportfeatureflag"></a>
# **TestGdprExportFeatureFlag**
> InlineResponse20098 TestGdprExportFeatureFlag ()



Lists feature flag data

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestGdprExportFeatureFlagExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();

            try
            {
                InlineResponse20098 result = apiInstance.TestGdprExportFeatureFlag();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestGdprExportFeatureFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20098**](InlineResponse20098.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testgdprexportfilesetfile"></a>
# **TestGdprExportFileSetFile**
> InlineResponse20024 TestGdprExportFileSetFile (string ownerName, string appName)



Lists file set file data

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestGdprExportFileSetFileExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20024 result = apiInstance.TestGdprExportFileSetFile(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestGdprExportFileSetFile: " + e.Message );
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

[**InlineResponse20024**](InlineResponse20024.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testgdprexporthashfile"></a>
# **TestGdprExportHashFile**
> InlineResponse20023 TestGdprExportHashFile (string ownerName, string appName)



Lists hash file data

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestGdprExportHashFileExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20023 result = apiInstance.TestGdprExportHashFile(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestGdprExportHashFile: " + e.Message );
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

[**InlineResponse20023**](InlineResponse20023.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testgdprexportpipelinetest"></a>
# **TestGdprExportPipelineTest**
> InlineResponse20022 TestGdprExportPipelineTest (string ownerName, string appName)



Lists pipeline test data

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestGdprExportPipelineTestExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20022 result = apiInstance.TestGdprExportPipelineTest(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestGdprExportPipelineTest: " + e.Message );
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

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testgdprexporttestrun"></a>
# **TestGdprExportTestRun**
> InlineResponse20021 TestGdprExportTestRun (string ownerName, string appName)



Lists test run data

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestGdprExportTestRunExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20021 result = apiInstance.TestGdprExportTestRun(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestGdprExportTestRun: " + e.Message );
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

[**InlineResponse20021**](InlineResponse20021.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testgetalltestrunsforseries"></a>
# **TestGetAllTestRunsForSeries**
> List<TestRun> TestGetAllTestRunsForSeries (string testSeriesSlug, string ownerName, string appName)



Returns list of all test runs for a given test series

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestGetAllTestRunsForSeriesExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var testSeriesSlug = testSeriesSlug_example;  // string | The slug of the test series
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;TestRun&gt; result = apiInstance.TestGetAllTestRunsForSeries(testSeriesSlug, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestGetAllTestRunsForSeries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **testSeriesSlug** | **string**| The slug of the test series | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**List<TestRun>**](TestRun.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testgetalltestseries"></a>
# **TestGetAllTestSeries**
> List<TestSeries1> TestGetAllTestSeries (string ownerName, string appName, string query = null)



Returns list of all test series for an application

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestGetAllTestSeriesExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var query = query_example;  // string | A query string to filter test series (optional) 

            try
            {
                List&lt;TestSeries1&gt; result = apiInstance.TestGetAllTestSeries(ownerName, appName, query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestGetAllTestSeries: " + e.Message );
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
 **query** | **string**| A query string to filter test series | [optional] 

### Return type

[**List<TestSeries1>**](TestSeries1.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testgetdeviceconfigurations"></a>
# **TestGetDeviceConfigurations**
> List<InlineResponse20061> TestGetDeviceConfigurations (string ownerName, string appName, Guid? appUploadId = null)



Returns a list of available devices

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestGetDeviceConfigurationsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var appUploadId = new Guid?(); // Guid? | The ID of the test run (optional) 

            try
            {
                List&lt;InlineResponse20061&gt; result = apiInstance.TestGetDeviceConfigurations(ownerName, appName, appUploadId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestGetDeviceConfigurations: " + e.Message );
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
 **appUploadId** | [**Guid?**](Guid?.md)| The ID of the test run | [optional] 

### Return type

[**List<InlineResponse20061>**](InlineResponse20061.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testgetdevicesetofowner"></a>
# **TestGetDeviceSetOfOwner**
> DeviceSet TestGetDeviceSetOfOwner (Guid? id, string ownerName, string appName)



Gets a device set belonging to the owner

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestGetDeviceSetOfOwnerExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var id = new Guid?(); // Guid? | The UUID of the device set
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                DeviceSet result = apiInstance.TestGetDeviceSetOfOwner(id, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestGetDeviceSetOfOwner: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The UUID of the device set | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**DeviceSet**](DeviceSet.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testgetdevicesetofuser"></a>
# **TestGetDeviceSetOfUser**
> DeviceSet TestGetDeviceSetOfUser (Guid? id, string ownerName, string appName)



Gets a device set belonging to the user

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestGetDeviceSetOfUserExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var id = new Guid?(); // Guid? | The UUID of the device set
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                DeviceSet result = apiInstance.TestGetDeviceSetOfUser(id, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestGetDeviceSetOfUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The UUID of the device set | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**DeviceSet**](DeviceSet.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testgetsubscriptions"></a>
# **TestGetSubscriptions**
> Subscription1 TestGetSubscriptions (string ownerName, string appName)



Get information about the currently active subscriptions, if any

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestGetSubscriptionsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Subscription1 result = apiInstance.TestGetSubscriptions(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestGetSubscriptions: " + e.Message );
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

[**Subscription1**](Subscription1.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testgettestreport"></a>
# **TestGetTestReport**
> Object TestGetTestReport (Guid? testRunId, string ownerName, string appName)



Returns a single test report

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestGetTestReportExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var testRunId = new Guid?(); // Guid? | The ID of the test run
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.TestGetTestReport(testRunId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestGetTestReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **testRunId** | [**Guid?**](Guid?.md)| The ID of the test run | 
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
<a name="testgettestrun"></a>
# **TestGetTestRun**
> TestRun1 TestGetTestRun (Guid? testRunId, string ownerName, string appName)



Returns a single test runs

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestGetTestRunExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var testRunId = new Guid?(); // Guid? | The ID of the test run
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                TestRun1 result = apiInstance.TestGetTestRun(testRunId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestGetTestRun: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **testRunId** | [**Guid?**](Guid?.md)| The ID of the test run | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**TestRun1**](TestRun1.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testgettestrunstate"></a>
# **TestGetTestRunState**
> TestRunState TestGetTestRunState (string testRunId, string ownerName, string appName)



Gets state of the test run

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestGetTestRunStateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var testRunId = testRunId_example;  // string | The ID of the test run
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                TestRunState result = apiInstance.TestGetTestRunState(testRunId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestGetTestRunState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **testRunId** | **string**| The ID of the test run | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**TestRunState**](TestRunState.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testgettestruns"></a>
# **TestGetTestRuns**
> List<TestRun> TestGetTestRuns (string ownerName, string appName)



Returns a list of test runs

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestGetTestRunsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;TestRun&gt; result = apiInstance.TestGetTestRuns(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestGetTestRuns: " + e.Message );
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

[**List<TestRun>**](TestRun.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testlistdevicesetsofowner"></a>
# **TestListDeviceSetsOfOwner**
> List<DeviceSet2> TestListDeviceSetsOfOwner (string ownerName, string appName)



Lists device sets belonging to the owner

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestListDeviceSetsOfOwnerExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;DeviceSet2&gt; result = apiInstance.TestListDeviceSetsOfOwner(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestListDeviceSetsOfOwner: " + e.Message );
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

[**List<DeviceSet2>**](DeviceSet2.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testlistdevicesetsofuser"></a>
# **TestListDeviceSetsOfUser**
> List<DeviceSet1> TestListDeviceSetsOfUser (string ownerName, string appName)



Lists device sets belonging to the user

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestListDeviceSetsOfUserExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;DeviceSet1&gt; result = apiInstance.TestListDeviceSetsOfUser(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestListDeviceSetsOfUser: " + e.Message );
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

[**List<DeviceSet1>**](DeviceSet1.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testpatchtestseries"></a>
# **TestPatchTestSeries**
> TestSeries TestPatchTestSeries (NameOfTheTestSeries body, string testSeriesSlug, string ownerName, string appName)



Updates name and slug of a test series

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestPatchTestSeriesExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var body = new NameOfTheTestSeries(); // NameOfTheTestSeries | 
            var testSeriesSlug = testSeriesSlug_example;  // string | The slug of the test series
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                TestSeries result = apiInstance.TestPatchTestSeries(body, testSeriesSlug, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestPatchTestSeries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NameOfTheTestSeries**](NameOfTheTestSeries.md)|  | 
 **testSeriesSlug** | **string**| The slug of the test series | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**TestSeries**](TestSeries.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="teststarttestrun"></a>
# **TestStartTestRun**
> TestCloudTestRunStartResult TestStartTestRun (TestCloudStartTestRunOptions body, string testRunId, string ownerName, string appName)



Starts test run

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestStartTestRunExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var body = new TestCloudStartTestRunOptions(); // TestCloudStartTestRunOptions | Option required to start the test run
            var testRunId = testRunId_example;  // string | The ID of the test run
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                TestCloudTestRunStartResult result = apiInstance.TestStartTestRun(body, testRunId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestStartTestRun: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TestCloudStartTestRunOptions**](TestCloudStartTestRunOptions.md)| Option required to start the test run | 
 **testRunId** | **string**| The ID of the test run | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**TestCloudTestRunStartResult**](TestCloudTestRunStartResult.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="teststartuploadingfile"></a>
# **TestStartUploadingFile**
> void TestStartUploadingFile (string testRunId, string ownerName, string appName)



Uploads file for a test run

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestStartUploadingFileExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var testRunId = testRunId_example;  // string | The ID of the test run
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.TestStartUploadingFile(testRunId, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestStartUploadingFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **testRunId** | **string**| The ID of the test run | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="teststoptestrun"></a>
# **TestStopTestRun**
> TestRun1 TestStopTestRun (string testRunId, string ownerName, string appName)



Stop a test run execution

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestStopTestRunExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var testRunId = testRunId_example;  // string | The ID of the test run to be stopped
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                TestRun1 result = apiInstance.TestStopTestRun(testRunId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestStopTestRun: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **testRunId** | **string**| The ID of the test run to be stopped | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**TestRun1**](TestRun1.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testupdatedevicesetofowner"></a>
# **TestUpdateDeviceSetOfOwner**
> DeviceSet TestUpdateDeviceSetOfOwner (DeviceSetUpdateInformation2 body, Guid? id, string ownerName, string appName)



Updates a device set belonging to the owner

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestUpdateDeviceSetOfOwnerExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var body = new DeviceSetUpdateInformation2(); // DeviceSetUpdateInformation2 | 
            var id = new Guid?(); // Guid? | The UUID of the device set
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                DeviceSet result = apiInstance.TestUpdateDeviceSetOfOwner(body, id, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestUpdateDeviceSetOfOwner: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeviceSetUpdateInformation2**](DeviceSetUpdateInformation2.md)|  | 
 **id** | [**Guid?**](Guid?.md)| The UUID of the device set | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**DeviceSet**](DeviceSet.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testupdatedevicesetofuser"></a>
# **TestUpdateDeviceSetOfUser**
> DeviceSet TestUpdateDeviceSetOfUser (DeviceSetUpdateInformation body, Guid? id, string ownerName, string appName)



Updates a device set belonging to the user

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestUpdateDeviceSetOfUserExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var body = new DeviceSetUpdateInformation(); // DeviceSetUpdateInformation | 
            var id = new Guid?(); // Guid? | The UUID of the device set
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                DeviceSet result = apiInstance.TestUpdateDeviceSetOfUser(body, id, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestUpdateDeviceSetOfUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeviceSetUpdateInformation**](DeviceSetUpdateInformation.md)|  | 
 **id** | [**Guid?**](Guid?.md)| The UUID of the device set | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**DeviceSet**](DeviceSet.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testuploadhash"></a>
# **TestUploadHash**
> void TestUploadHash (TestCloudFileHash1 body, string testRunId, string ownerName, string appName)



Adds file with the given hash to a test run

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestUploadHashExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var body = new TestCloudFileHash1(); // TestCloudFileHash1 | File hash information
            var testRunId = testRunId_example;  // string | The ID of the test run
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.TestUploadHash(body, testRunId, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestUploadHash: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TestCloudFileHash1**](TestCloudFileHash1.md)| File hash information | 
 **testRunId** | **string**| The ID of the test run | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="testuploadhashesbatch"></a>
# **TestUploadHashesBatch**
> List<TestCloudFileHashResponse> TestUploadHashesBatch (List<TestCloudFileHash> body, string testRunId, string ownerName, string appName)



Adds file with the given hash to a test run

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TestUploadHashesBatchExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TestApi();
            var body = new List<TestCloudFileHash>(); // List<TestCloudFileHash> | File hash information
            var testRunId = testRunId_example;  // string | The ID of the test run
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;TestCloudFileHashResponse&gt; result = apiInstance.TestUploadHashesBatch(body, testRunId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.TestUploadHashesBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;TestCloudFileHash&gt;**](TestCloudFileHash.md)| File hash information | 
 **testRunId** | **string**| The ID of the test run | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**List<TestCloudFileHashResponse>**](TestCloudFileHashResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
