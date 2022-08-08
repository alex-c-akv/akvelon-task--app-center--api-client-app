# AppCenterApiClientLib.Api.CodepushApi

All URIs are relative to *https://api.appcenter.ms/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CodePushAcquisitionGetAcquisitionStatus**](CodepushApi.md#codepushacquisitiongetacquisitionstatus) | **GET** /v0.1/public/codepush/status | 
[**CodePushAcquisitionUpdateCheck**](CodepushApi.md#codepushacquisitionupdatecheck) | **GET** /v0.1/public/codepush/update_check | 
[**CodePushAcquisitionUpdateDeployStatus**](CodepushApi.md#codepushacquisitionupdatedeploystatus) | **POST** /v0.1/public/codepush/report_status/deploy | 
[**CodePushAcquisitionUpdateDownloadStatus**](CodepushApi.md#codepushacquisitionupdatedownloadstatus) | **POST** /v0.1/public/codepush/report_status/download | 
[**CodePushDeploymentMetricsGet**](CodepushApi.md#codepushdeploymentmetricsget) | **GET** /v0.1/apps/{owner_name}/{app_name}/deployments/{deployment_name}/metrics | 
[**CodePushDeploymentReleaseRollback**](CodepushApi.md#codepushdeploymentreleaserollback) | **POST** /v0.1/apps/{owner_name}/{app_name}/deployments/{deployment_name}/rollback_release | 
[**CodePushDeploymentReleasesCreate**](CodepushApi.md#codepushdeploymentreleasescreate) | **POST** /v0.1/apps/{owner_name}/{app_name}/deployments/{deployment_name}/releases | 
[**CodePushDeploymentReleasesDelete**](CodepushApi.md#codepushdeploymentreleasesdelete) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/deployments/{deployment_name}/releases | 
[**CodePushDeploymentReleasesGet**](CodepushApi.md#codepushdeploymentreleasesget) | **GET** /v0.1/apps/{owner_name}/{app_name}/deployments/{deployment_name}/releases | 
[**CodePushDeploymentUploadCreate**](CodepushApi.md#codepushdeploymentuploadcreate) | **POST** /v0.1/apps/{owner_name}/{app_name}/deployments/{deployment_name}/uploads | 
[**CodePushDeploymentsCreate**](CodepushApi.md#codepushdeploymentscreate) | **POST** /v0.1/apps/{owner_name}/{app_name}/deployments | 
[**CodePushDeploymentsDelete**](CodepushApi.md#codepushdeploymentsdelete) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/deployments/{deployment_name} | 
[**CodePushDeploymentsGet**](CodepushApi.md#codepushdeploymentsget) | **GET** /v0.1/apps/{owner_name}/{app_name}/deployments/{deployment_name} | 
[**CodePushDeploymentsList**](CodepushApi.md#codepushdeploymentslist) | **GET** /v0.1/apps/{owner_name}/{app_name}/deployments | 
[**CodePushDeploymentsPromote**](CodepushApi.md#codepushdeploymentspromote) | **POST** /v0.1/apps/{owner_name}/{app_name}/deployments/{deployment_name}/promote_release/{promote_deployment_name} | 
[**CodePushDeploymentsUpdate**](CodepushApi.md#codepushdeploymentsupdate) | **PATCH** /v0.1/apps/{owner_name}/{app_name}/deployments/{deployment_name} | 
[**DeploymentReleasesUpdate**](CodepushApi.md#deploymentreleasesupdate) | **PATCH** /v0.1/apps/{owner_name}/{app_name}/deployments/{deployment_name}/releases/{release_label} | 
[**LegacyCodePushAcquisitionUpdateCheck**](CodepushApi.md#legacycodepushacquisitionupdatecheck) | **GET** /v0.1/legacy/updateCheck | 
[**LegacyCodePushAcquisitionUpdateDownloadStatus**](CodepushApi.md#legacycodepushacquisitionupdatedownloadstatus) | **POST** /v0.1/legacy/reportStatus/download | 
[**LegacyCodePushAcquisitionUpdateInstallsStatus**](CodepushApi.md#legacycodepushacquisitionupdateinstallsstatus) | **POST** /v0.1/legacy/reportStatus/deploy | 

<a name="codepushacquisitiongetacquisitionstatus"></a>
# **CodePushAcquisitionGetAcquisitionStatus**
> Object CodePushAcquisitionGetAcquisitionStatus ()



Returns the acquisition service status to the caller

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CodePushAcquisitionGetAcquisitionStatusExample
    {
        public void main()
        {
            var apiInstance = new CodepushApi();

            try
            {
                Object result = apiInstance.CodePushAcquisitionGetAcquisitionStatus();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodepushApi.CodePushAcquisitionGetAcquisitionStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="codepushacquisitionupdatecheck"></a>
# **CodePushAcquisitionUpdateCheck**
> Object CodePushAcquisitionUpdateCheck (string deploymentKey, string appVersion, string packageHash = null, string label = null, string clientUniqueId = null, bool? isCompanion = null, string previousLabelOrAppVersion = null, string previousDeploymentKey = null)



Check for updates

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CodePushAcquisitionUpdateCheckExample
    {
        public void main()
        {
            var apiInstance = new CodepushApi();
            var deploymentKey = deploymentKey_example;  // string | 
            var appVersion = appVersion_example;  // string | 
            var packageHash = packageHash_example;  // string |  (optional) 
            var label = label_example;  // string |  (optional) 
            var clientUniqueId = clientUniqueId_example;  // string |  (optional) 
            var isCompanion = true;  // bool? |  (optional) 
            var previousLabelOrAppVersion = previousLabelOrAppVersion_example;  // string |  (optional) 
            var previousDeploymentKey = previousDeploymentKey_example;  // string |  (optional) 

            try
            {
                Object result = apiInstance.CodePushAcquisitionUpdateCheck(deploymentKey, appVersion, packageHash, label, clientUniqueId, isCompanion, previousLabelOrAppVersion, previousDeploymentKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodepushApi.CodePushAcquisitionUpdateCheck: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deploymentKey** | **string**|  | 
 **appVersion** | **string**|  | 
 **packageHash** | **string**|  | [optional] 
 **label** | **string**|  | [optional] 
 **clientUniqueId** | **string**|  | [optional] 
 **isCompanion** | **bool?**|  | [optional] 
 **previousLabelOrAppVersion** | **string**|  | [optional] 
 **previousDeploymentKey** | **string**|  | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="codepushacquisitionupdatedeploystatus"></a>
# **CodePushAcquisitionUpdateDeployStatus**
> void CodePushAcquisitionUpdateDeployStatus (ReportStatusDeployBody body)



Report Deployment status metric

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CodePushAcquisitionUpdateDeployStatusExample
    {
        public void main()
        {
            var apiInstance = new CodepushApi();
            var body = new ReportStatusDeployBody(); // ReportStatusDeployBody | Deployment status metric properties

            try
            {
                apiInstance.CodePushAcquisitionUpdateDeployStatus(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodepushApi.CodePushAcquisitionUpdateDeployStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportStatusDeployBody**](ReportStatusDeployBody.md)| Deployment status metric properties | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="codepushacquisitionupdatedownloadstatus"></a>
# **CodePushAcquisitionUpdateDownloadStatus**
> void CodePushAcquisitionUpdateDownloadStatus (ReportStatusDownloadBody body)



Report download of specified release

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CodePushAcquisitionUpdateDownloadStatusExample
    {
        public void main()
        {
            var apiInstance = new CodepushApi();
            var body = new ReportStatusDownloadBody(); // ReportStatusDownloadBody | Deployment status metric properties

            try
            {
                apiInstance.CodePushAcquisitionUpdateDownloadStatus(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodepushApi.CodePushAcquisitionUpdateDownloadStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportStatusDownloadBody**](ReportStatusDownloadBody.md)| Deployment status metric properties | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="codepushdeploymentmetricsget"></a>
# **CodePushDeploymentMetricsGet**
> List<InlineResponse20062> CodePushDeploymentMetricsGet (string deploymentName, string ownerName, string appName)



Gets all releases metrics for specified Deployment

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CodePushDeploymentMetricsGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CodepushApi();
            var deploymentName = deploymentName_example;  // string | deployment name
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse20062&gt; result = apiInstance.CodePushDeploymentMetricsGet(deploymentName, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodepushApi.CodePushDeploymentMetricsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deploymentName** | **string**| deployment name | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**List<InlineResponse20062>**](InlineResponse20062.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="codepushdeploymentreleaserollback"></a>
# **CodePushDeploymentReleaseRollback**
> Object CodePushDeploymentReleaseRollback (string deploymentName, string ownerName, string appName, DeploymentNameRollbackReleaseBody body = null)



Rollback the latest or a specific release for an app deployment

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CodePushDeploymentReleaseRollbackExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CodepushApi();
            var deploymentName = deploymentName_example;  // string | deployment name
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var body = new DeploymentNameRollbackReleaseBody(); // DeploymentNameRollbackReleaseBody | The specific release label that you want to rollback to (optional) 

            try
            {
                Object result = apiInstance.CodePushDeploymentReleaseRollback(deploymentName, ownerName, appName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodepushApi.CodePushDeploymentReleaseRollback: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deploymentName** | **string**| deployment name | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **body** | [**DeploymentNameRollbackReleaseBody**](DeploymentNameRollbackReleaseBody.md)| The specific release label that you want to rollback to | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="codepushdeploymentreleasescreate"></a>
# **CodePushDeploymentReleasesCreate**
> Object CodePushDeploymentReleasesCreate (DeploymentNameReleasesBody body, string deploymentName, string ownerName, string appName)



Create a new CodePush release for the specified deployment

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CodePushDeploymentReleasesCreateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CodepushApi();
            var body = new DeploymentNameReleasesBody(); // DeploymentNameReleasesBody | The necessary information required to download the bundle and being the release process.
            var deploymentName = deploymentName_example;  // string | deployment name
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.CodePushDeploymentReleasesCreate(body, deploymentName, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodepushApi.CodePushDeploymentReleasesCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeploymentNameReleasesBody**](DeploymentNameReleasesBody.md)| The necessary information required to download the bundle and being the release process. | 
 **deploymentName** | **string**| deployment name | 
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
<a name="codepushdeploymentreleasesdelete"></a>
# **CodePushDeploymentReleasesDelete**
> void CodePushDeploymentReleasesDelete (string deploymentName, string ownerName, string appName)



Clears a Deployment of releases

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CodePushDeploymentReleasesDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CodepushApi();
            var deploymentName = deploymentName_example;  // string | deployment name
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.CodePushDeploymentReleasesDelete(deploymentName, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodepushApi.CodePushDeploymentReleasesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deploymentName** | **string**| deployment name | 
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
<a name="codepushdeploymentreleasesget"></a>
# **CodePushDeploymentReleasesGet**
> List<Object> CodePushDeploymentReleasesGet (string deploymentName, string ownerName, string appName)



Gets the history of releases on a Deployment

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CodePushDeploymentReleasesGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CodepushApi();
            var deploymentName = deploymentName_example;  // string | deployment name
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;Object&gt; result = apiInstance.CodePushDeploymentReleasesGet(deploymentName, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodepushApi.CodePushDeploymentReleasesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deploymentName** | **string**| deployment name | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

**List<Object>**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="codepushdeploymentuploadcreate"></a>
# **CodePushDeploymentUploadCreate**
> Object CodePushDeploymentUploadCreate (string deploymentName, string ownerName, string appName)



Create a new CodePush release upload for the specified deployment

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CodePushDeploymentUploadCreateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CodepushApi();
            var deploymentName = deploymentName_example;  // string | deployment name
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.CodePushDeploymentUploadCreate(deploymentName, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodepushApi.CodePushDeploymentUploadCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deploymentName** | **string**| deployment name | 
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
<a name="codepushdeploymentscreate"></a>
# **CodePushDeploymentsCreate**
> AppNameDeploymentsBody CodePushDeploymentsCreate (AppNameDeploymentsBody body, string ownerName, string appName)



Creates a CodePush Deployment for the given app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CodePushDeploymentsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CodepushApi();
            var body = new AppNameDeploymentsBody(); // AppNameDeploymentsBody | Deployment to be created
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                AppNameDeploymentsBody result = apiInstance.CodePushDeploymentsCreate(body, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodepushApi.CodePushDeploymentsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AppNameDeploymentsBody**](AppNameDeploymentsBody.md)| Deployment to be created | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**AppNameDeploymentsBody**](AppNameDeploymentsBody.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="codepushdeploymentsdelete"></a>
# **CodePushDeploymentsDelete**
> void CodePushDeploymentsDelete (string deploymentName, string ownerName, string appName, Object body = null)



Deletes a CodePush Deployment for the given app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CodePushDeploymentsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CodepushApi();
            var deploymentName = deploymentName_example;  // string | deployment name
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var body = new Object(); // Object |  (optional) 

            try
            {
                apiInstance.CodePushDeploymentsDelete(deploymentName, ownerName, appName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodepushApi.CodePushDeploymentsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deploymentName** | **string**| deployment name | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="codepushdeploymentsget"></a>
# **CodePushDeploymentsGet**
> InlineResponse20063 CodePushDeploymentsGet (string deploymentName, string ownerName, string appName)



Gets a CodePush Deployment for the given app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CodePushDeploymentsGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CodepushApi();
            var deploymentName = deploymentName_example;  // string | deployment name
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20063 result = apiInstance.CodePushDeploymentsGet(deploymentName, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodepushApi.CodePushDeploymentsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deploymentName** | **string**| deployment name | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20063**](InlineResponse20063.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="codepushdeploymentslist"></a>
# **CodePushDeploymentsList**
> List<InlineResponse20063> CodePushDeploymentsList (string ownerName, string appName)



Gets a list of CodePush deployments for the given app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CodePushDeploymentsListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CodepushApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse20063&gt; result = apiInstance.CodePushDeploymentsList(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodepushApi.CodePushDeploymentsList: " + e.Message );
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

[**List<InlineResponse20063>**](InlineResponse20063.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="codepushdeploymentspromote"></a>
# **CodePushDeploymentsPromote**
> Object CodePushDeploymentsPromote (string deploymentName, string promoteDeploymentName, string ownerName, string appName, PromoteReleasePromoteDeploymentNameBody body = null)



Promote one release (default latest one) from one deployment to another

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CodePushDeploymentsPromoteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CodepushApi();
            var deploymentName = deploymentName_example;  // string | deployment name
            var promoteDeploymentName = promoteDeploymentName_example;  // string | deployment name
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var body = new PromoteReleasePromoteDeploymentNameBody(); // PromoteReleasePromoteDeploymentNameBody | Release to be promoted, only needs to provide optional fields, description, label, disabled, mandatory, rollout, targetBinaryVersion (optional) 

            try
            {
                Object result = apiInstance.CodePushDeploymentsPromote(deploymentName, promoteDeploymentName, ownerName, appName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodepushApi.CodePushDeploymentsPromote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deploymentName** | **string**| deployment name | 
 **promoteDeploymentName** | **string**| deployment name | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **body** | [**PromoteReleasePromoteDeploymentNameBody**](PromoteReleasePromoteDeploymentNameBody.md)| Release to be promoted, only needs to provide optional fields, description, label, disabled, mandatory, rollout, targetBinaryVersion | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="codepushdeploymentsupdate"></a>
# **CodePushDeploymentsUpdate**
> void CodePushDeploymentsUpdate (DeploymentsDeploymentNameBody body, string deploymentName, string ownerName, string appName)



Modifies a CodePush Deployment for the given app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CodePushDeploymentsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CodepushApi();
            var body = new DeploymentsDeploymentNameBody(); // DeploymentsDeploymentNameBody | Deployment modification. All fields are optional and only provided fields will get updated.
            var deploymentName = deploymentName_example;  // string | deployment name
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.CodePushDeploymentsUpdate(body, deploymentName, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodepushApi.CodePushDeploymentsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeploymentsDeploymentNameBody**](DeploymentsDeploymentNameBody.md)| Deployment modification. All fields are optional and only provided fields will get updated. | 
 **deploymentName** | **string**| deployment name | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deploymentreleasesupdate"></a>
# **DeploymentReleasesUpdate**
> Object DeploymentReleasesUpdate (ReleasesReleaseLabelBody body, string deploymentName, string releaseLabel, string ownerName, string appName)



Modifies a CodePush release metadata under the given Deployment

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DeploymentReleasesUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CodepushApi();
            var body = new ReleasesReleaseLabelBody(); // ReleasesReleaseLabelBody | Release modification. All fields are optional and only provided fields will get updated.
            var deploymentName = deploymentName_example;  // string | deployment name
            var releaseLabel = releaseLabel_example;  // string | release label
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.DeploymentReleasesUpdate(body, deploymentName, releaseLabel, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodepushApi.DeploymentReleasesUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReleasesReleaseLabelBody**](ReleasesReleaseLabelBody.md)| Release modification. All fields are optional and only provided fields will get updated. | 
 **deploymentName** | **string**| deployment name | 
 **releaseLabel** | **string**| release label | 
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
<a name="legacycodepushacquisitionupdatecheck"></a>
# **LegacyCodePushAcquisitionUpdateCheck**
> Object LegacyCodePushAcquisitionUpdateCheck (string deploymentKey = null, string appVersion = null, string packageHash = null, string label = null, string clientUniqueId = null, string isCompanion = null)



Check for updates

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class LegacyCodePushAcquisitionUpdateCheckExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CodepushApi();
            var deploymentKey = deploymentKey_example;  // string |  (optional) 
            var appVersion = appVersion_example;  // string |  (optional) 
            var packageHash = packageHash_example;  // string |  (optional) 
            var label = label_example;  // string |  (optional) 
            var clientUniqueId = clientUniqueId_example;  // string |  (optional) 
            var isCompanion = isCompanion_example;  // string |  (optional) 

            try
            {
                Object result = apiInstance.LegacyCodePushAcquisitionUpdateCheck(deploymentKey, appVersion, packageHash, label, clientUniqueId, isCompanion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodepushApi.LegacyCodePushAcquisitionUpdateCheck: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deploymentKey** | **string**|  | [optional] 
 **appVersion** | **string**|  | [optional] 
 **packageHash** | **string**|  | [optional] 
 **label** | **string**|  | [optional] 
 **clientUniqueId** | **string**|  | [optional] 
 **isCompanion** | **string**|  | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="legacycodepushacquisitionupdatedownloadstatus"></a>
# **LegacyCodePushAcquisitionUpdateDownloadStatus**
> void LegacyCodePushAcquisitionUpdateDownloadStatus (ReportStatusDownloadBody body)



Report download of specified release

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class LegacyCodePushAcquisitionUpdateDownloadStatusExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CodepushApi();
            var body = new ReportStatusDownloadBody(); // ReportStatusDownloadBody | Deployment status metric properties

            try
            {
                apiInstance.LegacyCodePushAcquisitionUpdateDownloadStatus(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodepushApi.LegacyCodePushAcquisitionUpdateDownloadStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportStatusDownloadBody**](ReportStatusDownloadBody.md)| Deployment status metric properties | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="legacycodepushacquisitionupdateinstallsstatus"></a>
# **LegacyCodePushAcquisitionUpdateInstallsStatus**
> void LegacyCodePushAcquisitionUpdateInstallsStatus (ReportStatusDeployBody body)



Report deploy of specified release

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class LegacyCodePushAcquisitionUpdateInstallsStatusExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CodepushApi();
            var body = new ReportStatusDeployBody(); // ReportStatusDeployBody | Deployment status metric properties

            try
            {
                apiInstance.LegacyCodePushAcquisitionUpdateInstallsStatus(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodepushApi.LegacyCodePushAcquisitionUpdateInstallsStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportStatusDeployBody**](ReportStatusDeployBody.md)| Deployment status metric properties | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
