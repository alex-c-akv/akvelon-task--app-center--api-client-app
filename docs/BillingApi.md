# AppCenterApiClientLib.Api.BillingApi

All URIs are relative to *https://api.appcenter.ms/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BillingAggregatedInformationGetAll**](BillingApi.md#billingaggregatedinformationgetall) | **GET** /v0.1/billing/allAccountsAggregated | 
[**BillingAggregatedInformationGetByApp**](BillingApi.md#billingaggregatedinformationgetbyapp) | **GET** /v0.1/apps/{owner_name}/{app_name}/billing/aggregated | 
[**BillingAggregatedInformationGetForOrg**](BillingApi.md#billingaggregatedinformationgetfororg) | **GET** /v0.1/orgs/{orgName}/billing/aggregated | 

<a name="billingaggregatedinformationgetall"></a>
# **BillingAggregatedInformationGetAll**
> InlineResponse20015 BillingAggregatedInformationGetAll (string service = null, string period = null, bool? showOriginalPlans = null)



Aggregated Billing Information for the requesting user and the organizations in which the user is an admin.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BillingAggregatedInformationGetAllExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BillingApi();
            var service = service_example;  // string | Type of service that should be included in the Billing Information (optional) 
            var period = period_example;  // string | Type of period that should be included in the Billing Information (optional) 
            var showOriginalPlans = true;  // bool? | Controls whether the API should show the original plan when Azure Subscription is not enabled (optional) 

            try
            {
                InlineResponse20015 result = apiInstance.BillingAggregatedInformationGetAll(service, period, showOriginalPlans);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingAggregatedInformationGetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **service** | **string**| Type of service that should be included in the Billing Information | [optional] 
 **period** | **string**| Type of period that should be included in the Billing Information | [optional] 
 **showOriginalPlans** | **bool?**| Controls whether the API should show the original plan when Azure Subscription is not enabled | [optional] 

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="billingaggregatedinformationgetbyapp"></a>
# **BillingAggregatedInformationGetByApp**
> InlineResponse20012 BillingAggregatedInformationGetByApp (string ownerName, string appName, string service = null, string period = null, bool? showOriginalPlans = null)



Aggregated Billing Information for owner of a given app.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BillingAggregatedInformationGetByAppExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BillingApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var service = service_example;  // string | Type of service that should be included in the Billing Information (optional) 
            var period = period_example;  // string | Type of period that should be included in the Billing Information (optional) 
            var showOriginalPlans = true;  // bool? | Controls whether the API should show the original plan when Azure Subscription is not enabled (optional) 

            try
            {
                InlineResponse20012 result = apiInstance.BillingAggregatedInformationGetByApp(ownerName, appName, service, period, showOriginalPlans);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingAggregatedInformationGetByApp: " + e.Message );
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
 **service** | **string**| Type of service that should be included in the Billing Information | [optional] 
 **period** | **string**| Type of period that should be included in the Billing Information | [optional] 
 **showOriginalPlans** | **bool?**| Controls whether the API should show the original plan when Azure Subscription is not enabled | [optional] 

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="billingaggregatedinformationgetfororg"></a>
# **BillingAggregatedInformationGetForOrg**
> InlineResponse20012 BillingAggregatedInformationGetForOrg (string orgName, string service = null, string period = null, bool? showOriginalPlans = null)



Aggregated Billing Information for a given Organization.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class BillingAggregatedInformationGetForOrgExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BillingApi();
            var orgName = orgName_example;  // string | The name of the Organization
            var service = service_example;  // string | Type of service that should be included in the Billing Information (optional) 
            var period = period_example;  // string | Type of period that should be included in the Billing Information (optional) 
            var showOriginalPlans = true;  // bool? | Controls whether the API should show the original plan when Azure Subscription is not enabled (optional) 

            try
            {
                InlineResponse20012 result = apiInstance.BillingAggregatedInformationGetForOrg(orgName, service, period, showOriginalPlans);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingAggregatedInformationGetForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The name of the Organization | 
 **service** | **string**| Type of service that should be included in the Billing Information | [optional] 
 **period** | **string**| Type of period that should be included in the Billing Information | [optional] 
 **showOriginalPlans** | **bool?**| Controls whether the API should show the original plan when Azure Subscription is not enabled | [optional] 

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
