# AppCenterApiClientLib.Model.AppNameDistributionStoresBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | store Type | [optional] 
**Name** | **string** | name of the store. In case of googleplay, and Apple store this is fixed to Production. | [optional] 
**Track** | **string** | track of the store. Can be production, alpha &amp; beta for googleplay. Can be production, testflight-internal &amp; testflight-external for Apple Store. | [optional] 
**IntuneDetails** | [**V01appsownerNameappNamedistributionStoresIntuneDetails1**](V01appsownerNameappNamedistributionStoresIntuneDetails1.md) |  | [optional] 
**ServiceConnectionId** | **string** | Id for the shared service connection. In case of Apple AppStore, this connection will be used to create and connect to the Apple AppStore in Mobile Center. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

