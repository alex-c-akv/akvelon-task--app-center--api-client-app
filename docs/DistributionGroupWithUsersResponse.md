# AppCenterApiClientLib.Model.DistributionGroupWithUsersResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid?** | The unique ID of the distribution group | 
**Name** | **string** | The name of the distribution group used in URLs | 
**TotalUserCount** | [**decimal?**](BigDecimal.md) | The count of users in the distribution group | 
**TotalGroupsCount** | [**decimal?**](BigDecimal.md) | The count of aad groups in the distribution group | [optional] 
**NotifiedUserCount** | [**decimal?**](BigDecimal.md) | The count of non-pending users in the distribution group who will be notified by new releases | 
**IsPublic** | **bool?** | Whether the distribution group is public | [optional] 
**Users** | [**List&lt;DistributionGroupDetailsResponseUsers&gt;**](DistributionGroupDetailsResponseUsers.md) | The distribution group users | 
**AadGroups** | [**List&lt;DistributionGroupWithUsersResponseAadGroups&gt;**](DistributionGroupWithUsersResponseAadGroups.md) | The distribution group aad groups | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

