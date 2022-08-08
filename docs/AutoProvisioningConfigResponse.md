# AppCenterApiClientLib.Model.AutoProvisioningConfigResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**decimal?**](BigDecimal.md) | The identifier of the config. | [optional] 
**AppId** | **string** | The identifier of the App. | [optional] 
**DestinationId** | **string** | The identifier of the destination. | [optional] 
**AppleDeveloperAccountKey** | **string** | A key to a secret in customer-credential-store. apple_developer_account refers to the user&#x27;s developer account that is used to log into https://developer.apple.com. Normally the user&#x27;s email. | [optional] 
**AppleDistributionCertificateKey** | **string** | A key to a secret in customer-credential-store. distribution_certificate refers to the cusomer&#x27;s certificate (that holds the private key) that will be used to sign the app. | [optional] 
**AllowAutoProvisioning** | **bool?** | When *true* enables auto provisioning | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

