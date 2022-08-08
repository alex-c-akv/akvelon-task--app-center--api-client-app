# AppCenterApiClientLib.Model.XcodeBranchConfigurationProperties
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProjectOrWorkspacePath** | **string** | Xcode project/workspace path | [optional] 
**PodfilePath** | **string** | Path to CococaPods file, if present | [optional] 
**CartfilePath** | **string** | Path to Carthage file, if present | [optional] 
**ProvisioningProfileEncoded** | **string** |  | [optional] 
**CertificateEncoded** | **string** |  | [optional] 
**ProvisioningProfileFileId** | **string** |  | [optional] 
**CertificateFileId** | **string** |  | [optional] 
**ProvisioningProfileUploadId** | **string** |  | [optional] 
**AppExtensionProvisioningProfileFiles** | [**List&lt;V01appsownerNameappNamebranchesbranchconfigToolsetsXcodeAppExtensionProvisioningProfileFiles&gt;**](V01appsownerNameappNamebranchesbranchconfigToolsetsXcodeAppExtensionProvisioningProfileFiles.md) |  | [optional] 
**CertificateUploadId** | **string** |  | [optional] 
**CertificatePassword** | **string** |  | [optional] 
**Scheme** | **string** |  | [optional] 
**XcodeVersion** | **string** | Xcode version used to build. Available versions can be found in \&quot;/xcode_versions\&quot; API. Default is latest stable version, at the time when the configuration is set. | [optional] 
**ProvisioningProfileFilename** | **string** |  | [optional] 
**CertificateFilename** | **string** |  | [optional] 
**TeamId** | **string** |  | [optional] 
**AutomaticSigning** | **bool?** |  | [optional] 
**XcodeProjectSha** | **string** | The selected pbxproject hash to the repositroy | [optional] 
**ArchiveConfiguration** | **string** | The build configuration of the target to archive | [optional] 
**TargetToArchive** | **string** | The target id of the selected scheme to archive | [optional] 
**ForceLegacyBuildSystem** | **bool?** | Setting this to true forces the build to use Xcode legacy build system. Otherwise, the setting from workspace settings is used. By default new build system is used if workspace setting is not committed to the repository. Only used for iOS React Native app, with Xcode 10.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

