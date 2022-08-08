# AppCenterApiClientLib.Model.LogFlowDevice
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SdkName** | **string** | Name of the SDK. Consists of the name of the SDK and the platform, e.g. \&quot;appcenter.ios\&quot;, \&quot;hockeysdk.android\&quot;.  | 
**SdkVersion** | **string** | Version of the SDK in semver format, e.g. \&quot;1.2.0\&quot; or \&quot;0.12.3-alpha.1\&quot;.  | 
**WrapperSdkVersion** | **string** | Version of the wrapper SDK in semver format. When the SDK is embedding another base SDK (for example Xamarin.Android wraps Android), the Xamarin specific version is populated into this field while sdkVersion refers to the original Android SDK.  | [optional] 
**WrapperSdkName** | **string** | Name of the wrapper SDK. Consists of the name of the SDK and the wrapper platform, e.g. \&quot;appcenter.xamarin\&quot;, \&quot;hockeysdk.cordova\&quot;.  | [optional] 
**Model** | **string** | Device model (example: iPad2,3).  | [optional] 
**OemName** | **string** | Device manufacturer (example: HTC).  | [optional] 
**OsName** | **string** | OS name (example: iOS). The following OS names are standardized (non-exclusive): Android, iOS, macOS, tvOS, Windows.  | 
**OsVersion** | **string** | OS version (example: 9.3.0).  | 
**OsBuild** | **string** | OS build code (example: LMY47X).  | [optional] 
**OsApiLevel** | **int?** | API level when applicable like in Android (example: 15).  | [optional] 
**Locale** | **string** | Language code (example: en_US).  | 
**TimeZoneOffset** | **int?** | The offset in minutes from UTC for the device time zone, including daylight savings time.  | 
**ScreenSize** | **string** | Screen size of the device in pixels (example: 640x480).  | [optional] 
**AppVersion** | **string** | Application version name, e.g. 1.1.0  | 
**CarrierName** | **string** | Carrier name (for mobile devices).  | [optional] 
**CarrierCode** | **string** | Carrier country code (for mobile devices).  | [optional] 
**CarrierCountry** | **string** | Carrier country.  | [optional] 
**AppBuild** | **string** | The app&#x27;s build number, e.g. 42.  | 
**AppNamespace** | **string** | The bundle identifier, package identifier, or namespace, depending on what the individual plattforms use,  .e.g com.microsoft.example.  | [optional] 
**LiveUpdateReleaseLabel** | **string** | Label that is used to identify application code &#x27;version&#x27; released via Live Update beacon running on device  | [optional] 
**LiveUpdateDeploymentKey** | **string** | Identifier of environment that current application release belongs to, deployment key then maps to environment like Production, Staging.  | [optional] 
**LiveUpdatePackageHash** | **string** | Hash of all files (ReactNative or Cordova) deployed to device via LiveUpdate beacon. Helps identify the Release version on device or need to download updates in future.  | [optional] 
**WrapperRuntimeVersion** | **string** | Version of the wrapper technology framework (Xamarin runtime version or ReactNative or Cordova etc...). See wrapper_sdk_name to see if this version refers to Xamarin or ReactNative or other.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

