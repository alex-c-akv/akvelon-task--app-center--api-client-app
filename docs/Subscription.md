# AppCenterApiClientLib.Model.Subscription
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartsAt** | **string** | The date the subscription began | [optional] 
**EndsAt** | **string** | The date the subscription will end or ended | [optional] 
**DaysLeft** | [**decimal?**](BigDecimal.md) | The number of days left in the subscription | [optional] 
**Tier** | [**SubscriptionTier**](SubscriptionTier.md) |  | [optional] 
**Active** | **bool?** | Is the subscription currently active? | [optional] 
**Id** | **Guid?** | Id of the subscription | [optional] 
**ConcurrentDevicesLimit** | **int?** | Customer limits on concurrent devices | [optional] 
**RunningDevices** | **int?** | Current device concurrency utilization | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

