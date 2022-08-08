/* 
 * App Center Client
 *
 * Microsoft Visual Studio App Center API
 *
 * OpenAPI spec version: v0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = AppCenterApiClientLib.Client.SwaggerDateConverter;

namespace AppCenterApiClientLib.Model
{
    /// <summary>
    /// A request containing information for creating a release.
    /// </summary>
    [DataContract]
        public partial class ReleaseCreateRequest :  IEquatable<ReleaseCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseCreateRequest" /> class.
        /// </summary>
        /// <param name="version">The release&#x27;s version.&lt;br&gt; For iOS: CFBundleVersion from info.plist.&lt;br&gt; For Android: android:versionCode from AppManifest.xml. .</param>
        /// <param name="buildVersion">The release&#x27;s short version.&lt;br&gt; For iOS: CFBundleShortVersionString from info.plist.&lt;br&gt; For Android: android:versionName from AppManifest.xml. .</param>
        /// <param name="uniqueIdentifier">The identifier of the app&#x27;s bundle..</param>
        /// <param name="minimumOsVersion">The release&#x27;s minimum required operating system..</param>
        /// <param name="deviceFamily">The release&#x27;s device family..</param>
        /// <param name="languages">The languages supported by the release. Limited to 510 characters in a serialized array..</param>
        /// <param name="fingerprint">MD5 checksum of the release binary. (required).</param>
        /// <param name="size">The release&#x27;s size in bytes. (required).</param>
        /// <param name="packageUrl">The URL to the release&#x27;s binary..</param>
        /// <param name="fileExtension">The file extension of the asset. Does not include the initial period..</param>
        /// <param name="uploadId">The upload id associated with the release, to map to the releases upload table. (required).</param>
        /// <param name="iconAssetId">The assetId associated with the icon uploaded to app center file upload service..</param>
        /// <param name="ipaUuids">A list of UUIDs for architectures for an iOS app..</param>
        /// <param name="provision">provision.</param>
        /// <param name="appexProvisioningProfiles">iOS app extension provisioning profiles included in the release..</param>
        /// <param name="proxyFlow">If true this release was uploaded to the AKS upload proxy.</param>
        public ReleaseCreateRequest(string version = default(string), string buildVersion = default(string), string uniqueIdentifier = default(string), string minimumOsVersion = default(string), string deviceFamily = default(string), List<string> languages = default(List<string>), string fingerprint = default(string), int? size = default(int?), string packageUrl = default(string), string fileExtension = default(string), string uploadId = default(string), string iconAssetId = default(string), List<ReleaseCreateRequestIpaUuids> ipaUuids = default(List<ReleaseCreateRequestIpaUuids>), ReleaseCreateRequestProvision provision = default(ReleaseCreateRequestProvision), List<ReleaseCreateRequestProvision> appexProvisioningProfiles = default(List<ReleaseCreateRequestProvision>), bool? proxyFlow = default(bool?))
        {
            // to ensure "fingerprint" is required (not null)
            if (fingerprint == null)
            {
                throw new InvalidDataException("fingerprint is a required property for ReleaseCreateRequest and cannot be null");
            }
            else
            {
                this.Fingerprint = fingerprint;
            }
            // to ensure "size" is required (not null)
            if (size == null)
            {
                throw new InvalidDataException("size is a required property for ReleaseCreateRequest and cannot be null");
            }
            else
            {
                this.Size = size;
            }
            // to ensure "uploadId" is required (not null)
            if (uploadId == null)
            {
                throw new InvalidDataException("uploadId is a required property for ReleaseCreateRequest and cannot be null");
            }
            else
            {
                this.UploadId = uploadId;
            }
            this.Version = version;
            this.BuildVersion = buildVersion;
            this.UniqueIdentifier = uniqueIdentifier;
            this.MinimumOsVersion = minimumOsVersion;
            this.DeviceFamily = deviceFamily;
            this.Languages = languages;
            this.PackageUrl = packageUrl;
            this.FileExtension = fileExtension;
            this.IconAssetId = iconAssetId;
            this.IpaUuids = ipaUuids;
            this.Provision = provision;
            this.AppexProvisioningProfiles = appexProvisioningProfiles;
            this.ProxyFlow = proxyFlow;
        }
        
        /// <summary>
        /// The release&#x27;s version.&lt;br&gt; For iOS: CFBundleVersion from info.plist.&lt;br&gt; For Android: android:versionCode from AppManifest.xml. 
        /// </summary>
        /// <value>The release&#x27;s version.&lt;br&gt; For iOS: CFBundleVersion from info.plist.&lt;br&gt; For Android: android:versionCode from AppManifest.xml. </value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// The release&#x27;s short version.&lt;br&gt; For iOS: CFBundleShortVersionString from info.plist.&lt;br&gt; For Android: android:versionName from AppManifest.xml. 
        /// </summary>
        /// <value>The release&#x27;s short version.&lt;br&gt; For iOS: CFBundleShortVersionString from info.plist.&lt;br&gt; For Android: android:versionName from AppManifest.xml. </value>
        [DataMember(Name="build_version", EmitDefaultValue=false)]
        public string BuildVersion { get; set; }

        /// <summary>
        /// The identifier of the app&#x27;s bundle.
        /// </summary>
        /// <value>The identifier of the app&#x27;s bundle.</value>
        [DataMember(Name="unique_identifier", EmitDefaultValue=false)]
        public string UniqueIdentifier { get; set; }

        /// <summary>
        /// The release&#x27;s minimum required operating system.
        /// </summary>
        /// <value>The release&#x27;s minimum required operating system.</value>
        [DataMember(Name="minimum_os_version", EmitDefaultValue=false)]
        public string MinimumOsVersion { get; set; }

        /// <summary>
        /// The release&#x27;s device family.
        /// </summary>
        /// <value>The release&#x27;s device family.</value>
        [DataMember(Name="device_family", EmitDefaultValue=false)]
        public string DeviceFamily { get; set; }

        /// <summary>
        /// The languages supported by the release. Limited to 510 characters in a serialized array.
        /// </summary>
        /// <value>The languages supported by the release. Limited to 510 characters in a serialized array.</value>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<string> Languages { get; set; }

        /// <summary>
        /// MD5 checksum of the release binary.
        /// </summary>
        /// <value>MD5 checksum of the release binary.</value>
        [DataMember(Name="fingerprint", EmitDefaultValue=false)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// The release&#x27;s size in bytes.
        /// </summary>
        /// <value>The release&#x27;s size in bytes.</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }

        /// <summary>
        /// The URL to the release&#x27;s binary.
        /// </summary>
        /// <value>The URL to the release&#x27;s binary.</value>
        [DataMember(Name="package_url", EmitDefaultValue=false)]
        public string PackageUrl { get; set; }

        /// <summary>
        /// The file extension of the asset. Does not include the initial period.
        /// </summary>
        /// <value>The file extension of the asset. Does not include the initial period.</value>
        [DataMember(Name="file_extension", EmitDefaultValue=false)]
        public string FileExtension { get; set; }

        /// <summary>
        /// The upload id associated with the release, to map to the releases upload table.
        /// </summary>
        /// <value>The upload id associated with the release, to map to the releases upload table.</value>
        [DataMember(Name="upload_id", EmitDefaultValue=false)]
        public string UploadId { get; set; }

        /// <summary>
        /// The assetId associated with the icon uploaded to app center file upload service.
        /// </summary>
        /// <value>The assetId associated with the icon uploaded to app center file upload service.</value>
        [DataMember(Name="icon_asset_id", EmitDefaultValue=false)]
        public string IconAssetId { get; set; }

        /// <summary>
        /// A list of UUIDs for architectures for an iOS app.
        /// </summary>
        /// <value>A list of UUIDs for architectures for an iOS app.</value>
        [DataMember(Name="ipa_uuids", EmitDefaultValue=false)]
        public List<ReleaseCreateRequestIpaUuids> IpaUuids { get; set; }

        /// <summary>
        /// Gets or Sets Provision
        /// </summary>
        [DataMember(Name="provision", EmitDefaultValue=false)]
        public ReleaseCreateRequestProvision Provision { get; set; }

        /// <summary>
        /// iOS app extension provisioning profiles included in the release.
        /// </summary>
        /// <value>iOS app extension provisioning profiles included in the release.</value>
        [DataMember(Name="appex_provisioning_profiles", EmitDefaultValue=false)]
        public List<ReleaseCreateRequestProvision> AppexProvisioningProfiles { get; set; }

        /// <summary>
        /// If true this release was uploaded to the AKS upload proxy
        /// </summary>
        /// <value>If true this release was uploaded to the AKS upload proxy</value>
        [DataMember(Name="proxy_flow", EmitDefaultValue=false)]
        public bool? ProxyFlow { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReleaseCreateRequest {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  BuildVersion: ").Append(BuildVersion).Append("\n");
            sb.Append("  UniqueIdentifier: ").Append(UniqueIdentifier).Append("\n");
            sb.Append("  MinimumOsVersion: ").Append(MinimumOsVersion).Append("\n");
            sb.Append("  DeviceFamily: ").Append(DeviceFamily).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  PackageUrl: ").Append(PackageUrl).Append("\n");
            sb.Append("  FileExtension: ").Append(FileExtension).Append("\n");
            sb.Append("  UploadId: ").Append(UploadId).Append("\n");
            sb.Append("  IconAssetId: ").Append(IconAssetId).Append("\n");
            sb.Append("  IpaUuids: ").Append(IpaUuids).Append("\n");
            sb.Append("  Provision: ").Append(Provision).Append("\n");
            sb.Append("  AppexProvisioningProfiles: ").Append(AppexProvisioningProfiles).Append("\n");
            sb.Append("  ProxyFlow: ").Append(ProxyFlow).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReleaseCreateRequest);
        }

        /// <summary>
        /// Returns true if ReleaseCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ReleaseCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReleaseCreateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.BuildVersion == input.BuildVersion ||
                    (this.BuildVersion != null &&
                    this.BuildVersion.Equals(input.BuildVersion))
                ) && 
                (
                    this.UniqueIdentifier == input.UniqueIdentifier ||
                    (this.UniqueIdentifier != null &&
                    this.UniqueIdentifier.Equals(input.UniqueIdentifier))
                ) && 
                (
                    this.MinimumOsVersion == input.MinimumOsVersion ||
                    (this.MinimumOsVersion != null &&
                    this.MinimumOsVersion.Equals(input.MinimumOsVersion))
                ) && 
                (
                    this.DeviceFamily == input.DeviceFamily ||
                    (this.DeviceFamily != null &&
                    this.DeviceFamily.Equals(input.DeviceFamily))
                ) && 
                (
                    this.Languages == input.Languages ||
                    this.Languages != null &&
                    input.Languages != null &&
                    this.Languages.SequenceEqual(input.Languages)
                ) && 
                (
                    this.Fingerprint == input.Fingerprint ||
                    (this.Fingerprint != null &&
                    this.Fingerprint.Equals(input.Fingerprint))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.PackageUrl == input.PackageUrl ||
                    (this.PackageUrl != null &&
                    this.PackageUrl.Equals(input.PackageUrl))
                ) && 
                (
                    this.FileExtension == input.FileExtension ||
                    (this.FileExtension != null &&
                    this.FileExtension.Equals(input.FileExtension))
                ) && 
                (
                    this.UploadId == input.UploadId ||
                    (this.UploadId != null &&
                    this.UploadId.Equals(input.UploadId))
                ) && 
                (
                    this.IconAssetId == input.IconAssetId ||
                    (this.IconAssetId != null &&
                    this.IconAssetId.Equals(input.IconAssetId))
                ) && 
                (
                    this.IpaUuids == input.IpaUuids ||
                    this.IpaUuids != null &&
                    input.IpaUuids != null &&
                    this.IpaUuids.SequenceEqual(input.IpaUuids)
                ) && 
                (
                    this.Provision == input.Provision ||
                    (this.Provision != null &&
                    this.Provision.Equals(input.Provision))
                ) && 
                (
                    this.AppexProvisioningProfiles == input.AppexProvisioningProfiles ||
                    this.AppexProvisioningProfiles != null &&
                    input.AppexProvisioningProfiles != null &&
                    this.AppexProvisioningProfiles.SequenceEqual(input.AppexProvisioningProfiles)
                ) && 
                (
                    this.ProxyFlow == input.ProxyFlow ||
                    (this.ProxyFlow != null &&
                    this.ProxyFlow.Equals(input.ProxyFlow))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.BuildVersion != null)
                    hashCode = hashCode * 59 + this.BuildVersion.GetHashCode();
                if (this.UniqueIdentifier != null)
                    hashCode = hashCode * 59 + this.UniqueIdentifier.GetHashCode();
                if (this.MinimumOsVersion != null)
                    hashCode = hashCode * 59 + this.MinimumOsVersion.GetHashCode();
                if (this.DeviceFamily != null)
                    hashCode = hashCode * 59 + this.DeviceFamily.GetHashCode();
                if (this.Languages != null)
                    hashCode = hashCode * 59 + this.Languages.GetHashCode();
                if (this.Fingerprint != null)
                    hashCode = hashCode * 59 + this.Fingerprint.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.PackageUrl != null)
                    hashCode = hashCode * 59 + this.PackageUrl.GetHashCode();
                if (this.FileExtension != null)
                    hashCode = hashCode * 59 + this.FileExtension.GetHashCode();
                if (this.UploadId != null)
                    hashCode = hashCode * 59 + this.UploadId.GetHashCode();
                if (this.IconAssetId != null)
                    hashCode = hashCode * 59 + this.IconAssetId.GetHashCode();
                if (this.IpaUuids != null)
                    hashCode = hashCode * 59 + this.IpaUuids.GetHashCode();
                if (this.Provision != null)
                    hashCode = hashCode * 59 + this.Provision.GetHashCode();
                if (this.AppexProvisioningProfiles != null)
                    hashCode = hashCode * 59 + this.AppexProvisioningProfiles.GetHashCode();
                if (this.ProxyFlow != null)
                    hashCode = hashCode * 59 + this.ProxyFlow.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
