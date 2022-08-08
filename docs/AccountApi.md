# AppCenterApiClientLib.Api.AccountApi

All URIs are relative to *https://api.appcenter.ms/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppApiTokensDelete**](AccountApi.md#appapitokensdelete) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/api_tokens/{api_token_id} | 
[**AppApiTokensList**](AccountApi.md#appapitokenslist) | **GET** /v0.1/apps/{owner_name}/{app_name}/api_tokens | 
[**AppApiTokensNew**](AccountApi.md#appapitokensnew) | **POST** /v0.1/apps/{owner_name}/{app_name}/api_tokens | 
[**AppInvitationsAccept**](AccountApi.md#appinvitationsaccept) | **POST** /v0.1/user/invitations/apps/{invitation_token}/accept | 
[**AppInvitationsCreate**](AccountApi.md#appinvitationscreate) | **POST** /v0.1/apps/{owner_name}/{app_name}/invitations | 
[**AppInvitationsCreateByEmail**](AccountApi.md#appinvitationscreatebyemail) | **POST** /v0.1/apps/{owner_name}/{app_name}/invitations/{user_email} | 
[**AppInvitationsDelete**](AccountApi.md#appinvitationsdelete) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/invitations/{user_email} | 
[**AppInvitationsList**](AccountApi.md#appinvitationslist) | **GET** /v0.1/apps/{owner_name}/{app_name}/invitations | 
[**AppInvitationsReject**](AccountApi.md#appinvitationsreject) | **POST** /v0.1/user/invitations/apps/{invitation_token}/reject | 
[**AppInvitationsUpdatePermissions**](AccountApi.md#appinvitationsupdatepermissions) | **PATCH** /v0.1/apps/{owner_name}/{app_name}/invitations/{user_email} | 
[**AppsCreate**](AccountApi.md#appscreate) | **POST** /v0.1/apps | 
[**AppsCreateForOrg**](AccountApi.md#appscreatefororg) | **POST** /v0.1/orgs/{org_name}/apps | 
[**AppsDelete**](AccountApi.md#appsdelete) | **DELETE** /v0.1/apps/{owner_name}/{app_name} | 
[**AppsDeleteAvatar**](AccountApi.md#appsdeleteavatar) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/avatar | 
[**AppsGet**](AccountApi.md#appsget) | **GET** /v0.1/apps/{owner_name}/{app_name} | 
[**AppsGetForOrgUser**](AccountApi.md#appsgetfororguser) | **GET** /v0.1/orgs/{org_name}/users/{user_name}/apps | 
[**AppsGetTeams**](AccountApi.md#appsgetteams) | **GET** /v0.1/apps/{owner_name}/{app_name}/teams | 
[**AppsList**](AccountApi.md#appslist) | **GET** /v0.1/apps | 
[**AppsListForOrg**](AccountApi.md#appslistfororg) | **GET** /v0.1/orgs/{org_name}/apps | 
[**AppsListTesters**](AccountApi.md#appslisttesters) | **GET** /v0.1/apps/{owner_name}/{app_name}/testers | 
[**AppsRemoveUser**](AccountApi.md#appsremoveuser) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/users/{user_email} | 
[**AppsTransferOwnership**](AccountApi.md#appstransferownership) | **POST** /v0.1/apps/{owner_name}/{app_name}/transfer/{destination_owner_name} | 
[**AppsTransferToOrg**](AccountApi.md#appstransfertoorg) | **POST** /v0.1/apps/{owner_name}/{app_name}/transfer_to_org | 
[**AppsUpdate**](AccountApi.md#appsupdate) | **PATCH** /v0.1/apps/{owner_name}/{app_name} | 
[**AppsUpdateAvatar**](AccountApi.md#appsupdateavatar) | **POST** /v0.1/apps/{owner_name}/{app_name}/avatar | 
[**AppsUpdateUserPermissions**](AccountApi.md#appsupdateuserpermissions) | **PATCH** /v0.1/apps/{owner_name}/{app_name}/users/{user_email} | 
[**AzureSubscriptionDeleteForApp**](AccountApi.md#azuresubscriptiondeleteforapp) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/azure_subscriptions/{azure_subscription_id} | 
[**AzureSubscriptionLinkForApp**](AccountApi.md#azuresubscriptionlinkforapp) | **POST** /v0.1/apps/{owner_name}/{app_name}/azure_subscriptions | 
[**AzureSubscriptionListForApp**](AccountApi.md#azuresubscriptionlistforapp) | **GET** /v0.1/apps/{owner_name}/{app_name}/azure_subscriptions | 
[**AzureSubscriptionListForOrg**](AccountApi.md#azuresubscriptionlistfororg) | **GET** /v0.1/orgs/{org_name}/azure_subscriptions | 
[**AzureSubscriptionListForUser**](AccountApi.md#azuresubscriptionlistforuser) | **GET** /v0.1/azure_subscriptions | 
[**DistributionGroupInvitationsAcceptAll**](AccountApi.md#distributiongroupinvitationsacceptall) | **POST** /v0.1/user/invitations/distribution_groups/accept | 
[**DistributionGroupsAddApps**](AccountApi.md#distributiongroupsaddapps) | **POST** /v0.1/orgs/{org_name}/distribution_groups/{distribution_group_name}/apps | 
[**DistributionGroupsAddUser**](AccountApi.md#distributiongroupsadduser) | **POST** /v0.1/apps/{owner_name}/{app_name}/distribution_groups/{distribution_group_name}/members | 
[**DistributionGroupsAddUsersForOrg**](AccountApi.md#distributiongroupsaddusersfororg) | **POST** /v0.1/orgs/{org_name}/distribution_groups/{distribution_group_name}/members | 
[**DistributionGroupsBulkDeleteApps**](AccountApi.md#distributiongroupsbulkdeleteapps) | **POST** /v0.1/orgs/{org_name}/distribution_groups/{distribution_group_name}/apps/bulk_delete | 
[**DistributionGroupsBulkDeleteUsers**](AccountApi.md#distributiongroupsbulkdeleteusers) | **POST** /v0.1/orgs/{org_name}/distribution_groups/{distribution_group_name}/members/bulk_delete | 
[**DistributionGroupsCreate**](AccountApi.md#distributiongroupscreate) | **POST** /v0.1/apps/{owner_name}/{app_name}/distribution_groups | 
[**DistributionGroupsCreateForOrg**](AccountApi.md#distributiongroupscreatefororg) | **POST** /v0.1/orgs/{org_name}/distribution_groups | 
[**DistributionGroupsDelete**](AccountApi.md#distributiongroupsdelete) | **DELETE** /v0.1/apps/{owner_name}/{app_name}/distribution_groups/{distribution_group_name} | 
[**DistributionGroupsDeleteForOrg**](AccountApi.md#distributiongroupsdeletefororg) | **DELETE** /v0.1/orgs/{org_name}/distribution_groups/{distribution_group_name} | 
[**DistributionGroupsDetailsForOrg**](AccountApi.md#distributiongroupsdetailsfororg) | **GET** /v0.1/orgs/{org_name}/distribution_groups_details | 
[**DistributionGroupsGet**](AccountApi.md#distributiongroupsget) | **GET** /v0.1/apps/{owner_name}/{app_name}/distribution_groups/{distribution_group_name} | 
[**DistributionGroupsGetApps**](AccountApi.md#distributiongroupsgetapps) | **GET** /v0.1/orgs/{org_name}/distribution_groups/{distribution_group_name}/apps | 
[**DistributionGroupsGetForOrg**](AccountApi.md#distributiongroupsgetfororg) | **GET** /v0.1/orgs/{org_name}/distribution_groups/{distribution_group_name} | 
[**DistributionGroupsList**](AccountApi.md#distributiongroupslist) | **GET** /v0.1/apps/{owner_name}/{app_name}/distribution_groups | 
[**DistributionGroupsListAllTestersForOrg**](AccountApi.md#distributiongroupslistalltestersfororg) | **GET** /v0.1/orgs/{org_name}/testers | 
[**DistributionGroupsListForOrg**](AccountApi.md#distributiongroupslistfororg) | **GET** /v0.1/orgs/{org_name}/distribution_groups | 
[**DistributionGroupsListUsers**](AccountApi.md#distributiongroupslistusers) | **GET** /v0.1/apps/{owner_name}/{app_name}/distribution_groups/{distribution_group_name}/members | 
[**DistributionGroupsListUsersForOrg**](AccountApi.md#distributiongroupslistusersfororg) | **GET** /v0.1/orgs/{org_name}/distribution_groups/{distribution_group_name}/members | 
[**DistributionGroupsPatchForOrg**](AccountApi.md#distributiongroupspatchfororg) | **PATCH** /v0.1/orgs/{org_name}/distribution_groups/{distribution_group_name} | 
[**DistributionGroupsRemoveUser**](AccountApi.md#distributiongroupsremoveuser) | **POST** /v0.1/apps/{owner_name}/{app_name}/distribution_groups/{distribution_group_name}/members/bulk_delete | 
[**DistributionGroupsResendInvite**](AccountApi.md#distributiongroupsresendinvite) | **POST** /v0.1/apps/{owner_name}/{app_name}/distribution_groups/{distribution_group_name}/resend_invite | 
[**DistributionGroupsResendSharedInvite**](AccountApi.md#distributiongroupsresendsharedinvite) | **POST** /v0.1/orgs/{org_name}/distribution_groups/{distribution_group_name}/resend_invite | 
[**DistributionGroupsUpdate**](AccountApi.md#distributiongroupsupdate) | **PATCH** /v0.1/apps/{owner_name}/{app_name}/distribution_groups/{distribution_group_name} | 
[**InvitationsSent**](AccountApi.md#invitationssent) | **GET** /v0.1/invitations/sent | 
[**OrgInvitations**](AccountApi.md#orginvitations) | **POST** /v0.1/orgs/{org_name}/invitations/{email}/revoke | 
[**OrgInvitationsAccept**](AccountApi.md#orginvitationsaccept) | **POST** /v0.1/user/invitations/orgs/{invitation_token}/accept | 
[**OrgInvitationsCreate**](AccountApi.md#orginvitationscreate) | **POST** /v0.1/orgs/{org_name}/invitations | 
[**OrgInvitationsDelete**](AccountApi.md#orginvitationsdelete) | **DELETE** /v0.1/orgs/{org_name}/invitations | 
[**OrgInvitationsListPending**](AccountApi.md#orginvitationslistpending) | **GET** /v0.1/orgs/{org_name}/invitations | 
[**OrgInvitationsReject**](AccountApi.md#orginvitationsreject) | **POST** /v0.1/user/invitations/orgs/{invitation_token}/reject | 
[**OrgInvitationsSendNewInvitation**](AccountApi.md#orginvitationssendnewinvitation) | **POST** /v0.1/orgs/{org_name}/invitations/{email}/resend | 
[**OrgInvitationsUpdate**](AccountApi.md#orginvitationsupdate) | **PATCH** /v0.1/orgs/{org_name}/invitations/{email} | 
[**OrganizationDeleteAvatar**](AccountApi.md#organizationdeleteavatar) | **DELETE** /v0.1/orgs/{org_name}/avatar | 
[**OrganizationUpdateAvatar**](AccountApi.md#organizationupdateavatar) | **POST** /v0.1/orgs/{org_name}/avatar | 
[**OrganizationsCreateOrUpdate**](AccountApi.md#organizationscreateorupdate) | **POST** /v0.1/orgs | 
[**OrganizationsDelete**](AccountApi.md#organizationsdelete) | **DELETE** /v0.1/orgs/{org_name} | 
[**OrganizationsGet**](AccountApi.md#organizationsget) | **GET** /v0.1/orgs/{org_name} | 
[**OrganizationsList**](AccountApi.md#organizationslist) | **GET** /v0.1/orgs | 
[**OrganizationsListAdministered**](AccountApi.md#organizationslistadministered) | **GET** /v0.1/administeredOrgs | 
[**OrganizationsUpdate**](AccountApi.md#organizationsupdate) | **PATCH** /v0.1/orgs/{org_name} | 
[**SharedconnectionConnections**](AccountApi.md#sharedconnectionconnections) | **GET** /v0.1/user/export/serviceConnections | 
[**TeamsAddApp**](AccountApi.md#teamsaddapp) | **POST** /v0.1/orgs/{org_name}/teams/{team_name}/apps | 
[**TeamsAddUser**](AccountApi.md#teamsadduser) | **POST** /v0.1/orgs/{org_name}/teams/{team_name}/users | 
[**TeamsCreateTeam**](AccountApi.md#teamscreateteam) | **POST** /v0.1/orgs/{org_name}/teams | 
[**TeamsDelete**](AccountApi.md#teamsdelete) | **DELETE** /v0.1/orgs/{org_name}/teams/{team_name} | 
[**TeamsGetTeam**](AccountApi.md#teamsgetteam) | **GET** /v0.1/orgs/{org_name}/teams/{team_name} | 
[**TeamsGetUsers**](AccountApi.md#teamsgetusers) | **GET** /v0.1/orgs/{org_name}/teams/{team_name}/users | 
[**TeamsListAll**](AccountApi.md#teamslistall) | **GET** /v0.1/orgs/{org_name}/teams | 
[**TeamsListApps**](AccountApi.md#teamslistapps) | **GET** /v0.1/orgs/{org_name}/teams/{team_name}/apps | 
[**TeamsRemoveApp**](AccountApi.md#teamsremoveapp) | **DELETE** /v0.1/orgs/{org_name}/teams/{team_name}/apps/{app_name} | 
[**TeamsRemoveUser**](AccountApi.md#teamsremoveuser) | **DELETE** /v0.1/orgs/{org_name}/teams/{team_name}/users/{user_name} | 
[**TeamsUpdate**](AccountApi.md#teamsupdate) | **PATCH** /v0.1/orgs/{org_name}/teams/{team_name} | 
[**TeamsUpdatePermissions**](AccountApi.md#teamsupdatepermissions) | **PATCH** /v0.1/orgs/{org_name}/teams/{team_name}/apps/{app_name} | 
[**UserApiTokensDelete**](AccountApi.md#userapitokensdelete) | **DELETE** /v0.1/api_tokens/{api_token_id} | 
[**UserApiTokensList**](AccountApi.md#userapitokenslist) | **GET** /v0.1/api_tokens | 
[**UserApiTokensNew**](AccountApi.md#userapitokensnew) | **POST** /v0.1/api_tokens | 
[**UsersGet**](AccountApi.md#usersget) | **GET** /v0.1/user | 
[**UsersGetForOrg**](AccountApi.md#usersgetfororg) | **GET** /v0.1/orgs/{org_name}/users/{user_name} | 
[**UsersGetUserMetadata**](AccountApi.md#usersgetusermetadata) | **GET** /v0.1/user/metadata/optimizely | 
[**UsersList**](AccountApi.md#userslist) | **GET** /v0.1/apps/{owner_name}/{app_name}/users | 
[**UsersListForOrg**](AccountApi.md#userslistfororg) | **GET** /v0.1/orgs/{org_name}/users | 
[**UsersRemoveFromOrg**](AccountApi.md#usersremovefromorg) | **DELETE** /v0.1/orgs/{org_name}/users/{user_name} | 
[**UsersUpdate**](AccountApi.md#usersupdate) | **PATCH** /v0.1/user | 
[**UsersUpdateOrgRole**](AccountApi.md#usersupdateorgrole) | **PATCH** /v0.1/orgs/{org_name}/users/{user_name} | 

<a name="appapitokensdelete"></a>
# **AppApiTokensDelete**
> void AppApiTokensDelete (string ownerName, string appName, string apiTokenId)



Delete the App Api Token object with the specific ID

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppApiTokensDeleteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var apiTokenId = apiTokenId_example;  // string | The unique ID (UUID) of the api token

            try
            {
                apiInstance.AppApiTokensDelete(ownerName, appName, apiTokenId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppApiTokensDelete: " + e.Message );
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
 **apiTokenId** | **string**| The unique ID (UUID) of the api token | 

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appapitokenslist"></a>
# **AppApiTokensList**
> List<InlineResponse20075> AppApiTokensList (string ownerName, string appName)



Returns App API tokens for the app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppApiTokensListExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse20075&gt; result = apiInstance.AppApiTokensList(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppApiTokensList: " + e.Message );
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

[**List<InlineResponse20075>**](InlineResponse20075.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appapitokensnew"></a>
# **AppApiTokensNew**
> Object AppApiTokensNew (string ownerName, string appName, AppNameApiTokensBody body = null)



Creates a new App API token

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppApiTokensNewExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var body = new AppNameApiTokensBody(); // AppNameApiTokensBody | Description of the token (optional) 

            try
            {
                Object result = apiInstance.AppApiTokensNew(ownerName, appName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppApiTokensNew: " + e.Message );
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
 **body** | [**AppNameApiTokensBody**](AppNameApiTokensBody.md)| Description of the token | [optional] 

### Return type

**Object**

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appinvitationsaccept"></a>
# **AppInvitationsAccept**
> void AppInvitationsAccept (string invitationToken, Object body = null)



Accepts a pending invitation for the specified user

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppInvitationsAcceptExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var invitationToken = invitationToken_example;  // string | The app invitation token that was sent to the user
            var body = new Object(); // Object | allow empty body for custom http-client lib (optional) 

            try
            {
                apiInstance.AppInvitationsAccept(invitationToken, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppInvitationsAccept: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invitationToken** | **string**| The app invitation token that was sent to the user | 
 **body** | [**Object**](Object.md)| allow empty body for custom http-client lib | [optional] 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appinvitationscreate"></a>
# **AppInvitationsCreate**
> void AppInvitationsCreate (string ownerName, string appName, AppNameInvitationsBody body = null)



Invites a new or existing user to an app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppInvitationsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var body = new AppNameInvitationsBody(); // AppNameInvitationsBody | The email of the user to invite (optional) 

            try
            {
                apiInstance.AppInvitationsCreate(ownerName, appName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppInvitationsCreate: " + e.Message );
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
 **body** | [**AppNameInvitationsBody**](AppNameInvitationsBody.md)| The email of the user to invite | [optional] 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appinvitationscreatebyemail"></a>
# **AppInvitationsCreateByEmail**
> void AppInvitationsCreateByEmail (string ownerName, string appName, string userEmail, InvitationsUserEmailBody body = null)



Invites a new or existing user to an app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppInvitationsCreateByEmailExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var userEmail = userEmail_example;  // string | The email of the user to invite
            var body = new InvitationsUserEmailBody(); // InvitationsUserEmailBody | The role of the user to be added (optional) 

            try
            {
                apiInstance.AppInvitationsCreateByEmail(ownerName, appName, userEmail, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppInvitationsCreateByEmail: " + e.Message );
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
 **userEmail** | **string**| The email of the user to invite | 
 **body** | [**InvitationsUserEmailBody**](InvitationsUserEmailBody.md)| The role of the user to be added | [optional] 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appinvitationsdelete"></a>
# **AppInvitationsDelete**
> void AppInvitationsDelete (string ownerName, string appName, string userEmail)



Removes a user's invitation to an app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppInvitationsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var userEmail = userEmail_example;  // string | The email of the user to invite

            try
            {
                apiInstance.AppInvitationsDelete(ownerName, appName, userEmail);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppInvitationsDelete: " + e.Message );
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
 **userEmail** | **string**| The email of the user to invite | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appinvitationslist"></a>
# **AppInvitationsList**
> Object AppInvitationsList (string ownerName, string appName)



Gets the pending invitations for the app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppInvitationsListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.AppInvitationsList(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppInvitationsList: " + e.Message );
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
<a name="appinvitationsreject"></a>
# **AppInvitationsReject**
> void AppInvitationsReject (string invitationToken, Object body = null)



Rejects a pending invitation for the specified user

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppInvitationsRejectExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var invitationToken = invitationToken_example;  // string | The app invitation token that was sent to the user
            var body = new Object(); // Object | allow empty body for custom http-client lib (optional) 

            try
            {
                apiInstance.AppInvitationsReject(invitationToken, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppInvitationsReject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invitationToken** | **string**| The app invitation token that was sent to the user | 
 **body** | [**Object**](Object.md)| allow empty body for custom http-client lib | [optional] 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appinvitationsupdatepermissions"></a>
# **AppInvitationsUpdatePermissions**
> void AppInvitationsUpdatePermissions (InvitationsUserEmailBody1 body, string ownerName, string appName, string userEmail)



Update pending invitation permission

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppInvitationsUpdatePermissionsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new InvitationsUserEmailBody1(); // InvitationsUserEmailBody1 | The value to update the user permission in the invite.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var userEmail = userEmail_example;  // string | The email of the user to invite

            try
            {
                apiInstance.AppInvitationsUpdatePermissions(body, ownerName, appName, userEmail);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppInvitationsUpdatePermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InvitationsUserEmailBody1**](InvitationsUserEmailBody1.md)| The value to update the user permission in the invite. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **userEmail** | **string**| The email of the user to invite | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appscreate"></a>
# **AppsCreate**
> Object AppsCreate (V01AppsBody body)



Creates a new app and returns it to the caller

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new V01AppsBody(); // V01AppsBody | The data for the app

            try
            {
                Object result = apiInstance.AppsCreate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**V01AppsBody**](V01AppsBody.md)| The data for the app | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appscreatefororg"></a>
# **AppsCreateForOrg**
> Object AppsCreateForOrg (OrgNameAppsBody body, string orgName)



Creates a new app for the organization and returns it to the caller

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppsCreateForOrgExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new OrgNameAppsBody(); // OrgNameAppsBody | The data for the app
            var orgName = orgName_example;  // string | The organization's name

            try
            {
                Object result = apiInstance.AppsCreateForOrg(body, orgName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppsCreateForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrgNameAppsBody**](OrgNameAppsBody.md)| The data for the app | 
 **orgName** | **string**| The organization&#x27;s name | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appsdelete"></a>
# **AppsDelete**
> void AppsDelete (string appName, string ownerName)



Delete an app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var appName = appName_example;  // string | The name of the application
            var ownerName = ownerName_example;  // string | The name of the owner

            try
            {
                apiInstance.AppsDelete(appName, ownerName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appName** | **string**| The name of the application | 
 **ownerName** | **string**| The name of the owner | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appsdeleteavatar"></a>
# **AppsDeleteAvatar**
> Object AppsDeleteAvatar (string ownerName, string appName)



Deletes the uploaded app avatar

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppsDeleteAvatarExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.AppsDeleteAvatar(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppsDeleteAvatar: " + e.Message );
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
<a name="appsget"></a>
# **AppsGet**
> Object AppsGet (string ownerName, string appName)



Return a specific app with the given app name which belongs to the given owner.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppsGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.AppsGet(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppsGet: " + e.Message );
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
<a name="appsgetfororguser"></a>
# **AppsGetForOrgUser**
> List<Object> AppsGetForOrgUser (string orgName, string userName)



Get a user apps information from an organization by name

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppsGetForOrgUserExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name
            var userName = userName_example;  // string | The slug name of the user

            try
            {
                List&lt;Object&gt; result = apiInstance.AppsGetForOrgUser(orgName, userName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppsGetForOrgUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 
 **userName** | **string**| The slug name of the user | 

### Return type

**List<Object>**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appsgetteams"></a>
# **AppsGetTeams**
> List<Object> AppsGetTeams (string appName, string ownerName)



Returns the details of all teams that have access to the app.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppsGetTeamsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var appName = appName_example;  // string | The name of the application
            var ownerName = ownerName_example;  // string | The name of the owner

            try
            {
                List&lt;Object&gt; result = apiInstance.AppsGetTeams(appName, ownerName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppsGetTeams: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appName** | **string**| The name of the application | 
 **ownerName** | **string**| The name of the owner | 

### Return type

**List<Object>**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appslist"></a>
# **AppsList**
> List<Object> AppsList (string orderBy = null)



Returns a list of apps

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppsListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orderBy = orderBy_example;  // string | The name of the attribute by which to order the response by. By default, apps are in order of creation. All results are ordered in ascending order. (optional) 

            try
            {
                List&lt;Object&gt; result = apiInstance.AppsList(orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderBy** | **string**| The name of the attribute by which to order the response by. By default, apps are in order of creation. All results are ordered in ascending order. | [optional] 

### Return type

**List<Object>**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appslistfororg"></a>
# **AppsListForOrg**
> List<Object> AppsListForOrg (string orgName)



Returns a list of apps for the organization

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppsListForOrgExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name

            try
            {
                List&lt;Object&gt; result = apiInstance.AppsListForOrg(orgName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppsListForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 

### Return type

**List<Object>**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appslisttesters"></a>
# **AppsListTesters**
> List<InlineResponse20019> AppsListTesters (string ownerName, string appName)



Returns the testers associated with the app specified with the given app name which belongs to the given owner.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppsListTestersExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse20019&gt; result = apiInstance.AppsListTesters(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppsListTesters: " + e.Message );
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

[**List<InlineResponse20019>**](InlineResponse20019.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appsremoveuser"></a>
# **AppsRemoveUser**
> void AppsRemoveUser (string ownerName, string appName, string userEmail)



Removes the user from the app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppsRemoveUserExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var userEmail = userEmail_example;  // string | The user email of the user to delete

            try
            {
                apiInstance.AppsRemoveUser(ownerName, appName, userEmail);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppsRemoveUser: " + e.Message );
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
 **userEmail** | **string**| The user email of the user to delete | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appstransferownership"></a>
# **AppsTransferOwnership**
> Object AppsTransferOwnership (string ownerName, string appName, string destinationOwnerName, Object body = null)



Transfers ownership of an app to a different user or organization

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppsTransferOwnershipExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var destinationOwnerName = destinationOwnerName_example;  // string | The name of the owner (user or organization) to which the app is being transferred
            var body = new Object(); // Object | allow empty body for custom http-client lib (optional) 

            try
            {
                Object result = apiInstance.AppsTransferOwnership(ownerName, appName, destinationOwnerName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppsTransferOwnership: " + e.Message );
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
 **destinationOwnerName** | **string**| The name of the owner (user or organization) to which the app is being transferred | 
 **body** | [**Object**](Object.md)| allow empty body for custom http-client lib | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json, application/octet-stream
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appstransfertoorg"></a>
# **AppsTransferToOrg**
> Object AppsTransferToOrg (string ownerName, string appName, Object body = null)



Transfers ownership of an app to a new organization

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppsTransferToOrgExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var body = new Object(); // Object | allow empty body for custom http-client lib (optional) 

            try
            {
                Object result = apiInstance.AppsTransferToOrg(ownerName, appName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppsTransferToOrg: " + e.Message );
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
 **body** | [**Object**](Object.md)| allow empty body for custom http-client lib | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appsupdate"></a>
# **AppsUpdate**
> Object AppsUpdate (string appName, string ownerName, OwnerNameAppNameBody body = null)



Partially updates a single app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var appName = appName_example;  // string | The name of the application
            var ownerName = ownerName_example;  // string | The name of the owner
            var body = new OwnerNameAppNameBody(); // OwnerNameAppNameBody | The partial data for the app (optional) 

            try
            {
                Object result = apiInstance.AppsUpdate(appName, ownerName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appName** | **string**| The name of the application | 
 **ownerName** | **string**| The name of the owner | 
 **body** | [**OwnerNameAppNameBody**](OwnerNameAppNameBody.md)| The partial data for the app | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appsupdateavatar"></a>
# **AppsUpdateAvatar**
> Object AppsUpdateAvatar (string ownerName, string appName, byte[] avatar = null)



Sets the app avatar

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppsUpdateAvatarExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var avatar = avatar_example;  // byte[] |  (optional) 

            try
            {
                Object result = apiInstance.AppsUpdateAvatar(ownerName, appName, avatar);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppsUpdateAvatar: " + e.Message );
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
 **avatar** | **byte[]****byte[]**|  | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="appsupdateuserpermissions"></a>
# **AppsUpdateUserPermissions**
> void AppsUpdateUserPermissions (UsersUserEmailBody body, string ownerName, string appName, string userEmail)



Update user permission for the app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AppsUpdateUserPermissionsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new UsersUserEmailBody(); // UsersUserEmailBody | The value to update the user permission for the app.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var userEmail = userEmail_example;  // string | The user email of the user to patch

            try
            {
                apiInstance.AppsUpdateUserPermissions(body, ownerName, appName, userEmail);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AppsUpdateUserPermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UsersUserEmailBody**](UsersUserEmailBody.md)| The value to update the user permission for the app. | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **userEmail** | **string**| The user email of the user to patch | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="azuresubscriptiondeleteforapp"></a>
# **AzureSubscriptionDeleteForApp**
> void AzureSubscriptionDeleteForApp (Guid? azureSubscriptionId, string ownerName, string appName)



Delete the azure subscriptions for the app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AzureSubscriptionDeleteForAppExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var azureSubscriptionId = new Guid?(); // Guid? | The unique ID (UUID) of the azure subscription
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.AzureSubscriptionDeleteForApp(azureSubscriptionId, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AzureSubscriptionDeleteForApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **azureSubscriptionId** | [**Guid?**](Guid?.md)| The unique ID (UUID) of the azure subscription | 
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
<a name="azuresubscriptionlinkforapp"></a>
# **AzureSubscriptionLinkForApp**
> void AzureSubscriptionLinkForApp (AppNameAzureSubscriptionsBody body, string ownerName, string appName)



Link azure subscription to an app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AzureSubscriptionLinkForAppExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new AppNameAzureSubscriptionsBody(); // AppNameAzureSubscriptionsBody | The azure subscription data needed to be link to the app.
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.AzureSubscriptionLinkForApp(body, ownerName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AzureSubscriptionLinkForApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AppNameAzureSubscriptionsBody**](AppNameAzureSubscriptionsBody.md)| The azure subscription data needed to be link to the app. | 
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
<a name="azuresubscriptionlistforapp"></a>
# **AzureSubscriptionListForApp**
> List<InlineResponse20011> AzureSubscriptionListForApp (string ownerName, string appName)



Returns a list of azure subscriptions for the app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AzureSubscriptionListForAppExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse20011&gt; result = apiInstance.AzureSubscriptionListForApp(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AzureSubscriptionListForApp: " + e.Message );
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

[**List<InlineResponse20011>**](InlineResponse20011.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="azuresubscriptionlistfororg"></a>
# **AzureSubscriptionListForOrg**
> List<InlineResponse20011> AzureSubscriptionListForOrg (string orgName)



Returns a list of azure subscriptions for the organization

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AzureSubscriptionListForOrgExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name

            try
            {
                List&lt;InlineResponse20011&gt; result = apiInstance.AzureSubscriptionListForOrg(orgName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AzureSubscriptionListForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 

### Return type

[**List<InlineResponse20011>**](InlineResponse20011.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="azuresubscriptionlistforuser"></a>
# **AzureSubscriptionListForUser**
> List<InlineResponse20011> AzureSubscriptionListForUser ()



Returns a list of azure subscriptions for the user

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class AzureSubscriptionListForUserExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();

            try
            {
                List&lt;InlineResponse20011&gt; result = apiInstance.AzureSubscriptionListForUser();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AzureSubscriptionListForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InlineResponse20011>**](InlineResponse20011.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupinvitationsacceptall"></a>
# **DistributionGroupInvitationsAcceptAll**
> void DistributionGroupInvitationsAcceptAll (Object body = null)



Accepts all pending invitations to distribution groups for the specified user

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupInvitationsAcceptAllExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new Object(); // Object | allow empty body for custom http-client lib (optional) 

            try
            {
                apiInstance.DistributionGroupInvitationsAcceptAll(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupInvitationsAcceptAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Object**](Object.md)| allow empty body for custom http-client lib | [optional] 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupsaddapps"></a>
# **DistributionGroupsAddApps**
> void DistributionGroupsAddApps (DistributionGroupNameAppsBody body, string orgName, string distributionGroupName)



Add apps to distribution group in an org

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsAddAppsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new DistributionGroupNameAppsBody(); // DistributionGroupNameAppsBody | The name of the apps to be added to the distribution group. The apps have to be owned by the organization.
            var orgName = orgName_example;  // string | The organization's name
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group

            try
            {
                apiInstance.DistributionGroupsAddApps(body, orgName, distributionGroupName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsAddApps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DistributionGroupNameAppsBody**](DistributionGroupNameAppsBody.md)| The name of the apps to be added to the distribution group. The apps have to be owned by the organization. | 
 **orgName** | **string**| The organization&#x27;s name | 
 **distributionGroupName** | **string**| The name of the distribution group | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupsadduser"></a>
# **DistributionGroupsAddUser**
> List<InlineResponse20010> DistributionGroupsAddUser (DistributionGroupNameMembersBody1 body, string ownerName, string appName, string distributionGroupName)



Adds the members to the specified distribution group

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsAddUserExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new DistributionGroupNameMembersBody1(); // DistributionGroupNameMembersBody1 | The list of members to add
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group

            try
            {
                List&lt;InlineResponse20010&gt; result = apiInstance.DistributionGroupsAddUser(body, ownerName, appName, distributionGroupName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsAddUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DistributionGroupNameMembersBody1**](DistributionGroupNameMembersBody1.md)| The list of members to add | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **distributionGroupName** | **string**| The name of the distribution group | 

### Return type

[**List<InlineResponse20010>**](InlineResponse20010.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupsaddusersfororg"></a>
# **DistributionGroupsAddUsersForOrg**
> List<InlineResponse20010> DistributionGroupsAddUsersForOrg (DistributionGroupNameMembersBody body, string orgName, string distributionGroupName)



Accepts an array of user email addresses to get added to the specified group

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsAddUsersForOrgExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new DistributionGroupNameMembersBody(); // DistributionGroupNameMembersBody | list of user email addresses that should get added as members to the specified group
            var orgName = orgName_example;  // string | The organization's name
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group

            try
            {
                List&lt;InlineResponse20010&gt; result = apiInstance.DistributionGroupsAddUsersForOrg(body, orgName, distributionGroupName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsAddUsersForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DistributionGroupNameMembersBody**](DistributionGroupNameMembersBody.md)| list of user email addresses that should get added as members to the specified group | 
 **orgName** | **string**| The organization&#x27;s name | 
 **distributionGroupName** | **string**| The name of the distribution group | 

### Return type

[**List<InlineResponse20010>**](InlineResponse20010.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupsbulkdeleteapps"></a>
# **DistributionGroupsBulkDeleteApps**
> void DistributionGroupsBulkDeleteApps (AppsBulkDeleteBody body, string orgName, string distributionGroupName)



Delete apps from distribution group in an org

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsBulkDeleteAppsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new AppsBulkDeleteBody(); // AppsBulkDeleteBody | The name of the apps to be deleted from the distribution group. The apps have to be owned by the organization.
            var orgName = orgName_example;  // string | The organization's name
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group

            try
            {
                apiInstance.DistributionGroupsBulkDeleteApps(body, orgName, distributionGroupName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsBulkDeleteApps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AppsBulkDeleteBody**](AppsBulkDeleteBody.md)| The name of the apps to be deleted from the distribution group. The apps have to be owned by the organization. | 
 **orgName** | **string**| The organization&#x27;s name | 
 **distributionGroupName** | **string**| The name of the distribution group | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupsbulkdeleteusers"></a>
# **DistributionGroupsBulkDeleteUsers**
> void DistributionGroupsBulkDeleteUsers (MembersBulkDeleteBody body, string orgName, string distributionGroupName)



Delete testers from distribution group in an org

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsBulkDeleteUsersExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new MembersBulkDeleteBody(); // MembersBulkDeleteBody | The list of members to add
            var orgName = orgName_example;  // string | The organization's name
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group

            try
            {
                apiInstance.DistributionGroupsBulkDeleteUsers(body, orgName, distributionGroupName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsBulkDeleteUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MembersBulkDeleteBody**](MembersBulkDeleteBody.md)| The list of members to add | 
 **orgName** | **string**| The organization&#x27;s name | 
 **distributionGroupName** | **string**| The name of the distribution group | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupscreate"></a>
# **DistributionGroupsCreate**
> Object DistributionGroupsCreate (AppNameDistributionGroupsBody body, string ownerName, string appName)



Creates a new distribution group and returns it to the caller

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new AppNameDistributionGroupsBody(); // AppNameDistributionGroupsBody | The attributes to update for the distribution group
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.DistributionGroupsCreate(body, ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AppNameDistributionGroupsBody**](AppNameDistributionGroupsBody.md)| The attributes to update for the distribution group | 
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
<a name="distributiongroupscreatefororg"></a>
# **DistributionGroupsCreateForOrg**
> Object DistributionGroupsCreateForOrg (OrgNameDistributionGroupsBody body, string orgName)



Creates a disribution goup which can be shared across apps under an organization

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsCreateForOrgExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new OrgNameDistributionGroupsBody(); // OrgNameDistributionGroupsBody | The attributes to update for the distribution group
            var orgName = orgName_example;  // string | The organization's name

            try
            {
                Object result = apiInstance.DistributionGroupsCreateForOrg(body, orgName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsCreateForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrgNameDistributionGroupsBody**](OrgNameDistributionGroupsBody.md)| The attributes to update for the distribution group | 
 **orgName** | **string**| The organization&#x27;s name | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupsdelete"></a>
# **DistributionGroupsDelete**
> void DistributionGroupsDelete (string appName, string ownerName, string distributionGroupName)



Deletes a distribution group

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var appName = appName_example;  // string | The name of the application
            var ownerName = ownerName_example;  // string | The name of the owner
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group

            try
            {
                apiInstance.DistributionGroupsDelete(appName, ownerName, distributionGroupName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appName** | **string**| The name of the application | 
 **ownerName** | **string**| The name of the owner | 
 **distributionGroupName** | **string**| The name of the distribution group | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupsdeletefororg"></a>
# **DistributionGroupsDeleteForOrg**
> void DistributionGroupsDeleteForOrg (string orgName, string distributionGroupName)



Deletes a single distribution group from an org with a given distribution group name

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsDeleteForOrgExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group

            try
            {
                apiInstance.DistributionGroupsDeleteForOrg(orgName, distributionGroupName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsDeleteForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 
 **distributionGroupName** | **string**| The name of the distribution group | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupsdetailsfororg"></a>
# **DistributionGroupsDetailsForOrg**
> List<Object> DistributionGroupsDetailsForOrg (string orgName, decimal? appsLimit = null)



Returns a list of distribution groups with details for an organization

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsDetailsForOrgExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name
            var appsLimit = 1.2;  // decimal? | The max number of apps to include in the response (optional) 

            try
            {
                List&lt;Object&gt; result = apiInstance.DistributionGroupsDetailsForOrg(orgName, appsLimit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsDetailsForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 
 **appsLimit** | **decimal?**| The max number of apps to include in the response | [optional] 

### Return type

**List<Object>**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupsget"></a>
# **DistributionGroupsGet**
> Object DistributionGroupsGet (string ownerName, string appName, string distributionGroupName)



Returns a single distribution group for a given distribution group name

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group

            try
            {
                Object result = apiInstance.DistributionGroupsGet(ownerName, appName, distributionGroupName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsGet: " + e.Message );
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
 **distributionGroupName** | **string**| The name of the distribution group | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupsgetapps"></a>
# **DistributionGroupsGetApps**
> List<Object> DistributionGroupsGetApps (string orgName, string distributionGroupName)



Get apps from a distribution group in an org

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsGetAppsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group

            try
            {
                List&lt;Object&gt; result = apiInstance.DistributionGroupsGetApps(orgName, distributionGroupName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsGetApps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 
 **distributionGroupName** | **string**| The name of the distribution group | 

### Return type

**List<Object>**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupsgetfororg"></a>
# **DistributionGroupsGetForOrg**
> Object DistributionGroupsGetForOrg (string orgName, string distributionGroupName)



Returns a single distribution group in org for a given distribution group name

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsGetForOrgExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group

            try
            {
                Object result = apiInstance.DistributionGroupsGetForOrg(orgName, distributionGroupName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsGetForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 
 **distributionGroupName** | **string**| The name of the distribution group | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupslist"></a>
# **DistributionGroupsList**
> List<InlineResponse201> DistributionGroupsList (string ownerName, string appName)



Returns a list of distribution groups in the app specified

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse201&gt; result = apiInstance.DistributionGroupsList(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsList: " + e.Message );
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

[**List<InlineResponse201>**](InlineResponse201.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupslistalltestersfororg"></a>
# **DistributionGroupsListAllTestersForOrg**
> List<InlineResponse2006> DistributionGroupsListAllTestersForOrg (string orgName)



Returns a unique list of users including the whole organization members plus testers in any shared group of that org

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsListAllTestersForOrgExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name

            try
            {
                List&lt;InlineResponse2006&gt; result = apiInstance.DistributionGroupsListAllTestersForOrg(orgName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsListAllTestersForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 

### Return type

[**List<InlineResponse2006>**](InlineResponse2006.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupslistfororg"></a>
# **DistributionGroupsListForOrg**
> List<InlineResponse201> DistributionGroupsListForOrg (string orgName)



Returns a list of distribution groups in the org specified

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsListForOrgExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name

            try
            {
                List&lt;InlineResponse201&gt; result = apiInstance.DistributionGroupsListForOrg(orgName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsListForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 

### Return type

[**List<InlineResponse201>**](InlineResponse201.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupslistusers"></a>
# **DistributionGroupsListUsers**
> List<InlineResponse2009> DistributionGroupsListUsers (string ownerName, string appName, string distributionGroupName, bool? excludePendingInvitations = null)



Returns a list of member details in the distribution group specified

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsListUsersExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group
            var excludePendingInvitations = true;  // bool? | Whether to exclude pending invitations in the response (optional) 

            try
            {
                List&lt;InlineResponse2009&gt; result = apiInstance.DistributionGroupsListUsers(ownerName, appName, distributionGroupName, excludePendingInvitations);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsListUsers: " + e.Message );
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
 **distributionGroupName** | **string**| The name of the distribution group | 
 **excludePendingInvitations** | **bool?**| Whether to exclude pending invitations in the response | [optional] 

### Return type

[**List<InlineResponse2009>**](InlineResponse2009.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupslistusersfororg"></a>
# **DistributionGroupsListUsersForOrg**
> List<InlineResponse2009> DistributionGroupsListUsersForOrg (string orgName, string distributionGroupName)



Returns a list of member in the distribution group specified

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsListUsersForOrgExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group

            try
            {
                List&lt;InlineResponse2009&gt; result = apiInstance.DistributionGroupsListUsersForOrg(orgName, distributionGroupName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsListUsersForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 
 **distributionGroupName** | **string**| The name of the distribution group | 

### Return type

[**List<InlineResponse2009>**](InlineResponse2009.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupspatchfororg"></a>
# **DistributionGroupsPatchForOrg**
> Object DistributionGroupsPatchForOrg (string orgName, string distributionGroupName, DistributionGroupsDistributionGroupNameBody body = null)



Update one given distribution group name in an org

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsPatchForOrgExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group
            var body = new DistributionGroupsDistributionGroupNameBody(); // DistributionGroupsDistributionGroupNameBody | The attributes to update for the distribution group (optional) 

            try
            {
                Object result = apiInstance.DistributionGroupsPatchForOrg(orgName, distributionGroupName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsPatchForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 
 **distributionGroupName** | **string**| The name of the distribution group | 
 **body** | [**DistributionGroupsDistributionGroupNameBody**](DistributionGroupsDistributionGroupNameBody.md)| The attributes to update for the distribution group | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupsremoveuser"></a>
# **DistributionGroupsRemoveUser**
> List<InlineResponse20060> DistributionGroupsRemoveUser (MembersBulkDeleteBody1 body, string ownerName, string appName, string distributionGroupName)



Remove the users from the distribution group

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsRemoveUserExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new MembersBulkDeleteBody1(); // MembersBulkDeleteBody1 | The list of members to add
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group

            try
            {
                List&lt;InlineResponse20060&gt; result = apiInstance.DistributionGroupsRemoveUser(body, ownerName, appName, distributionGroupName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsRemoveUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MembersBulkDeleteBody1**](MembersBulkDeleteBody1.md)| The list of members to add | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **distributionGroupName** | **string**| The name of the distribution group | 

### Return type

[**List<InlineResponse20060>**](InlineResponse20060.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupsresendinvite"></a>
# **DistributionGroupsResendInvite**
> void DistributionGroupsResendInvite (DistributionGroupNameResendInviteBody1 body, string ownerName, string appName, string distributionGroupName)



Resend distribution group app invite notification to previously invited testers

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsResendInviteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new DistributionGroupNameResendInviteBody1(); // DistributionGroupNameResendInviteBody1 | The list of members to add
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group

            try
            {
                apiInstance.DistributionGroupsResendInvite(body, ownerName, appName, distributionGroupName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsResendInvite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DistributionGroupNameResendInviteBody1**](DistributionGroupNameResendInviteBody1.md)| The list of members to add | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **distributionGroupName** | **string**| The name of the distribution group | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupsresendsharedinvite"></a>
# **DistributionGroupsResendSharedInvite**
> void DistributionGroupsResendSharedInvite (DistributionGroupNameResendInviteBody body, string orgName, string distributionGroupName)



Resend shared distribution group invite notification to previously invited testers

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsResendSharedInviteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new DistributionGroupNameResendInviteBody(); // DistributionGroupNameResendInviteBody | The list of members to add
            var orgName = orgName_example;  // string | The organization's name
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group

            try
            {
                apiInstance.DistributionGroupsResendSharedInvite(body, orgName, distributionGroupName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsResendSharedInvite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DistributionGroupNameResendInviteBody**](DistributionGroupNameResendInviteBody.md)| The list of members to add | 
 **orgName** | **string**| The organization&#x27;s name | 
 **distributionGroupName** | **string**| The name of the distribution group | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="distributiongroupsupdate"></a>
# **DistributionGroupsUpdate**
> Object DistributionGroupsUpdate (DistributionGroupsDistributionGroupNameBody1 body, string ownerName, string appName, string distributionGroupName)



Updates the attributes of distribution group

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class DistributionGroupsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new DistributionGroupsDistributionGroupNameBody1(); // DistributionGroupsDistributionGroupNameBody1 | The attributes to update for the distribution group
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application
            var distributionGroupName = distributionGroupName_example;  // string | The name of the distribution group

            try
            {
                Object result = apiInstance.DistributionGroupsUpdate(body, ownerName, appName, distributionGroupName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DistributionGroupsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DistributionGroupsDistributionGroupNameBody1**](DistributionGroupsDistributionGroupNameBody1.md)| The attributes to update for the distribution group | 
 **ownerName** | **string**| The name of the owner | 
 **appName** | **string**| The name of the application | 
 **distributionGroupName** | **string**| The name of the distribution group | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="invitationssent"></a>
# **InvitationsSent**
> List<InlineResponse20014> InvitationsSent ()



Returns all invitations sent by the caller

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class InvitationsSentExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();

            try
            {
                List&lt;InlineResponse20014&gt; result = apiInstance.InvitationsSent();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.InvitationsSent: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InlineResponse20014>**](InlineResponse20014.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orginvitations"></a>
# **OrgInvitations**
> void OrgInvitations (string orgName, string email, Object body = null)



Removes a user's invitation to an organization

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class OrgInvitationsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name
            var email = email_example;  // string | The email address of the user to send the password reset mail to.
            var body = new Object(); // Object | allow empty body for custom http-client lib (optional) 

            try
            {
                apiInstance.OrgInvitations(orgName, email, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.OrgInvitations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 
 **email** | **string**| The email address of the user to send the password reset mail to. | 
 **body** | [**Object**](Object.md)| allow empty body for custom http-client lib | [optional] 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orginvitationsaccept"></a>
# **OrgInvitationsAccept**
> void OrgInvitationsAccept (string invitationToken, Object body = null)



Accepts a pending organization invitation for the specified user

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class OrgInvitationsAcceptExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var invitationToken = invitationToken_example;  // string | The app invitation token that was sent to the user
            var body = new Object(); // Object | allow empty body for custom http-client lib (optional) 

            try
            {
                apiInstance.OrgInvitationsAccept(invitationToken, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.OrgInvitationsAccept: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invitationToken** | **string**| The app invitation token that was sent to the user | 
 **body** | [**Object**](Object.md)| allow empty body for custom http-client lib | [optional] 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orginvitationscreate"></a>
# **OrgInvitationsCreate**
> void OrgInvitationsCreate (OrgNameInvitationsBody body, string orgName)



Invites a new or existing user to an organization

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class OrgInvitationsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new OrgNameInvitationsBody(); // OrgNameInvitationsBody | The email of the user to invite
            var orgName = orgName_example;  // string | The organization's name

            try
            {
                apiInstance.OrgInvitationsCreate(body, orgName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.OrgInvitationsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrgNameInvitationsBody**](OrgNameInvitationsBody.md)| The email of the user to invite | 
 **orgName** | **string**| The organization&#x27;s name | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orginvitationsdelete"></a>
# **OrgInvitationsDelete**
> void OrgInvitationsDelete (OrgNameInvitationsBody1 body, string orgName)



Removes a user's invitation to an organization

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class OrgInvitationsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new OrgNameInvitationsBody1(); // OrgNameInvitationsBody1 | The email of the user whose invitation should be removed
            var orgName = orgName_example;  // string | The organization's name

            try
            {
                apiInstance.OrgInvitationsDelete(body, orgName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.OrgInvitationsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrgNameInvitationsBody1**](OrgNameInvitationsBody1.md)| The email of the user whose invitation should be removed | 
 **orgName** | **string**| The organization&#x27;s name | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orginvitationslistpending"></a>
# **OrgInvitationsListPending**
> List<InlineResponse2008> OrgInvitationsListPending (string orgName)



Gets the pending invitations for the organization

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class OrgInvitationsListPendingExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name

            try
            {
                List&lt;InlineResponse2008&gt; result = apiInstance.OrgInvitationsListPending(orgName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.OrgInvitationsListPending: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 

### Return type

[**List<InlineResponse2008>**](InlineResponse2008.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orginvitationsreject"></a>
# **OrgInvitationsReject**
> void OrgInvitationsReject (string invitationToken, Object body = null)



Rejects a pending organization invitation

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class OrgInvitationsRejectExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var invitationToken = invitationToken_example;  // string | The app invitation token that was sent to the user
            var body = new Object(); // Object | allow empty body for custom http-client lib (optional) 

            try
            {
                apiInstance.OrgInvitationsReject(invitationToken, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.OrgInvitationsReject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invitationToken** | **string**| The app invitation token that was sent to the user | 
 **body** | [**Object**](Object.md)| allow empty body for custom http-client lib | [optional] 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orginvitationssendnewinvitation"></a>
# **OrgInvitationsSendNewInvitation**
> void OrgInvitationsSendNewInvitation (string orgName, string email, EmailResendBody body = null)



Cancels an existing organization invitation for the user and sends a new one

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class OrgInvitationsSendNewInvitationExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name
            var email = email_example;  // string | The email address of the user to send the password reset mail to.
            var body = new EmailResendBody(); // EmailResendBody | The role of the user to be added (optional) 

            try
            {
                apiInstance.OrgInvitationsSendNewInvitation(orgName, email, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.OrgInvitationsSendNewInvitation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 
 **email** | **string**| The email address of the user to send the password reset mail to. | 
 **body** | [**EmailResendBody**](EmailResendBody.md)| The role of the user to be added | [optional] 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orginvitationsupdate"></a>
# **OrgInvitationsUpdate**
> void OrgInvitationsUpdate (InvitationsEmailBody body, string orgName, string email)



Allows the role of an invited user to be changed

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class OrgInvitationsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new InvitationsEmailBody(); // InvitationsEmailBody | The new role of the user
            var orgName = orgName_example;  // string | The organization's name
            var email = email_example;  // string | The email address of the user to send the password reset mail to.

            try
            {
                apiInstance.OrgInvitationsUpdate(body, orgName, email);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.OrgInvitationsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InvitationsEmailBody**](InvitationsEmailBody.md)| The new role of the user | 
 **orgName** | **string**| The organization&#x27;s name | 
 **email** | **string**| The email address of the user to send the password reset mail to. | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="organizationdeleteavatar"></a>
# **OrganizationDeleteAvatar**
> Object OrganizationDeleteAvatar (string orgName)



Deletes the uploaded organization avatar

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class OrganizationDeleteAvatarExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name

            try
            {
                Object result = apiInstance.OrganizationDeleteAvatar(orgName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.OrganizationDeleteAvatar: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="organizationupdateavatar"></a>
# **OrganizationUpdateAvatar**
> Object OrganizationUpdateAvatar (string orgName, byte[] avatar = null)



Sets the organization avatar

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class OrganizationUpdateAvatarExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name
            var avatar = avatar_example;  // byte[] |  (optional) 

            try
            {
                Object result = apiInstance.OrganizationUpdateAvatar(orgName, avatar);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.OrganizationUpdateAvatar: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 
 **avatar** | **byte[]****byte[]**|  | [optional] 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="organizationscreateorupdate"></a>
# **OrganizationsCreateOrUpdate**
> Object OrganizationsCreateOrUpdate (V01OrgsBody body)



Creates a new organization and returns it to the caller

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class OrganizationsCreateOrUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new V01OrgsBody(); // V01OrgsBody | The organization data

            try
            {
                Object result = apiInstance.OrganizationsCreateOrUpdate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.OrganizationsCreateOrUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**V01OrgsBody**](V01OrgsBody.md)| The organization data | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="organizationsdelete"></a>
# **OrganizationsDelete**
> void OrganizationsDelete (string orgName)



Deletes a single organization

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class OrganizationsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name

            try
            {
                apiInstance.OrganizationsDelete(orgName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.OrganizationsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="organizationsget"></a>
# **OrganizationsGet**
> Object OrganizationsGet (string orgName)



Returns the details of a single organization

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class OrganizationsGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name

            try
            {
                Object result = apiInstance.OrganizationsGet(orgName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.OrganizationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="organizationslist"></a>
# **OrganizationsList**
> List<InlineResponse20013> OrganizationsList ()



Returns a list of organizations the requesting user has access to

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class OrganizationsListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();

            try
            {
                List&lt;InlineResponse20013&gt; result = apiInstance.OrganizationsList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.OrganizationsList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InlineResponse20013>**](InlineResponse20013.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="organizationslistadministered"></a>
# **OrganizationsListAdministered**
> InlineResponse20097 OrganizationsListAdministered ()



Returns a list organizations in which the requesting user is an admin

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class OrganizationsListAdministeredExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();

            try
            {
                InlineResponse20097 result = apiInstance.OrganizationsListAdministered();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.OrganizationsListAdministered: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20097**](InlineResponse20097.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="organizationsupdate"></a>
# **OrganizationsUpdate**
> Object OrganizationsUpdate (OrgsOrgNameBody body, string orgName)



Returns a list of organizations the requesting user has access to

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class OrganizationsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new OrgsOrgNameBody(); // OrgsOrgNameBody | The data for the org
            var orgName = orgName_example;  // string | The organization's name

            try
            {
                Object result = apiInstance.OrganizationsUpdate(body, orgName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.OrganizationsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrgsOrgNameBody**](OrgsOrgNameBody.md)| The data for the org | 
 **orgName** | **string**| The organization&#x27;s name | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="sharedconnectionconnections"></a>
# **SharedconnectionConnections**
> List<InlineResponse2001> SharedconnectionConnections ()



Gets all service connections of the service type for GDPR export.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class SharedconnectionConnectionsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();

            try
            {
                List&lt;InlineResponse2001&gt; result = apiInstance.SharedconnectionConnections();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.SharedconnectionConnections: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InlineResponse2001>**](InlineResponse2001.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="teamsaddapp"></a>
# **TeamsAddApp**
> Object TeamsAddApp (TeamNameAppsBody body, string orgName, string teamName)



Adds an app to a team

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TeamsAddAppExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new TeamNameAppsBody(); // TeamNameAppsBody | The name of the app to be added to the team. The app has to be owned by the organization.
            var orgName = orgName_example;  // string | The organization's name
            var teamName = teamName_example;  // string | The team's name

            try
            {
                Object result = apiInstance.TeamsAddApp(body, orgName, teamName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.TeamsAddApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TeamNameAppsBody**](TeamNameAppsBody.md)| The name of the app to be added to the team. The app has to be owned by the organization. | 
 **orgName** | **string**| The organization&#x27;s name | 
 **teamName** | **string**| The team&#x27;s name | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="teamsadduser"></a>
# **TeamsAddUser**
> Object TeamsAddUser (TeamNameUsersBody body, string orgName, string teamName)



Adds a new user to a team that is owned by an organization

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TeamsAddUserExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new TeamNameUsersBody(); // TeamNameUsersBody | The email of the user to add to the team
            var orgName = orgName_example;  // string | The organization's name
            var teamName = teamName_example;  // string | The team's name

            try
            {
                Object result = apiInstance.TeamsAddUser(body, orgName, teamName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.TeamsAddUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TeamNameUsersBody**](TeamNameUsersBody.md)| The email of the user to add to the team | 
 **orgName** | **string**| The organization&#x27;s name | 
 **teamName** | **string**| The team&#x27;s name | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="teamscreateteam"></a>
# **TeamsCreateTeam**
> List<InlineResponse2007> TeamsCreateTeam (OrgNameTeamsBody body, string orgName)



Creates a team and returns it

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TeamsCreateTeamExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new OrgNameTeamsBody(); // OrgNameTeamsBody | The information used to create the team
            var orgName = orgName_example;  // string | The organization's name

            try
            {
                List&lt;InlineResponse2007&gt; result = apiInstance.TeamsCreateTeam(body, orgName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.TeamsCreateTeam: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrgNameTeamsBody**](OrgNameTeamsBody.md)| The information used to create the team | 
 **orgName** | **string**| The organization&#x27;s name | 

### Return type

[**List<InlineResponse2007>**](InlineResponse2007.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="teamsdelete"></a>
# **TeamsDelete**
> void TeamsDelete (string orgName, string teamName)



Deletes a single team

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TeamsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name
            var teamName = teamName_example;  // string | The team's name

            try
            {
                apiInstance.TeamsDelete(orgName, teamName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.TeamsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 
 **teamName** | **string**| The team&#x27;s name | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="teamsgetteam"></a>
# **TeamsGetTeam**
> Object TeamsGetTeam (string orgName, string teamName)



Returns the details of a single team

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TeamsGetTeamExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name
            var teamName = teamName_example;  // string | The team's name

            try
            {
                Object result = apiInstance.TeamsGetTeam(orgName, teamName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.TeamsGetTeam: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 
 **teamName** | **string**| The team&#x27;s name | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="teamsgetusers"></a>
# **TeamsGetUsers**
> Object TeamsGetUsers (string orgName, string teamName)



Returns the users of a team which is owned by an organization

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TeamsGetUsersExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name
            var teamName = teamName_example;  // string | The team's name

            try
            {
                Object result = apiInstance.TeamsGetUsers(orgName, teamName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.TeamsGetUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 
 **teamName** | **string**| The team&#x27;s name | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="teamslistall"></a>
# **TeamsListAll**
> List<InlineResponse2007> TeamsListAll (string orgName)



Returns the list of all teams in this org

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TeamsListAllExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name

            try
            {
                List&lt;InlineResponse2007&gt; result = apiInstance.TeamsListAll(orgName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.TeamsListAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 

### Return type

[**List<InlineResponse2007>**](InlineResponse2007.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="teamslistapps"></a>
# **TeamsListApps**
> List<Object> TeamsListApps (string orgName, string teamName)



Returns the apps a team has access to

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TeamsListAppsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name
            var teamName = teamName_example;  // string | The team's name

            try
            {
                List&lt;Object&gt; result = apiInstance.TeamsListApps(orgName, teamName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.TeamsListApps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 
 **teamName** | **string**| The team&#x27;s name | 

### Return type

**List<Object>**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="teamsremoveapp"></a>
# **TeamsRemoveApp**
> void TeamsRemoveApp (string orgName, string teamName, string appName)



Removes an app from a team

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TeamsRemoveAppExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name
            var teamName = teamName_example;  // string | The team's name
            var appName = appName_example;  // string | The name of the application

            try
            {
                apiInstance.TeamsRemoveApp(orgName, teamName, appName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.TeamsRemoveApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 
 **teamName** | **string**| The team&#x27;s name | 
 **appName** | **string**| The name of the application | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="teamsremoveuser"></a>
# **TeamsRemoveUser**
> void TeamsRemoveUser (string orgName, string teamName, string userName)



Removes a user from a team that is owned by an organization

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TeamsRemoveUserExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name
            var teamName = teamName_example;  // string | The team's name
            var userName = userName_example;  // string | The slug name of the user

            try
            {
                apiInstance.TeamsRemoveUser(orgName, teamName, userName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.TeamsRemoveUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 
 **teamName** | **string**| The team&#x27;s name | 
 **userName** | **string**| The slug name of the user | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="teamsupdate"></a>
# **TeamsUpdate**
> Object TeamsUpdate (TeamsTeamNameBody body, string orgName, string teamName)



Updates a single team

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TeamsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new TeamsTeamNameBody(); // TeamsTeamNameBody | The information used to update the team
            var orgName = orgName_example;  // string | The organization's name
            var teamName = teamName_example;  // string | The team's name

            try
            {
                Object result = apiInstance.TeamsUpdate(body, orgName, teamName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.TeamsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TeamsTeamNameBody**](TeamsTeamNameBody.md)| The information used to update the team | 
 **orgName** | **string**| The organization&#x27;s name | 
 **teamName** | **string**| The team&#x27;s name | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="teamsupdatepermissions"></a>
# **TeamsUpdatePermissions**
> Object TeamsUpdatePermissions (AppsAppNameBody body, string orgName, string teamName, string appName)



Updates the permissions the team has to the app

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class TeamsUpdatePermissionsExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new AppsAppNameBody(); // AppsAppNameBody | 
            var orgName = orgName_example;  // string | The organization's name
            var teamName = teamName_example;  // string | The team's name
            var appName = appName_example;  // string | The name of the application

            try
            {
                Object result = apiInstance.TeamsUpdatePermissions(body, orgName, teamName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.TeamsUpdatePermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AppsAppNameBody**](AppsAppNameBody.md)|  | 
 **orgName** | **string**| The organization&#x27;s name | 
 **teamName** | **string**| The team&#x27;s name | 
 **appName** | **string**| The name of the application | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="userapitokensdelete"></a>
# **UserApiTokensDelete**
> void UserApiTokensDelete (string apiTokenId)



Delete the user api_token object with the specific id

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class UserApiTokensDeleteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountApi();
            var apiTokenId = apiTokenId_example;  // string | The unique ID (UUID) of the api token

            try
            {
                apiInstance.UserApiTokensDelete(apiTokenId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.UserApiTokensDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiTokenId** | **string**| The unique ID (UUID) of the api token | 

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="userapitokenslist"></a>
# **UserApiTokensList**
> List<InlineResponse20075> UserApiTokensList ()



Returns api tokens for the authenticated user

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class UserApiTokensListExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountApi();

            try
            {
                List&lt;InlineResponse20075&gt; result = apiInstance.UserApiTokensList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.UserApiTokensList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InlineResponse20075>**](InlineResponse20075.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="userapitokensnew"></a>
# **UserApiTokensNew**
> Object UserApiTokensNew (V01ApiTokensBody body = null)



Creates a new User API token

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class UserApiTokensNewExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountApi();
            var body = new V01ApiTokensBody(); // V01ApiTokensBody | Description of the token (optional) 

            try
            {
                Object result = apiInstance.UserApiTokensNew(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.UserApiTokensNew: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**V01ApiTokensBody**](V01ApiTokensBody.md)| Description of the token | [optional] 

### Return type

**Object**

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="usersget"></a>
# **UsersGet**
> Object UsersGet ()



Returns the user profile data

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class UsersGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();

            try
            {
                Object result = apiInstance.UsersGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.UsersGet: " + e.Message );
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

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="usersgetfororg"></a>
# **UsersGetForOrg**
> Object UsersGetForOrg (string orgName, string userName)



Get a user information from an organization by name - if there is explicit permission return it, if not if not return highest implicit permission

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class UsersGetForOrgExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name
            var userName = userName_example;  // string | The slug name of the user

            try
            {
                Object result = apiInstance.UsersGetForOrg(orgName, userName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.UsersGetForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 
 **userName** | **string**| The slug name of the user | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="usersgetusermetadata"></a>
# **UsersGetUserMetadata**
> Object UsersGetUserMetadata ()



### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class UsersGetUserMetadataExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();

            try
            {
                Object result = apiInstance.UsersGetUserMetadata();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.UsersGetUserMetadata: " + e.Message );
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

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="userslist"></a>
# **UsersList**
> List<InlineResponse20019> UsersList (string ownerName, string appName)



Returns the users associated with the app specified with the given app name which belongs to the given owner.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class UsersListExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var ownerName = ownerName_example;  // string | The name of the owner
            var appName = appName_example;  // string | The name of the application

            try
            {
                List&lt;InlineResponse20019&gt; result = apiInstance.UsersList(ownerName, appName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.UsersList: " + e.Message );
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

[**List<InlineResponse20019>**](InlineResponse20019.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="userslistfororg"></a>
# **UsersListForOrg**
> List<InlineResponse2005> UsersListForOrg (string orgName)



Returns a list of users that belong to an organization

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class UsersListForOrgExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name

            try
            {
                List&lt;InlineResponse2005&gt; result = apiInstance.UsersListForOrg(orgName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.UsersListForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 

### Return type

[**List<InlineResponse2005>**](InlineResponse2005.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="usersremovefromorg"></a>
# **UsersRemoveFromOrg**
> void UsersRemoveFromOrg (string orgName, string userName)



Removes a user from an organization.

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class UsersRemoveFromOrgExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var orgName = orgName_example;  // string | The organization's name
            var userName = userName_example;  // string | The slug name of the user

            try
            {
                apiInstance.UsersRemoveFromOrg(orgName, userName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.UsersRemoveFromOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgName** | **string**| The organization&#x27;s name | 
 **userName** | **string**| The slug name of the user | 

### Return type

void (empty response body)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="usersupdate"></a>
# **UsersUpdate**
> Object UsersUpdate (V01UserBody body)



Updates the user profile and returns the updated user data

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class UsersUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new V01UserBody(); // V01UserBody | The data for the created user

            try
            {
                Object result = apiInstance.UsersUpdate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.UsersUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**V01UserBody**](V01UserBody.md)| The data for the created user | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="usersupdateorgrole"></a>
# **UsersUpdateOrgRole**
> Object UsersUpdateOrgRole (UsersUserNameBody body, string orgName, string userName)



Updates the given organization user

### Example
```csharp
using System;
using System.Diagnostics;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Model;

namespace Example
{
    public class UsersUpdateOrgRoleExample
    {
        public void main()
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new AccountApi();
            var body = new UsersUserNameBody(); // UsersUserNameBody | 
            var orgName = orgName_example;  // string | The organization's name
            var userName = userName_example;  // string | The slug name of the user

            try
            {
                Object result = apiInstance.UsersUpdateOrgRole(body, orgName, userName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.UsersUpdateOrgRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UsersUserNameBody**](UsersUserNameBody.md)|  | 
 **orgName** | **string**| The organization&#x27;s name | 
 **userName** | **string**| The slug name of the user | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
