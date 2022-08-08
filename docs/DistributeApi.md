# AppCenterApiClientLib.Api.DistributeApi

All URIs are relative to *https://api.appcenter.ms/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppleMappingCreate**](DistributeApi.md#applemappingcreate) | **POST** /v0.1/apps/{owner_name}/{app_name}/apple_mapping | 
[**AppleMappingDelete**](DistributeApi.md#applemappingdelete) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/apple_mapping | 
[**AppleMappingGet**](DistributeApi.md#applemappingget) | **GET** /v0.1/apps/{owner_name}/{app_name}/apple_mapping | 
[**AppleMappingTestFlightGroups**](DistributeApi.md#applemappingtestflightgroups) | **GET** /v0.1/apps/{owner_name}/{app_name}/apple_test_flight_groups | 
[**DevicesDeviceDetails**](DistributeApi.md#devicesdevicedetails) | **GET** /v0.1/user/devices/{device_udid} | 
[**DevicesGetReleaseUpdateDevicesStatus**](DistributeApi.md#devicesgetreleaseupdatedevicesstatus) | **GET** /v0.1/apps/{owner_name}/{app_name}/releases/{release_id}/update_devices/{resign_id} | 
[**DevicesList**](DistributeApi.md#deviceslist) | **GET** /v0.1/apps/{owner_name}/{app_name}/distribution_groups/{distribution_group_name}/devices | 
[**DevicesListCsvFormat**](DistributeApi.md#deviceslistcsvformat) | **GET** /v0.1/apps/{owner_name}/{app_name}/distribution_groups/{distribution_group_name}/devices/download_devices_list | 
[**DevicesRegisterUserForDevice**](DistributeApi.md#devicesregisteruserfordevice) | **POST** /v0.1/users/{user_id}/devices/register | 
[**DevicesRemoveUserDevice**](DistributeApi.md#devicesremoveuserdevice) | **DELETE** /v0.1/user/devices/{device_udid} | 
[**DevicesUserDevicesList**](DistributeApi.md#devicesuserdeviceslist) | **GET** /v0.1/user/devices | 
[**DistibutionReleasesInstallAnalytics**](DistributeApi.md#distibutionreleasesinstallanalytics) | **POST** /v0.1/public/apps/{owner_name}/{app_name}/install_analytics | 
[**ProvisioningProfile**](DistributeApi.md#provisioningprofile) | **GET** /v0.1/apps/{owner_name}/{app_name}/releases/{release_id}/provisioning_profile | 
[**ReleasesAddDistributionGroup**](DistributeApi.md#releasesadddistributiongroup) | **POST** /v0.1/apps/{owner_name}/{app_name}/releases/{release_id}/groups | 
[**ReleasesAddStore**](DistributeApi.md#releasesaddstore) | **POST** /v0.1/apps/{owner_name}/{app_name}/releases/{release_id}/stores | 
[**ReleasesAddTesters**](DistributeApi.md#releasesaddtesters) | **POST** /v0.1/apps/{owner_name}/{app_name}/releases/{release_id}/testers | 
[**ReleasesAvailableToTester**](DistributeApi.md#releasesavailabletotester) | **GET** /v0.1/apps/{owner_name}/{app_name}/releases/filter_by_tester | 
[**ReleasesCreateReleaseUpload**](DistributeApi.md#releasescreatereleaseupload) | **POST** /v0.1/apps/{owner_name}/{app_name}/uploads/releases | 
[**ReleasesDelete**](DistributeApi.md#releasesdelete) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/releases/{release_id} | 
[**ReleasesDeleteDistributionGroup**](DistributeApi.md#releasesdeletedistributiongroup) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/releases/{release_id}/groups/{group_id} | 
[**ReleasesDeleteDistributionStore**](DistributeApi.md#releasesdeletedistributionstore) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/releases/{release_id}/stores/{store_id} | 
[**ReleasesDeleteDistributionTester**](DistributeApi.md#releasesdeletedistributiontester) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/releases/{release_id}/testers/{tester_id} | 
[**ReleasesDeleteTesterFromDestinations**](DistributeApi.md#releasesdeletetesterfromdestinations) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/testers/{tester_id} | 
[**ReleasesDeleteWithDistributionGroupId**](DistributeApi.md#releasesdeletewithdistributiongroupid) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/distribution_groups/{distribution_group_name}/releases/{release_id} | 
[**ReleasesGetIosManifest**](DistributeApi.md#releasesgetiosmanifest) | **GET** /v0.1/public/apps/{app_id}/releases/{release_id}/ios_manifest | 
[**ReleasesGetLatestByDistributionGroup**](DistributeApi.md#releasesgetlatestbydistributiongroup) | **GET** /v0.1/apps/{owner_name}/{app_name}/distribution_groups/{distribution_group_name}/releases/{release_id} | 
[**ReleasesGetLatestByHash**](DistributeApi.md#releasesgetlatestbyhash) | **GET** /v0.1/sdk/apps/{app_secret}/releases/{release_hash} | 
[**ReleasesGetLatestByPublicDistributionGroup**](DistributeApi.md#releasesgetlatestbypublicdistributiongroup) | **GET** /v0.1/public/sdk/apps/{app_secret}/distribution_groups/{distribution_group_id}/releases/latest | 
[**ReleasesGetLatestByUser**](DistributeApi.md#releasesgetlatestbyuser) | **GET** /v0.1/apps/{owner_name}/{app_name}/releases/{release_id} | 
[**ReleasesGetLatestPrivateRelease**](DistributeApi.md#releasesgetlatestprivaterelease) | **GET** /v0.1/sdk/apps/{app_secret}/releases/private/latest | 
[**ReleasesGetLatestPublicRelease**](DistributeApi.md#releasesgetlatestpublicrelease) | **GET** /v0.1/public/sdk/apps/{app_secret}/releases/latest | 
[**ReleasesGetPublicGroupsForReleaseByHash**](DistributeApi.md#releasesgetpublicgroupsforreleasebyhash) | **GET** /v0.1/public/sdk/apps/{app_secret}/releases/{release_hash}/public_distribution_groups | 
[**ReleasesGetReleaseUploadStatus**](DistributeApi.md#releasesgetreleaseuploadstatus) | **GET** /v0.1/apps/{owner_name}/{app_name}/uploads/releases/{upload_id} | 
[**ReleasesGetSparkleFeed**](DistributeApi.md#releasesgetsparklefeed) | **GET** /v0.1/public/sparkle/apps/{app_secret} | 
[**ReleasesList**](DistributeApi.md#releaseslist) | **GET** /v0.1/apps/{owner_name}/{app_name}/releases | 
[**ReleasesListByDistributionGroup**](DistributeApi.md#releaseslistbydistributiongroup) | **GET** /v0.1/apps/{owner_name}/{app_name}/distribution_groups/{distribution_group_name}/releases | 
[**ReleasesListLatest**](DistributeApi.md#releaseslistlatest) | **GET** /v0.1/apps/{owner_name}/{app_name}/recent_releases | 
[**ReleasesPutDistributionGroup**](DistributeApi.md#releasesputdistributiongroup) | **PUT** /v0.1/apps/{owner_name}/{app_name}/releases/{release_id}/groups/{group_id} | 
[**ReleasesPutDistributionTester**](DistributeApi.md#releasesputdistributiontester) | **PUT** /v0.1/apps/{owner_name}/{app_name}/releases/{release_id}/testers/{tester_id} | 
[**ReleasesUpdate**](DistributeApi.md#releasesupdate) | **PATCH** /v0.1/apps/{owner_name}/{app_name}/releases/{release_id} | 
[**ReleasesUpdateDetails**](DistributeApi.md#releasesupdatedetails) | **PUT** /v0.1/apps/{owner_name}/{app_name}/releases/{release_id} | 
[**ReleasesUpdateReleaseUploadStatus**](DistributeApi.md#releasesupdatereleaseuploadstatus) | **PATCH** /v0.1/apps/{owner_name}/{app_name}/uploads/releases/{upload_id} | 
[**StoreNotificationsGetNotificationByAppId**](DistributeApi.md#storenotificationsgetnotificationbyappid) | **GET** /v0.1/apps/{owner_name}/{app_name}/store_service_status | 
[**StoreReleasePublishLogsGet**](DistributeApi.md#storereleasepublishlogsget) | **GET** /v0.1/apps/{owner_name}/{app_name}/distribution_stores/{store_name}/releases/{release_id}/publish_logs | 
[**StoreReleasesDelete**](DistributeApi.md#storereleasesdelete) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/distribution_stores/{store_name}/releases/{release_id} | 
[**StoreReleasesGet**](DistributeApi.md#storereleasesget) | **GET** /v0.1/apps/{owner_name}/{app_name}/distribution_stores/{store_name}/releases/{release_id} | 
[**StoreReleasesGetLatest**](DistributeApi.md#storereleasesgetlatest) | **GET** /v0.1/apps/{owner_name}/{app_name}/distribution_stores/{store_name}/latest_release | 
[**StoreReleasesGetPublishError**](DistributeApi.md#storereleasesgetpublisherror) | **GET** /v0.1/apps/{owner_name}/{app_name}/distribution_stores/{store_name}/releases/{release_id}/publish_error_details | 
[**StoreReleasesGetRealTimeStatusByReleaseId**](DistributeApi.md#storereleasesgetrealtimestatusbyreleaseid) | **GET** /v0.1/apps/{owner_name}/{app_name}/distribution_stores/{store_name}/releases/{release_id}/realtimestatus | 
[**StoreReleasesList**](DistributeApi.md#storereleaseslist) | **GET** /v0.1/apps/{owner_name}/{app_name}/distribution_stores/{store_name}/releases | 
[**StoresCreate**](DistributeApi.md#storescreate) | **POST** /v0.1/apps/{owner_name}/{app_name}/distribution_stores | 
[**StoresDelete**](DistributeApi.md#storesdelete) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/distribution_stores/{store_name} | 
[**StoresGet**](DistributeApi.md#storesget) | **GET** /v0.1/apps/{owner_name}/{app_name}/distribution_stores/{store_name} | 
[**StoresList**](DistributeApi.md#storeslist) | **GET** /v0.1/apps/{owner_name}/{app_name}/distribution_stores | 
[**StoresPatch**](DistributeApi.md#storespatch) | **PATCH** /v0.1/apps/{owner_name}/{app_name}/distribution_stores/{store_name} | 

<a name="applemappingcreate"></a>
# **AppleMappingCreate**
> Object AppleMappingCreate (AppNameAppleMappingBody body, string ownerName, string appName)



Create a mapping for an existing app in apple store for the specified application.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppleMappingCreateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var body = new AppNameAppleMappingBody(); // AppNameAppleMappingBody | The apple app mapping object
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.AppleMappingCreate(body, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.AppleMappingCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AppNameAppleMappingBody**](AppNameAppleMappingBody.md)| The apple app mapping object | 
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
<a name="applemappingdelete"></a>
# **AppleMappingDelete**
> void AppleMappingDelete (string ownerName, string appName, string body = null)



Delete mapping of apple app to an existing app in apple store.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppleMappingDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var body = new string(); // string |  (optional) 

            try
            {
                apiInstance.AppleMappingDelete(ownerName, appName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.AppleMappingDelete: " + e.Message );
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
 **body** | [**string**](string.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="applemappingget"></a>
# **AppleMappingGet**
> Object AppleMappingGet (string ownerName, string appName)



Get mapping of apple app to an existing app in apple store.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppleMappingGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.AppleMappingGet(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.AppleMappingGet: " + e.Message );
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
<a name="applemappingtestflightgroups"></a>
# **AppleMappingTestFlightGroups**
> List<InlineResponse20074> AppleMappingTestFlightGroups (string ownerName, string appName)



Fetch all apple test flight groups

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppleMappingTestFlightGroupsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse20074&gt; result = apiInstance.AppleMappingTestFlightGroups(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.AppleMappingTestFlightGroups: " + e.Message );
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

[**List<InlineResponse20074>**](InlineResponse20074.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="devicesdevicedetails"></a>
# **DevicesDeviceDetails**
> Object DevicesDeviceDetails (string deviceUdid)



Returns the device details.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DevicesDeviceDetailsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var deviceUdid = deviceUdid_example;  // string | The UDID of the device

            try
            {
                Object result = apiInstance.DevicesDeviceDetails(deviceUdid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.DevicesDeviceDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceUdid** | **string**| The UDID of the device | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="devicesgetreleaseupdatedevicesstatus"></a>
# **DevicesGetReleaseUpdateDevicesStatus**
> Object DevicesGetReleaseUpdateDevicesStatus (string releaseId, string resignId, string ownerName, string appName, bool? includeProvisioningProfile = null)



Returns the resign status to the caller

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DevicesGetReleaseUpdateDevicesStatusExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var releaseId = releaseId_example;  // string | The ID of the release.
            var resignId = resignId_example;  // string | The ID of the resign operation.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var includeProvisioningProfile = true;  // bool? | A boolean value that indicates if the provisioning profile should be return in addition to the status. When set to true, the provisioning profile will be returned only when status is 'complete' or 'preparing_for_testers'. (optional) 

            try
            {
                Object result = apiInstance.DevicesGetReleaseUpdateDevicesStatus(releaseId, resignId, ownerName, appName, includeProvisioningProfile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.DevicesGetReleaseUpdateDevicesStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **releaseId** | **string**| The ID of the release. | 
 **resignId** | **string**| The ID of the resign operation. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **includeProvisioningProfile** | **bool?**| A boolean value that indicates if the provisioning profile should be return in addition to the status. When set to true, the provisioning profile will be returned only when status is &#x27;complete&#x27; or &#x27;preparing_for_testers&#x27;. | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deviceslist"></a>
# **DevicesList**
> List<InlineResponse2003> DevicesList (string distributionGroupName, string ownerName, string appName, decimal? releaseId = null)



Returns all devices associated with the given distribution group

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DevicesListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var releaseId = 1.2;  // decimal? | when provided, gets the provisioning state of the devices owned by users of this distribution group when compared to the provided release. (optional) 

            try
            {
                List&lt;InlineResponse2003&gt; result = apiInstance.DevicesList(distributionGroupName, ownerName, appName, releaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.DevicesList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **distributionGroupName** | **string**| The name of the distribution group. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **releaseId** | **decimal?**| when provided, gets the provisioning state of the devices owned by users of this distribution group when compared to the provided release. | [optional] 

### Return type

[**List<InlineResponse2003>**](InlineResponse2003.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deviceslistcsvformat"></a>
# **DevicesListCsvFormat**
> void DevicesListCsvFormat (string distributionGroupName, string ownerName, string appName, bool? unprovisionedOnly = null, List<string> udids = null)



Returns all devices associated with the given distribution group.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DevicesListCsvFormatExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var unprovisionedOnly = true;  // bool? | when true, filters out provisioned devices (optional)  (default to false)
            var udids = new List<string>(); // List<string> | multiple UDIDs which should be part of the resulting CSV. (optional) 

            try
            {
                apiInstance.DevicesListCsvFormat(distributionGroupName, ownerName, appName, unprovisionedOnly, udids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.DevicesListCsvFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **distributionGroupName** | **string**| The name of the distribution group. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **unprovisionedOnly** | **bool?**| when true, filters out provisioned devices | [optional] [default to false]
 **udids** | [**List&lt;string&gt;**](string.md)| multiple UDIDs which should be part of the resulting CSV. | [optional] 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="devicesregisteruserfordevice"></a>
# **DevicesRegisterUserForDevice**
> Object DevicesRegisterUserForDevice (DevicesRegisterBody body, string userId)



Registers a user for an existing device

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DevicesRegisterUserForDeviceExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var body = new DevicesRegisterBody(); // DevicesRegisterBody | The device info.
            var userId = userId_example;  // string | The ID of the user

            try
            {
                Object result = apiInstance.DevicesRegisterUserForDevice(body, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.DevicesRegisterUserForDevice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DevicesRegisterBody**](DevicesRegisterBody.md)| The device info. | 
 **userId** | **string**| The ID of the user | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="devicesremoveuserdevice"></a>
# **DevicesRemoveUserDevice**
> void DevicesRemoveUserDevice (string deviceUdid)



Removes an existing device from a user

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DevicesRemoveUserDeviceExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var deviceUdid = deviceUdid_example;  // string | The UDID of the device

            try
            {
                apiInstance.DevicesRemoveUserDevice(deviceUdid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.DevicesRemoveUserDevice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceUdid** | **string**| The UDID of the device | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="devicesuserdeviceslist"></a>
# **DevicesUserDevicesList**
> List<InlineResponse2003> DevicesUserDevicesList ()



Returns all devices associated with the given user.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DevicesUserDevicesListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();

            try
            {
                List&lt;InlineResponse2003&gt; result = apiInstance.DevicesUserDevicesList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.DevicesUserDevicesList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InlineResponse2003>**](InlineResponse2003.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distibutionreleasesinstallanalytics"></a>
# **DistibutionReleasesInstallAnalytics**
> void DistibutionReleasesInstallAnalytics (AppNameInstallAnalyticsBody body, string ownerName, string appName)



Notify download(s) for the provided distribution release(s).

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistibutionReleasesInstallAnalyticsExample
    {
        public void main()
        {
            var apiInstance = new DistributeApi();
            var body = new AppNameInstallAnalyticsBody(); // AppNameInstallAnalyticsBody | The install analytics request payload
            var ownerName = ownerName_example;  // string | The name of the app owner
            var appName = appName_example;  // string | The name of the app

            try
            {
                apiInstance.DistibutionReleasesInstallAnalytics(body, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.DistibutionReleasesInstallAnalytics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AppNameInstallAnalyticsBody**](AppNameInstallAnalyticsBody.md)| The install analytics request payload | 
 **ownerName** | **string**| The name of the app owner | 
 **appName** | **string**| The name of the app | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="provisioningprofile"></a>
# **ProvisioningProfile**
> ProvisioningProfileResponse ProvisioningProfile (int? releaseId, string ownerName, string appName)



Return information about the provisioning profile. Only available for iOS.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ProvisioningProfileExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var releaseId = 56;  // int? | The release_id
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                ProvisioningProfileResponse result = apiInstance.ProvisioningProfile(releaseId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ProvisioningProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **releaseId** | **int?**| The release_id | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**ProvisioningProfileResponse**](ProvisioningProfileResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releasesadddistributiongroup"></a>
# **ReleasesAddDistributionGroup**
> InlineResponse2011 ReleasesAddDistributionGroup (ReleaseIdGroupsBody body, int? releaseId, string ownerName, string appName)



Distributes a release to a group

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesAddDistributionGroupExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var body = new ReleaseIdGroupsBody(); // ReleaseIdGroupsBody | The release information.
            var releaseId = 56;  // int? | The ID of the release
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse2011 result = apiInstance.ReleasesAddDistributionGroup(body, releaseId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesAddDistributionGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReleaseIdGroupsBody**](ReleaseIdGroupsBody.md)| The release information. | 
 **releaseId** | **int?**| The ID of the release | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse2011**](InlineResponse2011.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releasesaddstore"></a>
# **ReleasesAddStore**
> InlineResponse2012 ReleasesAddStore (ReleaseIdStoresBody body, int? releaseId, string ownerName, string appName)



Distributes a release to a store

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesAddStoreExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var body = new ReleaseIdStoresBody(); // ReleaseIdStoresBody | The release information.
            var releaseId = 56;  // int? | The ID of the release
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse2012 result = apiInstance.ReleasesAddStore(body, releaseId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesAddStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReleaseIdStoresBody**](ReleaseIdStoresBody.md)| The release information. | 
 **releaseId** | **int?**| The ID of the release | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse2012**](InlineResponse2012.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releasesaddtesters"></a>
# **ReleasesAddTesters**
> InlineResponse2011 ReleasesAddTesters (ReleaseIdTestersBody body, int? releaseId, string ownerName, string appName)



Distributes a release to a user

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesAddTestersExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var body = new ReleaseIdTestersBody(); // ReleaseIdTestersBody | The release information.
            var releaseId = 56;  // int? | The ID of the release
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                InlineResponse2011 result = apiInstance.ReleasesAddTesters(body, releaseId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesAddTesters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReleaseIdTestersBody**](ReleaseIdTestersBody.md)| The release information. | 
 **releaseId** | **int?**| The ID of the release | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**InlineResponse2011**](InlineResponse2011.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releasesavailabletotester"></a>
# **ReleasesAvailableToTester**
> List<InlineResponse20033> ReleasesAvailableToTester (string ownerName, string appName, bool? publishedOnly = null)



Return detailed information about releases avaiable to a tester.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesAvailableToTesterExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var publishedOnly = true;  // bool? | when *true*, filters out releases that were uploaded but were never distributed. Releases that under deleted distribution groups will not be filtered out. (optional) 

            try
            {
                List&lt;InlineResponse20033&gt; result = apiInstance.ReleasesAvailableToTester(ownerName, appName, publishedOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesAvailableToTester: " + e.Message );
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
 **publishedOnly** | **bool?**| when *true*, filters out releases that were uploaded but were never distributed. Releases that under deleted distribution groups will not be filtered out. | [optional] 

### Return type

[**List<InlineResponse20033>**](InlineResponse20033.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releasescreatereleaseupload"></a>
# **ReleasesCreateReleaseUpload**
> Object ReleasesCreateReleaseUpload (string ownerName, string appName, UploadsReleasesBody body = null)



Initiate a new release upload. This API is part of multi-step upload process.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesCreateReleaseUploadExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var body = new UploadsReleasesBody(); // UploadsReleasesBody | Optional parameters to create releases with user defined metadata (optional) 

            try
            {
                Object result = apiInstance.ReleasesCreateReleaseUpload(ownerName, appName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesCreateReleaseUpload: " + e.Message );
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
 **body** | [**UploadsReleasesBody**](UploadsReleasesBody.md)| Optional parameters to create releases with user defined metadata | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releasesdelete"></a>
# **ReleasesDelete**
> void ReleasesDelete (int? releaseId, string ownerName, string appName)



Deletes a release.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var releaseId = 56;  // int? | The ID of the release
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.ReleasesDelete(releaseId, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **releaseId** | **int?**| The ID of the release | 
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
<a name="releasesdeletedistributiongroup"></a>
# **ReleasesDeleteDistributionGroup**
> void ReleasesDeleteDistributionGroup (int? releaseId, string groupId, string ownerName, string appName)



Delete the given distribution group from the release

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesDeleteDistributionGroupExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var releaseId = 56;  // int? | The ID of the release
            var groupId = groupId_example;  // string | The id of the distribution group
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.ReleasesDeleteDistributionGroup(releaseId, groupId, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesDeleteDistributionGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **releaseId** | **int?**| The ID of the release | 
 **groupId** | **string**| The id of the distribution group | 
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
<a name="releasesdeletedistributionstore"></a>
# **ReleasesDeleteDistributionStore**
> void ReleasesDeleteDistributionStore (int? releaseId, string storeId, string ownerName, string appName)



Delete the given distribution store from the release

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesDeleteDistributionStoreExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var releaseId = 56;  // int? | The ID of the release
            var storeId = storeId_example;  // string | The id of the distribution store
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.ReleasesDeleteDistributionStore(releaseId, storeId, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesDeleteDistributionStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **releaseId** | **int?**| The ID of the release | 
 **storeId** | **string**| The id of the distribution store | 
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
<a name="releasesdeletedistributiontester"></a>
# **ReleasesDeleteDistributionTester**
> void ReleasesDeleteDistributionTester (int? releaseId, string testerId, string ownerName, string appName)



Delete the given tester from the release

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesDeleteDistributionTesterExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var releaseId = 56;  // int? | The ID of the release
            var testerId = testerId_example;  // string | The id of the tester
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.ReleasesDeleteDistributionTester(releaseId, testerId, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesDeleteDistributionTester: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **releaseId** | **int?**| The ID of the release | 
 **testerId** | **string**| The id of the tester | 
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
<a name="releasesdeletetesterfromdestinations"></a>
# **ReleasesDeleteTesterFromDestinations**
> void ReleasesDeleteTesterFromDestinations (string testerId, string ownerName, string appName)



Delete the given tester from the all releases

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesDeleteTesterFromDestinationsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var testerId = testerId_example;  // string | The id of the tester
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.ReleasesDeleteTesterFromDestinations(testerId, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesDeleteTesterFromDestinations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **testerId** | **string**| The id of the tester | 
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
<a name="releasesdeletewithdistributiongroupid"></a>
# **ReleasesDeleteWithDistributionGroupId**
> void ReleasesDeleteWithDistributionGroupId (string ownerName, string appName, string distributionGroupName, int? releaseId)



Deletes a release with id 'release_id' in a given distribution group.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesDeleteWithDistributionGroupIdExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var ownerName = ownerName_example;  // string | The name of the app owner
            var appName = appName_example;  // string | The name of the app
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group.
            var releaseId = 56;  // int? | The ID identifying the unique release.

            try
            {
                apiInstance.ReleasesDeleteWithDistributionGroupId(ownerName, appName, distributionGroupName, releaseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesDeleteWithDistributionGroupId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ownerName** | **string**| The name of the app owner | 
 **appName** | **string**| The name of the app | 
 **distributionGroupName** | **string**| The name of the distribution group. | 
 **releaseId** | **int?**| The ID identifying the unique release. | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releasesgetiosmanifest"></a>
# **ReleasesGetIosManifest**
> void ReleasesGetIosManifest (string appId, int? releaseId, string token)



Returns the manifest.plist in XML format for installing the release on a device. Only available for iOS.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesGetIosManifestExample
    {
        public void main()
        {
            var apiInstance = new DistributeApi();
            var appId = appId_example;  // string | The ID of the application
            var releaseId = 56;  // int? | The release_id
            var token = token_example;  // string | A hash that authorizes the download if it matches the release info.

            try
            {
                apiInstance.ReleasesGetIosManifest(appId, releaseId, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesGetIosManifest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| The ID of the application | 
 **releaseId** | **int?**| The release_id | 
 **token** | **string**| A hash that authorizes the download if it matches the release info. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releasesgetlatestbydistributiongroup"></a>
# **ReleasesGetLatestByDistributionGroup**
> Object ReleasesGetLatestByDistributionGroup (string ownerName, string appName, string distributionGroupName, string releaseId)



Return detailed information about a distributed release in a given distribution group.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesGetLatestByDistributionGroupExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var ownerName = ownerName_example;  // string | The name of the app owner
            var appName = appName_example;  // string | The name of the app
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group.
            var releaseId = releaseId_example;  // string | Also supports the constant `latest`, which will return the latest release in the distribution group.

            try
            {
                Object result = apiInstance.ReleasesGetLatestByDistributionGroup(ownerName, appName, distributionGroupName, releaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesGetLatestByDistributionGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ownerName** | **string**| The name of the app owner | 
 **appName** | **string**| The name of the app | 
 **distributionGroupName** | **string**| The name of the distribution group. | 
 **releaseId** | **string**| Also supports the constant &#x60;latest&#x60;, which will return the latest release in the distribution group. | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releasesgetlatestbyhash"></a>
# **ReleasesGetLatestByHash**
> Object ReleasesGetLatestByHash (string appSecret, string releaseHash, string udid = null)



If 'latest' is not specified then it will return the specified release if it's enabled. If 'latest' is specified, regardless of whether a release hash is provided, the latest enabled release is returned.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesGetLatestByHashExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var appSecret = appSecret_example;  // string | The secret of the target application
            var releaseHash = releaseHash_example;  // string | The hash of the release or 'latest' to get the latest release from all the distribution groups assigned to the current user.
            var udid = udid_example;  // string | When passing `udid` in the query string, a provisioning check for the given device ID will be done. Will be ignored for non-iOS platforms. (optional) 

            try
            {
                Object result = apiInstance.ReleasesGetLatestByHash(appSecret, releaseHash, udid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesGetLatestByHash: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appSecret** | **string**| The secret of the target application | 
 **releaseHash** | **string**| The hash of the release or &#x27;latest&#x27; to get the latest release from all the distribution groups assigned to the current user. | 
 **udid** | **string**| When passing &#x60;udid&#x60; in the query string, a provisioning check for the given device ID will be done. Will be ignored for non-iOS platforms. | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releasesgetlatestbypublicdistributiongroup"></a>
# **ReleasesGetLatestByPublicDistributionGroup**
> Object ReleasesGetLatestByPublicDistributionGroup (string appSecret, string distributionGroupId)



Get a release with 'latest' for the given public group.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesGetLatestByPublicDistributionGroupExample
    {
        public void main()
        {
            var apiInstance = new DistributeApi();
            var appSecret = appSecret_example;  // string | The secret of the target application
            var distributionGroupId = distributionGroupId_example;  // string | the id for destination

            try
            {
                Object result = apiInstance.ReleasesGetLatestByPublicDistributionGroup(appSecret, distributionGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesGetLatestByPublicDistributionGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appSecret** | **string**| The secret of the target application | 
 **distributionGroupId** | **string**| the id for destination | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releasesgetlatestbyuser"></a>
# **ReleasesGetLatestByUser**
> Object ReleasesGetLatestByUser (string releaseId, string ownerName, string appName, string udid = null, bool? isInstallPage = null)



Get a release with id `release_id`. If `release_id` is `latest`, return the latest release that was distributed to the current user (from all the distribution groups).

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesGetLatestByUserExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var releaseId = releaseId_example;  // string | The ID of the release, or `latest` to get the latest release from all the distribution groups assigned to the current user.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var udid = udid_example;  // string | when supplied, this call will also check if the given UDID is provisioned. Will be ignored for non-iOS platforms. The value will be returned in the property is_udid_provisioned. (optional) 
            var isInstallPage = true;  // bool? | The check if the request is from Install page (optional) 

            try
            {
                Object result = apiInstance.ReleasesGetLatestByUser(releaseId, ownerName, appName, udid, isInstallPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesGetLatestByUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **releaseId** | **string**| The ID of the release, or &#x60;latest&#x60; to get the latest release from all the distribution groups assigned to the current user. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **udid** | **string**| when supplied, this call will also check if the given UDID is provisioned. Will be ignored for non-iOS platforms. The value will be returned in the property is_udid_provisioned. | [optional] 
 **isInstallPage** | **bool?**| The check if the request is from Install page | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releasesgetlatestprivaterelease"></a>
# **ReleasesGetLatestPrivateRelease**
> Object ReleasesGetLatestPrivateRelease (string appSecret, string udid = null)



Get the latest release distributed to a private group the given user is a member of for the given app.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesGetLatestPrivateReleaseExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var appSecret = appSecret_example;  // string | The secret of the target application
            var udid = udid_example;  // string | When passing `udid` in the query string, a provisioning check for the given device ID will be done. Will be ignored for non-iOS platforms. (optional) 

            try
            {
                Object result = apiInstance.ReleasesGetLatestPrivateRelease(appSecret, udid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesGetLatestPrivateRelease: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appSecret** | **string**| The secret of the target application | 
 **udid** | **string**| When passing &#x60;udid&#x60; in the query string, a provisioning check for the given device ID will be done. Will be ignored for non-iOS platforms. | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releasesgetlatestpublicrelease"></a>
# **ReleasesGetLatestPublicRelease**
> Object ReleasesGetLatestPublicRelease (string appSecret)



Get the latest public release for the given app.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesGetLatestPublicReleaseExample
    {
        public void main()
        {
            var apiInstance = new DistributeApi();
            var appSecret = appSecret_example;  // string | The secret of the target application

            try
            {
                Object result = apiInstance.ReleasesGetLatestPublicRelease(appSecret);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesGetLatestPublicRelease: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appSecret** | **string**| The secret of the target application | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releasesgetpublicgroupsforreleasebyhash"></a>
# **ReleasesGetPublicGroupsForReleaseByHash**
> List<InlineResponse2004> ReleasesGetPublicGroupsForReleaseByHash (string appSecret, string releaseHash)



Get all public distribution groups that a given release has been distributed to

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesGetPublicGroupsForReleaseByHashExample
    {
        public void main()
        {
            var apiInstance = new DistributeApi();
            var appSecret = appSecret_example;  // string | The secret of the target application
            var releaseHash = releaseHash_example;  // string | The hash of the release

            try
            {
                List&lt;InlineResponse2004&gt; result = apiInstance.ReleasesGetPublicGroupsForReleaseByHash(appSecret, releaseHash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesGetPublicGroupsForReleaseByHash: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appSecret** | **string**| The secret of the target application | 
 **releaseHash** | **string**| The hash of the release | 

### Return type

[**List<InlineResponse2004>**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releasesgetreleaseuploadstatus"></a>
# **ReleasesGetReleaseUploadStatus**
> Object ReleasesGetReleaseUploadStatus (Guid? uploadId, string ownerName, string appName)



Get the current status of the release upload.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesGetReleaseUploadStatusExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var uploadId = new Guid?(); // Guid? | The ID of the release upload
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.ReleasesGetReleaseUploadStatus(uploadId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesGetReleaseUploadStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uploadId** | [**Guid?**](Guid?.md)| The ID of the release upload | 
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
<a name="releasesgetsparklefeed"></a>
# **ReleasesGetSparkleFeed**
> void ReleasesGetSparkleFeed (string appSecret)



Gets the sparkle feed of the releases that are distributed to all the public distribution groups.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesGetSparkleFeedExample
    {
        public void main()
        {
            var apiInstance = new DistributeApi();
            var appSecret = appSecret_example;  // string | The secret of the application.

            try
            {
                apiInstance.ReleasesGetSparkleFeed(appSecret);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesGetSparkleFeed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appSecret** | **string**| The secret of the application. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releaseslist"></a>
# **ReleasesList**
> List<InlineResponse20034> ReleasesList (string ownerName, string appName, bool? publishedOnly = null, string scope = null)



Return basic information about releases.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var publishedOnly = true;  // bool? | When *true*, filters out releases that were uploaded but were never distributed. Releases that under deleted distribution groups will not be filtered out. (optional) 
            var scope = scope_example;  // string | When the scope is 'tester', only includes releases that have been distributed to groups that the user belongs to. (optional) 

            try
            {
                List&lt;InlineResponse20034&gt; result = apiInstance.ReleasesList(ownerName, appName, publishedOnly, scope);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesList: " + e.Message );
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
 **publishedOnly** | **bool?**| When *true*, filters out releases that were uploaded but were never distributed. Releases that under deleted distribution groups will not be filtered out. | [optional] 
 **scope** | **string**| When the scope is &#x27;tester&#x27;, only includes releases that have been distributed to groups that the user belongs to. | [optional] 

### Return type

[**List<InlineResponse20034>**](InlineResponse20034.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releaseslistbydistributiongroup"></a>
# **ReleasesListByDistributionGroup**
> List<InlineResponse20059> ReleasesListByDistributionGroup (string distributionGroupName, string ownerName, string appName)



Return basic information about distributed releases in a given distribution group.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesListByDistributionGroupExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse20059&gt; result = apiInstance.ReleasesListByDistributionGroup(distributionGroupName, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesListByDistributionGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **distributionGroupName** | **string**| The name of the distribution group. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**List<InlineResponse20059>**](InlineResponse20059.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releaseslistlatest"></a>
# **ReleasesListLatest**
> List<InlineResponse20034> ReleasesListLatest (string ownerName, string appName)



Get the latest release from every distribution group associated with an application.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesListLatestExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse20034&gt; result = apiInstance.ReleasesListLatest(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesListLatest: " + e.Message );
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

[**List<InlineResponse20034>**](InlineResponse20034.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releasesputdistributiongroup"></a>
# **ReleasesPutDistributionGroup**
> void ReleasesPutDistributionGroup (int? releaseId, Guid? groupId, string ownerName, string appName, GroupsGroupIdBody body = null)



Update details about the specified distribution group associated with the release

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesPutDistributionGroupExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var releaseId = 56;  // int? | The ID of the release
            var groupId = new Guid?(); // Guid? | The id of the releases destination
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var body = new GroupsGroupIdBody(); // GroupsGroupIdBody |  (optional) 

            try
            {
                apiInstance.ReleasesPutDistributionGroup(releaseId, groupId, ownerName, appName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesPutDistributionGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **releaseId** | **int?**| The ID of the release | 
 **groupId** | [**Guid?**](Guid?.md)| The id of the releases destination | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **body** | [**GroupsGroupIdBody**](GroupsGroupIdBody.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releasesputdistributiontester"></a>
# **ReleasesPutDistributionTester**
> void ReleasesPutDistributionTester (int? releaseId, Guid? testerId, string ownerName, string appName, TestersTesterIdBody body = null)



Update details about the specified tester associated with the release

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesPutDistributionTesterExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var releaseId = 56;  // int? | The ID of the release
            var testerId = new Guid?(); // Guid? | The id of the tester
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var body = new TestersTesterIdBody(); // TestersTesterIdBody |  (optional) 

            try
            {
                apiInstance.ReleasesPutDistributionTester(releaseId, testerId, ownerName, appName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesPutDistributionTester: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **releaseId** | **int?**| The ID of the release | 
 **testerId** | [**Guid?**](Guid?.md)| The id of the tester | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **body** | [**TestersTesterIdBody**](TestersTesterIdBody.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releasesupdate"></a>
# **ReleasesUpdate**
> Object ReleasesUpdate (ReleasesReleaseIdBody1 body, int? releaseId, string ownerName, string appName)



Updates a release.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var body = new ReleasesReleaseIdBody1(); // ReleasesReleaseIdBody1 | The release information.
            var releaseId = 56;  // int? | The ID of the release
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.ReleasesUpdate(body, releaseId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReleasesReleaseIdBody1**](ReleasesReleaseIdBody1.md)| The release information. | 
 **releaseId** | **int?**| The ID of the release | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="releasesupdatedetails"></a>
# **ReleasesUpdateDetails**
> Object ReleasesUpdateDetails (ReleasesReleaseIdBody body, int? releaseId, string ownerName, string appName)



Update details of a release.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesUpdateDetailsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var body = new ReleasesReleaseIdBody(); // ReleasesReleaseIdBody | The release information.
            var releaseId = 56;  // int? | The ID of the release
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.ReleasesUpdateDetails(body, releaseId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesUpdateDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReleasesReleaseIdBody**](ReleasesReleaseIdBody.md)| The release information. | 
 **releaseId** | **int?**| The ID of the release | 
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
<a name="releasesupdatereleaseuploadstatus"></a>
# **ReleasesUpdateReleaseUploadStatus**
> Object ReleasesUpdateReleaseUploadStatus (ReleasesUploadIdBody body, Guid? uploadId, string ownerName, string appName, bool? extract = null)



Update the current status of the release upload.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class ReleasesUpdateReleaseUploadStatusExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var body = new ReleasesUploadIdBody(); // ReleasesUploadIdBody | The release upload status information.
            var uploadId = new Guid?(); // Guid? | The ID of the release upload
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var extract = true;  // bool? | A flag that indicates to extract release or not, true by default (optional) 

            try
            {
                Object result = apiInstance.ReleasesUpdateReleaseUploadStatus(body, uploadId, ownerName, appName, extract);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.ReleasesUpdateReleaseUploadStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReleasesUploadIdBody**](ReleasesUploadIdBody.md)| The release upload status information. | 
 **uploadId** | [**Guid?**](Guid?.md)| The ID of the release upload | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **extract** | **bool?**| A flag that indicates to extract release or not, true by default | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="storenotificationsgetnotificationbyappid"></a>
# **StoreNotificationsGetNotificationByAppId**
> Object StoreNotificationsGetNotificationByAppId (string ownerName, string appName)



Application specific store service status

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class StoreNotificationsGetNotificationByAppIdExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.StoreNotificationsGetNotificationByAppId(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.StoreNotificationsGetNotificationByAppId: " + e.Message );
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
<a name="storereleasepublishlogsget"></a>
# **StoreReleasePublishLogsGet**
> void StoreReleasePublishLogsGet (string storeName, string releaseId, string ownerName, string appName)



Returns publish logs for a particular release published to a particular store

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class StoreReleasePublishLogsGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var storeName = storeName_example;  // string | The name of the store
            var releaseId = releaseId_example;  // string | The ID of the realease
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.StoreReleasePublishLogsGet(storeName, releaseId, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.StoreReleasePublishLogsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeName** | **string**| The name of the store | 
 **releaseId** | **string**| The ID of the realease | 
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
<a name="storereleasesdelete"></a>
# **StoreReleasesDelete**
> void StoreReleasesDelete (string storeName, string releaseId, string ownerName, string appName, string body = null)



delete the release with release Id

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class StoreReleasesDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var storeName = storeName_example;  // string | The name of the store
            var releaseId = releaseId_example;  // string | The id of the release
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var body = new string(); // string |  (optional) 

            try
            {
                apiInstance.StoreReleasesDelete(storeName, releaseId, ownerName, appName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.StoreReleasesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeName** | **string**| The name of the store | 
 **releaseId** | **string**| The id of the release | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **body** | [**string**](string.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="storereleasesget"></a>
# **StoreReleasesGet**
> List<InlineResponse20056> StoreReleasesGet (string storeName, string releaseId, string ownerName, string appName)



Return releases published in a store for releaseId and storeId

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class StoreReleasesGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var storeName = storeName_example;  // string | The name of the store
            var releaseId = releaseId_example;  // string | The name of the store
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse20056&gt; result = apiInstance.StoreReleasesGet(storeName, releaseId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.StoreReleasesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeName** | **string**| The name of the store | 
 **releaseId** | **string**| The name of the store | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**List<InlineResponse20056>**](InlineResponse20056.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="storereleasesgetlatest"></a>
# **StoreReleasesGetLatest**
> List<InlineResponse20056> StoreReleasesGetLatest (string storeName, string ownerName, string appName)



Returns the latest release published in a store.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class StoreReleasesGetLatestExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var storeName = storeName_example;  // string | The name of the store
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse20056&gt; result = apiInstance.StoreReleasesGetLatest(storeName, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.StoreReleasesGetLatest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeName** | **string**| The name of the store | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**List<InlineResponse20056>**](InlineResponse20056.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="storereleasesgetpublisherror"></a>
# **StoreReleasesGetPublishError**
> Object StoreReleasesGetPublishError (string storeName, decimal? releaseId, string ownerName, string appName)



Return the Error Details of release which failed in publishing.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class StoreReleasesGetPublishErrorExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var storeName = storeName_example;  // string | The name of the store
            var releaseId = 1.2;  // decimal? | The id of the release
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.StoreReleasesGetPublishError(storeName, releaseId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.StoreReleasesGetPublishError: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeName** | **string**| The name of the store | 
 **releaseId** | **decimal?**| The id of the release | 
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
<a name="storereleasesgetrealtimestatusbyreleaseid"></a>
# **StoreReleasesGetRealTimeStatusByReleaseId**
> Object StoreReleasesGetRealTimeStatusByReleaseId (string storeName, decimal? releaseId, string ownerName, string appName)



Return the Real time Status publishing of release from store.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class StoreReleasesGetRealTimeStatusByReleaseIdExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var storeName = storeName_example;  // string | The name of the store
            var releaseId = 1.2;  // decimal? | The id of the release
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.StoreReleasesGetRealTimeStatusByReleaseId(storeName, releaseId, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.StoreReleasesGetRealTimeStatusByReleaseId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeName** | **string**| The name of the store | 
 **releaseId** | **decimal?**| The id of the release | 
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
<a name="storereleaseslist"></a>
# **StoreReleasesList**
> List<InlineResponse20057> StoreReleasesList (string storeName, string ownerName, string appName)



Return all releases published  in a store

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class StoreReleasesListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var storeName = storeName_example;  // string | The name of the store
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse20057&gt; result = apiInstance.StoreReleasesList(storeName, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.StoreReleasesList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeName** | **string**| The name of the store | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 

### Return type

[**List<InlineResponse20057>**](InlineResponse20057.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="storescreate"></a>
# **StoresCreate**
> Object StoresCreate (AppNameDistributionStoresBody body, string ownerName, string appName)



Create a new external store for the specified application.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class StoresCreateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var body = new AppNameDistributionStoresBody(); // AppNameDistributionStoresBody | The store request
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.StoresCreate(body, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.StoresCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AppNameDistributionStoresBody**](AppNameDistributionStoresBody.md)| The store request | 
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
<a name="storesdelete"></a>
# **StoresDelete**
> void StoresDelete (string storeName, string ownerName, string appName, string body = null)



delete the store based on specific store name.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class StoresDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var storeName = storeName_example;  // string | The name of the store
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var body = new string(); // string |  (optional) 

            try
            {
                apiInstance.StoresDelete(storeName, ownerName, appName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.StoresDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeName** | **string**| The name of the store | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **body** | [**string**](string.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="storesget"></a>
# **StoresGet**
> Object StoresGet (string storeName, string ownerName, string appName)



Return the store details for specified store name.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class StoresGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var storeName = storeName_example;  // string | The name of the store
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.StoresGet(storeName, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.StoresGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeName** | **string**| The name of the store | 
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
<a name="storeslist"></a>
# **StoresList**
> List<InlineResponse20058> StoresList (string ownerName, string appName)



Get all the store details from Storage store table for a particular application.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class StoresListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse20058&gt; result = apiInstance.StoresList(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.StoresList: " + e.Message );
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

[**List<InlineResponse20058>**](InlineResponse20058.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="storespatch"></a>
# **StoresPatch**
> void StoresPatch (DistributionStoresStoreNameBody body, string storeName, string ownerName, string appName)



Update the store.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class StoresPatchExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DistributeApi();
            var body = new DistributionStoresStoreNameBody(); // DistributionStoresStoreNameBody | Store update request
            var storeName = storeName_example;  // string | The name of the store
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.StoresPatch(body, storeName, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributeApi.StoresPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DistributionStoresStoreNameBody**](DistributionStoresStoreNameBody.md)| Store update request | 
 **storeName** | **string**| The name of the store | 
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
