# AppCenterApiClientLib.Api.BuildApi

All URIs are relative to *https://api.appcenter.ms/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BranchConfigurationsCreate**](BuildApi.md#branchconfigurationscreate) | **POST** /v0.1/apps/{owner_name}/{app_name}/branches/{branch}/config | 
[**BranchConfigurationsDelete**](BuildApi.md#branchconfigurationsdelete) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/branches/{branch}/config | 
[**BranchConfigurationsGet**](BuildApi.md#branchconfigurationsget) | **GET** /v0.1/apps/{owner_name}/{app_name}/branches/{branch}/config | 
[**BranchConfigurationsUpdate**](BuildApi.md#branchconfigurationsupdate) | **PUT** /v0.1/apps/{owner_name}/{app_name}/branches/{branch}/config | 
[**BuildConfigurationsGet**](BuildApi.md#buildconfigurationsget) | **GET** /v0.1/apps/{owner_name}/{app_name}/branches/{branch}/export_config | 
[**BuildsCreate**](BuildApi.md#buildscreate) | **POST** /v0.1/apps/{owner_name}/{app_name}/branches/{branch}/builds | 
[**BuildsDistribute**](BuildApi.md#buildsdistribute) | **POST** /v0.1/apps/{owner_name}/{app_name}/builds/{build_id}/distribute | 
[**BuildsGet**](BuildApi.md#buildsget) | **GET** /v0.1/apps/{owner_name}/{app_name}/builds/{build_id} | 
[**BuildsGetDownloadUri**](BuildApi.md#buildsgetdownloaduri) | **GET** /v0.1/apps/{owner_name}/{app_name}/builds/{build_id}/downloads/{download_type} | 
[**BuildsGetLog**](BuildApi.md#buildsgetlog) | **GET** /v0.1/apps/{owner_name}/{app_name}/builds/{build_id}/logs | 
[**BuildsGetStatusByAppId**](BuildApi.md#buildsgetstatusbyappid) | **GET** /v0.1/apps/{owner_name}/{app_name}/build_service_status | 
[**BuildsListBranches**](BuildApi.md#buildslistbranches) | **GET** /v0.1/apps/{owner_name}/{app_name}/branches | 
[**BuildsListByBranch**](BuildApi.md#buildslistbybranch) | **GET** /v0.1/apps/{owner_name}/{app_name}/branches/{branch}/builds | 
[**BuildsListToolsetProjects**](BuildApi.md#buildslisttoolsetprojects) | **GET** /v0.1/apps/{owner_name}/{app_name}/branches/{branch}/toolset_projects | 
[**BuildsListToolsets**](BuildApi.md#buildslisttoolsets) | **GET** /v0.1/apps/{owner_name}/{app_name}/toolsets | 
[**BuildsListXamarinSDKBundles**](BuildApi.md#buildslistxamarinsdkbundles) | **GET** /v0.1/apps/{owner_name}/{app_name}/xamarin_sdk_bundles | 
[**BuildsListXcodeVersions**](BuildApi.md#buildslistxcodeversions) | **GET** /v0.1/apps/{owner_name}/{app_name}/xcode_versions | 
[**BuildsUpdate**](BuildApi.md#buildsupdate) | **PATCH** /v0.1/apps/{owner_name}/{app_name}/builds/{build_id} | 
[**BuildsWebhook**](BuildApi.md#buildswebhook) | **POST** /v0.1/public/hooks | 
[**CommitsListByShaList**](BuildApi.md#commitslistbyshalist) | **GET** /v0.1/apps/{owner_name}/{app_name}/commits/batch | 
[**FileAssetsCreate**](BuildApi.md#fileassetscreate) | **POST** /v0.1/apps/{owner_name}/{app_name}/file_asset | 
[**RepositoriesList**](BuildApi.md#repositorieslist) | **GET** /v0.1/apps/{owner_name}/{app_name}/source_hosts/{source_host}/repositories | 
[**RepositoryConfigurationsCreateOrUpdate**](BuildApi.md#repositoryconfigurationscreateorupdate) | **POST** /v0.1/apps/{owner_name}/{app_name}/repo_config | 
[**RepositoryConfigurationsDelete**](BuildApi.md#repositoryconfigurationsdelete) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/repo_config | 
[**RepositoryConfigurationsList**](BuildApi.md#repositoryconfigurationslist) | **GET** /v0.1/apps/{owner_name}/{app_name}/repo_config | 

<a name="branchconfigurationscreate"></a>
# **BranchConfigurationsCreate**
> InlineResponse20072 BranchConfigurationsCreate (Dictionary<string, Object> body, string branch, string ownerName, string appName)



Configures the branch for build

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BranchConfigurationsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var body = new Dictionary<string, Object>(); // Dictionary<string, Object> | Parameters of the configuration
            var branch = branch_example;  // string | The branch name
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20072 result = apiInstance.BranchConfigurationsCreate(body, branch, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.BranchConfigurationsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dictionary&lt;string, Object&gt;**](Dictionary&lt;string, Object&gt;.md)| Parameters of the configuration | 
 **branch** | **string**| The branch name | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20072**](InlineResponse20072.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="branchconfigurationsdelete"></a>
# **BranchConfigurationsDelete**
> Object BranchConfigurationsDelete (string branch, string ownerName, string appName, Object body = null)



Deletes the branch build configuration

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BranchConfigurationsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var branch = branch_example;  // string | The branch name
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var body = new Object(); // Object |  (optional) 

            try
            {
                Object result = apiInstance.BranchConfigurationsDelete(branch, ownerName, appName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.BranchConfigurationsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **branch** | **string**| The branch name | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="branchconfigurationsget"></a>
# **BranchConfigurationsGet**
> InlineResponse20072 BranchConfigurationsGet (string branch, string ownerName, string appName)



Gets the branch configuration

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BranchConfigurationsGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var branch = branch_example;  // string | The branch name
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20072 result = apiInstance.BranchConfigurationsGet(branch, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.BranchConfigurationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **branch** | **string**| The branch name | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20072**](InlineResponse20072.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="branchconfigurationsupdate"></a>
# **BranchConfigurationsUpdate**
> InlineResponse20072 BranchConfigurationsUpdate (Dictionary<string, Object> body, string branch, string ownerName, string appName)



Reconfigures the branch for build

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BranchConfigurationsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var body = new Dictionary<string, Object>(); // Dictionary<string, Object> | Parameters of the configuration
            var branch = branch_example;  // string | The branch name
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse20072 result = apiInstance.BranchConfigurationsUpdate(body, branch, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.BranchConfigurationsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dictionary&lt;string, Object&gt;**](Dictionary&lt;string, Object&gt;.md)| Parameters of the configuration | 
 **branch** | **string**| The branch name | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse20072**](InlineResponse20072.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="buildconfigurationsget"></a>
# **BuildConfigurationsGet**
> Object BuildConfigurationsGet (string branch, string ownerName, string appName, string format = null)



Gets the build configuration in Azure pipeline YAML format

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BuildConfigurationsGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var branch = branch_example;  // string | The branch name
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var format = format_example;  // string | Configuration format (optional)  (default to yaml)

            try
            {
                Object result = apiInstance.BuildConfigurationsGet(branch, ownerName, appName, format);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.BuildConfigurationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **branch** | **string**| The branch name | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **format** | **string**| Configuration format | [optional] [default to yaml]

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="buildscreate"></a>
# **BuildsCreate**
> Object BuildsCreate (string branch, string ownerName, string appName, BranchBuildsBody body = null)



Create a build

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BuildsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var branch = branch_example;  // string | The branch name
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var body = new BranchBuildsBody(); // BranchBuildsBody | Parameters of the build (optional) 

            try
            {
                Object result = apiInstance.BuildsCreate(branch, ownerName, appName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.BuildsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **branch** | **string**| The branch name | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **body** | [**BranchBuildsBody**](BranchBuildsBody.md)| Parameters of the build | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="buildsdistribute"></a>
# **BuildsDistribute**
> Object BuildsDistribute (BuildIdDistributeBody body, int? buildId, string ownerName, string appName)



Distribute a build

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BuildsDistributeExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var body = new BuildIdDistributeBody(); // BuildIdDistributeBody | The distribution details
            var buildId = 56;  // int? | The build ID
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.BuildsDistribute(body, buildId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.BuildsDistribute: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BuildIdDistributeBody**](BuildIdDistributeBody.md)| The distribution details | 
 **buildId** | **int?**| The build ID | 
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
<a name="buildsget"></a>
# **BuildsGet**
> Object BuildsGet (int? buildId, string ownerName, string appName)



Returns the build detail for the given build ID

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BuildsGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var buildId = 56;  // int? | The build ID
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.BuildsGet(buildId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.BuildsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildId** | **int?**| The build ID | 
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
<a name="buildsgetdownloaduri"></a>
# **BuildsGetDownloadUri**
> Object BuildsGetDownloadUri (int? buildId, string downloadType, string ownerName, string appName)



Gets the download URI

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BuildsGetDownloadUriExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var buildId = 56;  // int? | The build ID
            var downloadType = downloadType_example;  // string | The download type
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.BuildsGetDownloadUri(buildId, downloadType, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.BuildsGetDownloadUri: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildId** | **int?**| The build ID | 
 **downloadType** | **string**| The download type | 
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
<a name="buildsgetlog"></a>
# **BuildsGetLog**
> Object BuildsGetLog (int? buildId, string ownerName, string appName)



Get the build log

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BuildsGetLogExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var buildId = 56;  // int? | The build ID
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.BuildsGetLog(buildId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.BuildsGetLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildId** | **int?**| The build ID | 
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
<a name="buildsgetstatusbyappid"></a>
# **BuildsGetStatusByAppId**
> Object BuildsGetStatusByAppId (string ownerName, string appName)



Application specific build service status

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BuildsGetStatusByAppIdExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.BuildsGetStatusByAppId(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.BuildsGetStatusByAppId: " + e.Message );
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
<a name="buildslistbranches"></a>
# **BuildsListBranches**
> List<Dictionary<string, Object>> BuildsListBranches (string ownerName, string appName)



Returns the list of Git branches for this application

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BuildsListBranchesExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;Dictionary&lt;string, Object&gt;&gt; result = apiInstance.BuildsListBranches(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.BuildsListBranches: " + e.Message );
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

**List<Dictionary<string, Object>>**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="buildslistbybranch"></a>
# **BuildsListByBranch**
> List<InlineResponse20073> BuildsListByBranch (string branch, string ownerName, string appName)



Returns the list of builds for the branch

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BuildsListByBranchExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var branch = branch_example;  // string | The branch name
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse20073&gt; result = apiInstance.BuildsListByBranch(branch, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.BuildsListByBranch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **branch** | **string**| The branch name | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**List<InlineResponse20073>**](InlineResponse20073.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="buildslisttoolsetprojects"></a>
# **BuildsListToolsetProjects**
> Object BuildsListToolsetProjects (string branch, string os, string platform, string ownerName, string appName, int? maxSearchDepth = null)



Returns the projects in the repository for the branch, for all toolsets

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BuildsListToolsetProjectsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var branch = branch_example;  // string | The branch name
            var os = os_example;  // string | The desired OS for the project scan; normally the same as the app OS
            var platform = platform_example;  // string | The desired platform for the project scan
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var maxSearchDepth = 56;  // int? | The depth of the repository to search for project files (optional) 

            try
            {
                Object result = apiInstance.BuildsListToolsetProjects(branch, os, platform, ownerName, appName, maxSearchDepth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.BuildsListToolsetProjects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **branch** | **string**| The branch name | 
 **os** | **string**| The desired OS for the project scan; normally the same as the app OS | 
 **platform** | **string**| The desired platform for the project scan | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **maxSearchDepth** | **int?**| The depth of the repository to search for project files | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="buildslisttoolsets"></a>
# **BuildsListToolsets**
> InlineResponse20020 BuildsListToolsets (string ownerName, string appName, string tools = null)



Returns available toolsets for application

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BuildsListToolsetsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var tools = tools_example;  // string | Toolset name (optional) 

            try
            {
                InlineResponse20020 result = apiInstance.BuildsListToolsets(ownerName, appName, tools);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.BuildsListToolsets: " + e.Message );
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
 **tools** | **string**| Toolset name | [optional] 

### Return type

[**InlineResponse20020**](InlineResponse20020.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="buildslistxamarinsdkbundles"></a>
# **BuildsListXamarinSDKBundles**
> List<InlineResponse20017> BuildsListXamarinSDKBundles (string ownerName, string appName)



Gets the Xamarin SDK bundles available to this app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BuildsListXamarinSDKBundlesExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse20017&gt; result = apiInstance.BuildsListXamarinSDKBundles(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.BuildsListXamarinSDKBundles: " + e.Message );
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

[**List<InlineResponse20017>**](InlineResponse20017.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="buildslistxcodeversions"></a>
# **BuildsListXcodeVersions**
> List<InlineResponse20016> BuildsListXcodeVersions (string ownerName, string appName)



Gets the Xcode versions available to this app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BuildsListXcodeVersionsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse20016&gt; result = apiInstance.BuildsListXcodeVersions(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.BuildsListXcodeVersions: " + e.Message );
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

[**List<InlineResponse20016>**](InlineResponse20016.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="buildsupdate"></a>
# **BuildsUpdate**
> Object BuildsUpdate (BuildsBuildIdBody body, int? buildId, string ownerName, string appName)



Cancels a build

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BuildsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var body = new BuildsBuildIdBody(); // BuildsBuildIdBody | 
            var buildId = 56;  // int? | The build ID
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.BuildsUpdate(body, buildId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.BuildsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BuildsBuildIdBody**](BuildsBuildIdBody.md)|  | 
 **buildId** | **int?**| The build ID | 
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
<a name="buildswebhook"></a>
# **BuildsWebhook**
> void BuildsWebhook (Object body = null)



Public webhook sink

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BuildsWebhookExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var body = new Object(); // Object |  (optional) 

            try
            {
                apiInstance.BuildsWebhook(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.BuildsWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="commitslistbyshalist"></a>
# **CommitsListByShaList**
> List<Object> CommitsListByShaList (List<string> hashes, string ownerName, string appName)



Returns commit information for a batch of shas

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class CommitsListByShaListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var hashes = new List<string>(); // List<string> | A collection of commit SHAs comma-delimited
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;Object&gt; result = apiInstance.CommitsListByShaList(hashes, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.CommitsListByShaList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hashes** | [**List&lt;string&gt;**](string.md)| A collection of commit SHAs comma-delimited | 
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
<a name="fileassetscreate"></a>
# **FileAssetsCreate**
> Object FileAssetsCreate (string ownerName, string appName, Object body = null)



Create a new asset to upload a file

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class FileAssetsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var body = new Object(); // Object |  (optional) 

            try
            {
                Object result = apiInstance.FileAssetsCreate(ownerName, appName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.FileAssetsCreate: " + e.Message );
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
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="repositorieslist"></a>
# **RepositoriesList**
> List<InlineResponse20031> RepositoriesList (string sourceHost, string ownerName, string appName, string vstsAccountName = null, string vstsProjectId = null, string serviceConnectionId = null, string form = null)



Gets the repositories available from the source code host

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class RepositoriesListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var sourceHost = sourceHost_example;  // string | The source host
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var vstsAccountName = vstsAccountName_example;  // string | Filter repositories only for specified account and project, \"vstsProjectId\" is required (optional) 
            var vstsProjectId = vstsProjectId_example;  // string | Filter repositories only for specified account and project, \"vstsAccountName\" is required (optional) 
            var serviceConnectionId = serviceConnectionId_example;  // string | The id of the service connection (private). Required for GitLab self-hosted repositories (optional) 
            var form = form_example;  // string | The selected form of the object (optional) 

            try
            {
                List&lt;InlineResponse20031&gt; result = apiInstance.RepositoriesList(sourceHost, ownerName, appName, vstsAccountName, vstsProjectId, serviceConnectionId, form);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.RepositoriesList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sourceHost** | **string**| The source host | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **vstsAccountName** | **string**| Filter repositories only for specified account and project, \&quot;vstsProjectId\&quot; is required | [optional] 
 **vstsProjectId** | **string**| Filter repositories only for specified account and project, \&quot;vstsAccountName\&quot; is required | [optional] 
 **serviceConnectionId** | **string**| The id of the service connection (private). Required for GitLab self-hosted repositories | [optional] 
 **form** | **string**| The selected form of the object | [optional] 

### Return type

[**List<InlineResponse20031>**](InlineResponse20031.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="repositoryconfigurationscreateorupdate"></a>
# **RepositoryConfigurationsCreateOrUpdate**
> Object RepositoryConfigurationsCreateOrUpdate (AppNameRepoConfigBody body, string ownerName, string appName)



Configures the repository for build

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class RepositoryConfigurationsCreateOrUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var body = new AppNameRepoConfigBody(); // AppNameRepoConfigBody | The repository information
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.RepositoryConfigurationsCreateOrUpdate(body, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.RepositoryConfigurationsCreateOrUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AppNameRepoConfigBody**](AppNameRepoConfigBody.md)| The repository information | 
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
<a name="repositoryconfigurationsdelete"></a>
# **RepositoryConfigurationsDelete**
> Object RepositoryConfigurationsDelete (string ownerName, string appName)



Removes the configuration for the repository

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class RepositoryConfigurationsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.RepositoryConfigurationsDelete(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.RepositoryConfigurationsDelete: " + e.Message );
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
<a name="repositoryconfigurationslist"></a>
# **RepositoryConfigurationsList**
> List<InlineResponse20032> RepositoryConfigurationsList (string ownerName, string appName, bool? includeInactive = null)



Returns the repository build configuration status of the app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class RepositoryConfigurationsListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BuildApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var includeInactive = true;  // bool? | Include inactive configurations if none are active (optional) 

            try
            {
                List&lt;InlineResponse20032&gt; result = apiInstance.RepositoryConfigurationsList(ownerName, appName, includeInactive);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.RepositoryConfigurationsList: " + e.Message );
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
 **includeInactive** | **bool?**| Include inactive configurations if none are active | [optional] 

### Return type

[**List<InlineResponse20032>**](InlineResponse20032.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
