# AppCenterApiClientLib.Model.DistributionGroupDetailsResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsShared** | **bool?** | Whether the distribution group is shared group or not | [optional] 
**TotalAppsCount** | [**decimal?**](BigDecimal.md) | The count of apps associated with this distribution group | [optional] 
**TotalUserCount** | [**decimal?**](BigDecimal.md) | The count of users in the distribution group | [optional] 
**NotifiedUserCount** | [**decimal?**](BigDecimal.md) | The count of non-pending users in the distribution group who will be notified by new releases | [optional] 
**GroupType** | **string** | Type of group (Default, HockeyAppDefault or MicrosoftDogfooding) | [optional] 
**Users** | [**List&lt;DistributionGroupDetailsResponseUsers&gt;**](DistributionGroupDetailsResponseUsers.md) | The distribution group users | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

