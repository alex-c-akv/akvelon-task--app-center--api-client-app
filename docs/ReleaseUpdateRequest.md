# AppCenterApiClientLib.Model.ReleaseUpdateRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DistributionGroupName** | **string** | OBSOLETE. Will be removed in future releases - use destinations instead. Name of a distribution group. The release will be associated with this distribution group. If the distribution group doesn&#x27;t exist a 400 is returned. If both distribution group name and id are passed, the id is taking precedence. | [optional] 
**DistributionGroupId** | **string** | OBSOLETE. Will be removed in future releases - use destinations instead. Id of a distribution group. The release will be associated with this distribution group. If the distribution group doesn&#x27;t exist a 400 is returned. If both distribution group name and id are passed, the id is taking precedence. | [optional] 
**DestinationName** | **string** | OBSOLETE. Will be removed in future releases - use destinations instead. Name of a destination. The release will be associated with this destination. If the destination doesn&#x27;t exist a 400 is returned. If both distribution group name and id are passed, the id is taking precedence. | [optional] 
**DestinationId** | **string** | OBSOLETE. Will be removed in future releases - use destinations instead. Id of a destination. The release will be associated with this destination. If the destination doesn&#x27;t exist a 400 is returned. If both destination name and id are passed, the id is taking precedence. | [optional] 
**DestinationType** | **string** | Not used anymore. | [optional] 
**ReleaseNotes** | **string** | Release notes for this release. | [optional] 
**MandatoryUpdate** | **bool?** | A boolean which determines whether this version should be a mandatory update or not. | [optional] 
**Destinations** | [**List&lt;V01appsownerNameappNamereleasesreleaseIdDestinations&gt;**](V01appsownerNameappNamereleasesreleaseIdDestinations.md) | Distribute this release under the following list of destinations (store groups or distribution groups). | [optional] 
**Build** | [**V01appsownerNameappNamereleasesreleaseIdBuild**](V01appsownerNameappNamereleasesreleaseIdBuild.md) |  | [optional] 
**NotifyTesters** | **bool?** | A boolean which determines whether to notify testers of a new release, default to true. | [optional] [default to true]
**Metadata** | [**V01appsownerNameappNamereleasesreleaseIdMetadata**](V01appsownerNameappNamereleasesreleaseIdMetadata.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

